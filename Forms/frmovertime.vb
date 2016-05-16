Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class frmovertime
    'SET UP A CONNECTION OF MYSQL DATABASE AND VISUAL BASIC.
    Dim con As MySqlConnection = New MySqlConnection("Server=localhost; userid=root; password=; database=demandph;")
    'A SET OF COMMANDS IN MYSQL
    Dim cmd As New MySqlCommand
    'SET THE BRIDGE BETWEEN THE DATABASE AND THE DATASET FOR SAVING AND RETRIEVING DATA.
    Dim da As New MySqlDataAdapter
    'a specfic table in the database
    'A SPECIFIC TABLE IN THE DATABASE
    Dim dt As New DataTable
    'SET A VARIABLE FOR THE QUERY IN IT
    Dim sql As String
    Dim dr As MySqlDataReader
    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtreason.TextChanged

    End Sub

    Private Sub frmovertime_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call FillFname()
        DateTimePicker1.Value = Today
        DateTimePicker2.Value = Today
    End Sub
    Private Sub FillFname()
        Try
            con.Open()
            Sql = "SELECT * from tblovertimetype"
            cmd = New MySqlCommand(Sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim sId = dr.GetString("overtime_type")
                ComboBox1.Items.Add(sId)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txttotalhours.TextChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Dim d1 As DateTime = DateTimePicker1.Value
        Dim d2 As DateTime = DateTimePicker2.Value
        Dim result As TimeSpan = d2.Subtract(d1)
        Dim days As Integer = result.TotalMinutes
        txttotalhours.Text = days / 60

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            con.Open()
            sql = "SELECT * FROM tblovertimetype WHERE overtime_type ='" & ComboBox1.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtotid.Text = dr.GetInt32("id")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id='" & txtId.Text & "' And Date='" & lbldate.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Overtime already generated!", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()
                sql = "INSERT INTO tblovertime (employee_id,overtime_type_id,start_of,end_of,total_hours,date,reason) VALUES ('" & txtId.Text & "', '" & txtotid.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "','" & txttotalhours.Text & "','" & lbldate.Text & "','" & txtreason.Text & "')"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Sucessfully Saved")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class