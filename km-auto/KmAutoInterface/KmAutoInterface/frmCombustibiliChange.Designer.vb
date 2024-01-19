<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCombustibiliChange
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
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim ConsumMediuLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCombustibiliChange))
        Me.cmbTip = New System.Windows.Forms.ComboBox()
        Me.cmdIesire = New System.Windows.Forms.Button()
        Me.cmdSalveaza = New System.Windows.Forms.Button()
        Me.PretTextBox = New System.Windows.Forms.TextBox()
        Me.dtpDataSchimbariiPretului = New System.Windows.Forms.DateTimePicker()
        MarcaLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        ConsumMediuLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(14, 13)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(22, 13)
        MarcaLabel.TabIndex = 257
        MarcaLabel.Text = "Tip"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(14, 39)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(30, 13)
        ModelLabel.TabIndex = 258
        ModelLabel.Text = "Data"
        '
        'ConsumMediuLabel
        '
        ConsumMediuLabel.AutoSize = True
        ConsumMediuLabel.Location = New System.Drawing.Point(14, 65)
        ConsumMediuLabel.Name = "ConsumMediuLabel"
        ConsumMediuLabel.Size = New System.Drawing.Size(26, 13)
        ConsumMediuLabel.TabIndex = 259
        ConsumMediuLabel.Text = "Pret"
        '
        'cmbTip
        '
        Me.cmbTip.DisplayMember = "Nume"
        Me.cmbTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTip.FormattingEnabled = True
        Me.cmbTip.Items.AddRange(New Object() {"Benzina", "Motorina"})
        Me.cmbTip.Location = New System.Drawing.Point(100, 9)
        Me.cmbTip.Name = "cmbTip"
        Me.cmbTip.Size = New System.Drawing.Size(92, 21)
        Me.cmbTip.TabIndex = 249
        Me.cmbTip.ValueMember = "id"
        '
        'cmdIesire
        '
        Me.cmdIesire.BackgroundImage = CType(resources.GetObject("cmdIesire.BackgroundImage"), System.Drawing.Image)
        Me.cmdIesire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdIesire.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdIesire.Location = New System.Drawing.Point(124, 98)
        Me.cmdIesire.Name = "cmdIesire"
        Me.cmdIesire.Size = New System.Drawing.Size(92, 91)
        Me.cmdIesire.TabIndex = 263
        Me.cmdIesire.Text = "Iesire"
        Me.cmdIesire.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdIesire.UseVisualStyleBackColor = True
        '
        'cmdSalveaza
        '
        Me.cmdSalveaza.BackgroundImage = CType(resources.GetObject("cmdSalveaza.BackgroundImage"), System.Drawing.Image)
        Me.cmdSalveaza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdSalveaza.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSalveaza.Location = New System.Drawing.Point(16, 98)
        Me.cmdSalveaza.Name = "cmdSalveaza"
        Me.cmdSalveaza.Size = New System.Drawing.Size(92, 91)
        Me.cmdSalveaza.TabIndex = 256
        Me.cmdSalveaza.Text = "Salveaza"
        Me.cmdSalveaza.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalveaza.UseVisualStyleBackColor = True
        '
        'PretTextBox
        '
        Me.PretTextBox.Location = New System.Drawing.Point(100, 62)
        Me.PretTextBox.Name = "PretTextBox"
        Me.PretTextBox.Size = New System.Drawing.Size(92, 20)
        Me.PretTextBox.TabIndex = 252
        '
        'dtpDataSchimbariiPretului
        '
        Me.dtpDataSchimbariiPretului.CustomFormat = "yyyy-MM-dd"
        Me.dtpDataSchimbariiPretului.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataSchimbariiPretului.Location = New System.Drawing.Point(100, 36)
        Me.dtpDataSchimbariiPretului.Name = "dtpDataSchimbariiPretului"
        Me.dtpDataSchimbariiPretului.Size = New System.Drawing.Size(142, 20)
        Me.dtpDataSchimbariiPretului.TabIndex = 264
        Me.dtpDataSchimbariiPretului.Value = New Date(1970, 1, 1, 0, 0, 0, 0)
        '
        'frmCombustibiliChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 205)
        Me.Controls.Add(Me.dtpDataSchimbariiPretului)
        Me.Controls.Add(Me.cmbTip)
        Me.Controls.Add(Me.cmdIesire)
        Me.Controls.Add(Me.cmdSalveaza)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(ConsumMediuLabel)
        Me.Controls.Add(Me.PretTextBox)
        Me.Name = "frmCombustibiliChange"
        Me.Text = "Gestionare combustibili"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbTip As ComboBox
    Friend WithEvents cmdIesire As Button
    Friend WithEvents cmdSalveaza As Button
    Friend WithEvents PretTextBox As TextBox
    Friend WithEvents dtpDataSchimbariiPretului As DateTimePicker
End Class
