Imports System.ComponentModel
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports KmAutoInterface.KmAutoDataSetTableAdapters
Imports Microsoft.Win32

Public Class frmGreseliLog
    Dim x, x1, y As Integer
    Dim newpoint As New Point
    Dim newpoint1 As New Point
    Private Sub frmGreseliLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 795, 834)
        Dim x As Long = GetSetting(AppName, "Settings", Me.Name & "_resizePicture", PictureBox1.Location.X)
        Dim y As Long = PictureBox1.Location.Y
        Dim pointt As New Point
        pointt.X = x
        pointt.Y = y
        PictureBox1.Location = pointt

        DataGridView1.Width = PictureBox1.Location.X - DataGridView1.Location.X - 3
        pointt.X = x + 10
        pointt.Y = DataGridView2.Location.Y
        DataGridView2.Location = pointt

        pointt.Y = DataGridView3.Location.Y
        DataGridView3.Location = pointt
        DataGridView2.Width = Me.Width - DataGridView1.Width - PictureBox1.Width - 45
        DataGridView3.Width = DataGridView2.Width



    End Sub
    Private Sub checkBoxes_MouseUp(sender As Object, e As EventArgs) Handles checkOSinguraInregistrare.MouseUp, checkKmPreaMulti.MouseUp, checkIndexeInversate.MouseUp, checkPrimaInregistrareNuEReferinta.MouseUp, checkToateInregistrarileSuntReferinta.MouseUp, checkDouaInregistrariAdiacenteReferinta.MouseUp, checkToateInregistrarileSuntReferinta.MouseUp, checkZeroInregistrari.MouseUp, checkToateInregistrarileSuntInteresServiciu.MouseUp, checkCompletareInutilaADateiDeIntroducere.MouseUp
        SaveSetting(AppName, "Settings", "checkBoxes" & sender.name, sender.checked)
        UpdateGrid(cmbCautare.Text)
    End Sub
    Private Sub UpdateGrid(Optional search As String = "")
        DataGridView3.Rows.Clear()
        Dim greseli As String = "("
        'incarca checkbox-urile cu greseli
        GetAllControls(Me, GetType(CheckBox)).ToList.ForEach(
           Sub(c As CheckBox)
               If Strings.Left(c.Name, 5) = "check" Then
                   If c.Checked = True Then
                       greseli &= c.Tag & ", "

                   End If
               End If
           End Sub)
        DataGridView1.Rows.Clear() 'UNBOUD DATAGRID
        If greseli <> "(" Then
            greseli = Strings.Left(greseli, Len(greseli) - 2) & ")"

        End If
        Me.Text = greseli
        'mai jos vom gasi in alt tabel un nume sau tip dupa id. Atentie, ambele campuri retunate(adica value) sunt 'Id' si nu UtilizatorId sau GresealaId

        Dim intervalComplet As String = cmbIntervale.Text
        Dim dataInceput As String = Split(ReturDataTable(kmAutoCmd, "Select distinct IntervalComplet from GreseliLog where Interval ='" & cmbIntervale.Items(0) & "'").Rows(0)(0), ":")(0)

        If intervalComplet <> "Toate" Then
            intervalComplet = ReturDataTable(kmAutoCmd, "Select distinct IntervalComplet from GreseliLog where Interval ='" & cmbIntervale.Text & "'").Rows(0)(0)
        End If

        'pregateste search splitat dupa ;
        'ex: constanta;mihai va face un OR intre 'Like'-urile pe 3 campuri pe constanta si apoi un and cu un OR intre 'Like'-urile pe 3 campuri pe mihai
        'ex: constanta;mihai;123 va face acelasi lucru dar pe 3 grupe, samd pe oricate grupe
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
        Dim myDataTable As DataTable = ReturDataTable(kmAutoCmd, "SELECT GreseliLog.id, dbo.Filiale.Nume AS Filiala, dbo.Utilizatori.Nume AS Utilizator,  " &
                         "GreseliLog.Interval, dbo.Greseli.Tip, dbo.Masini.Numar,  GreseliLog.IntervalComplet " &
                         "From dbo.Filiale INNER Join " &
                         "dbo.Utilizatori ON dbo.Filiale.id = dbo.Utilizatori.FilialaId INNER Join " &
                         "dbo.GreseliLog ON dbo.Utilizatori.Id =  GreseliLog.UtilizatorId INNER Join " &
                         "dbo.Masini ON  GreseliLog.MasinaId = dbo.Masini.Id INNER Join " &
                         "dbo.Greseli ON  GreseliLog.GresealaId = dbo.Greseli.Id Where GresealaId IN " & greseli & If(intervalComplet <> "Toate", " And IntervalComplet = '" & intervalComplet & "'", "") & searchWord & " Order By Filiala, Utilizator, dbo.GreseliLog.IntervalComplet, dbo.GreseliLog.GresealaId")
        Dim dictGreseliPeUtilizatori As New Dictionary(Of String, Dictionary(Of String, Long))
        Dim dictTemp As Dictionary(Of String, Long)
        Dim dictGreseli As New Dictionary(Of String, Long)
        'sterge toate label-urile
        stergeToateLabelurile(Me, "T")
        stergeToateLabelurile(Me, "U")

        If Not myDataTable Is Nothing Then
            'scrie gridul asa cum e (cu id-uri pentru utilizatori si greseli)
            For Each row As DataRow In myDataTable.Rows
                'identifica daca randul are inregistrari introduse pe interval, pe alt utilizator pentru a nu-l mai scrie In grid, daca tipul de greseala este Zero inregistrari
                Dim inputData(6) As String
                inputData(0) = row("Id")
                'Dim filialaId As String = ReturDataTable("Select FilialaId from Utilizatori where id ='" & row("UtilizatorId") & "'").Rows(0)(0)
                'Dim filiala As String = ReturDataTable("Select Nume from Filiale where id ='" & filialaId & "'").Rows(0)(0)
                inputData(1) = row("Filiala")
                inputData(2) = row("Utilizator")
                inputData(3) = row("Interval")
                inputData(4) = row("Tip")
                inputData(5) = row("Numar")
                inputData(6) = row("IntervalComplet")
                Dim masinaId As String = ReturDataTable(kmAutoCmd, "Select Id from Masini where Numar = '" & row("Numar") & "'").Rows(0)(0)
                Dim utilizatorId As String = ReturDataTable(kmAutoCmd, "Select Id from Utilizatori where Nume = '" & row("Utilizator") & "'").Rows(0)(0)
                'elimina randurile daca tipul de greseala este 'Zero inregistrari' si mai exista un utilizator care a introdus date in acelasi interval
                'If numeUtilizator = "Andrei Rus" And numarMasina = "B-156-CLT" And row("Interval") = "23 - 26.09" Then Stop
                Dim intervalePeMasinaDataTable As DataTable = ReturDataTable(kmAutoCmd, "Select Data, MasinaId, UtilizatorId, Km, Status, Spreadsheets_id from KmLog Where MasinaId = " & masinaId & " and UtilizatorId <> " & utilizatorId & ReturQueryInterval(row("IntervalComplet")) & "ORDER By MasinaId, Data;")
                If Not intervalePeMasinaDataTable Is Nothing AndAlso intervalePeMasinaDataTable.Rows.Count > 0 AndAlso row("Tip") = "Zero inregistrari" Then
                    'Stop
                Else
                    'acum cauta daca alt utilizator a introdus date de la inceputul lunii pe aceeasi masina. Daca da, nu va mai lua in seama
                    'si va transmite email-uri corespunzatoare pentru a informa ambii soferi ca nu au introdus nici unul kilometrii
                    intervalePeMasinaDataTable = ReturDataTable(kmAutoCmd, "Select Data, MasinaId, UtilizatorId, Km, Status, Spreadsheets_id from KmLog Where MasinaId = " & masinaId & " and UtilizatorId <> " & utilizatorId & ReturQueryInterval(row("IntervalComplet"), dataInceput) & "ORDER By MasinaId, Data;")
                    If Not intervalePeMasinaDataTable Is Nothing AndAlso intervalePeMasinaDataTable.Rows.Count > 0 AndAlso row("Tip") = "Zero inregistrari" Then
                    Else
                        DataGridView1.Rows.Add(inputData)

                    End If

                End If
            Next

            For Each row As DataGridViewRow In DataGridView1.Rows
                'memoreaza id-urile
                Dim masinaId As String = ReturDataTable(kmAutoCmd, "Select Id from Masini where Numar = '" & row.Cells("Numar").Value & "'").Rows(0)(0)
                Dim utilizatorId As String = ReturDataTable(kmAutoCmd, "Select Id from Utilizatori where Nume = '" & row.Cells("Utilizator_").Value & "'").Rows(0)(0)
                'Dim gresealaId As Long = row.Cells("GresealaId").Value

                'contorizeaza numarul de utilizatori pe greseala (se va lua count)
                If dictGreseliPeUtilizatori.ContainsKey(row.Cells("Tip").Value) = False Then 'greseala nu exista in dictionarul cu greseli
                    'contorizeaza numarul de utilizatori pe greseli
                    dictTemp = New Dictionary(Of String, Long)
                    dictTemp.Add(row.Cells("Utilizator_").Value, 1)
                    dictGreseliPeUtilizatori.Add(row.Cells("Tip").Value, dictTemp)
                Else
                    If dictGreseliPeUtilizatori(row.Cells("Tip").Value).ContainsKey(row.Cells("Utilizator_").Value) = False Then
                        dictGreseliPeUtilizatori(row.Cells("Tip").Value).Add(row.Cells("Utilizator_").Value, 1)
                    Else
                        dictGreseliPeUtilizatori(row.Cells("Tip").Value)(row.Cells("Utilizator_").Value) += 1
                    End If
                End If


                'greselile totale
                If dictGreseli.ContainsKey(row.Cells("Tip").Value) = False Then
                    dictGreseli.Add(row.Cells("Tip").Value, 1)
                Else
                    dictGreseli(row.Cells("Tip").Value) += 1
                End If

            Next

            'scrie greselile in label-uri
            getNumarGreseli(Me, "T", dictGreseli, dictGreseliPeUtilizatori) 'greseli totale
            getNumarGreseli(Me, "U", dictGreseli, dictGreseliPeUtilizatori) 'greseli pe utilizator

        End If
        LabelNumarInregistrariSt.Text = DataGridView1.Rows.Count
        Try
            refreshGrid1(DataGridView1.Rows(0))

        Catch ex As Exception

        End Try
        cmbCautare.Select(cmbCautare.Text.Length, 0)        'pune cursorul la final
    End Sub


    Private Sub frmGreseliLog_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)
        Try
            Registry.CurrentUser.DeleteSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInGreseliCombo\")

        Catch ex As Exception

        End Try
        SaveSetting(AppName, "Settings", "CautareInGreseliLogCombo_selectedIndex", cmbCautare.SelectedIndex)
        Registry.CurrentUser.CreateSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInGreseliCombo\")
        For Each item As String In cmbCautare.Items
            Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInGreseliCombo\", item, item)
        Next

    End Sub



    Private Sub cmdSelecteazaTot_Click(sender As Object, e As EventArgs) Handles cmdSelecteazaTot.Click
        GetAllControls(Me, GetType(CheckBox)).ToList.ForEach(
           Sub(c As CheckBox)
               If Strings.Left(c.Name, 5) = "check" Then
                   c.Checked = True
                   SaveSetting(AppName, "Settings", "checkBoxes" & c.Name, c.Checked)

               End If
           End Sub)
        UpdateGrid(cmbCautare.Text)


    End Sub

    Private Sub cmdDeselecteazaTot_Click(sender As Object, e As EventArgs) Handles cmdDeselecteazaTot.Click
        GetAllControls(Me, GetType(CheckBox)).ToList.ForEach(
           Sub(c As CheckBox)
               If Strings.Left(c.Name, 5) = "check" Then
                   c.Checked = False
                   SaveSetting(AppName, "Settings", "checkBoxes" & c.Name, c.Checked)
               End If
           End Sub)
        UpdateGrid(cmbCautare.Text)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False

        Dim CautareInGreseliCombo As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\VB and VBA Program Settings\KmAutoInterface\Settings\CautareInGreseliCombo")
        For Each ValueName As String In CautareInGreseliCombo.GetValueNames()
            Dim Value As Object = CautareInGreseliCombo.GetValue(ValueName) 'Get the value (data) of the specified value name.
            If Value IsNot Nothing Then 'Make sure it exists.
                cmbCautare.Items.Add(Value.ToString())
            End If
        Next
        Dim intervaleDataTable As DataTable = ReturDataTable(kmAutoCmd, "Select Distinct Interval from GreseliLog")
        For Each row As DataRow In intervaleDataTable.Rows
            cmbIntervale.Items.Add(row("Interval"))
            cmbIntervale.Sorted = True
        Next
        cmbIntervale.SelectedIndex = cmbIntervale.Items.Count - 1
        Try
            cmbCautare.SelectedIndex = GetSetting(AppName, "Settings", "CautareInGreseliLogCombo_selectedIndex", 0)


        Catch ex As Exception

        End Try
        UpdateGrid(cmbCautare.Text)
        cmbCautare.Select()
    End Sub

    Private Sub cmbIntervale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIntervale.SelectedIndexChanged
        UpdateGrid(cmbCautare.Text)
    End Sub




    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        refreshGrid1(DataGridView1.CurrentRow)
    End Sub
    Private Sub DataGridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        refreshGrid1(DataGridView1.CurrentRow)
    End Sub
    Sub refreshGrid1(sourceGridCurrentRow As DataGridViewRow)
        Dim sourceGrid As DataGridView = Me.DataGridView1
        Dim targetGrid As DataGridView = Me.DataGridView3

        Try
            'scoate intervalul din grid
            Dim interval As String = sourceGridCurrentRow.Cells("Interval").Value
            Dim intervalComplet As String = sourceGridCurrentRow.Cells("IntervalComplet").Value
            Dim utilizatorId As Long = CLng(ReturDataTable(kmAutoCmd, "Select Id from Utilizatori where Nume ='" & sourceGridCurrentRow.Cells("Utilizator_").Value & "'").Rows(0)(0))
            Dim masinaId As Long = CLng(ReturDataTable(kmAutoCmd, "Select Id from Masini where Numar ='" & sourceGridCurrentRow.Cells("Numar").Value & "'").Rows(0)(0))
            DataGridView3.Rows.Clear()
            Dim intervaleDataTable As DataTable = ReturDataTable(kmAutoCmd, "Select Data, MasinaId, UtilizatorId, Km, Status, Spreadsheets_id, DataSiOraCitirii from KmLog Where UtilizatorId = " & utilizatorId & " and MasinaId = " & masinaId & ReturQueryInterval(intervalComplet))

            If Not intervaleDataTable Is Nothing Then
                For Each row As DataRow In intervaleDataTable.Rows
                    Dim numeUtilizator As String = ReturDataTable(kmAutoCmd, "Select Nume from Utilizatori where id ='" & row("UtilizatorId") & "'").Rows(0)(0)
                    Dim numarMasina As String = ReturDataTable(kmAutoCmd, "Select Numar from Masini where id ='" & row("MasinaId") & "'").Rows(0)(0)
                    Dim numeSpreadsheet As String = ReturDataTable(kmAutoCmd, "Select Nume from Spreadsheets where Id ='" & row("Spreadsheets_id") & "'").Rows(0)(0)
                    Dim inputData(7) As String, data As Date = CType(row("Data"), DateTime)
                    inputData(0) = numeUtilizator
                    inputData(1) = numarMasina
                    inputData(2) = data.ToString("yyyy-MM-dd HH:mm")
                    inputData(3) = row("Km")
                    inputData(4) = row("Status")
                    inputData(5) = numeSpreadsheet
                    inputData(6) = row("DataSiOraCitirii")
                    targetGrid.Rows.Add(inputData)

                Next
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Me.Cursor = Cursors.SizeWE
    End Sub



    Private Sub DataGridView1_MouseHover(sender As Object, e As EventArgs) Handles DataGridView1.MouseHover, DataGridView3.MouseMove, Me.MouseHover, DataGridView2.MouseMove
        Me.Cursor = Cursors.Default

    End Sub



    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        x = Control.MousePosition.X - sender.location.x
        x1 = Control.MousePosition.X - sender.location.x - 7
        'y = Control.MousePosition.Y - sender.location.y
    End Sub


    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint1 = Control.MousePosition
            newpoint.X -= x
            newpoint1.X -= x1
            If newpoint.X > Me.Width - 400 Then newpoint.X = Me.Width - 400
            If newpoint1.X > Me.Width - 400 Then newpoint1.X = Me.Width - 400
            newpoint.Y = PictureBox1.Location.Y
            newpoint1.Y = PictureBox1.Location.Y
            PictureBox1.Location = newpoint
            DataGridView1.Width = PictureBox1.Location.X - DataGridView1.Location.X - 3
            newpoint1.Y = DataGridView2.Location.Y
            DataGridView2.Location = newpoint1
            newpoint1.Y = DataGridView3.Location.Y
            DataGridView3.Location = newpoint1
            DataGridView2.Width = Me.Width - DataGridView1.Width - PictureBox1.Width - 45
            DataGridView3.Width = DataGridView2.Width
            SaveSetting(AppName, "Settings", Me.Name & "_resizePicture", PictureBox1.Location.X)

            Application.DoEvents()
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




    Private Sub cmdTrimiteEmailuri_Click(sender As Object, e As EventArgs) Handles cmdTrimiteEmailuri.Click
        For Each row As DataGridViewRow In DataGridView1.Rows
            For k As Long = 0 To 123000000

            Next
            refreshGrid1(row)
            Application.DoEvents()
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdStergeListaCautare.Click
        Dim result As DialogResult = MessageBox.Show("Stergeti lista de cautare?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            cmbCautare.Items.Clear()
            cmbCautare.Text = ""
        End If
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

    Private Sub cmdStergeCrt_Click(sender As Object, e As EventArgs) Handles cmdStergeCrt.Click
        cmbCautare.Items.Remove(cmbCautare.Text)
        Try
            cmbCautare.SelectedIndex = 0

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbCautare_TextChanged(sender As Object, e As EventArgs) Handles cmbCautare.TextChanged, cmbCautare.SelectedIndexChanged
        Timer3.Enabled = False
        Timer3.Enabled = True

    End Sub


    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Enabled = False

        UpdateGrid(cmbCautare.Text)

    End Sub




    'CIORNA
    '**************************
    'Nu sterge asta. Este rutina de identificare a intervalelor de weekend in arrStart() si arrStop() ca date de inceput si sfarsit
    'Dim strDataRaportarii As String = frmPrincipal.dtpDataRaportarii.Value, strDataInceput As String, strDataSfarsit As String, strDataFinala As String, dictZileLibere As New Dictionary(Of String, String)
    'Dim zileLibereDataTable As DataTable = ReturDataTable(kmAutoCmd, "Select * from ZileLibere"), arrStart() As Date, arrStop() As Date
    'For Each row As DataRow In zileLibereDataTable.Rows
    '    dictZileLibere.Add(row("Data"), row("Observatii"))
    'Next
    'AflaDateleDeInceputSfarsitFinal(formateazaDataAsString(strDataRaportarii, "yyyy-MM-dd"), strDataInceput, strDataSfarsit, strDataFinala, dictZileLibere)
    'AflaIntervaleleDePlata(strDataInceput, strDataFinala, dictZileLibere, arrStart, arrStop)
    '**************************

    'Stop 'targetRow.Cells("Masina").Value = row("MasinaId")
    'Dim myItemArray()
    'myItemArray = row.ItemArray
    'DataGridView3.Rows.Add(myItemArray)
    'For k = 0 To 4
    '    data(k) = row(DataGridView3.Columns(k).Index)

    'Next
    'For Each sourceRow As DataGridViewRow In sourceGrid.Rows
    '    Dim targetRow = CType(sourceRow.Clone(), DataGridViewRow)
    '    For Each cell As DataGridViewCell In sourceRow.Cells
    '        targetRow.Cells(cell.ColumnIndex).Value = cell.Value
    '    Next
    '    targetGrid.Rows.Add(targetRow)
    'Next

    ''formeaza un dictionar pentru a se asigura ca sunt cheile unice pe 
    'DataGridView2.Rows.Clear()
    ''References to source and target grid.

    'Dim sourceGrid As DataGridView = Me.DataGridView1
    'Dim targetGrid As DataGridView = Me.DataGridView2

    'For Each sourceRow As DataGridViewRow In sourceGrid.Rows
    '    Dim targetRow = CType(sourceRow.Clone(), DataGridViewRow)
    '    For Each cell As DataGridViewCell In sourceRow.Cells
    '        targetRow.Cells(cell.ColumnIndex).Value = cell.Value
    '    Next
    '    targetGrid.Rows.Add(targetRow)
    'Next

    'Exit Sub

    ''Mai jos este o metoda de a adauga bulk randuri
    ''Copy all rows and cells.

    ''Dim sourceGrid As DataGridView = Me.DataGridView1
    ''Dim targetGrid As DataGridView = Me.DataGridView2
    'Dim targetRows = New List(Of DataGridViewRow)

    'For Each sourceRow As DataGridViewRow In sourceGrid.Rows

    '    If (Not sourceRow.IsNewRow) Then

    '        Dim targetRow = CType(sourceRow.Clone(), DataGridViewRow)

    '        'The Clone method do not copy the cell values so we must do this manually.
    '        'See: https://msdn.microsoft.com/en-us/library/system.windows.forms.datagridviewrow.clone(v=vs.110).aspx

    '        For Each cell As DataGridViewCell In sourceRow.Cells
    '            targetRow.Cells(cell.ColumnIndex).Value = cell.Value
    '        Next

    '        targetRows.Add(targetRow)

    '    End If

    'Next

    ''Clear target columns and then clone all source columns.

    'targetGrid.Columns.Clear()

    'For Each column As DataGridViewColumn In sourceGrid.Columns
    '    targetGrid.Columns.Add(CType(column.Clone(), DataGridViewColumn))
    'Next

    ''It's recommended to use the AddRange method (if available)
    ''when adding multiple items to a collection.

    'targetGrid.Rows.AddRange(targetRows.ToArray())


    'Me.Text = intervalePeMasinaDataTable.Rows.Count & " - " & intervaleDataTable.Rows.Count
    'For Each row As DataRow In intervaleZeroInregistrariPeMasinaDataTable.Rows
    '    Dim numeUtilizator As String = ReturDataTable(kmAutoCmd, "Select Nume from Utilizatori where id ='" & row("UtilizatorId") & "'").Rows(0)(0)
    '    Dim numarMasina As String = ReturDataTable(kmAutoCmd, "Select Numar from Masini where id ='" & row("MasinaId") & "'").Rows(0)(0)
    'Next



End Class