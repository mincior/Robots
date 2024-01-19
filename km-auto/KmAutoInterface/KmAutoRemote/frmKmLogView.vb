Imports System.ComponentModel
Imports Microsoft.Office.Interop.Outlook
Imports Microsoft.Win32

Public Class frmKmLogView
    Private Sub frmKmLogView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 982, 879)

    End Sub

    Private Sub frmKmLogView_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        SalveazaDimensiuniSiPozitie(Me)
        Try
            Registry.CurrentUser.DeleteSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInKmLog\")

        Catch

        End Try
        SaveSetting(AppName, "Settings", "CautareInKmLogCombo_selectedIndex", cmbCautare.SelectedIndex)

        Registry.CurrentUser.CreateSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInKmLog\")
        For Each item As String In cmbCautare.Items
            Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInKmLog\", item, item)
        Next

    End Sub

    Private Sub updateGrid(Optional search As String = "")
        Me.Cursor = Cursors.WaitCursor
        DataGridView1.Rows.Clear()
        Dim d As Date = DateAdd("m", -2, frmPrincipal.dtpDataRaportarii.Value)
        Dim v() As String = Split(search, ";")
        Dim searchWord As String
        If search = "" Then
            searchWord = ""
        ElseIf UBound(v) > 0 Then
            For i As Long = 0 To UBound(v)
                searchWord &= If(search.Length > 0, " AND (dbo.Filiale.Nume LIKE '%" & Trim(v(i)) & "%' OR dbo.Utilizatori.Nume LIKE '%" & Trim(v(i)) & "%' OR dbo.Masini.Numar LIKE '%" & Trim(v(i)) & "%' )", "")
            Next
        Else
            searchWord &= If(search.Length > 0, " AND (dbo.Filiale.Nume LIKE '%" & Trim(search) & "%' OR dbo.Utilizatori.Nume LIKE '%" & Trim(search) & "%' OR dbo.Masini.Numar LIKE '%" & Trim(search) & "%' )", "")

        End If
        Dim myDataTable As DataTable = ReturDataTable(kmAutoCmd, "SELECT dbo.KmLog.Data, dbo.Filiale.Nume AS Filiala, dbo.Utilizatori.Nume AS Utilizator, dbo.Masini.Numar, dbo.KmLog.Km, dbo.KmLog.PozaDinBord, dbo.KmLog.Status, dbo.Spreadsheets.Nume AS Spreadsheet, " &
                         "dbo.KmLog.DataSiOraCitirii From " &
                         "dbo.Utilizatori INNER JOIN " &
                         "dbo.KmLog ON dbo.Utilizatori.Id = dbo.KmLog.UtilizatorId INNER JOIN " &
                         "dbo.Filiale ON dbo.Utilizatori.FilialaId = dbo.Filiale.id INNER JOIN " &
                         "dbo.Masini ON dbo.KmLog.MasinaId = dbo.Masini.Id INNER JOIN " &
                         "dbo.Spreadsheets ON dbo.KmLog.Spreadsheets_id = dbo.Spreadsheets.Id  Where dbo.KmLog.Data >= '" & d & "'" & searchWord & " Order By Filiala, Utilizator, Numar, Data desc")
        If Not myDataTable Is Nothing Then
            'scrie gridul asa cum e (cu id-uri pentru utilizatori si greseli)
            For Each row As DataRow In myDataTable.Rows
                Dim inputData(8) As String
                inputData(0) = CType(row("Data"), Date).ToString("yyyy-MM-dd HH:mm:ss")
                inputData(1) = row("Filiala")
                inputData(2) = row("Utilizator")
                inputData(3) = row("Numar")
                inputData(4) = row("Km")
                inputData(5) = row("PozaDinBord")
                inputData(6) = row("Status")
                inputData(7) = row("Spreadsheet")
                inputData(8) = row("DataSiOraCitirii")
                DataGridView1.Rows.Add(inputData)
            Next
        End If
        Me.Cursor = Cursors.Default

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        'TODO: This line of code loads data into the 'KmAutoDataSet.KmLog' table. You can move, or remove it, as needed.

        Try
            Registry.CurrentUser.CreateSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInKmLog\")

            Dim CautareInKmLogCombo As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\VB and VBA Program Settings\KmAutoInterface\Settings\CautareInKmLog")
            For Each ValueName As String In CautareInKmLogCombo.GetValueNames()
                Dim Value As Object = CautareInKmLogCombo.GetValue(ValueName) 'Get the value (data) of the specified value name.
                If Value IsNot Nothing Then 'Make sure it exists.
                    cmbCautare.Items.Add(Value.ToString())
                End If
            Next
            cmbCautare.SelectedIndex = GetSetting(AppName, "Settings", "CautareInKmLogCombo_selectedIndex", 0)


        Catch

        End Try
        updateGrid(cmbCautare.Text)
        cmbCautare.Select()

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
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If cmbCautare.Text = "" Then
            cmbCautare.BackColor = SystemColors.Window
        Else
            cmbCautare.BackColor = Color.Yellow

        End If
        cmdStergeListaCautare.Enabled = cmbCautare.Items.Count
        cmdStergeCrt.Enabled = cmbCautare.Items.Count

    End Sub


    Private Sub DataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        'Timer1.Enabled = True
    End Sub



    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = 7 Then
            Dim url As String = DataGridView1.CurrentCell.Value
            Process.Start(url)
            Me.Text = url


        End If

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
        updateGrid(cmbCautare.Text)
        cmbCautare.Select(cmbCautare.Text.Length, 0)        'pune cursorul la final

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
        If e.ColumnIndex = 5 Then
            Dim url As String = row.Cells.Item("PozaDinBord").Value
            Dim formP As New frmPoza

            formP.WebBrowser1.Url = New Uri(url)
            formP.ShowDialog()
        End If
    End Sub


End Class