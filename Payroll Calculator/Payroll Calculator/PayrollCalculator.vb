'Program: Payroll Calculator'
'Developer: Izabella Fortunata'
'Date: 10/20/23'
'Purpose: Calculates the net pay after taxes'
Public Class PayrollCalculator
    'Percentage for each tax as decimals'

    Const cdecFICATax As Decimal = 0.0765D
    Const cdecFederalTax As Decimal = 0.22D
    Const CDecStateIncomeTax As Decimal = 0.04D

    Private Sub PayrollCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clearing the form'

        txtBiweeklyIncome.Text = ""
        txtFederalTax.Text = ""
        txtStateIncomeTax.Text = ""
        txtFICATax.Text = ""
        txtNetPay.Focus()
    End Sub
    Private Sub btnNetPay_Click(sender As Object, e As EventArgs) Handles btnNetPay.Click
        'When the user clicks the calculation button, it calculates the net income pay'
        'Defining variales'

        Dim IntBiweeklyIncome As Integer
        Dim decFICATax As Decimal
        Dim decFederalTax As Decimal
        Dim decStateIncomeTax As Decimal
        Dim decTotalNetPay As Decimal

        'Converting variables'

        IntBiweeklyIncome = txtBiweeklyIncome.Text
        IntBiweeklyIncome = Convert.ToInt32(IntBiweeklyIncome)

        'Calculating the taxes and net pay'

        decFICATax = IntBiweeklyIncome * cdecFICATax
        decFederalTax = IntBiweeklyIncome * cdecFederalTax
        decStateIncomeTax = IntBiweeklyIncome * CDecStateIncomeTax
        decTotalNetPay = IntBiweeklyIncome - decFICATax - decFederalTax - decStateIncomeTax

        'Displaying the values'

        txtNetPay.Text = decTotalNetPay.ToString("C")
        txtFICATax.Text = decFICATax.ToString("C")
        txtFederalTax.Text = decFederalTax.ToString("C")
        txtStateIncomeTax.Text = decStateIncomeTax.ToString("C")
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing out the values'

        txtFICATax.Text = ""
        txtFederalTax.Text = ""
        txtStateIncomeTax.Text = ""
        txtNetPay.Text = ""
        txtBiweeklyIncome.Clear()
        txtBiweeklyIncome.Focus()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the program'
        Close()
    End Sub
End Class
