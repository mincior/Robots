Imports System.ComponentModel
Imports System.Threading
Imports Microsoft.Office.Interop

Public Class frmBulk
    Private intervaleDataTable As System.Data.DataTable = ReturDataTableKmAuto("select * from intervale Where DataRaportarii = '" & gstrDataRaportarii & "' order by dataInceput")
    Private Sub frmBulk_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'KmAutoDataSet.Spreadsheets' table. You can move, or remove it, as needed.
        Me.SpreadsheetsTableAdapter.Fill(Me.KmAutoDataSet.Spreadsheets)
        IncarcaDimensiuniSiPozitie(Me, 691, 264, 613, 934)
        For Each row As System.Data.DataRow In intervaleDataTable.Rows
            cklIntervale.Items.Add(row("Interval"))
        Next


        txtCautareMasina.BackColor = System.Drawing.Color.Red
        txtCautareUtilizator.BackColor = System.Drawing.Color.Red
        cmbSpreadsheets1.SelectedIndex = -1
        incarca()
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

    Private Sub frmBulk_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)
        salveaza()

    End Sub
    Private Sub cmdIesire_Click(sender As Object, e As EventArgs) Handles cmdIesire.Click
        Me.Close()
    End Sub
    Private Sub incarcaMasiniSiUtilizatoriPentruAdaugareBulk()
        Dim utilizatoriDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select Nume from Utilizatori order by Nume")
        For Each row As System.Data.DataRow In utilizatoriDataTable.Rows
            cmbUtilizatori.Items.Add(row("Nume"))
        Next
        Dim masiniDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select Numar from Masini Order by Numar")
        For Each row As System.Data.DataRow In masiniDataTable.Rows
            cmbMasini.Items.Add(row("Numar"))
        Next
    End Sub
    Private Sub txtCautareMasina_TextChanged(sender As Object, e As EventArgs) Handles txtCautareMasina.TextChanged
        cautareMasina(txtCautareMasina.Text)
    End Sub

    Private Sub cautareMasina(numar As String)
        txtCautareMasina.BackColor = System.Drawing.Color.Red
        txtCautareMasina.ForeColor = System.Drawing.Color.Yellow
        If numar <> "" Then
            For Each item As String In cmbMasini.Items
                If item.Contains(numar) Then
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
        Else
            cmbMasini.SelectedIndex = -1
            cmbSpreadsheets1.SelectedIndex = -1
        End If

    End Sub
    Private Sub txtCautareUtilizator_TextChanged(sender As Object, e As EventArgs) Handles txtCautareUtilizator.TextChanged
        cautareUtilizator(txtCautareUtilizator.Text)
    End Sub
    Private Sub cautareUtilizator(nume As String)
        txtCautareUtilizator.BackColor = System.Drawing.Color.Red
        txtCautareUtilizator.ForeColor = System.Drawing.Color.Yellow
        If nume <> "" Then
            For Each item As String In cmbUtilizatori.Items
                If LCase(item).Contains(LCase(nume)) Then
                    cmbUtilizatori.SelectedItem = item
                    txtCautareUtilizator.BackColor = System.Drawing.Color.Green
                    txtCautareUtilizator.ForeColor = System.Drawing.Color.White
                    Exit For
                End If
            Next
        Else
            cmbUtilizatori.SelectedIndex = -1
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        incarcaMasiniSiUtilizatoriPentruAdaugareBulk()
        IncarcaSheets()
        Try
            txtCautareMasina.Text = gstrSearch
        Catch ex As System.Exception

        End Try
        Try
            txtCautareUtilizator.Text = gstrSearchSecond
        Catch ex As Exception

        End Try
        gstrSearch = ""
        gstrSearchSecond = ""

    End Sub

    Private Sub cmdToateIntervalele_Click(sender As Object, e As EventArgs) Handles cmdToateIntervalele.Click
        Dim k As Long
        For k = 0 To cklIntervale.Items.Count - 1
            cklIntervale.SetItemChecked(k, True)
        Next
        Timer2.Enabled = True

    End Sub

    Private Sub cmbNiciunul_Click(sender As Object, e As EventArgs) Handles cmbNiciunul.Click
        Dim k As Long
        For k = 0 To cklIntervale.Items.Count - 1
            cklIntervale.SetItemChecked(k, False)
        Next
        Timer2.Enabled = True

    End Sub

    Private Sub cmbMasini_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMasini.SelectedIndexChanged
        txtCautareUtilizator.Text = ReturExecutaSqlKmAuto("Select top (1) Sofer from MasiniLog Where Masina = '" & cmbMasini.Text & "' order by Data Desc")
    End Sub

    Private Sub cmdStergere_Click(sender As Object, e As EventArgs) Handles cmdStergere.Click
        Dim result As DialogResult = MessageBox.Show("Se va sterge inregistrarea curenta. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        If result = DialogResult.Yes Then
            Try
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)

            Catch ex As Exception

            End Try
        End If
        Timer2.Enabled = True
    End Sub

    Private Sub cmdAdaugare_Click(sender As Object, e As EventArgs) Handles cmdAdaugare.Click
        updateGrid()
    End Sub
    Private Sub updateGrid()
        Dim myList(4) As Object, s As String = "", k As Long = 0
        For Each item In cklIntervale.CheckedItems
            s &= item & "; "
        Next
        s = Strings.Left(s, s.Length - 2)
        If s = "" Then
            MessageBox.Show("Selectati cel putin un interval.")
            Exit Sub
        End If
        myList(0) = cmbUtilizatori.Text
        myList(1) = cmbMasini.Text
        myList(2) = s
        myList(3) = cmbSpreadsheets1.Text
        myList(4) = cmbSpreadsheets1.SelectedValue
        If exista(myList(0), myList(1)) = False Then
            If cmbUtilizatori.Text <> "" And cmbMasini.Text <> "" Then
                DataGridView1.Rows.Add(myList)
            Else
                MessageBox.Show("Utilizator sau masina negasite")
            End If
        Else
            MessageBox.Show("Exista deja inregistrarea aceasta")
        End If
        Timer2.Enabled = True
    End Sub
    Private Function exista(utilizator As String, masina As String) As Boolean
        exista = False
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("Numar").Value = masina And row.Cells("Nume").Value = utilizator Then
                exista = True
                Exit Function
            End If
        Next
    End Function
    Private Sub txtCautareMasina_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCautareMasina.KeyUp
        If e.KeyValue = 13 Then
            txtCautareUtilizator.Select()
        End If
    End Sub

    Private Sub txtCautareUtilizator_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCautareUtilizator.KeyUp
        If e.KeyValue = 13 Then
            updateGrid()
        End If

    End Sub

    Private Sub cmdStergeTot_Click(sender As Object, e As EventArgs) Handles cmdStergeTot.Click
        Dim result As DialogResult = MessageBox.Show("Se va sterge tot continutul tabelului. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        If result = DialogResult.Yes Then
            DataGridView1.Rows.Clear()
        End If
        Timer2.Enabled = True

    End Sub

    Private Sub cmdSalveaza_Click(sender As Object, e As EventArgs)
        salveaza()
    End Sub
    Private Sub salveaza()
        Dim res As String = ExecutaSQLKmAuto("Delete from kmlogBulk")
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim sql As String = "Insert into kmlogBulk (Nume, Numar, Intervale, Spreadsheet, SpreadsheetId, Succes) values ('" & row.Cells("Nume").Value & "', '" & row.Cells("Numar").Value & "', '" & row.Cells("Intervale").Value & "' , '" & row.Cells("Spreadsheet").Value & "', '" & row.Cells("SpreadsheetId").Value & "', '" & row.Cells("Succes").Value & "');"
            res = ExecutaSQLKmAuto(sql)
            lbInfo.Text = res
        Next
        Timer2.Enabled = True

    End Sub
    Private Sub incarca()
        Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select * from kmlogBulk")
        For Each row As DataRow In myDataTable.Rows
            Dim myList(5) As Object, k As Long = 0
            myList = row.ItemArray
            DataGridView1.Rows.Add(myList)
        Next
        Timer2.Enabled = True

    End Sub

    Private Sub cklIntervale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cklIntervale.SelectedIndexChanged
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        txtCautareMasina.Select()
        txtCautareMasina.SelectAll()

    End Sub

    Private Sub cmdExecuta_Click(sender As Object, e As EventArgs) Handles cmdExecuta.Click
        Dim result As DialogResult = MessageBox.Show("Se vor adauga doua inregistrari nule in tabelul Google pentru fiecare interval si fiecare rand din tabel.Prima cu status Referinta si a doua cu status Normal dar km = -1 pentru ambele. . Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            DataGridView2.Rows.Clear()
            DataGridView1.Sort(DataGridView1.Columns(4), System.ComponentModel.ListSortDirection.Ascending)
            Dim memSpreadsheetId As String = ""
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("Succes").Value <> "Da" Then
                    'va sparge si itera intervalele din campul interval si pentru fiecare dintre ele va identifica tipul operatiei ce trebuie facuta:
                    '1. Daca nu exista nici o inregistrare in interval va pune doua inregistrari cu index null si asumat = Da
                    '2. Daca exista o inregistrare va pune complementul ei cu acelasi index si cu status complementar

                    'incarca toata foaia google in tabelul temporar GoogleSheet pentru a putea face filtre sql pe el si a afla daca se poate aplica 
                    'o operatie pe randul curent din grid
                    If memSpreadsheetId <> row.Cells("SpreadsheetId").Value Then 'inregistrarile sunt sortate dupa SpreadsheetId.
                        'Aici detecteaza daca s-a schimbat foaia Google pentru a o incarca pe urmatoarea
                        Dim gsh As New GoogleSheetsHelper
                        Dim sheetName As String = ReturExecutaSqlKmAuto("Select Foaie from Spreadsheets Where SpreadsheetId = '" & row.Cells("SpreadsheetId").Value & "';")
                        Dim myList As IList(Of IList(Of Object)) = gsh.GetRowsList(row.Cells("SpreadsheetId").Value, sheetName)
                        Dim ss As String = ExecutaSQLKmAuto("Delete from GoogleSheet"), prima As Boolean = False
                        For Each ilst As IList(Of Object) In myList 'itereaza fiecare rand din foia google
                            If prima = False Then 'sare peste capul de tabel
                                prima = True
                                Continue For
                            End If
                            If ilst.Count < 12 Then 'daca ultimele campuri sunt nule, ilist(k) va avea o dimensiune mai mica de 12.
                                'Aici se asigura ca intotdeauna ilist(k) va avea 12 locatii (0-11)
                                For i As Long = ilst.Count To 12
                                    ilst.Add("")
                                Next
                            End If
                            Dim sql As String
                            If ilst(6) = "" Then 'daca DataSiOraCitirii este nula
                                sql = "Insert into GoogleSheet ( Timestamp, Masina, Utilizator,  Km, Status, PozaDinBord, EmailAddress, Asumat, Observatii, KmModificat, StatusModificat ) values ( '" & ilst(0) & "', '" & ilst(1) & "', '" & ilst(2) & "', '" & ilst(3) & "', '" & ilst(4) & "', '" & ilst(5) & "', '" & ilst(7) & "', '" & ilst(8) & "', '" & ilst(9) & "', '" & ilst(10) & "', '" & ilst(11) & "' );"

                            Else 'daca nu este nula o pune in locul Timestamp si invers (pentru a putea face cautari sql pe un singur camp, nu pe doua)
                                sql = "Insert into GoogleSheet ( Timestamp, Masina, Utilizator, Km, Status, PozaDinBord, DataSiOraCitirii, EmailAddress, Asumat, Observatii, KmModificat, StatusModificat ) values ( '" & ilst(6) & "', '" & ilst(1) & "', '" & ilst(2) & "', '" & ilst(3) & "', '" & ilst(4) & "', '" & ilst(5) & "', '" & ilst(0) & "', '" & ilst(7) & "', '" & ilst(8) & "', '" & ilst(9) & "', '" & ilst(10) & "', '" & ilst(11) & "' );"
                            End If
                            ss = ExecutaSQLKmAuto(sql) 'scrie in GoogleSheet din baza de date inregistrarea curenta din foaia google
                        Next
                    End If
                    memSpreadsheetId = row.Cells("SpreadsheetId").Value 'memoreaza spreadsheetId pentru a detecta mai sus schimbarea acestuia
                    Dim s As String = row.Cells("Intervale").Value, v() As String = {}, k As Long = 0, succes As Boolean
                    ReDim v(0)
                    If s.Contains("; ") = True Then 'spliteaza intervale dupa '; ' 
                        v = Split(s, "; ")
                    Else 'e un singur element si-l pune in v(0)
                        v(0) = s
                    End If

                    'in v() avem fiecare interval 
                    succes = True
                    For k = 0 To UBound(v)
                        'obtine data de inceput si cea finala pornind de la interval (exemplu de interval: 29.11-05.12)
                        Dim dataInceput As Date = GetDatesFromInterval(v(k))(0)
                        Dim dataFinala As Date = GetDatesFromInterval(v(k))(2)

                        'adauga la data finala 23 ore si 59 minute pentru a lua si ziua finala
                        dataFinala = DateAdd("h", 23, dataFinala)
                        dataFinala = DateAdd("n", 59, dataFinala)
                        'cauta in tabelul proaspat completat doar inregistrarile din intervalul curent
                        Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select * from GoogleSheet Where Timestamp >='" & dataInceput & "' and Timestamp <= '" & dataFinala & "' and Masina = '" & row.Cells("Numar").Value & "' and Utilizator ='" & row.Cells("Nume").Value & "';")
                        If myDataTable.Rows.Count = 0 Then 'aplica weekend nul
                            Dim ret As String = AdaugaWeekendNul(v(k), row.Cells("Spreadsheet").Value, row.Cells("Nume").Value, row.Cells("Numar").Value, "Asumat weekend nul", DataGridView2)
                            If ret <> "Adaugare Ok" Then
                                succes = False
                            End If

                        ElseIf myDataTable.Rows.Count = 1 Then 'aplica inegistrare complementara
                            'daca exista un status modificat il ia pe acela, daca nu pe status-ul original
                            Dim myDataRow As DataRow = myDataTable.Rows(0)
                            Dim status As String = If(myDataRow("StatusModificat") <> "", myDataRow("StatusModificat"), myDataRow("Status"))
                            'inverseaza Referinta cu Normal. Daca nu, lasa asa cum era (Ex. Plecare in concediu)
                            status = If(status = "Referinta", "Normal", If(status = "Normal", "Referinta", status))
                            Dim km As String = If(myDataRow("KmModificat") <> "", myDataRow("KmModificat"), myDataRow("Km"))
                            Dim data As Date = myDataRow("Timestamp"), observatii As String = ""
                            Dim gsh As New GoogleSheetsHelper
                            Dim spreadsheetId As String = row.Cells("SpreadsheetId").Value
                            Dim sheetId As String = ReturExecutaSqlKmAuto("Select SheetId from Spreadsheets where SpreadsheetId = '" & spreadsheetId & "';")
                            gsh.RemoveFilter(spreadsheetId, sheetId)
                            wait(3000)
                            observatii = "Asumat rand complementar"
                            Dim ret As String = AdaugaRandInGoogle(data, km, status, row.Cells("Spreadsheet").Value, row.Cells("Nume").Value, row.Cells("Numar").Value, observatii, DataGridView2)
                            If ret <> "Salvat cu succes" Then
                                succes = False
                            End If

                        Else 'nu face nimic - nu are ce. Sau vedem in viitor.

                        End If
                    Next
                    If succes = True Then
                        Dim res As String = ExecutaSQLKmAuto("Update KmLogBulk SET Succes = N'Da' Where Numar =N'' and Nume =N'' and Intervale =N'';")
                        If res = "Ok" Then
                            row.Cells("Succes").Value = "Da"
                        End If
                    Else
                        Dim res As String = ExecutaSQLKmAuto("Update KmLogBulk SET Succes = N'Nu' Where Numar =N'' and Nume =N'' and Intervale =N'';")
                        If res = "Ok" Then
                            row.Cells("Succes").Value = "Nu"
                        End If

                    End If
                End If
            Next
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cmdDeschideProcesator_Click(sender As Object, e As EventArgs) Handles cmdDeschideProcesator.Click
        System.Diagnostics.Process.Start("excel.exe", AppPath & "output\procesator.xlsm")

    End Sub

    Private Sub cmdDeschideRaportCurent_Click(sender As Object, e As EventArgs) Handles cmdDeschideRaportCurent.Click
        System.Diagnostics.Process.Start("excel.exe", """" & AppPath & "output\" & gstrDataRaportarii & "\KmAuto - " & gstrDataRaportarii & ".xlsm""")

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        If DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Name = "SpreadsheetId" Then
            Dim spreadsheetId As String = DataGridView1.CurrentCell.Value
            Dim url As String = "https://docs.google.com/spreadsheets/d/" & spreadsheetId
            If tabExists(url).Length > 0 Then
            Else
                Process.Start(url)
            End If

        End If

    End Sub

    Private Sub cmdMasini_Click(sender As Object, e As EventArgs) Handles cmdMasini.Click
        Try
            gstrSearch = DataGridView2.CurrentRow.Cells("Numar").Value

        Catch ex As System.Exception

        End Try
        frmMasini.ShowDialog()
        frmMasini.Dispose()
    End Sub

    Private Sub cmdUtilizatori_Click(sender As Object, e As EventArgs) Handles cmdUtilizatori.Click
        Try
            gstrSearch = DataGridView2.CurrentRow.Cells("NumeUtilizator").Value

        Catch ex As System.Exception

        End Try
        frmUtilizatori.ShowDialog()
        frmUtilizatori.Dispose()

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

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        cmbMasini.Text = DataGridView1.CurrentRow.Cells("Numar").Value
        cmbUtilizatori.Text = DataGridView1.CurrentRow.Cells("Nume").Value

    End Sub
End Class