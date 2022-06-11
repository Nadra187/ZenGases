Imports System.Data.OleDb
Public Class Form5
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "C:\Users\Oracle\Documents\ZEN GASES.accdb"
        connString = provider & datafile
        myConnection.ConnectionString = connString

        Dim InsertQuery As String

        InsertQuery = "insert into customer (cname, caddress) VALUES (@cname, @caddress);"

        myConnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(InsertQuery, myConnection)
        cmd.Parameters.AddWithValue("@cname", TextBox1.Text)
        cmd.Parameters.AddWithValue("@caddress", TextBox2.Text)
        cmd.ExecuteNonQuery()
        myConnection.Close()
        MessageBox.Show("inserted.")
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class