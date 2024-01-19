Imports System.ComponentModel
Imports System.Threading
Imports Microsoft.Office.Interop.Excel

Public Class frmGoogleSheets
    Private Sub frmGoogleSheets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 795, 834)

    End Sub

    Private Sub frmGoogleSheets_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        SalveazaDimensiuniSiPozitie(Me)

    End Sub
    Private Sub IncarcaSheets()
        lvSheets.Items.Clear()

        Dim formsDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select Nume, Filiala, Activ, SpreadsheetId from Spreadsheets Where Foaie <> N'' and SheetId <> N'' and Activ = 'Da'")
        For Each row As DataRow In formsDataTable.Rows
            Dim lvu As ListViewItem = lvSheets.Items.Add(row("Nume"))
            lvu.SubItems.Add(row("Filiala"))
            lvu.SubItems.Add(row("Activ"))
            lvu.SubItems.Add(row("SpreadsheetId"))
        Next
        lvSheets.EndUpdate()
        lvSheets.Refresh()
        ' cmbItems.SelectedIndex = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        IncarcaSheets()
        ListBoxItems.SelectedIndex = 0
        lvSheets.Items(0).Selected = True
        txtCautareMasinaSauUtilizator.Select()

    End Sub

    Private Sub cmdIesire_Click(sender As Object, e As EventArgs) Handles cmdIesire.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lvOutput.Items.Clear()

    End Sub

    Private Sub lvForms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvSheets.SelectedIndexChanged
        IncarcaKmLog()
    End Sub


    Private Sub IncarcaKmLog()
        DataGridView1.Rows.Clear()
        Dim gsh As New GoogleSheetsHelper
        Me.Cursor = Cursors.WaitCursor
        For Each lv As ListViewItem In lvSheets.Items
            If lv.Selected = True Then
                Dim sheetName As String = ReturExecutaSqlKmAuto("Select Foaie from Spreadsheets Where Nume = '" & lv.Text & "' and activ = 'Da' and foaie = N'' and sheetid = N''")
                Dim myList As IList(Of IList(Of Object)) = gsh.GetRowsList(lv.SubItems(3).Text, sheetName)

                Dim i As Integer
                Dim k As Integer
                For k = 1 To myList.Count - 1
                    Dim inputData(10) As String
                    For i = 0 To myList(k).Count - 1
                        inputData(If(i > 7, i - 1, i)) = myList(k)(i)
                    Next
                    DataGridView1.Rows.Add(inputData)
                Next
                Exit For
            End If
        Next
        Me.Cursor = Cursors.Default
        pbIncarca.Value = 0

    End Sub
End Class