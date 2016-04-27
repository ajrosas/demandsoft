<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpayslip
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdateto = New System.Windows.Forms.TextBox()
        Me.txtdatefrom = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lvPayslip = New System.Windows.Forms.ListView()
        Me.colEmployeename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCtpa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSea = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMeal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRegularot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.colSundayot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSundayotexcess = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLegalot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLegalotexcess = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLegalholidaywpay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNightdifferential = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNightdifferentialot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSundaynightdifferential = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSundaynightdifferentialot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLegalnightdifferential = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colLegalnightdifferentialot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colGrosspay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAdjustment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSsspremium = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSssloan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPhilhealth = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPagibigpremium = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPagibigloan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colUndertime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTardiness = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMaintenancefee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colHmo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOtherdeductions = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNetpay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(748, 12)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(713, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Year"
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(132, 11)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtMonth.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(464, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "to"
        '
        'txtdateto
        '
        Me.txtdateto.Location = New System.Drawing.Point(486, 12)
        Me.txtdateto.Name = "txtdateto"
        Me.txtdateto.Size = New System.Drawing.Size(206, 20)
        Me.txtdateto.TabIndex = 51
        '
        'txtdatefrom
        '
        Me.txtdatefrom.Location = New System.Drawing.Point(237, 11)
        Me.txtdatefrom.Name = "txtdatefrom"
        Me.txtdatefrom.Size = New System.Drawing.Size(206, 20)
        Me.txtdatefrom.TabIndex = 48
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(689, 12)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(18, 20)
        Me.DateTimePicker2.TabIndex = 52
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Location = New System.Drawing.Point(10, 11)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(116, 13)
        Me.lbldate.TabIndex = 47
        Me.lbldate.Text = "Payroll for the Month of"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(440, 11)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(18, 20)
        Me.DateTimePicker1.TabIndex = 49
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(865, 11)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 56
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lvPayslip
        '
        Me.lvPayslip.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colEmployeename, Me.colRate, Me.colCtpa, Me.colSea, Me.colMeal, Me.colRegularot, Me.colSundayot, Me.colSundayotexcess, Me.colLegalot, Me.colLegalotexcess, Me.colLegalholidaywpay, Me.colNightdifferential, Me.colNightdifferentialot, Me.colSundaynightdifferential, Me.colSundaynightdifferentialot, Me.colLegalnightdifferential, Me.colLegalnightdifferentialot, Me.colGrosspay, Me.colAdjustment, Me.colSsspremium, Me.colSssloan, Me.colPhilhealth, Me.colPagibigpremium, Me.colPagibigloan, Me.colUndertime, Me.colTardiness, Me.colMaintenancefee, Me.colHmo, Me.colOtherdeductions, Me.colNetpay})
        Me.lvPayslip.FullRowSelect = True
        Me.lvPayslip.GridLines = True
        Me.lvPayslip.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvPayslip.Location = New System.Drawing.Point(13, 47)
        Me.lvPayslip.Name = "lvPayslip"
        Me.lvPayslip.Size = New System.Drawing.Size(1337, 599)
        Me.lvPayslip.TabIndex = 57
        Me.lvPayslip.UseCompatibleStateImageBehavior = False
        Me.lvPayslip.View = System.Windows.Forms.View.Details
        '
        'colEmployeename
        '
        Me.colEmployeename.Text = "Employee Name"
        Me.colEmployeename.Width = 150
        '
        'colRate
        '
        Me.colRate.Text = "Rate"
        Me.colRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colCtpa
        '
        Me.colCtpa.Text = "CTPA"
        Me.colCtpa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colSea
        '
        Me.colSea.Text = "SEA"
        Me.colSea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colMeal
        '
        Me.colMeal.Text = "Meal Allowance"
        Me.colMeal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colRegularot
        '
        Me.colRegularot.Text = "Regular OT"
        Me.colRegularot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1278, 661)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Label1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(162, 661)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Label4"
        '
        'colSundayot
        '
        Me.colSundayot.Text = "Sunday OT"
        Me.colSundayot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colSundayotexcess
        '
        Me.colSundayotexcess.Text = "Sunday OT Excess"
        Me.colSundayotexcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colLegalot
        '
        Me.colLegalot.Text = "Legal OT"
        Me.colLegalot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colLegalotexcess
        '
        Me.colLegalotexcess.Text = "Legal OT Excess"
        Me.colLegalotexcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colLegalholidaywpay
        '
        Me.colLegalholidaywpay.Text = "Legal Holiday with Pay"
        Me.colLegalholidaywpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colNightdifferential
        '
        Me.colNightdifferential.Text = "Night Differential"
        Me.colNightdifferential.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colNightdifferentialot
        '
        Me.colNightdifferentialot.Text = "NIght Differential OT"
        Me.colNightdifferentialot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colSundaynightdifferential
        '
        Me.colSundaynightdifferential.Text = "Sunday Night Differential"
        Me.colSundaynightdifferential.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colSundaynightdifferentialot
        '
        Me.colSundaynightdifferentialot.Text = "Sunday Night Differential OT"
        Me.colSundaynightdifferentialot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colLegalnightdifferential
        '
        Me.colLegalnightdifferential.Text = "Legal Night Differential"
        Me.colLegalnightdifferential.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colLegalnightdifferentialot
        '
        Me.colLegalnightdifferentialot.Text = "Legal Night Differential OT"
        Me.colLegalnightdifferentialot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colGrosspay
        '
        Me.colGrosspay.Text = "Gross Pay"
        Me.colGrosspay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colAdjustment
        '
        Me.colAdjustment.Text = "Adjustment"
        Me.colAdjustment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colSsspremium
        '
        Me.colSsspremium.Text = "SSS Premium"
        Me.colSsspremium.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colSssloan
        '
        Me.colSssloan.Text = "SSS Loan"
        Me.colSssloan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colPhilhealth
        '
        Me.colPhilhealth.Text = "Philhealth"
        Me.colPhilhealth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colPagibigpremium
        '
        Me.colPagibigpremium.Text = "Pagibigpremium"
        Me.colPagibigpremium.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colPagibigloan
        '
        Me.colPagibigloan.Text = "Pagibig Loan"
        Me.colPagibigloan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colUndertime
        '
        Me.colUndertime.Text = "Undertime"
        Me.colUndertime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colTardiness
        '
        Me.colTardiness.Text = "Tardiness"
        Me.colTardiness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colMaintenancefee
        '
        Me.colMaintenancefee.Text = "Maintenance Fee"
        Me.colMaintenancefee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colHmo
        '
        Me.colHmo.Text = "HMO"
        Me.colHmo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colOtherdeductions
        '
        Me.colOtherdeductions.Text = "Other Deductions"
        Me.colOtherdeductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'colNetpay
        '
        Me.colNetpay.Text = "Net Pay"
        Me.colNetpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 661)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Number of Employee's Payroll:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1200, 661)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Total Net Pay:"
        '
        'frmpayslip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvPayslip)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdateto)
        Me.Controls.Add(Me.txtdatefrom)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.lbldate)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "frmpayslip"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMonth As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdateto As System.Windows.Forms.TextBox
    Friend WithEvents txtdatefrom As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lvPayslip As System.Windows.Forms.ListView
    Friend WithEvents colEmployeename As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRate As System.Windows.Forms.ColumnHeader
    Friend WithEvents colCtpa As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSea As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMeal As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents colRegularot As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents colSundayot As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSundayotexcess As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLegalot As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLegalotexcess As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLegalholidaywpay As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNightdifferential As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNightdifferentialot As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSundaynightdifferential As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSundaynightdifferentialot As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLegalnightdifferential As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLegalnightdifferentialot As System.Windows.Forms.ColumnHeader
    Friend WithEvents colGrosspay As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAdjustment As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSsspremium As System.Windows.Forms.ColumnHeader
    Friend WithEvents colSssloan As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPhilhealth As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPagibigpremium As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPagibigloan As System.Windows.Forms.ColumnHeader
    Friend WithEvents colUndertime As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTardiness As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMaintenancefee As System.Windows.Forms.ColumnHeader
    Friend WithEvents colHmo As System.Windows.Forms.ColumnHeader
    Friend WithEvents colOtherdeductions As System.Windows.Forms.ColumnHeader
    Friend WithEvents colNetpay As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
