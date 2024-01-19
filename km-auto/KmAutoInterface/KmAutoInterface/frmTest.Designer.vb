<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTest))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.cmdGoogleForms = New System.Windows.Forms.ToolStripButton()
        Me.cmdGoogleSheets = New System.Windows.Forms.ToolStripButton()
        Me.cmdIesire1 = New System.Windows.Forms.ToolStripButton()
        Me.cmdProceseazaLocal = New System.Windows.Forms.ToolStripButton()
        Me.cmdIncarcaToateFoileGoogle = New System.Windows.Forms.ToolStripButton()
        Me.cmdDeschideProcesator = New System.Windows.Forms.ToolStripButton()
        Me.cmdDeschideRaportCurent = New System.Windows.Forms.ToolStripButton()
        Me.cmdOperatiiBulk = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.Color.White
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdGoogleForms, Me.cmdGoogleSheets, Me.cmdIesire1, Me.cmdProceseazaLocal, Me.cmdIncarcaToateFoileGoogle, Me.cmdDeschideProcesator, Me.cmdDeschideRaportCurent, Me.cmdOperatiiBulk})
        Me.ToolStrip2.Location = New System.Drawing.Point(9, 9)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(845, 80)
        Me.ToolStrip2.TabIndex = 266
        '
        'cmdGoogleForms
        '
        Me.cmdGoogleForms.Image = CType(resources.GetObject("cmdGoogleForms.Image"), System.Drawing.Image)
        Me.cmdGoogleForms.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGoogleForms.Name = "cmdGoogleForms"
        Me.cmdGoogleForms.Size = New System.Drawing.Size(85, 77)
        Me.cmdGoogleForms.Text = "Google Forms"
        Me.cmdGoogleForms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdGoogleSheets
        '
        Me.cmdGoogleSheets.Image = CType(resources.GetObject("cmdGoogleSheets.Image"), System.Drawing.Image)
        Me.cmdGoogleSheets.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGoogleSheets.Name = "cmdGoogleSheets"
        Me.cmdGoogleSheets.Size = New System.Drawing.Size(86, 77)
        Me.cmdGoogleSheets.Text = "Google Sheets"
        Me.cmdGoogleSheets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdIesire1
        '
        Me.cmdIesire1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdIesire1.Image = CType(resources.GetObject("cmdIesire1.Image"), System.Drawing.Image)
        Me.cmdIesire1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdIesire1.Name = "cmdIesire1"
        Me.cmdIesire1.Size = New System.Drawing.Size(68, 77)
        Me.cmdIesire1.Text = "Iesire"
        Me.cmdIesire1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdProceseazaLocal
        '
        Me.cmdProceseazaLocal.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdProceseazaLocal.Image = CType(resources.GetObject("cmdProceseazaLocal.Image"), System.Drawing.Image)
        Me.cmdProceseazaLocal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdProceseazaLocal.Name = "cmdProceseazaLocal"
        Me.cmdProceseazaLocal.Size = New System.Drawing.Size(97, 77)
        Me.cmdProceseazaLocal.Text = "Proceseaza local"
        Me.cmdProceseazaLocal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdProceseazaLocal.ToolTipText = "Ruleaza Procesator.xlsm daca acesta exista pe acest calculator. Spre deosebire de" &
    " Ruleaza VBA sau Ruleaza Robotul unde se executa pe server atat procesator.xlsm " &
    "cat si robotul UIPath."
        '
        'cmdIncarcaToateFoileGoogle
        '
        Me.cmdIncarcaToateFoileGoogle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdIncarcaToateFoileGoogle.Image = CType(resources.GetObject("cmdIncarcaToateFoileGoogle.Image"), System.Drawing.Image)
        Me.cmdIncarcaToateFoileGoogle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdIncarcaToateFoileGoogle.Name = "cmdIncarcaToateFoileGoogle"
        Me.cmdIncarcaToateFoileGoogle.Size = New System.Drawing.Size(89, 77)
        Me.cmdIncarcaToateFoileGoogle.Text = "Incarca km log"
        Me.cmdIncarcaToateFoileGoogle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdDeschideProcesator
        '
        Me.cmdDeschideProcesator.Image = CType(resources.GetObject("cmdDeschideProcesator.Image"), System.Drawing.Image)
        Me.cmdDeschideProcesator.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDeschideProcesator.Name = "cmdDeschideProcesator"
        Me.cmdDeschideProcesator.Size = New System.Drawing.Size(95, 77)
        Me.cmdDeschideProcesator.Text = "Procesator.xlsm"
        Me.cmdDeschideProcesator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDeschideProcesator.ToolTipText = "Pune filtrul in foaia curenta"
        '
        'cmdDeschideRaportCurent
        '
        Me.cmdDeschideRaportCurent.Image = CType(resources.GetObject("cmdDeschideRaportCurent.Image"), System.Drawing.Image)
        Me.cmdDeschideRaportCurent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDeschideRaportCurent.Name = "cmdDeschideRaportCurent"
        Me.cmdDeschideRaportCurent.Size = New System.Drawing.Size(68, 77)
        Me.cmdDeschideRaportCurent.Text = "Raport"
        Me.cmdDeschideRaportCurent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDeschideRaportCurent.ToolTipText = "Pune filtrul in foaia curenta"
        '
        'cmdOperatiiBulk
        '
        Me.cmdOperatiiBulk.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdOperatiiBulk.Image = CType(resources.GetObject("cmdOperatiiBulk.Image"), System.Drawing.Image)
        Me.cmdOperatiiBulk.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdOperatiiBulk.Name = "cmdOperatiiBulk"
        Me.cmdOperatiiBulk.Size = New System.Drawing.Size(79, 77)
        Me.cmdOperatiiBulk.Text = "Operatii bulk"
        Me.cmdOperatiiBulk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdOperatiiBulk.ToolTipText = "Adauga in KmLog inregistrari nule sau complementare pentru masinile/utilizatorii " &
    "selectati in intervalele selectate"
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 450)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Name = "frmTest"
        Me.Text = "frmTest"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents cmdGoogleForms As ToolStripButton
    Friend WithEvents cmdGoogleSheets As ToolStripButton
    Friend WithEvents cmdIesire1 As ToolStripButton
    Friend WithEvents cmdProceseazaLocal As ToolStripButton
    Friend WithEvents cmdIncarcaToateFoileGoogle As ToolStripButton
    Friend WithEvents cmdDeschideProcesator As ToolStripButton
    Friend WithEvents cmdDeschideRaportCurent As ToolStripButton
    Friend WithEvents cmdOperatiiBulk As ToolStripButton
End Class
