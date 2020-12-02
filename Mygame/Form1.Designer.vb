<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Wall = New System.Windows.Forms.PictureBox()
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.WIN = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox2.Image = Global.Mygame.My.Resources.Resources.blooper_icondssd
        Me.PictureBox2.Location = New System.Drawing.Point(952, 374)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(69, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Wall
        '
        Me.Wall.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Wall.Location = New System.Drawing.Point(745, 535)
        Me.Wall.Name = "Wall"
        Me.Wall.Size = New System.Drawing.Size(406, 46)
        Me.Wall.TabIndex = 2
        Me.Wall.TabStop = False
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.SystemColors.Control
        Me.Bullet.Image = Global.Mygame.My.Resources.Resources.VG_SMB_04__03517_1314141213_380_380rrrrrrrrrrre
        Me.Bullet.Location = New System.Drawing.Point(943, 461)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(103, 68)
        Me.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Bullet.TabIndex = 3
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'Timer2
        '
        '
        'WIN
        '
        Me.WIN.Location = New System.Drawing.Point(606, 478)
        Me.WIN.Name = "WIN"
        Me.WIN.Size = New System.Drawing.Size(87, 103)
        Me.WIN.TabIndex = 4
        Me.WIN.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Mygame.My.Resources.Resources._1adabd0c5dc47f7596ca5073df27c606df306c85_hqswws
        Me.PictureBox1.Location = New System.Drawing.Point(287, 478)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Mygame.My.Resources.Resources.downloadffffffffffffffffffffff
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1248, 654)
        Me.Controls.Add(Me.WIN)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.Wall)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Wall As PictureBox
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents WIN As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
