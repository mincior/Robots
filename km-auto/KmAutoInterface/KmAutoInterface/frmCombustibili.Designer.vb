<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCombustibili
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCombustibili))
        Me.ssInfo = New System.Windows.Forms.StatusStrip()
        Me.lbInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pbIncarca = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdModificare = New System.Windows.Forms.ToolStripButton()
        Me.cmdAdaugare = New System.Windows.Forms.ToolStripButton()
        Me.cmdStergere = New System.Windows.Forms.ToolStripButton()
        Me.cmdIesire = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Tip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pret = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ssInfo.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ssInfo
        '
        Me.ssInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbInfo, Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1, Me.pbIncarca})
        Me.ssInfo.Location = New System.Drawing.Point(0, 575)
        Me.ssInfo.Name = "ssInfo"
        Me.ssInfo.Size = New System.Drawing.Size(984, 22)
        Me.ssInfo.TabIndex = 229
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdModificare, Me.cmdAdaugare, Me.cmdStergere, Me.cmdIesire})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 2)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(966, 80)
        Me.ToolStrip1.TabIndex = 228
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdModificare
        '
        Me.cmdModificare.Image = CType(resources.GetObject("cmdModificare.Image"), System.Drawing.Image)
        Me.cmdModificare.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdModificare.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdModificare.Name = "cmdModificare"
        Me.cmdModificare.Size = New System.Drawing.Size(68, 77)
        Me.cmdModificare.Text = "Modificare"
        Me.cmdModificare.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdModificare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdModificare.ToolTipText = "Reface setarile predefinite pentru fiecare robot (pentru a evita setari activate " &
    "la depanare sau accidental)"
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tip, Me.Data, Me.Pret, Me.id})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(975, 480)
        Me.DataGridView1.TabIndex = 227
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Tip
        '
        Me.Tip.DataPropertyName = "Tip"
        Me.Tip.HeaderText = "Tip combustibil"
        Me.Tip.Name = "Tip"
        Me.Tip.ReadOnly = True
        '
        'Data
        '
        Me.Data.HeaderText = "Data modificarii pretului"
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        '
        'Pret
        '
        Me.Pret.HeaderText = "Pret"
        Me.Pret.Name = "Pret"
        Me.Pret.ReadOnly = True
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'frmCombustibili
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 597)
        Me.Controls.Add(Me.ssInfo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmCombustibili"
        Me.Text = "frmCombustibili"
        Me.ssInfo.ResumeLayout(False)
        Me.ssInfo.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ssInfo As StatusStrip
    Friend WithEvents lbInfo As ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents pbIncarca As ToolStripProgressBar
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdModificare As ToolStripButton
    Friend WithEvents cmdAdaugare As ToolStripButton
    Friend WithEvents cmdStergere As ToolStripButton
    Friend WithEvents cmdIesire As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Tip As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Pret As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
End Class
