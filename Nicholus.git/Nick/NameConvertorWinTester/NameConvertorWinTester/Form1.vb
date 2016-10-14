'Imports NameConvertor

Public Class Form1

    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        Dim myConvertor As New NameConvertor.NameConvertor

        Label1.Text = myConvertor.ReverseName(txtFirstName.Text)
    End Sub
End Class
