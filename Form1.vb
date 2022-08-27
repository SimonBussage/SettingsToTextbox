Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Server = TextBox1.Text
        My.Settings.Save()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Do Settings Connection Manually in Runtime
        TextBox1.DataBindings.Add("Text", My.Settings, "Server")
        TextBox1.Text = My.Settings.Server
    End Sub


End Class