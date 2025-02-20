Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchBar As String
        searchBar = txtSearchBar.Text
        txtSearchBar.Text = ""
        If searchBar = "" Then
            CheckedListBox1.Text = False
        Else



            CheckedListBox1.Items.Add(searchBar)
            txtSearchItem.Text = "   " & searchBar & "  "
        End If
        TextBox1.Text = ""

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim txtDiscription As String = TextBox1.Text
        txtSearchItem.Text = txtSearchItem.Text + txtDiscription
    End Sub

    Private Sub txtSearchItem_TextChanged(sender As Object, e As EventArgs) Handles txtSearchItem.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Me.BackgroundImage = Image.FromFile("C:\Users\rbaba\Downloads\background-color-paresan.jpg")
        Else Me.BackgroundImage = Image.FromFile("C:\Users\rbaba\Downloads\background-image-to-do-list.jpg")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckedListBox1.SelectedIndex >= 0 Then
            CheckedListBox1.Items.RemoveAt(CheckedListBox1.SelectedIndex)
            txtSearchItem.Text = ""
        Else
            Exit Sub
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim searchItemText As String
        searchItemText = txtSearchBar.Text.Trim()

        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            Dim currentItemText As String = CheckedListBox1.Items(i).ToString()
            If currentItemText.Contains(searchItemText) Then
                CheckedListBox1.SetSelected(i, True)
                txtSearchItem.Text = currentItemText
                Exit For
            End If


        Next


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Me.BackgroundImage = Image.FromFile("C:\Users\rbaba\Downloads\background-image-to-do-list.jpg")
        Else
            Me.BackgroundImage = Image.FromFile("C:\Users\rbaba\Downloads\background-image-to-do-list.jpg")
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Me.BackgroundImage = Image.FromFile("C:\Users\rbaba\Downloads\background-image-to-do-list2.jpg!d")
        Else
            Me.BackgroundImage = Image.FromFile("C:\Users\rbaba\Downloads\background-image-to-do-list.jpg")

        End If
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        If CheckedListBox1.SelectedIndex >= 0 Then
            txtSearchItem.Text = CheckedListBox1.Text
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MessageBox.Show("This program was created By " & "Rb devs")
        MessageBox.Show("This program was created for practices only.")
    End Sub
End Class
