Public Class registration

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.SelectedItem = "" Then
            MessageBox.Show("Please complete the required fields..", "Inappropriate Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MessageBox.Show("Please note down your ID = customer_2 & Password = 22345", "SUCCESSFULL REGISTRATION", MessageBoxButtons.OK, MessageBoxIcon.Information) = MsgBoxResult.Ok Then
            login.Show()
            Me.Hide()
        End If
        

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Are you sure you want to cancel registration", "Cancel registration", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
            login.Show()
            Me.Hide()
        End If

    End Sub
End Class