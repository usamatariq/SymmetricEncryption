Namespace EncryptionAlgorithms.Util
End Namespace

Public Class Block
    Private _size As Short = 64
    Private _value As ULong = 0

    Public Property Size As Short
        Set(ByVal value As Short)
            If (value > 64 Or value < 0) Then
                Throw New InvalidExpressionException("Size must be between 1 and 64")
            End If
            _size = value
        End Set
        Get
            Return _size
        End Get
    End Property

    Public Property Value As ULong
        Set(ByVal value As ULong)
            _value = value
        End Set
        Get
            Return _value
        End Get
    End Property

    Public Sub Block(ByVal size As Short)
        _size = size
    End Sub

    Public Sub Initialize(ByVal data() As Byte, Optional ByVal index As Integer = 0)
        If (data.Length - index < 8) Then
            Throw New Exception("Data must be atleast 8 byte long than index.")
        End If
        For i As Integer = 0 To 7
            _value = (CULng(data(index + i)) << 56 - (i * 8)) Or _value
        Next
    End Sub

    Public Sub LeftShift(Optional ByVal places As Integer = 1)
        _value = _value << places
        _value = _value And CULng((2 ^ Size) - 1)
    End Sub

    Public Sub LeftCircularShift(Optional ByVal places As Integer = 1)
        Dim temp As ULong = (2 ^ places) - 1
        temp = temp << (_size - places)
        temp = _value And temp
        temp = temp >> (_size - places)
        _value = _value << places
        _value = _value Or temp
        _value = _value And CULng((2 ^ Size) - 1)
    End Sub

    Public Sub RightShift(Optional ByVal places As Integer = 1)
        _value = _value >> places
        _value = _value And CULng((2 ^ Size) - 1)
    End Sub

    Public Sub RightCircularShift(Optional ByVal places As Integer = 1)
        Dim temp As ULong = (2 ^ places) - 1
        temp = _value And temp
        temp = temp << (_size - 1)
        _value = _value >> places
        _value = _value Or temp
        _value = _value And (2 ^ Size) - 1
        _value = _value And CULng((2 ^ Size) - 1)
    End Sub

    Public Sub SwapBit(ByVal source As Short, ByVal destination As Short)
        Dim srcBit As ULong = 2 ^ source
        Dim destBit As ULong = 2 ^ destination

        'get src and dest bit
        srcBit = _value And srcBit
        destBit = _value And destBit

        'clear src and dest bits (other bits will remain as is)
        Dim notSrc As ULong = Not srcBit
        Dim notDst As ULong = Not destBit
        _value = _value And notSrc
        _value = _value And notDst

        'find difference b/w position of src and dest, -ve difference if dest is on right side
        Dim shift As Short = destination - source

        'swap locations of src and dst bits
        srcBit = srcBit << shift
        destBit = destBit >> shift

        'swap location in value
        _value = _value Or srcBit
        _value = _value Or destBit
    End Sub

    Sub CopyBit(ByVal from As Block, ByVal fromIndex As Short, ByVal toIndex As Short)
        fromIndex = (from._size - fromIndex) - 1
        toIndex = (_size - toIndex) - 1
        Dim srcBit As ULong = 1
        srcBit = srcBit << fromIndex
        Dim destBit As ULong = 1
        destBit = destBit << toIndex

        'get src bit
        srcBit = from._value And srcBit

        'clear dest bits (other bits will remain as is)
        Dim notDst As ULong = Not destBit
        _value = _value And notDst

        'find difference b/w position of src and dest, -ve difference if dest is on right side
        Dim shift As Short = (toIndex - fromIndex)

        If (shift > 0) Then
            'shift location of src and dst bit
            srcBit = srcBit << shift
        Else
            srcBit = srcBit >> Math.Abs(shift)
        End If
        'copy in value
        _value = _value Or srcBit
    End Sub

    Function Clone() As Block
        Dim b As Block = New Block()
        b._size = Me._size
        b._value = Me._value
        Return b
    End Function

    Public Shared Function Combine(ByVal block1 As Block, ByVal block2 As Block) As Block
        Dim block As Block = New Block()
        block.Size = block1.Size + block2.Size
        block._value = (block1._value << (block2.Size)) Or (block2._value)
        Return block
    End Function

    Public Function ExclusiveOR(ByVal block As Block) As Block
        If (Me.Size <> block.Size) Then
            Throw New Exception("Invalid argument. Size must be same for XOR")
        End If
        Dim result As Block = New Block()
        result.Size = Me.Size
        result._value = Me._value Xor block._value
        Return result
    End Function

    Public Function GetLong(ByVal noOfBits As Integer, ByVal index As Integer) As ULong
        Dim result As ULong = _value
        index = (_size - index) - 1
        If (index < 0 Or (index - noOfBits) < -1) Then
            Throw New Exception("Invalid operation.")
        End If
        result = result >> (index - noOfBits)
        result = result And ((2 ^ noOfBits) - 1)
        Return result
    End Function

    Public Function GetData() As Byte()
        Dim result(7) As Byte
        For i As Integer = 0 To 7
            result(i) = (_value >> 56 - (i * 8)) And CULng(255)
        Next
        Return result
    End Function
End Class
