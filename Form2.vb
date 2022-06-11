Public Class Form2

    Private Sub Form2_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Me.CreateGraphics.DrawString("ZEN GASES", New Font("calibri", 200), New SolidBrush(Color.Gray), 130, 200)
    End Sub

    Private Sub PaymentByToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentByToolStripMenuItem.Click
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
        Me.Hide()
        Form5.Show()
    End Sub


    Private Sub UpdateCPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCPToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub NewCylinderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewCylinderToolStripMenuItem1.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub PaySupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaySupplierToolStripMenuItem.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub PurchaseByCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseByCustomerToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TodaysSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodaysSummaryToolStripMenuItem.Click
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub NewCylinderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCylinderToolStripMenuItem.Click

    End Sub
End Class