Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmtimekeepingtemp
    Public sConnection As New MySqlConnection
    'SET UP A CONNECTION OF MYSQL DATABASE AND VISUAL BASIC.
    Dim con As MySqlConnection = New MySqlConnection("Server=localhost; userid=root; password=; database=demandph;")
    'A SET OF COMMANDS IN MYSQL
    Dim cmd As New MySqlCommand
    'A SET OF COMMANDS IN MYSQL
    Dim cmd1 As New MySqlCommand
    'A SET OF COMMANDS IN MYSQL
    Dim cmd2 As New MySqlCommand
    'A SET OF COMMANDS IN MYSQL
    Dim cmd3 As New MySqlCommand
    'A SET OF COMMANDS IN MYSQL
    Dim cmd4 As New MySqlCommand
    'A SET OF COMMANDS IN MYSQL
    Dim cmd5 As New MySqlCommand
    'A SET OF COMMANDS IN MYSQL
    Dim cmd6 As New MySqlCommand
    'A SET OF COMMANDS IN MYSQL
    Dim cmd7 As New MySqlCommand
    'A SET OF COMMANDS IN MYSQL
    Dim cmd8 As New MySqlCommand
    'A SET OF COMMANDS IN MYSQL
    Dim cmd9 As New MySqlCommand
    'A SET OF COMMANDS IN MYSQL
    Dim cmd10 As New MySqlCommand
    'A SET OF COMMANDS IN MYSQL
    Dim cmd11 As New MySqlCommand
    'A SET OF COMMANDS IN MYSQL
    Dim cmd12 As New MySqlCommand
    'A SET OF COMMANDS IN MYSQL
    Dim cmd13 As New MySqlCommand
    'A SET OF COMMANDS IN MYSQL
    Dim cmd14 As New MySqlCommand
    'A SET OF COMMANDS IN MYSQL
    Dim cmd15 As New MySqlCommand
    'SET THE BRIDGE BETWEEN THE DATABASE AND THE DATASET FOR SAVING AND RETRIEVING DATA.
    Dim da As New MySqlDataAdapter
    'a specfic table in the database
    'A SPECIFIC TABLE IN THE DATABASE
    Dim dt As New DataTable
    'SET A VARIABLE FOR THE QUERY IN IT
    Dim sql As String
    Dim sql1 As String
    Dim sql2 As String
    Dim sql3 As String
    Dim sql4 As String
    Dim sql5 As String
    Dim sql6 As String
    Dim sql7 As String
    Dim sql8 As String
    Dim sql9 As String
    Dim sql10 As String
    Dim sql11 As String
    Dim sql12 As String
    Dim sql13 As String
    Dim sql14 As String
    Dim sql15 As String
    Dim sql16 As String
    Dim dr As MySqlDataReader

    Private Sub lbldate1_Click(sender As System.Object, e As System.EventArgs) Handles lbldate1.Click

    End Sub

    Private Sub txtdatefrom_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdatefrom.TextChanged
        Dim d As Date = DateTimePicker1.Value
        d = d.AddDays(+1)


        lbldate1.Text = txtdatefrom.Text
        lbldate2.Text = Format(d, "yyyy-MM-dd")
        lbldate3.Text = Format(d.AddDays(+1), "yyyy-MM-dd")
        lbldate4.Text = Format(d.AddDays(+2), "yyyy-MM-dd")
        lbldate5.Text = Format(d.AddDays(+3), "yyyy-MM-dd")
        lbldate6.Text = Format(d.AddDays(+4), "yyyy-MM-dd")
        lbldate7.Text = Format(d.AddDays(+5), "yyyy-MM-dd")
        lbldate8.Text = Format(d.AddDays(+6), "yyyy-MM-dd")
        lbldate9.Text = Format(d.AddDays(+7), "yyyy-MM-dd")
        lbldate10.Text = Format(d.AddDays(+8), "yyyy-MM-dd")
        lbldate11.Text = Format(d.AddDays(+9), "yyyy-MM-dd")
        lbldate12.Text = Format(d.AddDays(+10), "yyyy-MM-dd")
        lbldate13.Text = Format(d.AddDays(+11), "yyyy-MM-dd")
        lbldate14.Text = Format(d.AddDays(+12), "yyyy-MM-dd")
        lbldate15.Text = Format(d.AddDays(+13), "yyyy-MM-dd")
        lbldate16.Text = Format(d.AddDays(+14), "yyyy-MM-dd")
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        txtdatefrom.Text = Format(DateTimePicker1.Value, "yyyy-MM-dd")
        Me.txtMonth.Text = MonthName(Month(Me.DateTimePicker1.Value))
        Me.txtYear.Text = Year(Me.DateTimePicker1.Value)
    End Sub

    Private Sub frmtimekeepingtemp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "Server=localhost; userid=root; password=; database=demandph;"
            sConnection.Open()
        End If
        Call FillFname()
    End Sub
    Private Sub FillFname()
        Try
            con.Open()
            sql = "SELECT * from tblemployee ORDER BY employee_id ASC"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim sId = dr.GetInt32("employee_id")
                cmbEmployeename.Items.Add(sId)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub Label16_Click(sender As System.Object, e As System.EventArgs) Handles lbldate12.Click

    End Sub

    Private Sub txtEmployeename_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEmployeename.TextChanged

        Try
            con.Open()
            sql = "SELECT * FROM tblemployee WHERE employee_id ='" & txtEmployeename.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtId.Text = dr.GetInt32("employee_id")
                txtLastname.Text = dr.GetString("lastname")
                txtFirstname.Text = dr.GetString("firstname")
                txtMiddlename.Text = dr.GetString("middlename")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try

        ' Day 1
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate1.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin1.Text = dr.GetString("punch_in")
                txtpunchin1.Text = FormatDateTime(txtpunchin1.Text, DateFormat.LongTime)
                txtpunchout1.Text = dr.GetString("punch_out")
                txtpunchout1.Text = FormatDateTime(txtpunchout1.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try


        ' Day 2
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate2.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin2.Text = dr.GetString("punch_in")
                txtpunchin2.Text = FormatDateTime(txtpunchin2.Text, DateFormat.LongTime)
                txtpunchout2.Text = dr.GetString("punch_out")
                txtpunchout2.Text = FormatDateTime(txtpunchout2.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try



        ' Day 3
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate3.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin3.Text = dr.GetString("punch_in")
                txtpunchin3.Text = FormatDateTime(txtpunchin3.Text, DateFormat.LongTime)
                txtpunchout3.Text = dr.GetString("punch_out")
                txtpunchout3.Text = FormatDateTime(txtpunchout3.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try


        ' Day 4
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate4.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin4.Text = dr.GetString("punch_in")
                txtpunchin4.Text = FormatDateTime(txtpunchin4.Text, DateFormat.LongTime)
                txtpunchout4.Text = dr.GetString("punch_out")
                txtpunchout4.Text = FormatDateTime(txtpunchout4.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try

        ' Day 5
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate5.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin5.Text = dr.GetString("punch_in")
                txtpunchin5.Text = FormatDateTime(txtpunchin5.Text, DateFormat.LongTime)
                txtpunchout5.Text = dr.GetString("punch_out")
                txtpunchout5.Text = FormatDateTime(txtpunchout5.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try




        ' Day 6
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate6.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin6.Text = dr.GetString("punch_in")
                txtpunchin6.Text = FormatDateTime(txtpunchin6.Text, DateFormat.LongTime)
                txtpunchout6.Text = dr.GetString("punch_out")
                txtpunchout6.Text = FormatDateTime(txtpunchout6.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try

        ' Day 7
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate7.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin7.Text = dr.GetString("punch_in")
                txtpunchin7.Text = FormatDateTime(txtpunchin7.Text, DateFormat.LongTime)
                txtpunchout7.Text = dr.GetString("punch_out")
                txtpunchout7.Text = FormatDateTime(txtpunchout7.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try

        ' Day 8
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate8.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin8.Text = dr.GetString("punch_in")
                txtpunchin8.Text = FormatDateTime(txtpunchin8.Text, DateFormat.LongTime)
                txtpunchout8.Text = dr.GetString("punch_out")
                txtpunchout8.Text = FormatDateTime(txtpunchout8.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try

        ' Day 9
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate9.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin9.Text = dr.GetString("punch_in")
                txtpunchin9.Text = FormatDateTime(txtpunchin9.Text, DateFormat.LongTime)
                txtpunchout9.Text = dr.GetString("punch_out")
                txtpunchout9.Text = FormatDateTime(txtpunchout9.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try

        ' Day 10
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate10.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin10.Text = dr.GetString("punch_in")
                txtpunchin10.Text = FormatDateTime(txtpunchin10.Text, DateFormat.LongTime)
                txtpunchout10.Text = dr.GetString("punch_out")
                txtpunchout10.Text = FormatDateTime(txtpunchout10.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try

        ' Day 11
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate11.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin11.Text = dr.GetString("punch_in")
                txtpunchin11.Text = FormatDateTime(txtpunchin11.Text, DateFormat.LongTime)
                txtpunchout11.Text = dr.GetString("punch_out")
                txtpunchout11.Text = FormatDateTime(txtpunchout11.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try

        ' Day 12
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate12.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin12.Text = dr.GetString("punch_in")
                txtpunchin12.Text = FormatDateTime(txtpunchin12.Text, DateFormat.LongTime)
                txtpunchout12.Text = dr.GetString("punch_out")
                txtpunchout12.Text = FormatDateTime(txtpunchout12.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try


        ' Day 13
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate13.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin13.Text = dr.GetString("punch_in")
                txtpunchin13.Text = FormatDateTime(txtpunchin13.Text, DateFormat.LongTime)
                txtpunchout13.Text = dr.GetString("punch_out")
                txtpunchout13.Text = FormatDateTime(txtpunchout13.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try


        ' Day 14
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate14.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin14.Text = dr.GetString("punch_in")
                txtpunchin14.Text = FormatDateTime(txtpunchin14.Text, DateFormat.LongTime)
                txtpunchout14.Text = dr.GetString("punch_out")
                txtpunchout14.Text = FormatDateTime(txtpunchout14.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try



        ' Day 15
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate15.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin15.Text = dr.GetString("punch_in")
                txtpunchin15.Text = FormatDateTime(txtpunchin15.Text, DateFormat.LongTime)
                txtpunchout15.Text = dr.GetString("punch_out")
                txtpunchout15.Text = FormatDateTime(txtpunchout15.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try



        ' Day 16
        Try
            con.Open()
            sql = "SELECT tblemployee.employee_id,tbltimein.date AS date,tbltimein.time AS punch_in,tbltimeout.time AS punch_out FROM tblemployee JOIN tbltimein ON tblemployee.employee_id=tbltimein.employee_id JOIN tbltimeout ON tblemployee.employee_id=tbltimeout.employee_id WHERE tblemployee.employee_id = '" & txtId.Text & "' AND tbltimein.date =  '" & lbldate16.Text & "' LIMIT 1"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtpunchin16.Text = dr.GetString("punch_in")
                txtpunchin16.Text = FormatDateTime(txtpunchin16.Text, DateFormat.LongTime)
                txtpunchout16.Text = dr.GetString("punch_out")
                txtpunchout16.Text = FormatDateTime(txtpunchout16.Text, DateFormat.LongTime)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try


    End Sub

    Private Sub cmbEmployeename_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbEmployeename.SelectedIndexChanged
        txtEmployeename.Text = cmbEmployeename.Text

    End Sub

    Private Sub txtId_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtId.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime1.Click
        frmovertime.lbldate.Text = lbldate1.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub btnAddrow_Click(sender As System.Object, e As System.EventArgs) Handles btnAddrow.Click
        lbldate16.Visible = True
        txtpunchin16.Visible = True
        txtpunchout16.Visible = True
        txtattendance16.Visible = True
        txtovertime16.Visible = True
        btnOvertime16.Visible = True
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        txtdateto.Text = Format(DateTimePicker2.Value, "yyyy-MM-dd")
    End Sub

    Private Sub txtLastname_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLastname.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            con.Open()
            sql = "SELECT * FROM tblattendance WHERE employee_id='" & txtId.Text & "' AND date_from= '" & txtdatefrom.Text & "' AND date_to='" & txtdateto.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Payroll already generated!", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()
                sql1 = "INSERT INTO tblattendance (employee_id,date,punch_in,punch_out,attendance,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & lbldate1.Text & "','" & txtpunchin1.Text & "','" & txtpunchout1.Text & "','" & txtattendance1.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd1 = New MySqlCommand(sql1, con)
                cmd1.ExecuteNonQuery()
                sql2 = "INSERT INTO tblattendance (employee_id,date,punch_in,punch_out,attendance,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & lbldate2.Text & "','" & txtpunchin2.Text & "','" & txtpunchout2.Text & "','" & txtattendance2.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd2 = New MySqlCommand(sql2, con)
                cmd2.ExecuteNonQuery()
                sql3 = "INSERT INTO tblattendance (employee_id,date,punch_in,punch_out,attendance,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & lbldate3.Text & "','" & txtpunchin3.Text & "','" & txtpunchout3.Text & "','" & txtattendance3.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd3 = New MySqlCommand(sql3, con)
                cmd3.ExecuteNonQuery()
                sql4 = "INSERT INTO tblattendance (employee_id,date,punch_in,punch_out,attendance,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & lbldate4.Text & "','" & txtpunchin4.Text & "','" & txtpunchout4.Text & "','" & txtattendance4.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd4 = New MySqlCommand(sql4, con)
                cmd4.ExecuteNonQuery()
                sql5 = "INSERT INTO tblattendance (employee_id,date,punch_in,punch_out,attendance,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & lbldate5.Text & "','" & txtpunchin5.Text & "','" & txtpunchout5.Text & "','" & txtattendance5.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd5 = New MySqlCommand(sql5, con)
                cmd5.ExecuteNonQuery()
                sql6 = "INSERT INTO tblattendance (employee_id,date,punch_in,punch_out,attendance,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & lbldate6.Text & "','" & txtpunchin6.Text & "','" & txtpunchout6.Text & "','" & txtattendance6.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd6 = New MySqlCommand(sql6, con)
                cmd6.ExecuteNonQuery()
                sql7 = "INSERT INTO tblattendance (employee_id,date,punch_in,punch_out,attendance,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & lbldate7.Text & "','" & txtpunchin7.Text & "','" & txtpunchout7.Text & "','" & txtattendance7.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd7 = New MySqlCommand(sql7, con)
                cmd7.ExecuteNonQuery()
                sql8 = "INSERT INTO tblattendance (employee_id,date,punch_in,punch_out,attendance,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & lbldate8.Text & "','" & txtpunchin8.Text & "','" & txtpunchout8.Text & "','" & txtattendance8.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd8 = New MySqlCommand(sql8, con)
                cmd8.ExecuteNonQuery()
                sql9 = "INSERT INTO tblattendance (employee_id,date,punch_in,punch_out,attendance,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & lbldate9.Text & "','" & txtpunchin9.Text & "','" & txtpunchout9.Text & "','" & txtattendance9.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd9 = New MySqlCommand(sql9, con)
                cmd9.ExecuteNonQuery()
                sql10 = "INSERT INTO tblattendance (employee_id,date,punch_in,punch_out,attendance,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & lbldate10.Text & "','" & txtpunchin10.Text & "','" & txtpunchout10.Text & "','" & txtattendance10.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd10 = New MySqlCommand(sql10, con)
                cmd10.ExecuteNonQuery()
                sql11 = "INSERT INTO tblattendance (employee_id,date,punch_in,punch_out,attendance,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & lbldate11.Text & "','" & txtpunchin11.Text & "','" & txtpunchout11.Text & "','" & txtattendance11.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd11 = New MySqlCommand(sql11, con)
                cmd11.ExecuteNonQuery()
                sql12 = "INSERT INTO tblattendance (employee_id,date,punch_in,punch_out,attendance,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & lbldate12.Text & "','" & txtpunchin12.Text & "','" & txtpunchout12.Text & "','" & txtattendance12.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd12 = New MySqlCommand(sql12, con)
                cmd12.ExecuteNonQuery()
                sql13 = "INSERT INTO tblattendance (employee_id,date,punch_in,punch_out,attendance,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & lbldate13.Text & "','" & txtpunchin13.Text & "','" & txtpunchout13.Text & "','" & txtattendance13.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd13 = New MySqlCommand(sql13, con)
                cmd13.ExecuteNonQuery()
                sql14 = "INSERT INTO tblattendance (employee_id,date,punch_in,punch_out,attendance,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & lbldate14.Text & "','" & txtpunchin14.Text & "','" & txtpunchout14.Text & "','" & txtattendance14.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd14 = New MySqlCommand(sql14, con)
                cmd14.ExecuteNonQuery()
                sql15 = "INSERT INTO tblattendance (employee_id,date,punch_in,punch_out,attendance,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & lbldate15.Text & "','" & txtpunchin15.Text & "','" & txtpunchout15.Text & "','" & txtattendance15.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd15 = New MySqlCommand(sql15, con)
                cmd15.ExecuteNonQuery()
                MsgBox("Sucessfully Saved")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try

        txtEmployeename.Text = ""
        txtId.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        txtLastname.Text = ""

        txtpunchin1.Text = ""
        txtpunchin2.Text = ""
        txtpunchin3.Text = ""
        txtpunchin4.Text = ""
        txtpunchin5.Text = ""
        txtpunchin6.Text = ""
        txtpunchin7.Text = ""
        txtpunchin8.Text = ""
        txtpunchin9.Text = ""
        txtpunchin10.Text = ""
        txtpunchin11.Text = ""
        txtpunchin12.Text = ""
        txtpunchin13.Text = ""
        txtpunchin14.Text = ""
        txtpunchin15.Text = ""
        txtpunchin16.Text = ""

        txtpunchout1.Text = ""
        txtpunchout2.Text = ""
        txtpunchout3.Text = ""
        txtpunchout4.Text = ""
        txtpunchout5.Text = ""
        txtpunchout6.Text = ""
        txtpunchout7.Text = ""
        txtpunchout8.Text = ""
        txtpunchout9.Text = ""
        txtpunchout10.Text = ""
        txtpunchout11.Text = ""
        txtpunchout12.Text = ""
        txtpunchout13.Text = ""
        txtpunchout14.Text = ""
        txtpunchout15.Text = ""
        txtpunchout16.Text = ""

        txtattendance1.Text = ""
        txtattendance2.Text = ""
        txtattendance3.Text = ""
        txtattendance4.Text = ""
        txtattendance5.Text = ""
        txtattendance6.Text = ""
        txtattendance7.Text = ""
        txtattendance8.Text = ""
        txtattendance9.Text = ""
        txtattendance10.Text = ""
        txtattendance11.Text = ""
        txtattendance12.Text = ""
        txtattendance13.Text = ""
        txtattendance14.Text = ""
        txtattendance15.Text = ""
        txtattendance16.Text = ""

        txtovertime1.Text = ""
        txtovertime2.Text = ""
        txtovertime3.Text = ""
        txtovertime4.Text = ""
        txtovertime5.Text = ""
        txtovertime6.Text = ""
        txtovertime7.Text = ""
        txtovertime8.Text = ""
        txtovertime9.Text = ""
        txtovertime10.Text = ""
        txtovertime11.Text = ""
        txtovertime12.Text = ""
        txtovertime13.Text = ""
        txtovertime14.Text = ""
        txtovertime15.Text = ""
        txtovertime16.Text = ""

    End Sub

    Private Sub btnOvertime2_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime2.Click
        frmovertime.lbldate.Text = lbldate2.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub btnOvertime3_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime3.Click
        frmovertime.lbldate.Text = lbldate3.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub btnOvertime4_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime4.Click
        frmovertime.lbldate.Text = lbldate4.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub btnOvertime5_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime5.Click
        frmovertime.lbldate.Text = lbldate5.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub btnOvertime6_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime6.Click
        frmovertime.lbldate.Text = lbldate6.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub btnOvertime7_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime7.Click
        frmovertime.lbldate.Text = lbldate7.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub btnOvertime8_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime8.Click
        frmovertime.lbldate.Text = lbldate8.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub btnOvertime9_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime9.Click
        frmovertime.lbldate.Text = lbldate9.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub btnOvertime10_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime10.Click
        frmovertime.lbldate.Text = lbldate10.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub btnOvertime11_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime11.Click
        frmovertime.lbldate.Text = lbldate11.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub btnOvertime12_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime12.Click
        frmovertime.lbldate.Text = lbldate12.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub btnOvertime13_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime13.Click
        frmovertime.lbldate.Text = lbldate13.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub btnOvertime14_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime14.Click
        frmovertime.lbldate.Text = lbldate14.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub btnOvertime15_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime15.Click
        frmovertime.lbldate.Text = lbldate15.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub btnOvertime16_Click(sender As System.Object, e As System.EventArgs) Handles btnOvertime16.Click
        frmovertime.lbldate.Text = lbldate16.Text
        frmovertime.txtId.Text = txtId.Text
        frmovertime.txtFirstname.Text = txtFirstname.Text
        frmovertime.txtMiddlename.Text = txtMiddlename.Text
        frmovertime.txtLastname.Text = txtLastname.Text
        frmovertime.Show()
    End Sub

    Private Sub txtovertime1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtovertime1.TextChanged

    End Sub

    Private Sub btnOvertime1_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime1.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate1.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime1.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnOvertime2_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime2.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate2.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime2.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnOvertime3_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime3.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate3.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime3.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnOvertime4_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime4.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate4.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime4.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnOvertime5_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime5.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate1.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime1.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnOvertime6_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime6.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate6.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime6.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnOvertime7_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime7.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate7.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime7.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnOvertime8_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime8.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate8.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime8.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnOvertime9_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime9.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate9.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime9.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnOvertime10_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime10.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate10.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime10.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnOvertime11_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime11.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate11.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime11.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnOvertime12_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime12.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate12.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime12.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnOvertime13_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime13.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate13.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime13.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnOvertime14_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime14.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate14.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime14.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnOvertime15_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime15.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate15.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime15.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub

    Private Sub btnOvertime16_LostFocus(sender As Object, e As System.EventArgs) Handles btnOvertime16.LostFocus
        Try
            con.Open()
            sql = "SELECT * FROM tblovertime WHERE employee_id = '" & txtId.Text & "' AND date = '" & lbldate16.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtovertime16.Text = dr.GetDecimal("total_hours")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub
    Public Sub LoadView()
        Dim sqlQuery As String = "SELECT DISTINCT tblemployee.employee_id,tblemployee.lastname,tblemployee.firstname,tblemployee.middlename FROM tblattendance INNER JOIN tblemployee ON tblemployee.employee_id = tblattendance.employee_id WHERE date_from = '" & txtdatefrom.Text & "' AND date_to = '" & txtdateto.Text & "' ORDER BY tblemployee.employee_id DESC"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand
        Dim table As New DataTable
        Dim i As Integer

        With sqlCommand
            .CommandText = sqlQuery
            .Connection = sConnection
        End With

        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(table)
        End With

        For i = 0 To table.Rows.Count - 1
            With lvTimekeeping

                .Items.Add(table.Rows(i)("employee_id"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(table.Rows(i)("firstname") + " " + table.Rows(i)("middlename") + " " + table.Rows(i)("lastname"))
                End With
                Label12.Text = lvTimekeeping.Items.Count
            End With
        Next
    End Sub

    Private Sub txtdateto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdateto.TextChanged
        Call LoadView()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        txtEmployeename.Text = ""
        txtId.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        txtLastname.Text = ""

        txtpunchin1.Text = ""
        txtpunchin2.Text = ""
        txtpunchin3.Text = ""
        txtpunchin4.Text = ""
        txtpunchin5.Text = ""
        txtpunchin6.Text = ""
        txtpunchin7.Text = ""
        txtpunchin8.Text = ""
        txtpunchin9.Text = ""
        txtpunchin10.Text = ""
        txtpunchin11.Text = ""
        txtpunchin12.Text = ""
        txtpunchin13.Text = ""
        txtpunchin14.Text = ""
        txtpunchin15.Text = ""
        txtpunchin16.Text = ""

        txtpunchout1.Text = ""
        txtpunchout2.Text = ""
        txtpunchout3.Text = ""
        txtpunchout4.Text = ""
        txtpunchout5.Text = ""
        txtpunchout6.Text = ""
        txtpunchout7.Text = ""
        txtpunchout8.Text = ""
        txtpunchout9.Text = ""
        txtpunchout10.Text = ""
        txtpunchout11.Text = ""
        txtpunchout12.Text = ""
        txtpunchout13.Text = ""
        txtpunchout14.Text = ""
        txtpunchout15.Text = ""
        txtpunchout16.Text = ""

        txtattendance1.Text = ""
        txtattendance2.Text = ""
        txtattendance3.Text = ""
        txtattendance4.Text = ""
        txtattendance5.Text = ""
        txtattendance6.Text = ""
        txtattendance7.Text = ""
        txtattendance8.Text = ""
        txtattendance9.Text = ""
        txtattendance10.Text = ""
        txtattendance11.Text = ""
        txtattendance12.Text = ""
        txtattendance13.Text = ""
        txtattendance14.Text = ""
        txtattendance15.Text = ""
        txtattendance16.Text = ""

        txtovertime1.Text = ""
        txtovertime2.Text = ""
        txtovertime3.Text = ""
        txtovertime4.Text = ""
        txtovertime5.Text = ""
        txtovertime6.Text = ""
        txtovertime7.Text = ""
        txtovertime8.Text = ""
        txtovertime9.Text = ""
        txtovertime10.Text = ""
        txtovertime11.Text = ""
        txtovertime12.Text = ""
        txtovertime13.Text = ""
        txtovertime14.Text = ""
        txtovertime15.Text = ""
        txtovertime16.Text = ""

    End Sub
End Class
