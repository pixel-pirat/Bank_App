Imports System.Drawing.Drawing2D

Public Class Form6
    Private Sub Guna2GradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel2.Paint


        ' glass morphism in vb code

        ' Guna2GradientPanel2.opacity = 0.5
        ' Guna2GradientPanel2.BackColor = Color.FromArgb(150, 255, 255, 255) ' 50% opaque white
        Guna2GradientPanel2.BorderColor = Color.FromArgb(100, 255, 255, 255) ' Adjust the alpha value for border transparency
        Guna2GradientPanel2.BorderThickness = 0
        Guna2GradientPanel2.ShadowDecoration.Color = Color.FromArgb(90, 0, 0, 0) ' Adjust the alpha value for shadow transparency
        Guna2GradientPanel2.ShadowDecoration.Depth = 5
        Guna2GradientPanel2.ShadowDecoration.Enabled = True
        ' Guna2GradientPanel2.ShadowDecoration.Shadow = New GuShadowna.UI2.WinForms(10, 10, False, 100, False)





    End Sub
End Class