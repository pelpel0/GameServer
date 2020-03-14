Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImageLayout = ImageLayout.Zoom
        start_btn.BackColor = Color.Gray
        start_btn.FlatStyle = FlatStyle.Flat
        start_btn.ForeColor = System.Drawing.Color.Red
        start_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        start_btn.FlatAppearance.MouseOverBackColor = Color.Black
    End Sub

    Private Sub start_btn_Click(sender As Object, e As EventArgs) Handles start_btn.Click
        Dim form As New Form2
        form.Show()
        Me.Close()

    End Sub
End Class
