<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBulk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBulk))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdMasini = New System.Windows.Forms.ToolStripButton()
        Me.cmdUtilizatori = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdIesire = New System.Windows.Forms.ToolStripButton()
        Me.cmdDeschideProcesator = New System.Windows.Forms.ToolStripButton()
        Me.cmdDeschideRaportCurent = New System.Windows.Forms.ToolStripButton()
        Me.cmdExecuta = New System.Windows.Forms.ToolStripButton()
        Me.txtCautareUtilizator = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbSpreadsheets1 = New System.Windows.Forms.ComboBox()
        Me.SpreadsheetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KmAutoDataSet = New KmAutoInterface.KmAutoDataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbUtilizatori = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCautareMasina = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbMasini = New System.Windows.Forms.ComboBox()
        Me.cklIntervale = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ssInfo = New System.Windows.Forms.StatusStrip()
        Me.lbInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbIncarca = New System.Windows.Forms.ToolStripProgressBar()
        Me.SpreadsheetsTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.SpreadsheetsTableAdapter()
        Me.cmdToateIntervalele = New System.Windows.Forms.Button()
        Me.cmbNiciunul = New System.Windows.Forms.Button()
        Me.cmdAdaugare = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdStergere = New System.Windows.Forms.Button()
        Me.cmdStergeTot = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Nume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Intervale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Spreadsheet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpreadsheetId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Succes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Km = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KmModificat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PozaDinBord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusModificat = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSiOraCitirii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observatii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asumat = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Observatii1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeteazaPeNormalInteresServiciu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdIncarcaToateFoileGoogle = New System.Windows.Forms.ToolStripButton()
        Me.cmdProceseazaLocal = New System.Windows.Forms.ToolStripButton()
        Me.lvSheets = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Filiala = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Activ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SpreadsheetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ssInfo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.cmdMasini, Me.cmdUtilizatori, Me.ToolStripSeparator1, Me.cmdIesire, Me.cmdDeschideProcesator, Me.cmdDeschideRaportCurent, Me.cmdExecuta, Me.ToolStripSeparator3, Me.cmdIncarcaToateFoileGoogle, Me.cmdProceseazaLocal})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1099, 80)
        Me.ToolStrip1.TabIndex = 231
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 80)
        '
        'cmdMasini
        '
        Me.cmdMasini.Image = CType(resources.GetObject("cmdMasini.Image"), System.Drawing.Image)
        Me.cmdMasini.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdMasini.Name = "cmdMasini"
        Me.cmdMasini.Size = New System.Drawing.Size(68, 77)
        Me.cmdMasini.Text = "Masini"
        Me.cmdMasini.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdUtilizatori
        '
        Me.cmdUtilizatori.Image = CType(resources.GetObject("cmdUtilizatori.Image"), System.Drawing.Image)
        Me.cmdUtilizatori.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdUtilizatori.Name = "cmdUtilizatori"
        Me.cmdUtilizatori.Size = New System.Drawing.Size(68, 77)
        Me.cmdUtilizatori.Text = "Utilizatori"
        Me.cmdUtilizatori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 80)
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
        'cmdDeschideProcesator
        '
        Me.cmdDeschideProcesator.Image = CType(resources.GetObject("cmdDeschideProcesator.Image"), System.Drawing.Image)
        Me.cmdDeschideProcesator.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDeschideProcesator.Name = "cmdDeschideProcesator"
        Me.cmdDeschideProcesator.Size = New System.Drawing.Size(95, 77)
        Me.cmdDeschideProcesator.Text = "Procesator.xlsm"
        Me.cmdDeschideProcesator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDeschideProcesator.ToolTipText = "Pune filtrul in foaia curenta"
        '
        'cmdDeschideRaportCurent
        '
        Me.cmdDeschideRaportCurent.Image = CType(resources.GetObject("cmdDeschideRaportCurent.Image"), System.Drawing.Image)
        Me.cmdDeschideRaportCurent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDeschideRaportCurent.Name = "cmdDeschideRaportCurent"
        Me.cmdDeschideRaportCurent.Size = New System.Drawing.Size(68, 77)
        Me.cmdDeschideRaportCurent.Text = "Raport"
        Me.cmdDeschideRaportCurent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDeschideRaportCurent.ToolTipText = "Pune filtrul in foaia curenta"
        '
        'cmdExecuta
        '
        Me.cmdExecuta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdExecuta.Image = CType(resources.GetObject("cmdExecuta.Image"), System.Drawing.Image)
        Me.cmdExecuta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExecuta.Name = "cmdExecuta"
        Me.cmdExecuta.Size = New System.Drawing.Size(68, 77)
        Me.cmdExecuta.Text = "Executa"
        Me.cmdExecuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'txtCautareUtilizator
        '
        Me.txtCautareUtilizator.Location = New System.Drawing.Point(274, 144)
        Me.txtCautareUtilizator.Name = "txtCautareUtilizator"
        Me.txtCautareUtilizator.Size = New System.Drawing.Size(162, 20)
        Me.txtCautareUtilizator.TabIndex = 279
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 278
        Me.Label9.Text = "Foaie Google"
        '
        'cmbSpreadsheets1
        '
        Me.cmbSpreadsheets1.DataSource = Me.SpreadsheetsBindingSource
        Me.cmbSpreadsheets1.DisplayMember = "Nume"
        Me.cmbSpreadsheets1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSpreadsheets1.FormattingEnabled = True
        Me.cmbSpreadsheets1.Location = New System.Drawing.Point(111, 170)
        Me.cmbSpreadsheets1.Name = "cmbSpreadsheets1"
        Me.cmbSpreadsheets1.Size = New System.Drawing.Size(325, 21)
        Me.cmbSpreadsheets1.TabIndex = 273
        Me.cmbSpreadsheets1.ValueMember = "SpreadsheetId"
        '
        'SpreadsheetsBindingSource
        '
        Me.SpreadsheetsBindingSource.DataMember = "Spreadsheets"
        Me.SpreadsheetsBindingSource.DataSource = Me.KmAutoDataSet
        '
        'KmAutoDataSet
        '
        Me.KmAutoDataSet.DataSetName = "KmAutoDataSet"
        Me.KmAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 277
        Me.Label6.Text = "Utilizatorul"
        '
        'cmbUtilizatori
        '
        Me.cmbUtilizatori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUtilizatori.FormattingEnabled = True
        Me.cmbUtilizatori.Location = New System.Drawing.Point(111, 141)
        Me.cmbUtilizatori.Name = "cmbUtilizatori"
        Me.cmbUtilizatori.Size = New System.Drawing.Size(123, 21)
        Me.cmbUtilizatori.TabIndex = 276
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 274
        Me.Label5.Text = "Masina"
        '
        'txtCautareMasina
        '
        Me.txtCautareMasina.Location = New System.Drawing.Point(274, 118)
        Me.txtCautareMasina.Name = "txtCautareMasina"
        Me.txtCautareMasina.Size = New System.Drawing.Size(162, 20)
        Me.txtCautareMasina.TabIndex = 271
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(332, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 272
        Me.Label4.Text = "Cautare:"
        '
        'cmbMasini
        '
        Me.cmbMasini.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMasini.FormattingEnabled = True
        Me.cmbMasini.Location = New System.Drawing.Point(111, 117)
        Me.cmbMasini.Name = "cmbMasini"
        Me.cmbMasini.Size = New System.Drawing.Size(123, 21)
        Me.cmbMasini.TabIndex = 275
        '
        'cklIntervale
        '
        Me.cklIntervale.CheckOnClick = True
        Me.cklIntervale.FormattingEnabled = True
        Me.cklIntervale.Location = New System.Drawing.Point(541, 104)
        Me.cklIntervale.Name = "cklIntervale"
        Me.cklIntervale.Size = New System.Drawing.Size(161, 94)
        Me.cklIntervale.TabIndex = 280
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(453, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 281
        Me.Label1.Text = "Intervale"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ssInfo
        '
        Me.ssInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbInfo, Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1, Me.pbIncarca})
        Me.ssInfo.Location = New System.Drawing.Point(0, 705)
        Me.ssInfo.Name = "ssInfo"
        Me.ssInfo.Size = New System.Drawing.Size(1117, 22)
        Me.ssInfo.TabIndex = 282
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
        'SpreadsheetsTableAdapter
        '
        Me.SpreadsheetsTableAdapter.ClearBeforeFill = True
        '
        'cmdToateIntervalele
        '
        Me.cmdToateIntervalele.Location = New System.Drawing.Point(632, 204)
        Me.cmdToateIntervalele.Name = "cmdToateIntervalele"
        Me.cmdToateIntervalele.Size = New System.Drawing.Size(70, 23)
        Me.cmdToateIntervalele.TabIndex = 285
        Me.cmdToateIntervalele.Text = "Toate"
        Me.cmdToateIntervalele.UseVisualStyleBackColor = True
        '
        'cmbNiciunul
        '
        Me.cmbNiciunul.Location = New System.Drawing.Point(541, 204)
        Me.cmbNiciunul.Name = "cmbNiciunul"
        Me.cmbNiciunul.Size = New System.Drawing.Size(73, 23)
        Me.cmbNiciunul.TabIndex = 286
        Me.cmbNiciunul.Text = "Niciunul"
        Me.cmbNiciunul.UseVisualStyleBackColor = True
        '
        'cmdAdaugare
        '
        Me.cmdAdaugare.Location = New System.Drawing.Point(12, 243)
        Me.cmdAdaugare.Name = "cmdAdaugare"
        Me.cmdAdaugare.Size = New System.Drawing.Size(73, 23)
        Me.cmdAdaugare.TabIndex = 287
        Me.cmdAdaugare.Text = "Adaugare"
        Me.ToolTip1.SetToolTip(Me.cmdAdaugare, "Adauga in grid operatia curenta")
        Me.cmdAdaugare.UseVisualStyleBackColor = True
        '
        'cmdStergere
        '
        Me.cmdStergere.Location = New System.Drawing.Point(91, 243)
        Me.cmdStergere.Name = "cmdStergere"
        Me.cmdStergere.Size = New System.Drawing.Size(73, 23)
        Me.cmdStergere.TabIndex = 289
        Me.cmdStergere.Text = "Stergere"
        Me.ToolTip1.SetToolTip(Me.cmdStergere, "Adauga in grid operatia curenta")
        Me.cmdStergere.UseVisualStyleBackColor = True
        '
        'cmdStergeTot
        '
        Me.cmdStergeTot.Location = New System.Drawing.Point(170, 243)
        Me.cmdStergeTot.Name = "cmdStergeTot"
        Me.cmdStergeTot.Size = New System.Drawing.Size(73, 23)
        Me.cmdStergeTot.TabIndex = 290
        Me.cmdStergeTot.Text = "Sterge tot"
        Me.ToolTip1.SetToolTip(Me.cmdStergeTot, "Adauga in grid operatia curenta")
        Me.cmdStergeTot.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nume, Me.Numar, Me.Intervale, Me.Spreadsheet, Me.SpreadsheetId, Me.Succes})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 272)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1097, 199)
        Me.DataGridView1.TabIndex = 288
        '
        'Nume
        '
        Me.Nume.HeaderText = "Nume"
        Me.Nume.Name = "Nume"
        Me.Nume.ReadOnly = True
        '
        'Numar
        '
        Me.Numar.HeaderText = "Numar"
        Me.Numar.Name = "Numar"
        Me.Numar.ReadOnly = True
        '
        'Intervale
        '
        Me.Intervale.HeaderText = "Intervale"
        Me.Intervale.Name = "Intervale"
        Me.Intervale.ReadOnly = True
        '
        'Spreadsheet
        '
        Me.Spreadsheet.HeaderText = "Spreadsheet"
        Me.Spreadsheet.Name = "Spreadsheet"
        Me.Spreadsheet.ReadOnly = True
        '
        'SpreadsheetId
        '
        Me.SpreadsheetId.HeaderText = "Spreadsheet id"
        Me.SpreadsheetId.Name = "SpreadsheetId"
        Me.SpreadsheetId.ReadOnly = True
        '
        'Succes
        '
        Me.Succes.HeaderText = "Succes"
        Me.Succes.Name = "Succes"
        Me.Succes.ReadOnly = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 200
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Data, Me.Km, Me.KmModificat, Me.PozaDinBord, Me.Status, Me.StatusModificat, Me.DataGridViewTextBoxColumn1, Me.DataSiOraCitirii, Me.Observatii, Me.Asumat, Me.Observatii1, Me.SeteazaPeNormalInteresServiciu})
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView2.Location = New System.Drawing.Point(10, 477)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(1097, 225)
        Me.DataGridView2.TabIndex = 291
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        '
        'Km
        '
        Me.Km.HeaderText = "Km"
        Me.Km.Name = "Km"
        '
        'KmModificat
        '
        Me.KmModificat.HeaderText = "Km modificat"
        Me.KmModificat.Name = "KmModificat"
        '
        'PozaDinBord
        '
        Me.PozaDinBord.HeaderText = "Poza din bord"
        Me.PozaDinBord.Name = "PozaDinBord"
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        '
        'StatusModificat
        '
        Me.StatusModificat.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.StatusModificat.HeaderText = "Status modificat"
        Me.StatusModificat.Items.AddRange(New Object() {"Referinta", "Normal", "Interes serviciu", "Concediu"})
        Me.StatusModificat.Name = "StatusModificat"
        Me.StatusModificat.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StatusModificat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Spreadsheet"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataSiOraCitirii
        '
        Me.DataSiOraCitirii.HeaderText = "Data si ora citirii"
        Me.DataSiOraCitirii.Name = "DataSiOraCitirii"
        '
        'Observatii
        '
        Me.Observatii.HeaderText = "Observatii "
        Me.Observatii.Name = "Observatii"
        '
        'Asumat
        '
        Me.Asumat.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Asumat.HeaderText = "Asumat"
        Me.Asumat.Items.AddRange(New Object() {"Da", "Nu"})
        Me.Asumat.Name = "Asumat"
        Me.Asumat.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Asumat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Observatii1
        '
        Me.Observatii1.HeaderText = "Observatii 1"
        Me.Observatii1.Name = "Observatii1"
        '
        'SeteazaPeNormalInteresServiciu
        '
        Me.SeteazaPeNormalInteresServiciu.HeaderText = "Observatii 2"
        Me.SeteazaPeNormalInteresServiciu.Name = "SeteazaPeNormalInteresServiciu"
        '
        'cmdIncarcaToateFoileGoogle
        '
        Me.cmdIncarcaToateFoileGoogle.Image = CType(resources.GetObject("cmdIncarcaToateFoileGoogle.Image"), System.Drawing.Image)
        Me.cmdIncarcaToateFoileGoogle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdIncarcaToateFoileGoogle.Name = "cmdIncarcaToateFoileGoogle"
        Me.cmdIncarcaToateFoileGoogle.Size = New System.Drawing.Size(105, 77)
        Me.cmdIncarcaToateFoileGoogle.Text = "Incarca toate foile"
        Me.cmdIncarcaToateFoileGoogle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdProceseazaLocal
        '
        Me.cmdProceseazaLocal.Image = CType(resources.GetObject("cmdProceseazaLocal.Image"), System.Drawing.Image)
        Me.cmdProceseazaLocal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdProceseazaLocal.Name = "cmdProceseazaLocal"
        Me.cmdProceseazaLocal.Size = New System.Drawing.Size(97, 77)
        Me.cmdProceseazaLocal.Text = "Proceseaza local"
        Me.cmdProceseazaLocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdProceseazaLocal.ToolTipText = "Ruleaza Procesator.xlsm daca acesta exista pe acest calculator. Spre deosebire de" &
    " Ruleaza VBA sau Ruleaza Robotul unde se executa pe server atat procesator.xlsm " &
    "cat si robotul UIPath."
        '
        'lvSheets
        '
        Me.lvSheets.CheckBoxes = True
        Me.lvSheets.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.Filiala, Me.Activ, Me.ColumnHeader2})
        Me.lvSheets.HideSelection = False
        Me.lvSheets.Location = New System.Drawing.Point(902, 220)
        Me.lvSheets.MultiSelect = False
        Me.lvSheets.Name = "lvSheets"
        Me.lvSheets.Size = New System.Drawing.Size(164, 101)
        Me.lvSheets.TabIndex = 292
        Me.lvSheets.UseCompatibleStateImageBehavior = False
        Me.lvSheets.View = System.Windows.Forms.View.Details
        Me.lvSheets.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nume"
        '
        'Filiala
        '
        Me.Filiala.Text = "Filiala"
        '
        'Activ
        '
        Me.Activ.Text = "Activ"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Spreadsheet id"
        Me.ColumnHeader2.Width = 160
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 80)
        '
        'frmBulk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 727)
        Me.Controls.Add(Me.lvSheets)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.cmdStergeTot)
        Me.Controls.Add(Me.cmdStergere)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdAdaugare)
        Me.Controls.Add(Me.cmbNiciunul)
        Me.Controls.Add(Me.cmdToateIntervalele)
        Me.Controls.Add(Me.ssInfo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cklIntervale)
        Me.Controls.Add(Me.txtCautareUtilizator)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbSpreadsheets1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbUtilizatori)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCautareMasina)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbMasini)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmBulk"
        Me.Text = "frmBulk"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.SpreadsheetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ssInfo.ResumeLayout(False)
        Me.ssInfo.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmdMasini As ToolStripButton
    Friend WithEvents cmdUtilizatori As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdIesire As ToolStripButton
    Friend WithEvents cmdDeschideProcesator As ToolStripButton
    Friend WithEvents cmdDeschideRaportCurent As ToolStripButton
    Friend WithEvents txtCautareUtilizator As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbSpreadsheets1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbUtilizatori As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCautareMasina As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbMasini As ComboBox
    Friend WithEvents cklIntervale As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ssInfo As StatusStrip
    Friend WithEvents lbInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents pbIncarca As ToolStripProgressBar
    Friend WithEvents KmAutoDataSet As KmAutoDataSet
    Friend WithEvents SpreadsheetsBindingSource As BindingSource
    Friend WithEvents SpreadsheetsTableAdapter As KmAutoDataSetTableAdapters.SpreadsheetsTableAdapter
    Friend WithEvents cmdToateIntervalele As Button
    Friend WithEvents cmbNiciunul As Button
    Friend WithEvents cmdExecuta As ToolStripButton
    Friend WithEvents cmdAdaugare As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmdStergere As Button
    Friend WithEvents cmdStergeTot As Button
    Friend WithEvents Nume As DataGridViewTextBoxColumn
    Friend WithEvents Numar As DataGridViewTextBoxColumn
    Friend WithEvents Intervale As DataGridViewTextBoxColumn
    Friend WithEvents Spreadsheet As DataGridViewTextBoxColumn
    Friend WithEvents SpreadsheetId As DataGridViewTextBoxColumn
    Friend WithEvents Succes As DataGridViewTextBoxColumn
    Friend WithEvents Timer2 As Timer
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Km As DataGridViewTextBoxColumn
    Friend WithEvents KmModificat As DataGridViewTextBoxColumn
    Friend WithEvents PozaDinBord As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents StatusModificat As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataSiOraCitirii As DataGridViewTextBoxColumn
    Friend WithEvents Observatii As DataGridViewTextBoxColumn
    Friend WithEvents Asumat As DataGridViewComboBoxColumn
    Friend WithEvents Observatii1 As DataGridViewTextBoxColumn
    Friend WithEvents SeteazaPeNormalInteresServiciu As DataGridViewTextBoxColumn
    Friend WithEvents cmdProceseazaLocal As ToolStripButton
    Friend WithEvents cmdIncarcaToateFoileGoogle As ToolStripButton
    Friend WithEvents lvSheets As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Filiala As ColumnHeader
    Friend WithEvents Activ As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
End Class
