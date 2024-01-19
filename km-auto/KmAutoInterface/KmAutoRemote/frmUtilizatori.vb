Imports System.ComponentModel

Public Class frmUtilizatori
    Private Sub frmUtilizatori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KmAutoDataSet.Utilizatori' table. You can move, or remove it, as needed.
        Me.UtilizatoriTableAdapter.Fill(Me.KmAutoDataSet.Utilizatori)
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 982, 879)

    End Sub

    Private Sub frmUtilizatori_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        'Atentie. Cautarea coloanelor din grid dupa nume se poate face numai daca in Designer, in Edit columns din DataGridView, se sterg coloanele 'binduite' si se adauga manual
        'Altfel le gasim dupa index, care se poate schimba daca modificam ordinea coloanelor'
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Cells("Filiala").Value = ReturValueFromTable("Nume", "Filiale", "Id", ReturValueFromTable("FilialaId", "Utilizatori", "Id", row.Cells(0).Value))
        Next

    End Sub
    Private Sub DataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        Timer1.Enabled = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class