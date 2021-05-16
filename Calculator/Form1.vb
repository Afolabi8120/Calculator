Public Class Form1
    Dim str1 As Double
    Dim str2 As Double
    Dim str As String

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub btn00_Click(sender As Object, e As EventArgs) Handles btn00.Click
        TextBox1.Text = TextBox1.Text + "00"
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        TextBox1.Text = TextBox1.Text + "."
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        str1 = TextBox1.Text
        TextBox1.Clear()
        str = btnPlus.Text
        Return
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        str2 = TextBox1.Text
        If str = "-" Then
            TextBox1.Text = str1 - str2
        ElseIf str = "+" Then
            TextBox1.Text = str1 + str2
        ElseIf str = "*" Then
            TextBox1.Text = str1 * str2
        ElseIf str = "/" Then
            TextBox1.Text = str1 / str2
        End If
    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
        str1 = TextBox1.Text
        TextBox1.Clear()
        str = btnMul.Text
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        str1 = TextBox1.Text
        TextBox1.Clear()
        str = btnMinus.Text
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        str1 = TextBox1.Text
        TextBox1.Clear()
        str = btnDivide.Text
    End Sub
End Class
