Imports System.Data.OleDb
Public Class Form7

    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "C:\Users\Oracle\Documents\ZEN GASES.accdb"
        connString = provider & datafile
        myConnection.ConnectionString = connString
        Dim Query As String

        'fetch gid
        Dim gid As UInteger
        Query = "select gid from cylinder where gname = @gname;"
        Dim cmd1 As OleDbCommand = New OleDbCommand(Query, myConnection)
        cmd1.Parameters.AddWithValue("@gname", ComboBox1.Text)
        gid = cmd1.ExecuteNonQuery()

        'inserting into cylinder 
        Query = "insert into cylinder (cyno, gid) VALUES (@cyno, @gid);"
        myConnection.Open()
        Dim cmd As OleDbCommand = New OleDbCommand(Query, myConnection)
        cmd.Parameters.AddWithValue("@cyno", TextBox1.Text)
        cmd.Parameters.AddWithValue("@gid", gid)
        cmd.ExecuteNonQuery()
        myConnection.Close()
        MessageBox.Show("inserted.")
        TextBox1.Text = ""
    End Sub
End Class
