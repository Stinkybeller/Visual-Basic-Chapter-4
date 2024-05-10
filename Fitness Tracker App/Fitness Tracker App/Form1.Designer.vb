<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFitnessTrackerApp
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.txtBirthMonth = New System.Windows.Forms.TextBox()
        Me.txtBirthDay = New System.Windows.Forms.TextBox()
        Me.txtBirthYear = New System.Windows.Forms.TextBox()
        Me.lblSubHeading = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.txtCurrentYear = New System.Windows.Forms.TextBox()
        Me.txtCurrentDay = New System.Windows.Forms.TextBox()
        Me.txtCurrentMonth = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.MediumPurple
        Me.lblHeading.Location = New System.Drawing.Point(152, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(436, 54)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Fitness Tracker App"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Bauhaus 93", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.MediumPurple
        Me.lblFirstName.Location = New System.Drawing.Point(71, 124)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(118, 39)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.MediumPurple
        Me.txtFirstName.Location = New System.Drawing.Point(179, 128)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(152, 35)
        Me.txtFirstName.TabIndex = 2
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.Font = New System.Drawing.Font("Bauhaus 93", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthdate.ForeColor = System.Drawing.Color.MediumPurple
        Me.lblBirthdate.Location = New System.Drawing.Point(72, 192)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(274, 36)
        Me.lblBirthdate.TabIndex = 3
        Me.lblBirthdate.Text = "Birthdate (m/d/y):"
        '
        'txtBirthMonth
        '
        Me.txtBirthMonth.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthMonth.ForeColor = System.Drawing.Color.MediumPurple
        Me.txtBirthMonth.Location = New System.Drawing.Point(340, 192)
        Me.txtBirthMonth.Name = "txtBirthMonth"
        Me.txtBirthMonth.Size = New System.Drawing.Size(67, 35)
        Me.txtBirthMonth.TabIndex = 4
        '
        'txtBirthDay
        '
        Me.txtBirthDay.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthDay.ForeColor = System.Drawing.Color.MediumPurple
        Me.txtBirthDay.Location = New System.Drawing.Point(413, 192)
        Me.txtBirthDay.Name = "txtBirthDay"
        Me.txtBirthDay.Size = New System.Drawing.Size(67, 35)
        Me.txtBirthDay.TabIndex = 5
        '
        'txtBirthYear
        '
        Me.txtBirthYear.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBirthYear.ForeColor = System.Drawing.Color.MediumPurple
        Me.txtBirthYear.Location = New System.Drawing.Point(486, 192)
        Me.txtBirthYear.Name = "txtBirthYear"
        Me.txtBirthYear.Size = New System.Drawing.Size(67, 35)
        Me.txtBirthYear.TabIndex = 6
        '
        'lblSubHeading
        '
        Me.lblSubHeading.AutoSize = True
        Me.lblSubHeading.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubHeading.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSubHeading.Location = New System.Drawing.Point(96, 63)
        Me.lblSubHeading.Name = "lblSubHeading"
        Me.lblSubHeading.Size = New System.Drawing.Size(548, 21)
        Me.lblSubHeading.TabIndex = 7
        Me.lblSubHeading.Text = "Want to calculate how many hours you've exerised in your life?"
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Font = New System.Drawing.Font("Bauhaus 93", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDate.ForeColor = System.Drawing.Color.MediumPurple
        Me.lblCurrentDate.Location = New System.Drawing.Point(72, 265)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(328, 36)
        Me.lblCurrentDate.TabIndex = 8
        Me.lblCurrentDate.Text = "Current Date (m/d/y):"
        '
        'txtCurrentYear
        '
        Me.txtCurrentYear.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentYear.ForeColor = System.Drawing.Color.MediumPurple
        Me.txtCurrentYear.Location = New System.Drawing.Point(541, 265)
        Me.txtCurrentYear.Name = "txtCurrentYear"
        Me.txtCurrentYear.Size = New System.Drawing.Size(67, 35)
        Me.txtCurrentYear.TabIndex = 11
        '
        'txtCurrentDay
        '
        Me.txtCurrentDay.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentDay.ForeColor = System.Drawing.Color.MediumPurple
        Me.txtCurrentDay.Location = New System.Drawing.Point(468, 265)
        Me.txtCurrentDay.Name = "txtCurrentDay"
        Me.txtCurrentDay.Size = New System.Drawing.Size(67, 35)
        Me.txtCurrentDay.TabIndex = 10
        '
        'txtCurrentMonth
        '
        Me.txtCurrentMonth.Font = New System.Drawing.Font("Bauhaus 93", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentMonth.ForeColor = System.Drawing.Color.MediumPurple
        Me.txtCurrentMonth.Location = New System.Drawing.Point(395, 265)
        Me.txtCurrentMonth.Name = "txtCurrentMonth"
        Me.txtCurrentMonth.Size = New System.Drawing.Size(67, 35)
        Me.txtCurrentMonth.TabIndex = 9
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Bauhaus 93", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotal.Location = New System.Drawing.Point(157, 331)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(383, 24)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "You have exercised xx hours in your life!"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.MediumPurple
        Me.btnCalculate.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.White
        Me.btnCalculate.Location = New System.Drawing.Point(100, 393)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 43)
        Me.btnCalculate.TabIndex = 14
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumPurple
        Me.btnClear.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(310, 393)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 43)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MediumPurple
        Me.btnExit.Font = New System.Drawing.Font("Bauhaus 93", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(520, 393)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 43)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.Image = Global.Fitness_Tracker_App.My.Resources.Resources.images
        Me.picLogo.Location = New System.Drawing.Point(580, 9)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(60, 50)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 17
        Me.picLogo.TabStop = False
        '
        'frmFitnessTrackerApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(740, 470)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtCurrentYear)
        Me.Controls.Add(Me.txtCurrentDay)
        Me.Controls.Add(Me.txtCurrentMonth)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.lblSubHeading)
        Me.Controls.Add(Me.txtBirthYear)
        Me.Controls.Add(Me.txtBirthDay)
        Me.Controls.Add(Me.txtBirthMonth)
        Me.Controls.Add(Me.lblBirthdate)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmFitnessTrackerApp"
        Me.Text = "Fitness Tracker App"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblBirthdate As Label
    Friend WithEvents txtBirthMonth As TextBox
    Friend WithEvents txtBirthDay As TextBox
    Friend WithEvents txtBirthYear As TextBox
    Friend WithEvents lblSubHeading As Label
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents txtCurrentYear As TextBox
    Friend WithEvents txtCurrentDay As TextBox
    Friend WithEvents txtCurrentMonth As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picLogo As PictureBox
End Class
