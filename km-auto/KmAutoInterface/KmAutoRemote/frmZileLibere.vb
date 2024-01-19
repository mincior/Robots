Imports System.ComponentModel

Public Class frmZileLibere
    Private Sub frmZileLibere_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KmAutoDataSet.ZileLibere' table. You can move, or remove it, as needed.
        Me.ZileLibereTableAdapter.FillBySortDataDesc(Me.KmAutoDataSet.ZileLibere)
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 388, 402)

    End Sub

    Private Sub frmZileLibere_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        'Atentie. Cautarea coloanelor din grid dupa nume se poate face numai daca in Designer, in Edit columns din DataGridView, se sterg coloanele 'binduite' si se adauga manual
        'Altfel le gasim dupa index, care se poate schimba daca modificam ordinea coloanelor'
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Cells("Data").Value = Format(CDate(ReturValueFromTable("Data", "ZileLibere", "id", row.Cells(0).Value)), "yyyy-MM-dd")
        Next

    End Sub
    Private Sub DataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        Timer1.Enabled = True
        Static SortOrder As Boolean
        SortOrder = Not SortOrder
        If e.ColumnIndex = 1 Then 'click pe coloana Data
            If SortOrder Then
                Me.ZileLibereTableAdapter.FillBySortDataAsc(Me.KmAutoDataSet.ZileLibere)
            Else
                Me.ZileLibereTableAdapter.FillBySortDataDesc(Me.KmAutoDataSet.ZileLibere)

            End If

        Else 'click pe coloana Observatii
            If SortOrder Then
                Me.ZileLibereTableAdapter.FillBySortObservatiiAsc(Me.KmAutoDataSet.ZileLibere)
            Else
                Me.ZileLibereTableAdapter.FillBySortObservatiiDesc(Me.KmAutoDataSet.ZileLibere)

            End If

        End If
    End Sub

End Class