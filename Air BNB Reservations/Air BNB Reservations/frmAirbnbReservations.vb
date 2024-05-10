'Program: Airbnb Reservations'
'Developer: Izabella Fortunata'
'Date: 10/17/23'
'Purpose: Calculates the cost of a number of nights stays at an Airbnb'
Public Class frmAirBnBReservations
    'Cost each night of the Airbnb'
    Const _cdecPricePerDay As Decimal = 99D

    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        'When the user clicks the diplay cost button, it calculates and displays the price for how many nights that the user put in.'

        'Declare variables'
        Dim strNumberOfDays As String
        Dim intNumberOfDays As Integer
        Dim decTotalCost As Decimal

        'Converting variables'
        strNumberOfDays = txtNumberOfDays.Text
        intNumberOfDays = Convert.ToInt32(strNumberOfDays)

        'Calculating the total and outputing'
        decTotalCost = intNumberOfDays * _cdecPricePerDay
        txtCostOfStay.Text = decTotalCost.ToString("C")
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing out the values'
        txtNumberOfDays.Clear()
        txtCostOfStay.Text = ""
        txtNumberOfDays.Focus()
    End Sub

    Private Sub frmAirbnbReservations_load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'Clears the form'
        lblPricePerDay.Text = _cdecPricePerDay.ToString("C") & " per Day!"
        txtCostOfStay.Text = ""
        txtNumberOfDays.Focus()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the program'
        Close()
    End Sub

End Class
