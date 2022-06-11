Imports System.Data.OleDb
Public Class Form6

    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "C:\Users\Oracle\Documents\ZEN GASES.accdb"
        connString = provider & datafile
        myConnection.ConnectionString = connString

        Dim Query As String
        myConnection.Open()

        'fetch last balance of supplier
        Dim last As UInteger
        Query = "select   sbalance from  supplier order by  sdate desc limit 1;"
        Dim cmd1 As OleDbCommand = New OleDbCommand(Query, myConnection)
        last = cmd1.ExecuteNonQuery()
        Dim debit As UInteger
        debit = CUInt(TextBox1.Text)
        Dim balance As UInteger
        balance = last - debit
        'howing new  balance 
        TextBox1.Text = balance

        'inserting debit
        Query = "insert into supplier (sdate, debit, balance) values(@sdate, @debit, @balance);"
        Dim cmd2 As OleDbCommand = New OleDbCommand(Query, myConnection)
        cmd2.Parameters.AddWithValue("@sdate", DateTimePicker1.Text)
        cmd2.Parameters.AddWithValue("@debit", debit)
        cmd2.Parameters.AddWithValue("@balance", balance)
        cmd2.ExecuteNonQuery()
        myConnection.Close()
        MessageBox.Show("inserted.")
        TextBox1.Text = ""
    End Sub
End Class
