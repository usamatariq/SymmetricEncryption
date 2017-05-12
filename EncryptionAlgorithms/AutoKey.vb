Imports System.Text

Public Class AutoKey
    Dim _key As String
    Dim _longKey As Byte()
    Public Sub New(ByVal key As String)
        If (String.IsNullOrEmpty(key)) Then
            Throw New Exception("Invalid Key. Key can not be null string for AutoKey cipher.")
        End If
        key = key.Replace(" ", "")
        key = key.Trim()
        key = key.ToUpper()
        _key = key
    End Sub

    Private Function getKey(ByVal index As Integer, ByVal input As Byte()) As Byte
        Dim i As Integer = index
        If (i >= _key.Length) Then
            _key = _key + Chr(input(index - _key.Length))
            _longKey = Encoding.ASCII.GetBytes(_key)
        End If
        If (_longKey(i) >= Asc("A") And _longKey(i) <= Asc("Z")) Then
            Return _longKey(i) - Asc("A")
        ElseIf (_longKey(i) >= Asc("a") And _longKey(i) <= Asc("z")) Then
            Return _longKey(i) - Asc("a")
        End If
        Throw New Exception("Invalid Key. Only alphabetic characters are allowed as key for AutoKey cipher.")
    End Function

    Public Function Decrypt(ByVal input As String) As String
        input = input.ToUpper()
        Dim lk As String = input.Replace(" ", "")
        lk = lk.Trim()
        _longKey = Encoding.ASCII.GetBytes(_key + lk)
        Return Encoding.ASCII.GetString(Transform(Encoding.ASCII.GetBytes(input), Mode.Decrypt))
    End Function

    Public Function Encrypt(ByVal input As String) As String
        input = input.Replace(" ", "")
        input = input.Trim()
        input = input.ToUpper()

        Dim lk As String = input.Replace(" ", "")
        lk = lk.Trim()
        _longKey = Encoding.ASCII.GetBytes(_key + lk)
        Return Encoding.ASCII.GetString(Transform(Encoding.ASCII.GetBytes(input), Mode.Encrypt))
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
                result(i) = (result(i) + getKey(i, data)) Mod 26
            Else
                result(i) = CByte((CInt(26) + CInt(CInt(result(i)) - CInt(getKey(i, result)))) Mod 26)
            End If
            result(i) = result(i) + shift
        Next

        Return result
    End Function
End Class
