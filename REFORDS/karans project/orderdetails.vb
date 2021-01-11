Public Class orderdetails
    Dim amount As Integer
    Dim totalamount As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub orderdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        amount = Label7.Text * Val(TextBox1.Text)
        totalamount = totalamount + amount
        cart.ListBox1.Items.Add(Label5.Text & " - Qty(" & TextBox1.Text & ") - Rs." & amount)
        If MessageBox.Show("Added to cart.", "Done", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = MsgBoxResult.Ok Then
            Me.Hide()
            Label5.Text = "."
            Label7.Text = "."
        End If
        cart.ListBox1.Items.Add("----------------------------------------------------------")
        cart.Label3.Text = totalamount
        TextBox1.Text = ""
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
