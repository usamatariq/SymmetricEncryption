Imports System.Text

Public Class MonoAlphabetic
    Private _key As Byte()

    Public Sub New(ByVal key As String)
        key = key.ToUpper()
        If (key.Length <> 26) Then
            Throw New Exception("Invalid key. For mono-alphabetic cipher Key length must be 26 characters long and contain all alphabets (A-Z).")
        End If
        _key = Encoding.ASCII.GetBytes(key)
        For i As Integer = 0 To 25
            If (_key.Contains(i + Asc("A")) = False) Then
                Throw New Exception("Invalid key. For mono-alphabetic cipher, key must contain all alphabets (A-Z).")
            End If
        Next
    End Sub

    Public WriteOnly Property Key As String
        Set(ByVal value As String)
            _key = Encoding.ASCII.GetBytes(value.ToUpper())
        End Set
    End Property

    Private Function getKey(ByVal input As Integer, ByVal mode As Mode) As Byte
        If (input >= _key.Length) Then
            Throw New Exception("Invalid key. For mono-alphabetic cipher Key length must be 26 characters long and contain all alphabets (A-Z).")
        End If
        If (mode = mode.Encrypt) Then
            Dim i As Integer = input
            If (_key(i) >= Asc("A") And _key(i) <= Asc("Z")) Then
                Return _key(i) - Asc("A")
            End If
        Else
            Return Array.IndexOf(_key, CByte(input + Asc("A")))
        End If


        Throw New Exception("Invalid Key.  For mono-alphabetic cipher, key must contain all alphabets (A-Z).")
    End Function

    Public Function Decrypt(ByVal input As String) As String
        Return Encoding.ASCII.GetString(Decrypt(Encoding.ASCII.GetBytes(input.ToUpper())))
    End Function

    Public Function Decrypt(ByVal input() As Byte) As Byte()
        Return Transform(input, Mode.Decrypt)
    End Function




    Public Function Encrypt(ByVal input As String) As String
        Return Encoding.ASCII.GetString(Encrypt(Encoding.ASCII.GetBytes(input.ToUpper())))
    End Function

    Public Function Encrypt(ByVal input() As Byte) As Byte()
        Return Transform(input, Mode.Encrypt)
    End Function

    Private Function Transform(ByVal data As Byte(), ByVal mode As Mode) As Byte()
        Dim shift As Integer = 0
        Dim result(data.Length) As Byte

        For i As Integer = 0 To data.Length - 1
            If (data(i) >= Asc("A") And data(i) <= Asc("Z")) Then
                result(i) = data(i) - Asc("A")
                shift = Asc("A")
            Else
                result(i) = data(i)
                Continue For
            End If


            If (mode = mode.Encrypt) Then
                result(i) = getKey(result(i), mode.Encrypt)
            Else
                result(i) = getKey(result(i), mode.Decrypt)
            End If
            result(i) = result(i) + shift
        Next

        Return result
    End Function
End Class
