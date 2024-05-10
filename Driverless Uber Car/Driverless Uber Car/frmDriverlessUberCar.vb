'Program: Driverless Uber Car'
'Developer: Izabella Fortunata'
'Date: 10/18/23'
'Purpose: Calculates the cost of the number of miles a Driverless Uber costs'
Public Class frmDriverlessUberCar
    'Cost each mile with flatrate each pickup'
    Const cdecCostPerMile As Decimal = 1.85D
    Const cdecFlatRate As Decimal = 2.85D
    Private Sub frmDriverlessUberCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clearing the form, including the prices'
        lblCostPerMile.Text = cdecCostPerMile.ToString("C") & " per Mile!"
        lblFlatRate.Text = cdecFlatRate.ToString("C") & " Fee at pickup"
        txtMiles.Text = ""
        txtFinalCost.Focus()
    End Sub
    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        'When the user clicks the display cost button, it calculates and displays the price for how many number of miles that was inputed.'
        Dim strMiles As String
        Dim intMiles As Integer
        Dim decTotalCost As Decimal

        strMiles = txtMiles.Text
        intMiles = Convert.ToInt32(strMiles)

        decTotalCost = intMiles * cdecCostPerMile + cdecFlatRate
        txtFinalCost.Text = decTotalCost.ToString("C")
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing out the values'
        txtMiles.Clear()
        txtFinalCost.Text = ""
        txtMiles.Focus()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the program'
        Close()
    End Sub
End Class
