<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilizatoriInexistenti
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
        Me.KmAutoDataSet = New KmAutoInterface.KmAutoDataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UtilizatoriInexistentiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UtilizatoriInexistentiTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.UtilizatoriInexistentiTableAdapter()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.NumeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Foaie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilizatoriInexistentiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KmAutoDataSet
        '
        Me.KmAutoDataSet.DataSetName = "KmAutoDataSet"
        Me.KmAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeDataGridViewTextBoxColumn, Me.Foaie})
        Me.DataGridView1.DataSource = Me.UtilizatoriInexistentiBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(788, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'UtilizatoriInexistentiBindingSource
        '
        Me.UtilizatoriInexistentiBindingSource.DataMember = "UtilizatoriInexistenti"
        Me.UtilizatoriInexistentiBindingSource.DataSource = Me.KmAutoDataSet
        '
        'UtilizatoriInexistentiTableAdapter
        '
        Me.UtilizatoriInexistentiTableAdapter.ClearBeforeFill = True
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
        'frmUtilizatoriInexistenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmUtilizatoriInexistenti"
        Me.Text = "frmUtilizatoriInexistenti"
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilizatoriInexistentiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KmAutoDataSet As KmAutoDataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UtilizatoriInexistentiBindingSource As BindingSource
    Friend WithEvents UtilizatoriInexistentiTableAdapter As KmAutoDataSetTableAdapters.UtilizatoriInexistentiTableAdapter
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpreadsheetNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Foaie As DataGridViewTextBoxColumn
End Class
