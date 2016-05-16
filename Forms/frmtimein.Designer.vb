<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtimein
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Filename"
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(772, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 23)
        Me.btnSave.TabIndex = 44
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtFilename
        '
        Me.txtFilename.Location = New System.Drawing.Point(74, 12)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(599, 20)
        Me.txtFilename.TabIndex = 43
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1342, 607)
        Me.DataGridView1.TabIndex = 42
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(679, 12)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(87, 23)
        Me.btnBrowse.TabIndex = 41
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Enabled = False
        Me.btnNext.Location = New System.Drawing.Point(1267, 654)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 46
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(1030, 654)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 47
        Me.ProgressBar1.Visible = False
        '
        'Timer1
        '
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(1136, 654)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar2.TabIndex = 48
        Me.ProgressBar2.Visible = False
        '
        'Timer2
        '
        '
        'frmtimein
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Name = "frmtimein"
        Me.Text = "frmtimein"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
