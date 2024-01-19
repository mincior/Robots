<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGoogleMuta
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
        Dim FilialaIdLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGoogleMuta))
        Me.cmbFiliala = New System.Windows.Forms.ComboBox()
        Me.cmdIesire = New System.Windows.Forms.Button()
        Me.cmdSalveaza = New System.Windows.Forms.Button()
        Me.lblIntro = New System.Windows.Forms.Label()
        FilialaIdLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FilialaIdLabel
        '
        FilialaIdLabel.AutoSize = True
        FilialaIdLabel.Location = New System.Drawing.Point(0, 151)
        FilialaIdLabel.Name = "FilialaIdLabel"
        FilialaIdLabel.Size = New System.Drawing.Size(87, 13)
        FilialaIdLabel.TabIndex = 250
        FilialaIdLabel.Text = "Filiala destinatie :"
        '
        'cmbFiliala
        '
        Me.cmbFiliala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiliala.FormattingEnabled = True
        Me.cmbFiliala.Location = New System.Drawing.Point(105, 148)
        Me.cmbFiliala.MaxDropDownItems = 20
        Me.cmbFiliala.Name = "cmbFiliala"
        Me.cmbFiliala.Size = New System.Drawing.Size(200, 21)
        Me.cmbFiliala.TabIndex = 248
        '
        'cmdIesire
        '
        Me.cmdIesire.BackgroundImage = CType(resources.GetObject("cmdIesire.BackgroundImage"), System.Drawing.Image)
        Me.cmdIesire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdIesire.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdIesire.Location = New System.Drawing.Point(213, 436)
        Me.cmdIesire.Name = "cmdIesire"
        Me.cmdIesire.Size = New System.Drawing.Size(92, 91)
        Me.cmdIesire.TabIndex = 251
        Me.cmdIesire.Text = "Iesire"
        Me.cmdIesire.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdIesire.UseVisualStyleBackColor = True
        '
        'cmdSalveaza
        '
        Me.cmdSalveaza.BackgroundImage = CType(resources.GetObject("cmdSalveaza.BackgroundImage"), System.Drawing.Image)
        Me.cmdSalveaza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdSalveaza.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSalveaza.Location = New System.Drawing.Point(105, 436)
        Me.cmdSalveaza.Name = "cmdSalveaza"
        Me.cmdSalveaza.Size = New System.Drawing.Size(92, 91)
        Me.cmdSalveaza.TabIndex = 249
        Me.cmdSalveaza.Text = "Salveaza"
        Me.cmdSalveaza.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalveaza.UseVisualStyleBackColor = True
        '
        'lblIntro
        '
        Me.lblIntro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro.Location = New System.Drawing.Point(12, 18)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(313, 91)
        Me.lblIntro.TabIndex = 252
        Me.lblIntro.Text = "Label1"
        '
        'frmGoogleMuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 539)
        Me.Controls.Add(Me.lblIntro)
        Me.Controls.Add(Me.cmbFiliala)
        Me.Controls.Add(Me.cmdIesire)
        Me.Controls.Add(Me.cmdSalveaza)
        Me.Controls.Add(FilialaIdLabel)
        Me.Name = "frmGoogleMuta"
        Me.Text = "frmGoogleMuta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbFiliala As ComboBox
    Friend WithEvents cmdIesire As Button
    Friend WithEvents cmdSalveaza As Button
    Friend WithEvents lblIntro As Label
End Class
