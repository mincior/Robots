<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDateExterne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDateExterne))
        Me.ssInfo = New System.Windows.Forms.StatusStrip()
        Me.lbInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbIncarca = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdIncarcaFisiereBenzinarii = New System.Windows.Forms.ToolStripButton()
        Me.cmdStergeDateBenzinarii = New System.Windows.Forms.ToolStripButton()
        Me.cmdActivitateZilnicaPeIntervale = New System.Windows.Forms.ToolStripButton()
        Me.cmdIesire = New System.Windows.Forms.ToolStripButton()
        Me.cmdStergeTabelActivitateZilnica = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperatiiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncarcaFisierBenzinariiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ITrackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivitateZilnicaPeIntervaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ssInfo.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ssInfo
        '
        Me.ssInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbInfo, Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1, Me.pbIncarca})
        Me.ssInfo.Location = New System.Drawing.Point(0, 573)
        Me.ssInfo.Name = "ssInfo"
        Me.ssInfo.Size = New System.Drawing.Size(870, 22)
        Me.ssInfo.TabIndex = 235
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
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdIncarcaFisiereBenzinarii, Me.cmdStergeDateBenzinarii, Me.cmdActivitateZilnicaPeIntervale, Me.cmdIesire, Me.cmdStergeTabelActivitateZilnica})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 33)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(852, 80)
        Me.ToolStrip1.TabIndex = 234
        '
        'cmdIncarcaFisiereBenzinarii
        '
        Me.cmdIncarcaFisiereBenzinarii.Image = CType(resources.GetObject("cmdIncarcaFisiereBenzinarii.Image"), System.Drawing.Image)
        Me.cmdIncarcaFisiereBenzinarii.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdIncarcaFisiereBenzinarii.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdIncarcaFisiereBenzinarii.Name = "cmdIncarcaFisiereBenzinarii"
        Me.cmdIncarcaFisiereBenzinarii.Size = New System.Drawing.Size(98, 77)
        Me.cmdIncarcaFisiereBenzinarii.Text = "Fisiere benzinarii"
        Me.cmdIncarcaFisiereBenzinarii.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdIncarcaFisiereBenzinarii.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdIncarcaFisiereBenzinarii.ToolTipText = "Reface setarile predefinite pentru fiecare robot (pentru a evita setari activate " &
    "la depanare sau accidental)"
        '
        'cmdStergeDateBenzinarii
        '
        Me.cmdStergeDateBenzinarii.Image = CType(resources.GetObject("cmdStergeDateBenzinarii.Image"), System.Drawing.Image)
        Me.cmdStergeDateBenzinarii.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdStergeDateBenzinarii.Name = "cmdStergeDateBenzinarii"
        Me.cmdStergeDateBenzinarii.Size = New System.Drawing.Size(124, 77)
        Me.cmdStergeDateBenzinarii.Text = "Sterge date benzinarii"
        Me.cmdStergeDateBenzinarii.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdStergeDateBenzinarii.ToolTipText = "Activitate zilnica pe intervale. Atentie, selectati intervalul mai intai."
        '
        'cmdActivitateZilnicaPeIntervale
        '
        Me.cmdActivitateZilnicaPeIntervale.Image = CType(resources.GetObject("cmdActivitateZilnicaPeIntervale.Image"), System.Drawing.Image)
        Me.cmdActivitateZilnicaPeIntervale.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdActivitateZilnicaPeIntervale.Name = "cmdActivitateZilnicaPeIntervale"
        Me.cmdActivitateZilnicaPeIntervale.Size = New System.Drawing.Size(97, 77)
        Me.cmdActivitateZilnicaPeIntervale.Text = "Activitate zilnica"
        Me.cmdActivitateZilnicaPeIntervale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdActivitateZilnicaPeIntervale.ToolTipText = "Activitate zilnica pe intervale. Atentie, selectati intervalul mai intai."
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
        'cmdStergeTabelActivitateZilnica
        '
        Me.cmdStergeTabelActivitateZilnica.Image = CType(resources.GetObject("cmdStergeTabelActivitateZilnica.Image"), System.Drawing.Image)
        Me.cmdStergeTabelActivitateZilnica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdStergeTabelActivitateZilnica.Name = "cmdStergeTabelActivitateZilnica"
        Me.cmdStergeTabelActivitateZilnica.Size = New System.Drawing.Size(131, 77)
        Me.cmdStergeTabelActivitateZilnica.Text = "Sterge activitate zilnica"
        Me.cmdStergeTabelActivitateZilnica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdStergeTabelActivitateZilnica.ToolTipText = "Activitate zilnica pe intervale. Atentie, selectati intervalul mai intai."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperatiiToolStripMenuItem, Me.ITrackToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(870, 24)
        Me.MenuStrip1.TabIndex = 237
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperatiiToolStripMenuItem
        '
        Me.OperatiiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncarcaFisierBenzinariiToolStripMenuItem})
        Me.OperatiiToolStripMenuItem.Name = "OperatiiToolStripMenuItem"
        Me.OperatiiToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.OperatiiToolStripMenuItem.Text = "PECO"
        '
        'IncarcaFisierBenzinariiToolStripMenuItem
        '
        Me.IncarcaFisierBenzinariiToolStripMenuItem.Name = "IncarcaFisierBenzinariiToolStripMenuItem"
        Me.IncarcaFisierBenzinariiToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.IncarcaFisierBenzinariiToolStripMenuItem.Text = "Incarca fisier benzinarii"
        '
        'ITrackToolStripMenuItem
        '
        Me.ITrackToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActivitateZilnicaPeIntervaleToolStripMenuItem})
        Me.ITrackToolStripMenuItem.Name = "ITrackToolStripMenuItem"
        Me.ITrackToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ITrackToolStripMenuItem.Text = "ITrack"
        '
        'ActivitateZilnicaPeIntervaleToolStripMenuItem
        '
        Me.ActivitateZilnicaPeIntervaleToolStripMenuItem.Name = "ActivitateZilnicaPeIntervaleToolStripMenuItem"
        Me.ActivitateZilnicaPeIntervaleToolStripMenuItem.Size = New System.Drawing.Size(224, 22)
        Me.ActivitateZilnicaPeIntervaleToolStripMenuItem.Text = "Activitate zilnica pe intervale"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 13)
        Me.Label1.TabIndex = 238
        Me.Label1.Text = "Atentie. Pentru a accesa fisierul excel de la benzinarii se procedeaza asfel:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 142)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(844, 63)
        Me.TextBox1.TabIndex = 239
        Me.TextBox1.Text = "De doua ori pe luna se primeste un fisier excel de la Mol care se incarca in C:\C" &
    "onsolight_RPA\Robots\km-auto\input\MOL Romania.  Dupa ce se incarca se vor muta " &
    "in directorul  'Incarcate'. "
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 252)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(844, 63)
        Me.TextBox2.TabIndex = 241
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 13)
        Me.Label2.TabIndex = 240
        Me.Label2.Text = "Atentie. Pentru a accesa fisierul excel exportat din Itrack se procedeaza astfel:" &
    ""
        '
        'frmDateExterne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 595)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ssInfo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmDateExterne"
        Me.Text = "frmDateExterne"
        Me.ssInfo.ResumeLayout(False)
        Me.ssInfo.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ssInfo As StatusStrip
    Friend WithEvents lbInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdIncarcaFisiereBenzinarii As ToolStripButton
    Friend WithEvents cmdActivitateZilnicaPeIntervale As ToolStripButton
    Friend WithEvents cmdIesire As ToolStripButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OperatiiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncarcaFisierBenzinariiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ITrackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivitateZilnicaPeIntervaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents pbIncarca As ToolStripProgressBar
    Friend WithEvents cmdStergeTabelActivitateZilnica As ToolStripButton
    Friend WithEvents cmdStergeDateBenzinarii As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
End Class
