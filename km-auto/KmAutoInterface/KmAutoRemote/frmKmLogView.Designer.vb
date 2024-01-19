<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKmLogView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKmLogView))
        Me.KmLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KmAutoDataSet = New KmAutoInterface.KmAutoDataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.KmLogTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.KmLogTableAdapter()
        Me.cmdStergeListaCautare = New System.Windows.Forms.Button()
        Me.cmbCautare = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Filiala = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Utilizator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Masina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Km = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PozaDinBord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Spreadsheet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSiOraCitirii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdStergeCrt = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.KmLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KmLogBindingSource
        '
        Me.KmLogBindingSource.DataMember = "KmLog"
        Me.KmLogBindingSource.DataSource = Me.KmAutoDataSet
        '
        'KmAutoDataSet
        '
        Me.KmAutoDataSet.DataSetName = "KmAutoDataSet"
        Me.KmAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'KmLogTableAdapter
        '
        Me.KmLogTableAdapter.ClearBeforeFill = True
        '
        'cmdStergeListaCautare
        '
        Me.cmdStergeListaCautare.Location = New System.Drawing.Point(352, 12)
        Me.cmdStergeListaCautare.Name = "cmdStergeListaCautare"
        Me.cmdStergeListaCautare.Size = New System.Drawing.Size(112, 23)
        Me.cmdStergeListaCautare.TabIndex = 208
        Me.cmdStergeListaCautare.Text = "Sterge lista cautare"
        Me.ToolTip1.SetToolTip(Me.cmdStergeListaCautare, "Sterge toata lista de cautare")
        Me.cmdStergeListaCautare.UseVisualStyleBackColor = True
        '
        'cmbCautare
        '
        Me.cmbCautare.FormattingEnabled = True
        Me.cmbCautare.Location = New System.Drawing.Point(89, 12)
        Me.cmbCautare.Name = "cmbCautare"
        Me.cmbCautare.Size = New System.Drawing.Size(169, 21)
        Me.cmbCautare.TabIndex = 207
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 206
        Me.Label3.Text = "Cautare:"
        Me.ToolTip1.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Data, Me.Filiala, Me.Utilizator, Me.Masina, Me.Km, Me.PozaDinBord, Me.Status, Me.Spreadsheet, Me.DataSiOraCitirii})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1140, 514)
        Me.DataGridView1.TabIndex = 209
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        '
        'Filiala
        '
        Me.Filiala.HeaderText = "Filiala"
        Me.Filiala.Name = "Filiala"
        Me.Filiala.ReadOnly = True
        '
        'Utilizator
        '
        Me.Utilizator.HeaderText = "Utilizator"
        Me.Utilizator.Name = "Utilizator"
        Me.Utilizator.ReadOnly = True
        '
        'Masina
        '
        Me.Masina.HeaderText = "Masina"
        Me.Masina.Name = "Masina"
        Me.Masina.ReadOnly = True
        '
        'Km
        '
        Me.Km.HeaderText = "Km"
        Me.Km.Name = "Km"
        Me.Km.ReadOnly = True
        '
        'PozaDinBord
        '
        Me.PozaDinBord.HeaderText = "Poza din bord"
        Me.PozaDinBord.Name = "PozaDinBord"
        Me.PozaDinBord.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'Spreadsheet
        '
        Me.Spreadsheet.HeaderText = "Spreadsheet"
        Me.Spreadsheet.Name = "Spreadsheet"
        Me.Spreadsheet.ReadOnly = True
        '
        'DataSiOraCitirii
        '
        Me.DataSiOraCitirii.HeaderText = "Data si ora citirii"
        Me.DataSiOraCitirii.Name = "DataSiOraCitirii"
        Me.DataSiOraCitirii.ReadOnly = True
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'cmdStergeCrt
        '
        Me.cmdStergeCrt.Location = New System.Drawing.Point(264, 12)
        Me.cmdStergeCrt.Name = "cmdStergeCrt"
        Me.cmdStergeCrt.Size = New System.Drawing.Size(82, 23)
        Me.cmdStergeCrt.TabIndex = 210
        Me.cmdStergeCrt.Text = "Sterge crt."
        Me.ToolTip1.SetToolTip(Me.cmdStergeCrt, "Sterge cautarea curenta")
        Me.cmdStergeCrt.UseVisualStyleBackColor = True
        '
        'frmKmLogView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 565)
        Me.Controls.Add(Me.cmdStergeCrt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdStergeListaCautare)
        Me.Controls.Add(Me.cmbCautare)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmKmLogView"
        Me.Text = "frmKmLogView"
        CType(Me.KmLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KmAutoDataSet As KmAutoDataSet
    Friend WithEvents KmLogBindingSource As BindingSource
    Friend WithEvents KmLogTableAdapter As KmAutoDataSetTableAdapters.KmLogTableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cmdStergeListaCautare As Button
    Friend WithEvents cmbCautare As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Filiala As DataGridViewTextBoxColumn
    Friend WithEvents Utilizator As DataGridViewTextBoxColumn
    Friend WithEvents Masina As DataGridViewTextBoxColumn
    Friend WithEvents Km As DataGridViewTextBoxColumn
    Friend WithEvents PozaDinBord As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Spreadsheet As DataGridViewTextBoxColumn
    Friend WithEvents DataSiOraCitirii As DataGridViewTextBoxColumn
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents cmdStergeCrt As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
