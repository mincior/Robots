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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdStergeListaCautare = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Km = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KmModificat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PozaDinBord = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusModificat = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Spreadsheet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSiOraCitirii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observatii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asumat = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Observatii1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeteazaPeNormalInteresServiciu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdStergeCrt = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdCreazaWeekendNul = New System.Windows.Forms.Button()
        Me.cmdRefreshCautareCurenta = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdCautaTot = New System.Windows.Forms.Button()
        Me.cmdPregatesteComplementNul = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.KmAutoDataSet = New KmAutoInterface.KmAutoDataSet()
        Me.cmdDeschideSpreadsheet = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdJurnal = New System.Windows.Forms.ToolStripButton()
        Me.cmdMasini = New System.Windows.Forms.ToolStripButton()
        Me.cmdUtilizatori = New System.Windows.Forms.ToolStripButton()
        Me.cmdIesire = New System.Windows.Forms.ToolStripButton()
        Me.cmdFiliale = New System.Windows.Forms.ToolStripButton()
        Me.cmdGreseli = New System.Windows.Forms.ToolStripButton()
        Me.cmdEmail = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDeleteCurrentCell = New System.Windows.Forms.ToolStripButton()
        Me.cmdReincarca = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdForteazaFolosesteDeObiceiMasinaPeNu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdProceseazaLocal = New System.Windows.Forms.ToolStripButton()
        Me.cmdIncarcaToateFoileGoogle = New System.Windows.Forms.ToolStripButton()
        Me.cmdScoateFiltrul = New System.Windows.Forms.ToolStripButton()
        Me.cmdPuneFiltrul = New System.Windows.Forms.ToolStripButton()
        Me.cmdFormatGoogle = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDeschideProcesator = New System.Windows.Forms.ToolStripButton()
        Me.cmdDeschideRaportCurent = New System.Windows.Forms.ToolStripButton()
        Me.cmdIncarcaFoaiaCurenta = New System.Windows.Forms.ToolStripButton()
        Me.cmdOperatiiBulk = New System.Windows.Forms.ToolStripButton()
        Me.cmdDeschideToateFoileGoogle = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Numar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeFiliala = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeUtilizator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VizualizareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasiniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilizatoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilizatoriInexistentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperatiiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReincarcaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StergeStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchimbaStatusInteresServiciuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefaceStatusInteresServiciuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsumaSelectiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StergeAsumareaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForteazaPrimaInregistrareReferintaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForteazaInregistrariSuccesiveReferintaPeNormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DacaUltimaInregistrareReferintaAtunciNormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuCirculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IesireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ssInfo = New System.Windows.Forms.StatusStrip()
        Me.lbInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbIncarca = New System.Windows.Forms.ToolStripProgressBar()
        Me.cmbCautare = New System.Windows.Forms.ComboBox()
        Me.cmbMasini = New System.Windows.Forms.ComboBox()
        Me.MasiniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdAsumaTotIntervalul = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.TextBoxPlus = New System.Windows.Forms.TextBox()
        Me.txtCautareUtilizator = New System.Windows.Forms.TextBox()
        Me.TextBoxObservatii = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdStergeInregistrareaCurenta = New System.Windows.Forms.Button()
        Me.cmbSpreadsheets1 = New System.Windows.Forms.ComboBox()
        Me.SpreadsheetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdAdauga = New System.Windows.Forms.Button()
        Me.textBoxKm = New System.Windows.Forms.TextBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabelDataInterogare = New System.Windows.Forms.Label()
        Me.dtpDataRaportarii = New System.Windows.Forms.DateTimePicker()
        Me.cmbUtilizatori = New System.Windows.Forms.ComboBox()
        Me.UtilizatoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCautareMasina = New System.Windows.Forms.TextBox()
        Me.ITrackActivitateZilnicaPeIntervalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KmAutoDataSet1 = New KmAutoInterface.KmAutoDataSet()
        Me.KmLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KmLogTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.KmLogTableAdapter()
        Me.KmLogBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasiniTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.MasiniTableAdapter()
        Me.UtilizatoriTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.UtilizatoriTableAdapter()
        Me.cmbSpreadsheets = New System.Windows.Forms.ComboBox()
        Me.SpreadsheetsTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.SpreadsheetsTableAdapter()
        Me.ITrackActivitateZilnicaPeIntervalTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.ITrackActivitateZilnicaPeIntervalTableAdapter()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.SursaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoferDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.Timestamp_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Masina_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Utilizator_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Km_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Poza_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSiOraCitiriiKilometrajului_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asumat_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observatii_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KmModificat_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusModificat_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lvSheets = New System.Windows.Forms.ListView()
        Me.Nume = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Filiala = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Activ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SpreadsheetId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmbIntervale = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdToateIntervalele = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ssInfo.SuspendLayout()
        CType(Me.MasiniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SpreadsheetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilizatoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ITrackActivitateZilnicaPeIntervalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmAutoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmLogBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'cmdStergeListaCautare
        '
        Me.cmdStergeListaCautare.Location = New System.Drawing.Point(349, 109)
        Me.cmdStergeListaCautare.Name = "cmdStergeListaCautare"
        Me.cmdStergeListaCautare.Size = New System.Drawing.Size(112, 23)
        Me.cmdStergeListaCautare.TabIndex = 208
        Me.cmdStergeListaCautare.Text = "Sterge lista cautare"
        Me.ToolTip1.SetToolTip(Me.cmdStergeListaCautare, "Sterge toata lista de cautare")
        Me.cmdStergeListaCautare.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 114)
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
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Data, Me.Km, Me.KmModificat, Me.PozaDinBord, Me.Status, Me.StatusModificat, Me.Spreadsheet, Me.DataSiOraCitirii, Me.Observatii, Me.Asumat, Me.Observatii1, Me.SeteazaPeNormalInteresServiciu})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(466, 154)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1277, 315)
        Me.DataGridView1.TabIndex = 209
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
        'Spreadsheet
        '
        Me.Spreadsheet.HeaderText = "Spreadsheet"
        Me.Spreadsheet.Name = "Spreadsheet"
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
        Me.cmdStergeCrt.Location = New System.Drawing.Point(261, 109)
        Me.cmdStergeCrt.Name = "cmdStergeCrt"
        Me.cmdStergeCrt.Size = New System.Drawing.Size(82, 23)
        Me.cmdStergeCrt.TabIndex = 210
        Me.cmdStergeCrt.Text = "Sterge crt."
        Me.ToolTip1.SetToolTip(Me.cmdStergeCrt, "Sterge cautarea curenta")
        Me.cmdStergeCrt.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(296, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 246
        Me.Label4.Text = "Cautare:"
        Me.ToolTip1.SetToolTip(Me.Label4, resources.GetString("Label4.ToolTip"))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 248
        Me.Label5.Text = "Masina"
        Me.ToolTip1.SetToolTip(Me.Label5, resources.GetString("Label5.ToolTip"))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 250
        Me.Label6.Text = "Utilizatorul"
        Me.ToolTip1.SetToolTip(Me.Label6, resources.GetString("Label6.ToolTip"))
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 261
        Me.Label9.Text = "Foaie Google"
        Me.ToolTip1.SetToolTip(Me.Label9, resources.GetString("Label9.ToolTip"))
        '
        'cmdCreazaWeekendNul
        '
        Me.cmdCreazaWeekendNul.Location = New System.Drawing.Point(276, 228)
        Me.cmdCreazaWeekendNul.Name = "cmdCreazaWeekendNul"
        Me.cmdCreazaWeekendNul.Size = New System.Drawing.Size(71, 45)
        Me.cmdCreazaWeekendNul.TabIndex = 266
        Me.cmdCreazaWeekendNul.Text = "Weekend null"
        Me.ToolTip1.SetToolTip(Me.cmdCreazaWeekendNul, "Daca nu exista inregistrari intr-un weekend (interval) va crea doua inregistrari " &
        "fictive una cu referinta si alta cu Normal, index -1")
        Me.cmdCreazaWeekendNul.UseVisualStyleBackColor = True
        '
        'cmdRefreshCautareCurenta
        '
        Me.cmdRefreshCautareCurenta.Location = New System.Drawing.Point(227, 109)
        Me.cmdRefreshCautareCurenta.Name = "cmdRefreshCautareCurenta"
        Me.cmdRefreshCautareCurenta.Size = New System.Drawing.Size(28, 23)
        Me.cmdRefreshCautareCurenta.TabIndex = 247
        Me.cmdRefreshCautareCurenta.Text = "R"
        Me.ToolTip1.SetToolTip(Me.cmdRefreshCautareCurenta, "Reincarca pentru cautarea curenta")
        Me.cmdRefreshCautareCurenta.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(470, 474)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 13)
        Me.Label11.TabIndex = 269
        Me.Label11.Text = "Info Gps,  CAN"
        Me.ToolTip1.SetToolTip(Me.Label11, "Informatii incarcate din raportul Foaie activitate zilnica din ITrack")
        '
        'cmdCautaTot
        '
        Me.cmdCautaTot.Location = New System.Drawing.Point(187, 110)
        Me.cmdCautaTot.Name = "cmdCautaTot"
        Me.cmdCautaTot.Size = New System.Drawing.Size(34, 23)
        Me.cmdCautaTot.TabIndex = 270
        Me.cmdCautaTot.Text = "Tot"
        Me.ToolTip1.SetToolTip(Me.cmdCautaTot, "Reincarca pentru cautarea curenta")
        Me.cmdCautaTot.UseVisualStyleBackColor = True
        '
        'cmdPregatesteComplementNul
        '
        Me.cmdPregatesteComplementNul.Location = New System.Drawing.Point(189, 228)
        Me.cmdPregatesteComplementNul.Name = "cmdPregatesteComplementNul"
        Me.cmdPregatesteComplementNul.Size = New System.Drawing.Size(81, 45)
        Me.cmdPregatesteComplementNul.TabIndex = 269
        Me.cmdPregatesteComplementNul.Text = "Complement nul"
        Me.ToolTip1.SetToolTip(Me.cmdPregatesteComplementNul, "Pregateste inregistrarea complementara pentru intervalul curent. Pune status comp" &
        "lementar (Referinta-Normal si invers) cu acelasi index")
        Me.cmdPregatesteComplementNul.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(463, 583)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 272
        Me.Label13.Text = "Google sheet:"
        Me.ToolTip1.SetToolTip(Me.Label13, "Informatii incarcate din raportul Foaie activitate zilnica din ITrack")
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(470, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(194, 13)
        Me.Label12.TabIndex = 277
        Me.Label12.Text = "Tabelul KmLog din baza de date:"
        Me.ToolTip1.SetToolTip(Me.Label12, "Informatii incarcate din raportul Foaie activitate zilnica din ITrack")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(297, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 273
        Me.Label14.Text = "Adauga la km:"
        Me.ToolTip1.SetToolTip(Me.Label14, resources.GetString("Label14.ToolTip"))
        '
        'KmAutoDataSet
        '
        Me.KmAutoDataSet.DataSetName = "KmAutoDataSet"
        Me.KmAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdDeschideSpreadsheet
        '
        Me.cmdDeschideSpreadsheet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDeschideSpreadsheet.Location = New System.Drawing.Point(1570, 109)
        Me.cmdDeschideSpreadsheet.Name = "cmdDeschideSpreadsheet"
        Me.cmdDeschideSpreadsheet.Size = New System.Drawing.Size(68, 23)
        Me.cmdDeschideSpreadsheet.TabIndex = 232
        Me.cmdDeschideSpreadsheet.Text = "Deschide"
        Me.cmdDeschideSpreadsheet.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdJurnal, Me.cmdMasini, Me.cmdUtilizatori, Me.cmdIesire, Me.cmdFiliale, Me.cmdGreseli, Me.cmdEmail, Me.ToolStripSplitButton2, Me.cmdDeleteCurrentCell, Me.cmdReincarca, Me.ToolStripSeparator1, Me.cmdForteazaFolosesteDeObiceiMasinaPeNu, Me.ToolStripSeparator2, Me.cmdProceseazaLocal, Me.cmdIncarcaToateFoileGoogle, Me.cmdScoateFiltrul, Me.cmdPuneFiltrul, Me.cmdFormatGoogle, Me.ToolStripSeparator5, Me.cmdDeschideProcesator, Me.cmdDeschideRaportCurent, Me.cmdIncarcaFoaiaCurenta, Me.cmdOperatiiBulk})
        Me.ToolStrip1.Location = New System.Drawing.Point(5, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1739, 80)
        Me.ToolStrip1.TabIndex = 234
        '
        'cmdJurnal
        '
        Me.cmdJurnal.Image = CType(resources.GetObject("cmdJurnal.Image"), System.Drawing.Image)
        Me.cmdJurnal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdJurnal.Name = "cmdJurnal"
        Me.cmdJurnal.Size = New System.Drawing.Size(68, 77)
        Me.cmdJurnal.Text = "Jurnal"
        Me.cmdJurnal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdJurnal.ToolTipText = "Un jurnal in loc de notite"
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
        'cmdFiliale
        '
        Me.cmdFiliale.Image = CType(resources.GetObject("cmdFiliale.Image"), System.Drawing.Image)
        Me.cmdFiliale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdFiliale.Name = "cmdFiliale"
        Me.cmdFiliale.Size = New System.Drawing.Size(68, 77)
        Me.cmdFiliale.Text = "Filiale"
        Me.cmdFiliale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdGreseli
        '
        Me.cmdGreseli.Image = CType(resources.GetObject("cmdGreseli.Image"), System.Drawing.Image)
        Me.cmdGreseli.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGreseli.Name = "cmdGreseli"
        Me.cmdGreseli.Size = New System.Drawing.Size(68, 77)
        Me.cmdGreseli.Text = "Greseli"
        Me.cmdGreseli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdEmail
        '
        Me.cmdEmail.Image = CType(resources.GetObject("cmdEmail.Image"), System.Drawing.Image)
        Me.cmdEmail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEmail.Name = "cmdEmail"
        Me.cmdEmail.Size = New System.Drawing.Size(68, 77)
        Me.cmdEmail.Text = "Email"
        Me.cmdEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSplitButton2
        '
        Me.ToolStripSplitButton2.Name = "ToolStripSplitButton2"
        Me.ToolStripSplitButton2.Size = New System.Drawing.Size(6, 80)
        '
        'cmdDeleteCurrentCell
        '
        Me.cmdDeleteCurrentCell.Image = CType(resources.GetObject("cmdDeleteCurrentCell.Image"), System.Drawing.Image)
        Me.cmdDeleteCurrentCell.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDeleteCurrentCell.Name = "cmdDeleteCurrentCell"
        Me.cmdDeleteCurrentCell.Size = New System.Drawing.Size(79, 77)
        Me.cmdDeleteCurrentCell.Text = "Sterge Status"
        Me.cmdDeleteCurrentCell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDeleteCurrentCell.ToolTipText = "Sterge continutul celulei curente, daca aceasta se refera la status (Status modif" &
    "icat)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " . Selectati mai intai celula dorita."
        '
        'cmdReincarca
        '
        Me.cmdReincarca.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdReincarca.Image = CType(resources.GetObject("cmdReincarca.Image"), System.Drawing.Image)
        Me.cmdReincarca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdReincarca.Name = "cmdReincarca"
        Me.cmdReincarca.Size = New System.Drawing.Size(68, 77)
        Me.cmdReincarca.Text = "Reincarca"
        Me.cmdReincarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdReincarca.ToolTipText = "Reincarca pagina cu datele noi"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 80)
        '
        'cmdForteazaFolosesteDeObiceiMasinaPeNu
        '
        Me.cmdForteazaFolosesteDeObiceiMasinaPeNu.Image = CType(resources.GetObject("cmdForteazaFolosesteDeObiceiMasinaPeNu.Image"), System.Drawing.Image)
        Me.cmdForteazaFolosesteDeObiceiMasinaPeNu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdForteazaFolosesteDeObiceiMasinaPeNu.Name = "cmdForteazaFolosesteDeObiceiMasinaPeNu"
        Me.cmdForteazaFolosesteDeObiceiMasinaPeNu.Size = New System.Drawing.Size(68, 77)
        Me.cmdForteazaFolosesteDeObiceiMasinaPeNu.Text = "Nu circula"
        Me.cmdForteazaFolosesteDeObiceiMasinaPeNu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdForteazaFolosesteDeObiceiMasinaPeNu.ToolTipText = "Forteaza campul Asumat pentru soferii declarati ca nu circula de obicei (Folosest" &
    "e de obicei masina in weekend = Nu in tabelul Utilizatori)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 80)
        '
        'cmdProceseazaLocal
        '
        Me.cmdProceseazaLocal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
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
        'cmdIncarcaToateFoileGoogle
        '
        Me.cmdIncarcaToateFoileGoogle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdIncarcaToateFoileGoogle.Image = CType(resources.GetObject("cmdIncarcaToateFoileGoogle.Image"), System.Drawing.Image)
        Me.cmdIncarcaToateFoileGoogle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdIncarcaToateFoileGoogle.Name = "cmdIncarcaToateFoileGoogle"
        Me.cmdIncarcaToateFoileGoogle.Size = New System.Drawing.Size(105, 77)
        Me.cmdIncarcaToateFoileGoogle.Text = "Incarca toate foile"
        Me.cmdIncarcaToateFoileGoogle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdScoateFiltrul
        '
        Me.cmdScoateFiltrul.Image = CType(resources.GetObject("cmdScoateFiltrul.Image"), System.Drawing.Image)
        Me.cmdScoateFiltrul.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdScoateFiltrul.Name = "cmdScoateFiltrul"
        Me.cmdScoateFiltrul.Size = New System.Drawing.Size(77, 77)
        Me.cmdScoateFiltrul.Text = "Scoate filtrul"
        Me.cmdScoateFiltrul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdScoateFiltrul.ToolTipText = "Scoate filtrul din foiaa curenta"
        '
        'cmdPuneFiltrul
        '
        Me.cmdPuneFiltrul.Image = CType(resources.GetObject("cmdPuneFiltrul.Image"), System.Drawing.Image)
        Me.cmdPuneFiltrul.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPuneFiltrul.Name = "cmdPuneFiltrul"
        Me.cmdPuneFiltrul.Size = New System.Drawing.Size(69, 77)
        Me.cmdPuneFiltrul.Text = "Pune filtrul"
        Me.cmdPuneFiltrul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdPuneFiltrul.ToolTipText = "Pune filtrul in foaia curenta"
        '
        'cmdFormatGoogle
        '
        Me.cmdFormatGoogle.Image = CType(resources.GetObject("cmdFormatGoogle.Image"), System.Drawing.Image)
        Me.cmdFormatGoogle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdFormatGoogle.Name = "cmdFormatGoogle"
        Me.cmdFormatGoogle.Size = New System.Drawing.Size(90, 77)
        Me.cmdFormatGoogle.Text = "Format Google"
        Me.cmdFormatGoogle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdFormatGoogle.ToolTipText = "Ia pe rand foile google cu date de km si pune format de data yyyy-MM-dd HH:mm:ss " &
    "pe coloanele Timestamp si Data si ora citirii kilometajului"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 80)
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
        'cmdIncarcaFoaiaCurenta
        '
        Me.cmdIncarcaFoaiaCurenta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdIncarcaFoaiaCurenta.Image = CType(resources.GetObject("cmdIncarcaFoaiaCurenta.Image"), System.Drawing.Image)
        Me.cmdIncarcaFoaiaCurenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdIncarcaFoaiaCurenta.Name = "cmdIncarcaFoaiaCurenta"
        Me.cmdIncarcaFoaiaCurenta.Size = New System.Drawing.Size(121, 77)
        Me.cmdIncarcaFoaiaCurenta.Text = "Incarca foaia curenta"
        Me.cmdIncarcaFoaiaCurenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdOperatiiBulk
        '
        Me.cmdOperatiiBulk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdOperatiiBulk.Image = CType(resources.GetObject("cmdOperatiiBulk.Image"), System.Drawing.Image)
        Me.cmdOperatiiBulk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdOperatiiBulk.Name = "cmdOperatiiBulk"
        Me.cmdOperatiiBulk.Size = New System.Drawing.Size(79, 77)
        Me.cmdOperatiiBulk.Text = "Operatii bulk"
        Me.cmdOperatiiBulk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdOperatiiBulk.ToolTipText = "Adauga in KmLog inregistrari nule sau complementare pentru masinile/utilizatorii " &
    "selectati in intervalele selectate"
        '
        'cmdDeschideToateFoileGoogle
        '
        Me.cmdDeschideToateFoileGoogle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDeschideToateFoileGoogle.Location = New System.Drawing.Point(1644, 109)
        Me.cmdDeschideToateFoileGoogle.Name = "cmdDeschideToateFoileGoogle"
        Me.cmdDeschideToateFoileGoogle.Size = New System.Drawing.Size(99, 23)
        Me.cmdDeschideToateFoileGoogle.TabIndex = 235
        Me.cmdDeschideToateFoileGoogle.Text = "Deschide toate"
        Me.cmdDeschideToateFoileGoogle.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numar, Me.Marca, Me.Model, Me.NumeFiliala, Me.NumeUtilizator})
        Me.DataGridView2.Location = New System.Drawing.Point(12, 138)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(448, 290)
        Me.DataGridView2.TabIndex = 237
        '
        'Numar
        '
        Me.Numar.HeaderText = "Numar"
        Me.Numar.Name = "Numar"
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        '
        'Model
        '
        Me.Model.HeaderText = "Model"
        Me.Model.Name = "Model"
        '
        'NumeFiliala
        '
        Me.NumeFiliala.HeaderText = "Filiala"
        Me.NumeFiliala.Name = "NumeFiliala"
        '
        'NumeUtilizator
        '
        Me.NumeUtilizator.HeaderText = "Nume"
        Me.NumeUtilizator.Name = "NumeUtilizator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(774, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 240
        Me.Label2.Text = "Foi Google"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VizualizareToolStripMenuItem, Me.OperatiiToolStripMenuItem, Me.IesireToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1757, 24)
        Me.MenuStrip1.TabIndex = 241
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VizualizareToolStripMenuItem
        '
        Me.VizualizareToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasiniToolStripMenuItem, Me.UtilizatoriToolStripMenuItem, Me.UtilizatoriInexistentiToolStripMenuItem})
        Me.VizualizareToolStripMenuItem.Name = "VizualizareToolStripMenuItem"
        Me.VizualizareToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.VizualizareToolStripMenuItem.Text = "Vizualizare"
        '
        'MasiniToolStripMenuItem
        '
        Me.MasiniToolStripMenuItem.Name = "MasiniToolStripMenuItem"
        Me.MasiniToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.MasiniToolStripMenuItem.Text = "Masini"
        '
        'UtilizatoriToolStripMenuItem
        '
        Me.UtilizatoriToolStripMenuItem.Name = "UtilizatoriToolStripMenuItem"
        Me.UtilizatoriToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.UtilizatoriToolStripMenuItem.Text = "Utilizatori"
        '
        'UtilizatoriInexistentiToolStripMenuItem
        '
        Me.UtilizatoriInexistentiToolStripMenuItem.Name = "UtilizatoriInexistentiToolStripMenuItem"
        Me.UtilizatoriInexistentiToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.UtilizatoriInexistentiToolStripMenuItem.Text = "Greseli"
        '
        'OperatiiToolStripMenuItem
        '
        Me.OperatiiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmailToolStripMenuItem, Me.ReincarcaToolStripMenuItem, Me.StergeStatusToolStripMenuItem, Me.StatusToolStripMenuItem})
        Me.OperatiiToolStripMenuItem.Name = "OperatiiToolStripMenuItem"
        Me.OperatiiToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OperatiiToolStripMenuItem.Text = "Operatii"
        '
        'EmailToolStripMenuItem
        '
        Me.EmailToolStripMenuItem.Name = "EmailToolStripMenuItem"
        Me.EmailToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.EmailToolStripMenuItem.Text = "Email"
        '
        'ReincarcaToolStripMenuItem
        '
        Me.ReincarcaToolStripMenuItem.Name = "ReincarcaToolStripMenuItem"
        Me.ReincarcaToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ReincarcaToolStripMenuItem.Text = "Reincarca"
        '
        'StergeStatusToolStripMenuItem
        '
        Me.StergeStatusToolStripMenuItem.Name = "StergeStatusToolStripMenuItem"
        Me.StergeStatusToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.StergeStatusToolStripMenuItem.Text = "Sterge status"
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SchimbaStatusInteresServiciuToolStripMenuItem, Me.RefaceStatusInteresServiciuToolStripMenuItem, Me.AsumaSelectiaToolStripMenuItem, Me.StergeAsumareaToolStripMenuItem, Me.ForteazaPrimaInregistrareReferintaToolStripMenuItem, Me.ForteazaInregistrariSuccesiveReferintaPeNormalToolStripMenuItem, Me.DacaUltimaInregistrareReferintaAtunciNormalToolStripMenuItem, Me.NuCirculaToolStripMenuItem})
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.StatusToolStripMenuItem.Text = "Status"
        '
        'SchimbaStatusInteresServiciuToolStripMenuItem
        '
        Me.SchimbaStatusInteresServiciuToolStripMenuItem.Name = "SchimbaStatusInteresServiciuToolStripMenuItem"
        Me.SchimbaStatusInteresServiciuToolStripMenuItem.Size = New System.Drawing.Size(339, 22)
        Me.SchimbaStatusInteresServiciuToolStripMenuItem.Text = "Schimba status interes serviciu"
        '
        'RefaceStatusInteresServiciuToolStripMenuItem
        '
        Me.RefaceStatusInteresServiciuToolStripMenuItem.Name = "RefaceStatusInteresServiciuToolStripMenuItem"
        Me.RefaceStatusInteresServiciuToolStripMenuItem.Size = New System.Drawing.Size(339, 22)
        Me.RefaceStatusInteresServiciuToolStripMenuItem.Text = "Reface status interes serviciu"
        '
        'AsumaSelectiaToolStripMenuItem
        '
        Me.AsumaSelectiaToolStripMenuItem.Name = "AsumaSelectiaToolStripMenuItem"
        Me.AsumaSelectiaToolStripMenuItem.Size = New System.Drawing.Size(339, 22)
        Me.AsumaSelectiaToolStripMenuItem.Text = "Asuma selectia"
        '
        'StergeAsumareaToolStripMenuItem
        '
        Me.StergeAsumareaToolStripMenuItem.Name = "StergeAsumareaToolStripMenuItem"
        Me.StergeAsumareaToolStripMenuItem.Size = New System.Drawing.Size(339, 22)
        Me.StergeAsumareaToolStripMenuItem.Text = "Sterge asumarea"
        '
        'ForteazaPrimaInregistrareReferintaToolStripMenuItem
        '
        Me.ForteazaPrimaInregistrareReferintaToolStripMenuItem.Name = "ForteazaPrimaInregistrareReferintaToolStripMenuItem"
        Me.ForteazaPrimaInregistrareReferintaToolStripMenuItem.Size = New System.Drawing.Size(339, 22)
        Me.ForteazaPrimaInregistrareReferintaToolStripMenuItem.Text = "Forteaza prima inregistrare Referinta"
        '
        'ForteazaInregistrariSuccesiveReferintaPeNormalToolStripMenuItem
        '
        Me.ForteazaInregistrariSuccesiveReferintaPeNormalToolStripMenuItem.Name = "ForteazaInregistrariSuccesiveReferintaPeNormalToolStripMenuItem"
        Me.ForteazaInregistrariSuccesiveReferintaPeNormalToolStripMenuItem.Size = New System.Drawing.Size(339, 22)
        Me.ForteazaInregistrariSuccesiveReferintaPeNormalToolStripMenuItem.Text = "Forteaza inregistrari succesive Referinta pe Normal"
        '
        'DacaUltimaInregistrareReferintaAtunciNormalToolStripMenuItem
        '
        Me.DacaUltimaInregistrareReferintaAtunciNormalToolStripMenuItem.Name = "DacaUltimaInregistrareReferintaAtunciNormalToolStripMenuItem"
        Me.DacaUltimaInregistrareReferintaAtunciNormalToolStripMenuItem.Size = New System.Drawing.Size(339, 22)
        Me.DacaUltimaInregistrareReferintaAtunciNormalToolStripMenuItem.Text = "Daca ultima inregistrare Referinta atunci Normal"
        '
        'NuCirculaToolStripMenuItem
        '
        Me.NuCirculaToolStripMenuItem.Name = "NuCirculaToolStripMenuItem"
        Me.NuCirculaToolStripMenuItem.Size = New System.Drawing.Size(339, 22)
        Me.NuCirculaToolStripMenuItem.Text = "Nu circula"
        '
        'IesireToolStripMenuItem
        '
        Me.IesireToolStripMenuItem.Name = "IesireToolStripMenuItem"
        Me.IesireToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.IesireToolStripMenuItem.Text = "Iesire"
        '
        'ssInfo
        '
        Me.ssInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbInfo, Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1, Me.pbIncarca})
        Me.ssInfo.Location = New System.Drawing.Point(0, 718)
        Me.ssInfo.Name = "ssInfo"
        Me.ssInfo.Size = New System.Drawing.Size(1757, 22)
        Me.ssInfo.TabIndex = 242
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
        'cmbCautare
        '
        Me.cmbCautare.FormattingEnabled = True
        Me.cmbCautare.Location = New System.Drawing.Point(68, 110)
        Me.cmbCautare.MaxDropDownItems = 30
        Me.cmbCautare.Name = "cmbCautare"
        Me.cmbCautare.Size = New System.Drawing.Size(113, 21)
        Me.cmbCautare.TabIndex = 207
        '
        'cmbMasini
        '
        Me.cmbMasini.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MasiniBindingSource, "Id", True))
        Me.cmbMasini.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMasini.FormattingEnabled = True
        Me.cmbMasini.Location = New System.Drawing.Point(123, 69)
        Me.cmbMasini.Name = "cmbMasini"
        Me.cmbMasini.Size = New System.Drawing.Size(123, 21)
        Me.cmbMasini.TabIndex = 248
        '
        'MasiniBindingSource
        '
        Me.MasiniBindingSource.DataMember = "Masini"
        Me.MasiniBindingSource.DataSource = Me.KmAutoDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cmdAsumaTotIntervalul)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmdPlus)
        Me.GroupBox1.Controls.Add(Me.TextBoxPlus)
        Me.GroupBox1.Controls.Add(Me.txtCautareUtilizator)
        Me.GroupBox1.Controls.Add(Me.cmdPregatesteComplementNul)
        Me.GroupBox1.Controls.Add(Me.TextBoxObservatii)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmdCreazaWeekendNul)
        Me.GroupBox1.Controls.Add(Me.cmdStergeInregistrareaCurenta)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbSpreadsheets1)
        Me.GroupBox1.Controls.Add(Me.cmdAdauga)
        Me.GroupBox1.Controls.Add(Me.textBoxKm)
        Me.GroupBox1.Controls.Add(Me.cmbStatus)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LabelDataInterogare)
        Me.GroupBox1.Controls.Add(Me.dtpDataRaportarii)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbUtilizatori)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCautareMasina)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbMasini)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 436)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 279)
        Me.GroupBox1.TabIndex = 245
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adaugare km (inregistrari noi)"
        '
        'cmdAsumaTotIntervalul
        '
        Me.cmdAsumaTotIntervalul.Location = New System.Drawing.Point(116, 228)
        Me.cmdAsumaTotIntervalul.Name = "cmdAsumaTotIntervalul"
        Me.cmdAsumaTotIntervalul.Size = New System.Drawing.Size(67, 45)
        Me.cmdAsumaTotIntervalul.TabIndex = 274
        Me.cmdAsumaTotIntervalul.Text = "Asuma tot intervalul"
        Me.cmdAsumaTotIntervalul.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Location = New System.Drawing.Point(286, 143)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(29, 21)
        Me.cmdPlus.TabIndex = 272
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'TextBoxPlus
        '
        Me.TextBoxPlus.Location = New System.Drawing.Point(323, 144)
        Me.TextBoxPlus.Name = "TextBoxPlus"
        Me.TextBoxPlus.Size = New System.Drawing.Size(125, 20)
        Me.TextBoxPlus.TabIndex = 271
        '
        'txtCautareUtilizator
        '
        Me.txtCautareUtilizator.Location = New System.Drawing.Point(286, 96)
        Me.txtCautareUtilizator.Name = "txtCautareUtilizator"
        Me.txtCautareUtilizator.Size = New System.Drawing.Size(162, 20)
        Me.txtCautareUtilizator.TabIndex = 270
        '
        'TextBoxObservatii
        '
        Me.TextBoxObservatii.Location = New System.Drawing.Point(123, 195)
        Me.TextBoxObservatii.Name = "TextBoxObservatii"
        Me.TextBoxObservatii.Size = New System.Drawing.Size(325, 20)
        Me.TextBoxObservatii.TabIndex = 253
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(30, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 268
        Me.Label10.Text = "Observatii"
        '
        'cmdStergeInregistrareaCurenta
        '
        Me.cmdStergeInregistrareaCurenta.Location = New System.Drawing.Point(353, 228)
        Me.cmdStergeInregistrareaCurenta.Name = "cmdStergeInregistrareaCurenta"
        Me.cmdStergeInregistrareaCurenta.Size = New System.Drawing.Size(85, 45)
        Me.cmdStergeInregistrareaCurenta.TabIndex = 262
        Me.cmdStergeInregistrareaCurenta.Text = "Sterge inregistrarea curenta."
        Me.cmdStergeInregistrareaCurenta.UseVisualStyleBackColor = True
        '
        'cmbSpreadsheets1
        '
        Me.cmbSpreadsheets1.DataSource = Me.SpreadsheetsBindingSource
        Me.cmbSpreadsheets1.DisplayMember = "Nume"
        Me.cmbSpreadsheets1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSpreadsheets1.FormattingEnabled = True
        Me.cmbSpreadsheets1.Location = New System.Drawing.Point(123, 18)
        Me.cmbSpreadsheets1.Name = "cmbSpreadsheets1"
        Me.cmbSpreadsheets1.Size = New System.Drawing.Size(325, 21)
        Me.cmbSpreadsheets1.TabIndex = 247
        Me.cmbSpreadsheets1.ValueMember = "SpreadsheetId"
        '
        'SpreadsheetsBindingSource
        '
        Me.SpreadsheetsBindingSource.DataMember = "Spreadsheets"
        Me.SpreadsheetsBindingSource.DataSource = Me.KmAutoDataSet
        '
        'cmdAdauga
        '
        Me.cmdAdauga.Location = New System.Drawing.Point(10, 228)
        Me.cmdAdauga.Name = "cmdAdauga"
        Me.cmdAdauga.Size = New System.Drawing.Size(67, 45)
        Me.cmdAdauga.TabIndex = 254
        Me.cmdAdauga.Text = "Adauga"
        Me.cmdAdauga.UseVisualStyleBackColor = True
        '
        'textBoxKm
        '
        Me.textBoxKm.Location = New System.Drawing.Point(123, 144)
        Me.textBoxKm.Name = "textBoxKm"
        Me.textBoxKm.Size = New System.Drawing.Size(123, 20)
        Me.textBoxKm.TabIndex = 251
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Referinta", "Normal", "Interes serviciu", "Concediu"})
        Me.cmbStatus.Location = New System.Drawing.Point(123, 169)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(123, 21)
        Me.cmbStatus.TabIndex = 252
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 254
        Me.Label8.Text = "Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 253
        Me.Label7.Text = "Km"
        '
        'LabelDataInterogare
        '
        Me.LabelDataInterogare.AutoSize = True
        Me.LabelDataInterogare.Location = New System.Drawing.Point(30, 119)
        Me.LabelDataInterogare.Name = "LabelDataInterogare"
        Me.LabelDataInterogare.Size = New System.Drawing.Size(53, 13)
        Me.LabelDataInterogare.TabIndex = 251
        Me.LabelDataInterogare.Text = "Data citirii"
        '
        'dtpDataRaportarii
        '
        Me.dtpDataRaportarii.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpDataRaportarii.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataRaportarii.Location = New System.Drawing.Point(123, 118)
        Me.dtpDataRaportarii.Name = "dtpDataRaportarii"
        Me.dtpDataRaportarii.Size = New System.Drawing.Size(123, 20)
        Me.dtpDataRaportarii.TabIndex = 250
        '
        'cmbUtilizatori
        '
        Me.cmbUtilizatori.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UtilizatoriBindingSource, "Id", True))
        Me.cmbUtilizatori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUtilizatori.FormattingEnabled = True
        Me.cmbUtilizatori.Location = New System.Drawing.Point(123, 93)
        Me.cmbUtilizatori.Name = "cmbUtilizatori"
        Me.cmbUtilizatori.Size = New System.Drawing.Size(123, 21)
        Me.cmbUtilizatori.TabIndex = 249
        '
        'UtilizatoriBindingSource
        '
        Me.UtilizatoriBindingSource.DataMember = "Utilizatori"
        Me.UtilizatoriBindingSource.DataSource = Me.KmAutoDataSet
        '
        'txtCautareMasina
        '
        Me.txtCautareMasina.Location = New System.Drawing.Point(286, 70)
        Me.txtCautareMasina.Name = "txtCautareMasina"
        Me.txtCautareMasina.Size = New System.Drawing.Size(162, 20)
        Me.txtCautareMasina.TabIndex = 246
        '
        'ITrackActivitateZilnicaPeIntervalBindingSource
        '
        Me.ITrackActivitateZilnicaPeIntervalBindingSource.DataMember = "ITrackActivitateZilnicaPeInterval"
        Me.ITrackActivitateZilnicaPeIntervalBindingSource.DataSource = Me.KmAutoDataSet
        '
        'KmAutoDataSet1
        '
        Me.KmAutoDataSet1.DataSetName = "KmAutoDataSet"
        Me.KmAutoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KmLogBindingSource
        '
        Me.KmLogBindingSource.DataMember = "KmLog"
        Me.KmLogBindingSource.DataSource = Me.KmAutoDataSet
        '
        'KmLogTableAdapter
        '
        Me.KmLogTableAdapter.ClearBeforeFill = True
        '
        'KmLogBindingSource1
        '
        Me.KmLogBindingSource1.DataMember = "KmLog"
        Me.KmLogBindingSource1.DataSource = Me.KmAutoDataSet
        '
        'MasiniTableAdapter
        '
        Me.MasiniTableAdapter.ClearBeforeFill = True
        '
        'UtilizatoriTableAdapter
        '
        Me.UtilizatoriTableAdapter.ClearBeforeFill = True
        '
        'cmbSpreadsheets
        '
        Me.cmbSpreadsheets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSpreadsheets.DataSource = Me.SpreadsheetsBindingSource
        Me.cmbSpreadsheets.DisplayMember = "Nume"
        Me.cmbSpreadsheets.FormattingEnabled = True
        Me.cmbSpreadsheets.Location = New System.Drawing.Point(856, 110)
        Me.cmbSpreadsheets.MaxDropDownItems = 30
        Me.cmbSpreadsheets.Name = "cmbSpreadsheets"
        Me.cmbSpreadsheets.Size = New System.Drawing.Size(699, 21)
        Me.cmbSpreadsheets.TabIndex = 246
        Me.cmbSpreadsheets.ValueMember = "SpreadsheetId"
        '
        'SpreadsheetsTableAdapter
        '
        Me.SpreadsheetsTableAdapter.ClearBeforeFill = True
        '
        'ITrackActivitateZilnicaPeIntervalTableAdapter
        '
        Me.ITrackActivitateZilnicaPeIntervalTableAdapter.ClearBeforeFill = True
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 300
        '
        'SursaDataGridViewTextBoxColumn
        '
        Me.SursaDataGridViewTextBoxColumn.DataPropertyName = "Sursa"
        Me.SursaDataGridViewTextBoxColumn.HeaderText = "Sursa"
        Me.SursaDataGridViewTextBoxColumn.Name = "SursaDataGridViewTextBoxColumn"
        Me.SursaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "KmGPS"
        Me.DataGridViewTextBoxColumn1.HeaderText = "KmGPS"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SoferDataGridViewTextBoxColumn
        '
        Me.SoferDataGridViewTextBoxColumn.DataPropertyName = "Sofer"
        Me.SoferDataGridViewTextBoxColumn.HeaderText = "Sofer"
        Me.SoferDataGridViewTextBoxColumn.Name = "SoferDataGridViewTextBoxColumn"
        Me.SoferDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumarDataGridViewTextBoxColumn
        '
        Me.NumarDataGridViewTextBoxColumn.DataPropertyName = "Numar"
        Me.NumarDataGridViewTextBoxColumn.HeaderText = "Numar"
        Me.NumarDataGridViewTextBoxColumn.Name = "NumarDataGridViewTextBoxColumn"
        Me.NumarDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataDataGridViewTextBoxColumn, Me.NumarDataGridViewTextBoxColumn, Me.SoferDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.SursaDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.ITrackActivitateZilnicaPeIntervalBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(467, 490)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(1278, 90)
        Me.DataGridView3.TabIndex = 269
        '
        'DataGridView4
        '
        Me.DataGridView4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Timestamp_, Me.Masina_, Me.Utilizator_, Me.Km_, Me.Status_, Me.Poza_, Me.DataSiOraCitiriiKilometrajului_, Me.Asumat_, Me.Observatii_, Me.KmModificat_, Me.StatusModificat_})
        Me.DataGridView4.Location = New System.Drawing.Point(467, 607)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(1278, 102)
        Me.DataGridView4.TabIndex = 276
        '
        'Timestamp_
        '
        Me.Timestamp_.HeaderText = "Timestamp"
        Me.Timestamp_.Name = "Timestamp_"
        '
        'Masina_
        '
        Me.Masina_.HeaderText = "Masina"
        Me.Masina_.Name = "Masina_"
        '
        'Utilizator_
        '
        Me.Utilizator_.HeaderText = "Utilizator"
        Me.Utilizator_.Name = "Utilizator_"
        '
        'Km_
        '
        Me.Km_.HeaderText = "Km"
        Me.Km_.Name = "Km_"
        '
        'Status_
        '
        Me.Status_.HeaderText = "Status"
        Me.Status_.Name = "Status_"
        '
        'Poza_
        '
        Me.Poza_.HeaderText = "Poza"
        Me.Poza_.Name = "Poza_"
        '
        'DataSiOraCitiriiKilometrajului_
        '
        Me.DataSiOraCitiriiKilometrajului_.HeaderText = "Data si ora citirii kilometrajului"
        Me.DataSiOraCitiriiKilometrajului_.Name = "DataSiOraCitiriiKilometrajului_"
        '
        'Asumat_
        '
        Me.Asumat_.HeaderText = "Asumat"
        Me.Asumat_.Name = "Asumat_"
        '
        'Observatii_
        '
        Me.Observatii_.HeaderText = "Observatii"
        Me.Observatii_.Name = "Observatii_"
        '
        'KmModificat_
        '
        Me.KmModificat_.HeaderText = "Km modificat"
        Me.KmModificat_.Name = "KmModificat_"
        '
        'StatusModificat_
        '
        Me.StatusModificat_.HeaderText = "Status modificat"
        Me.StatusModificat_.Name = "StatusModificat_"
        '
        'lvSheets
        '
        Me.lvSheets.CheckBoxes = True
        Me.lvSheets.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nume, Me.Filiala, Me.Activ, Me.SpreadsheetId})
        Me.lvSheets.HideSelection = False
        Me.lvSheets.Location = New System.Drawing.Point(1415, 255)
        Me.lvSheets.MultiSelect = False
        Me.lvSheets.Name = "lvSheets"
        Me.lvSheets.Size = New System.Drawing.Size(164, 101)
        Me.lvSheets.TabIndex = 278
        Me.lvSheets.UseCompatibleStateImageBehavior = False
        Me.lvSheets.View = System.Windows.Forms.View.Details
        Me.lvSheets.Visible = False
        '
        'Nume
        '
        Me.Nume.Text = "Nume"
        '
        'Filiala
        '
        Me.Filiala.Text = "Filiala"
        '
        'Activ
        '
        Me.Activ.Text = "Activ"
        '
        'SpreadsheetId
        '
        Me.SpreadsheetId.Text = "Spreadsheet id"
        Me.SpreadsheetId.Width = 160
        '
        'cmbIntervale
        '
        Me.cmbIntervale.FormattingEnabled = True
        Me.cmbIntervale.Location = New System.Drawing.Point(554, 110)
        Me.cmbIntervale.Name = "cmbIntervale"
        Me.cmbIntervale.Size = New System.Drawing.Size(146, 21)
        Me.cmbIntervale.TabIndex = 238
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(491, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 239
        Me.Label1.Text = "Intervale"
        '
        'cmdToateIntervalele
        '
        Me.cmdToateIntervalele.Location = New System.Drawing.Point(706, 109)
        Me.cmdToateIntervalele.Name = "cmdToateIntervalele"
        Me.cmdToateIntervalele.Size = New System.Drawing.Size(52, 23)
        Me.cmdToateIntervalele.TabIndex = 243
        Me.cmdToateIntervalele.Text = "Toate"
        Me.cmdToateIntervalele.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1079, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 279
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmKmLogView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1757, 740)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lvSheets)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmdCautaTot)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.cmdRefreshCautareCurenta)
        Me.Controls.Add(Me.cmbSpreadsheets)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdToateIntervalele)
        Me.Controls.Add(Me.ssInfo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbIntervale)
        Me.Controls.Add(Me.cmdDeschideToateFoileGoogle)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cmdStergeCrt)
        Me.Controls.Add(Me.cmdDeschideSpreadsheet)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdStergeListaCautare)
        Me.Controls.Add(Me.cmbCautare)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmKmLogView"
        Me.Text = "frmKmLogView"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ssInfo.ResumeLayout(False)
        Me.ssInfo.PerformLayout()
        CType(Me.MasiniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SpreadsheetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilizatoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ITrackActivitateZilnicaPeIntervalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmAutoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmLogBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KmAutoDataSet As KmAutoDataSet
    Friend WithEvents KmLogBindingSource As BindingSource
    Friend WithEvents KmLogTableAdapter As KmAutoDataSetTableAdapters.KmLogTableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cmdStergeListaCautare As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents cmdStergeCrt As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cmdDeschideSpreadsheet As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdMasini As ToolStripButton
    Friend WithEvents cmdUtilizatori As ToolStripButton
    Friend WithEvents cmdIesire As ToolStripButton
    Friend WithEvents cmdGreseli As ToolStripButton
    Friend WithEvents cmdEmail As ToolStripButton
    Friend WithEvents KmLogBindingSource1 As BindingSource
    Friend WithEvents cmdDeschideToateFoileGoogle As Button
    Friend WithEvents cmdDeleteCurrentCell As ToolStripButton
    Friend WithEvents cmdReincarca As ToolStripButton
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VizualizareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasiniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilizatoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilizatoriInexistentiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperatiiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReincarcaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StergeStatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IesireToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SchimbaStatusInteresServiciuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefaceStatusInteresServiciuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsumaSelectiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StergeAsumareaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForteazaPrimaInregistrareReferintaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForteazaInregistrariSuccesiveReferintaPeNormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSplitButton2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ssInfo As StatusStrip
    Friend WithEvents lbInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents pbIncarca As ToolStripProgressBar
    Friend WithEvents DacaUltimaInregistrareReferintaAtunciNormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Numar As DataGridViewTextBoxColumn
    Friend WithEvents Marca As DataGridViewTextBoxColumn
    Friend WithEvents Model As DataGridViewTextBoxColumn
    Friend WithEvents NumeFiliala As DataGridViewTextBoxColumn
    Friend WithEvents NumeUtilizator As DataGridViewTextBoxColumn
    Friend WithEvents cmbCautare As ComboBox
    Friend WithEvents cmbMasini As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbUtilizatori As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCautareMasina As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents textBoxKm As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LabelDataInterogare As Label
    Friend WithEvents dtpDataRaportarii As DateTimePicker
    Friend WithEvents MasiniBindingSource As BindingSource
    Friend WithEvents MasiniTableAdapter As KmAutoDataSetTableAdapters.MasiniTableAdapter
    Friend WithEvents UtilizatoriBindingSource As BindingSource
    Friend WithEvents UtilizatoriTableAdapter As KmAutoDataSetTableAdapters.UtilizatoriTableAdapter
    Friend WithEvents cmdAdauga As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbSpreadsheets1 As ComboBox
    Friend WithEvents cmdStergeInregistrareaCurenta As Button
    Friend WithEvents cmdForteazaFolosesteDeObiceiMasinaPeNu As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents NuCirculaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdFormatGoogle As ToolStripButton
    Friend WithEvents cmbSpreadsheets As ComboBox
    Friend WithEvents SpreadsheetsBindingSource As BindingSource
    Friend WithEvents SpreadsheetsTableAdapter As KmAutoDataSetTableAdapters.SpreadsheetsTableAdapter
    Friend WithEvents cmdCreazaWeekendNul As Button
    Friend WithEvents TextBoxObservatii As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmdRefreshCautareCurenta As Button
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Km As DataGridViewTextBoxColumn
    Friend WithEvents KmModificat As DataGridViewTextBoxColumn
    Friend WithEvents PozaDinBord As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents StatusModificat As DataGridViewComboBoxColumn
    Friend WithEvents Spreadsheet As DataGridViewTextBoxColumn
    Friend WithEvents DataSiOraCitirii As DataGridViewTextBoxColumn
    Friend WithEvents Observatii As DataGridViewTextBoxColumn
    Friend WithEvents Asumat As DataGridViewComboBoxColumn
    Friend WithEvents Observatii1 As DataGridViewTextBoxColumn
    Friend WithEvents SeteazaPeNormalInteresServiciu As DataGridViewTextBoxColumn
    Friend WithEvents MasinaIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KmGpsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents KmBordSfarsitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KmAutoDataSet1 As KmAutoDataSet
    Friend WithEvents ITrackActivitateZilnicaPeIntervalTableAdapter As KmAutoDataSetTableAdapters.ITrackActivitateZilnicaPeIntervalTableAdapter
    Friend WithEvents ITrackActivitateZilnicaPeIntervalBindingSource As BindingSource
    Friend WithEvents Timer4 As Timer
    Friend WithEvents SursaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SoferDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents cmdCautaTot As Button
    Friend WithEvents cmdPregatesteComplementNul As Button
    Friend WithEvents txtCautareUtilizator As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents cmdIncarcaToateFoileGoogle As ToolStripButton
    Friend WithEvents cmdProceseazaLocal As ToolStripButton
    Friend WithEvents lvSheets As ListView
    Friend WithEvents Nume As ColumnHeader
    Friend WithEvents Filiala As ColumnHeader
    Friend WithEvents Activ As ColumnHeader
    Friend WithEvents SpreadsheetId As ColumnHeader
    Friend WithEvents cmdScoateFiltrul As ToolStripButton
    Friend WithEvents cmdPuneFiltrul As ToolStripButton
    Friend WithEvents cmdDeschideProcesator As ToolStripButton
    Friend WithEvents cmdDeschideRaportCurent As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents cmdIncarcaFoaiaCurenta As ToolStripButton
    Friend WithEvents cmdJurnal As ToolStripButton
    Friend WithEvents cmdPlus As Button
    Friend WithEvents TextBoxPlus As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Timestamp_ As DataGridViewTextBoxColumn
    Friend WithEvents Masina_ As DataGridViewTextBoxColumn
    Friend WithEvents Utilizator_ As DataGridViewTextBoxColumn
    Friend WithEvents Km_ As DataGridViewTextBoxColumn
    Friend WithEvents Status_ As DataGridViewTextBoxColumn
    Friend WithEvents Poza_ As DataGridViewTextBoxColumn
    Friend WithEvents DataSiOraCitiriiKilometrajului_ As DataGridViewTextBoxColumn
    Friend WithEvents Asumat_ As DataGridViewTextBoxColumn
    Friend WithEvents Observatii_ As DataGridViewTextBoxColumn
    Friend WithEvents KmModificat_ As DataGridViewTextBoxColumn
    Friend WithEvents StatusModificat_ As DataGridViewTextBoxColumn
    Friend WithEvents cmdAsumaTotIntervalul As Button
    Friend WithEvents cmdOperatiiBulk As ToolStripButton
    Friend WithEvents cmbIntervale As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdToateIntervalele As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdFiliale As ToolStripButton
End Class
