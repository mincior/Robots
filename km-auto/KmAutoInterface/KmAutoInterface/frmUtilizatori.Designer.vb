<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtilizatori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtilizatori))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LimitaKm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Filiala = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FilialeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KmAutoDataSet = New KmAutoInterface.KmAutoDataSet()
        Me.Activ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Retinere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailConsolight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolosesteDeObiceiMasinaInWeekend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alias_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observatii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdModificare = New System.Windows.Forms.ToolStripButton()
        Me.cmdAdaugare = New System.Windows.Forms.ToolStripButton()
        Me.cmdStergere = New System.Windows.Forms.ToolStripButton()
        Me.cmdIesire = New System.Windows.Forms.ToolStripButton()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ssInfo = New System.Windows.Forms.StatusStrip()
        Me.lbInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbIncarca = New System.Windows.Forms.ToolStripProgressBar()
        Me.cmdStergeCrt = New System.Windows.Forms.Button()
        Me.cmdStergeListaCautare = New System.Windows.Forms.Button()
        Me.cmbCautare = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.FilialeTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.FilialeTableAdapter()
        Me.cmdCautaTot = New System.Windows.Forms.Button()
        Me.cmdRefreshCautareCurenta = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Masina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sofer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Spreadsheet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FilialeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.ssInfo.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nume, Me.Email, Me.LimitaKm, Me.Filiala, Me.Activ, Me.Retinere, Me.EmailConsolight, Me.FolosesteDeObiceiMasinaInWeekend, Me.Alias_, Me.Observatii, Me.Telefon})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 297)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(934, 275)
        Me.DataGridView1.TabIndex = 0
        '
        'Nume
        '
        Me.Nume.HeaderText = "Nume"
        Me.Nume.Name = "Nume"
        Me.Nume.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'LimitaKm
        '
        Me.LimitaKm.HeaderText = "Limita km"
        Me.LimitaKm.Name = "LimitaKm"
        Me.LimitaKm.ReadOnly = True
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
        'Activ
        '
        Me.Activ.HeaderText = "Activ"
        Me.Activ.Name = "Activ"
        Me.Activ.ReadOnly = True
        Me.Activ.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Retinere
        '
        Me.Retinere.HeaderText = "Retinere"
        Me.Retinere.Name = "Retinere"
        Me.Retinere.ReadOnly = True
        Me.Retinere.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'EmailConsolight
        '
        Me.EmailConsolight.HeaderText = "Email Consolight"
        Me.EmailConsolight.Name = "EmailConsolight"
        Me.EmailConsolight.ReadOnly = True
        '
        'FolosesteDeObiceiMasinaInWeekend
        '
        Me.FolosesteDeObiceiMasinaInWeekend.HeaderText = "Foloseste de obicei masina in weekend"
        Me.FolosesteDeObiceiMasinaInWeekend.Name = "FolosesteDeObiceiMasinaInWeekend"
        Me.FolosesteDeObiceiMasinaInWeekend.ReadOnly = True
        Me.FolosesteDeObiceiMasinaInWeekend.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Alias_
        '
        Me.Alias_.HeaderText = "Alias"
        Me.Alias_.Name = "Alias_"
        Me.Alias_.ReadOnly = True
        '
        'Observatii
        '
        Me.Observatii.HeaderText = "Observatii"
        Me.Observatii.Name = "Observatii"
        Me.Observatii.ReadOnly = True
        '
        'Telefon
        '
        Me.Telefon.HeaderText = "Telefon"
        Me.Telefon.Name = "Telefon"
        Me.Telefon.ReadOnly = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
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
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(925, 80)
        Me.ToolStrip1.TabIndex = 17
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
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'ssInfo
        '
        Me.ssInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbInfo, Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1, Me.pbIncarca})
        Me.ssInfo.Location = New System.Drawing.Point(0, 575)
        Me.ssInfo.Name = "ssInfo"
        Me.ssInfo.Size = New System.Drawing.Size(943, 22)
        Me.ssInfo.TabIndex = 223
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
        'cmdStergeCrt
        '
        Me.cmdStergeCrt.Location = New System.Drawing.Point(696, 32)
        Me.cmdStergeCrt.Name = "cmdStergeCrt"
        Me.cmdStergeCrt.Size = New System.Drawing.Size(112, 23)
        Me.cmdStergeCrt.TabIndex = 227
        Me.cmdStergeCrt.Text = "Sterge crt."
        Me.cmdStergeCrt.UseVisualStyleBackColor = True
        '
        'cmdStergeListaCautare
        '
        Me.cmdStergeListaCautare.Location = New System.Drawing.Point(696, 61)
        Me.cmdStergeListaCautare.Name = "cmdStergeListaCautare"
        Me.cmdStergeListaCautare.Size = New System.Drawing.Size(112, 23)
        Me.cmdStergeListaCautare.TabIndex = 226
        Me.cmdStergeListaCautare.Text = "Sterge lista cautare"
        Me.cmdStergeListaCautare.UseVisualStyleBackColor = True
        '
        'cmbCautare
        '
        Me.cmbCautare.FormattingEnabled = True
        Me.cmbCautare.Location = New System.Drawing.Point(449, 34)
        Me.cmbCautare.MaxDropDownItems = 30
        Me.cmbCautare.Name = "cmbCautare"
        Me.cmbCautare.Size = New System.Drawing.Size(169, 21)
        Me.cmbCautare.TabIndex = 225
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(370, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 224
        Me.Label3.Text = "Cautare:"
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
        'cmdCautaTot
        '
        Me.cmdCautaTot.Location = New System.Drawing.Point(622, 33)
        Me.cmdCautaTot.Name = "cmdCautaTot"
        Me.cmdCautaTot.Size = New System.Drawing.Size(34, 23)
        Me.cmdCautaTot.TabIndex = 272
        Me.cmdCautaTot.Text = "Tot"
        Me.cmdCautaTot.UseVisualStyleBackColor = True
        '
        'cmdRefreshCautareCurenta
        '
        Me.cmdRefreshCautareCurenta.Location = New System.Drawing.Point(662, 32)
        Me.cmdRefreshCautareCurenta.Name = "cmdRefreshCautareCurenta"
        Me.cmdRefreshCautareCurenta.Size = New System.Drawing.Size(28, 23)
        Me.cmdRefreshCautareCurenta.TabIndex = 271
        Me.cmdRefreshCautareCurenta.Text = "R"
        Me.cmdRefreshCautareCurenta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 278
        Me.Label1.Text = "Istoric:"
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Masina, Me.Sofer, Me.Data, Me.Spreadsheet})
        Me.DataGridView2.Location = New System.Drawing.Point(109, 92)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(825, 199)
        Me.DataGridView2.TabIndex = 279
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
        'frmUtilizatori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 597)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdCautaTot)
        Me.Controls.Add(Me.cmdRefreshCautareCurenta)
        Me.Controls.Add(Me.cmdStergeCrt)
        Me.Controls.Add(Me.cmdStergeListaCautare)
        Me.Controls.Add(Me.cmbCautare)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ssInfo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmUtilizatori"
        Me.Text = "frmUtilizatori"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FilialeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ssInfo.ResumeLayout(False)
        Me.ssInfo.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdAdaugare As ToolStripButton
    Friend WithEvents cmdStergere As ToolStripButton
    Friend WithEvents cmdModificare As ToolStripButton
    Friend WithEvents cmdIesire As ToolStripButton
    Friend WithEvents Timer2 As Timer
    Friend WithEvents KmAutoDataSet As KmAutoDataSet
    Friend WithEvents FilialeBindingSource As BindingSource
    Friend WithEvents FilialeTableAdapter As KmAutoDataSetTableAdapters.FilialeTableAdapter
    Friend WithEvents ssInfo As StatusStrip
    Friend WithEvents lbInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents pbIncarca As ToolStripProgressBar
    Friend WithEvents cmdStergeCrt As Button
    Friend WithEvents cmdStergeListaCautare As Button
    Friend WithEvents cmbCautare As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Nume As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents LimitaKm As DataGridViewTextBoxColumn
    Friend WithEvents Filiala As DataGridViewComboBoxColumn
    Friend WithEvents Activ As DataGridViewTextBoxColumn
    Friend WithEvents Retinere As DataGridViewTextBoxColumn
    Friend WithEvents EmailConsolight As DataGridViewTextBoxColumn
    Friend WithEvents FolosesteDeObiceiMasinaInWeekend As DataGridViewTextBoxColumn
    Friend WithEvents Alias_ As DataGridViewTextBoxColumn
    Friend WithEvents Observatii As DataGridViewTextBoxColumn
    Friend WithEvents Telefon As DataGridViewTextBoxColumn
    Friend WithEvents cmdCautaTot As Button
    Friend WithEvents cmdRefreshCautareCurenta As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Masina As DataGridViewTextBoxColumn
    Friend WithEvents Sofer As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Spreadsheet As DataGridViewTextBoxColumn
End Class
