Imports System.ComponentModel

Public Class frmGetDataAsDate
    Private Sub frmGetDataAsDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IncarcaDimensiuniSiPozitie(Me, 300, 300, 340, 289)
        Me.DateTimePicker1.Value = Me.Tag
    End Sub

    Private Sub frmGetDataAsDate_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        Me.Tag = Me.DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker1_KeyUp(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyUp
        If e.KeyCode = 13 Then
            Me.Tag = Me.DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
            Me.Close()
        End If
    End Sub

    Private Sub cmdRenunta_Click(sender As Object, e As EventArgs) Handles cmdRenunta.Click
        Me.Close()

    End Sub
End Class