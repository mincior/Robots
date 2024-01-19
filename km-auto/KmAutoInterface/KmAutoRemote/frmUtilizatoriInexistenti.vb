Imports System.ComponentModel

Public Class frmUtilizatoriInexistenti
    Private Sub frmUtilizatoriInexistenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KmAutoDataSet.UtilizatoriInexistenti' table. You can move, or remove it, as needed.
        Me.UtilizatoriInexistentiTableAdapter.Fill(Me.KmAutoDataSet.UtilizatoriInexistenti)
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 388, 402)

    End Sub

    Private Sub frmUtilizatoriInexistenti_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)

    End Sub
End Class