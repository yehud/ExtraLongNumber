Public Class Form1
    Dim intOperator As Byte = 0
    Dim elnPrevVal As New ExtraLongNumber

    Private Sub btnOperator_Click(sender As Object, e As EventArgs) Handles btnEqual.Click, btnAdd.Click, btnSubtract.Click, btnMultiply.Click, btnDivide.Click
        intOperator = sender.tag
        'txtInput1.Text = txtInput1.Text & "+"
        'elnPrevVal.ValueString = txtInput1.Text
        Calculate()
    End Sub

    Private Sub Calculate()
        Dim Inputs() As String
        Dim elnInput1 As New ExtraLongNumber
        Dim elnInput2 As New ExtraLongNumber
        Dim elnOutput As New ExtraLongNumber
        Inputs = Split(txtInput1.Text, "+")
        elnInput1.ValueString = txtInput1.Text
        elnInput2.ValueString = txtInput2.Text
        Select Case intOperator
            Case 0
                elnOutput = elnInput1
            Case 1
                elnOutput = ExtraLongNumber.Add(elnInput1, elnInput2)
            Case 2
                elnOutput = ExtraLongNumber.Subtract(elnInput1, elnInput2)
            Case 3
                elnOutput = ExtraLongNumber.Multiply(elnInput1, elnInput2)
            Case 4
                elnOutput = ExtraLongNumber.Divide(elnInput1, elnInput2)
        End Select
        txtOutput.Text = elnOutput.Value
    End Sub
End Class