Public Class login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Please complete the required fields..", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox1.Text = "admin" Or TextBox2.Text = "admin" Then
            menupg.Show()
            Me.Hide()
        ElseIf TextBox1.Text = "customer_2" Or TextBox2.Text = "22345" Then
            menupg.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username and Password do not match..", "Authentication Faliure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBox1.Text = ""
            TextBox2.Text = ""

            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        registration.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Are you sure you want to quit?", "Quit Application", MessageBoxButtons.OKCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub
End Class