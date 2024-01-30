<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicA = New System.Windows.Forms.PictureBox()
        Me.PicC = New System.Windows.Forms.PictureBox()
        Me.PicApple = New System.Windows.Forms.PictureBox()
        Me.PicBook = New System.Windows.Forms.PictureBox()
        Me.PicCat = New System.Windows.Forms.PictureBox()
        Me.btnLevel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PicB = New System.Windows.Forms.PictureBox()
        CType(Me.PicA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicApple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Honeydew
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(637, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lets see your spelling of alphabets and words"
        '
        'PicA
        '
        Me.PicA.Image = CType(resources.GetObject("PicA.Image"), System.Drawing.Image)
        Me.PicA.Location = New System.Drawing.Point(180, 86)
        Me.PicA.Name = "PicA"
        Me.PicA.Size = New System.Drawing.Size(190, 159)
        Me.PicA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicA.TabIndex = 0
        Me.PicA.TabStop = False
        '
        'PicC
        '
        Me.PicC.Image = CType(resources.GetObject("PicC.Image"), System.Drawing.Image)
        Me.PicC.Location = New System.Drawing.Point(686, 82)
        Me.PicC.Name = "PicC"
        Me.PicC.Size = New System.Drawing.Size(190, 159)
        Me.PicC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicC.TabIndex = 1
        Me.PicC.TabStop = False
        Me.PicC.Visible = False
        '
        'PicApple
        '
        Me.PicApple.Image = CType(resources.GetObject("PicApple.Image"), System.Drawing.Image)
        Me.PicApple.Location = New System.Drawing.Point(180, 275)
        Me.PicApple.Name = "PicApple"
        Me.PicApple.Size = New System.Drawing.Size(190, 159)
        Me.PicApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicApple.TabIndex = 1
        Me.PicApple.TabStop = False
        Me.PicApple.Visible = False
        '
        'PicBook
        '
        Me.PicBook.Image = CType(resources.GetObject("PicBook.Image"), System.Drawing.Image)
        Me.PicBook.Location = New System.Drawing.Point(435, 275)
        Me.PicBook.Name = "PicBook"
        Me.PicBook.Size = New System.Drawing.Size(190, 159)
        Me.PicBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBook.TabIndex = 1
        Me.PicBook.TabStop = False
        Me.PicBook.Visible = False
        '
        'PicCat
        '
        Me.PicCat.Image = CType(resources.GetObject("PicCat.Image"), System.Drawing.Image)
        Me.PicCat.Location = New System.Drawing.Point(686, 271)
        Me.PicCat.Name = "PicCat"
        Me.PicCat.Size = New System.Drawing.Size(190, 159)
        Me.PicCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCat.TabIndex = 1
        Me.PicCat.TabStop = False
        Me.PicCat.Visible = False
        '
        'btnLevel
        '
        Me.btnLevel.BackColor = System.Drawing.Color.PaleGreen
        Me.btnLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel.Location = New System.Drawing.Point(676, 453)
        Me.btnLevel.Name = "btnLevel"
        Me.btnLevel.Size = New System.Drawing.Size(110, 43)
        Me.btnLevel.TabIndex = 3
        Me.btnLevel.Text = "Next Level"
        Me.btnLevel.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.PaleGreen
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(265, 453)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 43)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PicB
        '
        Me.PicB.Image = CType(resources.GetObject("PicB.Image"), System.Drawing.Image)
        Me.PicB.Location = New System.Drawing.Point(435, 82)
        Me.PicB.Name = "PicB"
        Me.PicB.Size = New System.Drawing.Size(190, 159)
        Me.PicB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicB.TabIndex = 1
        Me.PicB.TabStop = False
        Me.PicB.Visible = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1103, 513)
        Me.Controls.Add(Me.PicApple)
        Me.Controls.Add(Me.PicBook)
        Me.Controls.Add(Me.PicCat)
        Me.Controls.Add(Me.PicC)
        Me.Controls.Add(Me.PicA)
        Me.Controls.Add(Me.PicB)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLevel)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PicA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicApple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PicA As PictureBox
    Friend WithEvents PicC As PictureBox
    Friend WithEvents PicApple As PictureBox
    Friend WithEvents PicBook As PictureBox
    Friend WithEvents PicCat As PictureBox
    Friend WithEvents btnLevel As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PicB As PictureBox
End Class
