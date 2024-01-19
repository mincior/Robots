<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasiniInexistente
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MasiniInexistenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KmAutoDataSet = New KmAutoInterface.KmAutoDataSet()
        Me.MasiniInexistenteTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.MasiniInexistenteTableAdapter()
        Me.NumeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Foaie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasiniInexistenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeDataGridViewTextBoxColumn, Me.Foaie})
        Me.DataGridView1.DataSource = Me.MasiniInexistenteBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(800, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'MasiniInexistenteBindingSource
        '
        Me.MasiniInexistenteBindingSource.DataMember = "MasiniInexistente"
        Me.MasiniInexistenteBindingSource.DataSource = Me.KmAutoDataSet
        '
        'KmAutoDataSet
        '
        Me.KmAutoDataSet.DataSetName = "KmAutoDataSet"
        Me.KmAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MasiniInexistenteTableAdapter
        '
        Me.MasiniInexistenteTableAdapter.ClearBeforeFill = True
        '
        'NumeDataGridViewTextBoxColumn
        '
        Me.NumeDataGridViewTextBoxColumn.DataPropertyName = "Nume"
        Me.NumeDataGridViewTextBoxColumn.HeaderText = "Nume"
        Me.NumeDataGridViewTextBoxColumn.Name = "NumeDataGridViewTextBoxColumn"
        Me.NumeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Foaie
        '
        Me.Foaie.DataPropertyName = "Foaie"
        Me.Foaie.HeaderText = "Foaie"
        Me.Foaie.Name = "Foaie"
        Me.Foaie.ReadOnly = True
        '
        'frmMasiniInexistente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmMasiniInexistente"
        Me.Text = "frmMasiniInexistente"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasiniInexistenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KmAutoDataSet As KmAutoDataSet
    Friend WithEvents MasiniInexistenteBindingSource As BindingSource
    Friend WithEvents MasiniInexistenteTableAdapter As KmAutoDataSetTableAdapters.MasiniInexistenteTableAdapter
    Friend WithEvents SpreadsheetNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Foaie As DataGridViewTextBoxColumn
End Class
