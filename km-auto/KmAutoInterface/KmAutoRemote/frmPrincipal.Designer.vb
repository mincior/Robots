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
        Me.dtpDataRaportarii = New System.Windows.Forms.DateTimePicker()
        Me.LabelDataInterogare = New System.Windows.Forms.Label()
        Me.cmdExecuta = New System.Windows.Forms.Button()
        Me.cmdVizualizareMasini = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdGreseliUtilizatori = New System.Windows.Forms.Button()
        Me.cmdVizualizareZileLibere = New System.Windows.Forms.Button()
        Me.cmdVizualizareMasiniInexistente = New System.Windows.Forms.Button()
        Me.cmdVizualizareUtilizatoriInexistenti = New System.Windows.Forms.Button()
        Me.cmdVizualizareKmLogView = New System.Windows.Forms.Button()
        Me.cmdVizualizareUtilizatori = New System.Windows.Forms.Button()
        Me.EmailMeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailToTextBox = New System.Windows.Forms.TextBox()
        Me.EmailSendCheckBox = New System.Windows.Forms.CheckBox()
        Me.ExtrageRapExcelDinBICheckBox = New System.Windows.Forms.CheckBox()
        Me.ExtrageRapExcelDinERPCheckBox = New System.Windows.Forms.CheckBox()
        Me.ExecutaSQLCheckBox = New System.Windows.Forms.CheckBox()
        Me.NumarLuniActualizateTextBox = New System.Windows.Forms.TextBox()
        Me.cmdRenunta = New System.Windows.Forms.Button()
        Me.txtTimer = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblToateInregistrarileSuntReferintaU = New System.Windows.Forms.Label()
        Me.lblToateInregistrarileSuntInteresServiciuU = New System.Windows.Forms.Label()
        Me.lblDouaInregistrariAdiacenteReferintaU = New System.Windows.Forms.Label()
        Me.lblPrimaInregistrareNuEReferintaU = New System.Windows.Forms.Label()
        Me.lblIndexeInversateU = New System.Windows.Forms.Label()
        Me.lblKmPreaMultiU = New System.Windows.Forms.Label()
        Me.lblOSinguraInregistrareU = New System.Windows.Forms.Label()
        Me.lblZeroInregistrariU = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblToateInregistrarileSuntReferintaT = New System.Windows.Forms.Label()
        Me.lblToateInregistrarileSuntInteresServiciuT = New System.Windows.Forms.Label()
        Me.lblDouaInregistrariAdiacenteReferintaT = New System.Windows.Forms.Label()
        Me.lblPrimaInregistrareNuEReferintaT = New System.Windows.Forms.Label()
        Me.lblIndexeInversateT = New System.Windows.Forms.Label()
        Me.lblKmPreaMultiT = New System.Windows.Forms.Label()
        Me.lblOSinguraInregistrareT = New System.Windows.Forms.Label()
        Me.lblZeroInregistrariT = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CombustibiliTableAdapter1 = New KmAutoInterface.KmAutoDataSetTableAdapters.CombustibiliTableAdapter()
        Me.KmAutoDataSet = New KmAutoInterface.KmAutoDataSet()
        Me.GreseliLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GreseliLogTableAdapter = New KmAutoInterface.KmAutoDataSetTableAdapters.GreseliLogTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblCompletareInutilaADateiDeIntroducereU = New System.Windows.Forms.Label()
        Me.lblCompletareInutilaADateiDeIntroducereT = New System.Windows.Forms.Label()
        Me.ImpartePeFilialeCheckBox = New System.Windows.Forms.CheckBox()
        Me.ImpartePeAgentiCheckBox = New System.Windows.Forms.CheckBox()
        Me.RobotsDataSet = New KmAutoInterface.RobotsDataSet()
        Me.ConfigTableAdapter = New KmAutoInterface.RobotsDataSetTableAdapters.ConfigTableAdapter()
        Me.TableAdapterManager = New KmAutoInterface.RobotsDataSetTableAdapters.TableAdapterManager()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        EmailMeLabel = New System.Windows.Forms.Label()
        EmailToLabel = New System.Windows.Forms.Label()
        NumarLuniActualizateLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreseliLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RobotsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmailMeLabel
        '
        EmailMeLabel.AutoSize = True
        EmailMeLabel.Location = New System.Drawing.Point(306, 296)
        EmailMeLabel.Name = "EmailMeLabel"
        EmailMeLabel.Size = New System.Drawing.Size(53, 13)
        EmailMeLabel.TabIndex = 63
        EmailMeLabel.Text = "Email Me:"
        '
        'EmailToLabel
        '
        EmailToLabel.AutoSize = True
        EmailToLabel.Location = New System.Drawing.Point(306, 270)
        EmailToLabel.Name = "EmailToLabel"
        EmailToLabel.Size = New System.Drawing.Size(51, 13)
        EmailToLabel.TabIndex = 69
        EmailToLabel.Text = "Email To:"
        '
        'NumarLuniActualizateLabel
        '
        NumarLuniActualizateLabel.Location = New System.Drawing.Point(255, 205)
        NumarLuniActualizateLabel.Name = "NumarLuniActualizateLabel"
        NumarLuniActualizateLabel.Size = New System.Drawing.Size(108, 43)
        NumarLuniActualizateLabel.TabIndex = 129
        NumarLuniActualizateLabel.Text = "Numar implicit de km acceptati gratuit pe saptamana"
        '
        'dtpDataRaportarii
        '
        Me.dtpDataRaportarii.CustomFormat = "yyyy-MM-dd"
        Me.dtpDataRaportarii.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataRaportarii.Location = New System.Drawing.Point(111, 93)
        Me.dtpDataRaportarii.Name = "dtpDataRaportarii"
        Me.dtpDataRaportarii.Size = New System.Drawing.Size(123, 20)
        Me.dtpDataRaportarii.TabIndex = 45
        '
        'LabelDataInterogare
        '
        Me.LabelDataInterogare.AutoSize = True
        Me.LabelDataInterogare.Location = New System.Drawing.Point(13, 97)
        Me.LabelDataInterogare.Name = "LabelDataInterogare"
        Me.LabelDataInterogare.Size = New System.Drawing.Size(73, 13)
        Me.LabelDataInterogare.TabIndex = 38
        Me.LabelDataInterogare.Text = "Data raportarii"
        '
        'cmdExecuta
        '
        Me.cmdExecuta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExecuta.BackgroundImage = CType(resources.GetObject("cmdExecuta.BackgroundImage"), System.Drawing.Image)
        Me.cmdExecuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdExecuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExecuta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdExecuta.Location = New System.Drawing.Point(871, 88)
        Me.cmdExecuta.Name = "cmdExecuta"
        Me.cmdExecuta.Size = New System.Drawing.Size(169, 147)
        Me.cmdExecuta.TabIndex = 48
        Me.cmdExecuta.Text = "Ruleaza robotul"
        Me.cmdExecuta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExecuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExecuta.UseVisualStyleBackColor = True
        '
        'cmdVizualizareMasini
        '
        Me.cmdVizualizareMasini.Location = New System.Drawing.Point(3, 49)
        Me.cmdVizualizareMasini.Name = "cmdVizualizareMasini"
        Me.cmdVizualizareMasini.Size = New System.Drawing.Size(217, 26)
        Me.cmdVizualizareMasini.TabIndex = 50
        Me.cmdVizualizareMasini.Text = "Masini"
        Me.ToolTip1.SetToolTip(Me.cmdVizualizareMasini, "Masinile din aplicatie")
        Me.cmdVizualizareMasini.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdGreseliUtilizatori)
        Me.GroupBox3.Controls.Add(Me.cmdVizualizareZileLibere)
        Me.GroupBox3.Controls.Add(Me.cmdVizualizareMasiniInexistente)
        Me.GroupBox3.Controls.Add(Me.cmdVizualizareUtilizatoriInexistenti)
        Me.GroupBox3.Controls.Add(Me.cmdVizualizareKmLogView)
        Me.GroupBox3.Controls.Add(Me.cmdVizualizareUtilizatori)
        Me.GroupBox3.Controls.Add(Me.cmdVizualizareMasini)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 131)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(229, 285)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Vizualizare"
        '
        'cmdGreseliUtilizatori
        '
        Me.cmdGreseliUtilizatori.Location = New System.Drawing.Point(6, 252)
        Me.cmdGreseliUtilizatori.Name = "cmdGreseliUtilizatori"
        Me.cmdGreseliUtilizatori.Size = New System.Drawing.Size(217, 26)
        Me.cmdGreseliUtilizatori.TabIndex = 56
        Me.cmdGreseliUtilizatori.Text = "Greseli utilizatori"
        Me.ToolTip1.SetToolTip(Me.cmdGreseliUtilizatori, "Afiseaza fereastra de gestionare si trimitere emailuri catre utilizatori functie " &
        "de greselile de introducere facute de fiecare.")
        Me.cmdGreseliUtilizatori.UseVisualStyleBackColor = True
        '
        'cmdVizualizareZileLibere
        '
        Me.cmdVizualizareZileLibere.Location = New System.Drawing.Point(6, 204)
        Me.cmdVizualizareZileLibere.Name = "cmdVizualizareZileLibere"
        Me.cmdVizualizareZileLibere.Size = New System.Drawing.Size(217, 26)
        Me.cmdVizualizareZileLibere.TabIndex = 55
        Me.cmdVizualizareZileLibere.Text = "Zile libere"
        Me.ToolTip1.SetToolTip(Me.cmdVizualizareZileLibere, "Zilele libere sunt foarte importante pentru stabilirea intervalelor de weekend. A" &
        "tentie cand sunt sarbatori legale nelegate de weekend.")
        Me.cmdVizualizareZileLibere.UseVisualStyleBackColor = True
        '
        'cmdVizualizareMasiniInexistente
        '
        Me.cmdVizualizareMasiniInexistente.Location = New System.Drawing.Point(6, 172)
        Me.cmdVizualizareMasiniInexistente.Name = "cmdVizualizareMasiniInexistente"
        Me.cmdVizualizareMasiniInexistente.Size = New System.Drawing.Size(217, 26)
        Me.cmdVizualizareMasiniInexistente.TabIndex = 54
        Me.cmdVizualizareMasiniInexistente.Text = "Masini inexistente"
        Me.ToolTip1.SetToolTip(Me.cmdVizualizareMasiniInexistente, "Masini care apar in foile de introducere dar nu exista in tabelul Masini din goog" &
        "le")
        Me.cmdVizualizareMasiniInexistente.UseVisualStyleBackColor = True
        '
        'cmdVizualizareUtilizatoriInexistenti
        '
        Me.cmdVizualizareUtilizatoriInexistenti.Location = New System.Drawing.Point(6, 140)
        Me.cmdVizualizareUtilizatoriInexistenti.Name = "cmdVizualizareUtilizatoriInexistenti"
        Me.cmdVizualizareUtilizatoriInexistenti.Size = New System.Drawing.Size(217, 26)
        Me.cmdVizualizareUtilizatoriInexistenti.TabIndex = 53
        Me.cmdVizualizareUtilizatoriInexistenti.Text = "Utilizatori inexistenti"
        Me.ToolTip1.SetToolTip(Me.cmdVizualizareUtilizatoriInexistenti, "Utilizatori care apar in foile de introducere dar nu exista in tabelul Utilizator" &
        "i din google. ")
        Me.cmdVizualizareUtilizatoriInexistenti.UseVisualStyleBackColor = True
        '
        'cmdVizualizareKmLogView
        '
        Me.cmdVizualizareKmLogView.Location = New System.Drawing.Point(3, 19)
        Me.cmdVizualizareKmLogView.Name = "cmdVizualizareKmLogView"
        Me.cmdVizualizareKmLogView.Size = New System.Drawing.Size(217, 26)
        Me.cmdVizualizareKmLogView.TabIndex = 52
        Me.cmdVizualizareKmLogView.Text = "Km"
        Me.ToolTip1.SetToolTip(Me.cmdVizualizareKmLogView, "Jurnalul de km")
        Me.cmdVizualizareKmLogView.UseVisualStyleBackColor = True
        '
        'cmdVizualizareUtilizatori
        '
        Me.cmdVizualizareUtilizatori.Location = New System.Drawing.Point(3, 78)
        Me.cmdVizualizareUtilizatori.Name = "cmdVizualizareUtilizatori"
        Me.cmdVizualizareUtilizatori.Size = New System.Drawing.Size(217, 26)
        Me.cmdVizualizareUtilizatori.TabIndex = 51
        Me.cmdVizualizareUtilizatori.Text = "Utilizatori"
        Me.ToolTip1.SetToolTip(Me.cmdVizualizareUtilizatori, "Utilizatorii din aplicatie")
        Me.cmdVizualizareUtilizatori.UseVisualStyleBackColor = True
        '
        'EmailMeTextBox
        '
        Me.EmailMeTextBox.Location = New System.Drawing.Point(363, 293)
        Me.EmailMeTextBox.Name = "EmailMeTextBox"
        Me.EmailMeTextBox.ReadOnly = True
        Me.EmailMeTextBox.Size = New System.Drawing.Size(414, 20)
        Me.EmailMeTextBox.TabIndex = 64
        '
        'EmailToTextBox
        '
        Me.EmailToTextBox.Location = New System.Drawing.Point(363, 267)
        Me.EmailToTextBox.Name = "EmailToTextBox"
        Me.EmailToTextBox.ReadOnly = True
        Me.EmailToTextBox.Size = New System.Drawing.Size(414, 20)
        Me.EmailToTextBox.TabIndex = 70
        '
        'EmailSendCheckBox
        '
        Me.EmailSendCheckBox.Enabled = False
        Me.EmailSendCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailSendCheckBox.Location = New System.Drawing.Point(255, 86)
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
        Me.ExtrageRapExcelDinBICheckBox.Location = New System.Drawing.Point(255, 116)
        Me.ExtrageRapExcelDinBICheckBox.Name = "ExtrageRapExcelDinBICheckBox"
        Me.ExtrageRapExcelDinBICheckBox.Size = New System.Drawing.Size(332, 24)
        Me.ExtrageRapExcelDinBICheckBox.TabIndex = 127
        Me.ExtrageRapExcelDinBICheckBox.Text = "Extrage km din spreadsheet-urile Google"
        Me.ExtrageRapExcelDinBICheckBox.UseVisualStyleBackColor = True
        '
        'ExtrageRapExcelDinERPCheckBox
        '
        Me.ExtrageRapExcelDinERPCheckBox.Enabled = False
        Me.ExtrageRapExcelDinERPCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtrageRapExcelDinERPCheckBox.Location = New System.Drawing.Point(255, 146)
        Me.ExtrageRapExcelDinERPCheckBox.Name = "ExtrageRapExcelDinERPCheckBox"
        Me.ExtrageRapExcelDinERPCheckBox.Size = New System.Drawing.Size(153, 24)
        Me.ExtrageRapExcelDinERPCheckBox.TabIndex = 128
        Me.ExtrageRapExcelDinERPCheckBox.Text = "Incarca utilizatori"
        Me.ExtrageRapExcelDinERPCheckBox.UseVisualStyleBackColor = True
        '
        'ExecutaSQLCheckBox
        '
        Me.ExecutaSQLCheckBox.Enabled = False
        Me.ExecutaSQLCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExecutaSQLCheckBox.Location = New System.Drawing.Point(255, 176)
        Me.ExecutaSQLCheckBox.Name = "ExecutaSQLCheckBox"
        Me.ExecutaSQLCheckBox.Size = New System.Drawing.Size(153, 24)
        Me.ExecutaSQLCheckBox.TabIndex = 129
        Me.ExecutaSQLCheckBox.Text = "Incarca masini"
        Me.ExecutaSQLCheckBox.UseVisualStyleBackColor = True
        '
        'NumarLuniActualizateTextBox
        '
        Me.NumarLuniActualizateTextBox.Location = New System.Drawing.Point(384, 209)
        Me.NumarLuniActualizateTextBox.Name = "NumarLuniActualizateTextBox"
        Me.NumarLuniActualizateTextBox.ReadOnly = True
        Me.NumarLuniActualizateTextBox.Size = New System.Drawing.Size(52, 20)
        Me.NumarLuniActualizateTextBox.TabIndex = 130
        '
        'cmdRenunta
        '
        Me.cmdRenunta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRenunta.Location = New System.Drawing.Point(871, 241)
        Me.cmdRenunta.Name = "cmdRenunta"
        Me.cmdRenunta.Size = New System.Drawing.Size(172, 63)
        Me.cmdRenunta.TabIndex = 133
        Me.cmdRenunta.Text = "Renunta"
        Me.cmdRenunta.UseVisualStyleBackColor = True
        '
        'txtTimer
        '
        Me.txtTimer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimer.Location = New System.Drawing.Point(7, 11)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.Size = New System.Drawing.Size(1033, 24)
        Me.txtTimer.TabIndex = 134
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(898, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 35)
        Me.Button1.TabIndex = 163
        Me.Button1.Text = "Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblToateInregistrarileSuntReferintaU
        '
        Me.lblToateInregistrarileSuntReferintaU.AutoSize = True
        Me.lblToateInregistrarileSuntReferintaU.BackColor = System.Drawing.Color.Transparent
        Me.lblToateInregistrarileSuntReferintaU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToateInregistrarileSuntReferintaU.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblToateInregistrarileSuntReferintaU.Location = New System.Drawing.Point(269, 637)
        Me.lblToateInregistrarileSuntReferintaU.Name = "lblToateInregistrarileSuntReferintaU"
        Me.lblToateInregistrarileSuntReferintaU.Size = New System.Drawing.Size(14, 16)
        Me.lblToateInregistrarileSuntReferintaU.TabIndex = 162
        Me.lblToateInregistrarileSuntReferintaU.Text = "0"
        '
        'lblToateInregistrarileSuntInteresServiciuU
        '
        Me.lblToateInregistrarileSuntInteresServiciuU.AutoSize = True
        Me.lblToateInregistrarileSuntInteresServiciuU.BackColor = System.Drawing.Color.Transparent
        Me.lblToateInregistrarileSuntInteresServiciuU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToateInregistrarileSuntInteresServiciuU.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblToateInregistrarileSuntInteresServiciuU.Location = New System.Drawing.Point(269, 611)
        Me.lblToateInregistrarileSuntInteresServiciuU.Name = "lblToateInregistrarileSuntInteresServiciuU"
        Me.lblToateInregistrarileSuntInteresServiciuU.Size = New System.Drawing.Size(14, 16)
        Me.lblToateInregistrarileSuntInteresServiciuU.TabIndex = 161
        Me.lblToateInregistrarileSuntInteresServiciuU.Text = "0"
        '
        'lblDouaInregistrariAdiacenteReferintaU
        '
        Me.lblDouaInregistrariAdiacenteReferintaU.AutoSize = True
        Me.lblDouaInregistrariAdiacenteReferintaU.BackColor = System.Drawing.Color.Transparent
        Me.lblDouaInregistrariAdiacenteReferintaU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDouaInregistrariAdiacenteReferintaU.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDouaInregistrariAdiacenteReferintaU.Location = New System.Drawing.Point(269, 585)
        Me.lblDouaInregistrariAdiacenteReferintaU.Name = "lblDouaInregistrariAdiacenteReferintaU"
        Me.lblDouaInregistrariAdiacenteReferintaU.Size = New System.Drawing.Size(14, 16)
        Me.lblDouaInregistrariAdiacenteReferintaU.TabIndex = 160
        Me.lblDouaInregistrariAdiacenteReferintaU.Text = "0"
        '
        'lblPrimaInregistrareNuEReferintaU
        '
        Me.lblPrimaInregistrareNuEReferintaU.AutoSize = True
        Me.lblPrimaInregistrareNuEReferintaU.BackColor = System.Drawing.Color.Transparent
        Me.lblPrimaInregistrareNuEReferintaU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimaInregistrareNuEReferintaU.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrimaInregistrareNuEReferintaU.Location = New System.Drawing.Point(269, 559)
        Me.lblPrimaInregistrareNuEReferintaU.Name = "lblPrimaInregistrareNuEReferintaU"
        Me.lblPrimaInregistrareNuEReferintaU.Size = New System.Drawing.Size(14, 16)
        Me.lblPrimaInregistrareNuEReferintaU.TabIndex = 159
        Me.lblPrimaInregistrareNuEReferintaU.Text = "0"
        '
        'lblIndexeInversateU
        '
        Me.lblIndexeInversateU.AutoSize = True
        Me.lblIndexeInversateU.BackColor = System.Drawing.Color.Transparent
        Me.lblIndexeInversateU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndexeInversateU.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIndexeInversateU.Location = New System.Drawing.Point(269, 533)
        Me.lblIndexeInversateU.Name = "lblIndexeInversateU"
        Me.lblIndexeInversateU.Size = New System.Drawing.Size(14, 16)
        Me.lblIndexeInversateU.TabIndex = 158
        Me.lblIndexeInversateU.Text = "0"
        '
        'lblKmPreaMultiU
        '
        Me.lblKmPreaMultiU.AutoSize = True
        Me.lblKmPreaMultiU.BackColor = System.Drawing.Color.Transparent
        Me.lblKmPreaMultiU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKmPreaMultiU.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblKmPreaMultiU.Location = New System.Drawing.Point(269, 507)
        Me.lblKmPreaMultiU.Name = "lblKmPreaMultiU"
        Me.lblKmPreaMultiU.Size = New System.Drawing.Size(14, 16)
        Me.lblKmPreaMultiU.TabIndex = 157
        Me.lblKmPreaMultiU.Text = "0"
        '
        'lblOSinguraInregistrareU
        '
        Me.lblOSinguraInregistrareU.AutoSize = True
        Me.lblOSinguraInregistrareU.BackColor = System.Drawing.Color.Transparent
        Me.lblOSinguraInregistrareU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSinguraInregistrareU.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOSinguraInregistrareU.Location = New System.Drawing.Point(269, 481)
        Me.lblOSinguraInregistrareU.Name = "lblOSinguraInregistrareU"
        Me.lblOSinguraInregistrareU.Size = New System.Drawing.Size(14, 16)
        Me.lblOSinguraInregistrareU.TabIndex = 156
        Me.lblOSinguraInregistrareU.Text = "0"
        '
        'lblZeroInregistrariU
        '
        Me.lblZeroInregistrariU.AutoSize = True
        Me.lblZeroInregistrariU.BackColor = System.Drawing.Color.Transparent
        Me.lblZeroInregistrariU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZeroInregistrariU.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZeroInregistrariU.Location = New System.Drawing.Point(269, 456)
        Me.lblZeroInregistrariU.Name = "lblZeroInregistrariU"
        Me.lblZeroInregistrariU.Size = New System.Drawing.Size(14, 16)
        Me.lblZeroInregistrariU.TabIndex = 155
        Me.lblZeroInregistrariU.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(325, 433)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 13)
        Me.Label12.TabIndex = 154
        Me.Label12.Text = "Total inregistrari"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(221, 433)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "Numar utilizatori"
        '
        'lblToateInregistrarileSuntReferintaT
        '
        Me.lblToateInregistrarileSuntReferintaT.AutoSize = True
        Me.lblToateInregistrarileSuntReferintaT.BackColor = System.Drawing.Color.Transparent
        Me.lblToateInregistrarileSuntReferintaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToateInregistrarileSuntReferintaT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblToateInregistrarileSuntReferintaT.Location = New System.Drawing.Point(368, 637)
        Me.lblToateInregistrarileSuntReferintaT.Name = "lblToateInregistrarileSuntReferintaT"
        Me.lblToateInregistrarileSuntReferintaT.Size = New System.Drawing.Size(14, 16)
        Me.lblToateInregistrarileSuntReferintaT.TabIndex = 152
        Me.lblToateInregistrarileSuntReferintaT.Text = "0"
        '
        'lblToateInregistrarileSuntInteresServiciuT
        '
        Me.lblToateInregistrarileSuntInteresServiciuT.AutoSize = True
        Me.lblToateInregistrarileSuntInteresServiciuT.BackColor = System.Drawing.Color.Transparent
        Me.lblToateInregistrarileSuntInteresServiciuT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToateInregistrarileSuntInteresServiciuT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblToateInregistrarileSuntInteresServiciuT.Location = New System.Drawing.Point(368, 611)
        Me.lblToateInregistrarileSuntInteresServiciuT.Name = "lblToateInregistrarileSuntInteresServiciuT"
        Me.lblToateInregistrarileSuntInteresServiciuT.Size = New System.Drawing.Size(14, 16)
        Me.lblToateInregistrarileSuntInteresServiciuT.TabIndex = 151
        Me.lblToateInregistrarileSuntInteresServiciuT.Text = "0"
        '
        'lblDouaInregistrariAdiacenteReferintaT
        '
        Me.lblDouaInregistrariAdiacenteReferintaT.AutoSize = True
        Me.lblDouaInregistrariAdiacenteReferintaT.BackColor = System.Drawing.Color.Transparent
        Me.lblDouaInregistrariAdiacenteReferintaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDouaInregistrariAdiacenteReferintaT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDouaInregistrariAdiacenteReferintaT.Location = New System.Drawing.Point(368, 585)
        Me.lblDouaInregistrariAdiacenteReferintaT.Name = "lblDouaInregistrariAdiacenteReferintaT"
        Me.lblDouaInregistrariAdiacenteReferintaT.Size = New System.Drawing.Size(14, 16)
        Me.lblDouaInregistrariAdiacenteReferintaT.TabIndex = 150
        Me.lblDouaInregistrariAdiacenteReferintaT.Text = "0"
        '
        'lblPrimaInregistrareNuEReferintaT
        '
        Me.lblPrimaInregistrareNuEReferintaT.AutoSize = True
        Me.lblPrimaInregistrareNuEReferintaT.BackColor = System.Drawing.Color.Transparent
        Me.lblPrimaInregistrareNuEReferintaT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimaInregistrareNuEReferintaT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPrimaInregistrareNuEReferintaT.Location = New System.Drawing.Point(368, 559)
        Me.lblPrimaInregistrareNuEReferintaT.Name = "lblPrimaInregistrareNuEReferintaT"
        Me.lblPrimaInregistrareNuEReferintaT.Size = New System.Drawing.Size(14, 16)
        Me.lblPrimaInregistrareNuEReferintaT.TabIndex = 149
        Me.lblPrimaInregistrareNuEReferintaT.Text = "0"
        '
        'lblIndexeInversateT
        '
        Me.lblIndexeInversateT.AutoSize = True
        Me.lblIndexeInversateT.BackColor = System.Drawing.Color.Transparent
        Me.lblIndexeInversateT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIndexeInversateT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIndexeInversateT.Location = New System.Drawing.Point(368, 533)
        Me.lblIndexeInversateT.Name = "lblIndexeInversateT"
        Me.lblIndexeInversateT.Size = New System.Drawing.Size(14, 16)
        Me.lblIndexeInversateT.TabIndex = 147
        Me.lblIndexeInversateT.Text = "0"
        '
        'lblKmPreaMultiT
        '
        Me.lblKmPreaMultiT.AutoSize = True
        Me.lblKmPreaMultiT.BackColor = System.Drawing.Color.Transparent
        Me.lblKmPreaMultiT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKmPreaMultiT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblKmPreaMultiT.Location = New System.Drawing.Point(368, 507)
        Me.lblKmPreaMultiT.Name = "lblKmPreaMultiT"
        Me.lblKmPreaMultiT.Size = New System.Drawing.Size(14, 16)
        Me.lblKmPreaMultiT.TabIndex = 146
        Me.lblKmPreaMultiT.Text = "0"
        '
        'lblOSinguraInregistrareT
        '
        Me.lblOSinguraInregistrareT.AutoSize = True
        Me.lblOSinguraInregistrareT.BackColor = System.Drawing.Color.Transparent
        Me.lblOSinguraInregistrareT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOSinguraInregistrareT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOSinguraInregistrareT.Location = New System.Drawing.Point(368, 481)
        Me.lblOSinguraInregistrareT.Name = "lblOSinguraInregistrareT"
        Me.lblOSinguraInregistrareT.Size = New System.Drawing.Size(14, 16)
        Me.lblOSinguraInregistrareT.TabIndex = 145
        Me.lblOSinguraInregistrareT.Text = "0"
        '
        'lblZeroInregistrariT
        '
        Me.lblZeroInregistrariT.AutoSize = True
        Me.lblZeroInregistrariT.BackColor = System.Drawing.Color.Transparent
        Me.lblZeroInregistrariT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZeroInregistrariT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblZeroInregistrariT.Location = New System.Drawing.Point(368, 456)
        Me.lblZeroInregistrariT.Name = "lblZeroInregistrariT"
        Me.lblZeroInregistrariT.Size = New System.Drawing.Size(14, 16)
        Me.lblZeroInregistrariT.TabIndex = 144
        Me.lblZeroInregistrariT.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Red
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(20, 507)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 16)
        Me.Label11.TabIndex = 143
        Me.Label11.Text = "Km prea multi"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.MediumPurple
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gold
        Me.Label10.Location = New System.Drawing.Point(20, 533)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 16)
        Me.Label10.TabIndex = 142
        Me.Label10.Text = "Indexe inversate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 559)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 16)
        Me.Label9.TabIndex = 141
        Me.Label9.Text = "Prima inregistrare nu e referinta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 585)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(219, 16)
        Me.Label8.TabIndex = 140
        Me.Label8.Text = "Doua inregistrari adiacente referinta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 611)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(238, 16)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "Toate inregistrarile sunt interes serviciu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 637)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 16)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "Toate inregistrarile sunt referinta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 456)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Zero inregistrari"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.NavajoWhite
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 481)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 16)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "O singura inregistrare"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 433)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 13)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Greseli in introducerea datelor:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(707, 28)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Km Auto - aplicatie pentru evidenta utilizarii masinilor Consolight in interes pe" &
    "rsonal"
        '
        'CombustibiliTableAdapter1
        '
        Me.CombustibiliTableAdapter1.ClearBeforeFill = True
        '
        'KmAutoDataSet
        '
        Me.KmAutoDataSet.DataSetName = "KmAutoDataSet"
        Me.KmAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(871, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 35)
        Me.Button2.TabIndex = 164
        Me.Button2.Text = "Inchide"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 665)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(247, 16)
        Me.Label13.TabIndex = 165
        Me.Label13.Text = "Completare inutila a datei de introducere"
        '
        'lblCompletareInutilaADateiDeIntroducereU
        '
        Me.lblCompletareInutilaADateiDeIntroducereU.AutoSize = True
        Me.lblCompletareInutilaADateiDeIntroducereU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletareInutilaADateiDeIntroducereU.Location = New System.Drawing.Point(269, 665)
        Me.lblCompletareInutilaADateiDeIntroducereU.Name = "lblCompletareInutilaADateiDeIntroducereU"
        Me.lblCompletareInutilaADateiDeIntroducereU.Size = New System.Drawing.Size(14, 16)
        Me.lblCompletareInutilaADateiDeIntroducereU.TabIndex = 202
        Me.lblCompletareInutilaADateiDeIntroducereU.Text = "0"
        '
        'lblCompletareInutilaADateiDeIntroducereT
        '
        Me.lblCompletareInutilaADateiDeIntroducereT.AutoSize = True
        Me.lblCompletareInutilaADateiDeIntroducereT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletareInutilaADateiDeIntroducereT.Location = New System.Drawing.Point(368, 665)
        Me.lblCompletareInutilaADateiDeIntroducereT.Name = "lblCompletareInutilaADateiDeIntroducereT"
        Me.lblCompletareInutilaADateiDeIntroducereT.Size = New System.Drawing.Size(14, 16)
        Me.lblCompletareInutilaADateiDeIntroducereT.TabIndex = 201
        Me.lblCompletareInutilaADateiDeIntroducereT.Text = "0"
        '
        'ImpartePeFilialeCheckBox
        '
        Me.ImpartePeFilialeCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImpartePeFilialeCheckBox.ForeColor = System.Drawing.Color.Blue
        Me.ImpartePeFilialeCheckBox.Location = New System.Drawing.Point(363, 350)
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
        Me.ImpartePeAgentiCheckBox.Location = New System.Drawing.Point(577, 350)
        Me.ImpartePeAgentiCheckBox.Name = "ImpartePeAgentiCheckBox"
        Me.ImpartePeAgentiCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.ImpartePeAgentiCheckBox.TabIndex = 204
        Me.ImpartePeAgentiCheckBox.Text = "Trimite emailuri la agenti"
        Me.ToolTip1.SetToolTip(Me.ImpartePeAgentiCheckBox, "Se pot trimite si la agenti daca se doreste. Functionalitatea este realizata, tre" &
        "buie doar activata.")
        Me.ImpartePeAgentiCheckBox.UseVisualStyleBackColor = True
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
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1044, 734)
        Me.Controls.Add(Me.ImpartePeAgentiCheckBox)
        Me.Controls.Add(Me.ImpartePeFilialeCheckBox)
        Me.Controls.Add(Me.lblCompletareInutilaADateiDeIntroducereU)
        Me.Controls.Add(Me.lblCompletareInutilaADateiDeIntroducereT)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblToateInregistrarileSuntReferintaU)
        Me.Controls.Add(Me.lblToateInregistrarileSuntInteresServiciuU)
        Me.Controls.Add(Me.lblDouaInregistrariAdiacenteReferintaU)
        Me.Controls.Add(Me.txtTimer)
        Me.Controls.Add(Me.lblPrimaInregistrareNuEReferintaU)
        Me.Controls.Add(Me.LabelDataInterogare)
        Me.Controls.Add(Me.lblIndexeInversateU)
        Me.Controls.Add(EmailMeLabel)
        Me.Controls.Add(Me.lblKmPreaMultiU)
        Me.Controls.Add(Me.ExtrageRapExcelDinBICheckBox)
        Me.Controls.Add(Me.lblOSinguraInregistrareU)
        Me.Controls.Add(Me.EmailMeTextBox)
        Me.Controls.Add(Me.lblZeroInregistrariU)
        Me.Controls.Add(Me.ExtrageRapExcelDinERPCheckBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(EmailToLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ExecutaSQLCheckBox)
        Me.Controls.Add(Me.lblToateInregistrarileSuntReferintaT)
        Me.Controls.Add(Me.EmailToTextBox)
        Me.Controls.Add(Me.lblToateInregistrarileSuntInteresServiciuT)
        Me.Controls.Add(Me.NumarLuniActualizateTextBox)
        Me.Controls.Add(Me.lblDouaInregistrariAdiacenteReferintaT)
        Me.Controls.Add(Me.EmailSendCheckBox)
        Me.Controls.Add(Me.lblPrimaInregistrareNuEReferintaT)
        Me.Controls.Add(Me.cmdExecuta)
        Me.Controls.Add(Me.lblIndexeInversateT)
        Me.Controls.Add(NumarLuniActualizateLabel)
        Me.Controls.Add(Me.lblKmPreaMultiT)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lblOSinguraInregistrareT)
        Me.Controls.Add(Me.cmdRenunta)
        Me.Controls.Add(Me.lblZeroInregistrariT)
        Me.Controls.Add(Me.dtpDataRaportarii)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.MinimumSize = New System.Drawing.Size(1060, 551)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Km Auto"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.KmAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreseliLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RobotsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDataRaportarii As DateTimePicker
    Friend WithEvents LabelDataInterogare As Label
    Friend WithEvents cmdExecuta As Button
    Friend WithEvents cmdVizualizareMasini As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmdVizualizareZileLibere As Button
    Friend WithEvents cmdVizualizareMasiniInexistente As Button
    Friend WithEvents cmdVizualizareUtilizatoriInexistenti As Button
    Friend WithEvents cmdVizualizareKmLogView As Button
    Friend WithEvents cmdVizualizareUtilizatori As Button
    Friend WithEvents RobotsDataSet As RobotsDataSet
    Friend WithEvents ConfigTableAdapter As RobotsDataSetTableAdapters.ConfigTableAdapter
    Friend WithEvents TableAdapterManager As RobotsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmailMeTextBox As TextBox
    Friend WithEvents EmailToTextBox As TextBox
    Friend WithEvents EmailSendCheckBox As CheckBox
    Friend WithEvents ExtrageRapExcelDinBICheckBox As CheckBox
    Friend WithEvents ExtrageRapExcelDinERPCheckBox As CheckBox
    Friend WithEvents ExecutaSQLCheckBox As CheckBox
    Friend WithEvents NumarLuniActualizateTextBox As TextBox
    Friend WithEvents CombustibiliTableAdapter1 As KmAutoDataSetTableAdapters.CombustibiliTableAdapter
    Friend WithEvents cmdRenunta As Button
    Friend WithEvents txtTimer As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents KmAutoDataSet As KmAutoDataSet
    Friend WithEvents GreseliLogBindingSource As BindingSource
    Friend WithEvents GreseliLogTableAdapter As KmAutoDataSetTableAdapters.GreseliLogTableAdapter
    Friend WithEvents cmdGreseliUtilizatori As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblToateInregistrarileSuntReferintaT As Label
    Friend WithEvents lblToateInregistrarileSuntInteresServiciuT As Label
    Friend WithEvents lblDouaInregistrariAdiacenteReferintaT As Label
    Friend WithEvents lblPrimaInregistrareNuEReferintaT As Label
    Friend WithEvents lblIndexeInversateT As Label
    Friend WithEvents lblKmPreaMultiT As Label
    Friend WithEvents lblOSinguraInregistrareT As Label
    Friend WithEvents lblZeroInregistrariT As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblToateInregistrarileSuntReferintaU As Label
    Friend WithEvents lblToateInregistrarileSuntInteresServiciuU As Label
    Friend WithEvents lblDouaInregistrariAdiacenteReferintaU As Label
    Friend WithEvents lblPrimaInregistrareNuEReferintaU As Label
    Friend WithEvents lblIndexeInversateU As Label
    Friend WithEvents lblKmPreaMultiU As Label
    Friend WithEvents lblOSinguraInregistrareU As Label
    Friend WithEvents lblZeroInregistrariU As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents lblCompletareInutilaADateiDeIntroducereU As Label
    Friend WithEvents lblCompletareInutilaADateiDeIntroducereT As Label
    Friend WithEvents ImpartePeFilialeCheckBox As CheckBox
    Friend WithEvents ImpartePeAgentiCheckBox As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
