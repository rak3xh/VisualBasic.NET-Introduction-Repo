Public Class Form1
    Dim iNumber1 As Double
    Dim iNumber2 As Double
    Dim iResult As Double


    Private Sub btnRemainder_Click(sender As Object, e As EventArgs) Handles btnRemainder.Click
        iNumber1 = txtNumber1.Text
        iNumber2 = txtNumber2.Text

        iResult = iNumber1 Mod iNumber2
        MsgBox("The Remainder of " & iNumber1 & " & " & iNumber2 & " is " & iResult)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        iNumber1 = txtNumber1.Text
        iNumber2 = txtNumber2.Text

        iResult = iNumber1 + iNumber2
        MsgBox("The Addition of " & iNumber1 & " & " & iNumber2 & " is " & iResult)
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        iNumber1 = txtNumber1.Text
        iNumber2 = txtNumber2.Text

        iResult = iNumber1 - iNumber2
        MsgBox("The Subtraction of " & iNumber1 & " & " & iNumber2 & " is " & iResult)
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        iNumber1 = txtNumber1.Text
        iNumber2 = txtNumber2.Text

        iResult = iNumber1 * iNumber2
        MsgBox("The Multiplication of " & iNumber1 & " & " & iNumber2 & " is " & iResult)
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        iNumber1 = txtNumber1.Text
        iNumber2 = txtNumber2.Text

        iResult = iNumber1 / iNumber2
        MsgBox("The Quotient of " & iNumber1 & " & " & iNumber2 & " is " & iResult)
    End Sub

    Private Sub btnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        iNumber1 = txtNumber1.Text
        iNumber2 = txtNumber2.Text

        iResult = iNumber1 ^ iNumber2
        MsgBox("The Power of " & iNumber1 & " & " & iNumber2 & " is " & iResult)
    End Sub
End Class
