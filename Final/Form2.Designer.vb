<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.battle_btn = New System.Windows.Forms.Button()
        Me.vs_pic = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.vs_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'battle_btn
        '
        Me.battle_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.battle_btn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.battle_btn.Location = New System.Drawing.Point(279, 280)
        Me.battle_btn.Name = "battle_btn"
        Me.battle_btn.Size = New System.Drawing.Size(109, 54)
        Me.battle_btn.TabIndex = 1
        Me.battle_btn.Text = "Battle"
        Me.battle_btn.UseVisualStyleBackColor = True
        '
        'vs_pic
        '
        Me.vs_pic.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.vs_pic.Image = Global.Final.My.Resources.Resources._11f36d0f28a8f933aa2309ff93bb374b__cranberry_wedding_burgundy_wedding
        Me.vs_pic.Location = New System.Drawing.Point(-1, 1)
        Me.vs_pic.Name = "vs_pic"
        Me.vs_pic.Size = New System.Drawing.Size(670, 207)
        Me.vs_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.vs_pic.TabIndex = 2
        Me.vs_pic.TabStop = False
        '
        'Timer1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final.My.Resources.Resources.bg11
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(668, 450)
        Me.Controls.Add(Me.vs_pic)
        Me.Controls.Add(Me.battle_btn)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.vs_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents battle_btn As Button
    Friend WithEvents vs_pic As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
