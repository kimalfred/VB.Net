Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbl1.Click

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles coursetxt.TextChanged

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listbox.SelectedIndexChanged

    End Sub

    Private Sub Birthday_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bday.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Hi!" & txtname.Text & vbNewLine & "Your Bday: " & bday.Text & cmdday.Text & vbNewLine & cmdday2.Text & vbNewLine)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Listbox.Items.Add(nametxt.Text & vbNewLine & coursetxt.Text & vbNewLine & sectiontxt.Text & vbNewLine & addresstxt.Text & vbNewLine & emailtxt.Text)
    End Sub
End Class