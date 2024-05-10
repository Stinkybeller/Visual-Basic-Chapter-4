<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PayrollCalculator
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
        Me.lblPayrollCalculator = New System.Windows.Forms.Label()
        Me.lblTaxes = New System.Windows.Forms.Label()
        Me.lblBiweeklyIncome = New System.Windows.Forms.Label()
        Me.txtBiweeklyIncome = New System.Windows.Forms.TextBox()
        Me.btnNetPay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFICATax = New System.Windows.Forms.Label()
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.txtFederalTax = New System.Windows.Forms.TextBox()
        Me.lblStateIncomeTax = New System.Windows.Forms.Label()
        Me.txtStateIncomeTax = New System.Windows.Forms.TextBox()
        Me.lblTotalNetPay = New System.Windows.Forms.Label()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.txtFICATax = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPayrollCalculator
        '
        Me.lblPayrollCalculator.AutoSize = True
        Me.lblPayrollCalculator.Font = New System.Drawing.Font("Microsoft Tai Le", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayrollCalculator.Location = New System.Drawing.Point(98, 9)
        Me.lblPayrollCalculator.Name = "lblPayrollCalculator"
        Me.lblPayrollCalculator.Size = New System.Drawing.Size(223, 34)
        Me.lblPayrollCalculator.TabIndex = 0
        Me.lblPayrollCalculator.Text = "Payroll Calculator"
        '
        'lblTaxes
        '
        Me.lblTaxes.AutoSize = True
        Me.lblTaxes.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTaxes.Location = New System.Drawing.Point(39, 43)
        Me.lblTaxes.Name = "lblTaxes"
        Me.lblTaxes.Size = New System.Drawing.Size(340, 17)
        Me.lblTaxes.TabIndex = 1
        Me.lblTaxes.Text = "FICA tax (7.65%), federal tax (22%), state income tax (4%)"
        '
        'lblBiweeklyIncome
        '
        Me.lblBiweeklyIncome.AutoSize = True
        Me.lblBiweeklyIncome.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBiweeklyIncome.Location = New System.Drawing.Point(86, 82)
        Me.lblBiweeklyIncome.Name = "lblBiweeklyIncome"
        Me.lblBiweeklyIncome.Size = New System.Drawing.Size(170, 26)
        Me.lblBiweeklyIncome.TabIndex = 3
        Me.lblBiweeklyIncome.Text = "Biweekly income:"
        '
        'txtBiweeklyIncome
        '
        Me.txtBiweeklyIncome.Location = New System.Drawing.Point(262, 87)
        Me.txtBiweeklyIncome.Name = "txtBiweeklyIncome"
        Me.txtBiweeklyIncome.Size = New System.Drawing.Size(100, 20)
        Me.txtBiweeklyIncome.TabIndex = 4
        '
        'btnNetPay
        '
        Me.btnNetPay.BackColor = System.Drawing.Color.White
        Me.btnNetPay.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNetPay.Location = New System.Drawing.Point(42, 396)
        Me.btnNetPay.Name = "btnNetPay"
        Me.btnNetPay.Size = New System.Drawing.Size(88, 33)
        Me.btnNetPay.TabIndex = 5
        Me.btnNetPay.Text = "Calculate"
        Me.btnNetPay.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(162, 396)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 33)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(288, 396)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 33)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblFICATax
        '
        Me.lblFICATax.AutoSize = True
        Me.lblFICATax.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICATax.Location = New System.Drawing.Point(123, 144)
        Me.lblFICATax.Name = "lblFICATax"
        Me.lblFICATax.Size = New System.Drawing.Size(98, 26)
        Me.lblFICATax.TabIndex = 8
        Me.lblFICATax.Text = "FICA Tax:"
        '
        'lblFederalTax
        '
        Me.lblFederalTax.AutoSize = True
        Me.lblFederalTax.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTax.Location = New System.Drawing.Point(99, 202)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(122, 26)
        Me.lblFederalTax.TabIndex = 10
        Me.lblFederalTax.Text = "Federal Tax:"
        '
        'txtFederalTax
        '
        Me.txtFederalTax.BackColor = System.Drawing.Color.AliceBlue
        Me.txtFederalTax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFederalTax.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFederalTax.Location = New System.Drawing.Point(217, 208)
        Me.txtFederalTax.Name = "txtFederalTax"
        Me.txtFederalTax.Size = New System.Drawing.Size(100, 16)
        Me.txtFederalTax.TabIndex = 11
        Me.txtFederalTax.Text = "$888.88"
        '
        'lblStateIncomeTax
        '
        Me.lblStateIncomeTax.AutoSize = True
        Me.lblStateIncomeTax.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateIncomeTax.Location = New System.Drawing.Point(44, 260)
        Me.lblStateIncomeTax.Name = "lblStateIncomeTax"
        Me.lblStateIncomeTax.Size = New System.Drawing.Size(177, 26)
        Me.lblStateIncomeTax.TabIndex = 12
        Me.lblStateIncomeTax.Text = "State Income Tax:"
        '
        'txtStateIncomeTax
        '
        Me.txtStateIncomeTax.BackColor = System.Drawing.Color.AliceBlue
        Me.txtStateIncomeTax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStateIncomeTax.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStateIncomeTax.Location = New System.Drawing.Point(217, 266)
        Me.txtStateIncomeTax.Name = "txtStateIncomeTax"
        Me.txtStateIncomeTax.Size = New System.Drawing.Size(100, 16)
        Me.txtStateIncomeTax.TabIndex = 14
        Me.txtStateIncomeTax.Text = "$777.77"
        '
        'lblTotalNetPay
        '
        Me.lblTotalNetPay.AutoSize = True
        Me.lblTotalNetPay.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNetPay.Location = New System.Drawing.Point(95, 322)
        Me.lblTotalNetPay.Name = "lblTotalNetPay"
        Me.lblTotalNetPay.Size = New System.Drawing.Size(142, 26)
        Me.lblTotalNetPay.TabIndex = 15
        Me.lblTotalNetPay.Text = "Total Net Pay:"
        '
        'txtNetPay
        '
        Me.txtNetPay.BackColor = System.Drawing.Color.AliceBlue
        Me.txtNetPay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNetPay.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetPay.Location = New System.Drawing.Point(232, 328)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.Size = New System.Drawing.Size(100, 16)
        Me.txtNetPay.TabIndex = 16
        Me.txtNetPay.Text = "$666.66"
        '
        'txtFICATax
        '
        Me.txtFICATax.BackColor = System.Drawing.Color.AliceBlue
        Me.txtFICATax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFICATax.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFICATax.Location = New System.Drawing.Point(217, 150)
        Me.txtFICATax.Name = "txtFICATax"
        Me.txtFICATax.Size = New System.Drawing.Size(100, 16)
        Me.txtFICATax.TabIndex = 17
        Me.txtFICATax.Text = "$888.88"
        '
        'PayrollCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(419, 486)
        Me.Controls.Add(Me.txtFICATax)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.lblTotalNetPay)
        Me.Controls.Add(Me.txtStateIncomeTax)
        Me.Controls.Add(Me.lblStateIncomeTax)
        Me.Controls.Add(Me.txtFederalTax)
        Me.Controls.Add(Me.lblFederalTax)
        Me.Controls.Add(Me.lblFICATax)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnNetPay)
        Me.Controls.Add(Me.txtBiweeklyIncome)
        Me.Controls.Add(Me.lblBiweeklyIncome)
        Me.Controls.Add(Me.lblTaxes)
        Me.Controls.Add(Me.lblPayrollCalculator)
        Me.Name = "PayrollCalculator"
        Me.Text = "Payroll Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPayrollCalculator As Label
    Friend WithEvents lblTaxes As Label
    Friend WithEvents lblBiweeklyIncome As Label
    Friend WithEvents txtBiweeklyIncome As TextBox
    Friend WithEvents btnNetPay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFICATax As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents txtFederalTax As TextBox
    Friend WithEvents lblStateIncomeTax As Label
    Friend WithEvents txtStateIncomeTax As TextBox
    Friend WithEvents lblTotalNetPay As Label
    Friend WithEvents txtNetPay As TextBox
    Friend WithEvents txtFICATax As TextBox
End Class
