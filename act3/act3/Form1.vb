Imports System.Runtime.Intrinsics.X86

Public Class Form1
    Dim total As Double
    Dim mat, ep, co, pc As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles compute.Click
        mat = Math.Text
        ep = Physical.Text
        co = Oral.Text
        pc = comprog.Text
        total = (mat + ep + co + pc) / 4
        Average.Text = total

        If (total >= 75) Then
            Remarks.Text = ("Aral kapa")
            Grade.Text = (3.0)

        Else
            MsgBox("bawi ka erp")
            Remarks.Text = ("Magdrop kana tanga")
            Grade.Text = (5.0)

        End If

        If (total >= 80) Then
            Remarks.Text = ("Malapit kana")
            Grade.Text = (2.75)


        End If

        If (total >= 85) Then
            Remarks.Text = ("Naku Pwede na")
            Grade.Text = (2.5)


        End If

        If (total >= 90) Then
            Remarks.Text = ("Nadali mo!")
            Grade.Text = (1.75)


        End If

        If (total >= 95) Then
            Remarks.Text = ("Conrats nigs")
            Grade.Text = (1.25)
        End If














    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles OC.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
