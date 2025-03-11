Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Data.SqlClient
Public Class Form1



    Private Sub ConnectToMySQLDatabase()
        Dim connectionString As String = "server=localhost;user=root;password=password;database=your_database"
        '        Dim connection As New MySqlConnection(connectionString)

        '       Try
        '      connection.Open()
        '     MsgBox("Connected to MySQL database!")

        ' Create a command to execute a query
        '        Dim command As New MySqlCommand("SELECT * FROM your_table", connection)
        '       Dim reader As MySqlDataReader = command.ExecuteReader()

        ' Read the results
        '       While reader.Read()
        '      MsgBox(reader("column_name").ToString())
        '     End While

        '     reader.Close()
        '    Catch ex As MySqlException
        '   MsgBox("Error connecting to MySQL database: " & ex.Message)
        '  Finally
        '  connection.Close()
        '  End Try
    End Sub


    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ApplyCurvedRegion(Panel1, 15, 15, 15, 15)



        ApplyCurvedRegion(Button1, 10, 10, 10, 10)
        ApplyCurvedRegion(Button2, 10, 10, 10, 10)

        ' ApplyCircularRegion(PictureBox1)




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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class
