<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim EmailMeLabel As System.Windows.Forms.Label
        Dim EmailToLabel As System.Windows.Forms.Label
        Dim NumarLuniActualizateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.LabelDataInterogare = New System.Windows.Forms.Label()
        Me.EmailMeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailToTextBox = New System.Windows.Forms.TextBox()
        Me.EmailSendCheckBox = New System.Windows.Forms.CheckBox()
        Me.ExtrageRapExcelDinBICheckBox = New System.Windows.Forms.CheckBox()
        Me.NumarLuniActualizateTextBox = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ImpartePeFilialeCheckBox = New System.Windows.Forms.CheckBox()
        Me.ImpartePeAgentiCheckBox = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ssInfo = New System.Windows.Forms.StatusStrip()
        Me.lbInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbIncarca = New System.Windows.Forms.ToolStripProgressBar()
        Me.txtTimer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.RobotsDataSet = New KmAutoInterface.RobotsDataSet()
        Me.ConfigTableAdapter = New KmAutoInterface.RobotsDataSetTableAdapters.ConfigTableAdapter()
        Me.TableAdapterManager = New KmAutoInterface.RobotsDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VizualizareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasiniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilizatoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilizatoriInexistentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasiniInexistenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CombustibiliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZileLibereToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleFormsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleSheetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperatiiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreseliUtilizatoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailUtilizatoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperatiiExterneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncarcaKmLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProceseazaLocalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RuleazaVBAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RuleazaRobotulToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdJurnal = New System.Windows.Forms.ToolStripButton()
        Me.cmdIntervale = New System.Windows.Forms.ToolStripButton()
        Me.cmdKm = New System.Windows.Forms.ToolStripButton()
        Me.cmdGreseli = New System.Windows.Forms.ToolStripButton()
        Me.cmdEmail = New System.Windows.Forms.ToolStripButton()
        Me.cmdDateExterne = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdMasini = New System.Windows.Forms.ToolStripButton()
        Me.cmdUtilizatori = New System.Windows.Forms.ToolStripButton()
        Me.Combustibili = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdIesire = New System.Windows.Forms.ToolStripButton()
        Me.cmdRenuntaLaRulare = New System.Windows.Forms.ToolStripButton()
        Me.cmdRuleazaRobotul = New System.Windows.Forms.ToolStripButton()
        Me.cmdFiliale = New System.Windows.Forms.ToolStripButton()
        Me.cmdRuleazaVBA = New System.Windows.Forms.ToolStripButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.KmAutoDataSet = New KmAutoInterface.KmAutoDataSet()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NumeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpreadsheetNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasiniInexistenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbSpreadsheets = New System.Windows.Forms.ComboBox()
        Me.Spreadsheets1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmdDeschideToateFoileGoogle = New System.Windows.Forms.Button()
        Me.cmdDeschideSpreadsheet = New System.Windows.Forms.Button()
        Me.CombustibiliTableAdapter1 = New KmAutoInterface.KmAutoDataSetTableAdapters.CombustibiliTableAdapter()
        Me.GreseliLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GreseliLogTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.GreseliLogTableAdapter()
        Me.Spreadsheets1TableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.Spreadsheets1TableAdapter()
        Me.cmdSchimbaDataRaportarii = New System.Windows.Forms.Button()
        Me.lblDataRaportarii = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.NumeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UtilizatoriInPlusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KmAutoDataSet1 = New KmAutoInterface.KmAutoDataSet()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.NumarDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observatii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasiniInPlusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpreadsheetNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UtilizatoriInexistentiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UtilizatoriInexistentiTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.UtilizatoriInexistentiTableAdapter()
        Me.MasiniInexistenteTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.MasiniInexistenteTableAdapter()
        Me.MasiniInPlusTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.MasiniInPlusTableAdapter()
        Me.UtilizatoriInPlusTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.UtilizatoriInPlusTableAdapter()
        Me.ckBoxDeschideKm = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lvSheets = New System.Windows.Forms.ListView()
        Me.Nume = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Filiala = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Activ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SpreadsheetId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.cmdGoogleForms = New System.Windows.Forms.ToolStripButton()
        Me.cmdGoogleSheets = New System.Windows.Forms.ToolStripButton()
        Me.cmdIesire1 = New System.Windows.Forms.ToolStripButton()
        Me.cmdProceseazaLocal = New System.Windows.Forms.ToolStripButton()
        Me.cmdIncarcaToateFoileGoogle = New System.Windows.Forms.ToolStripButton()
        Me.cmdDeschideProcesator = New System.Windows.Forms.ToolStripButton()
        Me.cmdDeschideRaportCurent = New System.Windows.Forms.ToolStripButton()
        Me.cmdOperatiiBulk = New System.Windows.Forms.ToolStripButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        EmailMeLabel = New System.Windows.Forms.Label()
        EmailToLabel = New System.Windows.Forms.Label()
        NumarLuniActualizateLabel = New System.Windows.Forms.Label()
        Me.ssInfo.SuspendLayout()
        CType(Me.RobotsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasiniInexistenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Spreadsheets1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreseliLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilizatoriInPlusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmAutoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasiniInPlusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilizatoriInexistentiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmailMeLabel
        '
        EmailMeLabel.AutoSize = True
        EmailMeLabel.Location = New System.Drawing.Point(23, 321)
        EmailMeLabel.Name = "EmailMeLabel"
        EmailMeLabel.Size = New System.Drawing.Size(53, 13)
        EmailMeLabel.TabIndex = 63
        EmailMeLabel.Text = "Email Me:"
        '
        'EmailToLabel
        '
        EmailToLabel.AutoSize = True
        EmailToLabel.Location = New System.Drawing.Point(23, 295)
        EmailToLabel.Name = "EmailToLabel"
        EmailToLabel.Size = New System.Drawing.Size(51, 13)
        EmailToLabel.TabIndex = 69
        EmailToLabel.Text = "Email To:"
        '
        'NumarLuniActualizateLabel
        '
        NumarLuniActualizateLabel.Location = New System.Drawing.Point(22, 378)
        NumarLuniActualizateLabel.Name = "NumarLuniActualizateLabel"
        NumarLuniActualizateLabel.Size = New System.Drawing.Size(253, 21)
        NumarLuniActualizateLabel.TabIndex = 129
        NumarLuniActualizateLabel.Text = "Numar implicit de km acceptati gratuit pe saptamana"
        '
        'LabelDataInterogare
        '
        Me.LabelDataInterogare.AutoSize = True
        Me.LabelDataInterogare.Location = New System.Drawing.Point(20, 346)
        Me.LabelDataInterogare.Name = "LabelDataInterogare"
        Me.LabelDataInterogare.Size = New System.Drawing.Size(73, 13)
        Me.LabelDataInterogare.TabIndex = 38
        Me.LabelDataInterogare.Text = "Data raportarii"
        '
        'EmailMeTextBox
        '
        Me.EmailMeTextBox.Location = New System.Drawing.Point(80, 318)
        Me.EmailMeTextBox.Name = "EmailMeTextBox"
        Me.EmailMeTextBox.ReadOnly = True
        Me.EmailMeTextBox.Size = New System.Drawing.Size(304, 20)
        Me.EmailMeTextBox.TabIndex = 64
        '
        'EmailToTextBox
        '
        Me.EmailToTextBox.Location = New System.Drawing.Point(80, 292)
        Me.EmailToTextBox.Name = "EmailToTextBox"
        Me.EmailToTextBox.ReadOnly = True
        Me.EmailToTextBox.Size = New System.Drawing.Size(304, 20)
        Me.EmailToTextBox.TabIndex = 70
        '
        'EmailSendCheckBox
        '
        Me.EmailSendCheckBox.Enabled = False
        Me.EmailSendCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailSendCheckBox.Location = New System.Drawing.Point(25, 219)
        Me.EmailSendCheckBox.Name = "EmailSendCheckBox"
        Me.EmailSendCheckBox.Size = New System.Drawing.Size(153, 24)
        Me.EmailSendCheckBox.TabIndex = 76
        Me.EmailSendCheckBox.Text = "Trimite emailuri"
        Me.EmailSendCheckBox.UseVisualStyleBackColor = True
        '
        'ExtrageRapExcelDinBICheckBox
        '
        Me.ExtrageRapExcelDinBICheckBox.Enabled = False
        Me.ExtrageRapExcelDinBICheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtrageRapExcelDinBICheckBox.Location = New System.Drawing.Point(25, 249)
        Me.ExtrageRapExcelDinBICheckBox.Name = "ExtrageRapExcelDinBICheckBox"
        Me.ExtrageRapExcelDinBICheckBox.Size = New System.Drawing.Size(332, 24)
        Me.ExtrageRapExcelDinBICheckBox.TabIndex = 127
        Me.ExtrageRapExcelDinBICheckBox.Text = "Extrage km din spreadsheet-urile Google"
        Me.ExtrageRapExcelDinBICheckBox.UseVisualStyleBackColor = True
        '
        'NumarLuniActualizateTextBox
        '
        Me.NumarLuniActualizateTextBox.Location = New System.Drawing.Point(288, 378)
        Me.NumarLuniActualizateTextBox.Name = "NumarLuniActualizateTextBox"
        Me.NumarLuniActualizateTextBox.ReadOnly = True
        Me.NumarLuniActualizateTextBox.Size = New System.Drawing.Size(51, 20)
        Me.NumarLuniActualizateTextBox.TabIndex = 130
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 400
        '
        'ImpartePeFilialeCheckBox
        '
        Me.ImpartePeFilialeCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImpartePeFilialeCheckBox.ForeColor = System.Drawing.Color.Blue
        Me.ImpartePeFilialeCheckBox.Location = New System.Drawing.Point(365, 378)
        Me.ImpartePeFilialeCheckBox.Name = "ImpartePeFilialeCheckBox"
        Me.ImpartePeFilialeCheckBox.Size = New System.Drawing.Size(208, 24)
        Me.ImpartePeFilialeCheckBox.TabIndex = 203
        Me.ImpartePeFilialeCheckBox.Text = "Trimite emailuri la filiale"
        Me.ToolTip1.SetToolTip(Me.ImpartePeFilialeCheckBox, "Inainte de a rula robotul activati aceasta optiune daca doriti trimiterea la fili" &
        "ale a fisierelor personalizate.")
        Me.ImpartePeFilialeCheckBox.UseVisualStyleBackColor = True
        '
        'ImpartePeAgentiCheckBox
        '
        Me.ImpartePeAgentiCheckBox.Enabled = False
        Me.ImpartePeAgentiCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImpartePeAgentiCheckBox.ForeColor = System.Drawing.Color.SeaGreen
        Me.ImpartePeAgentiCheckBox.Location = New System.Drawing.Point(579, 378)
        Me.ImpartePeAgentiCheckBox.Name = "ImpartePeAgentiCheckBox"
        Me.ImpartePeAgentiCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.ImpartePeAgentiCheckBox.TabIndex = 204
        Me.ImpartePeAgentiCheckBox.Text = "Trimite emailuri la agenti"
        Me.ToolTip1.SetToolTip(Me.ImpartePeAgentiCheckBox, "Se pot trimite si la agenti daca se doreste. Functionalitatea este realizata, tre" &
        "buie doar activata.")
        Me.ImpartePeAgentiCheckBox.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ssInfo
        '
        Me.ssInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbInfo, Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1, Me.pbIncarca, Me.txtTimer})
        Me.ssInfo.Location = New System.Drawing.Point(0, 746)
        Me.ssInfo.Name = "ssInfo"
        Me.ssInfo.Size = New System.Drawing.Size(1126, 22)
        Me.ssInfo.TabIndex = 222
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
        'txtTimer
        '
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.Size = New System.Drawing.Size(119, 17)
        Me.txtTimer.Text = "ToolStripStatusLabel2"
        '
        'RobotsDataSet
        '
        Me.RobotsDataSet.DataSetName = "RobotsDataSet"
        Me.RobotsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConfigTableAdapter
        '
        Me.ConfigTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Agenti_vanzari_parteneriTableAdapter = Nothing
        Me.TableAdapterManager.Asignare_producator_achizitorTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CampuriConfigTableAdapter = Nothing
        Me.TableAdapterManager.ConfigTableAdapter = Me.ConfigTableAdapter
        Me.TableAdapterManager.Emails_agentiTableAdapter = Nothing
        Me.TableAdapterManager.Emails_filialeTableAdapter = Nothing
        Me.TableAdapterManager.Emails_TableAdapter = Nothing
        Me.TableAdapterManager.EmailsTableAdapter = Nothing
        Me.TableAdapterManager.Scadentar_emails_agentiTableAdapter = Nothing
        Me.TableAdapterManager.Scadentar_emails_filialeTableAdapter = Nothing
        Me.TableAdapterManager.SetariFortateRobotiTableAdapter = Nothing
        Me.TableAdapterManager.Solduri_clienti_parteneri_filiale_agentiTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = KmAutoInterface.RobotsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VizualizareToolStripMenuItem, Me.OperatiiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1126, 24)
        Me.MenuStrip1.TabIndex = 225
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VizualizareToolStripMenuItem
        '
        Me.VizualizareToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KmToolStripMenuItem, Me.MasiniToolStripMenuItem, Me.UtilizatoriToolStripMenuItem, Me.UtilizatoriInexistentiToolStripMenuItem, Me.MasiniInexistenteToolStripMenuItem, Me.CombustibiliToolStripMenuItem, Me.ZileLibereToolStripMenuItem, Me.GoogleFormsToolStripMenuItem, Me.GoogleSheetsToolStripMenuItem})
        Me.VizualizareToolStripMenuItem.Name = "VizualizareToolStripMenuItem"
        Me.VizualizareToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.VizualizareToolStripMenuItem.Text = "Vizualizare"
        '
        'KmToolStripMenuItem
        '
        Me.KmToolStripMenuItem.Name = "KmToolStripMenuItem"
        Me.KmToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.KmToolStripMenuItem.Text = "Km"
        '
        'MasiniToolStripMenuItem
        '
        Me.MasiniToolStripMenuItem.Name = "MasiniToolStripMenuItem"
        Me.MasiniToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.MasiniToolStripMenuItem.Text = "Masini"
        '
        'UtilizatoriToolStripMenuItem
        '
        Me.UtilizatoriToolStripMenuItem.Name = "UtilizatoriToolStripMenuItem"
        Me.UtilizatoriToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.UtilizatoriToolStripMenuItem.Text = "Utilizatori"
        '
        'UtilizatoriInexistentiToolStripMenuItem
        '
        Me.UtilizatoriInexistentiToolStripMenuItem.Name = "UtilizatoriInexistentiToolStripMenuItem"
        Me.UtilizatoriInexistentiToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.UtilizatoriInexistentiToolStripMenuItem.Text = "Utilizatori inexistenti"
        '
        'MasiniInexistenteToolStripMenuItem
        '
        Me.MasiniInexistenteToolStripMenuItem.Name = "MasiniInexistenteToolStripMenuItem"
        Me.MasiniInexistenteToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.MasiniInexistenteToolStripMenuItem.Text = "Masini inexistente"
        '
        'CombustibiliToolStripMenuItem
        '
        Me.CombustibiliToolStripMenuItem.Name = "CombustibiliToolStripMenuItem"
        Me.CombustibiliToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CombustibiliToolStripMenuItem.Text = "Combustibili"
        '
        'ZileLibereToolStripMenuItem
        '
        Me.ZileLibereToolStripMenuItem.Name = "ZileLibereToolStripMenuItem"
        Me.ZileLibereToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ZileLibereToolStripMenuItem.Text = "Filiale"
        '
        'GoogleFormsToolStripMenuItem
        '
        Me.GoogleFormsToolStripMenuItem.Name = "GoogleFormsToolStripMenuItem"
        Me.GoogleFormsToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.GoogleFormsToolStripMenuItem.Text = "Google Forms"
        '
        'GoogleSheetsToolStripMenuItem
        '
        Me.GoogleSheetsToolStripMenuItem.Name = "GoogleSheetsToolStripMenuItem"
        Me.GoogleSheetsToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.GoogleSheetsToolStripMenuItem.Text = "Google Sheets"
        '
        'OperatiiToolStripMenuItem
        '
        Me.OperatiiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GreseliUtilizatoriToolStripMenuItem, Me.EmailUtilizatoriToolStripMenuItem, Me.OperatiiExterneToolStripMenuItem, Me.IncarcaKmLogToolStripMenuItem, Me.ProceseazaLocalToolStripMenuItem, Me.RuleazaVBAToolStripMenuItem, Me.RuleazaRobotulToolStripMenuItem})
        Me.OperatiiToolStripMenuItem.Name = "OperatiiToolStripMenuItem"
        Me.OperatiiToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OperatiiToolStripMenuItem.Text = "Operatii"
        '
        'GreseliUtilizatoriToolStripMenuItem
        '
        Me.GreseliUtilizatoriToolStripMenuItem.Name = "GreseliUtilizatoriToolStripMenuItem"
        Me.GreseliUtilizatoriToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.GreseliUtilizatoriToolStripMenuItem.Text = "Greseli utilizatori"
        '
        'EmailUtilizatoriToolStripMenuItem
        '
        Me.EmailUtilizatoriToolStripMenuItem.Name = "EmailUtilizatoriToolStripMenuItem"
        Me.EmailUtilizatoriToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.EmailUtilizatoriToolStripMenuItem.Text = "Email utilizatori"
        '
        'OperatiiExterneToolStripMenuItem
        '
        Me.OperatiiExterneToolStripMenuItem.Name = "OperatiiExterneToolStripMenuItem"
        Me.OperatiiExterneToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.OperatiiExterneToolStripMenuItem.Text = "Operatii externe"
        '
        'IncarcaKmLogToolStripMenuItem
        '
        Me.IncarcaKmLogToolStripMenuItem.Name = "IncarcaKmLogToolStripMenuItem"
        Me.IncarcaKmLogToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.IncarcaKmLogToolStripMenuItem.Text = "Incarca km log"
        '
        'ProceseazaLocalToolStripMenuItem
        '
        Me.ProceseazaLocalToolStripMenuItem.Name = "ProceseazaLocalToolStripMenuItem"
        Me.ProceseazaLocalToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.ProceseazaLocalToolStripMenuItem.Text = "Proceseaza local"
        '
        'RuleazaVBAToolStripMenuItem
        '
        Me.RuleazaVBAToolStripMenuItem.Name = "RuleazaVBAToolStripMenuItem"
        Me.RuleazaVBAToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.RuleazaVBAToolStripMenuItem.Text = "Ruleaza VBA"
        '
        'RuleazaRobotulToolStripMenuItem
        '
        Me.RuleazaRobotulToolStripMenuItem.Name = "RuleazaRobotulToolStripMenuItem"
        Me.RuleazaRobotulToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.RuleazaRobotulToolStripMenuItem.Text = "Ruleaza robotul"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdJurnal, Me.cmdIntervale, Me.cmdKm, Me.cmdGreseli, Me.cmdEmail, Me.cmdDateExterne, Me.ToolStripSeparator2, Me.cmdMasini, Me.cmdUtilizatori, Me.Combustibili, Me.ToolStripSeparator1, Me.cmdIesire, Me.cmdRenuntaLaRulare, Me.cmdRuleazaRobotul, Me.cmdFiliale, Me.cmdRuleazaVBA})
        Me.ToolStrip1.Location = New System.Drawing.Point(14, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1103, 80)
        Me.ToolStrip1.TabIndex = 230
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
        'cmdIntervale
        '
        Me.cmdIntervale.Image = CType(resources.GetObject("cmdIntervale.Image"), System.Drawing.Image)
        Me.cmdIntervale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdIntervale.Name = "cmdIntervale"
        Me.cmdIntervale.Size = New System.Drawing.Size(68, 77)
        Me.cmdIntervale.Text = "Intervale"
        Me.cmdIntervale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdIntervale.ToolTipText = "Seteaza intervalele de weekend plus sarbatori legale din perioada curenta"
        '
        'cmdKm
        '
        Me.cmdKm.Image = CType(resources.GetObject("cmdKm.Image"), System.Drawing.Image)
        Me.cmdKm.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdKm.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdKm.Name = "cmdKm"
        Me.cmdKm.Size = New System.Drawing.Size(68, 77)
        Me.cmdKm.Text = "Km"
        Me.cmdKm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdKm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdKm.ToolTipText = "Reface setarile predefinite pentru fiecare robot (pentru a evita setari activate " &
    "la depanare sau accidental)"
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
        'cmdDateExterne
        '
        Me.cmdDateExterne.Image = CType(resources.GetObject("cmdDateExterne.Image"), System.Drawing.Image)
        Me.cmdDateExterne.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDateExterne.Name = "cmdDateExterne"
        Me.cmdDateExterne.Size = New System.Drawing.Size(77, 77)
        Me.cmdDateExterne.Text = "Date externe"
        Me.cmdDateExterne.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDateExterne.ToolTipText = "Date externe din Itrack, benzinarii"
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
        'Combustibili
        '
        Me.Combustibili.Image = CType(resources.GetObject("Combustibili.Image"), System.Drawing.Image)
        Me.Combustibili.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Combustibili.Name = "Combustibili"
        Me.Combustibili.Size = New System.Drawing.Size(79, 77)
        Me.Combustibili.Text = "Combustibili"
        Me.Combustibili.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'cmdRenuntaLaRulare
        '
        Me.cmdRenuntaLaRulare.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdRenuntaLaRulare.Image = CType(resources.GetObject("cmdRenuntaLaRulare.Image"), System.Drawing.Image)
        Me.cmdRenuntaLaRulare.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRenuntaLaRulare.Name = "cmdRenuntaLaRulare"
        Me.cmdRenuntaLaRulare.Size = New System.Drawing.Size(68, 77)
        Me.cmdRenuntaLaRulare.Text = "Renunta"
        Me.cmdRenuntaLaRulare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdRuleazaRobotul
        '
        Me.cmdRuleazaRobotul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdRuleazaRobotul.Image = CType(resources.GetObject("cmdRuleazaRobotul.Image"), System.Drawing.Image)
        Me.cmdRuleazaRobotul.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRuleazaRobotul.Name = "cmdRuleazaRobotul"
        Me.cmdRuleazaRobotul.Size = New System.Drawing.Size(93, 77)
        Me.cmdRuleazaRobotul.Text = "Ruleaza robotul"
        Me.cmdRuleazaRobotul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'cmdRuleazaVBA
        '
        Me.cmdRuleazaVBA.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdRuleazaVBA.Image = CType(resources.GetObject("cmdRuleazaVBA.Image"), System.Drawing.Image)
        Me.cmdRuleazaVBA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRuleazaVBA.Name = "cmdRuleazaVBA"
        Me.cmdRuleazaVBA.Size = New System.Drawing.Size(76, 77)
        Me.cmdRuleazaVBA.Text = "Ruleaza VBA"
        Me.cmdRuleazaVBA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(60, 453)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 13)
        Me.Label14.TabIndex = 231
        Me.Label14.Text = "Utilizatori neinregistrati"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(618, 453)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 13)
        Me.Label15.TabIndex = 232
        Me.Label15.Text = "Masini neinregistrate"
        '
        'KmAutoDataSet
        '
        Me.KmAutoDataSet.DataSetName = "KmAutoDataSet"
        Me.KmAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.Yellow
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeDataGridViewTextBoxColumn2, Me.SpreadsheetNameDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.MasiniInexistenteBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(616, 476)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(498, 81)
        Me.DataGridView2.TabIndex = 234
        '
        'NumeDataGridViewTextBoxColumn2
        '
        Me.NumeDataGridViewTextBoxColumn2.DataPropertyName = "Nume"
        Me.NumeDataGridViewTextBoxColumn2.HeaderText = "Nume"
        Me.NumeDataGridViewTextBoxColumn2.Name = "NumeDataGridViewTextBoxColumn2"
        Me.NumeDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'SpreadsheetNameDataGridViewTextBoxColumn1
        '
        Me.SpreadsheetNameDataGridViewTextBoxColumn1.DataPropertyName = "SpreadsheetName"
        Me.SpreadsheetNameDataGridViewTextBoxColumn1.HeaderText = "SpreadsheetName"
        Me.SpreadsheetNameDataGridViewTextBoxColumn1.Name = "SpreadsheetNameDataGridViewTextBoxColumn1"
        Me.SpreadsheetNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'MasiniInexistenteBindingSource
        '
        Me.MasiniInexistenteBindingSource.DataMember = "MasiniInexistente"
        Me.MasiniInexistenteBindingSource.DataSource = Me.KmAutoDataSet
        '
        'cmbSpreadsheets
        '
        Me.cmbSpreadsheets.DataSource = Me.Spreadsheets1BindingSource
        Me.cmbSpreadsheets.DisplayMember = "Nume"
        Me.cmbSpreadsheets.FormattingEnabled = True
        Me.cmbSpreadsheets.Location = New System.Drawing.Point(105, 424)
        Me.cmbSpreadsheets.MaxDropDownItems = 20
        Me.cmbSpreadsheets.Name = "cmbSpreadsheets"
        Me.cmbSpreadsheets.Size = New System.Drawing.Size(291, 21)
        Me.cmbSpreadsheets.TabIndex = 250
        Me.cmbSpreadsheets.ValueMember = "SpreadsheetId"
        '
        'Spreadsheets1BindingSource
        '
        Me.Spreadsheets1BindingSource.DataMember = "Spreadsheets1"
        Me.Spreadsheets1BindingSource.DataSource = Me.KmAutoDataSet
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(23, 428)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 249
        Me.Label16.Text = "Foi Google"
        '
        'cmdDeschideToateFoileGoogle
        '
        Me.cmdDeschideToateFoileGoogle.Location = New System.Drawing.Point(485, 423)
        Me.cmdDeschideToateFoileGoogle.Name = "cmdDeschideToateFoileGoogle"
        Me.cmdDeschideToateFoileGoogle.Size = New System.Drawing.Size(99, 23)
        Me.cmdDeschideToateFoileGoogle.TabIndex = 248
        Me.cmdDeschideToateFoileGoogle.Text = "Deschide toate"
        Me.cmdDeschideToateFoileGoogle.UseVisualStyleBackColor = True
        '
        'cmdDeschideSpreadsheet
        '
        Me.cmdDeschideSpreadsheet.Location = New System.Drawing.Point(411, 423)
        Me.cmdDeschideSpreadsheet.Name = "cmdDeschideSpreadsheet"
        Me.cmdDeschideSpreadsheet.Size = New System.Drawing.Size(68, 23)
        Me.cmdDeschideSpreadsheet.TabIndex = 247
        Me.cmdDeschideSpreadsheet.Text = "Deschide"
        Me.cmdDeschideSpreadsheet.UseVisualStyleBackColor = True
        '
        'CombustibiliTableAdapter1
        '
        Me.CombustibiliTableAdapter1.ClearBeforeFill = True
        '
        'GreseliLogBindingSource
        '
        Me.GreseliLogBindingSource.DataMember = "GreseliLog"
        Me.GreseliLogBindingSource.DataSource = Me.KmAutoDataSet
        '
        'GreseliLogTableAdapter
        '
        Me.GreseliLogTableAdapter.ClearBeforeFill = True
        '
        'Spreadsheets1TableAdapter
        '
        Me.Spreadsheets1TableAdapter.ClearBeforeFill = True
        '
        'cmdSchimbaDataRaportarii
        '
        Me.cmdSchimbaDataRaportarii.Location = New System.Drawing.Point(178, 344)
        Me.cmdSchimbaDataRaportarii.Name = "cmdSchimbaDataRaportarii"
        Me.cmdSchimbaDataRaportarii.Size = New System.Drawing.Size(72, 20)
        Me.cmdSchimbaDataRaportarii.TabIndex = 251
        Me.cmdSchimbaDataRaportarii.Text = "Schimba"
        Me.cmdSchimbaDataRaportarii.UseVisualStyleBackColor = True
        '
        'lblDataRaportarii
        '
        Me.lblDataRaportarii.AutoSize = True
        Me.lblDataRaportarii.Location = New System.Drawing.Point(99, 347)
        Me.lblDataRaportarii.Name = "lblDataRaportarii"
        Me.lblDataRaportarii.Size = New System.Drawing.Size(73, 13)
        Me.lblDataRaportarii.TabIndex = 252
        Me.lblDataRaportarii.Text = "Data raportarii"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(618, 560)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(193, 13)
        Me.Label17.TabIndex = 254
        Me.Label17.Text = "Masini active fara date introduse"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(74, 560)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(206, 13)
        Me.Label18.TabIndex = 253
        Me.Label18.Text = "Utilizatori activi fara date introduse"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.Yellow
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DataGridView3.DataSource = Me.UtilizatoriInPlusBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(23, 581)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(561, 149)
        Me.DataGridView3.TabIndex = 256
        '
        'NumeDataGridViewTextBoxColumn1
        '
        Me.NumeDataGridViewTextBoxColumn1.DataPropertyName = "Nume"
        Me.NumeDataGridViewTextBoxColumn1.HeaderText = "Nume"
        Me.NumeDataGridViewTextBoxColumn1.Name = "NumeDataGridViewTextBoxColumn1"
        Me.NumeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Telefon"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Telefon"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Observatii"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Observatii"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Spreadsheet"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Spreadsheet"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'UtilizatoriInPlusBindingSource
        '
        Me.UtilizatoriInPlusBindingSource.DataMember = "UtilizatoriInPlus"
        Me.UtilizatoriInPlusBindingSource.DataSource = Me.KmAutoDataSet
        '
        'KmAutoDataSet1
        '
        Me.KmAutoDataSet1.DataSetName = "KmAutoDataSet"
        Me.KmAutoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.BackgroundColor = System.Drawing.Color.Yellow
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumarDataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Observatii, Me.DataGridViewTextBoxColumn7})
        Me.DataGridView4.DataSource = Me.MasiniInPlusBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(616, 576)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.Size = New System.Drawing.Size(498, 149)
        Me.DataGridView4.TabIndex = 255
        '
        'NumarDataGridViewTextBoxColumn1
        '
        Me.NumarDataGridViewTextBoxColumn1.DataPropertyName = "Numar"
        Me.NumarDataGridViewTextBoxColumn1.HeaderText = "Numar"
        Me.NumarDataGridViewTextBoxColumn1.Name = "NumarDataGridViewTextBoxColumn1"
        Me.NumarDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Model"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Observatii
        '
        Me.Observatii.DataPropertyName = "Observatii"
        Me.Observatii.HeaderText = "Observatii"
        Me.Observatii.Name = "Observatii"
        Me.Observatii.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Spreadsheet"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Spreadsheet"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'MasiniInPlusBindingSource
        '
        Me.MasiniInPlusBindingSource.DataMember = "MasiniInPlus"
        Me.MasiniInPlusBindingSource.DataSource = Me.KmAutoDataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Yellow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeDataGridViewTextBoxColumn, Me.SpreadsheetNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UtilizatoriInexistentiBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 476)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(562, 83)
        Me.DataGridView1.TabIndex = 257
        '
        'NumeDataGridViewTextBoxColumn
        '
        Me.NumeDataGridViewTextBoxColumn.DataPropertyName = "Nume"
        Me.NumeDataGridViewTextBoxColumn.HeaderText = "Nume"
        Me.NumeDataGridViewTextBoxColumn.Name = "NumeDataGridViewTextBoxColumn"
        Me.NumeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SpreadsheetNameDataGridViewTextBoxColumn
        '
        Me.SpreadsheetNameDataGridViewTextBoxColumn.DataPropertyName = "SpreadsheetName"
        Me.SpreadsheetNameDataGridViewTextBoxColumn.HeaderText = "SpreadsheetName"
        Me.SpreadsheetNameDataGridViewTextBoxColumn.Name = "SpreadsheetNameDataGridViewTextBoxColumn"
        Me.SpreadsheetNameDataGridViewTextBoxColumn.ReadOnly = True
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
        'MasiniInexistenteTableAdapter
        '
        Me.MasiniInexistenteTableAdapter.ClearBeforeFill = True
        '
        'MasiniInPlusTableAdapter
        '
        Me.MasiniInPlusTableAdapter.ClearBeforeFill = True
        '
        'UtilizatoriInPlusTableAdapter
        '
        Me.UtilizatoriInPlusTableAdapter.ClearBeforeFill = True
        '
        'ckBoxDeschideKm
        '
        Me.ckBoxDeschideKm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckBoxDeschideKm.Location = New System.Drawing.Point(444, 335)
        Me.ckBoxDeschideKm.Name = "ckBoxDeschideKm"
        Me.ckBoxDeschideKm.Size = New System.Drawing.Size(280, 24)
        Me.ckBoxDeschideKm.TabIndex = 258
        Me.ckBoxDeschideKm.Text = "Deschide fereastra km la pornire"
        Me.ckBoxDeschideKm.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 400
        '
        'lvSheets
        '
        Me.lvSheets.CheckBoxes = True
        Me.lvSheets.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nume, Me.Filiala, Me.Activ, Me.SpreadsheetId})
        Me.lvSheets.HideSelection = False
        Me.lvSheets.Location = New System.Drawing.Point(547, 212)
        Me.lvSheets.MultiSelect = False
        Me.lvSheets.Name = "lvSheets"
        Me.lvSheets.Size = New System.Drawing.Size(104, 76)
        Me.lvSheets.TabIndex = 264
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
        'ToolStrip2
        '
        Me.ToolStrip2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.Color.White
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdGoogleForms, Me.cmdGoogleSheets, Me.cmdIesire1, Me.cmdProceseazaLocal, Me.cmdIncarcaToateFoileGoogle, Me.cmdDeschideProcesator, Me.cmdDeschideRaportCurent, Me.cmdOperatiiBulk})
        Me.ToolStrip2.Location = New System.Drawing.Point(14, 113)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1103, 80)
        Me.ToolStrip2.TabIndex = 265
        '
        'cmdGoogleForms
        '
        Me.cmdGoogleForms.Image = CType(resources.GetObject("cmdGoogleForms.Image"), System.Drawing.Image)
        Me.cmdGoogleForms.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGoogleForms.Name = "cmdGoogleForms"
        Me.cmdGoogleForms.Size = New System.Drawing.Size(85, 77)
        Me.cmdGoogleForms.Text = "Google Forms"
        Me.cmdGoogleForms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdGoogleSheets
        '
        Me.cmdGoogleSheets.Image = CType(resources.GetObject("cmdGoogleSheets.Image"), System.Drawing.Image)
        Me.cmdGoogleSheets.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGoogleSheets.Name = "cmdGoogleSheets"
        Me.cmdGoogleSheets.Size = New System.Drawing.Size(86, 77)
        Me.cmdGoogleSheets.Text = "Google Sheets"
        Me.cmdGoogleSheets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdIesire1
        '
        Me.cmdIesire1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdIesire1.Image = CType(resources.GetObject("cmdIesire1.Image"), System.Drawing.Image)
        Me.cmdIesire1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdIesire1.Name = "cmdIesire1"
        Me.cmdIesire1.Size = New System.Drawing.Size(68, 77)
        Me.cmdIesire1.Text = "Iesire"
        Me.cmdIesire1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.cmdIncarcaToateFoileGoogle.Size = New System.Drawing.Size(89, 77)
        Me.cmdIncarcaToateFoileGoogle.Text = "Incarca km log"
        Me.cmdIncarcaToateFoileGoogle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(870, 218)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(211, 205)
        Me.TextBox1.TabIndex = 266
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1126, 768)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.lvSheets)
        Me.Controls.Add(Me.ckBoxDeschideKm)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.lblDataRaportarii)
        Me.Controls.Add(Me.cmdSchimbaDataRaportarii)
        Me.Controls.Add(Me.cmbSpreadsheets)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmdDeschideToateFoileGoogle)
        Me.Controls.Add(Me.cmdDeschideSpreadsheet)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ssInfo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ImpartePeAgentiCheckBox)
        Me.Controls.Add(Me.ImpartePeFilialeCheckBox)
        Me.Controls.Add(Me.LabelDataInterogare)
        Me.Controls.Add(EmailMeLabel)
        Me.Controls.Add(Me.ExtrageRapExcelDinBICheckBox)
        Me.Controls.Add(Me.EmailMeTextBox)
        Me.Controls.Add(EmailToLabel)
        Me.Controls.Add(Me.EmailToTextBox)
        Me.Controls.Add(Me.NumarLuniActualizateTextBox)
        Me.Controls.Add(Me.EmailSendCheckBox)
        Me.Controls.Add(NumarLuniActualizateLabel)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1060, 551)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Km Auto"
        Me.ssInfo.ResumeLayout(False)
        Me.ssInfo.PerformLayout()
        CType(Me.RobotsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasiniInexistenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Spreadsheets1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreseliLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilizatoriInPlusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmAutoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasiniInPlusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilizatoriInexistentiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDataInterogare As Label
    Friend WithEvents RobotsDataSet As RobotsDataSet
    Friend WithEvents ConfigTableAdapter As RobotsDataSetTableAdapters.ConfigTableAdapter
    Friend WithEvents TableAdapterManager As RobotsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmailMeTextBox As TextBox
    Friend WithEvents EmailToTextBox As TextBox
    Friend WithEvents EmailSendCheckBox As CheckBox
    Friend WithEvents ExtrageRapExcelDinBICheckBox As CheckBox
    Friend WithEvents NumarLuniActualizateTextBox As TextBox
    Friend WithEvents CombustibiliTableAdapter1 As KmAutoDataSetTableAdapters.CombustibiliTableAdapter
    Friend WithEvents Timer2 As Timer
    Friend WithEvents KmAutoDataSet As KmAutoDataSet
    Friend WithEvents GreseliLogBindingSource As BindingSource
    Friend WithEvents GreseliLogTableAdapter As KmAutoDataSetTableAdapters.GreseliLogTableAdapter
    Friend WithEvents ImpartePeFilialeCheckBox As CheckBox
    Friend WithEvents ImpartePeAgentiCheckBox As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ssInfo As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents pbIncarca As ToolStripProgressBar
    Friend WithEvents lbInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents VizualizareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasiniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilizatoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilizatoriInexistentiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasiniInexistenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZileLibereToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperatiiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreseliUtilizatoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmailUtilizatoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtTimer As ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdKm As ToolStripButton
    Friend WithEvents cmdMasini As ToolStripButton
    Friend WithEvents cmdUtilizatori As ToolStripButton
    Friend WithEvents cmdDateExterne As ToolStripButton
    Friend WithEvents cmdIesire As ToolStripButton
    Friend WithEvents cmdIntervale As ToolStripButton
    Friend WithEvents cmdGreseli As ToolStripButton
    Friend WithEvents cmdEmail As ToolStripButton
    Friend WithEvents cmdRuleazaRobotul As ToolStripButton
    Friend WithEvents cmdRenuntaLaRulare As ToolStripButton
    Friend WithEvents Combustibili As ToolStripButton
    Friend WithEvents OperatiiExterneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdRuleazaVBA As ToolStripButton
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents cmbSpreadsheets As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cmdDeschideToateFoileGoogle As Button
    Friend WithEvents cmdDeschideSpreadsheet As Button
    Friend WithEvents Spreadsheets1BindingSource As BindingSource
    Friend WithEvents Spreadsheets1TableAdapter As KmAutoDataSetTableAdapters.Spreadsheets1TableAdapter
    Friend WithEvents cmdSchimbaDataRaportarii As Button
    Friend WithEvents lblDataRaportarii As Label
    Friend WithEvents cmdFiliale As ToolStripButton
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents KmAutoDataSet1 As KmAutoDataSet
    Friend WithEvents TelefonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservatiiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpreadsheetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpreadsheetDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UtilizatoriInexistentiBindingSource As BindingSource
    Friend WithEvents UtilizatoriInexistentiTableAdapter As KmAutoDataSetTableAdapters.UtilizatoriInexistentiTableAdapter
    Friend WithEvents NumeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpreadsheetNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MasiniInexistenteBindingSource As BindingSource
    Friend WithEvents MasiniInexistenteTableAdapter As KmAutoDataSetTableAdapters.MasiniInexistenteTableAdapter
    Friend WithEvents NumeDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents SpreadsheetNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MasiniInPlusBindingSource As BindingSource
    Friend WithEvents MasiniInPlusTableAdapter As KmAutoDataSetTableAdapters.MasiniInPlusTableAdapter
    Friend WithEvents UtilizatoriInPlusBindingSource As BindingSource
    Friend WithEvents UtilizatoriInPlusTableAdapter As KmAutoDataSetTableAdapters.UtilizatoriInPlusTableAdapter
    Friend WithEvents NumeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents GoogleFormsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ckBoxDeschideKm As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GoogleSheetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lvSheets As ListView
    Friend WithEvents Nume As ColumnHeader
    Friend WithEvents Filiala As ColumnHeader
    Friend WithEvents Activ As ColumnHeader
    Friend WithEvents SpreadsheetId As ColumnHeader
    Friend WithEvents CombustibiliToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncarcaKmLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProceseazaLocalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RuleazaVBAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RuleazaRobotulToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdJurnal As ToolStripButton
    Friend WithEvents NumarDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Observatii As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents cmdGoogleForms As ToolStripButton
    Friend WithEvents cmdGoogleSheets As ToolStripButton
    Friend WithEvents cmdProceseazaLocal As ToolStripButton
    Friend WithEvents cmdIncarcaToateFoileGoogle As ToolStripButton
    Friend WithEvents cmdDeschideProcesator As ToolStripButton
    Friend WithEvents cmdDeschideRaportCurent As ToolStripButton
    Friend WithEvents cmdOperatiiBulk As ToolStripButton
    Friend WithEvents cmdIesire1 As ToolStripButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
