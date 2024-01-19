Imports System.ComponentModel
Imports Microsoft.Office.Interop.Outlook

Public Class frmFiliale
    Private lstDataGrid As IList(Of Object)
    Public fil As New Filiala
    Private Sub frmFiliale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 982, 879)
        lstDataGrid = New List(Of Object)
        lstDataGrid.Add(-1)
        UpdateGrid()
    End Sub
    Private Sub ModificaFiliala(row As DataGridViewRow, operatie As String)
        If operatie = "Modificare" Then
            With fil
                .Nume = row.Cells("Nume").Value
                .Email = row.Cells("Email").Value
                .Responsabil = row.Cells("Responsabil").Value
                .Operatie = operatie
            End With
        Else
            With fil
                .Nume = ""
                .Email = ""
                .Responsabil = ""
                .Operatie = operatie
            End With
        End If
        frmFilialeChange.ShowDialog()
        frmFilialeChange.Dispose()
        UpdateGrid()

    End Sub
    Private Sub UpdateGrid()
        Cursor = Cursors.WaitCursor
        DataGridView1.Rows.Clear()
        Dim combustibiliDataTable As System.Data.DataTable = ReturDataTableKmAuto("SELECT dbo.Filiale.Responsabil, dbo.Utilizatori.Telefon, dbo.Filiale.Email, dbo.Filiale.Nume FROM  dbo.Filiale left outer JOIN   dbo.Utilizatori ON dbo.Filiale.Responsabil = dbo.Utilizatori.Nume")
        Dim row As System.Data.DataRow
        For Each row In combustibiliDataTable.Rows
            Dim arr(3) As Object
            arr(0) = row("Nume")
            arr(1) = row("Email")
            arr(2) = row("Responsabil")
            arr(3) = row("Telefon")
            DataGridView1.Rows.Add(arr)
        Next
        Cursor = Cursors.Default
    End Sub

    Private Sub cmdIesire_Click(sender As Object, e As EventArgs) Handles cmdIesire.Click
        Me.Close()
    End Sub
    Private Sub frmFiliale_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)
    End Sub

    Private Sub cmdStergere_Click(sender As Object, e As EventArgs) Handles cmdStergere.Click
        Dim result As DialogResult = MessageBox.Show("Stergeti randul curent ?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            If Not DataGridView1.CurrentCell Is Nothing Then
                Dim crtRow As Integer = DataGridView1.CurrentCell.RowIndex
                Dim nume As String = DataGridView1.CurrentRow.Cells("Nume").Value
                lbInfo.Text = ""
                'sterge in baza de date
                Dim succes As String = ExecutaSQLkmAuto( "Delete from Filiale Where Nume = '" & nume & "'")
                'sterge si in grid
                If succes = "Ok" Then
                    UpdateGrid()
                    Try
                        DataGridView1.CurrentCell = DataGridView1(0, crtRow)
                    Catch ex As System.Exception

                    End Try
                    MessageBox.Show("Filiala stearsa cu succes", "KmAuto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

    End Sub

    Private Sub cmdModificare_Click(sender As Object, e As EventArgs) Handles cmdModificare.Click
        ModificaFiliala(DataGridView1.CurrentRow, "Modificare")
    End Sub
    Private Sub cmdAdaugare_Click(sender As Object, e As EventArgs) Handles cmdAdaugare.Click
        ModificaFiliala(DataGridView1.CurrentRow, "Adaugare")

    End Sub


End Class