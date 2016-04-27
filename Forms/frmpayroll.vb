Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class frmpayroll
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

    Private Sub frmpayroll_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call ToResetValue()
    End Sub
    Public Sub ToResetValue()
        txtEmployeename.Text = ""
        txtRate.Text = "310"
        txtProduction.Text = "0"
        txtSocioecono.Text = "0"
        txtMeal.Text = "0"
        txtRegot.Text = "0"
        txtSunot.Text = "0"
        txtSunotexcess.Text = "0"
        txtLegalot.Text = "0"
        txtLegalotexcess.Text = "0"
        txtlegalholidaywpay.Text = "0"
        txtNightdifferential.Text = "0"
        txtNightdifferentialot.Text = "0"
        txtSundaynightdiff.Text = "0"
        txtSundaynightdiffot.Text = "0"
        txtLegalnightdiff.Text = "0"
        txtLegalnightdiffot.Text = "0"
        txtGrosspay.Text = "0"
        txtAdjustment.Text = "0"
        txtSsspremium.Text = "0"
        txtSssloan.Text = "0"
        txtPhilhealth.Text = "0"
        txtPagibigpremium.Text = "0"
        txtPagibigloan.Text = "0"
        txtUndertime.Text = "0"
        txtTardiness.Text = "0"
        txtMaintenancefee.Text = "0"
        txtHmo.Text = "0"
        txtOtherdeductions.Text = "0"
        txtNetpay.Text = "0"

        txtId.Text = ""
        txtLastname.Text = ""
        txtFirstname.Text = ""
        txtMiddlename.Text = ""
        txtReguralhoursworked.Text = ""
        txtRegotval.Text = ""
        txtSunotval.Text = ""
        txtSunotexcessval.Text = ""
        txtLegalotval.Text = ""
        txtLegalotexcessval.Text = ""
        txtlegalholidaywpayval.Text = ""
        txtNightdifferentialval.Text = ""
        txtNightdifferentialotval.Text = ""
        txtSundaynightdiffval.Text = ""
        txtSundaynightdiffotval.Text = ""
        txtLegalnightdiffval.Text = ""
        txtLegalnightdiffotval.Text = ""
        txtDaysworkedwsunday.Text = ""
        txtDaystotalwlegal.Text = ""
        txtUndertimeval.Text = ""
        txtTardinessval.Text = ""

        Call ToCurrency()
        Call ToCurrency()
    End Sub
    Public Sub ToCurrency()
        txtRate.Text = FormatNumber(Me.txtRate.Text, 2)
        txtProduction.Text = FormatNumber(Me.txtProduction.Text, 2)
        txtSocioecono.Text = FormatNumber(Me.txtSocioecono.Text, 2)
        txtMeal.Text = FormatNumber(Me.txtMeal.Text, 2)
        txtRegot.Text = FormatNumber(Me.txtRegot.Text, 2)
        txtSunot.Text = FormatNumber(Me.txtSunot.Text, 2)
        txtSunotexcess.Text = FormatNumber(Me.txtSunotexcess.Text, 2)
        txtLegalot.Text = FormatNumber(Me.txtLegalot.Text, 2)
        txtLegalotexcess.Text = FormatNumber(Me.txtLegalotexcess.Text, 2)
        txtlegalholidaywpay.Text = FormatNumber(Me.txtlegalholidaywpay.Text, 2)
        txtNightdifferential.Text = FormatNumber(Me.txtNightdifferential.Text, 2)
        txtNightdifferentialot.Text = FormatNumber(Me.txtNightdifferentialot.Text, 2)
        txtSundaynightdiff.Text = FormatNumber(Me.txtSundaynightdiff.Text, 2)
        txtSundaynightdiffot.Text = FormatNumber(Me.txtSundaynightdiffot.Text, 2)
        txtLegalnightdiff.Text = FormatNumber(Me.txtLegalnightdiff.Text, 2)
        txtLegalnightdiffot.Text = FormatNumber(Me.txtLegalnightdiffot.Text, 2)
        txtGrosspay.Text = FormatNumber(Me.txtGrosspay.Text, 2)
        txtAdjustment.Text = FormatNumber(Me.txtAdjustment.Text, 2)
        txtSsspremium.Text = Format((Val(txtSsspremium.Text)), "0.00")
        txtSssloan.Text = Format((Val(txtSssloan.Text)), "0.00")
        txtPhilhealth.Text = FormatNumber(Me.txtPhilhealth.Text, 2)
        txtPagibigpremium.Text = FormatNumber(Me.txtPagibigpremium.Text)
        txtPagibigloan.Text = FormatNumber(Me.txtPagibigloan.Text, 2)
        txtUndertime.Text = FormatNumber(Me.txtUndertime.Text, 2)
        txtTardiness.Text = FormatNumber(Me.txtTardiness.Text, 2)
        txtMaintenancefee.Text = FormatNumber(Me.txtMaintenancefee.Text, 2)
        txtHmo.Text = FormatNumber(Me.txtHmo.Text, 2)
        txtOtherdeductions.Text = FormatNumber(Me.txtOtherdeductions.Text, 2)
        txtNetpay.Text = FormatNumber(Me.txtNetpay.Text, 2)
    End Sub

    Public Sub ComputePayroll()

        txtProduction.Text = Format((Val(txtDaystotalwlegal.Text) * 12.5), "0.00")
        txtSocioecono.Text = Format((Val(txtDaystotalwlegal.Text) * 13), "0.00")
        txtMeal.Text = Format((Val(txtDaysworkedwsunday.Text) * 4), "0.00")

        txtGrosspay1.Text = Format(Val(txtDaysworked.Text) * Val(txtRate.Text), "0.00")
        txtRegot.Text = Format(Val(txtRate.Text) / 8 * 1.25 * Val(txtRegotval.Text), "0.00")
        txtSunot.Text = Format(Val(txtRate.Text / 8 * 1.3 * Val(txtSunotval.Text)), "0.00")
        txtSunotexcess.Text = Format(Val(txtRate.Text / 8 * 1.69 * Val(txtSunotexcessval.Text)), "0.00")
        txtLegalot.Text = Format((Val(txtRate.Text / 8 * 2 * Val(txtLegalotval.Text))), "0.00")
        txtLegalotexcess.Text = Format((Val(txtRate.Text / 8 * 2.6 * Val(txtLegalotexcessval.Text))), "0.00")
        txtlegalholidaywpay.Text = Format((Val(txtRate.Text / 8 * Val(txtlegalholidaywpayval.Text))), "0.00")
        txtNightdifferential.Text = Format((Val(txtRate.Text / 8 * 0.1 * Val(txtNightdifferentialval.Text))), "0.00")
        txtNightdifferentialot.Text = Format((Val(txtNightdifferentialotval.Text) * 4.84), "0.00")
        txtSundaynightdiff.Text = Format((Val(txtSundaynightdiffval.Text) * 5.04), "0.00")
        txtSundaynightdiffot.Text = Format((Val(txtSundaynightdiffotval.Text) * 6.55), "0.00")
        txtLegalnightdiff.Text = Format((Val(txtLegalnightdiffval.Text) * 7.75), "0.00")
        txtLegalnightdiffot.Text = Format((Val(txtLegalnightdiffotval.Text) * 10.08), "0.00")

        txtGrosspay.Text = Format((Val(Me.txtGrosspay1.Text) + Val(Me.txtProduction.Text) + Val(Me.txtSocioecono.Text) + Val(Me.txtMeal.Text) + Val(Me.txtRegot.Text) + Val(Me.txtSunot.Text) + Val(Me.txtSunotexcess.Text) + Val(Me.txtLegalot.Text) + Val(Me.txtLegalotexcess.Text) + Val(Me.txtlegalholidaywpay.Text) + Val(Me.txtNightdifferential.Text) + Val(Me.txtNightdifferentialot.Text) + Val(Me.txtSundaynightdiff.Text) + Val(Me.txtSundaynightdiffot.Text) + Val(Me.txtLegalnightdiff.Text) + Val(Me.txtLegalnightdiffot.Text)), "0.00")

        txtNetpay1.Text = Format((Val(Me.txtAdjustment.Text) + Val(Me.txtSsspremium.Text) + Val(Me.txtSssloan.Text) + Val(Me.txtPhilhealth.Text) + Val(Me.txtPagibigpremium.Text) + Val(Me.txtPagibigloan.Text) + Val(Me.txtUndertime.Text) + Val(Me.txtTardiness.Text) + Val(Me.txtMaintenancefee.Text) + Val(Me.txtHmo.Text) + Val(Me.txtOtherdeductions.Text)), "0.00")

        txtNetpay.Text = Format((Val(Me.txtGrosspay.Text) - Val(Me.txtNetpay1.Text)), "0.00")


    End Sub

    Private Sub cmbEmployeename_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbEmployeename.SelectedIndexChanged
        txtEmployeename.Text = cmbEmployeename.Text
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            con.Open()
            sql = "SELECT * FROM tblpayroll WHERE timekeeping_id='" & txtId.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Payroll already generated!", MsgBoxStyle.Critical)
                con.Close()
            Else
                con.Close()
                con.Open()
                sql = "INSERT INTO tblpayroll (timekeeping_id,firstname,middlename,lastname,rate,d_rate,production_allowance,socio_econo_allowance,meal_allowance,regular_ot,sunday_ot,sunday_ot_excess,legal_ot,legal_ot_excess,legal_holiday_w_pay,night_differential,night_differential_ot,sunday_night_differential,sunday_night_differential_ot,legal_night_differential,legal_night_differential_ot,gross_pay,adjustment,sss_premium,sss_loan,philhealth,pagibig_premium,pagibig_loan,undertime,tardiness,maintenance_fee,hmo,other_deductions,net_pay,month,date_from,date_to,year) VALUES ('" & txtId.Text & "', '" & txtFirstname.Text & "','" & txtMiddlename.Text & "','" & txtLastname.Text & "','" & txtRate.Text & "','" & txtGrosspay1.Text & "','" & txtProduction.Text & "','" & txtSocioecono.Text & "','" & txtMeal.Text & "','" & txtRegot.Text & "','" & txtSunot.Text & "','" & txtSunotexcess.Text & "','" & txtLegalot.Text & "','" & txtLegalotexcess.Text & "','" & txtlegalholidaywpay.Text & "','" & txtNightdifferential.Text & "','" & txtNightdifferentialot.Text & "','" & txtSundaynightdiff.Text & "','" & txtSundaynightdiffot.Text & "','" & txtLegalnightdiff.Text & "','" & txtLegalnightdiffot.Text & "','" & txtGrosspay.Text & "','" & txtAdjustment.Text & "','" & txtSsspremium.Text & "','" & txtSssloan.Text & "','" & txtPhilhealth.Text & "','" & txtPagibigpremium.Text & "','" & txtPagibigloan.Text & "','" & txtUndertime.Text & "','" & txtTardiness.Text & "','" & txtMaintenancefee.Text & "','" & txtHmo.Text & "','" & txtOtherdeductions.Text & "','" & txtNetpay.Text & "','" & txtMonth.Text & "','" & txtdatefrom.Text & "','" & txtdateto.Text & "','" & txtYear.Text & "')"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Sucessfully Saved")
            End If
            con.Close()
            Call ToResetValue()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
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
        Call FillFname()
    End Sub
    Private Sub FillFname()
        Try
            con.Open()
            sql = "SELECT * from tbltimekeeping WHERE date_from = '" & txtdatefrom.Text & "' AND date_to = '" & txtdateto.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                Dim sFname = dr.GetString("firstname") + " " + dr.GetString("middlename") + " " + dr.GetString("lastname")
                cmbEmployeename.Items.Add(sFname)
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try
    End Sub
    Private Sub txtReguralhoursworked_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtReguralhoursworked.TextChanged
        txtDaysworked.Text = Val(Me.txtReguralhoursworked.Text) / 8
    End Sub

    Private Sub txtDaysworked_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDaysworked.TextChanged
        txtDaystotal.Text = Me.txtDaysworked.Text
    End Sub

    Private Sub txtlegalholidaywpayval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtlegalholidaywpayval.TextChanged
        If txtlegalholidaywpayval.Text = "8" Then
            txtDaystotalwlegal.Text = Val(Me.txtDaystotal.Text) + 1

        End If

        If txtlegalholidaywpayval.Text = "16" Then
            txtDaystotalwlegal.Text = Val(Me.txtDaystotal.Text) + 2
        End If
        Call ComputePayroll()
    End Sub

    Private Sub txtSunotval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSunotval.TextChanged
        If txtSunotval.Text = "8" Then
            txtDaystotal.Text = Val(Me.txtDaystotal.Text) + 1
            txtDaysworkedwsunday.Text = Val(Me.txtDaysworked.Text) + 1

        End If

        If txtSunotval.Text = "16" Then
            txtDaystotal.Text = Val(Me.txtDaystotal.Text) + 2
            txtDaysworkedwsunday.Text = Val(Me.txtDaysworked.Text) + 2
        End If
        Call ComputePayroll()
    End Sub

    Private Sub txtSunotexcessval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSunotexcessval.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtLegalotval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLegalotval.TextChanged
        If txtLegalotval.Text = "8" Then
            txtDaystotal.Text = Val(Me.txtDaystotal.Text) + 1
            txtDaystotalwlegal.Text = Val(Me.txtDaystotal.Text)
        End If

        If txtLegalotval.Text = "16" Then
            txtDaystotal.Text = Val(Me.txtDaystotal.Text) + 2
            txtDaystotalwlegal.Text = Val(Me.txtDaystotal.Text)
        End If
        Call ComputePayroll()
    End Sub

    Private Sub txtRegotval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRegotval.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtNightdifferentialval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNightdifferentialval.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtDaystotal_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDaystotal.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtLegalotexcessval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLegalotexcessval.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtNightdifferentialotval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNightdifferentialotval.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtSundaynightdiffval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSundaynightdiffval.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtSundaynightdiffotval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSundaynightdiffotval.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtLegalnightdiffval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLegalnightdiffval.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtLegalnightdiffotval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLegalnightdiffotval.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtAdjustment_LostFocus(sender As Object, e As System.EventArgs) Handles txtAdjustment.LostFocus
        txtAdjustment.Text = Format((Val(txtAdjustment.Text)), "0.00")
    End Sub

    Private Sub txtAdjustment_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtAdjustment.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtSsspremium_LostFocus(sender As Object, e As System.EventArgs) Handles txtSsspremium.LostFocus
        txtSsspremium.Text = Format((Val(txtSsspremium.Text)), "0.00")
    End Sub

    Private Sub txtSsspremium_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSsspremium.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtSssloan_LostFocus(sender As Object, e As System.EventArgs) Handles txtSssloan.LostFocus
        txtSssloan.Text = Format((Val(txtSssloan.Text)), "0.00")
    End Sub

    Private Sub txtSssloan_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSssloan.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtPhilhealth_LostFocus(sender As Object, e As System.EventArgs) Handles txtPhilhealth.LostFocus
        txtPhilhealth.Text = Format((Val(txtPhilhealth.Text)), "0.00")
    End Sub

    Private Sub txtPhilhealth_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPhilhealth.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtPagibigpremium_LostFocus(sender As Object, e As System.EventArgs) Handles txtPagibigpremium.LostFocus
        txtPagibigpremium.Text = Format((Val(txtPagibigpremium.Text)), "0.00")
    End Sub

    Private Sub txtPagibigpremium_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPagibigpremium.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtPagibigloan_LostFocus(sender As Object, e As System.EventArgs) Handles txtPagibigloan.LostFocus
        txtPagibigloan.Text = Format((Val(txtPagibigloan.Text)), "0.00")
    End Sub

    Private Sub txtPagibigloan_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPagibigloan.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtUndertime_LostFocus(sender As Object, e As System.EventArgs) Handles txtUndertime.LostFocus
        txtUndertime.Text = Format((Val(txtUndertime.Text)), "0.00")
    End Sub

    Private Sub txtUndertime_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUndertime.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtTardiness_LostFocus(sender As Object, e As System.EventArgs) Handles txtTardiness.LostFocus
        txtTardiness.Text = Format((Val(txtTardiness.Text)), "0.00")
    End Sub

    Private Sub txtTardiness_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTardiness.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtMaintenancefee_LostFocus(sender As Object, e As System.EventArgs) Handles txtMaintenancefee.LostFocus
        txtMaintenancefee.Text = Format((Val(txtMaintenancefee.Text)), "0.00")
    End Sub

    Private Sub txtMaintenancefee_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMaintenancefee.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtHmo_LostFocus(sender As Object, e As System.EventArgs) Handles txtHmo.LostFocus
        txtHmo.Text = Format((Val(txtHmo.Text)), "0.00")
    End Sub

    Private Sub txtHmo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtHmo.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtOtherdeductions_LostFocus(sender As Object, e As System.EventArgs) Handles txtOtherdeductions.LostFocus
        txtOtherdeductions.Text = Format((Val(txtOtherdeductions.Text)), "0.00")
    End Sub

    Private Sub txtOtherdeductions_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOtherdeductions.TextChanged
        Call ComputePayroll()
    End Sub

    Private Sub txtEmployeename_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtEmployeename.TextChanged
        Try
            con.Open()
            sql = "SELECT * FROM tbltimekeeping WHERE firstname+' ' + middlename+' '+lastname ='" & txtEmployeename.Text & "' AND date_from = '" & txtdatefrom.Text & "' AND date_to = '" & txtdateto.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                txtId.Text = dr.GetString("id")
                txtLastname.Text = dr.GetString("lastname")
                txtFirstname.Text = dr.GetString("firstname")
                txtMiddlename.Text = dr.GetString("middlename")
                txtReguralhoursworked.Text = dr.GetInt32("regular_hours_worked")
                txtRegotval.Text = dr.GetDecimal("regular_ot")
                txtSunotval.Text = dr.GetInt32("sunday_ot")
                txtSunotexcessval.Text = dr.GetDecimal("sunday_ot_excess")
                txtLegalotval.Text = dr.GetInt32("legal_ot")
                txtLegalotexcessval.Text = dr.GetDecimal("legal_ot_excess")
                txtlegalholidaywpayval.Text = dr.GetInt32("legal_holiday_w_pay")
                txtNightdifferentialval.Text = dr.GetDecimal("night_differential")
                txtNightdifferentialotval.Text = dr.GetDecimal("night_differential_ot")
                txtSundaynightdiffval.Text = dr.GetDecimal("sunday_night_differential")
                txtSundaynightdiffotval.Text = dr.GetDecimal("sunday_night_differential_ot")
                txtLegalnightdiffval.Text = dr.GetDecimal("legal_night_differential")
                txtLegalnightdiffotval.Text = dr.GetDecimal("legal_night_differential_ot")
                txtUndertimeval.Text = dr.GetDecimal("undertime")
                txtTardinessval.Text = dr.GetDecimal("tardiness")
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Dispose()
        End Try

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        frmtimekeeping.Show()
    End Sub

    Private Sub txtdateto_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtdateto.TextChanged

    End Sub

    Private Sub btnPayslip_Click(sender As System.Object, e As System.EventArgs) Handles btnPayslip.Click
        frmpayslip.Show()
    End Sub
End Class