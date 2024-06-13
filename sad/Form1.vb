Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim iNumber1 As Integer
        Dim iNumber2 As Integer

        Dim iResult As Integer

        iNumber1 = TextBox1.Text
        iNumber2 = TextBox2.Text

        iResult = iNumber1 + iNumber2
        MsgBox(iResult)






    End Sub




End Class
