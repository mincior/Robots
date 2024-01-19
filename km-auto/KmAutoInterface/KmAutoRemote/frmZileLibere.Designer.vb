<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmZileLibere
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
        Me.ZileLibereBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KmAutoDataSet = New KmAutoInterface.KmAutoDataSet()
        Me.ZileLibereTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.ZileLibereTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservatiiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZileLibereBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.Data, Me.ObservatiiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ZileLibereBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(800, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'ZileLibereBindingSource
        '
        Me.ZileLibereBindingSource.DataMember = "ZileLibere"
        Me.ZileLibereBindingSource.DataSource = Me.KmAutoDataSet
        '
        'KmAutoDataSet
        '
        Me.KmAutoDataSet.DataSetName = "KmAutoDataSet"
        Me.KmAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ZileLibereTableAdapter
        '
        Me.ZileLibereTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        '
        'ObservatiiDataGridViewTextBoxColumn
        '
        Me.ObservatiiDataGridViewTextBoxColumn.DataPropertyName = "Observatii"
        Me.ObservatiiDataGridViewTextBoxColumn.HeaderText = "Observatii"
        Me.ObservatiiDataGridViewTextBoxColumn.Name = "ObservatiiDataGridViewTextBoxColumn"
        Me.ObservatiiDataGridViewTextBoxColumn.ReadOnly = True
        Me.ObservatiiDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'frmZileLibere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmZileLibere"
        Me.Text = "frmZileLibere"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZileLibereBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KmAutoDataSet As KmAutoDataSet
    Friend WithEvents ZileLibereBindingSource As BindingSource
    Friend WithEvents ZileLibereTableAdapter As KmAutoDataSetTableAdapters.ZileLibereTableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents ObservatiiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
