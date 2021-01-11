Public Class icecream
    Dim itemprice As Integer
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        orderdetails.Show()
        itemprice = 80
        orderdetails.Label5.Text = "Choco Cherry"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.MouseHover
        PictureBox1.Image = PictureBox8.Image()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.MouseHover
        PictureBox1.Image = PictureBox9.Image()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        menupg.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox1.Image = PictureBox3.Image()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        PictureBox1.Image = PictureBox4.Image()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover
        PictureBox1.Image = PictureBox5.Image()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.MouseHover
        PictureBox1.Image = PictureBox7.Image()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.MouseHover
        PictureBox1.Image = PictureBox6.Image()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.MouseHover
        PictureBox1.Image = PictureBox11.Image()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.MouseHover
        PictureBox1.Image = PictureBox10.Image()
    End Sub

    Private Sub PictureBox9_Click_1(sender As Object, e As EventArgs) Handles PictureBox9.MouseHover
        PictureBox1.Image = PictureBox9.Image()
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        orderdetails.Show()
        itemprice = 50
        orderdetails.Label5.Text = "Choco Cubs Berry"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        orderdetails.Show()
        itemprice = 150
        orderdetails.Label5.Text = "Ice Cream Napkins"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        orderdetails.Show()
        itemprice = 120
        orderdetails.Label5.Text = "Icecream Berry Rolls"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles PictureBox7.Click
        orderdetails.Show()
        itemprice = 70
        orderdetails.Label5.Text = "Choco Balls"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        orderdetails.Show()
        itemprice = 100
        orderdetails.Label5.Text = "Venilla waffy"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox11_Click_1(sender As Object, e As EventArgs) Handles PictureBox11.Click
        orderdetails.Show()
        itemprice = 150
        orderdetails.Label5.Text = "Icecream Custerd"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox10_Click_1(sender As Object, e As EventArgs) Handles PictureBox10.Click
        orderdetails.Show()
        itemprice = 130
        orderdetails.Label5.Text = "Choco Nuts"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox9_Click_2(sender As Object, e As EventArgs) Handles PictureBox9.Click
        orderdetails.Show()
        itemprice = 110
        orderdetails.Label5.Text = "Boogie Woogie Ball"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click
        orderdetails.Show()
        itemprice = 140
        orderdetails.Label5.Text = "Choco Chocobowl"
        orderdetails.Label7.Text = itemprice
    End Sub
End Class