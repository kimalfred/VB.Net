Public Class Form2

    Dim ans As Integer
    Dim deduc As Integer
    Dim tax As Integer
    Dim phil As Integer
    Dim s As Integer
    Dim net As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Compute.Click
        ans = ((HourPerDay.Text * NOofDays.Text) * (RatePerHour.Text))
        GrossSalary.Text = ans
        GrossSalary1.Text = ans
        tax = ans * 0.15
        MonthlyWage.Text = tax
        phil = ans * 0.05
        PhilHealth.Text = phil
        s = ans * 0.02
        SSS.Text = s

        deduc = tax + phil + s
        TotalDeduction.Text = deduc
        Deduction.Text = deduc

        net = GrossSalary1.Text - Deduction.Text
        NetSalary.Text = net
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles HourPerDay.TextChanged

    End Sub

    Private Sub NetSalary_TextChanged(sender As Object, e As EventArgs) Handles NetSalary.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class