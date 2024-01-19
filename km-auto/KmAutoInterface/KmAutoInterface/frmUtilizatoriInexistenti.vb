Imports System.ComponentModel

Public Class frmUtilizatoriInexistenti
    Private Sub frmUtilizatoriInexistenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UtilizatoriInexistentiTableAdapter.Fill(Me.KmAutoDataSet.UtilizatoriInexistenti)
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 388, 402)

    End Sub

    Private Sub frmUtilizatoriInexistenti_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)

    End Sub
End Class