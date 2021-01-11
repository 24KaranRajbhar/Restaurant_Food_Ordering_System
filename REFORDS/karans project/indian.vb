Public Class indian
    Dim itemprice As Integer
    Dim amount As Double
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox1.Image = PictureBox2.Image()
        Label2.Text = "                              Chana Masala                                    "
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.MouseHover
        PictureBox1.Image = PictureBox8.Image()
        Label2.Text = "                                    Jeera Aloo                                    "
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.MouseHover
        PictureBox1.Image = PictureBox9.Image()
        Label2.Text = "                                    Tadka Dal                                    "
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        cart.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        PictureBox1.Image = PictureBox4.Image()
        Label2.Text = "                                   Aloo Palak                                    "

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox1.Image = PictureBox3.Image()
        Label2.Text = "                                   Dal Makhni                                  "
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover
        PictureBox1.Image = PictureBox5.Image()
        Label2.Text = "                                 Kadai Paneer                                "
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.MouseHover
        PictureBox1.Image = PictureBox7.Image()
        Label2.Text = "                                 Masala Bhendi                               "
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.MouseHover
        PictureBox1.Image = PictureBox6.Image()
        Label2.Text = "                                  Special Thali                                  "
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.MouseHover
        PictureBox1.Image = PictureBox11.Image()
        Label2.Text = "                            Mushroom Mutter                               "
    End Sub

    Private Sub indian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.MouseHover
        PictureBox1.Image = PictureBox10.Image()
        Label2.Text = "                                  Aloo Mutter                                   "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        menupg.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        orderdetails.Show()
        itemprice = 180
        orderdetails.Label5.Text = "Chana masala"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        feedback.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        aboutus.Show()
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        orderdetails.Show()
        itemprice = 150 
        orderdetails.Label5.Text = "Dal Makhni"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        orderdetails.Show()
        itemprice = 105
        orderdetails.Label5.Text = "Aloo Palak"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        orderdetails.Show()
        itemprice = 123
        orderdetails.Label5.Text = "Kadai Paneer"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox7_Click_1(sender As Object, e As EventArgs) Handles PictureBox7.Click
        orderdetails.Show()
        itemprice = 70
        orderdetails.Label5.Text = "Masala Bhendi"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox8_Click_1(sender As Object, e As EventArgs) Handles PictureBox8.Click
        orderdetails.Show()
        itemprice = 80
        orderdetails.Label5.Text = "Jeera Aloo"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        orderdetails.Show()
        itemprice = 200
        orderdetails.Label5.Text = "Special Thali"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox11_Click_1(sender As Object, e As EventArgs) Handles PictureBox11.Click
        orderdetails.Show()
        itemprice = 120
        orderdetails.Label5.Text = "Mushroom Mutter"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox10_Click_1(sender As Object, e As EventArgs) Handles PictureBox10.Click
        orderdetails.Show()
        itemprice = 50
        orderdetails.Label5.Text = "Aloo Mutter"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox9_Click_1(sender As Object, e As EventArgs) Handles PictureBox9.Click
        orderdetails.Show()
        itemprice = 90
        orderdetails.Label5.Text = "Tadka Dal"
        orderdetails.Label7.Text = itemprice
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class