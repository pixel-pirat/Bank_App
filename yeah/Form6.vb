Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class Form6
    Private Sub Guna2GradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel2.Paint


        ' glass morphism in vb code

        ' Guna2GradientPanel2.opacity = 0.5
        ' Guna2GradientPanel2.BackColor = Color.FromArgb(150, 255, 255, 255) ' 50% opaque white
        Guna2GradientPanel2.BorderColor = Color.FromArgb(255, 255, 255, 255) ' White border color
        Guna2GradientPanel2.BorderThickness = 1
        Guna2GradientPanel2.ShadowDecoration.Color = Color.FromArgb(150, 255, 255, 255) ' Dark gray shadow color
        Guna2GradientPanel2.ShadowDecoration.Depth = 10 ' Reduced shadow depth to prevent leaking
        Guna2GradientPanel2.ShadowDecoration.Enabled = True
        ' Guna2GradientPanel2.ShadowDecoration.Shadow = New Guna.UI2.WinForms.Shadow(0, 1, False, 0, False) ' Custom shadow settings


        ' Guna2GradientPanel2.ShadowDecoration.Shadow = New GuShadowna.UI2.WinForms(10, 10, False, 100, False)





    End Sub


End Class
