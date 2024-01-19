<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGoogleForms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGoogleForms))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdMasiniUtilizatori = New System.Windows.Forms.ToolStripButton()
        Me.cmdIesire = New System.Windows.Forms.ToolStripButton()
        Me.cmdSelecteazaTot = New System.Windows.Forms.ToolStripButton()
        Me.cmdDeselecteazaTot = New System.Windows.Forms.ToolStripButton()
        Me.cmdUpdateDescription = New System.Windows.Forms.ToolStripButton()
        Me.cmdDeschideFoaiaGoogle = New System.Windows.Forms.ToolStripButton()
        Me.cmdMutaInAltaFoaie = New System.Windows.Forms.ToolStripButton()
        Me.cmdScoateDinGoogle = New System.Windows.Forms.ToolStripButton()
        Me.cmdAdaugaInGoogle = New System.Windows.Forms.ToolStripButton()
        Me.cmdIncarcaDateVerificareGoogle = New System.Windows.Forms.ToolStripButton()
        Me.cmdGoogleInfo = New System.Windows.Forms.ToolStripButton()
        Me.ssInfo = New System.Windows.Forms.StatusStrip()
        Me.lbInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbIncarca = New System.Windows.Forms.ToolStripProgressBar()
        Me.txtTimer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lvForms = New System.Windows.Forms.ListView()
        Me.Nume = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Filiala = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Activ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SpreadsheetId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBoxItemContent = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBoxItems = New System.Windows.Forms.ListBox()
        Me.lblItemLocation = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblQuestionId = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblQuestionRequired = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblChoiceQuestionType = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCautareMasinaSauUtilizator = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMasiniSauUtilizatori = New System.Windows.Forms.ComboBox()
        Me.lblGoogleForm = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ConsolightDataSet1 = New KmAutoInterface.ConsolightDataSet()
        Me.lvOutput = New System.Windows.Forms.ListView()
        Me.Numar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Foaie = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.ssInfo.SuspendLayout()
        CType(Me.ConsolightDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdMasiniUtilizatori, Me.cmdIesire, Me.cmdSelecteazaTot, Me.cmdDeselecteazaTot, Me.cmdUpdateDescription, Me.cmdDeschideFoaiaGoogle, Me.cmdMutaInAltaFoaie, Me.cmdScoateDinGoogle, Me.cmdAdaugaInGoogle, Me.cmdIncarcaDateVerificareGoogle, Me.cmdGoogleInfo})
        Me.ToolStrip1.Location = New System.Drawing.Point(14, 12)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1233, 80)
        Me.ToolStrip1.TabIndex = 232
        '
        'cmdMasiniUtilizatori
        '
        Me.cmdMasiniUtilizatori.Image = CType(resources.GetObject("cmdMasiniUtilizatori.Image"), System.Drawing.Image)
        Me.cmdMasiniUtilizatori.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdMasiniUtilizatori.Name = "cmdMasiniUtilizatori"
        Me.cmdMasiniUtilizatori.Size = New System.Drawing.Size(101, 77)
        Me.cmdMasiniUtilizatori.Text = "Masini/Utilizatori"
        Me.cmdMasiniUtilizatori.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'cmdSelecteazaTot
        '
        Me.cmdSelecteazaTot.Image = CType(resources.GetObject("cmdSelecteazaTot.Image"), System.Drawing.Image)
        Me.cmdSelecteazaTot.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSelecteazaTot.Name = "cmdSelecteazaTot"
        Me.cmdSelecteazaTot.Size = New System.Drawing.Size(83, 77)
        Me.cmdSelecteazaTot.Text = "Selecteaza tot"
        Me.cmdSelecteazaTot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdDeselecteazaTot
        '
        Me.cmdDeselecteazaTot.Image = CType(resources.GetObject("cmdDeselecteazaTot.Image"), System.Drawing.Image)
        Me.cmdDeselecteazaTot.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDeselecteazaTot.Name = "cmdDeselecteazaTot"
        Me.cmdDeselecteazaTot.Size = New System.Drawing.Size(96, 77)
        Me.cmdDeselecteazaTot.Text = "Deselecteaza tot"
        Me.cmdDeselecteazaTot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdUpdateDescription
        '
        Me.cmdUpdateDescription.Image = CType(resources.GetObject("cmdUpdateDescription.Image"), System.Drawing.Image)
        Me.cmdUpdateDescription.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdUpdateDescription.Name = "cmdUpdateDescription"
        Me.cmdUpdateDescription.Size = New System.Drawing.Size(114, 77)
        Me.cmdUpdateDescription.Text = "Modifica descrierea"
        Me.cmdUpdateDescription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdDeschideFoaiaGoogle
        '
        Me.cmdDeschideFoaiaGoogle.Image = CType(resources.GetObject("cmdDeschideFoaiaGoogle.Image"), System.Drawing.Image)
        Me.cmdDeschideFoaiaGoogle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDeschideFoaiaGoogle.Name = "cmdDeschideFoaiaGoogle"
        Me.cmdDeschideFoaiaGoogle.Size = New System.Drawing.Size(113, 77)
        Me.cmdDeschideFoaiaGoogle.Text = "Deschide in Google"
        Me.cmdDeschideFoaiaGoogle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdMutaInAltaFoaie
        '
        Me.cmdMutaInAltaFoaie.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdMutaInAltaFoaie.Image = CType(resources.GetObject("cmdMutaInAltaFoaie.Image"), System.Drawing.Image)
        Me.cmdMutaInAltaFoaie.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdMutaInAltaFoaie.Name = "cmdMutaInAltaFoaie"
        Me.cmdMutaInAltaFoaie.Size = New System.Drawing.Size(103, 77)
        Me.cmdMutaInAltaFoaie.Text = "Muta in alta foaie"
        Me.cmdMutaInAltaFoaie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdScoateDinGoogle
        '
        Me.cmdScoateDinGoogle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdScoateDinGoogle.Image = CType(resources.GetObject("cmdScoateDinGoogle.Image"), System.Drawing.Image)
        Me.cmdScoateDinGoogle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdScoateDinGoogle.Name = "cmdScoateDinGoogle"
        Me.cmdScoateDinGoogle.Size = New System.Drawing.Size(107, 77)
        Me.cmdScoateDinGoogle.Text = "Scoate din Google"
        Me.cmdScoateDinGoogle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdAdaugaInGoogle
        '
        Me.cmdAdaugaInGoogle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdAdaugaInGoogle.Image = CType(resources.GetObject("cmdAdaugaInGoogle.Image"), System.Drawing.Image)
        Me.cmdAdaugaInGoogle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdaugaInGoogle.Name = "cmdAdaugaInGoogle"
        Me.cmdAdaugaInGoogle.Size = New System.Drawing.Size(106, 77)
        Me.cmdAdaugaInGoogle.Text = "Adauga in Google"
        Me.cmdAdaugaInGoogle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdIncarcaDateVerificareGoogle
        '
        Me.cmdIncarcaDateVerificareGoogle.Image = CType(resources.GetObject("cmdIncarcaDateVerificareGoogle.Image"), System.Drawing.Image)
        Me.cmdIncarcaDateVerificareGoogle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdIncarcaDateVerificareGoogle.Name = "cmdIncarcaDateVerificareGoogle"
        Me.cmdIncarcaDateVerificareGoogle.Size = New System.Drawing.Size(68, 77)
        Me.cmdIncarcaDateVerificareGoogle.Text = "Incarca tot"
        Me.cmdIncarcaDateVerificareGoogle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdGoogleInfo
        '
        Me.cmdGoogleInfo.Image = CType(resources.GetObject("cmdGoogleInfo.Image"), System.Drawing.Image)
        Me.cmdGoogleInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGoogleInfo.Name = "cmdGoogleInfo"
        Me.cmdGoogleInfo.Size = New System.Drawing.Size(68, 77)
        Me.cmdGoogleInfo.Text = "Info"
        Me.cmdGoogleInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ssInfo
        '
        Me.ssInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbInfo, Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1, Me.pbIncarca, Me.txtTimer})
        Me.ssInfo.Location = New System.Drawing.Point(0, 608)
        Me.ssInfo.Name = "ssInfo"
        Me.ssInfo.Size = New System.Drawing.Size(1256, 22)
        Me.ssInfo.TabIndex = 231
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
        'lvForms
        '
        Me.lvForms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvForms.CheckBoxes = True
        Me.lvForms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nume, Me.Filiala, Me.Activ, Me.SpreadsheetId})
        Me.lvForms.HideSelection = False
        Me.lvForms.Location = New System.Drawing.Point(14, 384)
        Me.lvForms.MultiSelect = False
        Me.lvForms.Name = "lvForms"
        Me.lvForms.Size = New System.Drawing.Size(601, 221)
        Me.lvForms.TabIndex = 233
        Me.lvForms.UseCompatibleStateImageBehavior = False
        Me.lvForms.View = System.Windows.Forms.View.Details
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ListBoxItemContent
        '
        Me.ListBoxItemContent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxItemContent.FormattingEnabled = True
        Me.ListBoxItemContent.Location = New System.Drawing.Point(624, 251)
        Me.ListBoxItemContent.Name = "ListBoxItemContent"
        Me.ListBoxItemContent.Size = New System.Drawing.Size(204, 342)
        Me.ListBoxItemContent.TabIndex = 235
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(877, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 236
        Me.Label1.Text = "Location"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDescription.Location = New System.Drawing.Point(834, 384)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(410, 217)
        Me.TextBoxDescription.TabIndex = 239
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(831, 364)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 240
        Me.Label3.Text = "Description"
        '
        'ListBoxItems
        '
        Me.ListBoxItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxItems.FormattingEnabled = True
        Me.ListBoxItems.Items.AddRange(New Object() {"Masina", "Utilizator", "Km", "STATUS", "Poza din bord", "Observatii", "Data si ora citirii kilometrajului"})
        Me.ListBoxItems.Location = New System.Drawing.Point(621, 102)
        Me.ListBoxItems.Name = "ListBoxItems"
        Me.ListBoxItems.Size = New System.Drawing.Size(204, 108)
        Me.ListBoxItems.TabIndex = 243
        '
        'lblItemLocation
        '
        Me.lblItemLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemLocation.Location = New System.Drawing.Point(1034, 165)
        Me.lblItemLocation.Name = "lblItemLocation"
        Me.lblItemLocation.Size = New System.Drawing.Size(175, 13)
        Me.lblItemLocation.TabIndex = 244
        '
        'lblId
        '
        Me.lblId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblId.Location = New System.Drawing.Point(1034, 188)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(175, 13)
        Me.lblId.TabIndex = 246
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(877, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 13)
        Me.Label4.TabIndex = 245
        Me.Label4.Text = "Id"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.Location = New System.Drawing.Point(1034, 210)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(175, 13)
        Me.lblTitle.TabIndex = 248
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(877, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 13)
        Me.Label5.TabIndex = 247
        Me.Label5.Text = "Title"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQuestionId
        '
        Me.lblQuestionId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuestionId.Location = New System.Drawing.Point(1034, 233)
        Me.lblQuestionId.Name = "lblQuestionId"
        Me.lblQuestionId.Size = New System.Drawing.Size(175, 13)
        Me.lblQuestionId.TabIndex = 250
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(877, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 13)
        Me.Label6.TabIndex = 249
        Me.Label6.Text = "Question Id"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblQuestionRequired
        '
        Me.lblQuestionRequired.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuestionRequired.Location = New System.Drawing.Point(1034, 256)
        Me.lblQuestionRequired.Name = "lblQuestionRequired"
        Me.lblQuestionRequired.Size = New System.Drawing.Size(175, 13)
        Me.lblQuestionRequired.TabIndex = 252
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Location = New System.Drawing.Point(877, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 13)
        Me.Label7.TabIndex = 251
        Me.Label7.Text = "Question required"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblChoiceQuestionType
        '
        Me.lblChoiceQuestionType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChoiceQuestionType.Location = New System.Drawing.Point(1034, 281)
        Me.lblChoiceQuestionType.Name = "lblChoiceQuestionType"
        Me.lblChoiceQuestionType.Size = New System.Drawing.Size(175, 13)
        Me.lblChoiceQuestionType.TabIndex = 254
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Location = New System.Drawing.Point(877, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 13)
        Me.Label8.TabIndex = 253
        Me.Label8.Text = "Choice question type"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCautareMasinaSauUtilizator
        '
        Me.txtCautareMasinaSauUtilizator.Location = New System.Drawing.Point(82, 138)
        Me.txtCautareMasinaSauUtilizator.Name = "txtCautareMasinaSauUtilizator"
        Me.txtCautareMasinaSauUtilizator.Size = New System.Drawing.Size(78, 20)
        Me.txtCautareMasinaSauUtilizator.TabIndex = 255
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 256
        Me.Label2.Text = "Cautare:"
        '
        'cmbMasiniSauUtilizatori
        '
        Me.cmbMasiniSauUtilizatori.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMasiniSauUtilizatori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMasiniSauUtilizatori.FormattingEnabled = True
        Me.cmbMasiniSauUtilizatori.Location = New System.Drawing.Point(405, 135)
        Me.cmbMasiniSauUtilizatori.MaxDropDownItems = 40
        Me.cmbMasiniSauUtilizatori.Name = "cmbMasiniSauUtilizatori"
        Me.cmbMasiniSauUtilizatori.Size = New System.Drawing.Size(204, 21)
        Me.cmbMasiniSauUtilizatori.TabIndex = 257
        '
        'lblGoogleForm
        '
        Me.lblGoogleForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoogleForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblGoogleForm.Location = New System.Drawing.Point(12, 102)
        Me.lblGoogleForm.Name = "lblGoogleForm"
        Me.lblGoogleForm.Size = New System.Drawing.Size(384, 29)
        Me.lblGoogleForm.TabIndex = 258
        Me.lblGoogleForm.Text = "Google form: "
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 200
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(402, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 13)
        Me.Label9.TabIndex = 259
        Me.Label9.Text = "Selectati aici pentru adaugare in Google"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(621, 231)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(198, 13)
        Me.Label10.TabIndex = 260
        Me.Label10.Text = "Selectati aici pentru scoatere din Google"
        '
        'ConsolightDataSet1
        '
        Me.ConsolightDataSet1.DataSetName = "ConsolightDataSet"
        Me.ConsolightDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lvOutput
        '
        Me.lvOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvOutput.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Numar, Me.ColumnHeader1, Me.Foaie, Me.ColumnHeader2})
        Me.lvOutput.HideSelection = False
        Me.lvOutput.Location = New System.Drawing.Point(15, 164)
        Me.lvOutput.MultiSelect = False
        Me.lvOutput.Name = "lvOutput"
        Me.lvOutput.Size = New System.Drawing.Size(597, 217)
        Me.lvOutput.TabIndex = 261
        Me.lvOutput.UseCompatibleStateImageBehavior = False
        Me.lvOutput.View = System.Windows.Forms.View.Details
        '
        'Numar
        '
        Me.Numar.Text = "Numar"
        Me.Numar.Width = 100
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nume"
        Me.ColumnHeader1.Width = 200
        '
        'Foaie
        '
        Me.Foaie.Text = "Foaie"
        Me.Foaie.Width = 300
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Filiala"
        Me.ColumnHeader2.Width = 200
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(557, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 24)
        Me.Button1.TabIndex = 262
        Me.Button1.Text = "Sterge"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmGoogleForms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 630)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lvOutput)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblGoogleForm)
        Me.Controls.Add(Me.txtCautareMasinaSauUtilizator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbMasiniSauUtilizatori)
        Me.Controls.Add(Me.lblChoiceQuestionType)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblQuestionRequired)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblQuestionId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblItemLocation)
        Me.Controls.Add(Me.ListBoxItems)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxItemContent)
        Me.Controls.Add(Me.lvForms)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ssInfo)
        Me.Name = "frmGoogleForms"
        Me.Text = "frmGoogleForms"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ssInfo.ResumeLayout(False)
        Me.ssInfo.PerformLayout()
        CType(Me.ConsolightDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdIesire As ToolStripButton
    Friend WithEvents ssInfo As StatusStrip
    Friend WithEvents lbInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents pbIncarca As ToolStripProgressBar
    Friend WithEvents txtTimer As ToolStripStatusLabel
    Friend WithEvents lvForms As ListView
    Friend WithEvents Nume As ColumnHeader
    Friend WithEvents Filiala As ColumnHeader
    Friend WithEvents Activ As ColumnHeader
    Friend WithEvents SpreadsheetId As ColumnHeader
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ListBoxItemContent As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBoxItems As ListBox
    Friend WithEvents lblItemLocation As Label
    Friend WithEvents lblId As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblQuestionId As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblQuestionRequired As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblChoiceQuestionType As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdMasiniUtilizatori As ToolStripButton
    Friend WithEvents cmdSelecteazaTot As ToolStripButton
    Friend WithEvents cmdDeselecteazaTot As ToolStripButton
    Friend WithEvents cmdUpdateDescription As ToolStripButton
    Friend WithEvents cmdDeschideFoaiaGoogle As ToolStripButton
    Friend WithEvents txtCautareMasinaSauUtilizator As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbMasiniSauUtilizatori As ComboBox
    Friend WithEvents cmdAdaugaInGoogle As ToolStripButton
    Friend WithEvents cmdScoateDinGoogle As ToolStripButton
    Friend WithEvents lblGoogleForm As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmdIncarcaDateVerificareGoogle As ToolStripButton
    Friend WithEvents cmdGoogleInfo As ToolStripButton
    Friend WithEvents ConsolightDataSet1 As ConsolightDataSet
    Friend WithEvents cmdMutaInAltaFoaie As ToolStripButton
    Friend WithEvents lvOutput As ListView
    Friend WithEvents Numar As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Foaie As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Button1 As Button
End Class
