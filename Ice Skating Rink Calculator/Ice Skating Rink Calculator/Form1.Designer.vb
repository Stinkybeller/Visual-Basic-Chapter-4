<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIceSkatingRink
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDisplayVolume = New System.Windows.Forms.Button()
        Me.txtTotalVolume = New System.Windows.Forms.TextBox()
        Me.lblTotalVolume = New System.Windows.Forms.Label()
        Me.txtDepth = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblDepth = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblFt1 = New System.Windows.Forms.Label()
        Me.lblFt2 = New System.Windows.Forms.Label()
        Me.lblFt3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(524, 422)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(119, 42)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(305, 422)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(119, 42)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDisplayVolume
        '
        Me.btnDisplayVolume.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayVolume.ForeColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnDisplayVolume.Location = New System.Drawing.Point(86, 422)
        Me.btnDisplayVolume.Name = "btnDisplayVolume"
        Me.btnDisplayVolume.Size = New System.Drawing.Size(119, 42)
        Me.btnDisplayVolume.TabIndex = 23
        Me.btnDisplayVolume.Text = "Display Volume"
        Me.btnDisplayVolume.UseVisualStyleBackColor = True
        '
        'txtTotalVolume
        '
        Me.txtTotalVolume.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.txtTotalVolume.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalVolume.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVolume.ForeColor = System.Drawing.Color.White
        Me.txtTotalVolume.Location = New System.Drawing.Point(517, 379)
        Me.txtTotalVolume.Name = "txtTotalVolume"
        Me.txtTotalVolume.Size = New System.Drawing.Size(108, 22)
        Me.txtTotalVolume.TabIndex = 22
        '
        'lblTotalVolume
        '
        Me.lblTotalVolume.AutoSize = True
        Me.lblTotalVolume.CausesValidation = False
        Me.lblTotalVolume.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblTotalVolume.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVolume.ForeColor = System.Drawing.Color.White
        Me.lblTotalVolume.Location = New System.Drawing.Point(383, 363)
        Me.lblTotalVolume.Name = "lblTotalVolume"
        Me.lblTotalVolume.Size = New System.Drawing.Size(148, 42)
        Me.lblTotalVolume.TabIndex = 21
        Me.lblTotalVolume.Text = "Volume:"
        '
        'txtDepth
        '
        Me.txtDepth.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepth.Location = New System.Drawing.Point(161, 301)
        Me.txtDepth.Name = "txtDepth"
        Me.txtDepth.Size = New System.Drawing.Size(108, 26)
        Me.txtDepth.TabIndex = 3
        Me.txtDepth.TabStop = False
        '
        'txtWidth
        '
        Me.txtWidth.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWidth.Location = New System.Drawing.Point(161, 214)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(108, 26)
        Me.txtWidth.TabIndex = 2
        '
        'txtLength
        '
        Me.txtLength.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLength.Location = New System.Drawing.Point(161, 127)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(108, 26)
        Me.txtLength.TabIndex = 1
        '
        'lblDepth
        '
        Me.lblDepth.AutoSize = True
        Me.lblDepth.CausesValidation = False
        Me.lblDepth.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblDepth.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepth.ForeColor = System.Drawing.Color.White
        Me.lblDepth.Location = New System.Drawing.Point(50, 285)
        Me.lblDepth.Name = "lblDepth"
        Me.lblDepth.Size = New System.Drawing.Size(127, 42)
        Me.lblDepth.TabIndex = 16
        Me.lblDepth.Text = "Depth:"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.CausesValidation = False
        Me.lblWidth.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblWidth.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWidth.ForeColor = System.Drawing.Color.White
        Me.lblWidth.Location = New System.Drawing.Point(47, 198)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(130, 42)
        Me.lblWidth.TabIndex = 15
        Me.lblWidth.Text = "Width:"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.CausesValidation = False
        Me.lblLength.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblLength.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.ForeColor = System.Drawing.Color.White
        Me.lblLength.Location = New System.Drawing.Point(33, 111)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(144, 42)
        Me.lblLength.TabIndex = 14
        Me.lblLength.Text = "Length:"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.CausesValidation = False
        Me.lblHeading.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblHeading.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.Location = New System.Drawing.Point(135, 25)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(456, 42)
        Me.lblHeading.TabIndex = 13
        Me.lblHeading.Text = "Ice Skating Rink Calculator"
        '
        'lblFt1
        '
        Me.lblFt1.AutoSize = True
        Me.lblFt1.CausesValidation = False
        Me.lblFt1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblFt1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFt1.ForeColor = System.Drawing.Color.White
        Me.lblFt1.Location = New System.Drawing.Point(275, 131)
        Me.lblFt1.Name = "lblFt1"
        Me.lblFt1.Size = New System.Drawing.Size(28, 22)
        Me.lblFt1.TabIndex = 27
        Me.lblFt1.Text = "Ft"
        '
        'lblFt2
        '
        Me.lblFt2.AutoSize = True
        Me.lblFt2.CausesValidation = False
        Me.lblFt2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblFt2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFt2.ForeColor = System.Drawing.Color.White
        Me.lblFt2.Location = New System.Drawing.Point(275, 218)
        Me.lblFt2.Name = "lblFt2"
        Me.lblFt2.Size = New System.Drawing.Size(28, 22)
        Me.lblFt2.TabIndex = 28
        Me.lblFt2.Text = "Ft"
        '
        'lblFt3
        '
        Me.lblFt3.AutoSize = True
        Me.lblFt3.CausesValidation = False
        Me.lblFt3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblFt3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFt3.ForeColor = System.Drawing.Color.White
        Me.lblFt3.Location = New System.Drawing.Point(275, 305)
        Me.lblFt3.Name = "lblFt3"
        Me.lblFt3.Size = New System.Drawing.Size(28, 22)
        Me.lblFt3.TabIndex = 29
        Me.lblFt3.Text = "Ft"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(309, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(395, 262)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'frmIceSkatingRink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(731, 489)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblFt3)
        Me.Controls.Add(Me.lblFt2)
        Me.Controls.Add(Me.lblFt1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayVolume)
        Me.Controls.Add(Me.txtTotalVolume)
        Me.Controls.Add(Me.lblTotalVolume)
        Me.Controls.Add(Me.txtDepth)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.lblDepth)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmIceSkatingRink"
        Me.Text = "Ice Skating Rink Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDisplayVolume As Button
    Friend WithEvents txtTotalVolume As TextBox
    Friend WithEvents lblTotalVolume As Label
    Friend WithEvents txtDepth As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents lblDepth As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblFt1 As Label
    Friend WithEvents lblFt2 As Label
    Friend WithEvents lblFt3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
