Imports System.ComponentModel

Public Class frmMasiniInexistente
    Private Sub frmMasiniInexistente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KmAutoDataSet.MasiniInexistente' table. You can move, or remove it, as needed.
        Me.MasiniInexistenteTableAdapter.Fill(Me.KmAutoDataSet.MasiniInexistente)
        IncarcaDimensiuniSiPozitie(Me, 498, 88, 483, 557)

    End Sub

    Private Sub frmMasiniInexistente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)

    End Sub
End Class