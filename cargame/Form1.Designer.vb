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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.car = New System.Windows.Forms.PictureBox()
        Me.race1 = New System.Windows.Forms.PictureBox()
        Me.race2 = New System.Windows.Forms.PictureBox()
        Me.race3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.RightSide = New System.Windows.Forms.Timer(Me.components)
        Me.LeftSide = New System.Windows.Forms.Timer(Me.components)
        Me.RacerMover1 = New System.Windows.Forms.Timer(Me.components)
        Me.RacerMover2 = New System.Windows.Forms.Timer(Me.components)
        Me.RacerMover3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.race1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.race2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.race3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SCORE 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(239, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "SPEED 0"
        '
        'car
        '
        Me.car.Image = Global.cargame.My.Resources.Resources._9
        Me.car.Location = New System.Drawing.Point(141, 348)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(52, 78)
        Me.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car.TabIndex = 14
        Me.car.TabStop = False
        '
        'race1
        '
        Me.race1.Image = Global.cargame.My.Resources.Resources._8
        Me.race1.Location = New System.Drawing.Point(253, 127)
        Me.race1.Name = "race1"
        Me.race1.Size = New System.Drawing.Size(52, 78)
        Me.race1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.race1.TabIndex = 13
        Me.race1.TabStop = False
        '
        'race2
        '
        Me.race2.Image = Global.cargame.My.Resources.Resources._7
        Me.race2.Location = New System.Drawing.Point(141, 45)
        Me.race2.Name = "race2"
        Me.race2.Size = New System.Drawing.Size(52, 78)
        Me.race2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.race2.TabIndex = 12
        Me.race2.TabStop = False
        '
        'race3
        '
        Me.race3.Image = Global.cargame.My.Resources.Resources._1
        Me.race3.Location = New System.Drawing.Point(12, 247)
        Me.race3.Name = "race3"
        Me.race3.Size = New System.Drawing.Size(52, 78)
        Me.race3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.race3.TabIndex = 11
        Me.race3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox6.Location = New System.Drawing.Point(213, 248)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(20, 99)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox5.Location = New System.Drawing.Point(97, 248)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(20, 99)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox4.Location = New System.Drawing.Point(213, 103)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(20, 99)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox3.Location = New System.Drawing.Point(97, 106)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 99)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox2.Location = New System.Drawing.Point(213, -47)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 99)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Location = New System.Drawing.Point(97, -47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 99)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RoadMover
        '
        Me.RoadMover.Enabled = True
        Me.RoadMover.Interval = 10
        '
        'RightSide
        '
        Me.RightSide.Interval = 10
        '
        'LeftSide
        '
        Me.LeftSide.Interval = 10
        '
        'RacerMover1
        '
        Me.RacerMover1.Enabled = True
        Me.RacerMover1.Interval = 10
        '
        'RacerMover2
        '
        Me.RacerMover2.Enabled = True
        Me.RacerMover2.Interval = 10
        '
        'RacerMover3
        '
        Me.RacerMover3.Enabled = True
        Me.RacerMover3.Interval = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(47, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 51)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Game Over"
        Me.Label3.Visible = False
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Location = New System.Drawing.Point(126, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 38)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Replay"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox7.Location = New System.Drawing.Point(97, 400)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(20, 99)
        Me.PictureBox7.TabIndex = 17
        Me.PictureBox7.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox9.Location = New System.Drawing.Point(213, 400)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(20, 99)
        Me.PictureBox9.TabIndex = 18
        Me.PictureBox9.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(269, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(332, 453)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.car)
        Me.Controls.Add(Me.race1)
        Me.Controls.Add(Me.race2)
        Me.Controls.Add(Me.race3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(350, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(350, 500)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.race1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.race2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.race3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents race3 As PictureBox
    Friend WithEvents race2 As PictureBox
    Friend WithEvents race1 As PictureBox
    Friend WithEvents car As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents RightSide As Timer
    Friend WithEvents LeftSide As Timer
    Friend WithEvents RacerMover1 As Timer
    Friend WithEvents RacerMover2 As Timer
    Friend WithEvents RacerMover3 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Label4 As Label
End Class
