Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports KmAutoInterface.KmAutoDataSet
Imports Microsoft.Office.Interop.Outlook
Imports Microsoft.Win32

Public Class frmUtilizatori
    Private randuriGrid As Integer = 0
    Private randGridCurent As Integer = 0
    Private randDeSters As Integer = -1
    Private lstDataGrid As IList(Of Object)
    Private spreadsheetName = "Utilizatori"
    Public util As New Utilizator

    Private Sub frmUtilizatori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KmAutoDataSet.Filiale' table. You can move, or remove it, as needed.
        Me.FilialeTableAdapter.Fill(Me.KmAutoDataSet.Filiale)
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 982, 879)
        lstDataGrid = New List(Of Object)
        lstDataGrid.Add(-1)
        'Try
        '    kmAutoSqlCon.ConnectionString = kmAutoConnectionString
        '    kmAutoSqlCon.Open()
        '    kmAutoCmd.Connection = kmAutoSqlCon
        '    kmAutoCmd.CommandTimeout = 20000

        'Catch ex As System.Exception

        'End Try
        Try
            cmbCautare.SelectedIndex = GetSetting(AppName, "Settings", "CautareInUtilizatoriCombo_selectedIndex", 0)

        Catch ex As System.Exception

        End Try


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
            End If
        End If
    End Sub

    Private Sub frmUtilizatori_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)
        SaveSetting(AppName, "Settings", "CautareInUtilizatoriCombo_selectedIndex", cmbCautare.SelectedIndex)

        Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInUtilizatori\")
        For Each item As String In cmbCautare.Items
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInUtilizatori\", item, item)
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Try
            Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInUtilizatori\")

            Dim CautareInUtilizatoriCombo As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\VB and VBA Program Settings\KmAutoInterface\Settings\CautareInUtilizatori")
            For Each ValueName As String In CautareInUtilizatoriCombo.GetValueNames()
                Dim Value As Object = CautareInUtilizatoriCombo.GetValue(ValueName) 'Get the value (data) of the specified value name.
                If Value IsNot Nothing Then 'Make sure it exists.
                    cmbCautare.Items.Add(Value.ToString())
                End If
            Next
            cmbCautare.SelectedIndex = GetSetting(AppName, "Settings", "CautareInUtilizatoriCombo_selectedIndex", 0)


        Catch
        End Try
        cmbCautare.Select()
        If gstrSearch <> "" Then
            cmbCautare.Text = gstrSearch
            gstrSearch = ""
        End If


    End Sub
    Private Sub UpdateGrid(Optional search As String = "")
        Cursor = Cursors.WaitCursor
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        Dim searchString As String = ""
        Dim searchStringLog As String = ""
        If search.Length > 0 Then
            searchString = " Where Nume like '%" & search & "%' or  Email like '%" & search & "%' or  Telefon like '%" & search & "%' or  Alias like '%" & search & "%' "
            searchStringLog = " Where Sofer like '%" & search & "%'" & " Order by Data desc"

        End If
        Dim utilizatoriDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select * from Utilizatori" & searchString)
        Dim row As System.Data.DataRow
        For Each row In utilizatoriDataTable.Rows
            Dim arr(10) As Object
            arr(0) = row("Nume")
            arr(1) = row("Email")
            arr(2) = row("LimitaKm")
            arr(3) = row("FilialaId")
            arr(4) = row("Activ")
            arr(5) = row("Retinere")
            arr(6) = row("EmailConsolight")
            arr(7) = row("DeObiceiFolosesteMasina")
            arr(8) = row("Alias")
            arr(9) = row("Observatii")
            arr(10) = row("Telefon")
            DataGridView1.Rows.Add(arr)
        Next
        utilizatoriDataTable = ReturDataTableKmAuto("Select * from MasiniLog" & searchStringLog)

        For Each row In utilizatoriDataTable.Rows
            Dim arr(3) As Object
            arr(0) = row("Masina")
            arr(1) = row("Sofer")
            arr(2) = row("Data")
            arr(3) = row("SpreadsheetName")
            DataGridView2.Rows.Add(arr)
        Next

        Cursor = Cursors.Default

    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        Timer1.Enabled = True
    End Sub

    Private Sub cmdIesire_Click(sender As Object, e As EventArgs) Handles cmdIesire.Click
        Me.Close()
    End Sub

    Private Sub cmdAdaugare_Click(sender As Object, e As EventArgs) Handles cmdAdaugare.Click
        ModificaUtilizator(New DataGridViewRow, "Adaugare")
        DataGridView1.CurrentCell = DataGridView1(0, DataGridView1.Rows.Count - 1)
    End Sub



    Private Sub cmdSalvare_Click(sender As Object, e As EventArgs)
        'apeleaza evenimentul rowValidating al grid, dar pune primul parametru -1 pentru a putea sari peste messageBox cand vine din acest buton
        DataGridView1_RowValidating(DataGridView1, New DataGridViewCellCancelEventArgs(-1, DataGridView1.CurrentCell.RowIndex))
    End Sub
    Private Sub cmdStergeListaCautare_Click(sender As Object, e As EventArgs) Handles cmdStergeListaCautare.Click
        Dim result As DialogResult = MessageBox.Show("Stergeti lista de cautare?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            cmbCautare.Items.Clear()
            cmbCautare.Text = ""
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Enabled = False
        UpdateGrid(cmbCautare.Text)
        cmbCautare.Select(cmbCautare.Text.Length, 0)        'pune cursorul la final

    End Sub

    Private Sub cmdStergeCrt_Click(sender As Object, e As EventArgs) Handles cmdStergeCrt.Click
        cmbCautare.Items.Remove(cmbCautare.Text)
        Try
            cmbCautare.SelectedIndex = 0

        Catch

        End Try
    End Sub


    Private Sub cmdStergere_Click(sender As Object, e As EventArgs) Handles cmdStergere.Click
        Dim result As DialogResult = MessageBox.Show("Stergeti randul curent ?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            If Not DataGridView1.CurrentCell Is Nothing Then
                Dim crtRow As Integer = DataGridView1.CurrentCell.RowIndex
                Dim utilizator As String = DataGridView1.CurrentRow.Cells("Nume").Value
                Dim filiala As String = ReturExecutaSqlKmAuto("Select Nume from Filiale Where id = " & DataGridView1.CurrentRow.Cells("Filiala").Value)

                lbInfo.Text = ""
                'sterge si in baza de date
                Dim succes As String = ExecutaSQLKmAuto("Delete from Utilizatori Where Nume = '" & utilizator & "'")
                'sterge si in grid
                If succes = "Ok" Then
                    UpdateGrid()
                    Try
                        DataGridView1.CurrentCell = DataGridView1(0, crtRow)
                    Catch ex As System.Exception

                    End Try
                    'scoate si din foia Google
                    Dim gfh As New GoogleFormsHelper
                    Dim formId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets Where Filiala = '" & filiala & "' and Foaie = N'' and SheetId = N''")
                    Dim utilizatorDeSters As List(Of String) = New List(Of String) From {utilizator}
                    Dim res As String = gfh.DeleteOptionsFromChoiceItem(formId, "Utilizator", utilizatorDeSters)
                    succes = "Utilizatorul a fost sters cu succes."
                    If res = "Optiuni item sterse Ok." Then succes &= " (A fost scos si din Google. Utilizatorul nu mai poate introduce km.)"
                    MessageBox.Show(succes, "KmAuto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub





    Private Sub DataGridView1_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.RowValidating
    End Sub
    Private Function stergeInGoogleUtilizatori(utilizator As String) As String
        stergeInGoogleUtilizatori = "Eroare la stergere."
        Dim gsh As New GoogleSheetsHelper
        Dim SpreadsheetId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets Where Nume = '" & spreadsheetName & "' and activ = 'Da' and foaie = N'' and sheetid = N''")
        Dim sheetName As String = ReturExecutaSqlKmAuto("Select Foaie from Spreadsheets Where Nume = '" & spreadsheetName & "' and activ = 'Da' and foaie = N'' and sheetid = N''")
        Dim sheetId As String = ReturExecutaSqlKmAuto("Select SheetId from Spreadsheets Where Nume = '" & spreadsheetName & "' and activ = 'Da' and foaie = N'' and sheetid = N''")
        Dim myList As IList(Of IList(Of Object)) = gsh.GetRowsList(SpreadsheetId, sheetName)
        Dim k As Integer
        For k = 0 To myList.Count - 1
            If myList(k)(1).ToString = utilizator Then
                stergeInGoogleUtilizatori = gsh.DeleteRows(SpreadsheetId, sheetId, k, k + 1)
                Exit For
            End If
        Next


    End Function


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
        Dim crtRow As Integer = DataGridView1.CurrentCell.RowIndex
        ModificaUtilizator(DataGridView1.CurrentRow, "Modificare")
        DataGridView1.CurrentCell = DataGridView1(0, crtRow)
    End Sub
    Private Sub ModificaUtilizator(row As DataGridViewRow, operatie As String)
        If operatie = "Modificare" Then
            With util
                .DataInrolarii = DateTime.Now.ToOADate
                .Nume = row.Cells("Nume").Value
                .Email = row.Cells("Email").Value
                .LimitaKm = row.Cells("LimitaKm").Value
                .FilialaId = row.Cells("Filiala").Value
                .Activ = row.Cells("Activ").Value
                .Retinere = row.Cells("Retinere").Value
                .EmailConsolight = row.Cells("EmailConsolight").Value
                .DeObiceiFolosesteMasina = row.Cells("FolosesteDeObiceiMasinaInWeekend").Value
                .Alias_ = row.Cells("Alias_").Value
                .Observatii = row.Cells("Observatii").Value
                .Telefon = row.Cells("Telefon").Value
                .Operatie = operatie
            End With
        Else
            With util
                .DataInrolarii = DateTime.Now.ToOADate
                .Nume = ""
                .Email = ""
                .LimitaKm = ""
                .FilialaId = -1
                .Activ = ""
                .Retinere = ""
                .EmailConsolight = ""
                .DeObiceiFolosesteMasina = ""
                .Alias_ = ""
                .Observatii = ""
                .Telefon = ""
                .Operatie = operatie
            End With
        End If
        frmUtilizatoriChange.ShowDialog()
        frmUtilizatoriChange.Dispose()
        UpdateGrid()
    End Sub



    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        e.Cancel = True
    End Sub

    Private Sub cmdCautaTot_Click(sender As Object, e As EventArgs) Handles cmdCautaTot.Click
        cmbCautare.Text = ""
    End Sub

    Private Sub cmdRefreshCautareCurenta_Click(sender As Object, e As EventArgs) Handles cmdRefreshCautareCurenta.Click
        Timer3.Enabled = True
    End Sub


End Class