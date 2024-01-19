<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJurnal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJurnal))
        Me.txtCautareUtilizator = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbUtilizatori = New System.Windows.Forms.ComboBox()
        Me.xl1 = New System.Windows.Forms.Label()
        Me.txtCautareMasina = New System.Windows.Forms.TextBox()
        Me.cmbMasini = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtObservatii = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observatii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdKm = New System.Windows.Forms.ToolStripButton()
        Me.cmdGreseli = New System.Windows.Forms.ToolStripButton()
        Me.cmdEmail = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdMasini = New System.Windows.Forms.ToolStripButton()
        Me.cmdUtilizatori = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdIesire = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.cmdSalveaza = New System.Windows.Forms.ToolStripButton()
        Me.cmdRenunta = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditeaza = New System.Windows.Forms.ToolStripButton()
        Me.cmdAdauga = New System.Windows.Forms.ToolStripButton()
        Me.cmdSterge = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.xl9 = New System.Windows.Forms.Label()
        Me.xl8 = New System.Windows.Forms.Label()
        Me.xlFiliala = New System.Windows.Forms.Label()
        Me.xl6 = New System.Windows.Forms.Label()
        Me.chkMasina = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblFiliala = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCautareUtilizator
        '
        Me.txtCautareUtilizator.Location = New System.Drawing.Point(33, 96)
        Me.txtCautareUtilizator.Name = "txtCautareUtilizator"
        Me.txtCautareUtilizator.Size = New System.Drawing.Size(78, 20)
        Me.txtCautareUtilizator.TabIndex = 277
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(128, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 276
        Me.Label6.Text = "Utilizatorul"
        '
        'cmbUtilizatori
        '
        Me.cmbUtilizatori.DisplayMember = "Id"
        Me.cmbUtilizatori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUtilizatori.FormattingEnabled = True
        Me.cmbUtilizatori.Location = New System.Drawing.Point(201, 92)
        Me.cmbUtilizatori.Name = "cmbUtilizatori"
        Me.cmbUtilizatori.Size = New System.Drawing.Size(123, 21)
        Me.cmbUtilizatori.TabIndex = 275
        Me.cmbUtilizatori.ValueMember = "Id"
        '
        'xl1
        '
        Me.xl1.AutoSize = True
        Me.xl1.Enabled = False
        Me.xl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xl1.Location = New System.Drawing.Point(128, 125)
        Me.xl1.Name = "xl1"
        Me.xl1.Size = New System.Drawing.Size(47, 13)
        Me.xl1.TabIndex = 273
        Me.xl1.Text = "Masina"
        '
        'txtCautareMasina
        '
        Me.txtCautareMasina.Location = New System.Drawing.Point(33, 122)
        Me.txtCautareMasina.Name = "txtCautareMasina"
        Me.txtCautareMasina.Size = New System.Drawing.Size(78, 20)
        Me.txtCautareMasina.TabIndex = 271
        Me.txtCautareMasina.Visible = False
        '
        'cmbMasini
        '
        Me.cmbMasini.DisplayMember = "Id"
        Me.cmbMasini.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMasini.FormattingEnabled = True
        Me.cmbMasini.Location = New System.Drawing.Point(201, 121)
        Me.cmbMasini.Name = "cmbMasini"
        Me.cmbMasini.Size = New System.Drawing.Size(123, 21)
        Me.cmbMasini.TabIndex = 274
        Me.cmbMasini.ValueMember = "Id"
        Me.cmbMasini.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 279
        Me.Label1.Text = "Comentariu"
        '
        'txtObservatii
        '
        Me.txtObservatii.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservatii.Location = New System.Drawing.Point(88, 187)
        Me.txtObservatii.Multiline = True
        Me.txtObservatii.Name = "txtObservatii"
        Me.txtObservatii.Size = New System.Drawing.Size(959, 59)
        Me.txtObservatii.TabIndex = 280
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Data, Me.Nume, Me.Numar, Me.Observatii})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 252)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1035, 397)
        Me.DataGridView1.TabIndex = 283
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        '
        'Nume
        '
        Me.Nume.HeaderText = "Nume"
        Me.Nume.Name = "Nume"
        '
        'Numar
        '
        Me.Numar.HeaderText = "Numar"
        Me.Numar.Name = "Numar"
        '
        'Observatii
        '
        Me.Observatii.HeaderText = "Observatii"
        Me.Observatii.Name = "Observatii"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdKm, Me.cmdGreseli, Me.cmdEmail, Me.ToolStripSeparator2, Me.cmdMasini, Me.cmdUtilizatori, Me.ToolStripSeparator1, Me.cmdIesire, Me.ToolStripTextBox1, Me.cmdSalveaza, Me.cmdRenunta, Me.cmdEditeaza, Me.cmdAdauga, Me.cmdSterge})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1038, 80)
        Me.ToolStrip1.TabIndex = 284
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
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 80)
        '
        'cmdSalveaza
        '
        Me.cmdSalveaza.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdSalveaza.Image = CType(resources.GetObject("cmdSalveaza.Image"), System.Drawing.Image)
        Me.cmdSalveaza.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalveaza.Name = "cmdSalveaza"
        Me.cmdSalveaza.Size = New System.Drawing.Size(68, 77)
        Me.cmdSalveaza.Text = "Salveaza"
        Me.cmdSalveaza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdRenunta
        '
        Me.cmdRenunta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdRenunta.Image = CType(resources.GetObject("cmdRenunta.Image"), System.Drawing.Image)
        Me.cmdRenunta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRenunta.Name = "cmdRenunta"
        Me.cmdRenunta.Size = New System.Drawing.Size(68, 77)
        Me.cmdRenunta.Text = "Renunta"
        Me.cmdRenunta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdEditeaza
        '
        Me.cmdEditeaza.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdEditeaza.Image = CType(resources.GetObject("cmdEditeaza.Image"), System.Drawing.Image)
        Me.cmdEditeaza.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditeaza.Name = "cmdEditeaza"
        Me.cmdEditeaza.Size = New System.Drawing.Size(68, 77)
        Me.cmdEditeaza.Text = "Editeaza"
        Me.cmdEditeaza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdAdauga
        '
        Me.cmdAdauga.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdAdauga.Image = CType(resources.GetObject("cmdAdauga.Image"), System.Drawing.Image)
        Me.cmdAdauga.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdauga.Name = "cmdAdauga"
        Me.cmdAdauga.Size = New System.Drawing.Size(68, 77)
        Me.cmdAdauga.Text = "Adauga"
        Me.cmdAdauga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdSterge
        '
        Me.cmdSterge.Image = CType(resources.GetObject("cmdSterge.Image"), System.Drawing.Image)
        Me.cmdSterge.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSterge.Name = "cmdSterge"
        Me.cmdSterge.Size = New System.Drawing.Size(68, 77)
        Me.cmdSterge.Text = "Sterge"
        Me.cmdSterge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(657, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 285
        Me.Label2.Text = "Observatii utilizator"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(507, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 287
        Me.Label8.Text = "Telefon"
        '
        'xl9
        '
        Me.xl9.AutoSize = True
        Me.xl9.Enabled = False
        Me.xl9.Location = New System.Drawing.Point(513, 123)
        Me.xl9.Name = "xl9"
        Me.xl9.Size = New System.Drawing.Size(37, 13)
        Me.xl9.TabIndex = 289
        Me.xl9.Text = "Marca"
        '
        'xl8
        '
        Me.xl8.AutoSize = True
        Me.xl8.Enabled = False
        Me.xl8.Location = New System.Drawing.Point(588, 122)
        Me.xl8.Name = "xl8"
        Me.xl8.Size = New System.Drawing.Size(36, 13)
        Me.xl8.TabIndex = 291
        Me.xl8.Text = "Model"
        '
        'xlFiliala
        '
        Me.xlFiliala.AutoSize = True
        Me.xlFiliala.Enabled = False
        Me.xlFiliala.Location = New System.Drawing.Point(394, 125)
        Me.xlFiliala.Name = "xlFiliala"
        Me.xlFiliala.Size = New System.Drawing.Size(69, 13)
        Me.xlFiliala.TabIndex = 293
        Me.xlFiliala.Text = "Filiala masina"
        '
        'xl6
        '
        Me.xl6.AutoSize = True
        Me.xl6.Enabled = False
        Me.xl6.Location = New System.Drawing.Point(657, 122)
        Me.xl6.Name = "xl6"
        Me.xl6.Size = New System.Drawing.Size(90, 13)
        Me.xl6.TabIndex = 295
        Me.xl6.Text = "Observatii masina"
        '
        'chkMasina
        '
        Me.chkMasina.AutoSize = True
        Me.chkMasina.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMasina.Location = New System.Drawing.Point(33, 152)
        Me.chkMasina.Name = "chkMasina"
        Me.chkMasina.Size = New System.Drawing.Size(218, 29)
        Me.chkMasina.TabIndex = 297
        Me.chkMasina.Text = "Adauga si masina"
        Me.chkMasina.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 300
        '
        'lblFiliala
        '
        Me.lblFiliala.AutoSize = True
        Me.lblFiliala.Location = New System.Drawing.Point(394, 96)
        Me.lblFiliala.Name = "lblFiliala"
        Me.lblFiliala.Size = New System.Drawing.Size(74, 13)
        Me.lblFiliala.TabIndex = 298
        Me.lblFiliala.Text = "Filiala utilizator"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'frmJurnal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 661)
        Me.Controls.Add(Me.lblFiliala)
        Me.Controls.Add(Me.txtObservatii)
        Me.Controls.Add(Me.chkMasina)
        Me.Controls.Add(Me.xl6)
        Me.Controls.Add(Me.xlFiliala)
        Me.Controls.Add(Me.xl8)
        Me.Controls.Add(Me.xl9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCautareUtilizator)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbUtilizatori)
        Me.Controls.Add(Me.xl1)
        Me.Controls.Add(Me.txtCautareMasina)
        Me.Controls.Add(Me.cmbMasini)
        Me.Name = "frmJurnal"
        Me.Text = "frmJurnal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCautareUtilizator As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbUtilizatori As ComboBox
    Friend WithEvents xl1 As Label
    Friend WithEvents txtCautareMasina As TextBox
    Friend WithEvents cmbMasini As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtObservatii As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdKm As ToolStripButton
    Friend WithEvents cmdGreseli As ToolStripButton
    Friend WithEvents cmdEmail As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmdMasini As ToolStripButton
    Friend WithEvents cmdUtilizatori As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdIesire As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents xl9 As Label
    Friend WithEvents xl8 As Label
    Friend WithEvents xlFiliala As Label
    Friend WithEvents xl6 As Label
    Friend WithEvents chkMasina As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblFiliala As Label
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Nume As DataGridViewTextBoxColumn
    Friend WithEvents Numar As DataGridViewTextBoxColumn
    Friend WithEvents Observatii As DataGridViewTextBoxColumn
    Friend WithEvents cmdAdauga As ToolStripButton
    Friend WithEvents cmdEditeaza As ToolStripButton
    Friend WithEvents cmdRenunta As ToolStripButton
    Friend WithEvents cmdSalveaza As ToolStripButton
    Friend WithEvents Timer2 As Timer
    Friend WithEvents cmdSterge As ToolStripButton
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
End Class
