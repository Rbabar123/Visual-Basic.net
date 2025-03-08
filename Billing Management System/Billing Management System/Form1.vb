Public Class Form1

    Const bread = 18.13
    Const rice = 55.0
    Const milk = 14.5
    Const wine = 2946.0
    Const beans = 297.54
    Dim items(9)
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click
        rtReceipt.Clear()
        rtReceipt.AppendText(Label9.Text & vbTab & vbTab & Label8.Text & vbTab & Label10.Text & vbNewLine)

        rtReceipt.AppendText(lblItemBread.Text & vbTab & vbTab & vbTab & numBread.Value & vbTab & vbTab & " " & txtBread.Text & vbNewLine)
        rtReceipt.AppendText(lblItemRice.Text & vbTab & vbTab & vbTab & numRice.Value & vbTab & vbTab & " " & txtRice.Text & vbNewLine)
        rtReceipt.AppendText(lblItemBeans.Text & vbTab & vbTab & vbTab & numBeans.Value & vbTab & vbTab & " " & txtBeans.Text & vbNewLine)
        rtReceipt.AppendText(lblItemWine.Text & vbTab & vbTab & vbTab & numWine.Value & vbTab & vbTab & " " & txtWine.Text & vbNewLine)
        rtReceipt.AppendText(lblItemMilk.Text & vbTab & vbTab & vbTab & numMilk.Value & vbTab & vbTab & " " & txtMilk.Text & vbNewLine)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        numMilk.Value = 0
        numRice.Value = 0
        numBeans.Value = 0
        numRice.Value = 0
        numWine.Value = 0
        numBread.Value = 0
        txtMilk.Text = "₱0.00"
        txtRice.Text = "₱0.00"
        txtBeans.Text = "₱0.00"
        txtWine.Text = "₱0.00"
        txtBread.Text = "₱0.00"
        txtNumItem.Text = "0"
        rtReceipt.Clear()
        txtTotalCost.Text = "₱0.00"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iQuit As DialogResult
        iQuit = MessageBox.Show("Confirm if you want to quit", "Billing Management System",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iQuit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub numBread_ValueChanged(sender As Object, e As EventArgs) Handles numBread.ValueChanged
        txtBread.Text = FormatCurrency(numBread.Value * bread)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblItemBread.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblItemMilk.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblItemWine.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblItemBeans.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblItemRice.Click

    End Sub

    Private Sub numRice_ValueChanged(sender As Object, e As EventArgs) Handles numRice.ValueChanged
        txtRice.Text = FormatCurrency(numRice.Value * rice)
    End Sub

    Private Sub numBeans_ValueChanged(sender As Object, e As EventArgs) Handles numBeans.ValueChanged
        txtBeans.Text = FormatCurrency(numBeans.Value * beans)
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtMilk.TextChanged

    End Sub

    Private Sub numMilk_ValueChanged(sender As Object, e As EventArgs) Handles numMilk.ValueChanged
        txtMilk.Text = FormatCurrency(numMilk.Value * milk)
    End Sub

    Private Sub numWine_ValueChanged(sender As Object, e As EventArgs) Handles numWine.ValueChanged
        txtWine.Text = FormatCurrency(numWine.Value * wine)
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        items(0) = numBread.Value
        items(1) = numRice.Value
        items(2) = numBeans.Value
        items(3) = numWine.Value
        items(4) = numMilk.Value
        items(5) = items(0) + items(1) + items(2) + items(3) + items(4)
        txtNumItem.Text = (items(5))

        Dim q(9)
        q(0) = numBread.Value * bread
        q(1) = numRice.Value * rice
        q(2) = numBeans.Value * beans
        q(3) = numWine.Value * wine
        q(4) = numMilk.Value * milk
        q(5) = q(0) + q(1) + q(2) + q(3) + q(4)
        txtTotalCost.Text = FormatCurrency(q(5))
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles rtReceipt.TextChanged

    End Sub
End Class
