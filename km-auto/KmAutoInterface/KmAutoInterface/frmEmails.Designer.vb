<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmails))
        Me.lvFiliale = New System.Windows.Forms.ListView()
        Me.NumeFiliala = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ResponsabilFiliala = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EmailFiliala = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdTrimite = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdSelecteazaTotFiliale = New System.Windows.Forms.Button()
        Me.cmdDeselecteazaTotFiliale = New System.Windows.Forms.Button()
        Me.cmdDeselecteazaTotUtilizatori = New System.Windows.Forms.Button()
        Me.cmdSelecteazaTotUtilizatori = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lvUtilizatori = New System.Windows.Forms.ListView()
        Me.NumeUtilizator = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EmailUtilizator = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EmailConsolightUtilizator = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Telefon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbCautare = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdStergeCrt = New System.Windows.Forms.Button()
        Me.cmdStergeListaCautare = New System.Windows.Forms.Button()
        Me.cmbSubiect = New System.Windows.Forms.ComboBox()
        Me.cmdAddAtach = New System.Windows.Forms.Button()
        Me.TextBoxAtasamente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ssInfo = New System.Windows.Forms.StatusStrip()
        Me.lbInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbIncarca = New System.Windows.Forms.ToolStripProgressBar()
        Me.cmdInchide = New System.Windows.Forms.Button()
        Me.TextBoxSelectareAutomataText = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbCautareSelectare = New System.Windows.Forms.ComboBox()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdTot = New System.Windows.Forms.Button()
        Me.ssInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvFiliale
        '
        Me.lvFiliale.CheckBoxes = True
        Me.lvFiliale.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NumeFiliala, Me.ResponsabilFiliala, Me.EmailFiliala})
        Me.lvFiliale.HideSelection = False
        Me.lvFiliale.Location = New System.Drawing.Point(12, 42)
        Me.lvFiliale.Name = "lvFiliale"
        Me.lvFiliale.Size = New System.Drawing.Size(689, 246)
        Me.lvFiliale.TabIndex = 0
        Me.lvFiliale.UseCompatibleStateImageBehavior = False
        Me.lvFiliale.View = System.Windows.Forms.View.Details
        '
        'NumeFiliala
        '
        Me.NumeFiliala.Text = "Nume"
        '
        'ResponsabilFiliala
        '
        Me.ResponsabilFiliala.Text = "Responsabil"
        '
        'EmailFiliala
        '
        Me.EmailFiliala.Text = "Email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(707, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Subiect"
        '
        'textBoxEmail
        '
        Me.textBoxEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxEmail.Location = New System.Drawing.Point(707, 180)
        Me.textBoxEmail.Multiline = True
        Me.textBoxEmail.Name = "textBoxEmail"
        Me.textBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBoxEmail.Size = New System.Drawing.Size(431, 496)
        Me.textBoxEmail.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(707, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Continut"
        '
        'cmdTrimite
        '
        Me.cmdTrimite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTrimite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTrimite.ForeColor = System.Drawing.Color.Red
        Me.cmdTrimite.Location = New System.Drawing.Point(946, 3)
        Me.cmdTrimite.Name = "cmdTrimite"
        Me.cmdTrimite.Size = New System.Drawing.Size(81, 47)
        Me.cmdTrimite.TabIndex = 6
        Me.cmdTrimite.Text = "Trimite"
        Me.cmdTrimite.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Filiale"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Utilizatori"
        '
        'cmdSelecteazaTotFiliale
        '
        Me.cmdSelecteazaTotFiliale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelecteazaTotFiliale.ForeColor = System.Drawing.Color.Blue
        Me.cmdSelecteazaTotFiliale.Location = New System.Drawing.Point(426, 9)
        Me.cmdSelecteazaTotFiliale.Name = "cmdSelecteazaTotFiliale"
        Me.cmdSelecteazaTotFiliale.Size = New System.Drawing.Size(131, 27)
        Me.cmdSelecteazaTotFiliale.TabIndex = 9
        Me.cmdSelecteazaTotFiliale.Text = "Selecteaza tot"
        Me.cmdSelecteazaTotFiliale.UseVisualStyleBackColor = True
        '
        'cmdDeselecteazaTotFiliale
        '
        Me.cmdDeselecteazaTotFiliale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeselecteazaTotFiliale.ForeColor = System.Drawing.Color.Green
        Me.cmdDeselecteazaTotFiliale.Location = New System.Drawing.Point(563, 9)
        Me.cmdDeselecteazaTotFiliale.Name = "cmdDeselecteazaTotFiliale"
        Me.cmdDeselecteazaTotFiliale.Size = New System.Drawing.Size(138, 27)
        Me.cmdDeselecteazaTotFiliale.TabIndex = 10
        Me.cmdDeselecteazaTotFiliale.Text = "Deselecteaza tot"
        Me.cmdDeselecteazaTotFiliale.UseVisualStyleBackColor = True
        '
        'cmdDeselecteazaTotUtilizatori
        '
        Me.cmdDeselecteazaTotUtilizatori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeselecteazaTotUtilizatori.ForeColor = System.Drawing.Color.Green
        Me.cmdDeselecteazaTotUtilizatori.Location = New System.Drawing.Point(484, 317)
        Me.cmdDeselecteazaTotUtilizatori.Name = "cmdDeselecteazaTotUtilizatori"
        Me.cmdDeselecteazaTotUtilizatori.Size = New System.Drawing.Size(137, 27)
        Me.cmdDeselecteazaTotUtilizatori.TabIndex = 12
        Me.cmdDeselecteazaTotUtilizatori.Text = "Deselecteaza tot"
        Me.cmdDeselecteazaTotUtilizatori.UseVisualStyleBackColor = True
        '
        'cmdSelecteazaTotUtilizatori
        '
        Me.cmdSelecteazaTotUtilizatori.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSelecteazaTotUtilizatori.ForeColor = System.Drawing.Color.Blue
        Me.cmdSelecteazaTotUtilizatori.Location = New System.Drawing.Point(362, 317)
        Me.cmdSelecteazaTotUtilizatori.Name = "cmdSelecteazaTotUtilizatori"
        Me.cmdSelecteazaTotUtilizatori.Size = New System.Drawing.Size(116, 27)
        Me.cmdSelecteazaTotUtilizatori.TabIndex = 11
        Me.cmdSelecteazaTotUtilizatori.Text = "Selecteaza tot"
        Me.cmdSelecteazaTotUtilizatori.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lvUtilizatori
        '
        Me.lvUtilizatori.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvUtilizatori.CheckBoxes = True
        Me.lvUtilizatori.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NumeUtilizator, Me.EmailUtilizator, Me.EmailConsolightUtilizator, Me.Telefon})
        Me.lvUtilizatori.HideSelection = False
        Me.lvUtilizatori.Location = New System.Drawing.Point(12, 351)
        Me.lvUtilizatori.Name = "lvUtilizatori"
        Me.lvUtilizatori.Size = New System.Drawing.Size(488, 325)
        Me.lvUtilizatori.TabIndex = 15
        Me.lvUtilizatori.UseCompatibleStateImageBehavior = False
        Me.lvUtilizatori.View = System.Windows.Forms.View.Details
        '
        'NumeUtilizator
        '
        Me.NumeUtilizator.Text = "Nume"
        '
        'EmailUtilizator
        '
        Me.EmailUtilizator.Text = "Email"
        '
        'EmailConsolightUtilizator
        '
        Me.EmailConsolightUtilizator.Text = "Email Consolight"
        '
        'Telefon
        '
        Me.Telefon.Text = "Telefon"
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'cmbCautare
        '
        Me.cmbCautare.FormattingEnabled = True
        Me.cmbCautare.Location = New System.Drawing.Point(145, 294)
        Me.cmbCautare.Name = "cmbCautare"
        Me.cmbCautare.Size = New System.Drawing.Size(200, 21)
        Me.cmbCautare.TabIndex = 209
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(84, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 208
        Me.Label5.Text = "Cautare:"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'cmdStergeCrt
        '
        Me.cmdStergeCrt.Location = New System.Drawing.Point(145, 321)
        Me.cmdStergeCrt.Name = "cmdStergeCrt"
        Me.cmdStergeCrt.Size = New System.Drawing.Size(82, 23)
        Me.cmdStergeCrt.TabIndex = 212
        Me.cmdStergeCrt.Text = "Sterge crt."
        Me.cmdStergeCrt.UseVisualStyleBackColor = True
        '
        'cmdStergeListaCautare
        '
        Me.cmdStergeListaCautare.Location = New System.Drawing.Point(233, 321)
        Me.cmdStergeListaCautare.Name = "cmdStergeListaCautare"
        Me.cmdStergeListaCautare.Size = New System.Drawing.Size(112, 23)
        Me.cmdStergeListaCautare.TabIndex = 211
        Me.cmdStergeListaCautare.Text = "Sterge lista cautare"
        Me.cmdStergeListaCautare.UseVisualStyleBackColor = True
        '
        'cmbSubiect
        '
        Me.cmbSubiect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSubiect.FormattingEnabled = True
        Me.cmbSubiect.Items.AddRange(New Object() {"KmAuto informare", "kmAuto notificare"})
        Me.cmbSubiect.Location = New System.Drawing.Point(707, 140)
        Me.cmbSubiect.Name = "cmbSubiect"
        Me.cmbSubiect.Size = New System.Drawing.Size(431, 21)
        Me.cmbSubiect.TabIndex = 213
        '
        'cmdAddAtach
        '
        Me.cmdAddAtach.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddAtach.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddAtach.ForeColor = System.Drawing.Color.Red
        Me.cmdAddAtach.Location = New System.Drawing.Point(833, 3)
        Me.cmdAddAtach.Name = "cmdAddAtach"
        Me.cmdAddAtach.Size = New System.Drawing.Size(107, 47)
        Me.cmdAddAtach.TabIndex = 214
        Me.cmdAddAtach.Text = "Adaugare fisiere"
        Me.cmdAddAtach.UseVisualStyleBackColor = True
        '
        'TextBoxAtasamente
        '
        Me.TextBoxAtasamente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAtasamente.Location = New System.Drawing.Point(707, 56)
        Me.TextBoxAtasamente.Multiline = True
        Me.TextBoxAtasamente.Name = "TextBoxAtasamente"
        Me.TextBoxAtasamente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxAtasamente.Size = New System.Drawing.Size(431, 65)
        Me.TextBoxAtasamente.TabIndex = 215
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(707, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 216
        Me.Label6.Text = "Atasamente"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'ssInfo
        '
        Me.ssInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbInfo, Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1, Me.pbIncarca})
        Me.ssInfo.Location = New System.Drawing.Point(0, 666)
        Me.ssInfo.Name = "ssInfo"
        Me.ssInfo.Size = New System.Drawing.Size(1150, 22)
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
        'cmdInchide
        '
        Me.cmdInchide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdInchide.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInchide.ForeColor = System.Drawing.Color.Black
        Me.cmdInchide.Location = New System.Drawing.Point(1057, 3)
        Me.cmdInchide.Name = "cmdInchide"
        Me.cmdInchide.Size = New System.Drawing.Size(81, 47)
        Me.cmdInchide.TabIndex = 224
        Me.cmdInchide.Text = "Inchide"
        Me.cmdInchide.UseVisualStyleBackColor = True
        '
        'TextBoxSelectareAutomataText
        '
        Me.TextBoxSelectareAutomataText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSelectareAutomataText.Location = New System.Drawing.Point(506, 351)
        Me.TextBoxSelectareAutomataText.Multiline = True
        Me.TextBoxSelectareAutomataText.Name = "TextBoxSelectareAutomataText"
        Me.TextBoxSelectareAutomataText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxSelectareAutomataText.Size = New System.Drawing.Size(195, 312)
        Me.TextBoxSelectareAutomataText.TabIndex = 225
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(627, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 27)
        Me.Button1.TabIndex = 226
        Me.Button1.Text = "Text"
        Me.ToolTip1.SetToolTip(Me.Button1, "Daca in caseta de mai jos se gaseste o lista cu nume, o va selecta in lista Utili" &
        "zatori")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(384, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 13)
        Me.Label7.TabIndex = 228
        Me.Label7.Text = "Cautare selectare:"
        Me.ToolTip1.SetToolTip(Me.Label7, "Va pozitiona linia curenta pe numele cautat")
        '
        'cmbCautareSelectare
        '
        Me.cmbCautareSelectare.FormattingEnabled = True
        Me.cmbCautareSelectare.Location = New System.Drawing.Point(501, 294)
        Me.cmbCautareSelectare.Name = "cmbCautareSelectare"
        Me.cmbCautareSelectare.Size = New System.Drawing.Size(200, 21)
        Me.cmbCautareSelectare.TabIndex = 227
        '
        'Timer4
        '
        Me.Timer4.Interval = 1000
        '
        'cmdTot
        '
        Me.cmdTot.Location = New System.Drawing.Point(105, 321)
        Me.cmdTot.Name = "cmdTot"
        Me.cmdTot.Size = New System.Drawing.Size(34, 23)
        Me.cmdTot.TabIndex = 229
        Me.cmdTot.Text = "Tot"
        Me.cmdTot.UseVisualStyleBackColor = True
        '
        'frmEmails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 688)
        Me.Controls.Add(Me.cmdTot)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbCautareSelectare)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxSelectareAutomataText)
        Me.Controls.Add(Me.cmdInchide)
        Me.Controls.Add(Me.ssInfo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxAtasamente)
        Me.Controls.Add(Me.cmdAddAtach)
        Me.Controls.Add(Me.cmbSubiect)
        Me.Controls.Add(Me.cmdStergeCrt)
        Me.Controls.Add(Me.cmdStergeListaCautare)
        Me.Controls.Add(Me.cmbCautare)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lvUtilizatori)
        Me.Controls.Add(Me.lvFiliale)
        Me.Controls.Add(Me.cmdDeselecteazaTotUtilizatori)
        Me.Controls.Add(Me.cmdSelecteazaTotUtilizatori)
        Me.Controls.Add(Me.cmdDeselecteazaTotFiliale)
        Me.Controls.Add(Me.cmdSelecteazaTotFiliale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdTrimite)
        Me.Controls.Add(Me.textBoxEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEmails"
        Me.Text = "frmEmails"
        Me.ssInfo.ResumeLayout(False)
        Me.ssInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvFiliale As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents textBoxEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdTrimite As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdSelecteazaTotFiliale As Button
    Friend WithEvents cmdDeselecteazaTotFiliale As Button
    Friend WithEvents cmdDeselecteazaTotUtilizatori As Button
    Friend WithEvents cmdSelecteazaTotUtilizatori As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NumeFiliala As ColumnHeader
    Friend WithEvents ResponsabilFiliala As ColumnHeader
    Friend WithEvents EmailFiliala As ColumnHeader
    Friend WithEvents lvUtilizatori As ListView
    Friend WithEvents NumeUtilizator As ColumnHeader
    Friend WithEvents EmailUtilizator As ColumnHeader
    Friend WithEvents EmailConsolightUtilizator As ColumnHeader
    Friend WithEvents Timer3 As Timer
    Friend WithEvents cmbCautare As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents cmdStergeCrt As Button
    Friend WithEvents cmdStergeListaCautare As Button
    Friend WithEvents cmbSubiect As ComboBox
    Friend WithEvents cmdAddAtach As Button
    Friend WithEvents TextBoxAtasamente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ssInfo As StatusStrip
    Friend WithEvents lbInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents pbIncarca As ToolStripProgressBar
    Friend WithEvents cmdInchide As Button
    Friend WithEvents TextBoxSelectareAutomataText As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Telefon As ColumnHeader
    Friend WithEvents cmbCautareSelectare As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer4 As Timer
    Friend WithEvents cmdTot As Button
End Class
