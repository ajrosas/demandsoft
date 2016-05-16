Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.IO

Imports MySql.Data.MySqlClient
Public Class frmtimein
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
    'SET A VARIABLE FOR STORING RESULT IN IT
    Dim result As Integer
    Private Sub frmtimein_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles btnBrowse.Click
        Dim conn As OleDbConnection
        Dim dta As OleDbDataAdapter
        Dim dts As DataSet
        Dim excel As String
        Dim OpenFileDialog As New OpenFileDialog

        Timer1.Start()
        btnBrowse.Enabled = False
        btnSave.Enabled = False
        btnBrowse.Text = "Processing....."
        btnSave.Text = "Processing....."

        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "All Files (*.*)|*.*|Excel Files (*.xlsx|*.xlsx|CSV Files (*.cvs)|*.csv|XLS Files (*.xls)|*.xls"

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim fi As New FileInfo(OpenFileDialog.FileName)
            Dim FileName As String = OpenFileDialog.FileName
            txtFilename.Text = fi.ToString

            excel = fi.FullName
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
            dta = New OleDbDataAdapter("SELECT * FROM [Sheet2$]", conn)
            dts = New DataSet
            dta.Fill(dts, "[Sheet2$]")
            DataGridView1.DataSource = dts
            DataGridView1.DataMember = "[Sheet2$]"
            DataGridView1.Columns.Item("DaiGong").DefaultCellStyle.Format = "yyyy-MM-dd hh:mm:ss"
            conn.Close()
        End If
        btnSave.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        Timer2.Start()
        btnBrowse.Enabled = False
        btnSave.Enabled = False
        btnBrowse.Text = "Processing....."
        btnSave.Text = "Processing....."

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
                    sql = "INSERT INTO tbltimein (employee_id,date,time,day) VALUES ('" _
                                    & CStr(row.Cells(2).FormattedValue) & "','" _
                                    & CStr(row.Cells(9).FormattedValue) & "','" _
                                    & CStr(row.Cells(9).FormattedValue) & "','" _
                                    & CStr(row.Cells(10).FormattedValue) & "')"

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
        btnBrowse.Enabled = False
        btnSave.Enabled = False
        btnNext.Enabled = True
    End Sub


    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            btnBrowse.Text = "Browse"
            btnSave.Text = "Save"
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            btnBrowse.Text = "Browse"
            btnSave.Text = "Save"
        End If
        btnSave.Enabled = False
    End Sub

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        frmtimeout.Show()
    End Sub
End Class