Imports System.Text


Public Class OneTimePad
    Implements ICipher

    Private _key As Byte()

    Public WriteOnly Property Key As String Implements ICipher.Key
        Set(ByVal value As String)
            _key = Encoding.ASCII.GetBytes(value)
        End Set
    End Property

    Private Function getKey(ByVal index As Integer) As Byte
        If (index >= _key.Length) Then
            Throw New Exception("Invalid key. For One Time Pad cipher, key length must be equal or greater than data length.")
        End If
        Dim i As Integer = index
        If (_key(i) >= Asc("A") And _key(i) <= Asc("Z")) Then
            Return _key(i) - Asc("A")
        ElseIf (_key(i) >= Asc("a") And _key(i) <= Asc("z")) Then
            Return _key(i) - Asc("a")
        End If
        Throw New Exception("Invalid Key. Only alphabetic characters are allowed as key for One Time Pad cipher.")
    End Function

    Public Function Decrypt(ByVal input() As Byte) As Byte() Implements ICipher.Decrypt
        Return Transform(input, Mode.Decrypt)
    End Function

    Public Function Encrypt(ByVal input() As Byte) As Byte() Implements ICipher.Encrypt
        Return Transform(input, Mode.Encrypt)
    End Function

    Private Function Transform(ByVal data As Byte(), ByVal mode As Mode) As Byte()
        Dim shift As Integer = 0
        Dim result(data.Length) As Byte

        For i As Integer = 0 To data.Length - 1
            If (data(i) >= Asc("A") And data(i) <= Asc("Z")) Then
                result(i) = data(i) - Asc("A")
                shift = Asc("A")
            ElseIf (data(i) >= Asc("a") And data(i) <= Asc("z")) Then
                result(i) = data(i) - Asc("a")
                shift = Asc("a")
            Else
                result(i) = data(i)
                Continue For
            End If

            If (mode = mode.Encrypt) Then
                result(i) = (result(i) + getKey(i)) Mod 26
            Else
                result(i) = CByte((CInt(26) + CInt(CInt(result(i)) - CInt(getKey(i)))) Mod 26)
            End If
            result(i) = result(i) + shift
        Next
        
        Return result
    End Function


End Class
