﻿Imports System.Text

Public Class PlayFairCipher
    Implements ICipher

    Private _key(5, 5) As Byte

    Public WriteOnly Property Key As String Implements ICipher.Key
        Set(ByVal value As String)
            value = value.ToLower()
            Dim key As String
            For i As Integer = 0 To value.Length - 1
                If (key.Contains(value.Substring(i, 1)) = False) Then
                    key = key.Concat(value.Substring(i, 1))
                End If
            Next

            For ch As Integer = Asc("a") To Asc("z")
                If (key.Contains(ch.ToString()) = False) Then
                    key = key.Concat(ch.ToString())
                End If
            Next

            For i As Integer = 0 To 4
                For j As Integer = 0 To 4
                    _key(i, j) = AscW(key.Chars(j + i * 5))
                Next
            Next
        End Set
    End Property

    Private Function getKey(ByVal index As Integer) As Byte
        Dim i As Integer = index Mod _key.Length
        If (_key(i) >= Asc("A") And _key(i) <= Asc("Z")) Then
            Return _key(i) - Asc("A")
        ElseIf (_key(i) >= Asc("a") And _key(i) <= Asc("z")) Then
            Return _key(i) - Asc("a")
        End If
        Throw New Exception("Invalid Key.")
    End Function
    Public Function Decrypt(ByVal input() As Byte) As Byte() Implements ICipher.Decrypt
        Return Transform(input, Mode.Decrypt)
    End Function

    'Public Function Decrypt(ByVal data() As Byte, ByVal index As Integer) As Byte() Implements ICipher.Decrypt
    '    Dim result(data.Length - index - 1) As Byte
    '    For i As Integer = index To data.Length
    '        result(i - index) = (data(i) + getKey(i - index)) Mod 26
    '    Next
    'End Function

    Public Function Encrypt(ByVal input() As Byte) As Byte() Implements ICipher.Encrypt
        Return Transform(input, Mode.Encrypt)
    End Function

    'Public Function Encrypt(ByVal data() As Byte, ByVal index As Integer) As Byte() Implements ICipher.Encrypt

    'End Function

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
