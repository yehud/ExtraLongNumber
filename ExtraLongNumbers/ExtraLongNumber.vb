Public Class ExtraLongNumber
    Private byteValue() As Byte

    Public Sub New(ByVal value As String)
        byteValue = New Byte(1) {}
    End Sub

    Overloads Property ValueString() As String
        Get
            Return byteValue.ToString()
        End Get
        Set(value As String)
            byteValue(1) = Integer.Parse(value)
        End Set
    End Property

    Overloads Property Value() As Byte
        Get
            Return byteValue(1)
        End Get
        Set(value As Byte)
            byteValue(1) = value
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
