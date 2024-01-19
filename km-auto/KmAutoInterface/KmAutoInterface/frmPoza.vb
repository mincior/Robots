Imports System.ComponentModel
Imports System.Reflection.Emit

Public Class frmPoza
    Private Sub frmPoza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 795, 834)
    End Sub

    Private Sub frmPoza_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)
        Me.Dispose()
    End Sub


End Class