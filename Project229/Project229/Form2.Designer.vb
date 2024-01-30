<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSignEmail = New System.Windows.Forms.TextBox()
        Me.txtSignPassword = New System.Windows.Forms.TextBox()
        Me.txtMobileNumber = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.btnCreat = New System.Windows.Forms.Button()
        Me.btnBackRegister = New System.Windows.Forms.Button()
        Me.lblNot = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(485, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PowderBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PowderBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(360, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.PowderBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.PowderBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(249, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mobile Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.PowderBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(380, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 29)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Age:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(500, 225)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(195, 27)
        Me.txtName.TabIndex = 7
        '
        'txtSignEmail
        '
        Me.txtSignEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignEmail.Location = New System.Drawing.Point(500, 140)
        Me.txtSignEmail.Name = "txtSignEmail"
        Me.txtSignEmail.Size = New System.Drawing.Size(195, 27)
        Me.txtSignEmail.TabIndex = 8
        '
        'txtSignPassword
        '
        Me.txtSignPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSignPassword.Location = New System.Drawing.Point(500, 181)
        Me.txtSignPassword.Name = "txtSignPassword"
        Me.txtSignPassword.Size = New System.Drawing.Size(195, 27)
        Me.txtSignPassword.TabIndex = 9
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNumber.Location = New System.Drawing.Point(500, 271)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(195, 27)
        Me.txtMobileNumber.TabIndex = 10
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(500, 311)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(195, 27)
        Me.txtAge.TabIndex = 11
        '
        'btnCreat
        '
        Me.btnCreat.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnCreat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreat.Location = New System.Drawing.Point(697, 403)
        Me.btnCreat.Name = "btnCreat"
        Me.btnCreat.Size = New System.Drawing.Size(78, 37)
        Me.btnCreat.TabIndex = 13
        Me.btnCreat.Text = "Sign in"
        Me.btnCreat.UseVisualStyleBackColor = False
        '
        'btnBackRegister
        '
        Me.btnBackRegister.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnBackRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackRegister.Location = New System.Drawing.Point(267, 454)
        Me.btnBackRegister.Name = "btnBackRegister"
        Me.btnBackRegister.Size = New System.Drawing.Size(78, 37)
        Me.btnBackRegister.TabIndex = 15
        Me.btnBackRegister.Text = "Back"
        Me.btnBackRegister.UseVisualStyleBackColor = False
        '
        'lblNot
        '
        Me.lblNot.AutoSize = True
        Me.lblNot.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNot.Location = New System.Drawing.Point(454, 424)
        Me.lblNot.Name = "lblNot"
        Me.lblNot.Size = New System.Drawing.Size(64, 16)
        Me.lblNot.TabIndex = 16
        Me.lblNot.Text = "                   "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1102, 522)
        Me.Controls.Add(Me.lblNot)
        Me.Controls.Add(Me.btnBackRegister)
        Me.Controls.Add(Me.btnCreat)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtMobileNumber)
        Me.Controls.Add(Me.txtSignPassword)
        Me.Controls.Add(Me.txtSignEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSignEmail As TextBox
    Friend WithEvents txtSignPassword As TextBox
    Friend WithEvents txtMobileNumber As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnCreat As Button
    Friend WithEvents btnBackRegister As Button
    Friend WithEvents lblNot As Label
End Class
