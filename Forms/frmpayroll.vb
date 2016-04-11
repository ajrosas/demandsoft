Public Class frmpayroll

    Private Sub txtRegot_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRegot.TextChanged


    End Sub

    Private Sub txtRegotval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRegotval.TextChanged
        txtRegot.Text = Me.txtRate.Text / 8 * 1.25 * Val(txtRegotval.Text)
        txtRegot.Text = FormatNumber(Me.txtRegot.Text, 2)
    End Sub

    Private Sub frmpayroll_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
        Call ToDecimal()

    End Sub
    Public Sub ToDecimal()
        txtRate.Text = "310"
        txtRate.Text = FormatNumber(Me.txtRate.Text, 2)

        txtProduction.Text = "0"
        txtProduction.Text = FormatNumber(Me.txtProduction.Text, 2)
        txtSocioecono.Text = "0"
        txtSocioecono.Text = FormatNumber(Me.txtSocioecono.Text, 2)
        txtMeal.Text = "0"
        txtMeal.Text = FormatNumber(Me.txtMeal.Text, 2)

        txtRegot.Text = "0"
        txtRegot.Text = FormatNumber(Me.txtRegot.Text, 2)
        txtSunot.Text = "0"
        txtSunot.Text = FormatNumber(Me.txtSunot.Text, 2)
        txtSunotexcess.Text = "0"
        txtSunotexcess.Text = FormatNumber(Me.txtSunotexcess.Text, 2)
        txtLegalot.Text = "0"
        txtLegalot.Text = FormatNumber(Me.txtLegalot.Text, 2)
        txtLegalotexcess.Text = "0"
        txtLegalotexcess.Text = FormatNumber(Me.txtLegalotexcess.Text, 2)
        txtNightdifferential.Text = "0"
        txtNightdifferential.Text = FormatNumber(Me.txtNightdifferential.Text, 2)
        txtNightdifferentialot.Text = "0"
        txtNightdifferentialot.Text = FormatNumber(Me.txtNightdifferentialot.Text, 2)
        txtSundaynightdiff.Text = "0"
        txtSundaynightdiff.Text = FormatNumber(Me.txtSundaynightdiff.Text, 2)
        txtSundaynightdiffot.Text = "0"
        txtSundaynightdiffot.Text = FormatNumber(Me.txtSundaynightdiff.Text, 2)
        txtLegalnightdiff.Text = "0"
        txtLegalnightdiff.Text = FormatNumber(Me.txtLegalnightdiff.Text, 2)
        txtLegalnightdiffot.Text = "0"
        txtLegalnightdiffot.Text = FormatNumber(Me.txtLegalnightdiffot.Text, 2)
        txtGrosspay.Text = "0"
        txtGrosspay.Text = FormatNumber(Me.txtGrosspay.Text, 2)


        txtAdjustment.Text = "0"
        txtAdjustment.Text = FormatNumber(Me.txtAdjustment.Text, 2)
        txtSsspremium.Text = "0"
        txtSsspremium.Text = FormatNumber(Me.txtSsspremium.Text, 2)
        txtSssloan.Text = "0"
        txtSssloan.Text = FormatNumber(Me.txtSssloan.Text, 2)
        txtPhilhealth.Text = "0"
        txtPhilhealth.Text = FormatNumber(Me.txtPhilhealth.Text, 2)

        txtPagibigpremium.Text = "0"
        txtPagibigpremium.Text = FormatNumber(Me.txtPagibigpremium.Text)
        txtPagibigloan.Text = "0"
        txtPagibigloan.Text = FormatNumber(Me.txtPagibigloan.Text, 2)
        txtUndertime.Text = "0"
        txtUndertime.Text = FormatNumber(Me.txtUndertime.Text, 2)
        txtTardiness.Text = "0"
        txtTardiness.Text = FormatNumber(Me.txtTardiness.Text, 2)
        txtMaintenancefee.Text = "0"
        txtMaintenancefee.Text = FormatNumber(Me.txtMaintenancefee.Text, 2)
        txtHmo.Text = "0"
        txtHmo.Text = FormatNumber(Me.txtHmo.Text, 2)
        txtOtherdeductions.Text = "0"
        txtOtherdeductions.Text = FormatNumber(Me.txtOtherdeductions.Text, 2)
        txtNetpay.Text = "0"
        txtNetpay.Text = FormatNumber(Me.txtNetpay.Text, 2)


    End Sub
   

    Private Sub txtSunotval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSunotval.TextChanged
        txtSunot.Text = Me.txtRate.Text / 8 * 1.3 * Val(txtSunotval.Text)
        txtSunot.Text = FormatNumber(Me.txtSunot.Text, 2)
    End Sub

    Private Sub txtSunotexcessval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSunotexcessval.TextChanged
        txtSunotexcess.Text = Me.txtRate.Text / 8 * 1.69 * Val(txtSunotexcessval.Text)
        txtSunotexcess.Text = FormatNumber(Me.txtSunotexcess.Text, 2)

    End Sub

    Private Sub txtLegalotval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtLegalotval.TextChanged
        txtLegalot.Text = Me.txtRate.Text / 8 * 2 * Val(txtLegalotval.Text)
        txtLegalot.Text = FormatNumber(Me.txtLegalot.Text, 2)
    End Sub

    Private Sub txtNightdifferentialval_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNightdifferentialval.TextChanged
        txtNightdifferential.Text = Me.txtRate.Text / 8 * 10 * Val(txtNightdifferentialval.Text)
        txtNightdifferential.Text = FormatNumber(Me.txtNightdifferential.Text, 2)

    End Sub
End Class