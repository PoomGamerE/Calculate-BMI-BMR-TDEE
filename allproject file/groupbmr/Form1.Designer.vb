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
        Me.male = New System.Windows.Forms.Button()
        Me.famale = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sex = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.showact = New System.Windows.Forms.Label()
        Me.btncal = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.showtdee = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.showbmi = New System.Windows.Forms.Button()
        Me.high = New System.Windows.Forms.TextBox()
        Me.weight = New System.Windows.Forms.TextBox()
        Me.age = New System.Windows.Forms.TextBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic5 = New System.Windows.Forms.PictureBox()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'male
        '
        Me.male.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.male.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.male.ForeColor = System.Drawing.Color.Black
        Me.male.Location = New System.Drawing.Point(248, 76)
        Me.male.Name = "male"
        Me.male.Size = New System.Drawing.Size(129, 43)
        Me.male.TabIndex = 0
        Me.male.Text = "ชาย"
        Me.male.UseVisualStyleBackColor = False
        '
        'famale
        '
        Me.famale.BackColor = System.Drawing.Color.Fuchsia
        Me.famale.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.famale.ForeColor = System.Drawing.Color.Black
        Me.famale.Location = New System.Drawing.Point(530, 76)
        Me.famale.Name = "famale"
        Me.famale.Size = New System.Drawing.Size(129, 43)
        Me.famale.TabIndex = 1
        Me.famale.Text = "หญิง"
        Me.famale.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(516, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "คำนวณการเผาผลาญพลังงาน Basal Metabolic Rate (BMR)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ส่วนสูง/เซ็นติเมตร"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(174, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "น้ำหนัก/กิโลกรัม"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(253, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "อายุ/ปี"
        '
        'sex
        '
        Me.sex.AutoSize = True
        Me.sex.Location = New System.Drawing.Point(415, 94)
        Me.sex.Name = "sex"
        Me.sex.Size = New System.Drawing.Size(77, 13)
        Me.sex.TabIndex = 15
        Me.sex.Text = "โปรดเลือกเพศ"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(212, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(517, 34)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "กิจกรรม: นั่งทำงานอยู่กับที่ และไม่ได้ออกกำลังกายเลย"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(212, 240)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(517, 34)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "กิจกรรม: ออกกำลังกายหรือเล่นกีฬาเล็กน้อย ประมาณอาทิตย์ละ 1-3 วัน"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.Location = New System.Drawing.Point(212, 280)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(517, 34)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "กิจกรรม: ออกกำลังกายหรือเล่นกีฬาปานกลาง ประมาณอาทิตย์ละ 3-5 วัน"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button4.Location = New System.Drawing.Point(212, 320)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(517, 34)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "กิจกรรม: ออกกำลังกายหรือเล่นกีฬาอย่างหนัก ประมาณอาทิตย์ละ 6-7 วัน"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button5.Location = New System.Drawing.Point(212, 360)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(517, 34)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "กิจกรรม: ออกกำลังกายหรือเล่นกีฬาอย่างหนักทุกวันเช้าเย็น"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'showact
        '
        Me.showact.AutoSize = True
        Me.showact.Location = New System.Drawing.Point(209, 397)
        Me.showact.Name = "showact"
        Me.showact.Size = New System.Drawing.Size(256, 13)
        Me.showact.TabIndex = 21
        Me.showact.Text = "โปรดเลือกความสม่ำเสมอในการออกกำลังกายด้วยครับ"
        '
        'btncal
        '
        Me.btncal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btncal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btncal.Location = New System.Drawing.Point(212, 413)
        Me.btncal.Name = "btncal"
        Me.btncal.Size = New System.Drawing.Size(517, 34)
        Me.btncal.TabIndex = 22
        Me.btncal.Text = "คำนวน"
        Me.btncal.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(158, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(604, 25)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "พลังงานที่คุณใช้ในแต่ละวัน TDEE (Total Daily Energy Expenditure)"
        '
        'showtdee
        '
        Me.showtdee.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.showtdee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.showtdee.Location = New System.Drawing.Point(213, 443)
        Me.showtdee.Name = "showtdee"
        Me.showtdee.Size = New System.Drawing.Size(516, 26)
        Me.showtdee.TabIndex = 26
        Me.showtdee.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(361, -2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 25)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "ค่าดัชนีมวลกาย (BMI)"
        '
        'showbmi
        '
        Me.showbmi.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.showbmi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.showbmi.Location = New System.Drawing.Point(213, 466)
        Me.showbmi.Name = "showbmi"
        Me.showbmi.Size = New System.Drawing.Size(516, 26)
        Me.showbmi.TabIndex = 28
        Me.showbmi.UseVisualStyleBackColor = False
        '
        'high
        '
        Me.high.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.high.Location = New System.Drawing.Point(322, 127)
        Me.high.Name = "high"
        Me.high.Size = New System.Drawing.Size(406, 20)
        Me.high.TabIndex = 29
        '
        'weight
        '
        Me.weight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.weight.Location = New System.Drawing.Point(322, 151)
        Me.weight.Name = "weight"
        Me.weight.Size = New System.Drawing.Size(406, 20)
        Me.weight.TabIndex = 30
        '
        'age
        '
        Me.age.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.age.Location = New System.Drawing.Point(322, 174)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(406, 20)
        Me.age.TabIndex = 31
        '
        'pic1
        '
        Me.pic1.Image = CType(resources.GetObject("pic1.Image"), System.Drawing.Image)
        Me.pic1.Location = New System.Drawing.Point(773, 151)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(96, 318)
        Me.pic1.TabIndex = 32
        Me.pic1.TabStop = False
        Me.pic1.Visible = False
        '
        'pic2
        '
        Me.pic2.Image = CType(resources.GetObject("pic2.Image"), System.Drawing.Image)
        Me.pic2.Location = New System.Drawing.Point(773, 151)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(96, 318)
        Me.pic2.TabIndex = 33
        Me.pic2.TabStop = False
        Me.pic2.Visible = False
        '
        'pic3
        '
        Me.pic3.Image = CType(resources.GetObject("pic3.Image"), System.Drawing.Image)
        Me.pic3.Location = New System.Drawing.Point(773, 151)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(96, 318)
        Me.pic3.TabIndex = 34
        Me.pic3.TabStop = False
        Me.pic3.Visible = False
        '
        'pic4
        '
        Me.pic4.Image = CType(resources.GetObject("pic4.Image"), System.Drawing.Image)
        Me.pic4.Location = New System.Drawing.Point(773, 151)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(96, 318)
        Me.pic4.TabIndex = 35
        Me.pic4.TabStop = False
        Me.pic4.Visible = False
        '
        'pic5
        '
        Me.pic5.Image = CType(resources.GetObject("pic5.Image"), System.Drawing.Image)
        Me.pic5.Location = New System.Drawing.Point(773, 151)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(96, 318)
        Me.pic5.TabIndex = 36
        Me.pic5.TabStop = False
        Me.pic5.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 515)
        Me.Controls.Add(Me.pic5)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.weight)
        Me.Controls.Add(Me.high)
        Me.Controls.Add(Me.showbmi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.showtdee)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btncal)
        Me.Controls.Add(Me.showact)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sex)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.famale)
        Me.Controls.Add(Me.male)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "การคำนวนหาค่า BMI, BMR และค่า TDEE"
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents male As System.Windows.Forms.Button
    Friend WithEvents famale As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents sex As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents showact As System.Windows.Forms.Label
    Friend WithEvents btncal As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents showtdee As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents showbmi As System.Windows.Forms.Button
    Friend WithEvents high As System.Windows.Forms.TextBox
    Friend WithEvents weight As System.Windows.Forms.TextBox
    Friend WithEvents age As System.Windows.Forms.TextBox
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents pic4 As System.Windows.Forms.PictureBox
    Friend WithEvents pic5 As System.Windows.Forms.PictureBox

End Class
