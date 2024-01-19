<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilizatoriChange
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
        Dim NumeLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim LimitaKmLabel As System.Windows.Forms.Label
        Dim FilialaIdLabel As System.Windows.Forms.Label
        Dim ActivLabel As System.Windows.Forms.Label
        Dim RetinereLabel As System.Windows.Forms.Label
        Dim EmailConsolightLabel As System.Windows.Forms.Label
        Dim DeObiceiFolosesteMasinaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtilizatoriChange))
        Me.NumeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.LimitaKmTextBox = New System.Windows.Forms.TextBox()
        Me.ActivComboBox = New System.Windows.Forms.ComboBox()
        Me.RetinereComboBox = New System.Windows.Forms.ComboBox()
        Me.DeObiceiFolosesteMasinaComboBox = New System.Windows.Forms.ComboBox()
        Me.EmailConsolightTextBox = New System.Windows.Forms.TextBox()
        Me.AliasTextBox = New System.Windows.Forms.TextBox()
        Me.ObservatiiTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonTextBox = New System.Windows.Forms.TextBox()
        Me.cmbFiliala = New System.Windows.Forms.ComboBox()
        Me.FilialeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KmAutoDataSet = New KmAutoInterface.KmAutoDataSet()
        Me.FilialeTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.FilialeTableAdapter()
        Me.cmdSalveaza = New System.Windows.Forms.Button()
        Me.cmdIesire = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NumeAngajatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AUseriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsolightDataSet = New KmAutoInterface.ConsolightDataSet()
        Me.A_UseriTableAdapter = New KmAutoInterface.ConsolightDataSetTableAdapters.A_UseriTableAdapter()
        Me.cmdCompleteazaAliasDinERP = New System.Windows.Forms.Button()
        Me.ckOpereazaSiInGoogle = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        NumeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        LimitaKmLabel = New System.Windows.Forms.Label()
        FilialaIdLabel = New System.Windows.Forms.Label()
        ActivLabel = New System.Windows.Forms.Label()
        RetinereLabel = New System.Windows.Forms.Label()
        EmailConsolightLabel = New System.Windows.Forms.Label()
        DeObiceiFolosesteMasinaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.FilialeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AUseriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsolightDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumeLabel
        '
        NumeLabel.AutoSize = True
        NumeLabel.Location = New System.Drawing.Point(20, 15)
        NumeLabel.Name = "NumeLabel"
        NumeLabel.Size = New System.Drawing.Size(38, 13)
        NumeLabel.TabIndex = 3
        NumeLabel.Text = "Nume:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(20, 41)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 5
        EmailLabel.Text = "Email:"
        '
        'LimitaKmLabel
        '
        LimitaKmLabel.AutoSize = True
        LimitaKmLabel.Location = New System.Drawing.Point(20, 69)
        LimitaKmLabel.Name = "LimitaKmLabel"
        LimitaKmLabel.Size = New System.Drawing.Size(55, 13)
        LimitaKmLabel.TabIndex = 9
        LimitaKmLabel.Text = "Limita Km:"
        '
        'FilialaIdLabel
        '
        FilialaIdLabel.AutoSize = True
        FilialaIdLabel.Location = New System.Drawing.Point(20, 95)
        FilialaIdLabel.Name = "FilialaIdLabel"
        FilialaIdLabel.Size = New System.Drawing.Size(36, 13)
        FilialaIdLabel.TabIndex = 11
        FilialaIdLabel.Text = "Filiala:"
        '
        'ActivLabel
        '
        ActivLabel.AutoSize = True
        ActivLabel.Location = New System.Drawing.Point(20, 277)
        ActivLabel.Name = "ActivLabel"
        ActivLabel.Size = New System.Drawing.Size(34, 13)
        ActivLabel.TabIndex = 13
        ActivLabel.Text = "Activ:"
        '
        'RetinereLabel
        '
        RetinereLabel.AutoSize = True
        RetinereLabel.Location = New System.Drawing.Point(20, 122)
        RetinereLabel.Name = "RetinereLabel"
        RetinereLabel.Size = New System.Drawing.Size(50, 13)
        RetinereLabel.TabIndex = 15
        RetinereLabel.Text = "Retinere:"
        '
        'EmailConsolightLabel
        '
        EmailConsolightLabel.AutoSize = True
        EmailConsolightLabel.Location = New System.Drawing.Point(20, 148)
        EmailConsolightLabel.Name = "EmailConsolightLabel"
        EmailConsolightLabel.Size = New System.Drawing.Size(87, 13)
        EmailConsolightLabel.TabIndex = 17
        EmailConsolightLabel.Text = "Email Consolight:"
        '
        'DeObiceiFolosesteMasinaLabel
        '
        DeObiceiFolosesteMasinaLabel.AutoSize = True
        DeObiceiFolosesteMasinaLabel.Location = New System.Drawing.Point(20, 174)
        DeObiceiFolosesteMasinaLabel.Name = "DeObiceiFolosesteMasinaLabel"
        DeObiceiFolosesteMasinaLabel.Size = New System.Drawing.Size(142, 13)
        DeObiceiFolosesteMasinaLabel.TabIndex = 19
        DeObiceiFolosesteMasinaLabel.Text = "De Obicei Foloseste Masina:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(20, 201)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(29, 13)
        Label1.TabIndex = 236
        Label1.Text = "Alias"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(20, 227)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(54, 13)
        Label2.TabIndex = 238
        Label2.Text = "Observatii"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(20, 253)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(43, 13)
        Label3.TabIndex = 240
        Label3.Text = "Telefon"
        '
        'NumeTextBox
        '
        Me.NumeTextBox.Location = New System.Drawing.Point(182, 12)
        Me.NumeTextBox.Name = "NumeTextBox"
        Me.NumeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NumeTextBox.TabIndex = 0
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(182, 38)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailTextBox.TabIndex = 1
        '
        'LimitaKmTextBox
        '
        Me.LimitaKmTextBox.Location = New System.Drawing.Point(182, 66)
        Me.LimitaKmTextBox.Name = "LimitaKmTextBox"
        Me.LimitaKmTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LimitaKmTextBox.TabIndex = 2
        '
        'ActivComboBox
        '
        Me.ActivComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ActivComboBox.FormattingEnabled = True
        Me.ActivComboBox.Items.AddRange(New Object() {"Da", "Nu"})
        Me.ActivComboBox.Location = New System.Drawing.Point(182, 274)
        Me.ActivComboBox.Name = "ActivComboBox"
        Me.ActivComboBox.Size = New System.Drawing.Size(69, 21)
        Me.ActivComboBox.TabIndex = 12
        '
        'RetinereComboBox
        '
        Me.RetinereComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RetinereComboBox.FormattingEnabled = True
        Me.RetinereComboBox.Items.AddRange(New Object() {"Da", "Nu"})
        Me.RetinereComboBox.Location = New System.Drawing.Point(182, 119)
        Me.RetinereComboBox.Name = "RetinereComboBox"
        Me.RetinereComboBox.Size = New System.Drawing.Size(69, 21)
        Me.RetinereComboBox.TabIndex = 5
        '
        'DeObiceiFolosesteMasinaComboBox
        '
        Me.DeObiceiFolosesteMasinaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DeObiceiFolosesteMasinaComboBox.FormattingEnabled = True
        Me.DeObiceiFolosesteMasinaComboBox.Items.AddRange(New Object() {"Da", "Nu"})
        Me.DeObiceiFolosesteMasinaComboBox.Location = New System.Drawing.Point(182, 171)
        Me.DeObiceiFolosesteMasinaComboBox.Name = "DeObiceiFolosesteMasinaComboBox"
        Me.DeObiceiFolosesteMasinaComboBox.Size = New System.Drawing.Size(69, 21)
        Me.DeObiceiFolosesteMasinaComboBox.TabIndex = 7
        '
        'EmailConsolightTextBox
        '
        Me.EmailConsolightTextBox.Location = New System.Drawing.Point(182, 145)
        Me.EmailConsolightTextBox.Name = "EmailConsolightTextBox"
        Me.EmailConsolightTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EmailConsolightTextBox.TabIndex = 6
        '
        'AliasTextBox
        '
        Me.AliasTextBox.Location = New System.Drawing.Point(182, 198)
        Me.AliasTextBox.Name = "AliasTextBox"
        Me.AliasTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AliasTextBox.TabIndex = 9
        '
        'ObservatiiTextBox
        '
        Me.ObservatiiTextBox.Location = New System.Drawing.Point(182, 224)
        Me.ObservatiiTextBox.Name = "ObservatiiTextBox"
        Me.ObservatiiTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ObservatiiTextBox.TabIndex = 10
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.Location = New System.Drawing.Point(182, 250)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TelefonTextBox.TabIndex = 11
        '
        'cmbFiliala
        '
        Me.cmbFiliala.DataSource = Me.FilialeBindingSource
        Me.cmbFiliala.DisplayMember = "Nume"
        Me.cmbFiliala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiliala.FormattingEnabled = True
        Me.cmbFiliala.Location = New System.Drawing.Point(182, 92)
        Me.cmbFiliala.Name = "cmbFiliala"
        Me.cmbFiliala.Size = New System.Drawing.Size(200, 21)
        Me.cmbFiliala.TabIndex = 3
        Me.cmbFiliala.ValueMember = "id"
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
        'FilialeTableAdapter
        '
        Me.FilialeTableAdapter.ClearBeforeFill = True
        '
        'cmdSalveaza
        '
        Me.cmdSalveaza.BackgroundImage = CType(resources.GetObject("cmdSalveaza.BackgroundImage"), System.Drawing.Image)
        Me.cmdSalveaza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdSalveaza.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSalveaza.Location = New System.Drawing.Point(182, 336)
        Me.cmdSalveaza.Name = "cmdSalveaza"
        Me.cmdSalveaza.Size = New System.Drawing.Size(92, 91)
        Me.cmdSalveaza.TabIndex = 13
        Me.cmdSalveaza.Text = "Salveaza"
        Me.cmdSalveaza.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalveaza.UseVisualStyleBackColor = True
        '
        'cmdIesire
        '
        Me.cmdIesire.BackgroundImage = CType(resources.GetObject("cmdIesire.BackgroundImage"), System.Drawing.Image)
        Me.cmdIesire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdIesire.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdIesire.Location = New System.Drawing.Point(290, 336)
        Me.cmdIesire.Name = "cmdIesire"
        Me.cmdIesire.Size = New System.Drawing.Size(92, 91)
        Me.cmdIesire.TabIndex = 244
        Me.cmdIesire.Text = "Iesire"
        Me.cmdIesire.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdIesire.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeAngajatDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AUseriBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(393, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(255, 386)
        Me.DataGridView1.TabIndex = 245
        '
        'NumeAngajatDataGridViewTextBoxColumn
        '
        Me.NumeAngajatDataGridViewTextBoxColumn.DataPropertyName = "Nume_Angajat"
        Me.NumeAngajatDataGridViewTextBoxColumn.HeaderText = "Utilizatori ERP"
        Me.NumeAngajatDataGridViewTextBoxColumn.Name = "NumeAngajatDataGridViewTextBoxColumn"
        Me.NumeAngajatDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumeAngajatDataGridViewTextBoxColumn.Width = 200
        '
        'AUseriBindingSource
        '
        Me.AUseriBindingSource.DataMember = "A_Useri"
        Me.AUseriBindingSource.DataSource = Me.ConsolightDataSet
        '
        'ConsolightDataSet
        '
        Me.ConsolightDataSet.DataSetName = "ConsolightDataSet"
        Me.ConsolightDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'A_UseriTableAdapter
        '
        Me.A_UseriTableAdapter.ClearBeforeFill = True
        '
        'cmdCompleteazaAliasDinERP
        '
        Me.cmdCompleteazaAliasDinERP.Location = New System.Drawing.Point(393, 14)
        Me.cmdCompleteazaAliasDinERP.Name = "cmdCompleteazaAliasDinERP"
        Me.cmdCompleteazaAliasDinERP.Size = New System.Drawing.Size(236, 21)
        Me.cmdCompleteazaAliasDinERP.TabIndex = 247
        Me.cmdCompleteazaAliasDinERP.Text = "Completeaza Alias din ERP"
        Me.cmdCompleteazaAliasDinERP.UseVisualStyleBackColor = True
        '
        'ckOpereazaSiInGoogle
        '
        Me.ckOpereazaSiInGoogle.AutoSize = True
        Me.ckOpereazaSiInGoogle.Location = New System.Drawing.Point(23, 310)
        Me.ckOpereazaSiInGoogle.Name = "ckOpereazaSiInGoogle"
        Me.ckOpereazaSiInGoogle.Size = New System.Drawing.Size(130, 17)
        Me.ckOpereazaSiInGoogle.TabIndex = 251
        Me.ckOpereazaSiInGoogle.Text = "Opereaza si in Google"
        Me.ToolTip1.SetToolTip(Me.ckOpereazaSiInGoogle, "Daca este activ se poate adauga si daca este inactiv se poate sterge din Google")
        Me.ckOpereazaSiInGoogle.UseVisualStyleBackColor = True
        '
        'frmUtilizatoriChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 439)
        Me.Controls.Add(Me.ckOpereazaSiInGoogle)
        Me.Controls.Add(Me.cmdCompleteazaAliasDinERP)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdIesire)
        Me.Controls.Add(Me.cmdSalveaza)
        Me.Controls.Add(Me.cmbFiliala)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.ObservatiiTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.AliasTextBox)
        Me.Controls.Add(Me.EmailConsolightTextBox)
        Me.Controls.Add(Me.DeObiceiFolosesteMasinaComboBox)
        Me.Controls.Add(Me.RetinereComboBox)
        Me.Controls.Add(Me.ActivComboBox)
        Me.Controls.Add(NumeLabel)
        Me.Controls.Add(Me.NumeTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(LimitaKmLabel)
        Me.Controls.Add(Me.LimitaKmTextBox)
        Me.Controls.Add(FilialaIdLabel)
        Me.Controls.Add(ActivLabel)
        Me.Controls.Add(RetinereLabel)
        Me.Controls.Add(EmailConsolightLabel)
        Me.Controls.Add(DeObiceiFolosesteMasinaLabel)
        Me.Name = "frmUtilizatoriChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmUtilizatoriChange"
        CType(Me.FilialeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AUseriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsolightDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumeTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents LimitaKmTextBox As TextBox
    Friend WithEvents ActivComboBox As ComboBox
    Friend WithEvents RetinereComboBox As ComboBox
    Friend WithEvents DeObiceiFolosesteMasinaComboBox As ComboBox
    Friend WithEvents EmailConsolightTextBox As TextBox
    Friend WithEvents AliasTextBox As TextBox
    Friend WithEvents ObservatiiTextBox As TextBox
    Friend WithEvents TelefonTextBox As TextBox
    Friend WithEvents cmbFiliala As ComboBox
    Friend WithEvents KmAutoDataSet As KmAutoDataSet
    Friend WithEvents FilialeBindingSource As BindingSource
    Friend WithEvents FilialeTableAdapter As KmAutoDataSetTableAdapters.FilialeTableAdapter
    Friend WithEvents cmdSalveaza As Button
    Friend WithEvents cmdIesire As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ConsolightDataSet As ConsolightDataSet
    Friend WithEvents AUseriBindingSource As BindingSource
    Friend WithEvents A_UseriTableAdapter As ConsolightDataSetTableAdapters.A_UseriTableAdapter
    Friend WithEvents NumeAngajatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cmdCompleteazaAliasDinERP As Button
    Friend WithEvents ckOpereazaSiInGoogle As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
