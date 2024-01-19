<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasiniChange
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
        Dim NumarLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim ConsumMediuLabel As System.Windows.Forms.Label
        Dim FilialaIdLabel As System.Windows.Forms.Label
        Dim CarburantLabel As System.Windows.Forms.Label
        Dim ActivLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMasiniChange))
        Me.NumarTextBox = New System.Windows.Forms.TextBox()
        Me.ConsumMediuTextBox = New System.Windows.Forms.TextBox()
        Me.cmdIesire = New System.Windows.Forms.Button()
        Me.cmdSalveaza = New System.Windows.Forms.Button()
        Me.cmbFiliala = New System.Windows.Forms.ComboBox()
        Me.FilialeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KmAutoDataSet = New KmAutoInterface.KmAutoDataSet()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.FilialeTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.FilialeTableAdapter()
        Me.ActivComboBox = New System.Windows.Forms.ComboBox()
        Me.cmbCarburant = New System.Windows.Forms.ComboBox()
        Me.ObservatiiTextBox = New System.Windows.Forms.TextBox()
        Me.ckOpereazaSiInGoogle = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        NumarLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        ConsumMediuLabel = New System.Windows.Forms.Label()
        FilialaIdLabel = New System.Windows.Forms.Label()
        CarburantLabel = New System.Windows.Forms.Label()
        ActivLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.FilialeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumarLabel
        '
        NumarLabel.AutoSize = True
        NumarLabel.Location = New System.Drawing.Point(21, 15)
        NumarLabel.Name = "NumarLabel"
        NumarLabel.Size = New System.Drawing.Size(41, 13)
        NumarLabel.TabIndex = 3
        NumarLabel.Text = "Numar:"
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(21, 46)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(40, 13)
        MarcaLabel.TabIndex = 7
        MarcaLabel.Text = "Marca:"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(21, 72)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(39, 13)
        ModelLabel.TabIndex = 9
        ModelLabel.Text = "Model:"
        '
        'ConsumMediuLabel
        '
        ConsumMediuLabel.AutoSize = True
        ConsumMediuLabel.Location = New System.Drawing.Point(21, 98)
        ConsumMediuLabel.Name = "ConsumMediuLabel"
        ConsumMediuLabel.Size = New System.Drawing.Size(80, 13)
        ConsumMediuLabel.TabIndex = 11
        ConsumMediuLabel.Text = "Consum Mediu:"
        '
        'FilialaIdLabel
        '
        FilialaIdLabel.AutoSize = True
        FilialaIdLabel.Location = New System.Drawing.Point(21, 124)
        FilialaIdLabel.Name = "FilialaIdLabel"
        FilialaIdLabel.Size = New System.Drawing.Size(36, 13)
        FilialaIdLabel.TabIndex = 13
        FilialaIdLabel.Text = "Filiala:"
        '
        'CarburantLabel
        '
        CarburantLabel.AutoSize = True
        CarburantLabel.Location = New System.Drawing.Point(21, 150)
        CarburantLabel.Name = "CarburantLabel"
        CarburantLabel.Size = New System.Drawing.Size(56, 13)
        CarburantLabel.TabIndex = 15
        CarburantLabel.Text = "Carburant:"
        '
        'ActivLabel
        '
        ActivLabel.AutoSize = True
        ActivLabel.Location = New System.Drawing.Point(21, 176)
        ActivLabel.Name = "ActivLabel"
        ActivLabel.Size = New System.Drawing.Size(34, 13)
        ActivLabel.TabIndex = 17
        ActivLabel.Text = "Activ:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(21, 203)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(57, 13)
        Label1.TabIndex = 249
        Label1.Text = "Observatii:"
        '
        'NumarTextBox
        '
        Me.NumarTextBox.Location = New System.Drawing.Point(107, 12)
        Me.NumarTextBox.Name = "NumarTextBox"
        Me.NumarTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NumarTextBox.TabIndex = 0
        '
        'ConsumMediuTextBox
        '
        Me.ConsumMediuTextBox.Location = New System.Drawing.Point(107, 95)
        Me.ConsumMediuTextBox.Name = "ConsumMediuTextBox"
        Me.ConsumMediuTextBox.Size = New System.Drawing.Size(92, 20)
        Me.ConsumMediuTextBox.TabIndex = 3
        '
        'cmdIesire
        '
        Me.cmdIesire.BackgroundImage = CType(resources.GetObject("cmdIesire.BackgroundImage"), System.Drawing.Image)
        Me.cmdIesire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdIesire.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdIesire.Location = New System.Drawing.Point(215, 290)
        Me.cmdIesire.Name = "cmdIesire"
        Me.cmdIesire.Size = New System.Drawing.Size(92, 91)
        Me.cmdIesire.TabIndex = 247
        Me.cmdIesire.Text = "Iesire"
        Me.cmdIesire.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdIesire.UseVisualStyleBackColor = True
        '
        'cmdSalveaza
        '
        Me.cmdSalveaza.BackgroundImage = CType(resources.GetObject("cmdSalveaza.BackgroundImage"), System.Drawing.Image)
        Me.cmdSalveaza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdSalveaza.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSalveaza.Location = New System.Drawing.Point(107, 290)
        Me.cmdSalveaza.Name = "cmdSalveaza"
        Me.cmdSalveaza.Size = New System.Drawing.Size(92, 91)
        Me.cmdSalveaza.TabIndex = 7
        Me.cmdSalveaza.Text = "Salveaza"
        Me.cmdSalveaza.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalveaza.UseVisualStyleBackColor = True
        '
        'cmbFiliala
        '
        Me.cmbFiliala.DataSource = Me.FilialeBindingSource
        Me.cmbFiliala.DisplayMember = "Nume"
        Me.cmbFiliala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiliala.FormattingEnabled = True
        Me.cmbFiliala.Location = New System.Drawing.Point(107, 120)
        Me.cmbFiliala.Name = "cmbFiliala"
        Me.cmbFiliala.Size = New System.Drawing.Size(200, 21)
        Me.cmbFiliala.TabIndex = 4
        Me.cmbFiliala.ValueMember = "Id"
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
        'cmbMarca
        '
        Me.cmbMarca.DisplayMember = "Nume"
        Me.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Items.AddRange(New Object() {"Peugeot", "Ford", "Skoda", "Audi"})
        Me.cmbMarca.Location = New System.Drawing.Point(107, 42)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(92, 21)
        Me.cmbMarca.TabIndex = 1
        Me.cmbMarca.ValueMember = "id"
        '
        'cmbModel
        '
        Me.cmbModel.DisplayMember = "Nume"
        Me.cmbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Items.AddRange(New Object() {"308", "Focus", "Kodiaq", "Transit", "A7", "Boxer", "Octavia", "Partner", "Scala", "308", "Superb", "508", "208", "Mondeo", "Fabia", "301"})
        Me.cmbModel.Location = New System.Drawing.Point(107, 69)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(92, 21)
        Me.cmbModel.TabIndex = 2
        Me.cmbModel.ValueMember = "id"
        '
        'FilialeTableAdapter
        '
        Me.FilialeTableAdapter.ClearBeforeFill = True
        '
        'ActivComboBox
        '
        Me.ActivComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ActivComboBox.FormattingEnabled = True
        Me.ActivComboBox.Items.AddRange(New Object() {"Da", "Nu"})
        Me.ActivComboBox.Location = New System.Drawing.Point(107, 173)
        Me.ActivComboBox.Name = "ActivComboBox"
        Me.ActivComboBox.Size = New System.Drawing.Size(69, 21)
        Me.ActivComboBox.TabIndex = 6
        '
        'cmbCarburant
        '
        Me.cmbCarburant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCarburant.FormattingEnabled = True
        Me.cmbCarburant.Items.AddRange(New Object() {"Benzina", "Motorina"})
        Me.cmbCarburant.Location = New System.Drawing.Point(107, 147)
        Me.cmbCarburant.Name = "cmbCarburant"
        Me.cmbCarburant.Size = New System.Drawing.Size(69, 21)
        Me.cmbCarburant.TabIndex = 5
        '
        'ObservatiiTextBox
        '
        Me.ObservatiiTextBox.Location = New System.Drawing.Point(107, 200)
        Me.ObservatiiTextBox.MaxLength = 29
        Me.ObservatiiTextBox.Multiline = True
        Me.ObservatiiTextBox.Name = "ObservatiiTextBox"
        Me.ObservatiiTextBox.Size = New System.Drawing.Size(200, 23)
        Me.ObservatiiTextBox.TabIndex = 248
        '
        'ckOpereazaSiInGoogle
        '
        Me.ckOpereazaSiInGoogle.AutoSize = True
        Me.ckOpereazaSiInGoogle.Location = New System.Drawing.Point(24, 261)
        Me.ckOpereazaSiInGoogle.Name = "ckOpereazaSiInGoogle"
        Me.ckOpereazaSiInGoogle.Size = New System.Drawing.Size(130, 17)
        Me.ckOpereazaSiInGoogle.TabIndex = 250
        Me.ckOpereazaSiInGoogle.Text = "Opereaza si in Google"
        Me.ToolTip1.SetToolTip(Me.ckOpereazaSiInGoogle, "Daca este activ se poate adauga si daca este inactiv se poate sterge din Google")
        Me.ckOpereazaSiInGoogle.UseVisualStyleBackColor = True
        '
        'frmMasiniChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 405)
        Me.Controls.Add(Me.ckOpereazaSiInGoogle)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ObservatiiTextBox)
        Me.Controls.Add(Me.cmbCarburant)
        Me.Controls.Add(Me.ActivComboBox)
        Me.Controls.Add(Me.cmbModel)
        Me.Controls.Add(Me.cmbMarca)
        Me.Controls.Add(Me.cmbFiliala)
        Me.Controls.Add(Me.cmdIesire)
        Me.Controls.Add(Me.cmdSalveaza)
        Me.Controls.Add(NumarLabel)
        Me.Controls.Add(Me.NumarTextBox)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(ConsumMediuLabel)
        Me.Controls.Add(Me.ConsumMediuTextBox)
        Me.Controls.Add(FilialaIdLabel)
        Me.Controls.Add(CarburantLabel)
        Me.Controls.Add(ActivLabel)
        Me.Name = "frmMasiniChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMasiniChange"
        CType(Me.FilialeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumarTextBox As TextBox
    Friend WithEvents ConsumMediuTextBox As TextBox
    Friend WithEvents cmdIesire As Button
    Friend WithEvents cmdSalveaza As Button
    Friend WithEvents cmbFiliala As ComboBox
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents cmbModel As ComboBox
    Friend WithEvents KmAutoDataSet As KmAutoDataSet
    Friend WithEvents FilialeBindingSource As BindingSource
    Friend WithEvents FilialeTableAdapter As KmAutoDataSetTableAdapters.FilialeTableAdapter
    Friend WithEvents ActivComboBox As ComboBox
    Friend WithEvents cmbCarburant As ComboBox
    Friend WithEvents ObservatiiTextBox As TextBox
    Friend WithEvents ckOpereazaSiInGoogle As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
