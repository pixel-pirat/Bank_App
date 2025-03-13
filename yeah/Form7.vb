Imports Guna.UI2.WinForms

Public Class Form7
    Private Sub Guna2CustomGradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel2.Paint
        ' Guna2CustomGradientPanel2.BackColor = Color.FromArgb(150, 255, 255, 255) ' 50% opaque white
    End Sub

    Private Sub Guna2GradientTileButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientTileButton1.Click
        Form9.Show()
        Me.Hide()

    End Sub
End Class