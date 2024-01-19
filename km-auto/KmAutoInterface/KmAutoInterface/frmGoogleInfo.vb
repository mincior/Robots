Imports System.ComponentModel

Public Class frmGoogleInfo
    Private Sub frmGoogleInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 795, 834)

    End Sub

    Private Sub frmGoogleInfo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)

    End Sub

    Private Sub cmdMasiniDublate_Click(sender As Object, e As EventArgs) Handles cmdMasiniDublate.Click
        lvOutput.Items.Clear()
        Dim sql As String = "SELECT TOP (100) PERCENT dbo.MasiniInGoogle.Numar, dbo.Spreadsheets.Filiala, dbo.Spreadsheets.Nume as foaie " &
                             "FROM dbo.MasiniInGoogle INNER JOIN " &
                             "dbo.Spreadsheets ON dbo.MasiniInGoogle.SpreadsheetId = dbo.Spreadsheets.SpreadsheetId " &
                             "WHERE (dbo.Spreadsheets.Activ = 'Da') AND (dbo.Spreadsheets.Foaie = N'') AND (dbo.Spreadsheets.SheetId = N'') AND (dbo.Spreadsheets.Activ = 'Da') AND (dbo.MasiniInGoogle.Numar IN " &
                             "(SELECT Numar " &
                             "FROM dbo.MasiniInGoogle AS MasiniInGoogle_1 " &
                             "GROUP BY Numar " &
                             "HAVING (COUNT(*) > 1))) " &
                             "ORDER BY dbo.MasiniInGoogle.Numar, dbo.Spreadsheets.Filiala"
        sql = clearSql(sql)
        Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto(sql)
        For Each row As DataRow In myDataTable.Rows
            Dim lvu As ListViewItem = lvOutput.Items.Add(row("Numar"))
            lvu.SubItems.Add("--")
            lvu.SubItems.Add(row("foaie"))
            lvu.SubItems.Add(row("filiala"))


        Next
        Me.Text = cmdMasiniDublate.ToolTipText
    End Sub

    Private Sub cmdIesire_Click(sender As Object, e As EventArgs) Handles cmdIesire.Click
        Me.Close()

    End Sub

    Private Sub cmdUtilizatoriDublati_Click(sender As Object, e As EventArgs) Handles cmdUtilizatoriDublati.Click
        lvOutput.Items.Clear()
        Dim sql As String = "SELECT TOP (100) PERCENT dbo.UtilizatoriInGoogle.Nume, dbo.Spreadsheets.Filiala, dbo.Spreadsheets.Nume AS foaie " &
                     "FROM dbo.UtilizatoriInGoogle INNER JOIN " &
                     "dbo.Spreadsheets ON dbo.UtilizatoriInGoogle.SpreadsheetId = dbo.Spreadsheets.SpreadsheetId " &
                     "WHERE (dbo.Spreadsheets.Activ = 'Da') AND (dbo.Spreadsheets.Foaie = N'') AND (dbo.Spreadsheets.SheetId = N'') AND (dbo.Spreadsheets.Activ = 'Da') AND (dbo.UtilizatoriInGoogle.Nume IN " &
                     "(SELECT Nume " &
                     "FROM dbo.UtilizatoriInGoogle AS UtilizatoriInGoogle_1 " &
                     "GROUP BY Nume " &
                     "HAVING (COUNT(*) > 1))) " &
                     "ORDER BY dbo.UtilizatoriInGoogle.Nume, dbo.Spreadsheets.Filiala"
        sql = clearSql(sql)
        Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto(sql)
        For Each row As DataRow In myDataTable.Rows
            Dim lvu As ListViewItem = lvOutput.Items.Add("--")
            lvu.SubItems.Add(row("Nume"))
            lvu.SubItems.Add(row("foaie"))
            lvu.SubItems.Add(row("filiala"))

        Next
        Me.Text = cmdUtilizatoriDublati.ToolTipText
    End Sub

    Private Sub cmdMasiniInexistente_Click(sender As Object, e As EventArgs) Handles cmdMasiniInexistente.Click
        lvOutput.Items.Clear()
        Dim sql As String = "SELECT dbo.Masini.Numar, dbo.Spreadsheets.Nume as foaie, dbo.Filiale.Nume AS filiala " &
                     "FROM dbo.Masini INNER JOIN " &
                     "dbo.Filiale ON dbo.Masini.FilialaId = dbo.Filiale.id INNER JOIN " &
                     "dbo.Spreadsheets ON dbo.Filiale.Nume = dbo.Spreadsheets.Filiala " &
                     "WHERE (dbo.Spreadsheets.Activ = 'Da') AND (dbo.Spreadsheets.Foaie = N'') AND (dbo.Spreadsheets.SheetId = N'') AND (dbo.Masini.Numar NOT IN " &
                     "(SELECT Numar " &
                     "FROM dbo.MasiniInGoogle))"
        sql = clearSql(sql)
        Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto(sql)
        For Each row As DataRow In myDataTable.Rows
            Dim lvu As ListViewItem = lvOutput.Items.Add(row("Numar"))
            lvu.SubItems.Add("--")
            lvu.SubItems.Add(row("foaie"))
            lvu.SubItems.Add(row("filiala"))

        Next
        Me.Text = cmdMasiniInexistente.ToolTipText

    End Sub

    Private Sub cmdUtilizatoriInexistenti_Click(sender As Object, e As EventArgs) Handles cmdUtilizatoriInexistenti.Click
        lvOutput.Items.Clear()
        Dim sql As String = "SELECT dbo.Utilizatori.Nume, dbo.Spreadsheets.Nume as foaie, dbo.Filiale.Nume AS filiala " &
                     "FROM dbo.Utilizatori INNER JOIN " &
                     "dbo.Filiale ON dbo.Utilizatori.FilialaId = dbo.Filiale.id INNER JOIN " &
                     "dbo.Spreadsheets ON dbo.Filiale.Nume = dbo.Spreadsheets.Filiala " &
                     "WHERE (dbo.Spreadsheets.Activ = 'Da') AND (dbo.Spreadsheets.Foaie = N'') AND (dbo.Spreadsheets.SheetId = N'') AND (dbo.Utilizatori.Nume NOT IN " &
                     "(SELECT Nume " &
                     "FROM dbo.UtilizatoriInGoogle))"
        sql = clearSql(sql)
        Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto(sql)
        For Each row As DataRow In myDataTable.Rows
            Dim lvu As ListViewItem = lvOutput.Items.Add("--")
            lvu.SubItems.Add(row("Nume"))
            lvu.SubItems.Add(row("foaie"))
            lvu.SubItems.Add(row("filiala"))

        Next
        Me.Text = cmdUtilizatoriInexistenti.ToolTipText

    End Sub

    Private Sub cmdMasiniLipsa_Click(sender As Object, e As EventArgs) Handles cmdMasiniLipsa.Click
        lvOutput.Items.Clear()
        Dim sql As String = "SELECT dbo.MasiniInGoogle.Numar, dbo.Spreadsheets.Nume AS foaie, dbo.Spreadsheets.Filiala AS filiala " &
                     "FROM dbo.MasiniInGoogle INNER JOIN " &
                     "dbo.Spreadsheets ON dbo.MasiniInGoogle.SpreadsheetId = dbo.Spreadsheets.SpreadsheetId " &
                     "WHERE (dbo.Spreadsheets.Activ = 'Da') AND (dbo.Spreadsheets.Foaie = N'') AND (dbo.Spreadsheets.SheetId = N'') AND (dbo.MasiniInGoogle.Numar NOT IN " &
                     "(SELECT Numar " &
                     "FROM dbo.Masini AS MasiniI_1))"
        sql = clearSql(sql)
        Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto(sql)
        For Each row As DataRow In myDataTable.Rows
            Dim lvu As ListViewItem = lvOutput.Items.Add(row("Numar"))
            lvu.SubItems.Add("--")
            lvu.SubItems.Add(row("foaie"))
            lvu.SubItems.Add(row("filiala"))

        Next
        Me.Text = cmdMasiniLipsa.ToolTipText

    End Sub

    Private Sub cmdUtilizatoriLipsa_Click(sender As Object, e As EventArgs) Handles cmdUtilizatoriLipsa.Click
        lvOutput.Items.Clear()
        Dim sql As String = "SELECT dbo.UtilizatoriInGoogle.Nume, dbo.Spreadsheets.Nume AS foaie, dbo.Spreadsheets.Filiala AS filiala " &
                     "FROM dbo.UtilizatoriInGoogle INNER JOIN " &
                     "dbo.Spreadsheets ON dbo.UtilizatoriInGoogle.SpreadsheetId = dbo.Spreadsheets.SpreadsheetId " &
                     "WHERE (dbo.Spreadsheets.Activ = 'Da') AND (dbo.Spreadsheets.Foaie = N'') AND (dbo.Spreadsheets.SheetId = N'') AND (dbo.UtilizatoriInGoogle.Nume NOT IN " &
                     "(SELECT Nume " &
                     "FROM dbo.Utilizatori AS UtilizatoriI_1))"
        sql = clearSql(sql)
        Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto(sql)
        For Each row As DataRow In myDataTable.Rows
            Dim lvu As ListViewItem = lvOutput.Items.Add("--")
            lvu.SubItems.Add(row("Nume"))
            lvu.SubItems.Add(row("foaie"))
            lvu.SubItems.Add(row("filiala"))

        Next
        Me.Text = cmdUtilizatoriLipsa.ToolTipText

    End Sub

    Private Sub lvOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvOutput.SelectedIndexChanged

    End Sub
End Class