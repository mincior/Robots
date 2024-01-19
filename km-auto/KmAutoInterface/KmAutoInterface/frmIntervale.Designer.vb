<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIntervale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntervale))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdAdaugare = New System.Windows.Forms.ToolStripButton()
        Me.cmdStergere = New System.Windows.Forms.ToolStripButton()
        Me.cmdStergereTot = New System.Windows.Forms.ToolStripButton()
        Me.cmdAdaugareWeekend = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalvare = New System.Windows.Forms.ToolStripButton()
        Me.cmdIesire = New System.Windows.Forms.ToolStripButton()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ssInfo = New System.Windows.Forms.StatusStrip()
        Me.lbInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbIncarca = New System.Windows.Forms.ToolStripProgressBar()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIntervale = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNumarZilePanaLaWeekendulUrmator = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.ssInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdaugare, Me.cmdStergere, Me.cmdStergereTot, Me.cmdAdaugareWeekend, Me.cmdSalvare, Me.cmdIesire})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(833, 80)
        Me.ToolStrip1.TabIndex = 237
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdAdaugare
        '
        Me.cmdAdaugare.Image = CType(resources.GetObject("cmdAdaugare.Image"), System.Drawing.Image)
        Me.cmdAdaugare.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdaugare.Name = "cmdAdaugare"
        Me.cmdAdaugare.Size = New System.Drawing.Size(68, 77)
        Me.cmdAdaugare.Text = "Adaugare"
        Me.cmdAdaugare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdStergere
        '
        Me.cmdStergere.Image = CType(resources.GetObject("cmdStergere.Image"), System.Drawing.Image)
        Me.cmdStergere.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdStergere.Name = "cmdStergere"
        Me.cmdStergere.Size = New System.Drawing.Size(68, 77)
        Me.cmdStergere.Text = "Stergere"
        Me.cmdStergere.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdStergereTot
        '
        Me.cmdStergereTot.Image = CType(resources.GetObject("cmdStergereTot.Image"), System.Drawing.Image)
        Me.cmdStergereTot.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdStergereTot.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdStergereTot.Name = "cmdStergereTot"
        Me.cmdStergereTot.Size = New System.Drawing.Size(68, 77)
        Me.cmdStergereTot.Text = "Sterge tot"
        Me.cmdStergereTot.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdStergereTot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdStergereTot.ToolTipText = "Reface setarile predefinite pentru fiecare robot (pentru a evita setari activate " &
    "la depanare sau accidental)"
        '
        'cmdAdaugareWeekend
        '
        Me.cmdAdaugareWeekend.Image = CType(resources.GetObject("cmdAdaugareWeekend.Image"), System.Drawing.Image)
        Me.cmdAdaugareWeekend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdaugareWeekend.Name = "cmdAdaugareWeekend"
        Me.cmdAdaugareWeekend.Size = New System.Drawing.Size(112, 77)
        Me.cmdAdaugareWeekend.Text = "Adaugare weekend"
        Me.cmdAdaugareWeekend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdSalvare
        '
        Me.cmdSalvare.Image = CType(resources.GetObject("cmdSalvare.Image"), System.Drawing.Image)
        Me.cmdSalvare.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalvare.Name = "cmdSalvare"
        Me.cmdSalvare.Size = New System.Drawing.Size(68, 77)
        Me.cmdSalvare.Text = "Salvare"
        Me.cmdSalvare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ssInfo
        '
        Me.ssInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbInfo, Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1, Me.pbIncarca})
        Me.ssInfo.Location = New System.Drawing.Point(0, 306)
        Me.ssInfo.Name = "ssInfo"
        Me.ssInfo.Size = New System.Drawing.Size(851, 22)
        Me.ssInfo.TabIndex = 238
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
        'MonthCalendar1
        '
        Me.MonthCalendar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.Window
        Me.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.MonthCalendar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MonthCalendar1.Location = New System.Drawing.Point(9, 98)
        Me.MonthCalendar1.MaxDate = New Date(2100, 1, 5, 0, 0, 0, 0)
        Me.MonthCalendar1.MaxSelectionCount = 20
        Me.MonthCalendar1.MinDate = New Date(2000, 11, 25, 0, 0, 0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowTodayCircle = False
        Me.MonthCalendar1.TabIndex = 239
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(537, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 147)
        Me.Label1.TabIndex = 242
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'lblIntervale
        '
        Me.lblIntervale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIntervale.Location = New System.Drawing.Point(427, 98)
        Me.lblIntervale.Name = "lblIntervale"
        Me.lblIntervale.Size = New System.Drawing.Size(109, 135)
        Me.lblIntervale.TabIndex = 244
        Me.lblIntervale.Text = "Intervale: "
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(10, 20)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton4.TabIndex = 246
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(47, 20)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton3.TabIndex = 247
        Me.RadioButton3.Text = "3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(84, 20)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton2.TabIndex = 248
        Me.RadioButton2.Text = "2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(121, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton1.TabIndex = 249
        Me.RadioButton1.Text = "1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblNumarZilePanaLaWeekendulUrmator)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Location = New System.Drawing.Point(542, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 54)
        Me.GroupBox1.TabIndex = 250
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Numar de zile pana la weekendul urmator"
        '
        'lblNumarZilePanaLaWeekendulUrmator
        '
        Me.lblNumarZilePanaLaWeekendulUrmator.AutoSize = True
        Me.lblNumarZilePanaLaWeekendulUrmator.Location = New System.Drawing.Point(213, 20)
        Me.lblNumarZilePanaLaWeekendulUrmator.Name = "lblNumarZilePanaLaWeekendulUrmator"
        Me.lblNumarZilePanaLaWeekendulUrmator.Size = New System.Drawing.Size(39, 13)
        Me.lblNumarZilePanaLaWeekendulUrmator.TabIndex = 250
        Me.lblNumarZilePanaLaWeekendulUrmator.Text = "Label2"
        '
        'frmIntervale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 328)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblIntervale)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.ssInfo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmIntervale"
        Me.Text = "frmIntervale"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ssInfo.ResumeLayout(False)
        Me.ssInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdStergereTot As ToolStripButton
    Friend WithEvents cmdAdaugare As ToolStripButton
    Friend WithEvents cmdAdaugareWeekend As ToolStripButton
    Friend WithEvents cmdSalvare As ToolStripButton
    Friend WithEvents cmdStergere As ToolStripButton
    Friend WithEvents cmdIesire As ToolStripButton
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ssInfo As StatusStrip
    Friend WithEvents lbInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents pbIncarca As ToolStripProgressBar
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIntervale As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNumarZilePanaLaWeekendulUrmator As Label
End Class
