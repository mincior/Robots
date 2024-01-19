<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGreseliLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGreseliLog))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Filiala = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Utilizator_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Interval = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntervalComplet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.checkPrimaInregistrareNuEReferinta = New System.Windows.Forms.CheckBox()
        Me.checkToateInregistrarileSuntReferinta = New System.Windows.Forms.CheckBox()
        Me.checkDouaInregistrariAdiacenteReferinta = New System.Windows.Forms.CheckBox()
        Me.checkToateInregistrarileSuntInteresServiciu = New System.Windows.Forms.CheckBox()
        Me.checkZeroInregistrari = New System.Windows.Forms.CheckBox()
        Me.checkIndexeInversate = New System.Windows.Forms.CheckBox()
        Me.checkKmPreaMulti = New System.Windows.Forms.CheckBox()
        Me.checkOSinguraInregistrare = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdSelecteazaTot = New System.Windows.Forms.Button()
        Me.cmdDeselecteazaTot = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblToateInregistrarileSuntReferintaU = New System.Windows.Forms.Label()
        Me.lblToateInregistrarileSuntInteresServiciuU = New System.Windows.Forms.Label()
        Me.lblDouaInregistrariAdiacenteReferintaU = New System.Windows.Forms.Label()
        Me.lblPrimaInregistrareNuEReferintaU = New System.Windows.Forms.Label()
        Me.lblIndexeInversateU = New System.Windows.Forms.Label()
        Me.lblKmPreaMultiU = New System.Windows.Forms.Label()
        Me.lblOSinguraInregistrareU = New System.Windows.Forms.Label()
        Me.lblZeroInregistrariU = New System.Windows.Forms.Label()
        Me.lblToateInregistrarileSuntReferintaT = New System.Windows.Forms.Label()
        Me.lblToateInregistrarileSuntInteresServiciuT = New System.Windows.Forms.Label()
        Me.lblDouaInregistrariAdiacenteReferintaT = New System.Windows.Forms.Label()
        Me.lblPrimaInregistrareNuEReferintaT = New System.Windows.Forms.Label()
        Me.lblIndexeInversateT = New System.Windows.Forms.Label()
        Me.lblKmPreaMultiT = New System.Windows.Forms.Label()
        Me.lblOSinguraInregistrareT = New System.Windows.Forms.Label()
        Me.lblZeroInregistrariT = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdStergeListaCautare = New System.Windows.Forms.Button()
        Me.cmdStergeCrt = New System.Windows.Forms.Button()
        Me.cmdTrimitereEmailuri = New System.Windows.Forms.Button()
        Me.cmdTrimiteEmailCatre = New System.Windows.Forms.Button()
        Me.cmdSalveazaInSablonulCurent = New System.Windows.Forms.Button()
        Me.cmdDeschideSablonul = New System.Windows.Forms.Button()
        Me.cmdTrimiteEmailSelectie = New System.Windows.Forms.Button()
        Me.cmbIntervale = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Utiliz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblEmailuri = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Utilizator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Masina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Km = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KmModificat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusModificat = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Spreadsheet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSiOraCitirii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asumat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observatii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelNumarInregistrariSt = New System.Windows.Forms.Label()
        Me.lblCompletareInutilaADateiDeIntroducereU = New System.Windows.Forms.Label()
        Me.lblCompletareInutilaADateiDeIntroducereT = New System.Windows.Forms.Label()
        Me.checkCompletareInutilaADateiDeIntroducere = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbCautare = New System.Windows.Forms.ComboBox()
        Me.txtContinutEmail = New System.Windows.Forms.TextBox()
        Me.KmAutoDataSet = New KmAutoInterface.KmAutoDataSet()
        Me.cmdDeschideSpreadsheet = New System.Windows.Forms.Button()
        Me.cmbSpreadsheets = New System.Windows.Forms.ComboBox()
        Me.SpreadsheetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UtilizatoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UtilizatoriTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.UtilizatoriTableAdapter()
        Me.ssInfo = New System.Windows.Forms.StatusStrip()
        Me.lbInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbIncarca = New System.Windows.Forms.ToolStripProgressBar()
        Me.SpreadsheetsTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.SpreadsheetsTableAdapter()
        Me.cmdCautaTot = New System.Windows.Forms.Button()
        Me.cmdRefreshCautareCurenta = New System.Windows.Forms.Button()
        Me.cmbSabloaneEmail = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpreadsheetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilizatoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ssInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Filiala, Me.Utilizator_, Me.Interval, Me.Tip, Me.Numar, Me.IntervalComplet, Me.Telefon, Me.Email_})
        Me.DataGridView1.Location = New System.Drawing.Point(19, 410)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(610, 263)
        Me.DataGridView1.TabIndex = 17
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'Filiala
        '
        Me.Filiala.HeaderText = "Filiala"
        Me.Filiala.Name = "Filiala"
        Me.Filiala.ReadOnly = True
        '
        'Utilizator_
        '
        Me.Utilizator_.HeaderText = "Utilizator"
        Me.Utilizator_.Name = "Utilizator_"
        Me.Utilizator_.ReadOnly = True
        '
        'Interval
        '
        Me.Interval.HeaderText = "Interval"
        Me.Interval.Name = "Interval"
        Me.Interval.ReadOnly = True
        '
        'Tip
        '
        Me.Tip.HeaderText = "Greseala"
        Me.Tip.Name = "Tip"
        Me.Tip.ReadOnly = True
        '
        'Numar
        '
        Me.Numar.HeaderText = "Masina"
        Me.Numar.Name = "Numar"
        Me.Numar.ReadOnly = True
        '
        'IntervalComplet
        '
        Me.IntervalComplet.HeaderText = "IntervalComplet"
        Me.IntervalComplet.Name = "IntervalComplet"
        Me.IntervalComplet.ReadOnly = True
        '
        'Telefon
        '
        Me.Telefon.HeaderText = "Telefon"
        Me.Telefon.Name = "Telefon"
        Me.Telefon.ReadOnly = True
        '
        'Email_
        '
        Me.Email_.HeaderText = "Email"
        Me.Email_.Name = "Email_"
        Me.Email_.ReadOnly = True
        '
        'checkPrimaInregistrareNuEReferinta
        '
        Me.checkPrimaInregistrareNuEReferinta.AutoSize = True
        Me.checkPrimaInregistrareNuEReferinta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkPrimaInregistrareNuEReferinta.Location = New System.Drawing.Point(12, 131)
        Me.checkPrimaInregistrareNuEReferinta.Name = "checkPrimaInregistrareNuEReferinta"
        Me.checkPrimaInregistrareNuEReferinta.Size = New System.Drawing.Size(216, 20)
        Me.checkPrimaInregistrareNuEReferinta.TabIndex = 16
        Me.checkPrimaInregistrareNuEReferinta.Tag = "5"
        Me.checkPrimaInregistrareNuEReferinta.Text = "Prima inregistrare nu e Referinta"
        Me.checkPrimaInregistrareNuEReferinta.UseVisualStyleBackColor = True
        '
        'checkToateInregistrarileSuntReferinta
        '
        Me.checkToateInregistrarileSuntReferinta.AutoSize = True
        Me.checkToateInregistrarileSuntReferinta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkToateInregistrarileSuntReferinta.Location = New System.Drawing.Point(12, 209)
        Me.checkToateInregistrarileSuntReferinta.Name = "checkToateInregistrarileSuntReferinta"
        Me.checkToateInregistrarileSuntReferinta.Size = New System.Drawing.Size(222, 20)
        Me.checkToateInregistrarileSuntReferinta.TabIndex = 15
        Me.checkToateInregistrarileSuntReferinta.Tag = "6"
        Me.checkToateInregistrarileSuntReferinta.Text = "Toate inregistrarile sunt Referinta"
        Me.checkToateInregistrarileSuntReferinta.UseVisualStyleBackColor = True
        '
        'checkDouaInregistrariAdiacenteReferinta
        '
        Me.checkDouaInregistrariAdiacenteReferinta.AutoSize = True
        Me.checkDouaInregistrariAdiacenteReferinta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkDouaInregistrariAdiacenteReferinta.Location = New System.Drawing.Point(12, 157)
        Me.checkDouaInregistrariAdiacenteReferinta.Name = "checkDouaInregistrariAdiacenteReferinta"
        Me.checkDouaInregistrariAdiacenteReferinta.Size = New System.Drawing.Size(241, 20)
        Me.checkDouaInregistrariAdiacenteReferinta.TabIndex = 14
        Me.checkDouaInregistrariAdiacenteReferinta.Tag = "11"
        Me.checkDouaInregistrariAdiacenteReferinta.Text = "Doua inregisrari adiacente Referinta"
        Me.checkDouaInregistrariAdiacenteReferinta.UseVisualStyleBackColor = True
        '
        'checkToateInregistrarileSuntInteresServiciu
        '
        Me.checkToateInregistrarileSuntInteresServiciu.AutoSize = True
        Me.checkToateInregistrarileSuntInteresServiciu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkToateInregistrarileSuntInteresServiciu.Location = New System.Drawing.Point(12, 186)
        Me.checkToateInregistrarileSuntInteresServiciu.Name = "checkToateInregistrarileSuntInteresServiciu"
        Me.checkToateInregistrarileSuntInteresServiciu.Size = New System.Drawing.Size(257, 20)
        Me.checkToateInregistrarileSuntInteresServiciu.TabIndex = 13
        Me.checkToateInregistrarileSuntInteresServiciu.Tag = "12"
        Me.checkToateInregistrarileSuntInteresServiciu.Text = "Toate inregistrarile sunt Interes serviciu"
        Me.checkToateInregistrarileSuntInteresServiciu.UseVisualStyleBackColor = True
        '
        'checkZeroInregistrari
        '
        Me.checkZeroInregistrari.AutoSize = True
        Me.checkZeroInregistrari.BackColor = System.Drawing.Color.LightSkyBlue
        Me.checkZeroInregistrari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkZeroInregistrari.Location = New System.Drawing.Point(12, 31)
        Me.checkZeroInregistrari.Name = "checkZeroInregistrari"
        Me.checkZeroInregistrari.Size = New System.Drawing.Size(119, 20)
        Me.checkZeroInregistrari.TabIndex = 12
        Me.checkZeroInregistrari.Tag = "4"
        Me.checkZeroInregistrari.Text = "Zero inregistrari"
        Me.checkZeroInregistrari.UseVisualStyleBackColor = False
        '
        'checkIndexeInversate
        '
        Me.checkIndexeInversate.AutoSize = True
        Me.checkIndexeInversate.BackColor = System.Drawing.Color.MediumPurple
        Me.checkIndexeInversate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkIndexeInversate.ForeColor = System.Drawing.Color.Gold
        Me.checkIndexeInversate.Location = New System.Drawing.Point(12, 105)
        Me.checkIndexeInversate.Name = "checkIndexeInversate"
        Me.checkIndexeInversate.Size = New System.Drawing.Size(124, 20)
        Me.checkIndexeInversate.TabIndex = 11
        Me.checkIndexeInversate.Tag = "3"
        Me.checkIndexeInversate.Text = "Indexe inversate"
        Me.checkIndexeInversate.UseVisualStyleBackColor = False
        '
        'checkKmPreaMulti
        '
        Me.checkKmPreaMulti.AutoSize = True
        Me.checkKmPreaMulti.BackColor = System.Drawing.Color.Red
        Me.checkKmPreaMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkKmPreaMulti.ForeColor = System.Drawing.Color.Gold
        Me.checkKmPreaMulti.Location = New System.Drawing.Point(12, 79)
        Me.checkKmPreaMulti.Name = "checkKmPreaMulti"
        Me.checkKmPreaMulti.Size = New System.Drawing.Size(106, 20)
        Me.checkKmPreaMulti.TabIndex = 10
        Me.checkKmPreaMulti.Tag = "2"
        Me.checkKmPreaMulti.Text = "Km prea multi"
        Me.checkKmPreaMulti.UseVisualStyleBackColor = False
        '
        'checkOSinguraInregistrare
        '
        Me.checkOSinguraInregistrare.AutoSize = True
        Me.checkOSinguraInregistrare.BackColor = System.Drawing.Color.NavajoWhite
        Me.checkOSinguraInregistrare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkOSinguraInregistrare.Location = New System.Drawing.Point(12, 56)
        Me.checkOSinguraInregistrare.Name = "checkOSinguraInregistrare"
        Me.checkOSinguraInregistrare.Size = New System.Drawing.Size(153, 20)
        Me.checkOSinguraInregistrare.TabIndex = 9
        Me.checkOSinguraInregistrare.Tag = "1"
        Me.checkOSinguraInregistrare.Text = "O singura inregistrare"
        Me.checkOSinguraInregistrare.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'cmdSelecteazaTot
        '
        Me.cmdSelecteazaTot.Location = New System.Drawing.Point(529, 54)
        Me.cmdSelecteazaTot.Name = "cmdSelecteazaTot"
        Me.cmdSelecteazaTot.Size = New System.Drawing.Size(95, 47)
        Me.cmdSelecteazaTot.TabIndex = 18
        Me.cmdSelecteazaTot.Text = "Selecteaza tot"
        Me.cmdSelecteazaTot.UseVisualStyleBackColor = True
        '
        'cmdDeselecteazaTot
        '
        Me.cmdDeselecteazaTot.Location = New System.Drawing.Point(430, 54)
        Me.cmdDeselecteazaTot.Name = "cmdDeselecteazaTot"
        Me.cmdDeselecteazaTot.Size = New System.Drawing.Size(95, 47)
        Me.cmdDeselecteazaTot.TabIndex = 19
        Me.cmdDeselecteazaTot.Text = "Deselecteaza tot"
        Me.cmdDeselecteazaTot.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(347, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 13)
        Me.Label12.TabIndex = 172
        Me.Label12.Text = "Total inregistrari"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(237, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 171
        Me.Label5.Text = "Numar utilizatori"
        '
        'lblToateInregistrarileSuntReferintaU
        '
        Me.lblToateInregistrarileSuntReferintaU.AutoSize = True
        Me.lblToateInregistrarileSuntReferintaU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToateInregistrarileSuntReferintaU.Location = New System.Drawing.Point(283, 211)
        Me.lblToateInregistrarileSuntReferintaU.Name = "lblToateInregistrarileSuntReferintaU"
        Me.lblToateInregistrarileSuntReferintaU.Size = New System.Drawing.Size(14, 16)
        Me.lblToateInregistrarileSuntReferintaU.TabIndex = 188
        Me.lblToateInregistrarileSuntReferintaU.Text = "0"
        '
        'lblToateInregistrarileSuntInteresServiciuU
        '
        Me.lblToateInregistrarileSuntInteresServiciuU.AutoSize = True
        Me.lblToateInregistrarileSuntInteresServiciuU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToateInregistrarileSuntInteresServiciuU.Location = New System.Drawing.Point(283, 185)
        Me.lblToateInregistrarileSuntInteresServiciuU.Name = "lblToateInregistrarileSuntInteresServiciuU"
        Me.lblToateInregistrarileSuntInteresServiciuU.Size = New System.Drawing.Size(14, 16)
        Me.lblToateInregistrarileSuntInteresServiciuU.TabIndex = 187
        Me.lblToateInregistrarileSuntInteresServiciuU.Text = "0"
        '
        'lblDouaInregistrariAdiacenteReferintaU
        '
        Me.lblDouaInregistrariAdiacenteReferintaU.AutoSize = True
        Me.lblDouaInregistrariAdiacenteReferintaU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDouaInregistrariAdiacenteReferintaU.Location = New System.Drawing.Point(283, 159)
        Me.lblDouaInregistrariAdiacenteReferintaU.Name = "lblDouaInregistrariAdiacenteReferintaU"
        Me.lblDouaInregistrariAdiacenteReferintaU.Size = New System.Drawing.Size(14, 16)
        Me.lblDouaInregistrariAdiacenteReferintaU.TabIndex = 186
        Me.lblDouaInregistrariAdiacenteReferintaU.Text = "0"
        '
        'lblPrimaInregistrareNuEReferintaU
        '
        Me.lblPrimaInregistrareNuEReferintaU.AutoSize = True
        Me.lblPrimaInregistrareNuEReferintaU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimaInregistrareNuEReferintaU.Location = New System.Drawing.Point(283, 133)
        Me.lblPrimaInregistrareNuEReferintaU.Name = "lblPrimaInregistrareNuEReferintaU"
        Me.lblPrimaInregistrareNuEReferintaU.Size = New System.Drawing.Size(14, 16)
        Me.lblPrimaInregistrareNuEReferintaU.TabIndex = 185
        Me.lblPrimaInregistrareNuEReferintaU.Text = "0"
        '
        'lblIndexeInversateU
        '
        Me.lblIndexeInversateU.AutoSize = True
        Me.lblIndexeInversateU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndexeInversateU.Location = New System.Drawing.Point(283, 107)
        Me.lblIndexeInversateU.Name = "lblIndexeInversateU"
        Me.lblIndexeInversateU.Size = New System.Drawing.Size(14, 16)
        Me.lblIndexeInversateU.TabIndex = 184
        Me.lblIndexeInversateU.Text = "0"
        '
        'lblKmPreaMultiU
        '
        Me.lblKmPreaMultiU.AutoSize = True
        Me.lblKmPreaMultiU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKmPreaMultiU.Location = New System.Drawing.Point(283, 81)
        Me.lblKmPreaMultiU.Name = "lblKmPreaMultiU"
        Me.lblKmPreaMultiU.Size = New System.Drawing.Size(14, 16)
        Me.lblKmPreaMultiU.TabIndex = 183
        Me.lblKmPreaMultiU.Text = "0"
        '
        'lblOSinguraInregistrareU
        '
        Me.lblOSinguraInregistrareU.AutoSize = True
        Me.lblOSinguraInregistrareU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSinguraInregistrareU.Location = New System.Drawing.Point(283, 55)
        Me.lblOSinguraInregistrareU.Name = "lblOSinguraInregistrareU"
        Me.lblOSinguraInregistrareU.Size = New System.Drawing.Size(14, 16)
        Me.lblOSinguraInregistrareU.TabIndex = 182
        Me.lblOSinguraInregistrareU.Text = "0"
        '
        'lblZeroInregistrariU
        '
        Me.lblZeroInregistrariU.AutoSize = True
        Me.lblZeroInregistrariU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZeroInregistrariU.Location = New System.Drawing.Point(283, 30)
        Me.lblZeroInregistrariU.Name = "lblZeroInregistrariU"
        Me.lblZeroInregistrariU.Size = New System.Drawing.Size(14, 16)
        Me.lblZeroInregistrariU.TabIndex = 181
        Me.lblZeroInregistrariU.Text = "0"
        '
        'lblToateInregistrarileSuntReferintaT
        '
        Me.lblToateInregistrarileSuntReferintaT.AutoSize = True
        Me.lblToateInregistrarileSuntReferintaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToateInregistrarileSuntReferintaT.Location = New System.Drawing.Point(382, 211)
        Me.lblToateInregistrarileSuntReferintaT.Name = "lblToateInregistrarileSuntReferintaT"
        Me.lblToateInregistrarileSuntReferintaT.Size = New System.Drawing.Size(14, 16)
        Me.lblToateInregistrarileSuntReferintaT.TabIndex = 180
        Me.lblToateInregistrarileSuntReferintaT.Text = "0"
        '
        'lblToateInregistrarileSuntInteresServiciuT
        '
        Me.lblToateInregistrarileSuntInteresServiciuT.AutoSize = True
        Me.lblToateInregistrarileSuntInteresServiciuT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToateInregistrarileSuntInteresServiciuT.Location = New System.Drawing.Point(382, 185)
        Me.lblToateInregistrarileSuntInteresServiciuT.Name = "lblToateInregistrarileSuntInteresServiciuT"
        Me.lblToateInregistrarileSuntInteresServiciuT.Size = New System.Drawing.Size(14, 16)
        Me.lblToateInregistrarileSuntInteresServiciuT.TabIndex = 179
        Me.lblToateInregistrarileSuntInteresServiciuT.Text = "0"
        '
        'lblDouaInregistrariAdiacenteReferintaT
        '
        Me.lblDouaInregistrariAdiacenteReferintaT.AutoSize = True
        Me.lblDouaInregistrariAdiacenteReferintaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDouaInregistrariAdiacenteReferintaT.Location = New System.Drawing.Point(382, 159)
        Me.lblDouaInregistrariAdiacenteReferintaT.Name = "lblDouaInregistrariAdiacenteReferintaT"
        Me.lblDouaInregistrariAdiacenteReferintaT.Size = New System.Drawing.Size(14, 16)
        Me.lblDouaInregistrariAdiacenteReferintaT.TabIndex = 178
        Me.lblDouaInregistrariAdiacenteReferintaT.Text = "0"
        '
        'lblPrimaInregistrareNuEReferintaT
        '
        Me.lblPrimaInregistrareNuEReferintaT.AutoSize = True
        Me.lblPrimaInregistrareNuEReferintaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimaInregistrareNuEReferintaT.Location = New System.Drawing.Point(382, 133)
        Me.lblPrimaInregistrareNuEReferintaT.Name = "lblPrimaInregistrareNuEReferintaT"
        Me.lblPrimaInregistrareNuEReferintaT.Size = New System.Drawing.Size(14, 16)
        Me.lblPrimaInregistrareNuEReferintaT.TabIndex = 177
        Me.lblPrimaInregistrareNuEReferintaT.Text = "0"
        '
        'lblIndexeInversateT
        '
        Me.lblIndexeInversateT.AutoSize = True
        Me.lblIndexeInversateT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndexeInversateT.Location = New System.Drawing.Point(382, 107)
        Me.lblIndexeInversateT.Name = "lblIndexeInversateT"
        Me.lblIndexeInversateT.Size = New System.Drawing.Size(14, 16)
        Me.lblIndexeInversateT.TabIndex = 176
        Me.lblIndexeInversateT.Text = "0"
        '
        'lblKmPreaMultiT
        '
        Me.lblKmPreaMultiT.AutoSize = True
        Me.lblKmPreaMultiT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKmPreaMultiT.Location = New System.Drawing.Point(382, 81)
        Me.lblKmPreaMultiT.Name = "lblKmPreaMultiT"
        Me.lblKmPreaMultiT.Size = New System.Drawing.Size(14, 16)
        Me.lblKmPreaMultiT.TabIndex = 175
        Me.lblKmPreaMultiT.Text = "0"
        '
        'lblOSinguraInregistrareT
        '
        Me.lblOSinguraInregistrareT.AutoSize = True
        Me.lblOSinguraInregistrareT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSinguraInregistrareT.Location = New System.Drawing.Point(382, 55)
        Me.lblOSinguraInregistrareT.Name = "lblOSinguraInregistrareT"
        Me.lblOSinguraInregistrareT.Size = New System.Drawing.Size(14, 16)
        Me.lblOSinguraInregistrareT.TabIndex = 174
        Me.lblOSinguraInregistrareT.Text = "0"
        '
        'lblZeroInregistrariT
        '
        Me.lblZeroInregistrariT.AutoSize = True
        Me.lblZeroInregistrariT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZeroInregistrariT.Location = New System.Drawing.Point(382, 30)
        Me.lblZeroInregistrariT.Name = "lblZeroInregistrariT"
        Me.lblZeroInregistrariT.Size = New System.Drawing.Size(14, 16)
        Me.lblZeroInregistrariT.TabIndex = 173
        Me.lblZeroInregistrariT.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 203
        Me.Label3.Text = "Cautare:"
        Me.ToolTip1.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        '
        'cmdStergeListaCautare
        '
        Me.cmdStergeListaCautare.Location = New System.Drawing.Point(505, 259)
        Me.cmdStergeListaCautare.Name = "cmdStergeListaCautare"
        Me.cmdStergeListaCautare.Size = New System.Drawing.Size(117, 23)
        Me.cmdStergeListaCautare.TabIndex = 205
        Me.cmdStergeListaCautare.Text = "Sterge lista cautare"
        Me.ToolTip1.SetToolTip(Me.cmdStergeListaCautare, "Sterge toata lista de cautare")
        Me.cmdStergeListaCautare.UseVisualStyleBackColor = True
        '
        'cmdStergeCrt
        '
        Me.cmdStergeCrt.Location = New System.Drawing.Point(432, 259)
        Me.cmdStergeCrt.Name = "cmdStergeCrt"
        Me.cmdStergeCrt.Size = New System.Drawing.Size(67, 23)
        Me.cmdStergeCrt.TabIndex = 206
        Me.cmdStergeCrt.Text = "Sterge crt."
        Me.ToolTip1.SetToolTip(Me.cmdStergeCrt, "Sterge cautarea curenta")
        Me.cmdStergeCrt.UseVisualStyleBackColor = True
        '
        'cmdTrimitereEmailuri
        '
        Me.cmdTrimitereEmailuri.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTrimitereEmailuri.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdTrimitereEmailuri.Location = New System.Drawing.Point(862, 538)
        Me.cmdTrimitereEmailuri.Name = "cmdTrimitereEmailuri"
        Me.cmdTrimitereEmailuri.Size = New System.Drawing.Size(97, 25)
        Me.cmdTrimitereEmailuri.TabIndex = 207
        Me.cmdTrimitereEmailuri.Text = "Trimite emailuri"
        Me.cmdTrimitereEmailuri.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdTrimitereEmailuri, "Trimite email-urile pentru tipurile de greseli selectate")
        Me.cmdTrimitereEmailuri.UseVisualStyleBackColor = True
        '
        'cmdTrimiteEmailCatre
        '
        Me.cmdTrimiteEmailCatre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTrimiteEmailCatre.Location = New System.Drawing.Point(883, 52)
        Me.cmdTrimiteEmailCatre.Name = "cmdTrimiteEmailCatre"
        Me.cmdTrimiteEmailCatre.Size = New System.Drawing.Size(280, 24)
        Me.cmdTrimiteEmailCatre.TabIndex = 217
        Me.cmdTrimiteEmailCatre.Text = "Trimite email catre: "
        Me.ToolTip1.SetToolTip(Me.cmdTrimiteEmailCatre, "Trimite email-ul pregatit pentru utilizatorul selectat")
        Me.cmdTrimiteEmailCatre.UseVisualStyleBackColor = True
        '
        'cmdSalveazaInSablonulCurent
        '
        Me.cmdSalveazaInSablonulCurent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalveazaInSablonulCurent.Location = New System.Drawing.Point(756, 52)
        Me.cmdSalveazaInSablonulCurent.Name = "cmdSalveazaInSablonulCurent"
        Me.cmdSalveazaInSablonulCurent.Size = New System.Drawing.Size(121, 24)
        Me.cmdSalveazaInSablonulCurent.TabIndex = 277
        Me.cmdSalveazaInSablonulCurent.Text = "Salveaza in sablonul curent"
        Me.ToolTip1.SetToolTip(Me.cmdSalveazaInSablonulCurent, "Se poate modifica continutul emailului chiar aici si se salveaza in sablonul sele" &
        "ctat.")
        Me.cmdSalveazaInSablonulCurent.UseVisualStyleBackColor = True
        '
        'cmdDeschideSablonul
        '
        Me.cmdDeschideSablonul.Location = New System.Drawing.Point(504, 209)
        Me.cmdDeschideSablonul.Name = "cmdDeschideSablonul"
        Me.cmdDeschideSablonul.Size = New System.Drawing.Size(121, 24)
        Me.cmdDeschideSablonul.TabIndex = 278
        Me.cmdDeschideSablonul.Text = "Deschide sablonul"
        Me.ToolTip1.SetToolTip(Me.cmdDeschideSablonul, "Se poate modifica continutul emailului chiar aici si se salveaza in sablonul sele" &
        "ctat.")
        Me.cmdDeschideSablonul.UseVisualStyleBackColor = True
        '
        'cmdTrimiteEmailSelectie
        '
        Me.cmdTrimiteEmailSelectie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTrimiteEmailSelectie.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdTrimiteEmailSelectie.Location = New System.Drawing.Point(990, 538)
        Me.cmdTrimiteEmailSelectie.Name = "cmdTrimiteEmailSelectie"
        Me.cmdTrimiteEmailSelectie.Size = New System.Drawing.Size(173, 25)
        Me.cmdTrimiteEmailSelectie.TabIndex = 279
        Me.cmdTrimiteEmailSelectie.Text = "Trimite email selectie"
        Me.cmdTrimiteEmailSelectie.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.cmdTrimiteEmailSelectie, "Trimite email doar la randurile selectate")
        Me.cmdTrimiteEmailSelectie.UseVisualStyleBackColor = True
        '
        'cmbIntervale
        '
        Me.cmbIntervale.FormattingEnabled = True
        Me.cmbIntervale.Items.AddRange(New Object() {"Toate"})
        Me.cmbIntervale.Location = New System.Drawing.Point(432, 25)
        Me.cmbIntervale.Name = "cmbIntervale"
        Me.cmbIntervale.Size = New System.Drawing.Size(191, 21)
        Me.cmbIntervale.TabIndex = 190
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(464, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 191
        Me.Label1.Text = "Intervale"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Utiliz, Me.TextEmail, Me.Email})
        Me.DataGridView2.Location = New System.Drawing.Point(631, 569)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(532, 104)
        Me.DataGridView2.TabIndex = 192
        '
        'Utiliz
        '
        Me.Utiliz.HeaderText = "Utilizator"
        Me.Utiliz.Name = "Utiliz"
        Me.Utiliz.ReadOnly = True
        '
        'TextEmail
        '
        Me.TextEmail.HeaderText = "Text email"
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'lblEmailuri
        '
        Me.lblEmailuri.AutoSize = True
        Me.lblEmailuri.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailuri.Location = New System.Drawing.Point(628, 55)
        Me.lblEmailuri.Name = "lblEmailuri"
        Me.lblEmailuri.Size = New System.Drawing.Size(55, 13)
        Me.lblEmailuri.TabIndex = 193
        Me.lblEmailuri.Text = "Email-uri"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Utilizator, Me.Masina, Me.Data, Me.Km, Me.KmModificat, Me.Status, Me.StatusModificat, Me.Spreadsheet, Me.DataSiOraCitirii, Me.Asumat, Me.Observatii})
        Me.DataGridView3.Location = New System.Drawing.Point(13, 293)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(610, 112)
        Me.DataGridView3.TabIndex = 194
        '
        'Utilizator
        '
        Me.Utilizator.HeaderText = "Utilizator"
        Me.Utilizator.Name = "Utilizator"
        '
        'Masina
        '
        Me.Masina.HeaderText = "Masina"
        Me.Masina.Name = "Masina"
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
        Me.DataSiOraCitirii.HeaderText = "Data citirii"
        Me.DataSiOraCitirii.Name = "DataSiOraCitirii"
        '
        'Asumat
        '
        Me.Asumat.HeaderText = "Asumat"
        Me.Asumat.Name = "Asumat"
        '
        'Observatii
        '
        Me.Observatii.HeaderText = "Observatii"
        Me.Observatii.Name = "Observatii"
        '
        'LabelNumarInregistrariSt
        '
        Me.LabelNumarInregistrariSt.AutoSize = True
        Me.LabelNumarInregistrariSt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumarInregistrariSt.Location = New System.Drawing.Point(9, 274)
        Me.LabelNumarInregistrariSt.Name = "LabelNumarInregistrariSt"
        Me.LabelNumarInregistrariSt.Size = New System.Drawing.Size(106, 13)
        Me.LabelNumarInregistrariSt.TabIndex = 196
        Me.LabelNumarInregistrariSt.Text = "Numar inregistrari"
        '
        'lblCompletareInutilaADateiDeIntroducereU
        '
        Me.lblCompletareInutilaADateiDeIntroducereU.AutoSize = True
        Me.lblCompletareInutilaADateiDeIntroducereU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletareInutilaADateiDeIntroducereU.Location = New System.Drawing.Point(283, 237)
        Me.lblCompletareInutilaADateiDeIntroducereU.Name = "lblCompletareInutilaADateiDeIntroducereU"
        Me.lblCompletareInutilaADateiDeIntroducereU.Size = New System.Drawing.Size(14, 16)
        Me.lblCompletareInutilaADateiDeIntroducereU.TabIndex = 200
        Me.lblCompletareInutilaADateiDeIntroducereU.Text = "0"
        '
        'lblCompletareInutilaADateiDeIntroducereT
        '
        Me.lblCompletareInutilaADateiDeIntroducereT.AutoSize = True
        Me.lblCompletareInutilaADateiDeIntroducereT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletareInutilaADateiDeIntroducereT.Location = New System.Drawing.Point(382, 237)
        Me.lblCompletareInutilaADateiDeIntroducereT.Name = "lblCompletareInutilaADateiDeIntroducereT"
        Me.lblCompletareInutilaADateiDeIntroducereT.Size = New System.Drawing.Size(14, 16)
        Me.lblCompletareInutilaADateiDeIntroducereT.TabIndex = 199
        Me.lblCompletareInutilaADateiDeIntroducereT.Text = "0"
        '
        'checkCompletareInutilaADateiDeIntroducere
        '
        Me.checkCompletareInutilaADateiDeIntroducere.AutoSize = True
        Me.checkCompletareInutilaADateiDeIntroducere.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkCompletareInutilaADateiDeIntroducere.Location = New System.Drawing.Point(12, 235)
        Me.checkCompletareInutilaADateiDeIntroducere.Name = "checkCompletareInutilaADateiDeIntroducere"
        Me.checkCompletareInutilaADateiDeIntroducere.Size = New System.Drawing.Size(266, 20)
        Me.checkCompletareInutilaADateiDeIntroducere.TabIndex = 198
        Me.checkCompletareInutilaADateiDeIntroducere.Tag = "14"
        Me.checkCompletareInutilaADateiDeIntroducere.Text = "Completare inutile a datei de introducere"
        Me.checkCompletareInutilaADateiDeIntroducere.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PictureBox1.Location = New System.Drawing.Point(624, 290)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(5, 387)
        Me.PictureBox1.TabIndex = 201
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'cmbCautare
        '
        Me.cmbCautare.FormattingEnabled = True
        Me.cmbCautare.Location = New System.Drawing.Point(175, 261)
        Me.cmbCautare.MaxDropDownItems = 20
        Me.cmbCautare.Name = "cmbCautare"
        Me.cmbCautare.Size = New System.Drawing.Size(169, 21)
        Me.cmbCautare.TabIndex = 204
        '
        'txtContinutEmail
        '
        Me.txtContinutEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContinutEmail.Location = New System.Drawing.Point(631, 79)
        Me.txtContinutEmail.Multiline = True
        Me.txtContinutEmail.Name = "txtContinutEmail"
        Me.txtContinutEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtContinutEmail.Size = New System.Drawing.Size(529, 457)
        Me.txtContinutEmail.TabIndex = 210
        '
        'KmAutoDataSet
        '
        Me.KmAutoDataSet.DataSetName = "KmAutoDataSet"
        Me.KmAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdDeschideSpreadsheet
        '
        Me.cmdDeschideSpreadsheet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDeschideSpreadsheet.Location = New System.Drawing.Point(1064, 23)
        Me.cmdDeschideSpreadsheet.Name = "cmdDeschideSpreadsheet"
        Me.cmdDeschideSpreadsheet.Size = New System.Drawing.Size(99, 23)
        Me.cmdDeschideSpreadsheet.TabIndex = 213
        Me.cmdDeschideSpreadsheet.Text = "Deschide"
        Me.cmdDeschideSpreadsheet.UseVisualStyleBackColor = True
        '
        'cmbSpreadsheets
        '
        Me.cmbSpreadsheets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSpreadsheets.DataSource = Me.SpreadsheetsBindingSource
        Me.cmbSpreadsheets.DisplayMember = "Nume"
        Me.cmbSpreadsheets.FormattingEnabled = True
        Me.cmbSpreadsheets.Location = New System.Drawing.Point(631, 23)
        Me.cmbSpreadsheets.MaxDropDownItems = 30
        Me.cmbSpreadsheets.Name = "cmbSpreadsheets"
        Me.cmbSpreadsheets.Size = New System.Drawing.Size(427, 21)
        Me.cmbSpreadsheets.TabIndex = 214
        Me.cmbSpreadsheets.ValueMember = "SpreadsheetId"
        '
        'SpreadsheetsBindingSource
        '
        Me.SpreadsheetsBindingSource.DataMember = "Spreadsheets"
        Me.SpreadsheetsBindingSource.DataSource = Me.KmAutoDataSet
        '
        'UtilizatoriBindingSource
        '
        Me.UtilizatoriBindingSource.DataMember = "Utilizatori"
        Me.UtilizatoriBindingSource.DataSource = Me.KmAutoDataSet
        '
        'UtilizatoriTableAdapter
        '
        Me.UtilizatoriTableAdapter.ClearBeforeFill = True
        '
        'ssInfo
        '
        Me.ssInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbInfo, Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1, Me.pbIncarca})
        Me.ssInfo.Location = New System.Drawing.Point(0, 682)
        Me.ssInfo.Name = "ssInfo"
        Me.ssInfo.Size = New System.Drawing.Size(1175, 22)
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
        'SpreadsheetsTableAdapter
        '
        Me.SpreadsheetsTableAdapter.ClearBeforeFill = True
        '
        'cmdCautaTot
        '
        Me.cmdCautaTot.Location = New System.Drawing.Point(362, 259)
        Me.cmdCautaTot.Name = "cmdCautaTot"
        Me.cmdCautaTot.Size = New System.Drawing.Size(34, 23)
        Me.cmdCautaTot.TabIndex = 274
        Me.cmdCautaTot.Text = "Tot"
        Me.cmdCautaTot.UseVisualStyleBackColor = True
        '
        'cmdRefreshCautareCurenta
        '
        Me.cmdRefreshCautareCurenta.Location = New System.Drawing.Point(402, 259)
        Me.cmdRefreshCautareCurenta.Name = "cmdRefreshCautareCurenta"
        Me.cmdRefreshCautareCurenta.Size = New System.Drawing.Size(28, 23)
        Me.cmdRefreshCautareCurenta.TabIndex = 273
        Me.cmdRefreshCautareCurenta.Text = "R"
        Me.cmdRefreshCautareCurenta.UseVisualStyleBackColor = True
        '
        'cmbSabloaneEmail
        '
        Me.cmbSabloaneEmail.FormattingEnabled = True
        Me.cmbSabloaneEmail.Location = New System.Drawing.Point(428, 180)
        Me.cmbSabloaneEmail.Name = "cmbSabloaneEmail"
        Me.cmbSabloaneEmail.Size = New System.Drawing.Size(194, 21)
        Me.cmbSabloaneEmail.TabIndex = 275
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(429, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 276
        Me.Label2.Text = "Sabloane email"
        '
        'frmGreseliLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 704)
        Me.Controls.Add(Me.cmdTrimiteEmailSelectie)
        Me.Controls.Add(Me.cmdDeschideSablonul)
        Me.Controls.Add(Me.cmdSalveazaInSablonulCurent)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbSabloaneEmail)
        Me.Controls.Add(Me.cmdCautaTot)
        Me.Controls.Add(Me.cmdRefreshCautareCurenta)
        Me.Controls.Add(Me.ssInfo)
        Me.Controls.Add(Me.cmdTrimiteEmailCatre)
        Me.Controls.Add(Me.cmbSpreadsheets)
        Me.Controls.Add(Me.cmdDeschideSpreadsheet)
        Me.Controls.Add(Me.txtContinutEmail)
        Me.Controls.Add(Me.cmdTrimitereEmailuri)
        Me.Controls.Add(Me.cmdStergeCrt)
        Me.Controls.Add(Me.cmdStergeListaCautare)
        Me.Controls.Add(Me.cmbCautare)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblCompletareInutilaADateiDeIntroducereU)
        Me.Controls.Add(Me.lblCompletareInutilaADateiDeIntroducereT)
        Me.Controls.Add(Me.checkCompletareInutilaADateiDeIntroducere)
        Me.Controls.Add(Me.LabelNumarInregistrariSt)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.lblEmailuri)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbIntervale)
        Me.Controls.Add(Me.lblToateInregistrarileSuntReferintaU)
        Me.Controls.Add(Me.lblToateInregistrarileSuntInteresServiciuU)
        Me.Controls.Add(Me.lblDouaInregistrariAdiacenteReferintaU)
        Me.Controls.Add(Me.lblPrimaInregistrareNuEReferintaU)
        Me.Controls.Add(Me.lblIndexeInversateU)
        Me.Controls.Add(Me.lblKmPreaMultiU)
        Me.Controls.Add(Me.lblOSinguraInregistrareU)
        Me.Controls.Add(Me.lblZeroInregistrariU)
        Me.Controls.Add(Me.lblToateInregistrarileSuntReferintaT)
        Me.Controls.Add(Me.lblToateInregistrarileSuntInteresServiciuT)
        Me.Controls.Add(Me.lblDouaInregistrariAdiacenteReferintaT)
        Me.Controls.Add(Me.lblPrimaInregistrareNuEReferintaT)
        Me.Controls.Add(Me.lblIndexeInversateT)
        Me.Controls.Add(Me.lblKmPreaMultiT)
        Me.Controls.Add(Me.lblOSinguraInregistrareT)
        Me.Controls.Add(Me.lblZeroInregistrariT)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdDeselecteazaTot)
        Me.Controls.Add(Me.cmdSelecteazaTot)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.checkPrimaInregistrareNuEReferinta)
        Me.Controls.Add(Me.checkToateInregistrarileSuntReferinta)
        Me.Controls.Add(Me.checkDouaInregistrariAdiacenteReferinta)
        Me.Controls.Add(Me.checkToateInregistrarileSuntInteresServiciu)
        Me.Controls.Add(Me.checkZeroInregistrari)
        Me.Controls.Add(Me.checkIndexeInversate)
        Me.Controls.Add(Me.checkKmPreaMulti)
        Me.Controls.Add(Me.checkOSinguraInregistrare)
        Me.Name = "frmGreseliLog"
        Me.Text = "frmGreseliLog"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpreadsheetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilizatoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ssInfo.ResumeLayout(False)
        Me.ssInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents checkPrimaInregistrareNuEReferinta As CheckBox
    Friend WithEvents checkToateInregistrarileSuntReferinta As CheckBox
    Friend WithEvents checkDouaInregistrariAdiacenteReferinta As CheckBox
    Friend WithEvents checkToateInregistrarileSuntInteresServiciu As CheckBox
    Friend WithEvents checkZeroInregistrari As CheckBox
    Friend WithEvents checkIndexeInversate As CheckBox
    Friend WithEvents checkKmPreaMulti As CheckBox
    Friend WithEvents checkOSinguraInregistrare As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cmdSelecteazaTot As Button
    Friend WithEvents cmdDeselecteazaTot As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblToateInregistrarileSuntReferintaU As Label
    Friend WithEvents lblToateInregistrarileSuntInteresServiciuU As Label
    Friend WithEvents lblDouaInregistrariAdiacenteReferintaU As Label
    Friend WithEvents lblPrimaInregistrareNuEReferintaU As Label
    Friend WithEvents lblIndexeInversateU As Label
    Friend WithEvents lblKmPreaMultiU As Label
    Friend WithEvents lblOSinguraInregistrareU As Label
    Friend WithEvents lblZeroInregistrariU As Label
    Friend WithEvents lblToateInregistrarileSuntReferintaT As Label
    Friend WithEvents lblToateInregistrarileSuntInteresServiciuT As Label
    Friend WithEvents lblDouaInregistrariAdiacenteReferintaT As Label
    Friend WithEvents lblPrimaInregistrareNuEReferintaT As Label
    Friend WithEvents lblIndexeInversateT As Label
    Friend WithEvents lblKmPreaMultiT As Label
    Friend WithEvents lblOSinguraInregistrareT As Label
    Friend WithEvents lblZeroInregistrariT As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cmbIntervale As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents lblEmailuri As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents LabelNumarInregistrariSt As Label
    Friend WithEvents lblCompletareInutilaADateiDeIntroducereU As Label
    Friend WithEvents lblCompletareInutilaADateiDeIntroducereT As Label
    Friend WithEvents checkCompletareInutilaADateiDeIntroducere As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents cmbCautare As ComboBox
    Friend WithEvents cmdStergeListaCautare As Button
    Friend WithEvents cmdStergeCrt As Button
    Friend WithEvents cmdTrimitereEmailuri As Button
    Friend WithEvents txtContinutEmail As TextBox
    Friend WithEvents KmAutoDataSet As KmAutoDataSet
    Friend WithEvents cmdDeschideSpreadsheet As Button
    Friend WithEvents cmbSpreadsheets As ComboBox
    Friend WithEvents cmdTrimiteEmailCatre As Button
    Friend WithEvents UtilizatoriBindingSource As BindingSource
    Friend WithEvents UtilizatoriTableAdapter As KmAutoDataSetTableAdapters.UtilizatoriTableAdapter
    Friend WithEvents ssInfo As StatusStrip
    Friend WithEvents lbInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents pbIncarca As ToolStripProgressBar
    Friend WithEvents Utilizator As DataGridViewTextBoxColumn
    Friend WithEvents Masina As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Km As DataGridViewTextBoxColumn
    Friend WithEvents KmModificat As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents StatusModificat As DataGridViewComboBoxColumn
    Friend WithEvents Spreadsheet As DataGridViewTextBoxColumn
    Friend WithEvents DataSiOraCitirii As DataGridViewTextBoxColumn
    Friend WithEvents Asumat As DataGridViewTextBoxColumn
    Friend WithEvents Observatii As DataGridViewTextBoxColumn
    Friend WithEvents SpreadsheetsBindingSource As BindingSource
    Friend WithEvents SpreadsheetsTableAdapter As KmAutoDataSetTableAdapters.SpreadsheetsTableAdapter
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Filiala As DataGridViewTextBoxColumn
    Friend WithEvents Utilizator_ As DataGridViewTextBoxColumn
    Friend WithEvents Interval As DataGridViewTextBoxColumn
    Friend WithEvents Tip As DataGridViewTextBoxColumn
    Friend WithEvents Numar As DataGridViewTextBoxColumn
    Friend WithEvents IntervalComplet As DataGridViewTextBoxColumn
    Friend WithEvents Telefon As DataGridViewTextBoxColumn
    Friend WithEvents Email_ As DataGridViewTextBoxColumn
    Friend WithEvents Utiliz As DataGridViewTextBoxColumn
    Friend WithEvents TextEmail As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents cmdCautaTot As Button
    Friend WithEvents cmdRefreshCautareCurenta As Button
    Friend WithEvents cmbSabloaneEmail As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdSalveazaInSablonulCurent As Button
    Friend WithEvents cmdDeschideSablonul As Button
    Friend WithEvents cmdTrimiteEmailSelectie As Button
End Class
