Imports System.Data.OleDb
Public Class Form8

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

        'fetch cid
        Dim cid As UInteger
        Query = "select cid from customer where cname = @cname;"
        Dim cmd1 As OleDbCommand = New OleDbCommand(Query, myConnection)
        cmd1.Parameters.AddWithValue("@cname", TextBox1.Text)
        cid = cmd1.ExecuteNonQuery()
        'show cid
        TextBox1.Text = cid

        'fetch last balance of customer
        Dim last As UInteger
        Query = "select  balance from  account where cid = @cid order by pdate desc limit 1;"
        Dim cmd2 As OleDbCommand = New OleDbCommand(Query, myConnection)
        cmd2.Parameters.AddWithValue("@cid", cid)
        last = cmd2.ExecuteNonQuery()

        'finding balance
        Dim balance As UInteger
        Dim debit As UInteger
        balance = last - debit

        Query = "insert into account (cid, pdate, debit, balance) values(@cid, @pdate, @debit, @balance);"

        myConnection.Open()
        Dim cmd3 As OleDbCommand = New OleDbCommand(Query, myConnection)
        cmd3.Parameters.AddWithValue("@cid", cid)
        cmd3.Parameters.AddWithValue("@pdate", DateTimePicker1.Text)
        cmd3.Parameters.AddWithValue("@debit", TextBox2.Text)
        cmd3.Parameters.AddWithValue("@balance", balance)
        cmd3.ExecuteNonQuery()
        myConnection.Close()
        MessageBox.Show("inserted.")
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
