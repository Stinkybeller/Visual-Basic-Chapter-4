<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDriverlessUberCar
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblCostPerMile = New System.Windows.Forms.Label()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.picUber = New System.Windows.Forms.PictureBox()
        Me.lblMiles = New System.Windows.Forms.Label()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.txtFinalCost = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFlatRate = New System.Windows.Forms.Label()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHeading.Font = New System.Drawing.Font("Segoe UI Symbol", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.Location = New System.Drawing.Point(113, 26)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(279, 40)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Driverless Uber Car"
        '
        'lblCostPerMile
        '
        Me.lblCostPerMile.AutoSize = True
        Me.lblCostPerMile.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCostPerMile.Font = New System.Drawing.Font("Segoe UI Symbol", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerMile.ForeColor = System.Drawing.Color.White
        Me.lblCostPerMile.Location = New System.Drawing.Point(169, 63)
        Me.lblCostPerMile.Name = "lblCostPerMile"
        Me.lblCostPerMile.Size = New System.Drawing.Size(167, 28)
        Me.lblCostPerMile.TabIndex = 2
        Me.lblCostPerMile.Text = " $X.XX per Mile!"
        '
        'picBack
        '
        Me.picBack.Image = Global.Driverless_Uber_Car.My.Resources.Resources.download
        Me.picBack.Location = New System.Drawing.Point(-5, 0)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(515, 382)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBack.TabIndex = 3
        Me.picBack.TabStop = False
        '
        'picUber
        '
        Me.picUber.Image = Global.Driverless_Uber_Car.My.Resources.Resources.Ubwer
        Me.picUber.Location = New System.Drawing.Point(-5, 370)
        Me.picUber.Name = "picUber"
        Me.picUber.Size = New System.Drawing.Size(515, 244)
        Me.picUber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picUber.TabIndex = 1
        Me.picUber.TabStop = False
        '
        'lblMiles
        '
        Me.lblMiles.AutoSize = True
        Me.lblMiles.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMiles.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiles.ForeColor = System.Drawing.Color.White
        Me.lblMiles.Location = New System.Drawing.Point(184, 132)
        Me.lblMiles.Name = "lblMiles"
        Me.lblMiles.Size = New System.Drawing.Size(73, 30)
        Me.lblMiles.TabIndex = 4
        Me.lblMiles.Text = "Miles:"
        '
        'txtMiles
        '
        Me.txtMiles.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiles.Location = New System.Drawing.Point(263, 137)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(50, 25)
        Me.txtMiles.TabIndex = 5
        '
        'txtFinalCost
        '
        Me.txtFinalCost.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFinalCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFinalCost.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalCost.ForeColor = System.Drawing.Color.White
        Me.txtFinalCost.Location = New System.Drawing.Point(292, 202)
        Me.txtFinalCost.Name = "txtFinalCost"
        Me.txtFinalCost.Size = New System.Drawing.Size(66, 18)
        Me.txtFinalCost.TabIndex = 6
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTotalCost.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.White
        Me.lblTotalCost.Location = New System.Drawing.Point(164, 193)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(122, 30)
        Me.lblTotalCost.TabIndex = 7
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.BackColor = System.Drawing.Color.White
        Me.btnDisplayCost.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayCost.Location = New System.Drawing.Point(55, 294)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(104, 39)
        Me.btnDisplayCost.TabIndex = 9
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(200, 294)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 39)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(333, 294)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 39)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblFlatRate
        '
        Me.lblFlatRate.AutoSize = True
        Me.lblFlatRate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFlatRate.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlatRate.ForeColor = System.Drawing.Color.White
        Me.lblFlatRate.Location = New System.Drawing.Point(166, 223)
        Me.lblFlatRate.Name = "lblFlatRate"
        Me.lblFlatRate.Size = New System.Drawing.Size(142, 17)
        Me.lblFlatRate.TabIndex = 12
        Me.lblFlatRate.Text = "$X.XX Fee at pickup"
        '
        'frmDriverlessUberCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 606)
        Me.Controls.Add(Me.lblFlatRate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.txtFinalCost)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.lblMiles)
        Me.Controls.Add(Me.lblCostPerMile)
        Me.Controls.Add(Me.picUber)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picBack)
        Me.Name = "frmDriverlessUberCar"
        Me.Text = "Driverless Uber Car"
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picUber As PictureBox
    Friend WithEvents lblCostPerMile As Label
    Friend WithEvents picBack As PictureBox
    Friend WithEvents lblMiles As Label
    Friend WithEvents txtMiles As TextBox
    Friend WithEvents txtFinalCost As TextBox
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFlatRate As Label
End Class
