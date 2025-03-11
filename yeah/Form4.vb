Imports System.Drawing.Drawing2D

Public Class Form4
    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyCurvedRegion(Button3, 10, 10, 10, 10)
        ApplyCurvedRegion(Button1, 10, 10, 10, 10)
        ApplyCurvedRegion(Button2, 10, 10, 10, 10)
        ApplyCurvedRegion(Button4, 10, 10, 10, 10)
        ApplyCurvedRegion(Button5, 10, 10, 10, 10)
        ApplyCurvedRegion(Button6, 10, 10, 10, 10)
        ApplyCurvedRegion(Button7, 10, 10, 10, 10)
        ApplyCurvedRegion(Button8, 10, 10, 10, 10)
        ApplyCurvedRegion(Button9, 10, 10, 10, 10)
        ApplyCurvedRegion(Button11, 10, 10, 10, 10)
        ApplyCurvedRegion(Button10, 10, 10, 10, 10)
        ApplyCurvedRegion(Button12, 10, 10, 10, 10)

        ApplyCircularRegion(PictureBox1)
        ApplyCircularRegion(PictureBox2)
        ApplyCircularRegion(PictureBox3)
        ApplyCircularRegion(PictureBox4)
        ApplyCircularRegion(PictureBox5)
        ApplyCircularRegion(PictureBox6)
        ApplyCircularRegion(PictureBox7)
        ApplyCircularRegion(PictureBox8)
        ApplyCircularRegion(PictureBox9)
        ApplyCircularRegion(PictureBox10)
        ApplyCircularRegion(PictureBox11)
        ApplyCircularRegion(PictureBox12)
        ApplyCircularRegion(PictureBox13)
        ApplyCircularRegion(PictureBox14)
        ApplyCircularRegion(PictureBox15)
        ApplyCircularRegion(PictureBox16)
        ApplyCircularRegion(PictureBox17)
        ApplyCircularRegion(PictureBox18)
        ' ApplyCircularRegion(PictureBox19)
        'ApplyCircularRegion(PictureBox20)
        'ApplyCircularRegion(PictureBox21)
        'ApplyCircularRegion(PictureBox22)
        'ApplyCircularRegion(PictureBox23)
        'ApplyCircularRegion(PictureBox24)
        'ApplyCircularRegion(PictureBox25)
    End Sub

    Private Sub ApplyCurvedRegion(panel As Panel, radiusTopLeft As Integer, radiusTopRight As Integer, radiusBottomRight As Integer, radiusBottomLeft As Integer)
        Dim path As New GraphicsPath()
        Dim rect As Rectangle = panel.ClientRectangle

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radiusTopLeft * 2, radiusTopLeft * 2, 180, 90)
        path.AddLine(rect.X + radiusTopLeft, rect.Y, rect.X + rect.Width - radiusTopRight, rect.Y)
        path.AddArc(rect.X + rect.Width - radiusTopRight * 2, rect.Y, radiusTopRight * 2, radiusTopRight * 2, 270, 90)
        path.AddLine(rect.X + rect.Width, rect.Y + radiusTopRight, rect.X + rect.Width, rect.Y + rect.Height - radiusBottomRight)
        path.AddArc(rect.X + rect.Width - radiusBottomRight * 2, rect.Y + rect.Height - radiusBottomRight * 2, radiusBottomRight * 2, radiusBottomRight * 2, 0, 90)
        path.AddLine(rect.X + rect.Width - radiusBottomRight, rect.Y + rect.Height, rect.X + radiusBottomLeft, rect.Y + rect.Height)
        path.AddArc(rect.X, rect.Y + rect.Height - radiusBottomLeft * 2, radiusBottomLeft * 2, radiusBottomLeft * 2, 90, 90)
        path.CloseFigure()

        panel.Region = New Region(path)
        path.Dispose()
    End Sub

    Private Sub ApplyCurvedRegion(control As Control, radiusTopLeft As Integer, radiusTopRight As Integer, radiusBottomRight As Integer, radiusBottomLeft As Integer)
        Dim path As New GraphicsPath()
        Dim rect As Rectangle = control.ClientRectangle

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radiusTopLeft * 2, radiusTopLeft * 2, 180, 90)
        path.AddLine(rect.X + radiusTopLeft, rect.Y, rect.X + rect.Width - radiusTopRight, rect.Y)
        path.AddArc(rect.X + rect.Width - radiusTopRight * 2, rect.Y, radiusTopRight * 2, radiusTopRight * 2, 270, 90)
        path.AddLine(rect.X + rect.Width, rect.Y + radiusTopRight, rect.X + rect.Width, rect.Y + rect.Height - radiusBottomRight)
        path.AddArc(rect.X + rect.Width - radiusBottomRight * 2, rect.Y + rect.Height - radiusBottomRight * 2, radiusBottomRight * 2, radiusBottomRight * 2, 0, 90)
        path.AddLine(rect.X + rect.Width - radiusBottomRight, rect.Y + rect.Height, rect.X + radiusBottomLeft, rect.Y + rect.Height)
        path.AddArc(rect.X, rect.Y + rect.Height - radiusBottomLeft * 2, radiusBottomLeft * 2, radiusBottomLeft * 2, 90, 90)
        path.CloseFigure()

        control.Region = New Region(path)
        path.Dispose()

        If TypeOf control Is Button Then
            Dim btn As Button = CType(control, Button)
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
        End If
    End Sub
    Private Sub ApplyCircularRegion(pictureBox As PictureBox)
        Dim path As New GraphicsPath()
        Dim rect As Rectangle = pictureBox.ClientRectangle

        path.AddEllipse(rect)

        pictureBox.Region = New Region(path)
        path.Dispose()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form3.Show()
        Me.Hide()

    End Sub
End Class