Option Explicit On
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Windows.Automation
Imports System.Xml
Imports Google.Apis.Sheets.v4.Data
Imports Microsoft.Office.Interop.Excel
'Imports Microsoft.Office.Int
Imports RestSharp
Imports System.Threading
Imports Google.Apis.Forms.v1.Data
Imports Google.Apis.Forms.v1
Imports Microsoft.Office.Interop.Outlook
Imports Google.Apis
Imports Microsoft.Office.Interop

Public Class frmKmLogView
    Private myStrData As String = ""
    Private myStatusModificat As String = ""
    Private myKmModificat As String = ""
    Private intervaleDataTable As System.Data.DataTable = ReturDataTableKmAuto("select * from intervale Where DataRaportarii = '" & gstrDataRaportarii & "' order by dataInceput")

    Private Sub frmKmLogView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KmAutoDataSet.Spreadsheets' table. You can move, or remove it, as needed.
        Me.SpreadsheetsTableAdapter.Fill(Me.KmAutoDataSet.Spreadsheets)
        'TODO: This line of code loads data into the 'KmAutoDataSet.Utilizatori' table. You can move, or remove it, as needed.
        Me.UtilizatoriTableAdapter.Fill(Me.KmAutoDataSet.Utilizatori)
        'TODO: This line of code loads data into the 'KmAutoDataSet.Masini' table. You can move, or remove it, as needed.
        Me.MasiniTableAdapter.Fill(Me.KmAutoDataSet.Masini)
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 982, 879)
        For Each row As System.Data.DataRow In intervaleDataTable.Rows
            cmbIntervale.Items.Add(row("Interval"))
        Next
        cmbIntervale.Items.Add("Toate")
        cmbIntervale.SelectedIndex = cmbIntervale.Items.Count - 1

    End Sub

    Private Sub frmKmLogView_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        SalveazaDimensiuniSiPozitie(Me)
        Try
            Microsoft.Win32.Registry.CurrentUser.DeleteSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInKmLog\")

        Catch

        End Try
        If cmbCautare.Text <> "" Then
            SaveSetting(AppName, "Settings", "CautareInKmLogCombo", cmbCautare.Text)
        End If
        Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInKmLog\")
        For Each item As String In cmbCautare.Items
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInKmLog\", item, item)
        Next

    End Sub

    Private Sub upGridKmLog()
        If Not DataGridView2.CurrentRow Is Nothing Then
            Dim Numar As String, Utilizator As String, Interval As String
            Numar = DataGridView2.CurrentRow.Cells("Numar").Value
            Utilizator = DataGridView2.CurrentRow.Cells("NumeUtilizator").Value
            Interval = cmbIntervale.Text
            cmbMasini.Text = Numar
            cmbUtilizatori.Text = Utilizator
            updateGrid(Numar, Utilizator, Interval)
            'Dim masinaId As Long = ReturExecutaSqlkmAuto("Select Id from Masini where Numar = '" & Numar & "'")
            Me.ITrackActivitateZilnicaPeIntervalTableAdapter.FillByNumar(Me.KmAutoDataSet.ITrackActivitateZilnicaPeInterval, Numar)
            DataGridView3.Refresh()
            IncarcaKmLog(False)
            grid1Click()
        End If
    End Sub
    Private Sub updateGrid(Numar As String, Utilizator As String, interval As String)
        Me.Cursor = Cursors.WaitCursor
        Dim dataSfarsit As String
        Dim dataInceput As String = gstrDataInceput
        Dim memIntervalCurent As String = ""
        Dim selectieData As String
        If cmbIntervale.Text = "Toate" Then
            selectieData = " AND dbo.KmLog.Data >= '" & dataInceput & "'"
        Else
            dataInceput = convertDataAsStringOfFomat(ReturExecutaSqlKmAuto("Select DataInceput from Intervale where Interval ='" & cmbIntervale.Text & "' and DataRaportarii = '" & gstrDataRaportarii & "'"), "yyyy-MM-dd")
            dataSfarsit = convertDataAsStringOfFomat(ReturExecutaSqlKmAuto("Select DataFinala from Intervale where Interval ='" & cmbIntervale.Text & "' and DataRaportarii = '" & gstrDataRaportarii & "'"), "yyyy-MM-dd")
            selectieData = " AND (KmLog.Data >= '" & dataInceput & " 00:00:00') AND (KmLog.Data <= '" & dataSfarsit & " 23:59:59') "

        End If
        DataGridView1.Rows.Clear()
        Dim sql As String = "SELECT dbo.KmLog.Data, dbo.Filiale.Nume AS Filiala, dbo.Utilizatori.Nume AS Utilizator, dbo.Masini.Numar, dbo.KmLog.Km,dbo.KmLog.KmModificat, dbo.KmLog.PozaDinBord, dbo.KmLog.Status,dbo.KmLog.StatusModificat, dbo.Spreadsheets.Nume AS Spreadsheet, " &
                         "dbo.KmLog.DataSiOraCitirii, dbo.KmLog.Observatii, dbo.KmLog.Observatii1, dbo.KmLog.Observatii2, dbo.KmLog.Asumat From " &
                         "dbo.Utilizatori INNER JOIN " &
                         "dbo.KmLog ON dbo.Utilizatori.Id = dbo.KmLog.UtilizatorId INNER JOIN " &
                         "dbo.Masini ON dbo.KmLog.MasinaId = dbo.Masini.Id INNER JOIN " &
                         "dbo.Filiale ON dbo.Masini.FilialaId = dbo.Filiale.id INNER JOIN " &
                         "dbo.Spreadsheets ON dbo.KmLog.Spreadsheets_id = dbo.Spreadsheets.Id  Where dbo.Masini.Numar = '" & Numar & "' AND dbo.Utilizatori.Nume = '" & Utilizator & "'" & selectieData & " Order By Data"
        sql = clearSql(sql)
        Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto(sql)
        If Not myDataTable Is Nothing Then
            'scrie gridul asa cum e (cu id-uri pentru utilizatori si greseli)
            For Each row As DataRow In myDataTable.Rows
                Dim inputData(11) As Object, inputDataIntervale(11) As Object
                inputData(0) = CType(row("Data"), Date).ToString("yyyy-MM-dd HH:mm:ss")
                inputData(1) = row("Km")
                inputData(2) = row("KmModificat")
                inputData(3) = row("PozaDinBord")
                inputData(4) = row("Status")
                inputData(5) = row("StatusModificat")
                inputData(6) = row("Spreadsheet")
                inputData(7) = row("DataSiOraCitirii")
                inputData(8) = ""
                inputData(9) = ""
                inputData(10) = ""
                inputData(11) = ""
                Try
                    inputData(8) = row("Observatii")

                Catch ex As System.Exception

                End Try
                Try
                    inputData(9) = row("Asumat")

                Catch ex As System.Exception

                End Try
                Try
                    inputData(10) = row("Observatii1")

                Catch ex As System.Exception

                End Try
                Try
                    inputData(11) = row("Observatii2")

                Catch ex As System.Exception

                End Try
                If cmbIntervale.Text = "Toate" Then 'va adauga un rand gol dupa fiecare final de interval
                    'Dim strDataDePrelucrat = CType(, Date).ToString("yyyy-MM-dd HH:mm:ss")
                    'Dim dataDePrelucrat As Date = convertStringDataToDate(strDataDePrelucrat)
                    Dim intervalCurent As String = returIntervalCurent(row("Data"), intervaleDataTable)
                    If intervalCurent <> "Eroare" And intervalCurent <> memIntervalCurent Then
                        inputDataIntervale(0) = ""
                        inputDataIntervale(1) = ""
                        inputDataIntervale(2) = ""
                        inputDataIntervale(3) = ""
                        inputDataIntervale(5) = ""
                        inputDataIntervale(6) = ""
                        inputDataIntervale(7) = ""
                        inputDataIntervale(8) = ""
                        inputDataIntervale(9) = ""
                        inputDataIntervale(10) = ""
                        inputDataIntervale(11) = ""
                        If DataGridView1.Rows.Count > 0 Then
                            DataGridView1.Rows.Add(inputDataIntervale)
                        End If
                        memIntervalCurent = intervalCurent
                    End If
                End If

                DataGridView1.Rows.Add(inputData)
            Next
        End If
        Me.Cursor = Cursors.Default
        Dim filialaId As Long = ReturExecutaSqlKmAuto("Select FilialaId from Masini Where Numar = '" & Numar & "'")
        Dim Filiala As String = ReturExecutaSqlKmAuto("Select Nume from Filiale Where id = " & filialaId)
        puneDataPentruAdaugare()
        Try

            cmbSpreadsheets.Text = ReturExecutaSqlKmAuto("Select Nume from Spreadsheets Where Filiala = '" & Filiala & "' AND Activ = 'Da' AND SheetId <> N'' AND Foaie <> N''")

        Catch ex As System.Exception

        End Try
        Timer4.Enabled = True
        'DataGridView1.CurrentCell = DataGridView1(0, DataGridView1.Rows.Count - 1)
        'DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
        'DataGridView1.CurrentCell = DataGridView1(0, 0)

        'cmbIntervale.Text = "Toate"
    End Sub
    Private Sub updateGridLeftSideRaport(Optional search As String = "")
        Me.Cursor = Cursors.WaitCursor
        DataGridView2.Rows.Clear()
        Dim d As Date = DateAdd("m", -2, convertStringDataToDate(frmPrincipal.lblDataRaportarii.Text))
        Dim v() As String = Split(search, ";")
        Dim searchWord As String = ""
        searchWord &= If(search.Length > 0, " Where ((dbo.Masini.Numar LIKE '%" & Trim(search) & "%' ) OR (Utilizatori.Nume LIKE '%" & Trim(search) & "%' ) OR(dbo.Filiale.Nume LIKE '%" & Trim(search) & "%'))", "")
        Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto("SELECT  dbo.Masini.Numar, dbo.Masini.Marca, dbo.Masini.Model, dbo.Filiale.Nume AS Filiala, Utilizatori.Nume, Utilizatori.Retinere, Utilizatori.LimitaKm, dbo.Masini.Carburant, dbo.Masini.ConsumMediu " &
                    "FROM            dbo.Masini INNER JOIN " &
                    "(SELECT DISTINCT TOP (100) PERCENT Masini_2.Id, dbo.Utilizatori.Nume " &
                    "FROM            dbo.KmLog INNER JOIN " &
                    "dbo.Utilizatori ON dbo.KmLog.UtilizatorId = dbo.Utilizatori.Id INNER JOIN " &
                    "dbo.Masini AS Masini_2 ON dbo.KmLog.MasinaId = Masini_2.Id " &
                    "WHERE        (dbo.KmLog.MasinaId IN " &
                    "(SELECT        MasinaId " &
                    "FROM            (SELECT        KmLog_1.MasinaId, COUNT(DISTINCT KmLog_1.UtilizatorId) AS NumarUtilizatori, Masini_1.Numar " &
                    "FROM            dbo.KmLog AS KmLog_1 INNER JOIN " &
                    "dbo.Masini AS Masini_1 ON KmLog_1.MasinaId = Masini_1.Id " &
                    "WHERE        (KmLog_1.Data >= '" & gstrDataInceput & " 00:00:00') AND (KmLog_1.Data <= '" & gstrDataFinala & " 23:59:59') " &
                    "GROUP BY KmLog_1.MasinaId, Masini_1.Numar " &
                    "HAVING         (COUNT(DISTINCT KmLog_1.UtilizatorId) >= 1)) AS derivedtbl_1)) " &
                    "AND (KmLog.Data >= '" & gstrDataInceput & " 00:00:00') AND (KmLog.Data <= '" & gstrDataFinala & " 23:59:59') ORDER BY Masini_2.Id) AS myq ON dbo.Masini.Id = myq.Id INNER JOIN " &
                    "dbo.Filiale ON dbo.Masini.FilialaId = dbo.Filiale.id INNER JOIN " &
                    "dbo.Utilizatori AS Utilizatori ON myq.Nume = Utilizatori.Nume" &
                    searchWord)
        If Not myDataTable Is Nothing Then
            'scrie gridul asa cum e (cu id-uri pentru utilizatori si greseli)
            For Each row As DataRow In myDataTable.Rows
                Dim inputData(4) As String
                inputData(0) = row("Numar")
                inputData(1) = row("Marca")
                inputData(2) = row("Model")
                inputData(3) = row("Filiala")
                inputData(4) = row("Nume")
                DataGridView2.Rows.Add(inputData)
            Next
        End If
        Me.Cursor = Cursors.Default

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        'TODO: This line of code loads data into the 'KmAutoDataSet.KmLog' table. You can move, or remove it, as needed.

        Try
            Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInKmLog\")

            Dim CautareInKmLogCombo As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\VB and VBA Program Settings\KmAutoInterface\Settings\CautareInKmLog")
            For Each ValueName As String In CautareInKmLogCombo.GetValueNames()
                Dim Value As Object = CautareInKmLogCombo.GetValue(ValueName) 'Get the value (data) of the specified value name.
                If Value IsNot Nothing Then 'Make sure it exists.
                    cmbCautare.Items.Add(Value.ToString())
                End If
            Next
            cmbCautare.Text = GetSetting(AppName, "Settings", "CautareInKmLogCombo", 0)


        Catch

        End Try

        incarcaMasiniSiUtilizatoriPentruAdaugareKm()
        updateGridLeftSideRaport(cmbCautare.Text)
        cmbIntervale.Text = "Toate"
        IncarcaSheets()
    End Sub
    Private Sub incarcaMasiniSiUtilizatoriPentruAdaugareKm()
        Dim utilizatoriDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select Nume from Utilizatori order by Nume")
        For Each row As System.Data.DataRow In utilizatoriDataTable.Rows
            cmbUtilizatori.Items.Add(row("Nume"))
        Next
        Dim masiniDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select Numar from Masini Order by Numar")
        For Each row As System.Data.DataRow In masiniDataTable.Rows
            cmbMasini.Items.Add(row("Numar"))
        Next
    End Sub
    Private Sub cmbCautare_TextChanged(sender As Object, e As EventArgs) Handles cmbCautare.TextChanged, cmbCautare.SelectedIndexChanged
        Timer3.Enabled = False
        Timer3.Enabled = True
    End Sub
    Private Sub cmbCautare_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCautare.KeyPress
        If e.KeyChar = Chr(27) Then
            cmbCautare.Text = ""
        End If
        Dim gasit As Boolean = False
        If e.KeyChar = Chr(13) Then
            For Each item As String In cmbCautare.Items
                If item = cmbCautare.Text Then
                    gasit = True
                End If
            Next
            If gasit = False Then
                cmbCautare.Items.Add(cmbCautare.Text)
                If cmbCautare.Text <> "" Then
                    SaveSetting(AppName, "Settings", "CautareInKmLogCombo", cmbCautare.Text)
                End If

            End If
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim clip As String = ""
        If cmbCautare.Text = "" Then
            cmbCautare.BackColor = SystemColors.Window
        Else
            cmbCautare.BackColor = System.Drawing.Color.Yellow

        End If
        cmdStergeListaCautare.Enabled = cmbCautare.Items.Count
        cmdStergeCrt.Enabled = cmbCautare.Items.Count
        cmdDeleteCurrentCell.Enabled = False
        If Not DataGridView1.CurrentCell Is Nothing Then
            cmdDeleteCurrentCell.Enabled = (DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Name = "StatusModificat")
        End If
        If DataGridView2.Rows.Count = 0 Then
            DataGridView1.Rows.Clear()
        End If



    End Sub



    Private Sub cmdStergeListaCautare_Click(sender As Object, e As EventArgs) Handles cmdStergeListaCautare.Click
        Dim result As DialogResult = MessageBox.Show("Stergeti lista de cautare?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            cmbCautare.Items.Clear()
            cmbCautare.Text = ""
        End If
        Microsoft.Win32.Registry.CurrentUser.DeleteSubKey("SOFTWARE\VB and VBA Program Settings\KmAutoInterface\Settings\CautareInKmLog")

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Enabled = False
        updateGridLeftSideRaport(cmbCautare.Text)
        cmbCautare.Select(cmbCautare.Text.Length, 0)        'pune cursorul la final
        upGridKmLog()
        cmbCautare.Focus()
        cmbCautare.SelectAll()

        'cmbCautare.Select(cmbCautare.Text.Length, 0)        'pune cursorul la final
        'cmbCautare.SelectionStart = 0
        'cmbCautare.SelectionLength = cmbCautare.Text.Length

    End Sub

    Private Sub cmdStergeCrt_Click(sender As Object, e As EventArgs) Handles cmdStergeCrt.Click
        cmbCautare.Items.Remove(cmbCautare.Text)
        Try
            cmbCautare.SelectedIndex = 0

        Catch

        End Try
    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        If DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Name = "PozaDinBord" Then
            Dim url As String = row.Cells.Item("PozaDinBord").Value
            Dim formP As New frmPoza

            formP.WebBrowser1.Url = New Uri(url)
            formP.Show()
        End If
        If DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Name = "Asumat" Then
            Dim asumat As String
            If Control.ModifierKeys = Keys.Control Then
                asumat = "Nu"
            Else
                asumat = "Da"
            End If
            For Each cell As DataGridViewCell In row.Cells
                If cell.RowIndex = e.RowIndex And cell.ColumnIndex = e.ColumnIndex Then
                    manipuleazaAsumarea(asumat, cell)

                End If
            Next

        End If
        If DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Name = "KmModificat" Then

        End If
        If DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Name = "Data" Then
            frmGetDataAsDate.Tag = DataGridView1.CurrentCell.Value
            frmGetDataAsDate.ShowDialog()
            DataGridView1.CurrentCell.Value = frmGetDataAsDate.Tag
            DataGridView1.EndEdit()
            DataGridView1.RefreshEdit()
            frmGetDataAsDate.Dispose()

        End If

    End Sub
    Private Sub manipuleazaAsumarea(asumat As String, Optional selectedCell As DataGridViewCell = Nothing)
        Cursor = Cursors.WaitCursor

        With DataGridView1
            For Each cell As DataGridViewCell In DataGridView1.SelectedCells
                execAsum(asumat, cell, CInt(DataGridView1.Columns("Asumat").Index))
            Next

        End With
        Cursor = Cursors.Default
    End Sub

    Private Sub execAsum(asumat As String, cell As DataGridViewCell, Optional columnNumber As Integer = 0)
        Try
            With DataGridView1
                Dim data As String = .Rows(cell.RowIndex).Cells(0).Value
                Dim masinaId As String = ReturExecutaSqlKmAuto("Select Id from Masini where Numar = '" & .Rows(cell.RowIndex).Cells(3).Value & "'")
                Dim utilizatorId As String = ReturExecutaSqlKmAuto("Select Id from Utilizatori where Nume = '" & .Rows(cell.RowIndex).Cells(2).Value & "'")
                Dim rez As String = ExecutaSQLKmAuto("UPDATE KmLog SET Asumat='" & asumat & "' Where Data ='" & data & "' and MasinaId = " & masinaId & " and UtilizatorId = " & utilizatorId)
                If columnNumber = 0 Then
                    cell.Value = asumat
                Else
                    .Rows(cell.RowIndex).Cells(columnNumber).Value = asumat

                End If
            End With

        Catch ex As System.Exception

        End Try
    End Sub


    Private Sub cmdAsumaSelectia_Click(sender As Object, e As EventArgs) Handles AsumaSelectiaToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Va asumati toate iregistrarile selectate?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then

            manipuleazaAsumarea("Da")
        End If
    End Sub

    Private Sub cmdStergeAsumareaSelectiei_Click(sender As Object, e As EventArgs) Handles StergeAsumareaToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Veti infirma inregistrarile selectate, adica nu mai garantati ca sunt corecte, prin asumare, confirmare. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            manipuleazaAsumarea("Nu")
        End If
    End Sub

    Private Sub cmdSchimbaStatusInteresDeServiciu_Click(sender As Object, e As EventArgs) Handles SchimbaStatusInteresServiciuToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Veti schimba status-ul din Interes serviciu in Normal pentru utilizatorii care au pe coloana 'Pune interes de serviciu fara sa fie nevoie' din tabelul Utilizatori in Google. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Cursor = Cursors.WaitCursor
            Try
                With DataGridView1
                    For Each row As DataGridViewRow In .Rows
                        For Each cell As DataGridViewCell In row.Cells
                            If cell.ColumnIndex = 6 Then
                                Dim data As String = .Rows(cell.RowIndex).Cells(0).Value
                                Dim masinaId As String = ReturExecutaSqlKmAuto("Select Id from Masini where Numar = '" & .Rows(cell.RowIndex).Cells(3).Value & "'")
                                Dim utilizatorId As String = ReturExecutaSqlKmAuto("Select Id from Utilizatori where Nume = '" & .Rows(cell.RowIndex).Cells(2).Value & "'")
                                Dim resultError As String = ExecutaSQLKmAuto("UPDATE       KmLog " &
                                    "SET Observatii2 = 'Setat status automat pe Normal din Interes serviciu', Status = 'Normal' " &
                                    "From Utilizatori INNER Join " &
                                    "KmLog On Utilizatori.Id = KmLog.UtilizatorId " &
                                    "Where (Utilizatori.PuneFrecventInteresServiciu = N'Da') AND (KmLog.Status = 'Interes serviciu')  " &
                                    "And (KmLog.Data = '" & data & "')  AND (KmLog.MasinaId = " & masinaId & ")  AND (KmLog.UtilizatorId = " & utilizatorId & ") ")
                                cell.Value = "Normal"
                                If resultError <> "" Then Me.Text = resultError
                                .Rows(cell.RowIndex).Cells(11).Value = "Setat status automat pe Normal din Interes serviciu"
                            End If
                        Next
                    Next
                End With

            Catch ex As System.Exception

            End Try
            updateGridLeftSideRaport(cmbCautare.Text)
            Cursor = Cursors.Default
        End If

    End Sub

    Private Sub cmdSchimbaStatusInapoilDinNormalInInteresServiciuPentruUtilizatoriiCareDeObiceiGresescStatusul_Click(sender As Object, e As EventArgs) Handles RefaceStatusInteresServiciuToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Veti schimba status-ul din Normal in Interes serviciu (refaceti status-ul) pentru utilizatorii care au pe coloana 'Pune interes de serviciu fara sa fie nevoie' din tabelul Utilizatori in Google. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Cursor = Cursors.WaitCursor
            Try
                With DataGridView2
                    For Each row As DataGridViewRow In .Rows
                        For Each cell As DataGridViewCell In row.Cells
                            If cell.ColumnIndex = 6 Then
                                Dim data As String = .Rows(cell.RowIndex).Cells(0).Value
                                Dim masinaId As String = ReturExecutaSqlKmAuto("Select Id from Masini where Numar = '" & .Rows(cell.RowIndex).Cells(3).Value & "'")
                                Dim utilizatorId As String = ReturExecutaSqlKmAuto("Select Id from Utilizatori where Nume = '" & .Rows(cell.RowIndex).Cells(2).Value & "'")
                                Dim resultError As String = ExecutaSQLKmAuto("UPDATE       KmLog " &
                                    "SET Observatii2 = '', Status = 'Interes serviciu' " &
                                    "From Utilizatori INNER Join " &
                                    "KmLog On Utilizatori.Id = KmLog.UtilizatorId " &
                                    "Where (Utilizatori.PuneFrecventInteresServiciu = N'Da') AND (KmLog.Status = 'Normal')  " &
                                    "And (KmLog.Data = '" & data & "')  AND (KmLog.MasinaId = " & masinaId & ")  AND (KmLog.UtilizatorId = " & utilizatorId & ") ")
                                cell.Value = "Interes serviciu"
                                If resultError <> "" Then Me.Text = resultError
                                .Rows(cell.RowIndex).Cells(11).Value = ""
                            End If
                        Next
                    Next
                End With

            Catch ex As System.Exception

            End Try
            updateGridLeftSideRaport(cmbCautare.Text)
            Cursor = Cursors.Default
        End If

    End Sub

    Private Sub cmdIesire_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub cmdDeschideSpreadsheet_Click(sender As Object, e As EventArgs) Handles cmdDeschideSpreadsheet.Click
        Dim spreadsheetId As String = cmbSpreadsheets.SelectedValue
        Dim url As String = "https://docs.google.com/spreadsheets/d/" & spreadsheetId
        If tabExists(url).Length > 0 Then
        Else
            Process.Start(url)
        End If

    End Sub

    Private Sub cmdMasini_Click(sender As Object, e As EventArgs) Handles cmdMasini.Click, MasiniToolStripMenuItem.Click
        Try
            gstrSearch = DataGridView2.CurrentRow.Cells("Numar").Value

        Catch ex As System.Exception

        End Try
        frmMasini.ShowDialog()
        frmMasini.Dispose()
    End Sub

    Private Sub cmdUtilizatori_Click(sender As Object, e As EventArgs) Handles cmdUtilizatori.Click, UtilizatoriToolStripMenuItem.Click
        Try
            gstrSearch = DataGridView2.CurrentRow.Cells("NumeUtilizator").Value

        Catch ex As System.Exception

        End Try
        frmUtilizatori.ShowDialog()
        frmUtilizatori.Dispose()

    End Sub


    Private Sub cmdGreseli_Click(sender As Object, e As EventArgs) Handles cmdGreseli.Click, UtilizatoriInexistentiToolStripMenuItem.Click
        frmGreseliLog.ShowDialog()
        frmGreseliLog.Dispose()

    End Sub

    Private Sub cmdEmail_Click(sender As Object, e As EventArgs) Handles cmdEmail.Click, EmailToolStripMenuItem.Click
        Try
            gstrSearch = DataGridView2.CurrentRow.Cells("NumeUtilizator").Value

        Catch ex As System.Exception

        End Try
        frmEmails.ShowDialog()
        frmEmails.Dispose()
    End Sub

    Private Sub cmdIesire_Click_1(sender As Object, e As EventArgs) Handles cmdIesire.Click, IesireToolStripMenuItem.Click
        Me.Close()
    End Sub







    Private Sub DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        With DataGridView1
            Dim cell As DataGridViewCell = .CurrentCell
            Dim coloana As String = .Columns(cell.ColumnIndex).Name
            If coloana <> "KmModificat" And coloana <> "StatusModificat" And coloana <> "Data" And coloana <> "Asumat" Then
                e.Cancel = True
            End If
            If coloana = "Data" Then
                myStrData = cell.Value
            End If
            If coloana = "KmModificat" Then
                myKmModificat = cell.Value
            End If
            If coloana = "StatusModificat" Then
                myStatusModificat = cell.Value
            End If
            If coloana = "Asumat" Then
                myStatusModificat = cell.Value
            End If
        End With
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Try
            With DataGridView1

                Dim cell As DataGridViewCell = .CurrentCell
                Dim coloana As String = .Columns(cell.ColumnIndex).Name
                Dim data As String = .Rows(cell.RowIndex).Cells("Data").Value
                Dim dataSiOraCitirii As String = .Rows(cell.RowIndex).Cells("DataSiOraCitirii").Value
                Dim masina As String = DataGridView2.CurrentRow.Cells("Numar").Value
                Dim masinaId As String = ReturExecutaSqlKmAuto("Select Id from Masini where Numar = '" & masina & "'")
                Dim utilizator As String = DataGridView2.CurrentRow.Cells("NumeUtilizator").Value
                Dim utilizatorId As String = ReturExecutaSqlKmAuto("Select Id from Utilizatori where Nume = '" & utilizator & "'")

                Dim spreadsheetName = DataGridView1.CurrentRow.Cells("Spreadsheet").Value
                Dim SpreadsheetId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
                Dim sheetName As String = ReturExecutaSqlKmAuto("Select Foaie from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
                '    Dim sheetId As String = ReturExecutaSqlkmAuto("Select SheetId from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")

                Select Case coloana
                    Case "KmModificat"
                        If cell.Value <> myKmModificat Then
                            Dim rez As String = ScrieCelulaInGoogle(data, masina, utilizator, SpreadsheetId, sheetName, cell, 11)
                            If rez = "Succes modificare." Then 'executat cu succes
                                lbInfo.Text = ExecutaSQLKmAuto("UPDATE KmLog SET KmModificat=" & If(cell.Value Is Nothing, "''", cell.Value) & " Where Data ='" & data & "' and MasinaId = " & masinaId & " and UtilizatorId = " & utilizatorId)
                                If lbInfo.Text = "Ok" Then
                                    lbInfo.Text = "Modificare km ok."
                                Else
                                    MsgBox("Modificare scriere km in KmLog esuata.", vbOK + vbCritical)

                                End If
                            Else
                                MsgBox("Modificare scriere Km in foaia Google esuata.", vbOK + vbCritical)

                            End If
                        End If
                    Case "StatusModificat"
                        If cell.Value <> myStatusModificat Then
                            Dim rez As String = ScrieCelulaInGoogle(data, masina, utilizator, SpreadsheetId, sheetName, cell, 12)
                            If rez = "Succes modificare." Then 'executat cu succes
                                lbInfo.Text = ExecutaSQLKmAuto("UPDATE KmLog SET StatusModificat='" & cell.Value & "' Where Data ='" & data & "' and MasinaId = " & masinaId & " and UtilizatorId = " & utilizatorId)
                                If lbInfo.Text = "Ok" Then
                                    lbInfo.Text = "Modificare status ok."
                                Else
                                    MsgBox("Modificare scriere status in kmLog esuata.", vbOK + vbCritical)

                                End If
                            Else
                                MsgBox("Modificare scriere status in foaia Google esuata.", vbOK + vbCritical)
                            End If
                        End If
                    Case "Data"
                        If cell.Value <> myStrData Then
                            Dim rez As String = ExecutaSQLKmAuto("UPDATE KmLog SET Data='" & cell.Value & "' Where Data ='" & myStrData & "' and MasinaId = " & masinaId & " and UtilizatorId = " & utilizatorId)
                            If rez = "Ok" Then 'executat cu succes
                                lbInfo.Text = ScrieCelulaInGoogle(myStrData, masina, utilizator, SpreadsheetId, sheetName, cell, 7, CDate(cell.Value).ToOADate)
                            End If
                        End If
                    Case "Asumat"
                        If cell.Value <> myStrData And cell.Value <> "" Then
                            Dim rez As String = ScrieCelulaInGoogle(data, masina, utilizator, SpreadsheetId, sheetName, cell, 9)
                            If rez = "Succes modificare." Then 'executat cu succes
                                lbInfo.Text = ExecutaSQLKmAuto("UPDATE KmLog SET Asumat='" & cell.Value & "' Where Data ='" & data & "' and MasinaId = " & masinaId & " and UtilizatorId = " & utilizatorId)
                                If lbInfo.Text = "Ok" Then
                                    lbInfo.Text = "Modificare Asumat ok."
                                Else
                                    MsgBox("Modificare scriere Asumat in KmLog esuata.", vbOK + vbCritical)

                                End If
                            Else
                                MsgBox("Modificare scriere Asumat in foaia Google esuata.", vbOK + vbCritical)
                            End If
                        End If
                End Select
                'Stop
            End With
        Catch ex As System.Exception
            'Stop
        End Try

    End Sub

    Private Sub cmdDeschideToateFoileGoogle_Click(sender As Object, e As EventArgs) Handles cmdDeschideToateFoileGoogle.Click
        If MsgBox("Atentie. Se vor deschide toate paginile gogle active. Continuati?", vbExclamation + vbYesNo) = vbYes Then

            Dim k As Long
            For k = 0 To cmbSpreadsheets.Items.Count - 1
                'Threading.Thread.Sleep(2000)
                cmbSpreadsheets.SelectedIndex = k
                Dim spreadsheetId As String = cmbSpreadsheets.SelectedValue
                Dim activ As String = ReturExecutaSqlKmAuto("Select Activ from Spreadsheets where SpreadsheetId = '" & spreadsheetId & "'")
                Dim url As String = "https://docs.google.com/spreadsheets/d/" & spreadsheetId
                If tabExists(url).Length > 0 Then
                Else
                    If activ = "Da" Then
                        Process.Start(url)
                    End If
                End If

            Next
        End If
    End Sub

    Private Sub cmdDeleteCurrentCell_Click(sender As Object, e As EventArgs) Handles cmdDeleteCurrentCell.Click, StergeStatusToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Stergeti celula curenta?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            DataGridView1.CurrentCell.Value = ""
            DataGridView1.EndEdit()
            DataGridView1.RefreshEdit()
        End If
    End Sub

    Private Sub cmdReincarca_Click(sender As Object, e As EventArgs) Handles cmdReincarca.Click, ReincarcaToolStripMenuItem.Click
        kmAutoSqlCon.Close()
        kmAutoSqlCon.Open()
        kmAutoCmd.Connection = kmAutoSqlCon
        kmAutoCmd.CommandTimeout = 20000

        updateGridLeftSideRaport()
    End Sub

    Private Sub cmbIntervale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIntervale.SelectedIndexChanged
        upGridKmLog()
    End Sub

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
        upGridKmLog()

    End Sub




    Private Sub cmdForteazaFolosesteDeObiceiMasinaPeNu_Click(sender As Object, e As EventArgs) Handles cmdForteazaFolosesteDeObiceiMasinaPeNu.Click
        Dim result As DialogResult = MessageBox.Show("Se va completa in Google sheets coloana Asumat cu valoarea 'Da' acolo unde utilizatorul are completat campul 'Foloseste de obicei masina in weekend' = Nu, in foaia google Utilizatori. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            ForteazaStatus("Forteaza Foloseste de obicei masina in weekend pe Nu")
        End If
    End Sub


    Private Sub ForteazaStatus(tip As String)
        pbIncarca.Value = 0
        pbIncarca.Maximum = DataGridView2.Rows.Count
        Dim k, i As Integer, j As Integer
        For k = 0 To DataGridView2.Rows.Count - 1 'ia pe rand toate masinile
            DataGridView2.CurrentCell = DataGridView2.Item(0, k) 'selecteaza fiecare masina in parte
            Dim masinaId, utilizatorId As Long
            Dim masina As String = DataGridView2.CurrentRow.Cells("Numar").Value.ToString
            Dim utilizator As String = DataGridView2.CurrentRow.Cells("NumeUtilizator").Value.ToString
            masinaId = ReturExecutaSqlKmAuto("Select Id from Masini Where Numar = '" & masina & "'")
            utilizatorId = ReturExecutaSqlKmAuto("Select Id from Utilizatori Where Nume = '" & utilizator & "'")
            'If utilizator = "Cucu Octavian" Then Stop
            Dim FolosesteDeObicei As String = ReturExecutaSqlKmAuto("Select DeObiceiFolosesteMasina from Utilizatori where Nume = '" & utilizator & "'")
            pbIncarca.Value = k
            cmbIntervale.SelectedIndex = 0
            For i = 0 To cmbIntervale.Items.Count - 2 'ia pe rand toate intervalele dar fara 'Toate'
                cmbIntervale.SelectedIndex = i
                Me.Refresh()
                Try
                    wait(10)
                    DataGridView1.Refresh()
                    upGridKmLog() 'incarca valorile din kmLog
                    With DataGridView1
                        Select Case tip
                            Case "Forteaza Foloseste de obicei masina in weekend pe Nu"
                                If DataGridView1.Rows.Count > 0 Then
                                    For j = 0 To DataGridView1.Rows.Count - 1
                                        .CurrentCell = DataGridView1(11, j) 'coloana Asumat)
                                        myStatusModificat = .CurrentCell.Value
                                        If FolosesteDeObicei = "Nu" Then
                                            .CurrentCell.Value = "Da"
                                        Else
                                            .CurrentCell.Value = ""

                                        End If
                                        Dim eee As New DataGridViewCellEventArgs(11, j)
                                        DataGridView1_CellEndEdit(DataGridView1, eee)
                                    Next
                                End If
                        End Select
                    End With
                Catch ex As System.Exception

                End Try
            Next
            'refreshGrid1(DataGridView2.CurrentRow)
            Me.Refresh()
        Next

        pbIncarca.Value = 0
        cmbIntervale.SelectedIndex = cmbIntervale.Items.Count - 1 'pune intervalul pe 'Toate' - ca sa aiba un punct de plecare diferit

    End Sub

    Private Sub cmdToateIntervalele_Click(sender As Object, e As EventArgs) Handles cmdToateIntervalele.Click
        cmbIntervale.Text = "Toate"
    End Sub



    Private Sub cmbMasini_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMasini.SelectedIndexChanged
        Dim utilizatoriDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select DISTINCT TOP (100) PERCENT dbo.Utilizatori.Nume, dbo.Masini.Numar " &
                     "FROM dbo.Masini INNER JOIN " &
                     "dbo.KmLog On dbo.Masini.Id = dbo.KmLog.MasinaId INNER JOIN " &
                     "dbo.Utilizatori On dbo.KmLog.UtilizatorId = dbo.Utilizatori.Id " &
                     "WHERE (dbo.Masini.Numar = N'" & cmbMasini.Text & "')")
        'Dim utilizatoriDataTable as system.data.DataTable = ReturDataTablekmAuto("Select Nume from utilizatori Order by Nume")
        If utilizatoriDataTable.Rows.Count > 0 Then
            For Each row As System.Data.DataRow In utilizatoriDataTable.Rows
                If row("Numar") = cmbMasini.Text Then

                End If
                cmbUtilizatori.SelectedItem = row("Nume")
            Next
        Else
        End If

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub txtCautareMasina_TextChanged(sender As Object, e As EventArgs) Handles txtCautareMasina.TextChanged
        txtCautareMasina.BackColor = System.Drawing.Color.Red
        txtCautareMasina.ForeColor = System.Drawing.Color.Yellow
        For Each item As String In cmbMasini.Items
            If item.Contains(txtCautareMasina.Text) Then
                cmbMasini.SelectedItem = item
                Dim foaie As String = ReturExecutaSqlKmAuto("SELECT TOP (1) dbo.Spreadsheets.Nume " &
                     "FROM dbo.Masini INNER JOIN " &
                     "dbo.Filiale ON dbo.Masini.FilialaId = dbo.Filiale.id INNER JOIN " &
                     "dbo.Spreadsheets ON dbo.Filiale.Nume = dbo.Spreadsheets.Filiala " &
                     "WHERE (dbo.Masini.Numar = '" & item & "')")
                cmbSpreadsheets1.Text = foaie
                txtCautareMasina.BackColor = System.Drawing.Color.Green
                txtCautareMasina.ForeColor = System.Drawing.Color.White
                Exit For
            End If
        Next
    End Sub

    Private Sub puneDataPentruAdaugare()

        If Not DataGridView1.CurrentRow Is Nothing AndAlso DataGridView1.CurrentRow.Cells("Data").Value <> "" Then
            dtpDataRaportarii.Value = convertStringDataToDate(DataGridView1.CurrentRow.Cells("Data").Value)
        End If
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        grid1Click()

    End Sub
    Private Sub grid1Click()
        puneDataPentruAdaugare()
        Try
            textBoxKm.Text = If(DataGridView1.CurrentRow.Cells("KmModificat").Value <> "", DataGridView1.CurrentRow.Cells("KmModificat").Value, DataGridView1.CurrentRow.Cells("Km").Value)
            cmbStatus.Text = If(DataGridView1.CurrentRow.Cells("StatusModificat").Value <> "", DataGridView1.CurrentRow.Cells("StatusModificat").Value, DataGridView1.CurrentRow.Cells("Status").Value)
            TextBoxObservatii.Text = DataGridView1.CurrentRow.Cells("Observatii").Value
        Catch ex As System.Exception

        End Try
        selecteazaGPSsauCAN()
    End Sub
    Private Sub selecteazaGPSsauCAN()
        Try
            Dim k As Integer, i As Integer
            For k = 0 To DataGridView3.Rows.Count - 1
                DataGridView3.CurrentCell = DataGridView3(0, k)
                DataGridView3.Rows(k).Selected = True
                DataGridView3.FirstDisplayedScrollingRowIndex = k
                For i = k + 1 To DataGridView3.Rows.Count - 1
                    If DataGridView3(0, i).Value = DataGridView3(0, k).Value Then
                        DataGridView3.Rows(i).Selected = True

                    Else
                        Exit For
                    End If
                Next
                If DataGridView3.CurrentCell.Value <= convertStringDataToDate(DataGridView1.CurrentRow.Cells("Data").Value) Then Exit For
            Next

        Catch ex As System.Exception

        End Try

    End Sub

    Private Sub dtpDataRaportarii_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpDataRaportarii.KeyPress
        If e.KeyChar = vbCr Then SendKeys.Send("{Tab}")
    End Sub



    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textBoxKm.KeyPress
        If e.KeyChar = vbCr Then SendKeys.Send("{Tab}")

    End Sub


    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbStatus.KeyPress
        If e.KeyChar = vbCr Then SendKeys.Send("{Tab}")

    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCautareMasina.KeyPress
        If e.KeyChar = vbCr Then SendKeys.Send("{Tab}")

    End Sub

    Private Sub cmbMasini_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbMasini.KeyPress
        If e.KeyChar = vbCr Then SendKeys.Send("{Tab}")

    End Sub


    Private Sub cmbUtilizatori_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbUtilizatori.KeyPress
        If e.KeyChar = vbCr Then SendKeys.Send("{Tab}")

    End Sub


    Private Sub cmbSpreadsheets_SelectedIndexChanged(sender As Object, e As EventArgs)
        cmbSpreadsheets1.SelectedIndex = cmbSpreadsheets.SelectedIndex
    End Sub

    Private Sub cmbSpreadsheets1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbSpreadsheets1.KeyPress
        If e.KeyChar = vbCr Then SendKeys.Send("{Tab}")

    End Sub
    Private Sub cmdAdauga_Click(sender As Object, e As EventArgs) Handles cmdAdauga.Click
        Dim d As DateTime = New DateTime(DateAndTime.Year(dtpDataRaportarii.Value), DateAndTime.Month(dtpDataRaportarii.Value), DateAndTime.Day(dtpDataRaportarii.Value), DateAndTime.Hour(dtpDataRaportarii.Value), DateAndTime.Minute(dtpDataRaportarii.Value), 0, DateTime.Now.Kind)
        Dim km As Long
        Try
            km = CLng(textBoxKm.Text)

        Catch ex As System.Exception
            MessageBox.Show("Nu ati introdus valoare pentru Km.")
            Exit Sub
        End Try
        Dim status As String = cmbStatus.Text
        Dim result As DialogResult = MessageBox.Show("Se va adauga o inregistrare noua in tabelul Google. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            Dim gsh As New GoogleSheetsHelper
            Dim spreadsheetId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets where Nume = '" & cmbSpreadsheets1.Text & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
            Dim sheetId As String = ReturExecutaSqlKmAuto("Select SheetId from Spreadsheets where Nume = '" & cmbSpreadsheets1.Text & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
            gsh.RemoveFilter(spreadsheetId, sheetId)
            wait(3000)
            If TextBoxObservatii.Text = "" Then
                TextBoxObservatii.Text = "Asumat rand nou"
            End If
            Dim ret As String = AdaugaRandInGoogle(d, km, status, cmbSpreadsheets1.Text, cmbUtilizatori.Text, cmbMasini.Text, TextBoxObservatii.Text, DataGridView1)
            If ret = "Salvat cu succes" Then
                lbInfo.Text = "Inregistrarea a fost adaugata cu succes atat in Google cat si in baza de date"
            End If
            IncarcaKmLog(False)

        End If
    End Sub
    Private Sub cmdPregatesteComplementNul_Click(sender As Object, e As EventArgs) Handles cmdPregatesteComplementNul.Click
        Try
            Dim status As String = If(DataGridView1.CurrentRow.Cells("StatusModificat").Value <> "", DataGridView1.CurrentRow.Cells("StatusModificat").Value, DataGridView1.CurrentRow.Cells("Status").Value)
            If status = "Referinta" Then status = "Normal" Else status = "Referinta"
            cmbStatus.Text = status
            TextBoxObservatii.Text = "Adaugare inregistrare complementara cu acelasi index"
            dtpDataRaportarii.Value = ReturDataComplementara(dtpDataRaportarii.Value, status)

        Catch ex As System.Exception
            MessageBox.Show("Nu puteti pune un complement la o inregistrare pentru ca nu exista nici o inregistrare in intervalul curent pe care sa o complementati.")
        End Try

    End Sub

    Private Sub cmdCreazaWeekendNul_Click(sender As Object, e As EventArgs) Handles cmdCreazaWeekendNul.Click
        'cu valorile din formularul pentru randuri noi, mai putin data va crea doua inregistrari nule (index -1) pentru weekendul 'interval'
        If DataGridView1.Rows.Count > 0 Then
            MessageBox.Show("Exista inregistrari in intervalul selectat. Nu puteti crea un weekend null (cu valori de km -1 si status Referinta si apoi Normal")
            Exit Sub
        End If
        Dim result As DialogResult = MessageBox.Show("Se vor adauga doua inregistrari nule in tabelul Google.Prima cu status Referinta si a doua cu status Normal dar km = -1 pentru ambele. . Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            If TextBoxObservatii.Text = "" Then
                TextBoxObservatii.Text = "Asumat weekend nul"
            End If
            If AdaugaWeekendNul(cmbIntervale.Text, cmbSpreadsheets1.Text, cmbUtilizatori.Text, cmbMasini.Text, TextBoxObservatii.Text, DataGridView1) = "Adaugare Ok" Then
                lbInfo.Text = "Au fost adaugate doua inregistrari nule (km = -1) atat in foia Google cat si in baza de date"
                IncarcaKmLog(False)

            End If

        End If
    End Sub

    Private Sub cmdStergeInregistrareaCurenta_Click(sender As Object, e As EventArgs) Handles cmdStergeInregistrareaCurenta.Click
        If Not DataGridView1.CurrentRow Is Nothing AndAlso Not DataGridView2.CurrentRow Is Nothing Then
            Dim result As DialogResult = MessageBox.Show("Se va sterge randul curent din tabelul Google. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If result = DialogResult.Yes Then

                Try
                    Dim masina, utilizator As String, masinaId, utilizatorId As Long
                    Dim Data, DataSiOraCitirii As Double
                    masina = DataGridView2.CurrentRow.Cells("Numar").Value
                    masinaId = ReturExecutaSqlKmAuto("Select Id from Masini Where Numar = '" & masina & "'")

                    utilizator = DataGridView2.CurrentRow.Cells("NumeUtilizator").Value
                    utilizatorId = ReturExecutaSqlKmAuto("Select Id from Utilizatori Where Nume = '" & utilizator & "'")
                    Data = convertStringDataToDouble(DataGridView1.CurrentRow.Cells("Data").Value)
                    DataSiOraCitirii = convertStringDataToDouble(DataGridView1.CurrentRow.Cells("DataSiOraCitirii").Value)

                    Dim gsh As New GoogleSheetsHelper
                    Dim spreadsheetName As String = cmbSpreadsheets1.Text
                    Dim SpreadsheetId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
                    Dim sheetName As String = ReturExecutaSqlKmAuto("Select Foaie from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
                    Dim sheetId As String = ReturExecutaSqlKmAuto("Select SheetId from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
                    gsh.RemoveFilter(SpreadsheetId, sheetId)
                    wait(3000)
                    lbInfo.Text = StergeRandInGoogle(masina, utilizator, SpreadsheetId, sheetName, sheetId, Data, DataSiOraCitirii)
                    If lbInfo.Text = "Succes stergere." Then
                        'sterge si din baza de date
                        Dim rez As String = ExecutaSQLKmAuto("Delete from KmLog Where Data = '" & DataGridView1.CurrentRow.Cells("Data").Value & "' and MasinaId = " & masinaId & " and UtilizatorId = " & utilizatorId & "")
                        If rez = "Ok" Then
                            'sterge si din grid
                            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
                        End If
                    End If
                    IncarcaKmLog(False)

                Catch ex As System.Exception
                    Stop

                End Try
            End If
        End If
    End Sub

    Private Sub CarteTelefoaneToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'AppPath = "C:\Consolight_RPA\Robots\km-auto\"
        Dim ws As Workbook = myEx.Workbooks.Open(AppPath & "input\Carte telefoane.xlsx")
        myEx.Visible = True
    End Sub

    Private Sub cmdFormatGoogle_Click(sender As Object, e As EventArgs) Handles cmdFormatGoogle.Click
        Dim result As DialogResult = MessageBox.Show("Se va seta formatul de data pentru coloanele Timestamp si Data si ora citirii kilometrajului din toate foile Google ce contin date de introducere km. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        If result = DialogResult.Yes Then
            pbIncarca.Maximum = cmbSpreadsheets1.Items.Count
            pbIncarca.Value = 0

            Dim k As Long
            For k = 0 To cmbSpreadsheets1.Items.Count - 1
                cmbSpreadsheets1.SelectedIndex = k
                Dim spreadsheetId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets where Nume = '" & cmbSpreadsheets1.Text & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
                Dim sheetId As String = ReturExecutaSqlKmAuto("Select SheetId from Spreadsheets where Nume = '" & cmbSpreadsheets1.Text & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
                Dim ret As String = ReturExecutaSqlKmAuto("Select Activ from Spreadsheets Where Nume = '" & cmbSpreadsheets1.Text & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
                If ret = "Da" Then
                    Dim gsh As New GoogleSheetsHelper
                    gsh.RemoveFilter(spreadsheetId, sheetId)
                    wait(2000)
                    schimbaFormatulDateiPentruColoaneleTimeStampSiDataSiOraCitiriiKilometrajului(cmbSpreadsheets1.Text)

                End If
                pbIncarca.Value = k
            Next
        End If
        pbIncarca.Value = 0
    End Sub
    Private Sub schimbaFormatulDateiPentruColoaneleTimeStampSiDataSiOraCitiriiKilometrajului(spreadsheetName As String)
        Dim gsh As New GoogleSheetsHelper
        Dim SpreadsheetId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
        Dim sheetName As String = ReturExecutaSqlKmAuto("Select Foaie from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
        Dim sheetId As String = ReturExecutaSqlKmAuto("Select SheetId from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")

        lbInfo.Text = gsh.GoogleRepeatCellRequest(SpreadsheetId, sheetId, 0)
        lbInfo.Text = gsh.GoogleRepeatCellRequest(SpreadsheetId, sheetId, 6)


    End Sub


    Private Sub TextBoxObservatii_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxObservatii.KeyPress, textBoxKm.KeyPress
        If e.KeyChar = vbCr Then SendKeys.Send("{Tab}")

    End Sub

    Private Sub cmdRefreshCautareCurenta_Click(sender As Object, e As EventArgs) Handles cmdRefreshCautareCurenta.Click
        Timer3.Enabled = True
    End Sub




    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer4.Enabled = False
        selecteazaGPSsauCAN()


    End Sub

    Private Sub cmdCautaTot_Click(sender As Object, e As EventArgs) Handles cmdCautaTot.Click
        cmbCautare.Text = ""

    End Sub



    Private Sub txtCautareUtilizator_TextChanged(sender As Object, e As EventArgs) Handles txtCautareUtilizator.TextChanged
        txtCautareUtilizator.BackColor = System.Drawing.Color.Red
        txtCautareUtilizator.ForeColor = System.Drawing.Color.Yellow
        For Each item As String In cmbUtilizatori.Items
            If LCase(item).Contains(LCase(txtCautareUtilizator.Text)) Then
                cmbUtilizatori.SelectedItem = item
                txtCautareUtilizator.BackColor = System.Drawing.Color.Green
                txtCautareUtilizator.ForeColor = System.Drawing.Color.White
                Exit For
            End If
        Next

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
    Private Sub cmdIncarcaToateFoileGoogle_Click(sender As Object, e As EventArgs) Handles cmdIncarcaToateFoileGoogle.Click
        Dim result As DialogResult = MessageBox.Show("Atentie. Se vor incarca datele din foile Google'. Continuati?", "Km Auto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            IncarcaToateFoileGoogle()
        End If

    End Sub
    Sub IncarcaToateFoileGoogle()
        Dim gsh As New GoogleSheetsHelper
        pbIncarca.Maximum = lvSheets.Items.Count
        Me.Cursor = Cursors.WaitCursor
        pbIncarca.Value = 0
        ExecutaSQLKmAuto("Delete from KmLog")
        For Each lv As ListViewItem In lvSheets.Items
            pbIncarca.Value += 1
            lv.Selected = True
            Dim sheetName As String = ReturExecutaSqlKmAuto("Select Foaie from Spreadsheets Where Nume = '" & lv.Text & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
            Dim myList As IList(Of IList(Of Object)) = gsh.GetRowsList(lv.SubItems(3).Text, sheetName)
            Dim sprId As String = lv.SubItems(3).Text
            If WriteKmLog(myList, sprId) = False Then
                Exit For
            End If
        Next
        Me.Cursor = Cursors.Default
        pbIncarca.Value = 0
        Timer3.Enabled = True

    End Sub
    Private Sub IncarcaKmLog(write As Boolean)
        DataGridView4.Rows.Clear()
        Dim gsh As New GoogleSheetsHelper
        Me.Cursor = Cursors.WaitCursor
        Dim spreadsheetId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets Where Nume = '" & cmbSpreadsheets.Text & "' and Foaie <> N'' and Activ = 'Da' and SheetId <> N''")
        Dim spreadsheets_id As Integer = ReturExecutaSqlKmAuto("Select Id from Spreadsheets where SpreadsheetId ='" & spreadsheetId & "'")
        Dim sheetName As String = ReturExecutaSqlKmAuto("Select Foaie from Spreadsheets Where Nume = '" & cmbSpreadsheets.Text & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
        Dim sheetId As String = ReturExecutaSqlKmAuto("Select SheetId from Spreadsheets Where Nume = '" & cmbSpreadsheets.Text & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
        schimbaFormatulDateiPentruColoaneleTimeStampSiDataSiOraCitiriiKilometrajului(cmbSpreadsheets.Text)
        Dim myList As IList(Of IList(Of Object)) = gsh.GetRowsList(spreadsheetId, sheetName)
        If write Then
            ExecutaSQLKmAuto("Delete from KmLog where Spreadsheets_id = " & spreadsheets_id)
            WriteKmLog(myList, spreadsheetId)
        End If
        Me.Cursor = Cursors.Default
        Dim i, k As Integer
        If DataGridView2.Rows.Count > 0 Then
            For k = 1 To myList.Count - 1
                Dim numar As String = DataGridView2.CurrentRow.Cells("Numar").Value
                Dim nume As String = DataGridView2.CurrentRow.Cells("NumeUtilizator").Value
                Dim Data As Date = DateSerial(1900, 1, 1)
                'If myList(k).Count > 12 Then Stop
                If myList(k).Count < 12 Then
                    For i = myList(k).Count To 12
                        myList(k).Add("")
                    Next
                End If
                If myList(k)(6) <> "" Then
                    If IsNumeric(myList(k)(6)) Then
                        Data = System.DateTime.FromOADate(myList(k)(6))
                    Else
                        Data = myList(k)(6)
                    End If
                End If
                If Data = DateSerial(1900, 1, 1) Then Data = myList(k)(0)
                If Data < convertStringDataToDate(gstrDataInceput) Then Continue For
                If numar = myList(k)(1) Or nume = myList(k)(2) Then
                    Dim inputData(11) As String
                    For i = 0 To myList(k).Count - 1
                        inputData(If(i > 7, i - 1, i)) = myList(k)(i)
                    Next
                    DataGridView4.Rows.Add(inputData)
                End If
            Next
        End If
        DataGridView4.Sort(DataGridView4.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        Me.Cursor = Cursors.Default


        'Dim gsh As New GoogleSheetsHelper
        'Me.Cursor = Cursors.WaitCursor
        'Dim spreadsheetId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets Where Nume = '" & cmbSpreadsheets.Text & "' and Foaie <> N'' and Activ = 'Da' and SheetId <> N''")
        'Dim sheetName As String = ReturExecutaSqlKmAuto("Select Foaie from Spreadsheets Where Nume = '" & cmbSpreadsheets.Text & "'")
        'Dim myList As IList(Of IList(Of Object)) = gsh.GetRowsList(spreadsheetId, sheetName)

        'pbIncarca.Value = 0
    End Sub
    Private Sub cmdProceseazaLocal_Click(sender As Object, e As EventArgs) Handles cmdProceseazaLocal.Click
        Dim result As DialogResult = MessageBox.Show("Atentie. Se va rula procesator.xlsx daca acesta exista pe calculatorul local'. Continuati?", "Km Auto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Dim dt As System.Data.DataTable = ReturDataTableKmAuto("Select Data from kmLog")
            If dt.Rows.Count > 0 Then
                Dim myw As Excel.Workbook = myEx.Workbooks.Open(AppPath & "output\procesator.xlsm")
                myEx.Visible = True
                myEx.Run("executa")
                myw.Close(False)
            Else
                MessageBox.Show("Nu exista inregistrari in tabelul KmAuto. Incarcati mai intai datele din sheet-uri fie ruland robotul (pe server) fie apasati butonul 'Incarca Km log'")
            End If
        End If
    End Sub


    Private Sub cmdScoateFiltrul_Click(sender As Object, e As EventArgs) Handles cmdScoateFiltrul.Click
        Dim gsh As New GoogleSheetsHelper
        Dim spreadsheetId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets where Nume = '" & cmbSpreadsheets1.Text & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
        Dim sheetId As String = ReturExecutaSqlKmAuto("Select SheetId from Spreadsheets where Nume = '" & cmbSpreadsheets1.Text & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
        Me.Text = Rnd() * 5000

        gsh.RemoveFilter(spreadsheetId, sheetId)

    End Sub

    Private Sub cmdPuneFiltrul_Click(sender As Object, e As EventArgs) Handles cmdPuneFiltrul.Click
        Dim gsh As New GoogleSheetsHelper
        Dim spreadsheetId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets where Nume = '" & cmbSpreadsheets1.Text & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
        Dim sheetId As String = ReturExecutaSqlKmAuto("Select SheetId from Spreadsheets where Nume = '" & cmbSpreadsheets1.Text & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
        gsh.SetFilter(spreadsheetId, sheetId)

    End Sub

    Private Sub cmdDeschideProcesator_Click(sender As Object, e As EventArgs) Handles cmdDeschideProcesator.Click
        System.Diagnostics.Process.Start("excel.exe", AppPath & "output\procesator.xlsm")

    End Sub

    Private Sub cmdDeschideRaportCurent_Click(sender As Object, e As EventArgs) Handles cmdDeschideRaportCurent.Click
        System.Diagnostics.Process.Start("excel.exe", """" & AppPath & "output\" & gstrDataRaportarii & "\KmAuto - " & gstrDataRaportarii & ".xlsm""")


    End Sub

    Private Sub cmdIncarcaFoaiaCurenta_Click(sender As Object, e As EventArgs) Handles cmdIncarcaFoaiaCurenta.Click
        IncarcaKmLog(True)
        Timer3.Enabled = True

    End Sub

    Private Sub cmdJurnal_Click(sender As Object, e As EventArgs) Handles cmdJurnal.Click
        frmJurnal.ShowDialog()
        frmJurnal.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtPlus_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPlus.TextChanged

    End Sub

    Private Sub txtPlus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPlus.KeyPress

    End Sub

    Private Sub txtPlus_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPlus.KeyDown
        If Not (e.KeyCode <= Keys.NumPad9 AndAlso e.KeyCode >= Keys.NumPad0) _
        AndAlso Not (e.KeyCode >= Keys.D0 AndAlso e.KeyCode <= Keys.D9) Then
            e.SuppressKeyPress = True
        End If
    End Sub



    Private Sub textBoxKm_KeyDown(sender As Object, e As KeyEventArgs) Handles textBoxKm.KeyDown
        If Not (e.KeyCode <= Keys.NumPad9 AndAlso e.KeyCode >= Keys.NumPad0) _
        AndAlso Not (e.KeyCode >= Keys.D0 AndAlso e.KeyCode <= Keys.D9) Then
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        Try
            textBoxKm.Text = CLng(textBoxKm.Text) + CLng(TextBoxPlus.Text)

        Catch ex As System.Exception

        End Try
    End Sub


    Private Sub frmKmLogView_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Timer3.Enabled = True
    End Sub

    Private Sub cmdAsumaTotIntervalul_Click(sender As Object, e As EventArgs) Handles cmdAsumaTotIntervalul.Click
        'cu valorile din formularul pentru randuri noi, mai putin data va crea doua inregistrari nule (index -1) pentru weekendul 'interval'
        If DataGridView1.Rows.Count > 0 And cmbIntervale.Text <> "Toate" Then 'trebuie sa fie un interval selectat si sa aiba inregistrari
            Dim result As DialogResult = MessageBox.Show("Se vor edita toate inregistrarile existente in intervalul curent punandu-se 'Asumat' la fiecare. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then

                Dim err As String = "Erori acumulate in timpul scrierii: "
                Dim observatii As String = "Asumat tot intervalul"
                For Each row As DataGridViewRow In DataGridView1.Rows
                    Dim cell As DataGridViewCell = row.Cells("Asumat") '.CurrentCell
                    cell.Value = "Da"
                    'Dim coloana As String = DataGridView1.Columns(cell.ColumnIndex).Name
                    Dim data As String = row.Cells("Data").Value
                    'Dim dataSiOraCitirii As String = row.Cells("DataSiOraCitirii").Value
                    Dim masina As String = DataGridView2.CurrentRow.Cells("Numar").Value
                    Dim masinaId As String = ReturExecutaSqlKmAuto("Select Id from Masini where Numar = '" & masina & "'")
                    Dim utilizator As String = DataGridView2.CurrentRow.Cells("NumeUtilizator").Value
                    Dim utilizatorId As String = ReturExecutaSqlKmAuto("Select Id from Utilizatori where Nume = '" & utilizator & "'")

                    Dim spreadsheetName = DataGridView1.CurrentRow.Cells("Spreadsheet").Value
                    Dim SpreadsheetId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
                    Dim sheetName As String = ReturExecutaSqlKmAuto("Select Foaie from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
                    'Dim sheetId As String = ReturExecutaSqlKmAuto("Select SheetId from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
                    'Dim d As DateTime = row.Cells("Data").Value
                    'Dim km As Integer = row.Cells("Km").Value
                    'Dim Status As String = row.Cells("Status").Value

                    Dim rez As String = ScrieCelulaInGoogle(data, masina, utilizator, SpreadsheetId, sheetName, cell, 9)
                    If rez = "Succes modificare." Then 'executat cu succes
                        lbInfo.Text = ExecutaSQLKmAuto("UPDATE KmLog SET Asumat='" & cell.Value & "' Where Data ='" & data & "' and MasinaId = " & masinaId & " and UtilizatorId = " & utilizatorId)
                        If lbInfo.Text = "Ok" Then
                            lbInfo.Text = "Modificare Asumat ok."
                        Else
                            'MsgBox("Modificare scriere Asumat in KmLog esuata.", vbOK + vbCritical)
                            err &= vbCrLf & "tabelul KmLog: Data " & data & " Valoare: " & cell.Value
                        End If
                    Else
                        'MsgBox("Modificare scriere Asumat in foaia Google esuata.", vbOK + vbCritical)
                        err &= vbCrLf & "tabelul Google sheet: Data " & data & " Valoare: " & cell.Value
                    End If
                Next
                If err <> "Erori acumulate in timpul scrierii: " Then MessageBox.Show(err) Else lbInfo.Text = "Modificare status pentru tot intervalul " & cmbIntervale.Text & ": Ok"
            End If
        Else
            MessageBox.Show("Trebuie sa fie selectat un interval si sa aiba inregistrari")
        End If
    End Sub

    Private Sub cmdOperatiiBulk_Click(sender As Object, e As EventArgs) Handles cmdOperatiiBulk.Click
        Try
            gstrSearch = DataGridView2.CurrentRow.Cells("Numar").Value
            gstrSearchSecond = DataGridView2.CurrentRow.Cells("NumeUtilizator").Value

        Catch ex As System.Exception

        End Try
        frmBulk.ShowDialog()
        frmBulk.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim in_numeLunaDeSetat As String = "May, 2023"
        Dim v() As String, k As Long
        v = Split(in_numeLunaDeSetat, ", ")
        For k = 1 To 12
            If MonthName(k) = v(0) Then 'am gasit luna
                in_numeLunaDeSetat = "[Date].[Month].&[" & v(1) & If(k < 10, "0", "") & k.ToString & "]"
                Exit For
            End If
        Next k
    End Sub

    Private Sub cmdFiliale_Click(sender As Object, e As EventArgs) Handles cmdFiliale.Click
        frmFiliale.ShowDialog()
        frmFiliale.Dispose()

    End Sub



    'ciorna
End Class