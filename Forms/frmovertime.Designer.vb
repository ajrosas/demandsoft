<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmovertime
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
        Me.lbldate = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtMiddlename = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtreason = New System.Windows.Forms.TextBox()
        Me.txttotalhours = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtotid = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(12, 9)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(45, 13)
        Me.lbldate.TabIndex = 0
        Me.lbldate.Text = "Label1"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(12, 272)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(29, 20)
        Me.txtId.TabIndex = 284
        Me.txtId.Visible = False
        '
        'txtMiddlename
        '
        Me.txtMiddlename.Enabled = False
        Me.txtMiddlename.Location = New System.Drawing.Point(260, 272)
        Me.txtMiddlename.Name = "txtMiddlename"
        Me.txtMiddlename.Size = New System.Drawing.Size(100, 20)
        Me.txtMiddlename.TabIndex = 283
        Me.txtMiddlename.Visible = False
        '
        'txtFirstname
        '
        Me.txtFirstname.Enabled = False
        Me.txtFirstname.Location = New System.Drawing.Point(155, 272)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstname.TabIndex = 282
        Me.txtFirstname.Visible = False
        '
        'txtLastname
        '
        Me.txtLastname.Enabled = False
        Me.txtLastname.Location = New System.Drawing.Point(49, 272)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(100, 20)
        Me.txtLastname.TabIndex = 281
        Me.txtLastname.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(75, 53)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(85, 20)
        Me.DateTimePicker1.TabIndex = 285
        Me.DateTimePicker1.Value = New Date(2016, 5, 16, 16, 10, 23, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(169, 53)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(85, 20)
        Me.DateTimePicker2.TabIndex = 286
        Me.DateTimePicker2.Value = New Date(2016, 5, 16, 16, 10, 29, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 287
        Me.Label1.Text = "Start of"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 288
        Me.Label2.Text = "End of"
        '
        'txtreason
        '
        Me.txtreason.Location = New System.Drawing.Point(45, 105)
        Me.txtreason.Multiline = True
        Me.txtreason.Name = "txtreason"
        Me.txtreason.Size = New System.Drawing.Size(311, 134)
        Me.txtreason.TabIndex = 289
        '
        'txttotalhours
        '
        Me.txttotalhours.Enabled = False
        Me.txttotalhours.Location = New System.Drawing.Point(260, 53)
        Me.txttotalhours.Name = "txttotalhours"
        Me.txttotalhours.Size = New System.Drawing.Size(100, 20)
        Me.txttotalhours.TabIndex = 290
        Me.txttotalhours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(257, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 291
        Me.Label3.Text = "Total Hours"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(110, 9)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(250, 21)
        Me.ComboBox1.TabIndex = 292
        '
        'txtotid
        '
        Me.txtotid.Enabled = False
        Me.txtotid.Location = New System.Drawing.Point(75, 9)
        Me.txtotid.Name = "txtotid"
        Me.txtotid.Size = New System.Drawing.Size(29, 20)
        Me.txtotid.TabIndex = 293
        Me.txtotid.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(202, 245)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 294
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(283, 245)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 295
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 296
        Me.Label4.Text = "Reason"
        '
        'frmovertime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 276)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtotid)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txttotalhours)
        Me.Controls.Add(Me.txtreason)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtMiddlename)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.lbldate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmovertime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmovertime"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtMiddlename As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtreason As System.Windows.Forms.TextBox
    Friend WithEvents txttotalhours As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtotid As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
