Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Office.Interop.Outlook
Imports Microsoft.Win32

Public Class frmMasini
    Private randuriGrid As Integer = 0
    Private randGridCurent As Integer = 0
    Private randDeSters As Integer = -1
    Private lstDataGrid As IList(Of Object)
    Private spreadsheetName = "Masini"
    Public mas As New Masini

    Private Sub frmMasini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            gstrSearch = DataGridView2.CurrentRow.Cells("Numar").Value
            gstrSearchSecond = DataGridView2.CurrentRow.Cells("Nume").Value

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

    Private Sub frmMasini_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)
        SaveSetting(AppName, "Settings", "CautareInMasiniCombo_selectedIndex", cmbCautare.SelectedIndex)

        Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInMasini\")
        For Each item As String In cmbCautare.Items
            Microsoft.Win32.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInMasini\", item, item)
        Next

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Try
            Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInMasini\")

            Dim CautareInMasiniCombo As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\VB and VBA Program Settings\KmAutoInterface\Settings\CautareInMasini")
            For Each ValueName As String In CautareInMasiniCombo.GetValueNames()
                Dim Value As Object = CautareInMasiniCombo.GetValue(ValueName) 'Get the value (data) of the specified value name.
                If Value IsNot Nothing Then 'Make sure it exists.
                    cmbCautare.Items.Add(Value.ToString())
                End If
            Next
            cmbCautare.SelectedIndex = GetSetting(AppName, "Settings", "CautareInMasiniCombo_selectedIndex", 0)


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
        DataGridView3.Rows.Clear()
        Dim searchString As String = ""
        Dim searchStringLog As String = ""
        If search.Length > 0 Then
            searchString = " Where Numar like '%" & search & "%'"
            searchStringLog = " Where Masina like '%" & search & "%'" & " Order by data desc"
        End If
        Dim masiniDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select * from Masini" & searchString)
        Dim row As System.Data.DataRow
        For Each row In masiniDataTable.Rows
            Dim arr(7) As Object
            arr(0) = row("Numar")
            arr(1) = row("Marca")
            arr(2) = row("Model")
            arr(3) = row("ConsumMediu")
            arr(4) = row("FilialaId")
            arr(5) = row("Carburant")
            arr(6) = row("Activ")
            arr(7) = row("Observatii")
            DataGridView1.Rows.Add(arr)
        Next
        Dim sql As String = "Select dbo.Masini.Numar, dbo.Masini.Marca, dbo.Masini.Model, dbo.Masini.ConsumMediu, dbo.Masini.FilialaId, dbo.Masini.Carburant, dbo.Masini.Activ, dbo.Masini.Observatii " &
                     "FROM dbo.Masini INNER JOIN " &
                     "dbo.Filiale ON dbo.Masini.FilialaId = dbo.Filiale.id " & searchString &
                     " " & If(search.Length > 0, "And", "Where") & " ((dbo.Filiale.Nume = N'HUB - Bucuresti') OR " &
                     "(dbo.Filiale.Nume = N'card limitat')) " &
                     "ORDER BY dbo.Filiale.Nume"
        sql = clearSql(sql)

        masiniDataTable = ReturDataTableKmAuto(sql)
        For Each row In masiniDataTable.Rows
            Dim arr(7) As Object
            arr(0) = row("Numar")
            arr(1) = row("Marca")
            arr(2) = row("Model")
            arr(3) = row("ConsumMediu")
            arr(4) = row("FilialaId")
            arr(5) = row("Carburant")
            arr(6) = row("Activ")
            arr(7) = row("Observatii")
            DataGridView3.Rows.Add(arr)
        Next
        masiniDataTable = ReturDataTableKmAuto("Select * from MasiniLog" & searchStringLog)

        For Each row In masiniDataTable.Rows
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
        ModificaMasina(New DataGridViewRow, "Adaugare")
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
                Dim masina As String = DataGridView1.CurrentRow.Cells("Numar").Value
                Dim filiala As String = ReturExecutaSqlKmAuto("Select Nume from Filiale Where id = " & DataGridView1.CurrentRow.Cells("Filiala").Value)
                lbInfo.Text = ""
                'sterge in baza de date
                Dim succes As String = ExecutaSQLKmAuto("Delete from Masini Where Numar = '" & masina & "'")
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
                    Dim masiniDeSters As List(Of String) = New List(Of String) From {masina}
                    Dim res As String = gfh.DeleteOptionsFromChoiceItem(formId, "Masina", masiniDeSters)
                    succes = "Masina a fost stearsa cu succes."
                    If res = "Optiuni item sterse Ok." Then succes &= " (A fost scoasa si din Google. Utilizatorii nu mai pot introduce km.)"
                    MessageBox.Show(succes, "KmAuto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
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
        ModificaMasina(DataGridView1.CurrentRow, "Modificare")

    End Sub
    Private Sub ModificaMasina(row As DataGridViewRow, operatie As String)
        If operatie = "Modificare" Then
            With mas
                .DataInrolarii = DateTime.Now.ToOADate
                .Numar = row.Cells("Numar").Value
                .Marca = row.Cells("Marca").Value
                .Model = row.Cells("Model").Value
                .FilialaId = row.Cells("Filiala").Value
                .Activ = row.Cells("Activ").Value
                .ConsumMediu = row.Cells("ConsumMediu").Value
                .Carburant = row.Cells("Carburant").Value
                .Activ = row.Cells("Activ").Value
                .Observatii = row.Cells("Observatii").Value
                .Operatie = operatie
            End With
        Else
            With mas
                .DataInrolarii = DateTime.Now.ToOADate
                .Numar = ""
                .Marca = ""
                .Model = ""
                .FilialaId = -1
                .Activ = ""
                .ConsumMediu = ""
                .Carburant = ""
                .Activ = ""
                .Observatii = ""
                .Operatie = operatie
            End With
        End If
        frmMasiniChange.ShowDialog()
        frmMasiniChange.Dispose()
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