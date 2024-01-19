<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilizatori
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
        Me.UtilizatoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KmAutoDataSet = New KmAutoInterface.KmAutoDataSet()
        Me.UtilizatoriTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.UtilizatoriTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataInrolariiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimitaKmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Filiala = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetinereDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilizatoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NumeDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DataInrolariiDataGridViewTextBoxColumn, Me.LimitaKmDataGridViewTextBoxColumn, Me.Filiala, Me.ActivDataGridViewTextBoxColumn, Me.RetinereDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UtilizatoriBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(800, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'UtilizatoriBindingSource
        '
        Me.UtilizatoriBindingSource.DataMember = "Utilizatori"
        Me.UtilizatoriBindingSource.DataSource = Me.KmAutoDataSet
        '
        'KmAutoDataSet
        '
        Me.KmAutoDataSet.DataSetName = "KmAutoDataSet"
        Me.KmAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UtilizatoriTableAdapter
        '
        Me.UtilizatoriTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'NumeDataGridViewTextBoxColumn
        '
        Me.NumeDataGridViewTextBoxColumn.DataPropertyName = "Nume"
        Me.NumeDataGridViewTextBoxColumn.HeaderText = "Nume"
        Me.NumeDataGridViewTextBoxColumn.Name = "NumeDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'DataInrolariiDataGridViewTextBoxColumn
        '
        Me.DataInrolariiDataGridViewTextBoxColumn.DataPropertyName = "DataInrolarii"
        Me.DataInrolariiDataGridViewTextBoxColumn.HeaderText = "DataInrolarii"
        Me.DataInrolariiDataGridViewTextBoxColumn.Name = "DataInrolariiDataGridViewTextBoxColumn"
        Me.DataInrolariiDataGridViewTextBoxColumn.Visible = False
        '
        'LimitaKmDataGridViewTextBoxColumn
        '
        Me.LimitaKmDataGridViewTextBoxColumn.DataPropertyName = "LimitaKm"
        Me.LimitaKmDataGridViewTextBoxColumn.HeaderText = "LimitaKm"
        Me.LimitaKmDataGridViewTextBoxColumn.Name = "LimitaKmDataGridViewTextBoxColumn"
        '
        'Filiala
        '
        Me.Filiala.HeaderText = "Filiala"
        Me.Filiala.Name = "Filiala"
        '
        'ActivDataGridViewTextBoxColumn
        '
        Me.ActivDataGridViewTextBoxColumn.DataPropertyName = "Activ"
        Me.ActivDataGridViewTextBoxColumn.HeaderText = "Activ"
        Me.ActivDataGridViewTextBoxColumn.Name = "ActivDataGridViewTextBoxColumn"
        '
        'RetinereDataGridViewTextBoxColumn
        '
        Me.RetinereDataGridViewTextBoxColumn.DataPropertyName = "Retinere"
        Me.RetinereDataGridViewTextBoxColumn.HeaderText = "Retinere"
        Me.RetinereDataGridViewTextBoxColumn.Name = "RetinereDataGridViewTextBoxColumn"
        '
        'frmUtilizatori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmUtilizatori"
        Me.Text = "frmUtilizatori"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilizatoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KmAutoDataSet As KmAutoDataSet
    Friend WithEvents UtilizatoriBindingSource As BindingSource
    Friend WithEvents UtilizatoriTableAdapter As KmAutoDataSetTableAdapters.UtilizatoriTableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataInrolariiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LimitaKmDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Filiala As DataGridViewTextBoxColumn
    Friend WithEvents ActivDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RetinereDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
