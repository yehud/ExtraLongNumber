Public Class ExtraLongNumber
    Private byteValue() As Byte

    Overloads Property ValueString() As String
        Get
            Return byteValue.ToString()
        End Get
        Set(value As String)
            byteValue = Integer.Parse(value)
        End Set
    End Property

    Overloads Property Value() As Byte
        Get
            Return byteValue
        End Get
        Set(value As Byte)
            byteValue = value
        End Set
    End Property

    Public Shared Function Add(ByVal a As ExtraLongNumber, ByVal b As ExtraLongNumber) As ExtraLongNumber
        Dim elnResult As New ExtraLongNumber
        elnResult.ValueString = (a.Value + b.Value).ToString
        Return elnResult
    End Function

    Public Shared Function Subtract(ByVal a As ExtraLongNumber, ByVal b As ExtraLongNumber) As ExtraLongNumber
        Dim elnResult As New ExtraLongNumber
        elnResult.ValueString = (a.Value - b.Value).ToString
        Return elnResult
    End Function

    Public Shared Function Multiply(ByVal a As ExtraLongNumber, ByVal b As ExtraLongNumber) As ExtraLongNumber
        Dim elnResult As New ExtraLongNumber
        elnResult.ValueString = (a.Value * b.Value).ToString
        Return elnResult
    End Function

    Public Shared Function Divide(ByVal a As ExtraLongNumber, ByVal b As ExtraLongNumber) As ExtraLongNumber
        Dim elnResult As New ExtraLongNumber
        elnResult.ValueString = (a.Value / b.Value).ToString
        Return elnResult
    End Function
End Class
