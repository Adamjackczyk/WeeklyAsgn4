Option Strict On
Public Class Form1


    Private Sub TxtNumberOfNights_TextChanged(sender As Object, e As EventArgs) Handles TxtNumberOfNights.TextChanged

    End Sub

    Private Sub LblHeader_Click(sender As Object, e As EventArgs) Handles LblHeader.Click

    End Sub

    Private Sub BtnCost_Click(sender As Object, e As EventArgs) Handles BtnCost.Click
        Const _cdecPricePerDay As Decimal = 79D
        Dim strNumOfDays As String
        Dim intNumOfDays As Integer
        Dim decTotalCost As Decimal
        strNumOfDays = TxtNumberOfNights.Text
        intNumOfDays = Convert.ToInt32(strNumOfDays)
        decTotalCost = intNumOfDays * _cdecPricePerDay
        LblCostNum.Text = decTotalCost.ToString("C")

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtNumberOfNights.Clear()
        LblCostNum.Text = ""

    End Sub
End Class
