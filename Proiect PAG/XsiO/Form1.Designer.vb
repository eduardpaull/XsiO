<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnJoker1 = New System.Windows.Forms.Button()
        Me.btnSuperman1 = New System.Windows.Forms.Button()
        Me.btnBatman1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnJoker2 = New System.Windows.Forms.Button()
        Me.btnBatman2 = New System.Windows.Forms.Button()
        Me.btnSuperman2 = New System.Windows.Forms.Button()
        Me.btnNext1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(510, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 135)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VS"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(126, 76)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(119, 32)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Player 1"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(936, 76)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(119, 32)
        Me.lbl2.TabIndex = 2
        Me.lbl2.Text = "Player 2"
        Me.lbl2.Visible = False
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(63, 124)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(262, 22)
        Me.txt1.TabIndex = 3
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(861, 124)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(262, 22)
        Me.txt2.TabIndex = 4
        Me.txt2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnJoker1)
        Me.Panel1.Controls.Add(Me.btnSuperman1)
        Me.Panel1.Controls.Add(Me.btnBatman1)
        Me.Panel1.Location = New System.Drawing.Point(47, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 220)
        Me.Panel1.TabIndex = 5
        '
        'btnJoker1
        '
        Me.btnJoker1.BackgroundImage = Global.XsiO.My.Resources.Resources.joker
        Me.btnJoker1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJoker1.Location = New System.Drawing.Point(204, 24)
        Me.btnJoker1.Name = "btnJoker1"
        Me.btnJoker1.Size = New System.Drawing.Size(92, 163)
        Me.btnJoker1.TabIndex = 2
        Me.btnJoker1.UseVisualStyleBackColor = True
        '
        'btnSuperman1
        '
        Me.btnSuperman1.BackgroundImage = Global.XsiO.My.Resources.Resources.Superman
        Me.btnSuperman1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSuperman1.Location = New System.Drawing.Point(106, 24)
        Me.btnSuperman1.Name = "btnSuperman1"
        Me.btnSuperman1.Size = New System.Drawing.Size(92, 163)
        Me.btnSuperman1.TabIndex = 1
        Me.btnSuperman1.UseVisualStyleBackColor = True
        '
        'btnBatman1
        '
        Me.btnBatman1.BackgroundImage = Global.XsiO.My.Resources.Resources.batman
        Me.btnBatman1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBatman1.Location = New System.Drawing.Point(3, 24)
        Me.btnBatman1.Name = "btnBatman1"
        Me.btnBatman1.Size = New System.Drawing.Size(92, 163)
        Me.btnBatman1.TabIndex = 0
        Me.btnBatman1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnJoker2)
        Me.Panel2.Controls.Add(Me.btnBatman2)
        Me.Panel2.Controls.Add(Me.btnSuperman2)
        Me.Panel2.Location = New System.Drawing.Point(844, 174)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(301, 209)
        Me.Panel2.TabIndex = 6
        Me.Panel2.Visible = False
        '
        'btnJoker2
        '
        Me.btnJoker2.BackgroundImage = Global.XsiO.My.Resources.Resources.joker
        Me.btnJoker2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJoker2.Location = New System.Drawing.Point(199, 24)
        Me.btnJoker2.Name = "btnJoker2"
        Me.btnJoker2.Size = New System.Drawing.Size(92, 163)
        Me.btnJoker2.TabIndex = 3
        Me.btnJoker2.UseVisualStyleBackColor = True
        '
        'btnBatman2
        '
        Me.btnBatman2.BackgroundImage = Global.XsiO.My.Resources.Resources.batman
        Me.btnBatman2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBatman2.Location = New System.Drawing.Point(3, 24)
        Me.btnBatman2.Name = "btnBatman2"
        Me.btnBatman2.Size = New System.Drawing.Size(92, 163)
        Me.btnBatman2.TabIndex = 3
        Me.btnBatman2.UseVisualStyleBackColor = True
        '
        'btnSuperman2
        '
        Me.btnSuperman2.BackgroundImage = Global.XsiO.My.Resources.Resources.Superman
        Me.btnSuperman2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSuperman2.Location = New System.Drawing.Point(101, 24)
        Me.btnSuperman2.Name = "btnSuperman2"
        Me.btnSuperman2.Size = New System.Drawing.Size(92, 163)
        Me.btnSuperman2.TabIndex = 3
        Me.btnSuperman2.UseVisualStyleBackColor = True
        '
        'btnNext1
        '
        Me.btnNext1.BackColor = System.Drawing.Color.Transparent
        Me.btnNext1.Location = New System.Drawing.Point(132, 415)
        Me.btnNext1.Name = "btnNext1"
        Me.btnNext1.Size = New System.Drawing.Size(129, 41)
        Me.btnNext1.TabIndex = 7
        Me.btnNext1.Text = "Next"
        Me.btnNext1.UseVisualStyleBackColor = False
        Me.btnNext1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(181, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 394)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'btnNext2
        '
        Me.btnNext2.BackColor = System.Drawing.Color.Transparent
        Me.btnNext2.Location = New System.Drawing.Point(926, 415)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(129, 41)
        Me.btnNext2.TabIndex = 9
        Me.btnNext2.Text = "Next"
        Me.btnNext2.UseVisualStyleBackColor = False
        Me.btnNext2.Visible = False
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(513, 388)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(214, 68)
        Me.btnStart.TabIndex = 10
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        Me.btnStart.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(756, 71)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(281, 399)
        Me.Panel3.TabIndex = 11
        Me.Panel3.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.XsiO.My.Resources.Resources.daaa
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1225, 518)
        Me.Controls.Add(Me.btnNext2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnNext1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "X & 0"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnBatman1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSuperman1 As System.Windows.Forms.Button
    Friend WithEvents btnJoker1 As System.Windows.Forms.Button
    Friend WithEvents btnJoker2 As System.Windows.Forms.Button
    Friend WithEvents btnBatman2 As System.Windows.Forms.Button
    Friend WithEvents btnSuperman2 As System.Windows.Forms.Button
    Friend WithEvents btnNext1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnNext2 As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel

End Class
