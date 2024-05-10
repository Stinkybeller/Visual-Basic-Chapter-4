'Program Name: Fitness Tracker App
'Developer: Izabella Fortunata
'Date: 10/31/23
'Purpose: The app calculates how many hours a person has exercised in their life.
Public Class frmFitnessTrackerApp
    'Constants that are used in the calculation, defined'
    Const cdecDaysPerYear As Integer = 365
    Const cdecDaysPerMonth As Integer = 30
    Const cdecDaysPerWeek As Integer = 7
    Const cdecExercisePerWeek As Integer = 2.5
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clearing the form'
        txtFirstName.Focus()
        lblTotal.Text = ""

    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'When the user clicks the calculate button, it calculates the hours that they have exercised in their life'
        'Declaring the variables'
        Dim strFirstName As String
        Dim strBirthDay As String
        Dim strBirthMonth As String
        Dim strBirthYear As String
        Dim intBirthDay As Integer
        Dim intBirthMonth As Integer
        Dim intBirthYear As Integer
        Dim strCurrentDay As String
        Dim strCurrentMonth As String
        Dim strCurrentYear As String
        Dim intCurrentDay As Integer
        Dim intCurrentMonth As Integer
        Dim intCurrentYear As Integer
        Dim intTotalYears As Integer
        Dim intYearDays As Integer
        Dim intTotalMonths As Integer
        Dim intMonthDays As Integer
        Dim intTotalDays As Integer
        Dim intDays As Integer
        Dim intTotalWeeks As Integer
        Dim intHoursOfExercise As Integer

        'Converting varibles'
        strFirstName = txtFirstName.Text
        strBirthDay = txtBirthDay.Text
        intBirthDay = Convert.ToInt32(strBirthDay)
        strBirthMonth = txtBirthMonth.Text
        intBirthMonth = Convert.ToInt32(strBirthMonth)
        strBirthYear = txtBirthYear.Text
        intBirthYear = Convert.ToInt32(strBirthYear)
        strCurrentDay = txtCurrentDay.Text
        intCurrentDay = Convert.ToInt32(strCurrentDay)
        strCurrentMonth = txtCurrentMonth.Text
        intCurrentMonth = Convert.ToInt32(strCurrentMonth)
        strCurrentYear = txtCurrentYear.Text
        intCurrentYear = Convert.ToInt32(strCurrentYear)

        'Calculating the total hours'
        intTotalYears = intCurrentYear - intBirthYear
        intYearDays = intTotalYears * cdecDaysPerYear
        intTotalMonths = intCurrentMonth - intBirthMonth
        intMonthDays = intTotalMonths * cdecDaysPerMonth
        intTotalDays = intCurrentDay - intBirthDay
        intDays = intTotalDays + intMonthDays + intYearDays
        intTotalWeeks = intDays / cdecDaysPerWeek
        intHoursOfExercise = intTotalWeeks * cdecExercisePerWeek

        'Displaying the output data'
        lblTotal.Text = strFirstName & ", you have exercised " & intHoursOfExercise & " hours in your life!"
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing the values in the form'
        txtFirstName.Clear()
        txtFirstName.Focus()
        txtBirthDay.Clear()
        txtBirthMonth.Clear()
        txtBirthYear.Clear()
        txtCurrentDay.Clear()
        txtCurrentMonth.Clear()
        txtCurrentYear.Clear()
        lblTotal.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the program'
        Close()
    End Sub
End Class
