<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGoogleInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGoogleInfo))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdMasiniDublate = New System.Windows.Forms.ToolStripButton()
        Me.cmdIesire = New System.Windows.Forms.ToolStripButton()
        Me.cmdUtilizatoriDublati = New System.Windows.Forms.ToolStripButton()
        Me.cmdMasiniInexistente = New System.Windows.Forms.ToolStripButton()
        Me.cmdUtilizatoriInexistenti = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdMasiniLipsa = New System.Windows.Forms.ToolStripButton()
        Me.cmdUtilizatoriLipsa = New System.Windows.Forms.ToolStripButton()
        Me.lvOutput = New System.Windows.Forms.ListView()
        Me.Numar = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nume = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Foaie = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Filiala = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1.SuspendLayout()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdMasiniDublate, Me.cmdIesire, Me.cmdUtilizatoriDublati, Me.cmdMasiniInexistente, Me.cmdUtilizatoriInexistenti, Me.ToolStripSeparator1, Me.cmdMasiniLipsa, Me.cmdUtilizatoriLipsa})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(922, 80)
        Me.ToolStrip1.TabIndex = 233
        '
        'cmdMasiniDublate
        '
        Me.cmdMasiniDublate.Image = CType(resources.GetObject("cmdMasiniDublate.Image"), System.Drawing.Image)
        Me.cmdMasiniDublate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdMasiniDublate.Name = "cmdMasiniDublate"
        Me.cmdMasiniDublate.Size = New System.Drawing.Size(89, 77)
        Me.cmdMasiniDublate.Text = "Masini dublate"
        Me.cmdMasiniDublate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdMasiniDublate.ToolTipText = "Masini care exista in mai multe foi Google"
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
        'cmdUtilizatoriDublati
        '
        Me.cmdUtilizatoriDublati.Image = CType(resources.GetObject("cmdUtilizatoriDublati.Image"), System.Drawing.Image)
        Me.cmdUtilizatoriDublati.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdUtilizatoriDublati.Name = "cmdUtilizatoriDublati"
        Me.cmdUtilizatoriDublati.Size = New System.Drawing.Size(101, 77)
        Me.cmdUtilizatoriDublati.Text = "Utilizatori dublati"
        Me.cmdUtilizatoriDublati.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdUtilizatoriDublati.ToolTipText = "Utilizatori care exista in mai multe foi Google"
        '
        'cmdMasiniInexistente
        '
        Me.cmdMasiniInexistente.Image = CType(resources.GetObject("cmdMasiniInexistente.Image"), System.Drawing.Image)
        Me.cmdMasiniInexistente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdMasiniInexistente.Name = "cmdMasiniInexistente"
        Me.cmdMasiniInexistente.Size = New System.Drawing.Size(106, 77)
        Me.cmdMasiniInexistente.Text = "Masini inexistente"
        Me.cmdMasiniInexistente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdMasiniInexistente.ToolTipText = "Masini care sunt inregistrate in tabelul Masini din baza de date, dar nu sunt int" &
    "roduse in nici una din foile Google"
        '
        'cmdUtilizatoriInexistenti
        '
        Me.cmdUtilizatoriInexistenti.Image = CType(resources.GetObject("cmdUtilizatoriInexistenti.Image"), System.Drawing.Image)
        Me.cmdUtilizatoriInexistenti.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdUtilizatoriInexistenti.Name = "cmdUtilizatoriInexistenti"
        Me.cmdUtilizatoriInexistenti.Size = New System.Drawing.Size(118, 77)
        Me.cmdUtilizatoriInexistenti.Text = "Utilizatori inexistenti"
        Me.cmdUtilizatoriInexistenti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdUtilizatoriInexistenti.ToolTipText = "Utilizatori care sunt inregistrati in tabelul Utilizatori din baza de date, dar n" &
    "u sunt introdusi in nici una din foile Google"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 80)
        '
        'cmdMasiniLipsa
        '
        Me.cmdMasiniLipsa.Image = CType(resources.GetObject("cmdMasiniLipsa.Image"), System.Drawing.Image)
        Me.cmdMasiniLipsa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdMasiniLipsa.Name = "cmdMasiniLipsa"
        Me.cmdMasiniLipsa.Size = New System.Drawing.Size(73, 77)
        Me.cmdMasiniLipsa.Text = "Masini lipsa"
        Me.cmdMasiniLipsa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdMasiniLipsa.ToolTipText = "Masini care au fost introduse fie manual fie au ramas introduse in foile Google d" &
    "ar nu sunt inregistrrate in tabelul Masini din baza de date."
        '
        'cmdUtilizatoriLipsa
        '
        Me.cmdUtilizatoriLipsa.Image = CType(resources.GetObject("cmdUtilizatoriLipsa.Image"), System.Drawing.Image)
        Me.cmdUtilizatoriLipsa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdUtilizatoriLipsa.Name = "cmdUtilizatoriLipsa"
        Me.cmdUtilizatoriLipsa.Size = New System.Drawing.Size(88, 77)
        Me.cmdUtilizatoriLipsa.Text = "Utilizatori lipsa"
        Me.cmdUtilizatoriLipsa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdUtilizatoriLipsa.ToolTipText = "Utilizatori care au fost introdusi fie manual fie au ramas introdusi in foile Goo" &
    "gle dar nu sunt inregistrrati in tabelul Utilizatori din baza de date."
        '
        'lvOutput
        '
        Me.lvOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvOutput.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Numar, Me.Nume, Me.Foaie, Me.Filiala})
        Me.lvOutput.HideSelection = False
        Me.lvOutput.Location = New System.Drawing.Point(12, 92)
        Me.lvOutput.MultiSelect = False
        Me.lvOutput.Name = "lvOutput"
        Me.lvOutput.Size = New System.Drawing.Size(919, 628)
        Me.lvOutput.TabIndex = 234
        Me.lvOutput.UseCompatibleStateImageBehavior = False
        Me.lvOutput.View = System.Windows.Forms.View.Details
        '
        'Numar
        '
        Me.Numar.Text = "Numar"
        Me.Numar.Width = 100
        '
        'Nume
        '
        Me.Nume.Text = "Nume"
        Me.Nume.Width = 200
        '
        'Foaie
        '
        Me.Foaie.Text = "Foaie"
        Me.Foaie.Width = 300
        '
        'Filiala
        '
        Me.Filiala.Text = "Filiala"
        Me.Filiala.Width = 200
        '
        'frmGoogleInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 755)
        Me.Controls.Add(Me.lvOutput)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmGoogleInfo"
        Me.Text = "frmGoogleInfo"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents cmdMasiniDublate As ToolStripButton
    Friend WithEvents cmdIesire As ToolStripButton
    Friend WithEvents cmdUtilizatoriDublati As ToolStripButton
    Friend WithEvents cmdMasiniInexistente As ToolStripButton
    Friend WithEvents cmdUtilizatoriInexistenti As ToolStripButton
    Friend WithEvents cmdMasiniLipsa As ToolStripButton
    Friend WithEvents cmdUtilizatoriLipsa As ToolStripButton
    Friend WithEvents lvOutput As ListView
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Numar As ColumnHeader
    Friend WithEvents Nume As ColumnHeader
    Friend WithEvents Foaie As ColumnHeader
    Friend WithEvents Filiala As ColumnHeader
End Class
