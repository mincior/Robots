Imports System.ComponentModel
Imports Microsoft.Office.Interop.Outlook

Public Class frmCombustibili
    Private lstDataGrid As IList(Of Object)
    Public comb As New Combustibil
    Private Sub frmCombustibili_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 982, 879)
        lstDataGrid = New List(Of Object)
        lstDataGrid.Add(-1)
        UpdateGrid()
    End Sub
    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        If lstDataGrid(0) <> e.RowIndex Then
            lstDataGrid.Clear()
            Dim k As Integer
            lstDataGrid.Add(e.RowIndex) 'pune pe prima pozitie numarul randului memorat
            For k = 0 To DataGridView1.DisplayedColumnCount(True) - 1
                lstDataGrid.Add(DataGridView1.Rows(e.RowIndex).Cells(k).Value)

            Next
        End If
    End Sub

    Private Sub cmdModificare_Click(sender As Object, e As EventArgs) Handles cmdModificare.Click
        ModificaCombustibil(DataGridView1.CurrentRow, "Modificare")
    End Sub
    Private Sub ModificaCombustibil(row As DataGridViewRow, operatie As String)
        If operatie = "Modificare" Then
            With comb
                .Tip = row.Cells("Tip").Value
                .Data = row.Cells("Data").Value
                .Pret = row.Cells("Pret").Value
                .id = row.Cells("Id").Value
                .operatie = operatie
            End With
        Else
            With comb
                .Tip = ""
                .Data = gstrDataInceput
                .Pret = 0
                .id = 0
                .operatie = operatie
            End With
        End If
        frmCombustibiliChange.ShowDialog()
        frmCombustibiliChange.Dispose()
        UpdateGrid()

    End Sub
    Private Sub UpdateGrid()
        Cursor = Cursors.WaitCursor
        DataGridView1.Rows.Clear()
        Dim combustibiliDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select * from combustibili Order by Data, TipCombustibil")
        Dim row As System.Data.DataRow
        For Each row In combustibiliDataTable.Rows
            Dim arr(3) As Object
            arr(0) = row("TipCombustibil")
            arr(1) = CDate(row("Data")).ToString("yyyy-MM-dd")
            arr(2) = row("Pret")
            arr(3) = row("Id")
            DataGridView1.Rows.Add(arr)
        Next
        Cursor = Cursors.Default
    End Sub

    Private Sub cmdAdaugare_Click(sender As Object, e As EventArgs) Handles cmdAdaugare.Click
        ModificaCombustibil(DataGridView1.CurrentRow, "Adaugare")

    End Sub

    Private Sub cmdStergere_Click(sender As Object, e As EventArgs) Handles cmdStergere.Click
        Dim result As DialogResult = MessageBox.Show("Stergeti randul curent ?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            If Not DataGridView1.CurrentCell Is Nothing Then
                Dim crtRow As Integer = DataGridView1.CurrentCell.RowIndex
                Dim data As String = DataGridView1.CurrentRow.Cells("Data").Value
                Dim tip As String = DataGridView1.CurrentRow.Cells("Tip").Value
                lbInfo.Text = ""
                'sterge in baza de date
                Dim succes As String = ExecutaSQLKmAuto("Delete from Combustibili Where Data = '" & data & "' and TipCombustibil = '" & tip & "'")
                'sterge si in grid
                If succes = "Ok" Then
                    UpdateGrid()
                    Try
                        DataGridView1.CurrentCell = DataGridView1(0, crtRow)
                    Catch ex As System.Exception

                    End Try
                    MessageBox.Show("Combustibil sters cu succes", "KmAuto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub
    Private Sub cmdIesire_Click(sender As Object, e As EventArgs) Handles cmdIesire.Click
        Me.Close()
    End Sub
    Private Sub frmCombustibili_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)
    End Sub

End Class