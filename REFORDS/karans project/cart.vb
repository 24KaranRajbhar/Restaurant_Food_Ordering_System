Public Class cart

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       If MessageBox.Show("Oredered item will be get to you in mean time..TNANKS FOR ORDERING", "HAPPY ORDERING :)", MessageBoxButtons.OK, MessageBoxIcon.Information) = MsgBoxResult.Ok Then
            Me.Hide()
            menupg.Show()
        End If

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class