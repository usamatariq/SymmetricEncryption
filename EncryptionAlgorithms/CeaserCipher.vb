Public Class CeaserCipher
    Private _shift As Integer = 0
    Public Property Shift As Integer
        Set(ByVal value As Integer)
            While (value < 0)
                value += 26
            End While
            _shift = value
        End Set
        Get
            Return _shift
        End Get
    End Property

    'encrypts input according to ceaser cipher algorithm
    Public Function Encrypt(ByVal input() As Byte) As Byte()
        Return Transform(input, _shift)
    End Function

    'decrypts input according to ceaser cipher
    Public Function Decrypt(ByVal input() As Byte) As Byte()
        'a negative shift is same as a shift of 26-shift
        Return Transform(input, 26 - _shift)
    End Function

    'Applys a shift to the alphabetic characters in input according to ceaser cipher
    Private Function Transform(ByVal input() As Byte, ByVal shift As Integer) As Byte()
        Dim output(input.Length - 1) As Byte
        For i As Integer = 0 To input.Length - 1
            If (input(i) >= Asc("a") And input(i) <= Asc("z")) Then
                output(i) = (((input(i) - Asc("a") + shift)) Mod 26) + Asc("a")
            ElseIf (input(i) >= Asc("A") And input(i) <= Asc("Z")) Then
                output(i) = (((input(i) - Asc("A") + shift)) Mod 26) + Asc("A")
            Else
                output(i) = input(i)
            End If
        Next
        Return output
    End Function
End Class
