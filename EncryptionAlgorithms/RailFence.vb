Imports System.Text

Public Class RailFence

    Private _rails As Integer = 0

    Public Sub New(ByVal rails As Integer)
        _rails = rails
    End Sub

    Public Function Decrypt(ByVal input As String) As String
        Return Decrypt(_rails, input)
    End Function

    Public Function Encrypt(ByVal input As String) As String
        Return Encrypt(_rails, input)
    End Function


    Public Shared Function Encrypt(ByVal rail As Integer, ByVal plainText As String) As String
        Dim railFence As New List(Of String)()
        For i As Integer = 0 To rail - 1
            railFence.Add("")
        Next

        Dim number As Integer = 0
        Dim increment As Integer = 1
        For Each c As Char In plainText
            If number + increment = rail Then
                increment = -1
            ElseIf number + increment = -1 Then
                increment = 1
            End If
            railFence(number) += c
            number += increment
        Next

        Dim buffer As String = ""
        For Each s As String In railFence
            buffer += s
        Next
        Return buffer
    End Function



    Public Shared Function Decrypt(ByVal rail As Integer, ByVal cipherText As String) As String
        Dim cipherLength As Integer = cipherText.Length
        Dim railFence As New List(Of List(Of Integer))()
        For i As Integer = 0 To rail - 1
            railFence.Add(New List(Of Integer)())
        Next

        Dim number As Integer = 0
        Dim increment As Integer = 1
        For i As Integer = 0 To cipherLength - 1
            If number + increment = rail Then
                increment = -1
            ElseIf number + increment = -1 Then
                increment = 1
            End If
            railFence(number).Add(i)
            number += increment
        Next

        Dim counter As Integer = 0
        Dim buffer As Char() = New Char(cipherLength - 1) {}
        For i As Integer = 0 To rail - 1
            For j As Integer = 0 To railFence(i).Count - 1
                buffer(railFence(i)(j)) = cipherText(counter)
                counter += 1
            Next
        Next

        Return New String(buffer)
    End Function
End Class
