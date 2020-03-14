<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Btn_dice = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.randompic = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.PicBox_start = New System.Windows.Forms.PictureBox()
        CType(Me.randompic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox_start, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(493, 28)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(295, 23)
        Me.ProgressBar2.TabIndex = 20
        Me.ProgressBar2.Value = 100
        '
        'Btn_dice
        '
        Me.Btn_dice.Location = New System.Drawing.Point(373, 399)
        Me.Btn_dice.Name = "Btn_dice"
        Me.Btn_dice.Size = New System.Drawing.Size(76, 36)
        Me.Btn_dice.TabIndex = 32
        Me.Btn_dice.Text = "ROLL DICE"
        Me.Btn_dice.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.Location = New System.Drawing.Point(493, 371)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(278, 64)
        Me.RichTextBox1.TabIndex = 31
        Me.RichTextBox1.Text = ""
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(373, 371)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(76, 22)
        Me.btn_start.TabIndex = 30
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(338, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(126, 10)
        Me.ProgressBar1.TabIndex = 29
        '
        'randompic
        '
        Me.randompic.Image = Global.Final.My.Resources.Resources._6
        Me.randompic.Location = New System.Drawing.Point(338, 12)
        Me.randompic.Name = "randompic"
        Me.randompic.Size = New System.Drawing.Size(126, 68)
        Me.randompic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.randompic.TabIndex = 28
        Me.randompic.TabStop = False
        '
        'Timer1
        '
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(292, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 37)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(12, 28)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(301, 23)
        Me.ProgressBar3.TabIndex = 34
        Me.ProgressBar3.Value = 100
        '
        'PicBox_start
        '
        Me.PicBox_start.Image = Global.Final.My.Resources.Resources.START
        Me.PicBox_start.Location = New System.Drawing.Point(92, 74)
        Me.PicBox_start.Name = "PicBox_start"
        Me.PicBox_start.Size = New System.Drawing.Size(632, 234)
        Me.PicBox_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox_start.TabIndex = 35
        Me.PicBox_start.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final.My.Resources.Resources.untitled_png4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PicBox_start)
        Me.Controls.Add(Me.ProgressBar3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btn_dice)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.randompic)
        Me.Controls.Add(Me.ProgressBar2)
        Me.DoubleBuffered = True
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.randompic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox_start, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Btn_dice As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btn_start As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents randompic As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents PicBox_start As PictureBox
End Class
