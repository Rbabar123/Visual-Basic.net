Public Class Form1
    Dim fare As Double
    Dim discount As Double
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton4_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            TextBox1.Text = RadioButton6.Text
            fare = GroupBox3.Text
            TextBox2.Text = Format(fare, "0.00")
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = True
            RadioButton7.Checked = False
            RadioButton8.Checked = False
            RadioButton9.Checked = False
            RadioButton10.Checked = False
            RadioButton11.Checked = False
            RadioButton12.Checked = False
            RadioButton13.Checked = False
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            TextBox1.Text = RadioButton7.Text
            fare = GroupBox3.Text
            TextBox2.Text = Format(fare, "0.00")
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = True
            RadioButton8.Checked = False
            RadioButton9.Checked = False
            RadioButton10.Checked = False
            RadioButton11.Checked = False
            RadioButton12.Checked = False
            RadioButton13.Checked = False
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            TextBox1.Text = RadioButton8.Text
            fare = GroupBox3.Text
            TextBox2.Text = Format(fare, "0.00")
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            RadioButton8.Checked = True
            RadioButton9.Checked = False
            RadioButton10.Checked = False
            RadioButton11.Checked = False
            RadioButton12.Checked = False
            RadioButton13.Checked = False
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBox1.Text = RadioButton1.Text
            fare = GroupBox2.Text
            TextBox2.Text = Format(fare, "0.00")
            RadioButton1.Checked = True
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            RadioButton8.Checked = False
            RadioButton9.Checked = False
            RadioButton10.Checked = False
            RadioButton11.Checked = False
            RadioButton12.Checked = False
            RadioButton13.Checked = False

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextBox1.Text = RadioButton2.Text
            fare = GroupBox2.Text
            TextBox2.Text = Format(fare, "0.00")
            RadioButton1.Checked = False
            RadioButton2.Checked = True
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            RadioButton8.Checked = False
            RadioButton9.Checked = False
            RadioButton10.Checked = False
            RadioButton11.Checked = False
            RadioButton12.Checked = False
            RadioButton13.Checked = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TextBox1.Text = RadioButton3.Text
            fare = GroupBox2.Text
            TextBox2.Text = Format(fare, "0.00")
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = True
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            RadioButton8.Checked = False
            RadioButton9.Checked = False
            RadioButton10.Checked = False
            RadioButton11.Checked = False
            RadioButton12.Checked = False
            RadioButton13.Checked = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged_2(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            TextBox1.Text = RadioButton4.Text
            fare = GroupBox2.Text
            TextBox2.Text = Format(fare, "0.00")
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = True
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            RadioButton8.Checked = False
            RadioButton9.Checked = False
            RadioButton10.Checked = False
            RadioButton11.Checked = False
            RadioButton12.Checked = False
            RadioButton13.Checked = False
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            TextBox1.Text = RadioButton5.Text
            fare = GroupBox2.Text
            TextBox2.Text = Format(fare, "0.00")
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = True
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            RadioButton8.Checked = False
            RadioButton9.Checked = False
            RadioButton10.Checked = False
            RadioButton11.Checked = False
            RadioButton12.Checked = False
            RadioButton13.Checked = False
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            TextBox1.Text = RadioButton9.Text
            fare = GroupBox3.Text
            TextBox2.Text = Format(fare, "0.00")
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            RadioButton8.Checked = False
            RadioButton9.Checked = True
            RadioButton10.Checked = False
            RadioButton11.Checked = False
            RadioButton12.Checked = False
            RadioButton13.Checked = False
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            TextBox1.Text = RadioButton10.Text
            fare = GroupBox3.Text
            TextBox2.Text = Format(fare, "0.00")
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            RadioButton8.Checked = False
            RadioButton9.Checked = False
            RadioButton10.Checked = True
            RadioButton11.Checked = False
            RadioButton12.Checked = False
            RadioButton13.Checked = False
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            TextBox1.Text = RadioButton11.Text
            fare = GroupBox3.Text
            TextBox2.Text = Format(fare, "0.00")
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            RadioButton8.Checked = False
            RadioButton9.Checked = False
            RadioButton10.Checked = False
            RadioButton11.Checked = True
            RadioButton12.Checked = False
            RadioButton13.Checked = False
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            TextBox1.Text = RadioButton12.Text
            fare = GroupBox4.Text
            TextBox2.Text = Format(fare, "0.00")
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            RadioButton8.Checked = False
            RadioButton9.Checked = False
            RadioButton10.Checked = False
            RadioButton11.Checked = False
            RadioButton12.Checked = True
            RadioButton13.Checked = False
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked = True Then
            TextBox1.Text = RadioButton13.Text
            fare = GroupBox4.Text
            TextBox2.Text = Format(fare, "0.00")
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            RadioButton5.Checked = False
            RadioButton6.Checked = False
            RadioButton7.Checked = False
            RadioButton8.Checked = False
            RadioButton9.Checked = False
            RadioButton10.Checked = False
            RadioButton11.Checked = False
            RadioButton12.Checked = False
            RadioButton13.Checked = True
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked = True Then
            discount = 20
            TextBox3.Text = Format(fare - (discount / 100) * fare, "0.00")

        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        TextBox3.Text = Format(Val(TextBox2.Text), "0.00")
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Format(TextBox4.Text, "0.00")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox5.Text = Format((Val(TextBox4.Text) - Val(TextBox3.Text)), "0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False
        RadioButton13.Checked = False

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("This project was created for practices only")
        MessageBox.Show("This project was created by Rb devs")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
End Class
