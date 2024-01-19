<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGoogleSheets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGoogleSheets))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lvOutput = New System.Windows.Forms.ListView()
        Me.Numar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Foaie = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblGoogleForm = New System.Windows.Forms.Label()
        Me.txtCautareMasinaSauUtilizator = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMasiniSauUtilizatori = New System.Windows.Forms.ComboBox()
        Me.lvSheets = New System.Windows.Forms.ListView()
        Me.Nume = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Filiala = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Activ = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SpreadsheetId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdMasiniUtilizatori = New System.Windows.Forms.ToolStripButton()
        Me.cmdIesire = New System.Windows.Forms.ToolStripButton()
        Me.cmdSelecteazaTot = New System.Windows.Forms.ToolStripButton()
        Me.cmdDeselecteazaTot = New System.Windows.Forms.ToolStripButton()
        Me.cmdIncarcaKmLog = New System.Windows.Forms.ToolStripButton()
        Me.cmdDeschideFoaiaGoogle = New System.Windows.Forms.ToolStripButton()
        Me.ListBoxItems = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ssInfo = New System.Windows.Forms.StatusStrip()
        Me.lbInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbIncarca = New System.Windows.Forms.ToolStripProgressBar()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.ToolStrip1.SuspendLayout()
        Me.ssInfo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(563, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 24)
        Me.Button1.TabIndex = 270
        Me.Button1.Text = "Sterge"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lvOutput
        '
        Me.lvOutput.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Numar, Me.ColumnHeader1, Me.Foaie, Me.ColumnHeader2})
        Me.lvOutput.HideSelection = False
        Me.lvOutput.Location = New System.Drawing.Point(12, 162)
        Me.lvOutput.MultiSelect = False
        Me.lvOutput.Name = "lvOutput"
        Me.lvOutput.Size = New System.Drawing.Size(606, 217)
        Me.lvOutput.TabIndex = 269
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(411, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 13)
        Me.Label9.TabIndex = 268
        Me.Label9.Text = "Selectati aici pentru adaugare in Google"
        '
        'lblGoogleForm
        '
        Me.lblGoogleForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoogleForm.ForeColor = System.Drawing.Color.Green
        Me.lblGoogleForm.Location = New System.Drawing.Point(9, 89)
        Me.lblGoogleForm.Name = "lblGoogleForm"
        Me.lblGoogleForm.Size = New System.Drawing.Size(384, 32)
        Me.lblGoogleForm.TabIndex = 267
        Me.lblGoogleForm.Text = "Google sheet: "
        '
        'txtCautareMasinaSauUtilizator
        '
        Me.txtCautareMasinaSauUtilizator.Location = New System.Drawing.Point(79, 136)
        Me.txtCautareMasinaSauUtilizator.Name = "txtCautareMasinaSauUtilizator"
        Me.txtCautareMasinaSauUtilizator.Size = New System.Drawing.Size(78, 20)
        Me.txtCautareMasinaSauUtilizator.TabIndex = 264
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 265
        Me.Label2.Text = "Cautare:"
        '
        'cmbMasiniSauUtilizatori
        '
        Me.cmbMasiniSauUtilizatori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMasiniSauUtilizatori.FormattingEnabled = True
        Me.cmbMasiniSauUtilizatori.Location = New System.Drawing.Point(414, 136)
        Me.cmbMasiniSauUtilizatori.MaxDropDownItems = 40
        Me.cmbMasiniSauUtilizatori.Name = "cmbMasiniSauUtilizatori"
        Me.cmbMasiniSauUtilizatori.Size = New System.Drawing.Size(204, 21)
        Me.cmbMasiniSauUtilizatori.TabIndex = 266
        '
        'lvSheets
        '
        Me.lvSheets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvSheets.CheckBoxes = True
        Me.lvSheets.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nume, Me.Filiala, Me.Activ, Me.SpreadsheetId})
        Me.lvSheets.HideSelection = False
        Me.lvSheets.Location = New System.Drawing.Point(628, 99)
        Me.lvSheets.MultiSelect = False
        Me.lvSheets.Name = "lvSheets"
        Me.lvSheets.Size = New System.Drawing.Size(645, 280)
        Me.lvSheets.TabIndex = 263
        Me.lvSheets.UseCompatibleStateImageBehavior = False
        Me.lvSheets.View = System.Windows.Forms.View.Details
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
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdMasiniUtilizatori, Me.cmdIesire, Me.cmdSelecteazaTot, Me.cmdDeselecteazaTot, Me.cmdIncarcaKmLog, Me.cmdDeschideFoaiaGoogle})
        Me.ToolStrip1.Location = New System.Drawing.Point(13, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1260, 80)
        Me.ToolStrip1.TabIndex = 271
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
        'cmdIncarcaKmLog
        '
        Me.cmdIncarcaKmLog.Image = CType(resources.GetObject("cmdIncarcaKmLog.Image"), System.Drawing.Image)
        Me.cmdIncarcaKmLog.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdIncarcaKmLog.Name = "cmdIncarcaKmLog"
        Me.cmdIncarcaKmLog.Size = New System.Drawing.Size(90, 77)
        Me.cmdIncarcaKmLog.Text = "Incarca Km log"
        Me.cmdIncarcaKmLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'ListBoxItems
        '
        Me.ListBoxItems.FormattingEnabled = True
        Me.ListBoxItems.Items.AddRange(New Object() {"Masina", "Utilizator"})
        Me.ListBoxItems.Location = New System.Drawing.Point(259, 124)
        Me.ListBoxItems.Name = "ListBoxItems"
        Me.ListBoxItems.Size = New System.Drawing.Size(71, 30)
        Me.ListBoxItems.TabIndex = 273
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ssInfo
        '
        Me.ssInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbInfo, Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1, Me.pbIncarca})
        Me.ssInfo.Location = New System.Drawing.Point(0, 713)
        Me.ssInfo.Name = "ssInfo"
        Me.ssInfo.Size = New System.Drawing.Size(1285, 22)
        Me.ssInfo.TabIndex = 274
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
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Timestamp_, Me.Masina_, Me.Utilizator_, Me.Km_, Me.Status_, Me.Poza_, Me.DataSiOraCitiriiKilometrajului_, Me.Asumat_, Me.Observatii_, Me.KmModificat_, Me.StatusModificat_})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 385)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1262, 325)
        Me.DataGridView1.TabIndex = 275
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
        'frmGoogleSheets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1285, 735)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ssInfo)
        Me.Controls.Add(Me.ListBoxItems)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lvOutput)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblGoogleForm)
        Me.Controls.Add(Me.txtCautareMasinaSauUtilizator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbMasiniSauUtilizatori)
        Me.Controls.Add(Me.lvSheets)
        Me.Name = "frmGoogleSheets"
        Me.Text = "frmGoogleSheets"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ssInfo.ResumeLayout(False)
        Me.ssInfo.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lvOutput As ListView
    Friend WithEvents Numar As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Foaie As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label9 As Label
    Friend WithEvents lblGoogleForm As Label
    Friend WithEvents txtCautareMasinaSauUtilizator As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbMasiniSauUtilizatori As ComboBox
    Friend WithEvents lvSheets As ListView
    Friend WithEvents Nume As ColumnHeader
    Friend WithEvents Filiala As ColumnHeader
    Friend WithEvents Activ As ColumnHeader
    Friend WithEvents SpreadsheetId As ColumnHeader
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdMasiniUtilizatori As ToolStripButton
    Friend WithEvents cmdIesire As ToolStripButton
    Friend WithEvents cmdSelecteazaTot As ToolStripButton
    Friend WithEvents cmdDeselecteazaTot As ToolStripButton
    Friend WithEvents cmdIncarcaKmLog As ToolStripButton
    Friend WithEvents cmdDeschideFoaiaGoogle As ToolStripButton
    Friend WithEvents ListBoxItems As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ssInfo As StatusStrip
    Friend WithEvents lbInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents pbIncarca As ToolStripProgressBar
    Friend WithEvents DataGridView1 As DataGridView
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
End Class
