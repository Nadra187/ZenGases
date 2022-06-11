Imports System.Data.OleDb
Public Class Form4

    Public Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form4_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Me.CreateGraphics.DrawString("ZEN GASES", New Font("calibri", 20), New SolidBrush(Color.Gray), 1400, 780)
        Me.CreateGraphics.DrawString("by Nadra Ibrahim", New Font("calibri", 20), New SolidBrush(Color.DarkGray), 1330, 800)
    End Sub
End Class