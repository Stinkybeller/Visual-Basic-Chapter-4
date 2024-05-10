'Program: Ice Skating Rink Calculator'
'Developer: Izabella Fortunata'
'Date: 10/31/23'
'Purpose: Calculates the volume of an ice skating rink'
Public Class frmIceSkatingRink
    Private Sub frmIceSkatingRink_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clearing the form'

        txtLength.Text = ""
        txtLength.Focus()
        txtWidth.Text = ""
        txtWidth.Focus()
        txtDepth.Text = ""
        txtDepth.Focus()

    End Sub
    Private Sub btnDisplayVolume_Click(sender As Object, e As EventArgs) Handles btnDisplayVolume.Click
        'When the user clicks the display volume button, it calculates the net income pay'
        'Defining the variables'
        Dim decLength As Decimal
        Dim decWidth As Decimal
        Dim decDepth As Decimal
        Dim decTotalVolume As Decimal

        'Coverting the variables'
        decLength = txtLength.Text
        decLength = Convert.ToDecimal(decLength)

        decWidth = txtWidth.Text
        decWidth = Convert.ToDecimal(decWidth)

        decDepth = txtDepth.Text
        decDepth = Convert.ToDecimal(decDepth)

        'Calculating the volume of the ice skating rink'
        decTotalVolume = decLength * decWidth * decDepth

        'Displaying the final volume'
        txtTotalVolume.Text = decTotalVolume.ToString("N") & " Feet"
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing out the program'

        txtLength.Text = ""
        txtDepth.Text = ""
        txtWidth.Text = ""
        txtTotalVolume.Text = ""
        txtLength.Clear()
        txtDepth.Clear()
        txtWidth.Clear()
        txtTotalVolume.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the program'

        Close()
    End Sub
End Class
