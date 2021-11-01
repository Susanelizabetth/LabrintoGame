Public Class Form1
    Private Sub Jugar_Click(sender As Object, e As EventArgs) Handles Jugar.Click
        User(i).nombre = txtNombre.Text
        Form2.Show()
        Me.Hide()
        i = i + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class