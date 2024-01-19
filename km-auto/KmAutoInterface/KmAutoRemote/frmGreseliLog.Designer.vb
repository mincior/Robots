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
        Me.cmdTrimiteEmailuri = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBoxEliminaDubluriPeInterval = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdStergeListaCautare = New System.Windows.Forms.Button()
        Me.cmdStergeCrt = New System.Windows.Forms.Button()
        Me.cmbIntervale = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Utilizator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasinaId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Km = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Spreadsheet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSiOraCitirii = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelNumarInregistrariSt = New System.Windows.Forms.Label()
        Me.lblCompletareInutilaADateiDeIntroducereU = New System.Windows.Forms.Label()
        Me.lblCompletareInutilaADateiDeIntroducereT = New System.Windows.Forms.Label()
        Me.checkCompletareInutilaADateiDeIntroducere = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbCautare = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Filiala, Me.Utilizator_, Me.Interval, Me.Tip, Me.Numar, Me.IntervalComplet})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 290)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(610, 410)
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
        Me.cmdSelecteazaTot.Location = New System.Drawing.Point(767, 9)
        Me.cmdSelecteazaTot.Name = "cmdSelecteazaTot"
        Me.cmdSelecteazaTot.Size = New System.Drawing.Size(92, 47)
        Me.cmdSelecteazaTot.TabIndex = 18
        Me.cmdSelecteazaTot.Text = "Selecteaza tot"
        Me.cmdSelecteazaTot.UseVisualStyleBackColor = True
        '
        'cmdDeselecteazaTot
        '
        Me.cmdDeselecteazaTot.Location = New System.Drawing.Point(669, 9)
        Me.cmdDeselecteazaTot.Name = "cmdDeselecteazaTot"
        Me.cmdDeselecteazaTot.Size = New System.Drawing.Size(92, 47)
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
        'cmdTrimiteEmailuri
        '
        Me.cmdTrimiteEmailuri.Location = New System.Drawing.Point(921, 12)
        Me.cmdTrimiteEmailuri.Name = "cmdTrimiteEmailuri"
        Me.cmdTrimiteEmailuri.Size = New System.Drawing.Size(92, 47)
        Me.cmdTrimiteEmailuri.TabIndex = 189
        Me.cmdTrimiteEmailuri.Text = "Pregatire trimitere email-uri"
        Me.ToolTip1.SetToolTip(Me.cmdTrimiteEmailuri, "Grupeaza greselile pe utilizator eliminand dublurile")
        Me.cmdTrimiteEmailuri.UseVisualStyleBackColor = True
        '
        'CheckBoxEliminaDubluriPeInterval
        '
        Me.CheckBoxEliminaDubluriPeInterval.AutoSize = True
        Me.CheckBoxEliminaDubluriPeInterval.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxEliminaDubluriPeInterval.Location = New System.Drawing.Point(716, 94)
        Me.CheckBoxEliminaDubluriPeInterval.Name = "CheckBoxEliminaDubluriPeInterval"
        Me.CheckBoxEliminaDubluriPeInterval.Size = New System.Drawing.Size(178, 20)
        Me.CheckBoxEliminaDubluriPeInterval.TabIndex = 195
        Me.CheckBoxEliminaDubluriPeInterval.Tag = "6"
        Me.CheckBoxEliminaDubluriPeInterval.Text = "Elimina dubluri pe interval"
        Me.ToolTip1.SetToolTip(Me.CheckBoxEliminaDubluriPeInterval, "Daca este bifata va trimite o singura data chiar daca aceeasi greseala apare pe m" &
        "ai multe intervale")
        Me.CheckBoxEliminaDubluriPeInterval.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(145, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 203
        Me.Label3.Text = "Cautare:"
        Me.ToolTip1.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        '
        'cmdStergeListaCautare
        '
        Me.cmdStergeListaCautare.Location = New System.Drawing.Point(505, 264)
        Me.cmdStergeListaCautare.Name = "cmdStergeListaCautare"
        Me.cmdStergeListaCautare.Size = New System.Drawing.Size(117, 23)
        Me.cmdStergeListaCautare.TabIndex = 205
        Me.cmdStergeListaCautare.Text = "Sterge lista cautare"
        Me.ToolTip1.SetToolTip(Me.cmdStergeListaCautare, "Sterge toata lista de cautare")
        Me.cmdStergeListaCautare.UseVisualStyleBackColor = True
        '
        'cmdStergeCrt
        '
        Me.cmdStergeCrt.Location = New System.Drawing.Point(417, 264)
        Me.cmdStergeCrt.Name = "cmdStergeCrt"
        Me.cmdStergeCrt.Size = New System.Drawing.Size(82, 23)
        Me.cmdStergeCrt.TabIndex = 206
        Me.cmdStergeCrt.Text = "Sterge crt."
        Me.ToolTip1.SetToolTip(Me.cmdStergeCrt, "Sterge cautarea curenta")
        Me.cmdStergeCrt.UseVisualStyleBackColor = True
        '
        'cmbIntervale
        '
        Me.cmbIntervale.FormattingEnabled = True
        Me.cmbIntervale.Items.AddRange(New Object() {"Toate"})
        Me.cmbIntervale.Location = New System.Drawing.Point(466, 29)
        Me.cmbIntervale.Name = "cmbIntervale"
        Me.cmbIntervale.Size = New System.Drawing.Size(157, 21)
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
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Email})
        Me.DataGridView2.Location = New System.Drawing.Point(631, 460)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(534, 240)
        Me.DataGridView2.TabIndex = 192
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Utilizator"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Interval"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Greseala"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(655, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 193
        Me.Label2.Text = "Email-uri"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Utilizator, Me.MasinaId, Me.Data, Me.Km, Me.Status, Me.Spreadsheet, Me.DataSiOraCitirii})
        Me.DataGridView3.Location = New System.Drawing.Point(631, 290)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(534, 164)
        Me.DataGridView3.TabIndex = 194
        '
        'Utilizator
        '
        Me.Utilizator.HeaderText = "Utilizator"
        Me.Utilizator.Name = "Utilizator"
        Me.Utilizator.ReadOnly = True
        '
        'MasinaId
        '
        Me.MasinaId.HeaderText = "MasinaId"
        Me.MasinaId.Name = "MasinaId"
        Me.MasinaId.ReadOnly = True
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        '
        'Km
        '
        Me.Km.HeaderText = "Km"
        Me.Km.Name = "Km"
        Me.Km.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'Spreadsheet
        '
        Me.Spreadsheet.HeaderText = "Spreadsheet"
        Me.Spreadsheet.Name = "Spreadsheet"
        Me.Spreadsheet.ReadOnly = True
        '
        'DataSiOraCitirii
        '
        Me.DataSiOraCitirii.HeaderText = "Data citirii"
        Me.DataSiOraCitirii.Name = "DataSiOraCitirii"
        Me.DataSiOraCitirii.ReadOnly = True
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
        Me.PictureBox1.Size = New System.Drawing.Size(5, 410)
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
        Me.cmbCautare.Location = New System.Drawing.Point(224, 266)
        Me.cmbCautare.Name = "cmbCautare"
        Me.cmbCautare.Size = New System.Drawing.Size(169, 21)
        Me.cmbCautare.TabIndex = 204
        '
        'frmGreseliLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 704)
        Me.Controls.Add(Me.cmdStergeCrt)
        Me.Controls.Add(Me.cmdStergeListaCautare)
        Me.Controls.Add(Me.cmbCautare)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblCompletareInutilaADateiDeIntroducereU)
        Me.Controls.Add(Me.lblCompletareInutilaADateiDeIntroducereT)
        Me.Controls.Add(Me.checkCompletareInutilaADateiDeIntroducere)
        Me.Controls.Add(Me.LabelNumarInregistrariSt)
        Me.Controls.Add(Me.CheckBoxEliminaDubluriPeInterval)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbIntervale)
        Me.Controls.Add(Me.cmdTrimiteEmailuri)
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
    Friend WithEvents cmdTrimiteEmailuri As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cmbIntervale As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents CheckBoxEliminaDubluriPeInterval As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents LabelNumarInregistrariSt As Label
    Friend WithEvents Utilizator As DataGridViewTextBoxColumn
    Friend WithEvents MasinaId As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Km As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Spreadsheet As DataGridViewTextBoxColumn
    Friend WithEvents DataSiOraCitirii As DataGridViewTextBoxColumn
    Friend WithEvents lblCompletareInutilaADateiDeIntroducereU As Label
    Friend WithEvents lblCompletareInutilaADateiDeIntroducereT As Label
    Friend WithEvents checkCompletareInutilaADateiDeIntroducere As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Filiala As DataGridViewTextBoxColumn
    Friend WithEvents Utilizator_ As DataGridViewTextBoxColumn
    Friend WithEvents Interval As DataGridViewTextBoxColumn
    Friend WithEvents Tip As DataGridViewTextBoxColumn
    Friend WithEvents Numar As DataGridViewTextBoxColumn
    Friend WithEvents IntervalComplet As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents cmbCautare As ComboBox
    Friend WithEvents cmdStergeListaCautare As Button
    Friend WithEvents cmdStergeCrt As Button
End Class
