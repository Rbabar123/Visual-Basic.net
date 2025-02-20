Imports System.Media

Public Class Form1

    Dim num1, num2, temp, op, total As Double
    Dim sOperator As String
    Dim player As New SoundPlayer("C:\Users\rbaba\Downloads\button-click-289742.wav")
    Dim player2 As New SoundPlayer("C:\Users\rbaba\Downloads\pabaon.wav")

    Private Sub Button18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        txtdisplay.Text = txtdisplay.Text + Button12.Text
        TextBox1.Text = txtdisplay.Text + Button12.Text
        num1 = Val(TextBox1.Text)
        sOperator = "+"
        TextBox1.Text = ""
        player.Play()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtdisplay.Text = txtdisplay.Text + Button4.Text
        TextBox1.Text = TextBox1.Text + Button4.Text
        player.Play()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtdisplay.Text = txtdisplay.Text + Button7.Text
        TextBox1.Text = TextBox1.Text + Button7.Text
        player.Play()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtdisplay.Text = txtdisplay.Text + Button15.Text
        TextBox1.Text = TextBox1.Text + Button15.Text
        player.Play()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtdisplay.Text = txtdisplay.Text + Button2.Text
        TextBox1.Text = TextBox1.Text + Button2.Text
        player.Play()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtdisplay.Text = txtdisplay.Text + Button8.Text
        TextBox1.Text = TextBox1.Text + Button8.Text
        player.Play()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txtdisplay.Text = txtdisplay.Text + Button16.Text
        TextBox1.Text = TextBox1.Text + Button16.Text
        player.Play()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtdisplay.Text = txtdisplay.Text + Button1.Text
        TextBox1.Text = TextBox1.Text + Button1.Text
        player.Play()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txtdisplay.Text = txtdisplay.Text + Button9.Text
        TextBox1.Text = TextBox1.Text + Button9.Text
        player.Play()
    End Sub

    Private Sub txtdisplay_TextChanged(sender As Object, e As EventArgs) Handles txtdisplay.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtdisplay.Text = txtdisplay.Text + Button6.Text
        TextBox1.Text = TextBox1.Text + Button6.Text
        player.Play()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        txtdisplay.Text = txtdisplay.Text + Button12.Text
        TextBox1.Text = txtdisplay.Text + Button12.Text
        num1 = Val(TextBox1.Text)
        sOperator = "-"
        TextBox1.Text = ""
        player.Play()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtdisplay.Text = txtdisplay.Text + Button12.Text
        TextBox1.Text = txtdisplay.Text + Button12.Text
        num1 = Val(TextBox1.Text)
        sOperator = "/"
        TextBox1.Text = ""
        player.Play()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        txtdisplay.Text = txtdisplay.Text + Button10.Text
        TextBox1.Text = txtdisplay.Text + Button10.Text
        num1 = Val(TextBox1.Text)
        sOperator = "*"
        TextBox1.Text = ""
        player.Play()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = ""
        txtdisplay.Text = ""
        player.Play()
    End Sub

    Private Sub Button18_Click_1(sender As Object, e As EventArgs) Handles Button18.Click
        MessageBox.Show("This project was created by Rb Devs")
        MessageBox.Show("This project was created for practices only")

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        txtdisplay.Text = txtdisplay.Text + Button17.Text
        TextBox1.Text = TextBox1.Text + Button17.Text
        player.Play()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        num2 = TextBox1.Text
        If sOperator = "+" Then
            txtdisplay.Text = num1 + num2
        ElseIf sOperator = "-" Then
            txtdisplay.Text = num1 - num2
        ElseIf sOperator = "/" Then
            txtdisplay.Text = num1 / num2
        ElseIf sOperator = "*" Then
            txtdisplay.Text = num1 * num2
        End If



    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtdisplay.Text = txtdisplay.Text + Button3.Text
        TextBox1.Text = TextBox1.Text + Button3.Text
        player.Play()

    End Sub
End Class
