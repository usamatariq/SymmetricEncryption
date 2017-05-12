Public Interface ICipher

    WriteOnly Property Key As String

    Function Encrypt(ByVal input() As Byte) As Byte()
    'Function Encrypt(ByVal data As Byte(), ByVal index As Integer) As Byte()

    Function Decrypt(ByVal input() As Byte) As Byte()
    'Function Decrypt(ByVal data As Byte(), ByVal index As Integer) As Byte()

End Interface
