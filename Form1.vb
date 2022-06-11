Imports System.Data.OleDb
Public Class Form1

    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection
    'executing 7 querieS

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "C:\Users\Oracle\Documents\ZEN GASES.accdb"
        connString = provider & datafile
        myConnection.ConnectionString = connString


        myConnection.Open()
        Dim Query As String

        'fetch cid
        Dim cid As UInteger
        Query = "select cid from customer where cname = @cname;"
        Dim cmd1 As OleDbCommand = New OleDbCommand(Query, myConnection)
        cmd1.Parameters.AddWithValue("@cname", TextBox1.Text)
        cid = cmd1.ExecuteNonQuery()
        'show cid
        TextBox1.Text = cid

        Query = "Update cylinder Set cydate = @cydate, returned = @returned, cid = @cid where cyno = @cyno;"
        Dim cmd2 As OleDbCommand = New OleDbCommand(Query, myConnection)

        'two Updates at once


        'Update 1 for return
        If (TextBox3.Text <> Nothing) Then

            cmd2.Parameters.AddWithValue("@cydate", DateTimePicker1.Text)
            cmd2.Parameters.AddWithValue("@returned", "true")
            cmd2.Parameters.AddWithValue("@cid", cid)
            cmd2.Parameters.AddWithValue("@cyno", TextBox3.Text)

            cmd2.ExecuteNonQuery()
            MessageBox.Show("Updated return.")
            TextBox3.Text = ""

        End If

        'Update 2 for purchase
        Dim cmd3 As OleDbCommand = New OleDbCommand(Query, myConnection)

        If (TextBox2.Text <> Nothing) Then

            cmd3.Parameters.AddWithValue("@cydate", DateTimePicker1.Text)
            cmd3.Parameters.AddWithValue("@returned", "false")
            cmd3.Parameters.AddWithValue("@cid", cid)
            cmd3.Parameters.AddWithValue("@cyno", TextBox3.Text)

            cmd3.ExecuteNonQuery()
            myConnection.Close()
            MessageBox.Show("Updated purchase.")

            'fetch gid
            Dim gid As UInteger
            Query = "select gid from cylinder where cyno = @cyno;"
            Dim cmd4 As OleDbCommand = New OleDbCommand(Query, myConnection)
            cmd4.Parameters.AddWithValue("@cyno", TextBox3.Text)
            gid = cmd4.ExecuteNonQuery()

            'fetch sp of gid
            Dim sp As UInteger
            Query = "select  sp from gas where gid = @gid;"
            Dim cmd5 As OleDbCommand = New OleDbCommand(Query, myConnection)
            cmd5.Parameters.AddWithValue("@gid", gid)
            sp = cmd5.ExecuteNonQuery()
            'show sp
            TextBox3.Text = sp

            'fetch last balance of customer
            Dim last As UInteger
            Query = "select  balance from  account where cid = @cid order by pdate desc limit 1;"
            Dim cmd6 As OleDbCommand = New OleDbCommand(Query, myConnection)
            cmd6.Parameters.AddWithValue("@cid", cid)
            last = cmd6.ExecuteNonQuery()

            'finding balance
            Dim balance As UInteger
            balance = last + sp

            'insert purchase into account
            Query = "insert into account(cid, pdate, gid, credit, balance) values(@cid, @pdate, @gid, @credit, @balance);"
            Dim cmd7 As OleDbCommand = New OleDbCommand(Query, myConnection)
            cmd7.Parameters.AddWithValue("@cid", cid)
            cmd7.Parameters.AddWithValue("@pdate", DateTimePicker1.Text)
            cmd7.Parameters.AddWithValue("@gid", gid)
            cmd7.Parameters.AddWithValue("@credit", sp)
            cmd7.Parameters.AddWithValue("@balance", balance)
            cmd7.ExecuteNonQuery()
            MessageBox.Show("inserted into account.")
            myConnection.Close()
            TextBox2.Text = ""

        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        DateTimePicker1.Text = Today
    End Sub

End Class
