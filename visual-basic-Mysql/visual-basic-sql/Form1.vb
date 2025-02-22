Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
        MsgBox("Connected")
        con.Close()
    End Sub
End Class
