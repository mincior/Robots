<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetDataAsDate
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdRenunta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(198, 26)
        Me.DateTimePicker1.TabIndex = 0
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(220, 11)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(91, 26)
        Me.cmdOk.TabIndex = 1
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdRenunta
        '
        Me.cmdRenunta.Location = New System.Drawing.Point(317, 11)
        Me.cmdRenunta.Name = "cmdRenunta"
        Me.cmdRenunta.Size = New System.Drawing.Size(91, 26)
        Me.cmdRenunta.TabIndex = 2
        Me.cmdRenunta.Text = "Renunta"
        Me.cmdRenunta.UseVisualStyleBackColor = True
        '
        'frmGetDataAsDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 250)
        Me.Controls.Add(Me.cmdRenunta)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "frmGetDataAsDate"
        Me.Text = "frmGetDataAsDate"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdRenunta As Button
End Class
