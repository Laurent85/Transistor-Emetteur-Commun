<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Vcc = New System.Windows.Forms.TextBox()
        Me.Vbe = New System.Windows.Forms.TextBox()
        Me.Hfe = New System.Windows.Forms.TextBox()
        Me.RL = New System.Windows.Forms.TextBox()
        Me.Gain = New System.Windows.Forms.TextBox()
        Me.Vcc_text = New System.Windows.Forms.Label()
        Me.Vbe_text = New System.Windows.Forms.Label()
        Me.Hfe_text = New System.Windows.Forms.Label()
        Me.RL_text = New System.Windows.Forms.Label()
        Me.Gain_text = New System.Windows.Forms.Label()
        Me.R1 = New System.Windows.Forms.TextBox()
        Me.R2 = New System.Windows.Forms.TextBox()
        Me.R3 = New System.Windows.Forms.TextBox()
        Me.R4 = New System.Windows.Forms.TextBox()
        Me.R1_text = New System.Windows.Forms.Label()
        Me.R2_text = New System.Windows.Forms.Label()
        Me.R3_text = New System.Windows.Forms.Label()
        Me.R4_text = New System.Windows.Forms.Label()
        Me.Vce_text = New System.Windows.Forms.Label()
        Me.Vc_text = New System.Windows.Forms.Label()
        Me.Vb_text = New System.Windows.Forms.Label()
        Me.Ve_text = New System.Windows.Forms.Label()
        Me.Ic_text = New System.Windows.Forms.Label()
        Me.Vce = New System.Windows.Forms.TextBox()
        Me.Vc = New System.Windows.Forms.TextBox()
        Me.Vb = New System.Windows.Forms.TextBox()
        Me.Ve1 = New System.Windows.Forms.TextBox()
        Me.Ic1 = New System.Windows.Forms.TextBox()
        Me.Vce_vrai_text = New System.Windows.Forms.Label()
        Me.Vc_vrai_text = New System.Windows.Forms.Label()
        Me.Vb_vrai_text = New System.Windows.Forms.Label()
        Me.Ve_vrai_text = New System.Windows.Forms.Label()
        Me.Ic_vrai_text = New System.Windows.Forms.Label()
        Me.Vce_vrai = New System.Windows.Forms.TextBox()
        Me.Vc_vrai = New System.Windows.Forms.TextBox()
        Me.Vb_vrai = New System.Windows.Forms.TextBox()
        Me.Ve_vrai = New System.Windows.Forms.TextBox()
        Me.Ic_vrai = New System.Windows.Forms.TextBox()
        Me.Vin_max = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Transistor.My.Resources.Resources.Montage
        Me.PictureBox1.Location = New System.Drawing.Point(223, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(476, 281)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Vcc
        '
        Me.Vcc.Location = New System.Drawing.Point(101, 144)
        Me.Vcc.Name = "Vcc"
        Me.Vcc.Size = New System.Drawing.Size(62, 20)
        Me.Vcc.TabIndex = 1
        Me.Vcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Vbe
        '
        Me.Vbe.Location = New System.Drawing.Point(101, 191)
        Me.Vbe.Name = "Vbe"
        Me.Vbe.Size = New System.Drawing.Size(62, 20)
        Me.Vbe.TabIndex = 2
        Me.Vbe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Hfe
        '
        Me.Hfe.Location = New System.Drawing.Point(101, 237)
        Me.Hfe.Name = "Hfe"
        Me.Hfe.Size = New System.Drawing.Size(62, 20)
        Me.Hfe.TabIndex = 3
        Me.Hfe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RL
        '
        Me.RL.Location = New System.Drawing.Point(101, 284)
        Me.RL.Name = "RL"
        Me.RL.Size = New System.Drawing.Size(62, 20)
        Me.RL.TabIndex = 4
        Me.RL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Gain
        '
        Me.Gain.Location = New System.Drawing.Point(101, 332)
        Me.Gain.Name = "Gain"
        Me.Gain.Size = New System.Drawing.Size(62, 20)
        Me.Gain.TabIndex = 5
        Me.Gain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Vcc_text
        '
        Me.Vcc_text.AutoSize = True
        Me.Vcc_text.ForeColor = System.Drawing.Color.Red
        Me.Vcc_text.Location = New System.Drawing.Point(45, 147)
        Me.Vcc_text.Name = "Vcc_text"
        Me.Vcc_text.Size = New System.Drawing.Size(42, 13)
        Me.Vcc_text.TabIndex = 6
        Me.Vcc_text.Text = "Vcc (V)"
        '
        'Vbe_text
        '
        Me.Vbe_text.AutoSize = True
        Me.Vbe_text.ForeColor = System.Drawing.Color.Red
        Me.Vbe_text.Location = New System.Drawing.Point(45, 194)
        Me.Vbe_text.Name = "Vbe_text"
        Me.Vbe_text.Size = New System.Drawing.Size(42, 13)
        Me.Vbe_text.TabIndex = 7
        Me.Vbe_text.Text = "Vbe (V)"
        '
        'Hfe_text
        '
        Me.Hfe_text.AutoSize = True
        Me.Hfe_text.ForeColor = System.Drawing.Color.Red
        Me.Hfe_text.Location = New System.Drawing.Point(45, 240)
        Me.Hfe_text.Name = "Hfe_text"
        Me.Hfe_text.Size = New System.Drawing.Size(24, 13)
        Me.Hfe_text.TabIndex = 8
        Me.Hfe_text.Text = "Hfe"
        '
        'RL_text
        '
        Me.RL_text.AutoSize = True
        Me.RL_text.ForeColor = System.Drawing.Color.Red
        Me.RL_text.Location = New System.Drawing.Point(45, 287)
        Me.RL_text.Name = "RL_text"
        Me.RL_text.Size = New System.Drawing.Size(38, 13)
        Me.RL_text.TabIndex = 9
        Me.RL_text.Text = "RL (Ω)"
        '
        'Gain_text
        '
        Me.Gain_text.AutoSize = True
        Me.Gain_text.ForeColor = System.Drawing.Color.Red
        Me.Gain_text.Location = New System.Drawing.Point(45, 335)
        Me.Gain_text.Name = "Gain_text"
        Me.Gain_text.Size = New System.Drawing.Size(29, 13)
        Me.Gain_text.TabIndex = 10
        Me.Gain_text.Text = "Gain"
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.LightYellow
        Me.R1.Location = New System.Drawing.Point(776, 100)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(62, 20)
        Me.R1.TabIndex = 11
        Me.R1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R2
        '
        Me.R2.BackColor = System.Drawing.Color.LightYellow
        Me.R2.Location = New System.Drawing.Point(776, 137)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(62, 20)
        Me.R2.TabIndex = 12
        Me.R2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R3
        '
        Me.R3.BackColor = System.Drawing.Color.LightYellow
        Me.R3.Location = New System.Drawing.Point(931, 100)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(62, 20)
        Me.R3.TabIndex = 13
        Me.R3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R4
        '
        Me.R4.BackColor = System.Drawing.Color.LightYellow
        Me.R4.Location = New System.Drawing.Point(931, 137)
        Me.R4.Name = "R4"
        Me.R4.Size = New System.Drawing.Size(62, 20)
        Me.R4.TabIndex = 14
        Me.R4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'R1_text
        '
        Me.R1_text.AutoSize = True
        Me.R1_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1_text.Location = New System.Drawing.Point(740, 101)
        Me.R1_text.Name = "R1_text"
        Me.R1_text.Size = New System.Drawing.Size(25, 15)
        Me.R1_text.TabIndex = 15
        Me.R1_text.Text = "R1"
        '
        'R2_text
        '
        Me.R2_text.AutoSize = True
        Me.R2_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R2_text.Location = New System.Drawing.Point(740, 138)
        Me.R2_text.Name = "R2_text"
        Me.R2_text.Size = New System.Drawing.Size(25, 15)
        Me.R2_text.TabIndex = 16
        Me.R2_text.Text = "R2"
        '
        'R3_text
        '
        Me.R3_text.AutoSize = True
        Me.R3_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R3_text.Location = New System.Drawing.Point(896, 101)
        Me.R3_text.Name = "R3_text"
        Me.R3_text.Size = New System.Drawing.Size(25, 15)
        Me.R3_text.TabIndex = 17
        Me.R3_text.Text = "R3"
        '
        'R4_text
        '
        Me.R4_text.AutoSize = True
        Me.R4_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R4_text.Location = New System.Drawing.Point(896, 138)
        Me.R4_text.Name = "R4_text"
        Me.R4_text.Size = New System.Drawing.Size(25, 15)
        Me.R4_text.TabIndex = 18
        Me.R4_text.Text = "R4"
        '
        'Vce_text
        '
        Me.Vce_text.AutoSize = True
        Me.Vce_text.Location = New System.Drawing.Point(720, 378)
        Me.Vce_text.Name = "Vce_text"
        Me.Vce_text.Size = New System.Drawing.Size(51, 13)
        Me.Vce_text.TabIndex = 28
        Me.Vce_text.Text = "Vce idéal"
        '
        'Vc_text
        '
        Me.Vc_text.AutoSize = True
        Me.Vc_text.Location = New System.Drawing.Point(720, 330)
        Me.Vc_text.Name = "Vc_text"
        Me.Vc_text.Size = New System.Drawing.Size(45, 13)
        Me.Vc_text.TabIndex = 27
        Me.Vc_text.Text = "Vc idéal"
        '
        'Vb_text
        '
        Me.Vb_text.AutoSize = True
        Me.Vb_text.Location = New System.Drawing.Point(720, 283)
        Me.Vb_text.Name = "Vb_text"
        Me.Vb_text.Size = New System.Drawing.Size(45, 13)
        Me.Vb_text.TabIndex = 26
        Me.Vb_text.Text = "Vb idéal"
        '
        'Ve_text
        '
        Me.Ve_text.AutoSize = True
        Me.Ve_text.Location = New System.Drawing.Point(720, 237)
        Me.Ve_text.Name = "Ve_text"
        Me.Ve_text.Size = New System.Drawing.Size(45, 13)
        Me.Ve_text.TabIndex = 25
        Me.Ve_text.Text = "Ve idéal"
        '
        'Ic_text
        '
        Me.Ic_text.AutoSize = True
        Me.Ic_text.Location = New System.Drawing.Point(720, 190)
        Me.Ic_text.Name = "Ic_text"
        Me.Ic_text.Size = New System.Drawing.Size(41, 13)
        Me.Ic_text.TabIndex = 24
        Me.Ic_text.Text = "Ic idéal"
        '
        'Vce
        '
        Me.Vce.Location = New System.Drawing.Point(776, 375)
        Me.Vce.Name = "Vce"
        Me.Vce.Size = New System.Drawing.Size(62, 20)
        Me.Vce.TabIndex = 23
        Me.Vce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Vc
        '
        Me.Vc.Location = New System.Drawing.Point(776, 327)
        Me.Vc.Name = "Vc"
        Me.Vc.Size = New System.Drawing.Size(62, 20)
        Me.Vc.TabIndex = 22
        Me.Vc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Vb
        '
        Me.Vb.Location = New System.Drawing.Point(776, 280)
        Me.Vb.Name = "Vb"
        Me.Vb.Size = New System.Drawing.Size(62, 20)
        Me.Vb.TabIndex = 21
        Me.Vb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ve1
        '
        Me.Ve1.Location = New System.Drawing.Point(776, 234)
        Me.Ve1.Name = "Ve1"
        Me.Ve1.Size = New System.Drawing.Size(62, 20)
        Me.Ve1.TabIndex = 20
        Me.Ve1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ic1
        '
        Me.Ic1.Location = New System.Drawing.Point(776, 187)
        Me.Ic1.Name = "Ic1"
        Me.Ic1.Size = New System.Drawing.Size(62, 20)
        Me.Ic1.TabIndex = 19
        Me.Ic1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Vce_vrai_text
        '
        Me.Vce_vrai_text.AutoSize = True
        Me.Vce_vrai_text.Location = New System.Drawing.Point(875, 378)
        Me.Vce_vrai_text.Name = "Vce_vrai_text"
        Me.Vce_vrai_text.Size = New System.Drawing.Size(46, 13)
        Me.Vce_vrai_text.TabIndex = 38
        Me.Vce_vrai_text.Text = "Vce réèl"
        '
        'Vc_vrai_text
        '
        Me.Vc_vrai_text.AutoSize = True
        Me.Vc_vrai_text.Location = New System.Drawing.Point(875, 330)
        Me.Vc_vrai_text.Name = "Vc_vrai_text"
        Me.Vc_vrai_text.Size = New System.Drawing.Size(40, 13)
        Me.Vc_vrai_text.TabIndex = 37
        Me.Vc_vrai_text.Text = "Vc réèl"
        '
        'Vb_vrai_text
        '
        Me.Vb_vrai_text.AutoSize = True
        Me.Vb_vrai_text.Location = New System.Drawing.Point(875, 283)
        Me.Vb_vrai_text.Name = "Vb_vrai_text"
        Me.Vb_vrai_text.Size = New System.Drawing.Size(40, 13)
        Me.Vb_vrai_text.TabIndex = 36
        Me.Vb_vrai_text.Text = "Vb réèl"
        '
        'Ve_vrai_text
        '
        Me.Ve_vrai_text.AutoSize = True
        Me.Ve_vrai_text.Location = New System.Drawing.Point(875, 237)
        Me.Ve_vrai_text.Name = "Ve_vrai_text"
        Me.Ve_vrai_text.Size = New System.Drawing.Size(40, 13)
        Me.Ve_vrai_text.TabIndex = 35
        Me.Ve_vrai_text.Text = "Ve réèl"
        '
        'Ic_vrai_text
        '
        Me.Ic_vrai_text.AutoSize = True
        Me.Ic_vrai_text.Location = New System.Drawing.Point(875, 190)
        Me.Ic_vrai_text.Name = "Ic_vrai_text"
        Me.Ic_vrai_text.Size = New System.Drawing.Size(36, 13)
        Me.Ic_vrai_text.TabIndex = 34
        Me.Ic_vrai_text.Text = "Ic réèl"
        '
        'Vce_vrai
        '
        Me.Vce_vrai.Location = New System.Drawing.Point(931, 375)
        Me.Vce_vrai.Name = "Vce_vrai"
        Me.Vce_vrai.Size = New System.Drawing.Size(62, 20)
        Me.Vce_vrai.TabIndex = 33
        Me.Vce_vrai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Vc_vrai
        '
        Me.Vc_vrai.Location = New System.Drawing.Point(931, 327)
        Me.Vc_vrai.Name = "Vc_vrai"
        Me.Vc_vrai.Size = New System.Drawing.Size(62, 20)
        Me.Vc_vrai.TabIndex = 32
        Me.Vc_vrai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Vb_vrai
        '
        Me.Vb_vrai.Location = New System.Drawing.Point(931, 280)
        Me.Vb_vrai.Name = "Vb_vrai"
        Me.Vb_vrai.Size = New System.Drawing.Size(62, 20)
        Me.Vb_vrai.TabIndex = 31
        Me.Vb_vrai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ve_vrai
        '
        Me.Ve_vrai.Location = New System.Drawing.Point(931, 234)
        Me.Ve_vrai.Name = "Ve_vrai"
        Me.Ve_vrai.Size = New System.Drawing.Size(62, 20)
        Me.Ve_vrai.TabIndex = 30
        Me.Ve_vrai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ic_vrai
        '
        Me.Ic_vrai.Location = New System.Drawing.Point(931, 187)
        Me.Ic_vrai.Name = "Ic_vrai"
        Me.Ic_vrai.Size = New System.Drawing.Size(62, 20)
        Me.Ic_vrai.TabIndex = 29
        Me.Ic_vrai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Vin_max
        '
        Me.Vin_max.Location = New System.Drawing.Point(514, 404)
        Me.Vin_max.Name = "Vin_max"
        Me.Vin_max.Size = New System.Drawing.Size(82, 20)
        Me.Vin_max.TabIndex = 39
        Me.Vin_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(313, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 26)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Polarisation du transistor NPN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(368, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Montage émetteur commun"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(346, 407)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Tension Vin à ne pas dépasser :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(45, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 17)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Valeurs à fournir"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1025, 442)
        Me.ShapeContainer1.TabIndex = 44
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Green
        Me.RectangleShape1.CornerRadius = 10
        Me.RectangleShape1.Location = New System.Drawing.Point(17, 95)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(185, 280)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 442)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Vin_max)
        Me.Controls.Add(Me.Vce_vrai_text)
        Me.Controls.Add(Me.Vc_vrai_text)
        Me.Controls.Add(Me.Vb_vrai_text)
        Me.Controls.Add(Me.Ve_vrai_text)
        Me.Controls.Add(Me.Ic_vrai_text)
        Me.Controls.Add(Me.Vce_vrai)
        Me.Controls.Add(Me.Vc_vrai)
        Me.Controls.Add(Me.Vb_vrai)
        Me.Controls.Add(Me.Ve_vrai)
        Me.Controls.Add(Me.Ic_vrai)
        Me.Controls.Add(Me.Vce_text)
        Me.Controls.Add(Me.Vc_text)
        Me.Controls.Add(Me.Vb_text)
        Me.Controls.Add(Me.Ve_text)
        Me.Controls.Add(Me.Ic_text)
        Me.Controls.Add(Me.Vce)
        Me.Controls.Add(Me.Vc)
        Me.Controls.Add(Me.Vb)
        Me.Controls.Add(Me.Ve1)
        Me.Controls.Add(Me.Ic1)
        Me.Controls.Add(Me.R4_text)
        Me.Controls.Add(Me.R3_text)
        Me.Controls.Add(Me.R2_text)
        Me.Controls.Add(Me.R1_text)
        Me.Controls.Add(Me.R4)
        Me.Controls.Add(Me.R3)
        Me.Controls.Add(Me.R2)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.Gain_text)
        Me.Controls.Add(Me.RL_text)
        Me.Controls.Add(Me.Hfe_text)
        Me.Controls.Add(Me.Vbe_text)
        Me.Controls.Add(Me.Vcc_text)
        Me.Controls.Add(Me.Gain)
        Me.Controls.Add(Me.RL)
        Me.Controls.Add(Me.Hfe)
        Me.Controls.Add(Me.Vbe)
        Me.Controls.Add(Me.Vcc)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Emetteur commun"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Vcc As System.Windows.Forms.TextBox
    Friend WithEvents Vbe As System.Windows.Forms.TextBox
    Friend WithEvents Hfe As System.Windows.Forms.TextBox
    Friend WithEvents RL As System.Windows.Forms.TextBox
    Friend WithEvents Gain As System.Windows.Forms.TextBox
    Friend WithEvents Vcc_text As System.Windows.Forms.Label
    Friend WithEvents Vbe_text As System.Windows.Forms.Label
    Friend WithEvents Hfe_text As System.Windows.Forms.Label
    Friend WithEvents RL_text As System.Windows.Forms.Label
    Friend WithEvents Gain_text As System.Windows.Forms.Label
    Friend WithEvents R1 As System.Windows.Forms.TextBox
    Friend WithEvents R2 As System.Windows.Forms.TextBox
    Friend WithEvents R3 As System.Windows.Forms.TextBox
    Friend WithEvents R4 As System.Windows.Forms.TextBox
    Friend WithEvents R1_text As System.Windows.Forms.Label
    Friend WithEvents R2_text As System.Windows.Forms.Label
    Friend WithEvents R3_text As System.Windows.Forms.Label
    Friend WithEvents R4_text As System.Windows.Forms.Label
    Friend WithEvents Vce_text As System.Windows.Forms.Label
    Friend WithEvents Vc_text As System.Windows.Forms.Label
    Friend WithEvents Vb_text As System.Windows.Forms.Label
    Friend WithEvents Ve_text As System.Windows.Forms.Label
    Friend WithEvents Ic_text As System.Windows.Forms.Label
    Friend WithEvents Vce As System.Windows.Forms.TextBox
    Friend WithEvents Vc As System.Windows.Forms.TextBox
    Friend WithEvents Vb As System.Windows.Forms.TextBox
    Friend WithEvents Ve1 As System.Windows.Forms.TextBox
    Friend WithEvents Ic1 As System.Windows.Forms.TextBox
    Friend WithEvents Vce_vrai_text As System.Windows.Forms.Label
    Friend WithEvents Vc_vrai_text As System.Windows.Forms.Label
    Friend WithEvents Vb_vrai_text As System.Windows.Forms.Label
    Friend WithEvents Ve_vrai_text As System.Windows.Forms.Label
    Friend WithEvents Ic_vrai_text As System.Windows.Forms.Label
    Friend WithEvents Vce_vrai As System.Windows.Forms.TextBox
    Friend WithEvents Vc_vrai As System.Windows.Forms.TextBox
    Friend WithEvents Vb_vrai As System.Windows.Forms.TextBox
    Friend WithEvents Ve_vrai As System.Windows.Forms.TextBox
    Friend WithEvents Ic_vrai As System.Windows.Forms.TextBox
    Friend WithEvents Vin_max As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape

End Class
