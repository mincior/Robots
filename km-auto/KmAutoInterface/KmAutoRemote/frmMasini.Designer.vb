<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMasini
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataInrolariiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Filiala = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsumMediuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarburantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasiniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KmAutoDataSet = New KmAutoInterface.KmAutoDataSet()
        Me.FilialeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FilialeTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.FilialeTableAdapter()
        Me.MasiniTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.MasiniTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasiniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilialeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NumarDataGridViewTextBoxColumn, Me.DataInrolariiDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.Filiala, Me.ConsumMediuDataGridViewTextBoxColumn, Me.CarburantDataGridViewTextBoxColumn, Me.ActivDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MasiniBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1016, 513)
        Me.DataGridView1.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumarDataGridViewTextBoxColumn
        '
        Me.NumarDataGridViewTextBoxColumn.DataPropertyName = "Numar"
        Me.NumarDataGridViewTextBoxColumn.HeaderText = "Numar"
        Me.NumarDataGridViewTextBoxColumn.Name = "NumarDataGridViewTextBoxColumn"
        Me.NumarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataInrolariiDataGridViewTextBoxColumn
        '
        Me.DataInrolariiDataGridViewTextBoxColumn.DataPropertyName = "DataInrolarii"
        Me.DataInrolariiDataGridViewTextBoxColumn.HeaderText = "DataInrolarii"
        Me.DataInrolariiDataGridViewTextBoxColumn.Name = "DataInrolariiDataGridViewTextBoxColumn"
        Me.DataInrolariiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "Model"
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        Me.ModelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Filiala
        '
        Me.Filiala.HeaderText = "Filiala"
        Me.Filiala.Name = "Filiala"
        Me.Filiala.ReadOnly = True
        '
        'ConsumMediuDataGridViewTextBoxColumn
        '
        Me.ConsumMediuDataGridViewTextBoxColumn.DataPropertyName = "ConsumMediu"
        Me.ConsumMediuDataGridViewTextBoxColumn.HeaderText = "ConsumMediu"
        Me.ConsumMediuDataGridViewTextBoxColumn.Name = "ConsumMediuDataGridViewTextBoxColumn"
        Me.ConsumMediuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CarburantDataGridViewTextBoxColumn
        '
        Me.CarburantDataGridViewTextBoxColumn.DataPropertyName = "Carburant"
        Me.CarburantDataGridViewTextBoxColumn.HeaderText = "Carburant"
        Me.CarburantDataGridViewTextBoxColumn.Name = "CarburantDataGridViewTextBoxColumn"
        Me.CarburantDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActivDataGridViewTextBoxColumn
        '
        Me.ActivDataGridViewTextBoxColumn.DataPropertyName = "Activ"
        Me.ActivDataGridViewTextBoxColumn.HeaderText = "Activ"
        Me.ActivDataGridViewTextBoxColumn.Name = "ActivDataGridViewTextBoxColumn"
        Me.ActivDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MasiniBindingSource
        '
        Me.MasiniBindingSource.DataMember = "Masini"
        Me.MasiniBindingSource.DataSource = Me.KmAutoDataSet
        '
        'KmAutoDataSet
        '
        Me.KmAutoDataSet.DataSetName = "KmAutoDataSet"
        Me.KmAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FilialeBindingSource
        '
        Me.FilialeBindingSource.DataMember = "Filiale"
        Me.FilialeBindingSource.DataSource = Me.KmAutoDataSet
        '
        'FilialeTableAdapter
        '
        Me.FilialeTableAdapter.ClearBeforeFill = True
        '
        'MasiniTableAdapter
        '
        Me.MasiniTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmMasini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 513)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmMasini"
        Me.Text = "frmMasini"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasiniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilialeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KmAutoDataSet As KmAutoDataSet
    Friend WithEvents FilialeBindingSource As BindingSource
    Friend WithEvents FilialeTableAdapter As KmAutoDataSetTableAdapters.FilialeTableAdapter
    Friend WithEvents MasiniBindingSource As BindingSource
    Friend WithEvents MasiniTableAdapter As KmAutoDataSetTableAdapters.MasiniTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataInrolariiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Filiala As DataGridViewTextBoxColumn
    Friend WithEvents ConsumMediuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarburantDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActivDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
End Class
