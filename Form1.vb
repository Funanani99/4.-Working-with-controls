Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' MsgBox("The sum is =" & Val(TextBox1.Text) + Val(TextBox2.Text))
        'Label3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        ' MsgBox("The Multiplication is =" & Val(TextBox1.Text) * Val(TextBox2.Text))
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub

    Private Sub btnDevide_Click(sender As Object, e As EventArgs) Handles btnDevide.Click
        ' MsgBox("The Devision is =" & Val(TextBox1.Text) / Val(TextBox2.Text))
        TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        ' MsgBox("The Substraction is =" & Val(TextBox1.Text) - Val(TextBox2.Text))
        TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
