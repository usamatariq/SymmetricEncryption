Imports System.Text

Public Class VernamCipher
    Implements ICipher

    Private _key As Integer
    Private _random As Random

    Public WriteOnly Property Key As String Implements ICipher.Key
        Set(ByVal value As String)
            Try
                _key = Integer.Parse(value)
            Catch ex As Exception
                Throw New Exception("Invalid key. Key must be an integer. Given key will be used as seed to generate psudo random key for Vernam Cipher.")
            End Try
        End Set
    End Property

    Public Function Decrypt(ByVal input() As Byte) As Byte() Implements ICipher.Decrypt
        Return Transform(input, Mode.Decrypt)
    End Function

    Public Function Encrypt(ByVal input() As Byte) As Byte() Implements ICipher.Encrypt
        Return Transform(input, Mode.Encrypt)
    End Function

    Private Function Transform(ByVal data As Byte(), ByVal mode As Mode) As Byte()
        Dim shift As Integer = 0
        Dim result(data.Length) As Byte
        _random = New Random(_key)
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
                result(i) = (result(i) + _random.Next(0, 25)) Mod 26
            Else
                result(i) = CByte((CInt(26) + CInt(CInt(result(i)) - _random.Next(0, 25))) Mod 26)
            End If
            result(i) = result(i) + shift
        Next

        Return result
    End Function
End Class
