Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'TextBox1.Text = TextBox1.Text & vbCrLf & e.KeyChar
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        TextBox1.Text = e.KeyCode & vbCrLf & e.KeyData & vbCrLf & e.KeyValue & vbCrLf & e.ToString
    End Sub
End Class