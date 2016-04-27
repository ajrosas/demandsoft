Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmpayslip
    Public sConnection As New MySqlConnection
    Private Sub frmpayslip_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If sConnection.State = ConnectionState.Closed Then
            sConnection.ConnectionString = "Server=localhost; userid=root; password=; database=demandph;"
            sConnection.Open()
        End If

        Label4.Text = "0"
        Label1.Text = "0.00"
    End Sub

    Public Sub LoadPayslip()
        Dim sqlQuery As String = "SELECT * FROM tblpayroll WHERE date_from = '" & txtdatefrom.Text & "' AND date_to = '" & txtdateto.Text & "'"
        Dim sqlAdapter As New MySqlDataAdapter
        Dim sqlCommand As New MySqlCommand
        Dim table As New DataTable
        Dim i As Integer
        Dim tot As Double

        With sqlCommand
            .CommandText = sqlQuery
            .Connection = sConnection
        End With

        With sqlAdapter
            .SelectCommand = sqlCommand
            .Fill(table)
        End With

        For i = 0 To table.Rows.Count - 1
            With lvPayslip

                .Items.Add(table.Rows(i)("firstname") + " " + table.Rows(i)("middlename") + " " + table.Rows(i)("lastname"))
                With .Items(.Items.Count - 1).SubItems
                    .Add(table.Rows(i)("rate"))
                    .Add(table.Rows(i)("production_allowance"))
                    .Add(table.Rows(i)("socio_econo_allowance"))
                    .Add(table.Rows(i)("meal_allowance"))
                    .Add(table.Rows(i)("regular_ot"))
                    .Add(table.Rows(i)("sunday_ot"))
                    .Add(table.Rows(i)("sunday_ot_excess"))
                    .Add(table.Rows(i)("legal_ot"))
                    .Add(table.Rows(i)("legal_ot_excess"))
                    .Add(table.Rows(i)("legal_holiday_w_pay"))
                    .Add(table.Rows(i)("night_differential"))
                    .Add(table.Rows(i)("night_differential_ot"))
                    .Add(table.Rows(i)("sunday_night_differential"))
                    .Add(table.Rows(i)("sunday_night_differential_ot"))
                    .Add(table.Rows(i)("legal_night_differential"))
                    .Add(table.Rows(i)("legal_night_differential_ot"))
                    .Add(table.Rows(i)("gross_pay"))
                    .Add(table.Rows(i)("adjustment"))
                    .Add(table.Rows(i)("sss_premium"))
                    .Add(table.Rows(i)("sss_loan"))
                    .Add(table.Rows(i)("philhealth"))
                    .Add(table.Rows(i)("pagibig_premium"))
                    .Add(table.Rows(i)("pagibig_loan"))
                    .Add(table.Rows(i)("undertime"))
                    .Add(table.Rows(i)("tardiness"))
                    .Add(table.Rows(i)("maintenance_fee"))
                    .Add(table.Rows(i)("hmo"))
                    .Add(table.Rows(i)("other_deductions"))
                    .Add(table.Rows(i)("net_pay"))
                End With
                tot = tot + Val(table.Rows(i)("net_pay"))
            End With
        Next
        Label1.Text = tot
        Label1.Text = FormatNumber(Label1.Text, 2)
        Label4.Text = lvPayslip.Items.Count

    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        LoadPayslip()
    End Sub

    Private Sub frmpayslip_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        txtdatefrom.Text = Format(DateTimePicker1.Value, "yyyy-MM-dd")
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        txtdateto.Text = Format(DateTimePicker2.Value, "yyyy-MM-dd")
    End Sub

    Private Sub txtdatefrom_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdatefrom.TextChanged
        Me.txtMonth.Text = MonthName(Month(Me.DateTimePicker1.Value))
        Me.txtYear.Text = Year(Me.DateTimePicker1.Value)
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub
End Class