Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Automation
Imports Microsoft.Office.Interop.Outlook
Imports Microsoft.Win32
Imports System
Imports System.IO
Imports Google.Apis.Sheets.v4.Data

Public Class frmGreseliLog
    Dim x, x1, y As Integer
    Dim newpoint As New Point
    Dim newpoint1 As New Point

    'o inlantuire de dictionare pentru a forma continutul emailor cu greseli catre utilizatori asfel incat 
    'sa se trimita un singur mail pe utilizator iar in el sa se faca gruparea pe tipuri de greseli
    Dim dictUtilizatori As New Dictionary(Of String, Dictionary(Of String, Dictionary(Of String, String)))
    Dim dictGreseliUtilizatori As Dictionary(Of String, Dictionary(Of String, String))
    Dim dictMasiniIntervale As Dictionary(Of String, String)

    Dim lunaRaportarii As String, anulRaportarii As String

    Private myStrData As String = ""
    Private myStatusModificat As String = ""
    Private myKmModificat As String = ""

    Private Sub frmGreseliLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KmAutoDataSet.Spreadsheets' table. You can move, or remove it, as needed.
        Me.SpreadsheetsTableAdapter.Fill(Me.KmAutoDataSet.Spreadsheets)
        'TODO: This line of code loads data into the 'KmAutoDataSet.Utilizatori' table. You can move, or remove it, as needed.
        Me.UtilizatoriTableAdapter.Fill(Me.KmAutoDataSet.Utilizatori)
        'TODO: This line of code loads data into the 'KmAutoDataSet.Spreadsheets' table. You can move, or remove it, as needed.
        Me.SpreadsheetsTableAdapter.Fill(Me.KmAutoDataSet.Spreadsheets)
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

        'pointt.Y = DataGridView3.Location.Y
        'DataGridView3.Location = pointt
        DataGridView2.Width = Me.Width - DataGridView1.Width - PictureBox1.Width - 45
        DataGridView3.Width = DataGridView1.Width
        aliniaza()
        Dim lstSabloane As List(Of String) = SearchAllFolders(AppPath & "input\Sabloane greseli")
        For Each nume As String In lstSabloane
            cmbSabloaneEmail.Items.Add(nume)
        Next
        If cmbSabloaneEmail.Items.Count > 0 Then
            cmbSabloaneEmail.SelectedIndex = 0
        End If

    End Sub
    Private Sub checkBoxes_MouseUp(sender As Object, e As EventArgs) Handles checkOSinguraInregistrare.MouseUp, checkKmPreaMulti.MouseUp, checkIndexeInversate.MouseUp, checkPrimaInregistrareNuEReferinta.MouseUp, checkToateInregistrarileSuntReferinta.MouseUp, checkDouaInregistrariAdiacenteReferinta.MouseUp, checkToateInregistrarileSuntReferinta.MouseUp, checkZeroInregistrari.MouseUp, checkToateInregistrarileSuntInteresServiciu.MouseUp, checkCompletareInutilaADateiDeIntroducere.MouseUp
        SaveSetting(AppName, "Settings", "checkBoxes" & sender.name, sender.checked)
        UpdateGrid(cmbCautare.Text)
    End Sub
    Private Sub UpdateGrid(Optional search As String = "")
        Dim dataInceput As String = "", d As Date = DateTime.Now
        Try
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
            Dim intervalComplet As String = "", dataSfarsit As String = ""
            If cmbIntervale.Text <> "Toate" Then
                dataInceput = convertDataAsStringOfFomat(ReturExecutaSqlKmAuto("Select DataInceput from Intervale where Interval ='" & cmbIntervale.Text & "' and DataRaportarii = '" & gstrDataRaportarii & "'"), "yyyy-MM-dd")
                dataSfarsit = convertDataAsStringOfFomat(ReturExecutaSqlKmAuto("Select DataFinala from Intervale where Interval ='" & cmbIntervale.Text & "' and DataRaportarii = '" & gstrDataRaportarii & "'"), "yyyy-MM-dd")
                intervalComplet = dataInceput & ":" & dataSfarsit
            Else
                dataInceput = gstrDataInceput
            End If

            'pregateste search splitat dupa ;
            'ex: constanta;mihai va face un OR intre 'Like'-urile pe 3 campuri pe constanta si apoi un and cu un OR intre 'Like'-urile pe 3 campuri pe mihai
            'ex: constanta;mihai;123 va face acelasi lucru dar pe 3 grupe, samd pe oricate grupe
            Dim v() As String = Split(search, ";")
            Dim searchWord As String = ""
            If search = "" Then
                searchWord = ""
            ElseIf UBound(v) > 0 Then
                For i As Long = 0 To UBound(v)
                    searchWord &= If(search.Length > 0, " AND (dbo.Filiale.Nume LIKE '%" & Trim(v(i)) & "%' OR dbo.Utilizatori.Nume LIKE '%" & Trim(v(i)) & "%' OR dbo.Masini.Numar LIKE '%" & Trim(v(i)) & "%' )", "")

                Next
            Else
                searchWord &= If(search.Length > 0, " AND (dbo.Filiale.Nume LIKE '%" & Trim(search) & "%' OR dbo.Utilizatori.Nume LIKE '%" & Trim(search) & "%' OR dbo.Masini.Numar LIKE '%" & Trim(search) & "%' )", "")

            End If
            Dim sql As String = clearSql("SELECT GreseliLog.id, dbo.Filiale.Nume AS Filiala, dbo.Utilizatori.Nume AS Utilizator,  " &
                         "GreseliLog.Interval, dbo.Greseli.Tip, dbo.Masini.Numar,  GreseliLog.IntervalComplet " &
                         "From dbo.Filiale INNER Join " &
                         "dbo.Utilizatori ON dbo.Filiale.id = dbo.Utilizatori.FilialaId INNER Join " &
                         "dbo.GreseliLog ON dbo.Utilizatori.Id =  GreseliLog.UtilizatorId INNER Join " &
                         "dbo.Masini ON  GreseliLog.MasinaId = dbo.Masini.Id INNER Join " &
                         "dbo.Greseli ON  GreseliLog.GresealaId = dbo.Greseli.Id " & If(greseli = "(", "Where GresealaId = -1 ", "Where GresealaId IN " & greseli & If(cmbIntervale.Text <> "Toate", " And IntervalComplet = '" & intervalComplet & "'", "") & searchWord) & " Order By Filiala, Utilizator, dbo.GreseliLog.GresealaId, dbo.GreseliLog.IntervalComplet")
            Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto(sql)
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
                    Dim masinaId As String = ReturExecutaSqlKmAuto("Select Id from Masini where Numar = '" & row("Numar") & "'")
                    Dim utilizatorId As String = ReturExecutaSqlKmAuto("Select Id from Utilizatori where Nume = '" & row("Utilizator") & "'")
                    Dim telefon As String = ReturExecutaSqlKmAuto("Select Telefon from Utilizatori where Id = '" & utilizatorId & "'")
                    Dim emailDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select Email, EmailConsolight from Utilizatori where Id = '" & utilizatorId & "'")
                    Dim email As String = emailDataTable(0)(0) & emailDataTable(0)(1)
                    Dim inputData(8) As String
                    inputData(0) = row("Id")
                    'Dim filialaId As String = ReturExecutaSql("Select FilialaId from Utilizatori where id ='" & row("UtilizatorId") & "'")
                    'Dim filiala As String = ReturExecutaSql("Select Nume from Filiale where id ='" & filialaId & "'")
                    inputData(1) = row("Filiala")
                    inputData(2) = row("Utilizator")
                    inputData(3) = row("Interval")
                    inputData(4) = row("Tip")
                    inputData(5) = row("Numar")
                    inputData(6) = row("IntervalComplet")
                    inputData(7) = telefon
                    inputData(8) = email
                    'elimina randurile daca tipul de greseala este 'Zero inregistrari' si mai exista un utilizator care a introdus date in acelasi interval
                    'If numeUtilizator = "Andrei Rus" And numarMasina = "B-156-CLT" And row("Interval") = "23 - 26.09" Then Stop
                    Dim intervalePeMasinaDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select Data, MasinaId, UtilizatorId, Km, Status, Spreadsheets_id from KmLog Where MasinaId = " & masinaId & " and UtilizatorId <> " & utilizatorId & ReturQueryInterval(row("IntervalComplet")) & "ORDER By MasinaId, Data;")
                    If Not intervalePeMasinaDataTable Is Nothing AndAlso intervalePeMasinaDataTable.Rows.Count > 0 AndAlso row("Tip") = "Zero inregistrari" Then
                        'Stop
                    Else
                        'acum cauta daca alt utilizator a introdus date de la inceputul lunii pe aceeasi masina. Daca da, nu va mai lua in seama
                        'si va transmite email-uri corespunzatoare pentru a informa ambii soferi ca nu au introdus nici unul kilometrii
                        intervalePeMasinaDataTable = ReturDataTableKmAuto("Select Data, MasinaId, UtilizatorId, Km, Status, Spreadsheets_id from KmLog Where MasinaId = " & masinaId & " and UtilizatorId <> " & utilizatorId & ReturQueryInterval(row("IntervalComplet"), dataInceput) & "ORDER By MasinaId, Data;")
                        If Not intervalePeMasinaDataTable Is Nothing AndAlso intervalePeMasinaDataTable.Rows.Count > 0 AndAlso row("Tip") = "Zero inregistrari" Then
                        Else
                            DataGridView1.Rows.Add(inputData)

                        End If

                    End If
                Next

                For Each row As DataGridViewRow In DataGridView1.Rows
                    'memoreaza id-urile
                    Dim masinaId As String = ReturExecutaSqlKmAuto("Select Id from Masini where Numar = '" & row.Cells("Numar").Value & "'")
                    Dim utilizatorId As String = ReturExecutaSqlKmAuto("Select Id from Utilizatori where Nume = '" & row.Cells("Utilizator_").Value & "'")
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
            refreshGridKmLog(DataGridView1.Rows(0))
            cmbCautare.Select(cmbCautare.Text.Length, 0)        'pune cursorul la final
            pregatireEmailuriCatreUtilizatori()

        Catch ex As System.Exception

        End Try

    End Sub


    Private Sub frmGreseliLog_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)
        Try
            Registry.CurrentUser.DeleteSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInGreseliCombo\")

        Catch ex As System.Exception

        End Try
        SaveSetting(AppName, "Settings", "CautareInGreseliLogCombo_selectedIndex", cmbCautare.SelectedIndex)
        Registry.CurrentUser.CreateSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInGreseliCombo\")
        For Each item As String In cmbCautare.Items
            Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInGreseliCombo\", item, item)
        Next
        Me.Dispose()

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
        Dim d As Date = convertStringDataToDate(frmPrincipal.lblDataRaportarii.Text)
        If DateAndTime.Day(d) <= 8 Then
            d = DateAdd("m", -1, d)
        Else

        End If
        Dim v() As String = {"Ianuarie", "Februarie", "Martie", "Aprilie", "Mai", "Iunie", "Iulie", "August", "Septembrie", "Octombrie", "Noiembrie", "Decembrie"}
        lunaRaportarii = v(DateAndTime.Month(d) - 1)
        anulRaportarii = DateAndTime.Year(d)

        Dim CautareInGreseliCombo As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\VB and VBA Program Settings\KmAutoInterface\Settings\CautareInGreseliCombo")
        For Each ValueName As String In CautareInGreseliCombo.GetValueNames()
            Dim Value As Object = CautareInGreseliCombo.GetValue(ValueName) 'Get the value (data) of the specified value name.
            If Value IsNot Nothing Then 'Make sure it exists.
                cmbCautare.Items.Add(Value.ToString())
            End If
        Next
        Dim kmLogDataTable As System.Data.DataTable = ReturDataTableKmAuto("select * from intervale Where DataRaportarii ='" & gstrDataRaportarii & "' order by dataInceput")
        For Each row As DataRow In kmLogDataTable.Rows
            cmbIntervale.Items.Add(row("Interval"))
        Next
        cmbIntervale.Items.Add("Toate")
        cmbIntervale.SelectedIndex = cmbIntervale.Items.Count - 1
        Try
            cmbCautare.SelectedIndex = GetSetting(AppName, "Settings", "CautareInGreseliLogCombo_selectedIndex", 0)


        Catch ex As System.Exception

        End Try
        UpdateGrid(cmbCautare.Text)
        cmbCautare.Select()
    End Sub

    Private Sub cmbIntervale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIntervale.SelectedIndexChanged
        UpdateGrid(cmbCautare.Text)
    End Sub




    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        refreshGridKmLog(DataGridView1.CurrentRow)
    End Sub
    Private Sub DataGridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        refreshGridKmLog(DataGridView1.CurrentRow)
    End Sub
    Sub refreshGridKmLog(sourceGridCurrentRow As DataGridViewRow)
        Dim sourceGrid As DataGridView = Me.DataGridView1
        Dim targetGrid As DataGridView = Me.DataGridView3

        'scoate intervalul din grid
        Dim interval As String = sourceGridCurrentRow.Cells("Interval").Value
        Dim intervalComplet As String = sourceGridCurrentRow.Cells("IntervalComplet").Value
        Dim utilizatorId As Long = CLng(ReturExecutaSqlKmAuto("Select Id from Utilizatori where Nume ='" & sourceGridCurrentRow.Cells("Utilizator_").Value & "'"))
        Dim masinaId As Long = CLng(ReturExecutaSqlKmAuto("Select Id from Masini where Numar ='" & sourceGridCurrentRow.Cells("Numar").Value & "'"))
        DataGridView3.Rows.Clear()
        Dim kmLogDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select Data, MasinaId, UtilizatorId, Km, KmModificat, Status, StatusModificat, Spreadsheets_id, DataSiOraCitirii, Asumat, Observatii from KmLog Where UtilizatorId = " &
                                                                     utilizatorId & " and MasinaId = " & masinaId & ReturQueryInterval(intervalComplet) & " and Status <> 'Plecare in concediu' and Status <> 'Sosire din concediu (card firma)' 
                                                                     and Status <> 'Sosire din concediu (card personal)'")
        If Not kmLogDataTable Is Nothing Then
            For Each row As DataRow In kmLogDataTable.Rows
                Try
                    Dim numeUtilizator As String = ReturExecutaSqlKmAuto("Select Nume from Utilizatori where id ='" & row("UtilizatorId") & "'")
                    Dim numarMasina As String = ReturExecutaSqlKmAuto("Select Numar from Masini where id ='" & row("MasinaId") & "'")
                    Dim numeSpreadsheet As String = ReturExecutaSqlKmAuto("Select Nume from Spreadsheets where Id ='" & row("Spreadsheets_id") & "'")
                    Dim inputData(11) As String, data As Date = CType(row("Data"), DateTime)
                    inputData(0) = numeUtilizator
                    inputData(1) = numarMasina
                    inputData(2) = data.ToString("yyyy-MM-dd HH:mm:ss")
                    inputData(3) = row("Km")
                    inputData(4) = row("KmModificat")
                    inputData(5) = row("Status")
                    inputData(6) = row("StatusModificat")
                    inputData(7) = numeSpreadsheet
                    inputData(8) = row("DataSiOraCitirii")
                    inputData(8) = row("Asumat")
                    inputData(8) = row("Observatii")
                    targetGrid.Rows.Add(inputData)
                    cmbSpreadsheets.Text = numeSpreadsheet
                Catch ex As System.Exception

                End Try
            Next

        End If
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
            'newpoint1.Y = DataGridView3.Location.Y
            'DataGridView3.Location = newpoint1
            DataGridView2.Width = Me.Width - DataGridView1.Width - PictureBox1.Width - 45
            DataGridView3.Width = DataGridView1.Width
            SaveSetting(AppName, "Settings", Me.Name & "_resizePicture", PictureBox1.Location.X)

            System.Windows.Forms.Application.DoEvents()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        aliniaza()
        If DataGridView2.Rows.Count = 0 Then txtContinutEmail.Text = ""
        If DataGridView1.Rows.Count = 0 Then
            DataGridView2.Rows.Clear()
            txtContinutEmail.Text = ""
        End If


    End Sub
    Private Sub aliniaza()
        If cmbCautare.Text = "" Then
            cmbCautare.BackColor = SystemColors.Window
        Else
            cmbCautare.BackColor = System.Drawing.Color.Yellow

        End If
        cmdStergeListaCautare.Enabled = cmbCautare.Items.Count
        cmdStergeCrt.Enabled = cmbCautare.Items.Count
        txtContinutEmail.Width = DataGridView2.Width
        txtContinutEmail.Left = DataGridView2.Left
        lblEmailuri.Left = DataGridView2.Left
        cmbSpreadsheets.Left = DataGridView2.Left
        cmbSpreadsheets.Width = DataGridView2.Width - cmdDeschideSpreadsheet.Width - 20
        cmbSabloaneEmail.Width = txtContinutEmail.Left - cmbSabloaneEmail.Left - 20
    End Sub

    Private Sub pregatireEmailuriCatreUtilizatori()
        DataGridView2.Rows.Clear()
        dictUtilizatori.Clear()
        Dim fisierSablonGreseala As String = IO.File.ReadAllText(cmbSabloaneEmail.Text) 'citeste de pe disc sablonul pentru email greseli ales

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim interval As String = row.Cells("Interval").Value 'scoate intervalul din grid
            Dim intervalComplet As String = row.Cells("IntervalComplet").Value
            Dim utilizatorId As Long = CLng(ReturExecutaSqlKmAuto("Select Id from Utilizatori where Nume ='" & row.Cells("Utilizator_").Value & "'"))
            Dim masinaId As Long = CLng(ReturExecutaSqlKmAuto("Select Id from Masini where Numar ='" & row.Cells("Numar").Value & "'"))

            'pune in continutKmLog inregistrarile corespunzatoare
            Dim kmLogDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select Data, MasinaId, UtilizatorId, Km, Status, DataSiOraCitirii, PozaDinBord, Asumat, Observatii from KmLog Where UtilizatorId = " & utilizatorId & " and MasinaId = " & masinaId & ReturQueryInterval(intervalComplet))
            Dim continutKmLog As String = ""
            For Each datarow As DataRow In kmLogDataTable.Rows
                'If datarow("Status") = "Plecare in concediu" Then Stop
                If datarow("Status") <> "Plecare in concediu" And datarow("Status") <> "Sosire din concediu (card firma)" And datarow("Status") <> "Sosire din concediu (card personal )" Then
                    continutKmLog &= vbCrLf & Chr(9) & "Data: " & datarow("Data").ToString & " - " & "Km: " & datarow("Km").ToString & " - " & "Status: " & datarow("Status").ToString & " - " & If(datarow("DataSiOraCitirii").ToString.Length > 0, "Data si ora introducerii: " & datarow("DataSiOraCitirii").ToString, "") & " - " & "Poza din bord: " & datarow("PozaDinBord").ToString
                Else
                    continutKmLog &= "Se refera la concediu"
                End If
            Next

            'formeaza cheile dictionarelor
            Dim dictKey As String = row.Cells("Utilizator_").Value
            Dim dictKey1 As String = row.Cells("Tip").Value
            Dim dictKey2 As String = row.Cells("Numar").Value & ":" & row.Cells("Interval").Value


            'scrie dictionarele
            If dictUtilizatori.ContainsKey(dictKey) = False Then 'dictKey = Utilizator
                dictGreseliUtilizatori = New Dictionary(Of String, Dictionary(Of String, String))

                'se scrie aici pentru ca se adauga oricum si la crearea si la adaugarea in dictGreseliUtilizatori
                dictMasiniIntervale = New Dictionary(Of String, String)

                'In dictMasiniIntervale se adauga doar continutKmLog
                If dictMasiniIntervale.ContainsKey(dictKey2) = False Then 'dictKey2 = Masina:Interval
                    dictMasiniIntervale.Add(dictKey2, continutKmLog)
                Else
                    dictMasiniIntervale(dictKey2) = continutKmLog

                End If
                If dictGreseliUtilizatori.ContainsKey(dictKey1) = False Then 'dictKey1 = Greseala
                    dictGreseliUtilizatori.Add(dictKey1, dictMasiniIntervale)
                Else
                    dictGreseliUtilizatori(dictKey1) = dictMasiniIntervale

                End If
                dictUtilizatori.Add(dictKey, dictGreseliUtilizatori)
            Else
                'se scrie aici pentru ca se adauga oricum si la crearea si la adaugarea in dictGreseliUtilizatori
                dictMasiniIntervale = New Dictionary(Of String, String)

                'In dictMasiniIntervale se adauga doar continutKmLog
                If dictMasiniIntervale.ContainsKey(dictKey2) = False Then 'dictKey2 = Masina:Interval
                    dictMasiniIntervale.Add(dictKey2, continutKmLog)
                Else
                    dictMasiniIntervale(dictKey2) = continutKmLog

                End If
                If dictGreseliUtilizatori.ContainsKey(dictKey1) = False Then 'dictKey1 = Greseala
                    dictGreseliUtilizatori.Add(dictKey1, dictMasiniIntervale)
                Else
                    dictGreseliUtilizatori(dictKey1) = dictMasiniIntervale

                End If

                dictUtilizatori(dictKey) = dictGreseliUtilizatori
            End If
        Next
        For Each part As KeyValuePair(Of String, Dictionary(Of String, Dictionary(Of String, String))) In dictUtilizatori
            Dim fisierEmail As String = fisierSablonGreseala 'pentru fiecare utilizator reface sablonul
            Dim continut As String = "" 'si continutul ce va inlocui variabila $Continut din fisierEmail
            For Each part1 As KeyValuePair(Of String, Dictionary(Of String, String)) In part.Value
                'scoate mesajul greselii
                Dim mesajGreseala As String = ReturExecutaSqlKmAuto("Select Mesaj from Greseli where Tip = '" & part1.Key & "'")
                continut &= vbCrLf & vbCrLf & Chr(9) & mesajGreseala
                For Each part2 As KeyValuePair(Of String, String) In part1.Value
                    Dim vv() As String = Split(part2.Key, ":")
                    continut &= vbCrLf & Chr(9) & "pentru intervalul " & vv(1)
                    continut &= Chr(9) & part2.Value
                Next
            Next
            fisierEmail = fisierEmail.Replace("$Utilizator", part.Key)
            fisierEmail = fisierEmail.Replace("$Sender", MailSender)
            fisierEmail = fisierEmail.Replace("$Continut", continut)
            fisierEmail = fisierEmail.Replace("$Luna", lunaRaportarii & " - " & anulRaportarii)
            Dim emailUtilizator As String = ReturExecutaSqlKmAuto("Select Email from Utilizatori where Nume ='" & part.Key & "'")
            Dim emailConsolightUtilizator As String = ReturExecutaSqlKmAuto("Select EmailConsolight from Utilizatori where Nume ='" & part.Key & "'")
            Dim email As String
            If emailUtilizator = "" Then
                If emailConsolightUtilizator = "" Then
                    email = ""
                Else
                    email = emailConsolightUtilizator
                End If
            Else
                If emailConsolightUtilizator = "" Then
                    email = emailUtilizator
                Else
                    email = emailUtilizator & "; " & emailConsolightUtilizator
                End If


            End If
            Dim inputData(2) As String
            inputData(0) = part.Key
            inputData(1) = fisierEmail
            inputData(2) = email
            If fisierEmail.Contains("Se refera la concediu") Then
            Else
                DataGridView2.Rows.Add(inputData)

            End If

        Next
        DataGridView2.MultiSelect = False
        DataGridView2.MultiSelect = True
        If DataGridView2.Rows.Count > 0 Then
            DataGridView2.Rows(0).Selected = True
            txtContinutEmail.Text = DataGridView2.Rows(0).Cells(1).Value
        End If
    End Sub
    Private Sub cmdStergeListaCautare_Click(sender As Object, e As EventArgs) Handles cmdStergeListaCautare.Click
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

        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub cmbCautare_TextChanged(sender As Object, e As EventArgs) Handles cmbCautare.TextChanged, cmbCautare.SelectedIndexChanged
        Timer3.Enabled = False
        Timer3.Enabled = True

    End Sub


    Private Sub cmdDeschideSpreadsheet_Click(sender As Object, e As EventArgs) Handles cmdDeschideSpreadsheet.Click
        Dim spreadsheetId As String = cmbSpreadsheets.SelectedValue
        Dim url As String = "https://docs.google.com/spreadsheets/d/" & spreadsheetId
        If tabExists(url).Length > 0 Then
        Else
            Process.Start(url)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub cmdIncarcaEmailuri_Click(sender As Object, e As EventArgs)
        pregatireEmailuriCatreUtilizatori()
    End Sub

    Private Sub cmdTrimiteEmailCatre_Click(sender As Object, e As EventArgs) Handles cmdTrimiteEmailCatre.Click
        Dim result As DialogResult = MessageBox.Show("Se va trimite email catre utilizatorul selectat, continand greselile de introducere km. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Cursor = Cursors.WaitCursor
            Dim row As DataGridViewRow = DataGridView2.CurrentRow
            If row.Cells("Email").Value <> "" Then
                'MessageBox.Show("Trimitere email: " & sendSimpleEmail("mincior@yahoo.com", "Aplicatie KmAuto", row.Cells("TextEmail").Value))
                MessageBox.Show("Trimitere email: " & sendSimpleEmail(row.Cells("Email").Value, "Aplicatie KmAuto", row.Cells("TextEmail").Value))

            End If
            Cursor = Cursors.Default
        End If

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Enabled = False
        UpdateGrid(cmbCautare.Text)

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex <> -1 Then
            txtContinutEmail.Text = DataGridView2.Rows(e.RowIndex).Cells(1).Value
            cmdTrimiteEmailCatre.Text = "Trimite email catre " & DataGridView2.CurrentRow.Cells("Utiliz").Value
        End If
    End Sub


    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub cmdCautaTot_Click(sender As Object, e As EventArgs) Handles cmdCautaTot.Click
        cmbCautare.Text = ""
    End Sub

    Private Sub cmbSabloaneEmail_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSabloaneEmail.SelectedIndexChanged
        pregatireEmailuriCatreUtilizatori()
    End Sub

    Private Sub checkPrimaInregistrareNuEReferinta_CheckedChanged(sender As Object, e As EventArgs) Handles checkPrimaInregistrareNuEReferinta.CheckedChanged

    End Sub

    Private Sub cmdSalveazaInSablonulCurent_Click(sender As Object, e As EventArgs) Handles cmdSalveazaInSablonulCurent.Click
        Dim result As DialogResult = MessageBox.Show("Se vasalva textul de mai jos in sablonul " & cmbSabloaneEmail.Text & ". Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            IO.File.WriteAllText(cmbSabloaneEmail.Text, txtContinutEmail.Text)
        End If
    End Sub

    Private Sub cmdDeschideSablonul_Click(sender As Object, e As EventArgs) Handles cmdDeschideSablonul.Click
        System.Diagnostics.Process.Start("notepad.exe", cmbSabloaneEmail.Text)
    End Sub

    Private Sub cmdRefreshCautareCurenta_Click(sender As Object, e As EventArgs) Handles cmdRefreshCautareCurenta.Click
        Timer3.Enabled = True
    End Sub



    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        If DataGridView3.Columns(DataGridView3.CurrentCell.ColumnIndex).Name = "Spreadsheet" Then
            cmbSpreadsheets.Text = DataGridView3.CurrentCell.Value
        End If


    End Sub

    Private Sub DataGridView3_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellDoubleClick
        If DataGridView3.Columns(DataGridView3.CurrentCell.ColumnIndex).Name = "Data" Then
            frmGetDataAsDate.Tag = DataGridView3.CurrentCell.Value
            frmGetDataAsDate.ShowDialog()
            DataGridView3.CurrentCell.Value = frmGetDataAsDate.Tag
            DataGridView3.EndEdit()
            DataGridView3.RefreshEdit()
            frmGetDataAsDate.Dispose()

        End If

    End Sub
    Private Sub cmdTrimiteEmailSelectie_Click(sender As Object, e As EventArgs) Handles cmdTrimiteEmailSelectie.Click
        If DataGridView2.SelectedRows.Count.ToString Then
            Dim result As DialogResult = MessageBox.Show("Se vor trimite emailuri catre utilizatori continand greselile de introducere km. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Cursor = Cursors.WaitCursor
                For Each row As DataGridViewRow In DataGridView2.Rows
                    If row.Cells("Email").Value <> "" And row.Selected = True Then
                        sendSimpleEmail(row.Cells("Email").Value, "Aplicatie KmAuto", row.Cells("TextEmail").Value)
                        'sendSimpleEmail("vicentiu.mincior@consolight.ro", "Aplicatie KmAuto", row.Cells("TextEmail").Value)

                    End If
                Next
                Cursor = Cursors.Default
            End If
        End If
    End Sub
    Private Sub cmdTrimitereEmailuri_Click(sender As Object, e As EventArgs) Handles cmdTrimitereEmailuri.Click
        Dim result As DialogResult = MessageBox.Show("Se vor trimite emailuri catre utilizatori continand greselile de introducere km. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Cursor = Cursors.WaitCursor
            For Each row As DataGridViewRow In DataGridView2.Rows
                If row.Cells("Email").Value <> "" Then
                    sendSimpleEmail(row.Cells("Email").Value, "Aplicatie KmAuto", row.Cells("TextEmail").Value)
                    'sendSimpleEmail("vicentiu.mincior@consolight.ro", "Aplicatie KmAuto", row.Cells("TextEmail").Value)

                End If
            Next
            Cursor = Cursors.Default
        End If

    End Sub


    'ciorna

End Class