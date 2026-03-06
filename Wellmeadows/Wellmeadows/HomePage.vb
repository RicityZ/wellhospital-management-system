Public Class HomePage
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel5.Paint

    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PatientREG_Click(sender As Object, e As EventArgs) Handles PatientREG.Click
        PaREG.Show()
        Me.Hide()
    End Sub

    Private Sub Homebtn_Click(sender As Object, e As EventArgs) Handles Homebtn.Click
        Me.Show()
    End Sub
End Class
