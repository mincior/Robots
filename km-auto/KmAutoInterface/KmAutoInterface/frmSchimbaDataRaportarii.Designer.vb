<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchimbaDataRaportarii
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
        Me.dtpSchimbaDataRaportarii = New System.Windows.Forms.DateTimePicker()
        Me.cmdSalveaza = New System.Windows.Forms.Button()
        Me.cmdRenunta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpSchimbaDataRaportarii
        '
        Me.dtpSchimbaDataRaportarii.CustomFormat = "yyyy-MM-dd"
        Me.dtpSchimbaDataRaportarii.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSchimbaDataRaportarii.Location = New System.Drawing.Point(12, 11)
        Me.dtpSchimbaDataRaportarii.Name = "dtpSchimbaDataRaportarii"
        Me.dtpSchimbaDataRaportarii.Size = New System.Drawing.Size(219, 20)
        Me.dtpSchimbaDataRaportarii.TabIndex = 46
        Me.dtpSchimbaDataRaportarii.Value = New Date(1970, 1, 1, 0, 0, 0, 0)
        '
        'cmdSalveaza
        '
        Me.cmdSalveaza.Location = New System.Drawing.Point(247, 11)
        Me.cmdSalveaza.Name = "cmdSalveaza"
        Me.cmdSalveaza.Size = New System.Drawing.Size(75, 23)
        Me.cmdSalveaza.TabIndex = 47
        Me.cmdSalveaza.Text = "Salveaza"
        Me.cmdSalveaza.UseVisualStyleBackColor = True
        '
        'cmdRenunta
        '
        Me.cmdRenunta.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdRenunta.Location = New System.Drawing.Point(328, 11)
        Me.cmdRenunta.Name = "cmdRenunta"
        Me.cmdRenunta.Size = New System.Drawing.Size(75, 23)
        Me.cmdRenunta.TabIndex = 48
        Me.cmdRenunta.Text = "Renunta"
        Me.cmdRenunta.UseVisualStyleBackColor = True
        '
        'frmSchimbaDataRaportarii
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdRenunta
        Me.ClientSize = New System.Drawing.Size(413, 41)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdRenunta)
        Me.Controls.Add(Me.cmdSalveaza)
        Me.Controls.Add(Me.dtpSchimbaDataRaportarii)
        Me.Name = "frmSchimbaDataRaportarii"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Schimba data raportarii"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpSchimbaDataRaportarii As DateTimePicker
    Friend WithEvents cmdSalveaza As Button
    Friend WithEvents cmdRenunta As Button
End Class
