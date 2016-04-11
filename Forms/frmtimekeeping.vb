Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.IO

Imports MySql.Data.MySqlClient
Public Class frmtimekeeping
    'SET UP A CONNECTION OF MYSQL DATABASE AND VISUAL BASIC.
    Dim con As MySqlConnection = New MySqlConnection("Server=gemsbrook.arvixe.com; userid=ajrosas_root; password=P@ssw0rd2016; database=ajrosas_orangepayroll;")
    'A SET OF COMMANDS IN MYSQL
    Dim cmd As New MySqlCommand
    'SET THE BRIDGE BETWEEN THE DATABASE AND THE DATASET FOR SAVING AND RETRIEVING DATA.
    Dim da As New MySqlDataAdapter
    'a specfic table in the database
    'A SPECIFIC TABLE IN THE DATABASE
    Dim dt As New DataTable
    'SET A VARIABLE FOR THE QUERY IN IT
    Dim sql As String
    'SET A VARIABLE FOR STORING RESULT IN IT
    Dim result As Integer
    Private Sub frmtimekeeping_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        Dim conn As OleDbConnection
        Dim dta As OleDbDataAdapter
        Dim dts As DataSet
        Dim excel As String
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "All Files (*.*)|*.*|Excel Files (*.xlsx|*.xlsx|CSV Files (*.cvs)|*.csv|XLS Files (*.xls)|*.xls"

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim fi As New FileInfo(OpenFileDialog.FileName)
            Dim FileName As String = OpenFileDialog.FileName
            txtFilename.Text = fi.ToString

            excel = fi.FullName
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
            dta = New OleDbDataAdapter("SELECT * FROM [Sheet1$]", conn)
            dts = New DataSet
            dta.Fill(dts, "[Sheet1$]")
            DataGridView1.DataSource = dts
            DataGridView1.DataMember = "[Sheet1$]"
            conn.Close()
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            'OPENING THE CONNECTION
            con.Open()
            'DATAGRIDVIEWRO REPRESENTS A ROW IN THE DATAGRIDVIEW CONTROL
            'ROWS IS A COLLECTION OF ROWS IN THE DATAGRIDVIEW 
            For Each row As DataGridViewRow In DataGridView1.Rows
                'CELL IS A COLLECTION OF CELL THAT POPULATE THE ROW
                'FORMATTEDVALUE IS GETTING THE VALUE OF THE CELL AS A FORMATED DISPLAY
                If row.Cells(0).FormattedValue <> "" Then
                    'STORE YOUR QUERY IN A VARIABLE THAT YOU HAVE DECLARED
                    sql = "INSERT INTO tbltimekeeping (firstname,middlename,lastname,regular_hours_required,holiday_hours_required,paid_holiday_hours,regular_hours_worked,required_holiday_hours,absences,tardiness,undertime,leaved,leave_type,rest_day,holiday,hours_type,nsd,overtime,overtime_type,month,date_from,date_to,year) VALUES ('" _
                                   & CStr(row.Cells(0).FormattedValue) & "','" _
                                   & CStr(row.Cells(1).FormattedValue) & "','" _
                                    & CStr(row.Cells(2).FormattedValue) & "','" _
                                    & CStr(row.Cells(3).FormattedValue) & "','" _
                                      & CStr(row.Cells(4).FormattedValue) & "','" _
                    & CStr(row.Cells(5).FormattedValue) & "','" _
                    & CStr(row.Cells(6).FormattedValue) & "','" _
                    & CStr(row.Cells(7).FormattedValue) & "','" _
                      & CStr(row.Cells(8).FormattedValue) & "','" _
                      & CStr(row.Cells(9).FormattedValue) & "','" _
                    & CStr(row.Cells(10).FormattedValue) & "','" _
                          & CStr(row.Cells(11).FormattedValue) & "','" _
                           & CStr(row.Cells(12).FormattedValue) & "','" _
                    & CStr(row.Cells(13).FormattedValue) & "','" _
                    & CStr(row.Cells(14).FormattedValue) & "','" _
                    & CStr(row.Cells(15).FormattedValue) & "','" _
                    & CStr(row.Cells(16).FormattedValue) & "','" _
                     & CStr(row.Cells(17).FormattedValue) & "','" _
                       & CStr(row.Cells(18).FormattedValue) & "','" _
                                         & txtMonth.Text & "','" _
                                                       & txtdatefrom.Text & "','" _
                                                        & txtdateto.Text & "','" _
                                                         & txtYear.Text & "')"


                   
                                                      
                    'SET YOUR COMMANDS TO PROVIDE A TEXT-BASE INTERFACE INTO THE MYSQL DATABASE SERVER. 
                    'AND ONCE IT'S CONNECTED, YOU CAN MAKE QUERY OR MANY OTHER OPERATION.
                    With cmd
                        .Connection = con
                        .CommandText = sql
                    End With
                    'Execute the Data
                    result = cmd.ExecuteNonQuery
                End If
            Next
            'CHECKING IF THE DATA ARE EXECUTED OF NOT.
            If result > 0 Then
                MsgBox("All Records Saved.")
            Else
                MsgBox("No saved Record.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'CLOSING THE CONNECTION 
        con.Close()
    End Sub

    Private Sub DateTimePicker1_TextChanged(sender As Object, e As System.EventArgs) Handles DateTimePicker1.TextChanged
        Me.txtMonth.Text = MonthName(Month(Me.DateTimePicker1.Value))
        Me.txtYear.Text = Year(Me.DateTimePicker1.Value)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        txtdatefrom.Text = Format(DateTimePicker1.Value, "yyyy-MM-dd")
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        txtdateto.Text = Format(DateTimePicker2.Value, "yyyy-MM-dd")
    End Sub

    Private Sub txtdateto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdateto.TextChanged

    End Sub
End Class
