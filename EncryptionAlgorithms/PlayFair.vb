

Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class PlayFair
    Private key As String
    Dim alphabet As Dictionary(Of Char, Integer)

    Public Sub New(ByVal key As String)
        Me.key = key
        alphabet = New Dictionary(Of Char, Integer)()
        Dim c As Char = "a"c
        alphabet.Add(c, 0)

        For i As Integer = 1 To 25
            c = Chr(Asc(c) + 1)
            alphabet.Add(c, i)
        Next
    End Sub

#Region "Public Methods"

    Public Function Encrypt(ByVal plainText As String) As String
        plainText = plainText.Replace(" ", "")
        plainText = plainText.Trim()
        plainText = plainText.ToLower()
        Return Process(plainText, Mode.Encrypt).ToUpper()
    End Function

    Public Function Decrypt(ByVal cipherText As String) As String
        cipherText = cipherText.Replace(" ", "")
        cipherText = cipherText.Trim()
        cipherText = cipherText.ToLower()
        Return Process(cipherText, Mode.Decrypt).ToUpper()
    End Function

#End Region

#Region "Private Methods"

    Private Function Process(ByVal message As String, ByVal mode__1 As Mode) As String
        'Key:Charcater
        'Value:Position
        Dim characterPositionsInMatrix As New Dictionary(Of Char, String)()

        'Key:Position
        'Value:Charcater
        Dim positionCharacterInMatrix As New Dictionary(Of String, Char)()

        FillMatrix(key.Distinct().ToArray(), characterPositionsInMatrix, positionCharacterInMatrix)

        If mode__1 = Mode.Encrypt Then
            message = RepairWord(message)
        End If

        Dim result As String = ""

        For i As Integer = 0 To message.Length - 1 Step 2
            Dim substring_of_2 As String = message.Substring(i, 2)
            'get characters from text by pairs
            'get Row & Column of each character
            Dim rc1 As String = characterPositionsInMatrix(substring_of_2(0))
            Dim rc2 As String = characterPositionsInMatrix(substring_of_2(1))

            If rc1(0) = rc2(0) Then
                'Same Row, different Column
                Dim newC1 As Integer = 0, newC2 As Integer = 0

                Select Case mode__1
                    Case Mode.Encrypt
                        'Increment Columns
                        newC1 = (Integer.Parse(rc1(1).ToString()) + 1) Mod 5
                        newC2 = (Integer.Parse(rc2(1).ToString()) + 1) Mod 5
                        Exit Select
                    Case Mode.Decrypt
                        'Decrement Columns
                        newC1 = (Integer.Parse(rc1(1).ToString()) - 1) Mod 5
                        newC2 = (Integer.Parse(rc2(1).ToString()) - 1) Mod 5
                        Exit Select
                End Select

                newC1 = RepairNegative(newC1)
                newC2 = RepairNegative(newC2)

                result += positionCharacterInMatrix(rc1(0).ToString() + newC1.ToString())
                result += positionCharacterInMatrix(rc2(0).ToString() + newC2.ToString())

            ElseIf rc1(1) = rc2(1) Then
                'Same Column, different Row
                Dim newR1 As Integer = 0, newR2 As Integer = 0

                Select Case mode__1
                    Case Mode.Encrypt
                        'Increment Rows
                        newR1 = (Integer.Parse(rc1(0).ToString()) + 1) Mod 5
                        newR2 = (Integer.Parse(rc2(0).ToString()) + 1) Mod 5
                        Exit Select
                    Case Mode.Decrypt
                        'Decrement Rows
                        newR1 = (Integer.Parse(rc1(0).ToString()) - 1) Mod 5
                        newR2 = (Integer.Parse(rc2(0).ToString()) - 1) Mod 5
                        Exit Select
                End Select
                newR1 = RepairNegative(newR1)
                newR2 = RepairNegative(newR2)

                result += positionCharacterInMatrix(newR1.ToString() + rc1(1).ToString())
                result += positionCharacterInMatrix(newR2.ToString() + rc2(1).ToString())
            Else
                'different Row & Column
                '1st character:row of 1st + col of 2nd
                '2nd character:row of 2nd + col of 1st
                result += positionCharacterInMatrix(rc1(0).ToString() + rc2(1).ToString())
                result += positionCharacterInMatrix(rc2(0).ToString() + rc1(1).ToString())
            End If
        Next

        Return result
    End Function

    Private Function RepairWord(ByVal message As String) As String
        Dim trimmed As String = message.Replace(" ", "")
        Dim result As String = ""

        For i As Integer = 0 To trimmed.Length - 1
            result += trimmed(i)

            If i < trimmed.Length - 1 AndAlso message(i) = message(i + 1) Then
                'check if two consecutive letters are the same
                result += "x"c
            End If
        Next

        If result.Length Mod 2 <> 0 Then
            'check if length is even
            result += "x"c
        End If

        Return result
    End Function

    Private Sub FillMatrix(ByVal key As IList(Of Char), ByVal characterPositionsInMatrix As Dictionary(Of Char, String), ByVal positionCharacterInMatrix As Dictionary(Of String, Char))
        Dim matrix As Char(,) = New Char(4, 4) {}
        Dim keyPosition As Integer = 0, charPosition As Integer = 0
        Dim alphabetPF As List(Of Char) = alphabet.Keys.ToList()
        alphabetPF.Remove("j"c)

        For i As Integer = 0 To 4
            For j As Integer = 0 To 4
                If charPosition < key.Count Then
                    matrix(i, j) = key(charPosition)
                    'fill matrix with key
                    alphabetPF.Remove(key(charPosition))
                    charPosition += 1
                Else

                    'key finished...fill with rest of alphabet
                    matrix(i, j) = alphabetPF(keyPosition)
                    keyPosition += 1
                End If

                Dim position As String = i.ToString() + j.ToString()
                'store character positions in dictionary to avoid searching everytime
                characterPositionsInMatrix.Add(matrix(i, j), position)
                positionCharacterInMatrix.Add(position, matrix(i, j))
            Next
        Next
    End Sub

    Private Function RepairNegative(ByVal number As Integer) As Integer
        If number < 0 Then
            number += 5
        End If

        Return number
    End Function

#End Region
End Class

