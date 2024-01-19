<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFilialeChange
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
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim ConsumMediuLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFilialeChange))
        Me.cmdIesire = New System.Windows.Forms.Button()
        Me.cmdSalveaza = New System.Windows.Forms.Button()
        Me.ResponsabilTextBox = New System.Windows.Forms.TextBox()
        Me.NumeTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        MarcaLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        ConsumMediuLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Location = New System.Drawing.Point(14, 24)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(35, 13)
        MarcaLabel.TabIndex = 268
        MarcaLabel.Text = "Nume"
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(14, 50)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(32, 13)
        ModelLabel.TabIndex = 269
        ModelLabel.Text = "Email"
        '
        'ConsumMediuLabel
        '
        ConsumMediuLabel.AutoSize = True
        ConsumMediuLabel.Location = New System.Drawing.Point(14, 76)
        ConsumMediuLabel.Name = "ConsumMediuLabel"
        ConsumMediuLabel.Size = New System.Drawing.Size(65, 13)
        ConsumMediuLabel.TabIndex = 270
        ConsumMediuLabel.Text = "Responsabil"
        '
        'cmdIesire
        '
        Me.cmdIesire.BackgroundImage = CType(resources.GetObject("cmdIesire.BackgroundImage"), System.Drawing.Image)
        Me.cmdIesire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdIesire.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdIesire.Location = New System.Drawing.Point(124, 109)
        Me.cmdIesire.Name = "cmdIesire"
        Me.cmdIesire.Size = New System.Drawing.Size(92, 91)
        Me.cmdIesire.TabIndex = 4
        Me.cmdIesire.Text = "Iesire"
        Me.cmdIesire.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdIesire.UseVisualStyleBackColor = True
        '
        'cmdSalveaza
        '
        Me.cmdSalveaza.BackgroundImage = CType(resources.GetObject("cmdSalveaza.BackgroundImage"), System.Drawing.Image)
        Me.cmdSalveaza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdSalveaza.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSalveaza.Location = New System.Drawing.Point(16, 109)
        Me.cmdSalveaza.Name = "cmdSalveaza"
        Me.cmdSalveaza.Size = New System.Drawing.Size(92, 91)
        Me.cmdSalveaza.TabIndex = 3
        Me.cmdSalveaza.Text = "Salveaza"
        Me.cmdSalveaza.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSalveaza.UseVisualStyleBackColor = True
        '
        'ResponsabilTextBox
        '
        Me.ResponsabilTextBox.Location = New System.Drawing.Point(85, 73)
        Me.ResponsabilTextBox.Name = "ResponsabilTextBox"
        Me.ResponsabilTextBox.Size = New System.Drawing.Size(131, 20)
        Me.ResponsabilTextBox.TabIndex = 2
        '
        'NumeTextBox
        '
        Me.NumeTextBox.Location = New System.Drawing.Point(85, 21)
        Me.NumeTextBox.Name = "NumeTextBox"
        Me.NumeTextBox.Size = New System.Drawing.Size(131, 20)
        Me.NumeTextBox.TabIndex = 0
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(85, 47)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(483, 20)
        Me.EmailTextBox.TabIndex = 1
        '
        'frmFilialeChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 214)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.NumeTextBox)
        Me.Controls.Add(Me.cmdIesire)
        Me.Controls.Add(Me.cmdSalveaza)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(ConsumMediuLabel)
        Me.Controls.Add(Me.ResponsabilTextBox)
        Me.Name = "frmFilialeChange"
        Me.Text = "frmFilialeChange"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdIesire As Button
    Friend WithEvents cmdSalveaza As Button
    Friend WithEvents ResponsabilTextBox As TextBox
    Friend WithEvents NumeTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
End Class
