Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Zoom
        vs_pic.Hide()
        vs_pic.BackgroundImageLayout = ImageLayout.Zoom
        battle_btn.BackColor = Color.Gray
        battle_btn.FlatStyle = FlatStyle.Flat
        battle_btn.ForeColor = System.Drawing.Color.Red
        battle_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        battle_btn.FlatAppearance.MouseOverBackColor = Color.Black
    End Sub

    Private Sub battle_btn_Click(sender As Object, e As EventArgs) Handles battle_btn.Click
        vs_pic.Visible = True
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        vs_pic.Visible = False
        Timer1.Interval = 1000
        Timer1.Stop()
        Dim form As New form3
        form3.show()
        Me.Close()
    End Sub
End Class