<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtimelog
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Filename"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(775, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(87, 23)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtFilename
        '
        Me.txtFilename.Location = New System.Drawing.Point(77, 7)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(599, 20)
        Me.txtFilename.TabIndex = 38
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1342, 607)
        Me.DataGridView1.TabIndex = 37
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(682, 7)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(87, 23)
        Me.btnBrowse.TabIndex = 36
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmtimelog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 741)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Name = "frmtimelog"
        Me.Text = "frmtimelog"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
