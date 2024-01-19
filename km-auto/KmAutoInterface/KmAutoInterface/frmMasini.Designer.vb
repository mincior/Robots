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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMasini))
        Me.ssInfo = New System.Windows.Forms.StatusStrip()
        Me.lbInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbIncarca = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdModificare = New System.Windows.Forms.ToolStripButton()
        Me.cmdAdaugare = New System.Windows.Forms.ToolStripButton()
        Me.cmdStergere = New System.Windows.Forms.ToolStripButton()
        Me.cmdIesire = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Numar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsumMediu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Filiala = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FilialeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KmAutoDataSet = New KmAutoInterface.KmAutoDataSet()
        Me.Carburant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observatii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.FilialeTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.FilialeTableAdapter()
        Me.cmdStergeCrt = New System.Windows.Forms.Button()
        Me.cmdStergeListaCautare = New System.Windows.Forms.Button()
        Me.cmbCautare = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdCautaTot = New System.Windows.Forms.Button()
        Me.cmdRefreshCautareCurenta = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Masina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sofer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Spreadsheet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ssInfo.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilialeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ssInfo
        '
        Me.ssInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbInfo, Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1, Me.pbIncarca})
        Me.ssInfo.Location = New System.Drawing.Point(0, 697)
        Me.ssInfo.Name = "ssInfo"
        Me.ssInfo.Size = New System.Drawing.Size(1273, 22)
        Me.ssInfo.TabIndex = 226
        Me.ssInfo.Text = "StatusStrip1"
        '
        'lbInfo
        '
        Me.lbInfo.Name = "lbInfo"
        Me.lbInfo.Size = New System.Drawing.Size(69, 17)
        Me.lbInfo.Text = "KmAuto Ok"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 20)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(61, 17)
        Me.ToolStripStatusLabel1.Text = "Incarcare: "
        '
        'pbIncarca
        '
        Me.pbIncarca.Name = "pbIncarca"
        Me.pbIncarca.Size = New System.Drawing.Size(100, 16)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdModificare, Me.cmdAdaugare, Me.cmdStergere, Me.cmdIesire})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1255, 80)
        Me.ToolStrip1.TabIndex = 225
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdModificare
        '
        Me.cmdModificare.Image = CType(resources.GetObject("cmdModificare.Image"), System.Drawing.Image)
        Me.cmdModificare.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdModificare.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdModificare.Name = "cmdModificare"
        Me.cmdModificare.Size = New System.Drawing.Size(68, 77)
        Me.cmdModificare.Text = "Modificare"
        Me.cmdModificare.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdModificare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdModificare.ToolTipText = "Reface setarile predefinite pentru fiecare robot (pentru a evita setari activate " &
    "la depanare sau accidental)"
        '
        'cmdAdaugare
        '
        Me.cmdAdaugare.Image = CType(resources.GetObject("cmdAdaugare.Image"), System.Drawing.Image)
        Me.cmdAdaugare.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdaugare.Name = "cmdAdaugare"
        Me.cmdAdaugare.Size = New System.Drawing.Size(68, 77)
        Me.cmdAdaugare.Text = "Adaugare"
        Me.cmdAdaugare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdStergere
        '
        Me.cmdStergere.Image = CType(resources.GetObject("cmdStergere.Image"), System.Drawing.Image)
        Me.cmdStergere.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdStergere.Name = "cmdStergere"
        Me.cmdStergere.Size = New System.Drawing.Size(68, 77)
        Me.cmdStergere.Text = "Stergere"
        Me.cmdStergere.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdIesire
        '
        Me.cmdIesire.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdIesire.Image = CType(resources.GetObject("cmdIesire.Image"), System.Drawing.Image)
        Me.cmdIesire.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdIesire.Name = "cmdIesire"
        Me.cmdIesire.Size = New System.Drawing.Size(68, 77)
        Me.cmdIesire.Text = "Iesire"
        Me.cmdIesire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numar, Me.Marca, Me.Model, Me.ConsumMediu, Me.Filiala, Me.Carburant, Me.Activ, Me.Observatii})
        Me.DataGridView1.Location = New System.Drawing.Point(634, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(627, 588)
        Me.DataGridView1.TabIndex = 224
        '
        'Numar
        '
        Me.Numar.HeaderText = "Numar"
        Me.Numar.Name = "Numar"
        Me.Numar.ReadOnly = True
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        '
        'Model
        '
        Me.Model.HeaderText = "Model"
        Me.Model.Name = "Model"
        Me.Model.ReadOnly = True
        '
        'ConsumMediu
        '
        Me.ConsumMediu.HeaderText = "Consum mediu"
        Me.ConsumMediu.Name = "ConsumMediu"
        Me.ConsumMediu.ReadOnly = True
        '
        'Filiala
        '
        Me.Filiala.DataSource = Me.FilialeBindingSource
        Me.Filiala.DisplayMember = "Nume"
        Me.Filiala.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Filiala.HeaderText = "Filiala"
        Me.Filiala.Name = "Filiala"
        Me.Filiala.ReadOnly = True
        Me.Filiala.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Filiala.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Filiala.ValueMember = "id"
        '
        'FilialeBindingSource
        '
        Me.FilialeBindingSource.DataMember = "Filiale"
        Me.FilialeBindingSource.DataSource = Me.KmAutoDataSet
        '
        'KmAutoDataSet
        '
        Me.KmAutoDataSet.DataSetName = "KmAutoDataSet"
        Me.KmAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Carburant
        '
        Me.Carburant.HeaderText = "Carburant"
        Me.Carburant.Name = "Carburant"
        Me.Carburant.ReadOnly = True
        '
        'Activ
        '
        Me.Activ.HeaderText = "Activ"
        Me.Activ.Name = "Activ"
        Me.Activ.ReadOnly = True
        Me.Activ.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Observatii
        '
        Me.Observatii.HeaderText = "Observatii"
        Me.Observatii.Name = "Observatii"
        Me.Observatii.ReadOnly = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'FilialeTableAdapter
        '
        Me.FilialeTableAdapter.ClearBeforeFill = True
        '
        'cmdStergeCrt
        '
        Me.cmdStergeCrt.Location = New System.Drawing.Point(578, 25)
        Me.cmdStergeCrt.Name = "cmdStergeCrt"
        Me.cmdStergeCrt.Size = New System.Drawing.Size(112, 23)
        Me.cmdStergeCrt.TabIndex = 231
        Me.cmdStergeCrt.Text = "Sterge crt."
        Me.cmdStergeCrt.UseVisualStyleBackColor = True
        '
        'cmdStergeListaCautare
        '
        Me.cmdStergeListaCautare.Location = New System.Drawing.Point(696, 25)
        Me.cmdStergeListaCautare.Name = "cmdStergeListaCautare"
        Me.cmdStergeListaCautare.Size = New System.Drawing.Size(112, 23)
        Me.cmdStergeListaCautare.TabIndex = 230
        Me.cmdStergeListaCautare.Text = "Sterge lista cautare"
        Me.cmdStergeListaCautare.UseVisualStyleBackColor = True
        '
        'cmbCautare
        '
        Me.cmbCautare.FormattingEnabled = True
        Me.cmbCautare.Location = New System.Drawing.Point(329, 27)
        Me.cmbCautare.MaxDropDownItems = 30
        Me.cmbCautare.Name = "cmbCautare"
        Me.cmbCautare.Size = New System.Drawing.Size(169, 21)
        Me.cmbCautare.TabIndex = 229
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(250, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 228
        Me.Label3.Text = "Cautare:"
        '
        'cmdCautaTot
        '
        Me.cmdCautaTot.Location = New System.Drawing.Point(504, 25)
        Me.cmdCautaTot.Name = "cmdCautaTot"
        Me.cmdCautaTot.Size = New System.Drawing.Size(34, 23)
        Me.cmdCautaTot.TabIndex = 274
        Me.cmdCautaTot.Text = "Tot"
        Me.cmdCautaTot.UseVisualStyleBackColor = True
        '
        'cmdRefreshCautareCurenta
        '
        Me.cmdRefreshCautareCurenta.Location = New System.Drawing.Point(544, 25)
        Me.cmdRefreshCautareCurenta.Name = "cmdRefreshCautareCurenta"
        Me.cmdRefreshCautareCurenta.Size = New System.Drawing.Size(28, 23)
        Me.cmdRefreshCautareCurenta.TabIndex = 273
        Me.cmdRefreshCautareCurenta.Text = "R"
        Me.cmdRefreshCautareCurenta.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Masina, Me.Sofer, Me.Data, Me.Spreadsheet})
        Me.DataGridView2.Location = New System.Drawing.Point(15, 106)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(613, 316)
        Me.DataGridView2.TabIndex = 275
        '
        'Masina
        '
        Me.Masina.HeaderText = "Masina"
        Me.Masina.Name = "Masina"
        '
        'Sofer
        '
        Me.Sofer.HeaderText = "Sofer"
        Me.Sofer.Name = "Sofer"
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        '
        'Spreadsheet
        '
        Me.Spreadsheet.HeaderText = "Spreadsheet"
        Me.Spreadsheet.Name = "Spreadsheet"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 276
        Me.Label1.Text = "Istoric:"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DataGridView3.Location = New System.Drawing.Point(15, 441)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(613, 253)
        Me.DataGridView3.TabIndex = 277
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Numar"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Consum mediu"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataSource = Me.FilialeBindingSource
        Me.DataGridViewComboBoxColumn1.DisplayMember = "Nume"
        Me.DataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewComboBoxColumn1.HeaderText = "Filiala"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.ReadOnly = True
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn1.ValueMember = "id"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Carburant"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Activ"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Observatii"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 425)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 13)
        Me.Label2.TabIndex = 278
        Me.Label2.Text = "Hub Bucuresti si card limitat"
        '
        'frmMasini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 719)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.cmdCautaTot)
        Me.Controls.Add(Me.cmdRefreshCautareCurenta)
        Me.Controls.Add(Me.cmdStergeCrt)
        Me.Controls.Add(Me.cmdStergeListaCautare)
        Me.Controls.Add(Me.cmbCautare)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ssInfo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmMasini"
        Me.Text = "frmMasini"
        Me.ssInfo.ResumeLayout(False)
        Me.ssInfo.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilialeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ssInfo As StatusStrip
    Friend WithEvents lbInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents pbIncarca As ToolStripProgressBar
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdModificare As ToolStripButton
    Friend WithEvents cmdAdaugare As ToolStripButton
    Friend WithEvents cmdStergere As ToolStripButton
    Friend WithEvents cmdIesire As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents KmAutoDataSet As KmAutoDataSet
    Friend WithEvents FilialeBindingSource As BindingSource
    Friend WithEvents FilialeTableAdapter As KmAutoDataSetTableAdapters.FilialeTableAdapter
    Friend WithEvents cmdStergeCrt As Button
    Friend WithEvents cmdStergeListaCautare As Button
    Friend WithEvents cmbCautare As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmdCautaTot As Button
    Friend WithEvents cmdRefreshCautareCurenta As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Masina As DataGridViewTextBoxColumn
    Friend WithEvents Sofer As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Spreadsheet As DataGridViewTextBoxColumn
    Friend WithEvents Numar As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Model As DataGridViewTextBoxColumn
    Friend WithEvents ConsumMediu As DataGridViewTextBoxColumn
    Friend WithEvents Filiala As DataGridViewComboBoxColumn
    Friend WithEvents Carburant As DataGridViewTextBoxColumn
    Friend WithEvents Activ As DataGridViewTextBoxColumn
    Friend WithEvents Observatii As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class
