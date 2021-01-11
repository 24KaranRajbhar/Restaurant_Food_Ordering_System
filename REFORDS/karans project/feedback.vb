Public Class feedback

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RichTextBox1.Text = "" Then
            MessageBox.Show("Please fullfill the required field.", "No Feedback", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf MessageBox.Show("Thanks for your feedback..We will soon work on it.", "Feedback submitted", MessageBoxButtons.OK, MessageBoxIcon.Information) = MsgBoxResult.Ok Then
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class