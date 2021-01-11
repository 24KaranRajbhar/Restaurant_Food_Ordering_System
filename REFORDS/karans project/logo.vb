Public Class logo

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        If ProgressBar1.Value > 99 Then
            Timer1.Enabled = False
            login.Show()
            Me.Hide()
        End If
    End Sub
End Class
