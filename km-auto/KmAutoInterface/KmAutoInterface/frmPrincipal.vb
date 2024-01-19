Option Explicit On
Imports System.ComponentModel
Imports Google.Apis.Sheets.v4
Imports Google.Apis.Sheets.v4.Data
Imports Newtonsoft.Json
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System.IO
Imports Microsoft.Office.Interop.Outlook
Imports System.Windows.Automation
Imports System.Runtime.InteropServices
Imports Google.Apis
Public Class frmPrincipal
    Dim steagEmailSend As Boolean = False
    Dim iesire As Boolean = False

    Private Sub StartUIPathProcess(releaseKey As String)

        'Foloseste scripturi .ps1 PowerShell pentru a trimite requesturi catre UiPath. Scopul final este sa porneasca un proces din Orchestrator folosind UiPath API
        'https://docs.google.com/document/d/1W5fq5sKeydv3wa9NWNDfEbOIbZ0C4PqcWBTP2cyJygw/edit#
        Dim file As String, outputFile As String, content As String, token As String, v() As String

        'se autentifica prin obtinerea unui token
        file = AppPath & "scripts\script.ps1"
        outputFile = AppPath & "scripts\output.txt"
        content = "$headers = New-Object ""System.Collections.Generic.Dictionary[[String],[String]]""
        $headers.Add(""Accept"", ""application/json"")
        $headers.Add(""Content-Type"", ""application/json"")
        $headers.Add(""X-UIPATH-TenantName"", """ & XUIPathTenantName & """)
        $headers.Add(""Authorization"", ""Bearer " & AuthorizationBearer & """)
        $headers.Add(""Cookie"", """ & Cookie & """)
        
        $body = ""{
        `n    `""grant_type`"":`""refresh_token`"",
        `n`""client_id`"":`""" & ClientId & "`"",
        `n`""refresh_token`"":`""" & RefreshToken & "`""
        `n}""

        $response = Invoke-RestMethod 'https://account.uipath.com/oauth/token' -Method 'POST' -Headers $headers -Body $body
        $write = $response | ConvertTo-Json
        $write | Out-File " & outputFile

        IO.File.WriteAllText(file, content)
        WaitForExecute("Powershell.exe", "-executionpolicy remotesigned -File " & file)
        content = IO.File.ReadAllText(outputFile)
        v = Split(content, """id_token""")
        v = Split(v(0), """access_token"":")
        v = Split(v(1), """,")
        v = Split(v(0), """")
        token = Trim(v(1))

        file = AppPath & "scripts\scriptSendCommand.ps1"
        outputFile = AppPath & "scripts\outputSendComand.txt"
        content = "$headers = New-Object ""System.Collections.Generic.Dictionary[[String],[String]]""
        $headers.Add(""Content-Type"", ""application/json"")
        $headers.Add(""X-UIPATH-TenantName"", """ & XUIPathTenantName & """)
        $headers.Add(""X-UIPATH-OrganizationUnitId"", """ & UiPathOrganizationUnitProcessID & """)
        $headers.Add(""Accept"", ""application/json"")
        $headers.Add(""Authorization"", ""Bearer " & token & """)

        $body = ""{
        `n    `""startInfo`"":{
        `n        `""ReleaseKey`"":`""" & releaseKey & "`"",
        `n        `""Strategy`"":`""ModernJobsCount`"",
        `n        `""JobsCount`"": 1,
        `n        `""Source`"": `""Manual`"",
        `n        `""JobPriority`"": `""Normal`"",
        `n        `""RuntimeType`"": `""Unattended`""    
        `n    }
        `n}
        `n""

        $response = Invoke-RestMethod 'https://cloud.uipath.com/" & UiPathOrganizationId & "/" & XUIPathTenantName & "/odata/jobs/UiPath.Server.Configuration.OData.StartJobs' -Method 'POST' -Headers $headers -Body $body
        $response | ConvertTo-Json
        $write = $response | ConvertTo-Json
        $write | Out-File " & outputFile

        IO.File.WriteAllText(file, content)
        WaitForExecute("Powershell.exe", "-executionpolicy remotesigned -File " & file)
        content = IO.File.ReadAllText(outputFile)

    End Sub

    Private Sub cmdExecuta_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KmAutoDataSet.UtilizatoriInPlus' table. You can move, or remove it, as needed.
        Me.UtilizatoriInPlusTableAdapter.Fill(Me.KmAutoDataSet.UtilizatoriInPlus)
        'TODO: This line of code loads data into the 'KmAutoDataSet.MasiniInPlus' table. You can move, or remove it, as needed.
        Try

        Catch ex As system.Exception

        End Try
        Me.MasiniInPlusTableAdapter.Fill(Me.KmAutoDataSet.MasiniInPlus)
        'TODO: This line of code loads data into the 'KmAutoDataSet.MasiniInexistente' table. You can move, or remove it, as needed.
        Me.MasiniInexistenteTableAdapter.Fill(Me.KmAutoDataSet.MasiniInexistente)
        'TODO: This line of code loads data into the 'KmAutoDataSet.UtilizatoriInexistenti' table. You can move, or remove it, as needed.
        Me.UtilizatoriInexistentiTableAdapter.Fill(Me.KmAutoDataSet.UtilizatoriInexistenti)
        'TODO: This line of code loads data into the 'KmAutoDataSet1.MasiniInPlus' table. You can move, or remove it, as needed.
        Me.Spreadsheets1TableAdapter.Fill(Me.KmAutoDataSet.Spreadsheets1)
        'TODO: This line of code loads data into the 'KmAutoDataSet.GreseliLog' table. You can move, or remove it, as needed.
        Me.GreseliLogTableAdapter.Fill(Me.KmAutoDataSet.GreseliLog)
        Me.ConfigTableAdapter.FillByNumeRobot(Me.RobotsDataSet.Config, NumeRobot)
        Try
            MkDir(AppPath & "scripts")
        Catch ex As System.Exception

        End Try
        Try
            kmAutoSqlCon.ConnectionString = kmAutoConnectionString
            kmAutoSqlCon.Open()
            kmAutoCmd.Connection = kmAutoSqlCon
            kmAutoCmd.CommandTimeout = 20000

            RobotsSqlCon.ConnectionString = RobotsConnectionString
            RobotsSqlCon.Open()
            RobotsCmd.Connection = RobotsSqlCon
            RobotsCmd.CommandTimeout = 20000

        Catch ex As System.Exception

        End Try
        Me.Text = Me.Text & " " & SystemInformation.UserName
        IncarcaDimensiuniSiPozitie(Me, 691, 264, 613, 334)
        Dim limitaZiIntreLuni As Long = ReturExecutaSqlRobots("Select FisiereBI from Config Where NumeRobot ='" & NumeRobot & "'")

        lblDataRaportarii.Text = ReturExecutaSqlRobots("Select DataInterogare from Config Where NumeRobot ='" & NumeRobot & "'")
        If lblDataRaportarii.Text = "" Then
            lblDataRaportarii.Text = convertDataAsStringOfFomat(RectificaDataRaportarii(DateTime.Now, limitaZiIntreLuni), "yyyy-MM-dd")
        End If

        gstrDataRaportarii = convertDataAsStringOfFomat(RectificaDataRaportarii(convertStringDataToDate(lblDataRaportarii.Text), limitaZiIntreLuni), "yyyy-MM-dd")
        AflaDateleDeInceputSfarsitFinal(gstrDataRaportarii, gstrDataInceput, gstrDataSfarsit, gstrDataFinala)
        If gstrDataInceput = "0001-01-01" Then
            MessageBox.Show("Eroare setare data")
            Me.Close()
            End
        Else
            EmailSendCheckBox.Checked = ReturExecutaSqlRobots("SELECT EmailSend FROM Config WHERE (NumeRobot = '" & NumeRobot & "')")
            ExtrageRapExcelDinBICheckBox.Checked = ReturExecutaSqlRobots("SELECT ExtrageRapExcelDinBI FROM Config WHERE (NumeRobot = '" & NumeRobot & "')")
            NumarLuniActualizateTextBox.Text = ReturExecutaSqlRobots("SELECT NumarLuniActualizate FROM Config WHERE (NumeRobot = '" & NumeRobot & "')")
            EmailToTextBox.Text = ReturExecutaSqlRobots("SELECT EmailTo FROM Config WHERE (NumeRobot = '" & NumeRobot & "')")
            EmailMeTextBox.Text = ReturExecutaSqlRobots("SELECT EmailMe FROM Config WHERE (NumeRobot = '" & NumeRobot & "')")
            ImpartePeFilialeCheckBox.Checked = ReturExecutaSqlRobots("SELECT ImpartePeFiliale FROM Config WHERE (NumeRobot = '" & NumeRobot & "')")
            ImpartePeAgentiCheckBox.Checked = ReturExecutaSqlRobots("SELECT ImpartePeAgenti FROM Config WHERE (NumeRobot = '" & NumeRobot & "')")
            getNumarGreseli(Me, "T") 'greseli totale
            getNumarGreseli(Me, "U") 'greseli pe utilizator

        End If


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


    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        kmAutoSqlCon.Close()
        RobotsSqlCon.Close()
        SalveazaDimensiuniSiPozitie(Me)
        ConfigTableAdapter.UpdateQueryImpartePeFiliale(False)
        ConfigTableAdapter.UpdateQueryImpartePeAgenti(False)
        Try
            myEx.Quit()
        Catch ex As System.Exception

        End Try
    End Sub




    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        cmdRuleazaRobotul.Enabled = Not iesire
        Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select * from UtilizatoriInexistenti")
        DataGridView1.Visible = myDataTable.Rows.Count
        Dim myDataTable1 As System.Data.DataTable = ReturDataTableKmAuto("Select * from MasiniInexistente")
        DataGridView2.Visible = myDataTable1.Rows.Count
    End Sub

    Private Sub ImpartePeFilialeCheckBox_MouseUp(sender As Object, e As MouseEventArgs) Handles ImpartePeFilialeCheckBox.MouseUp
        ConfigTableAdapter.UpdateQueryImpartePeFiliale(ImpartePeFilialeCheckBox.Checked)

    End Sub

    Private Sub ImpartePeAgentiCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ImpartePeAgentiCheckBox.CheckedChanged
        ConfigTableAdapter.UpdateQueryImpartePeAgenti(ImpartePeAgentiCheckBox.Checked)

    End Sub

    Private Sub cmdKm_Click(sender As Object, e As EventArgs) Handles cmdKm.Click, KmToolStripMenuItem.Click
        frmKmLogView.ShowDialog()
        frmKmLogView.Dispose()

    End Sub

    Private Sub cmdMasini_Click(sender As Object, e As EventArgs) Handles cmdMasini.Click, MasiniToolStripMenuItem.Click
        frmMasini.ShowDialog()
        frmMasini.Dispose()

    End Sub

    Private Sub cmdUtilizatori_Click(sender As Object, e As EventArgs) Handles cmdUtilizatori.Click, UtilizatoriToolStripMenuItem.Click
        frmUtilizatori.ShowDialog()
        frmUtilizatori.Dispose()

    End Sub



    Private Sub cmdIntervale_Click(sender As Object, e As EventArgs) Handles cmdIntervale.Click
        frmIntervale.ShowDialog()
        frmIntervale.Dispose()

    End Sub

    Private Sub cmdRuleazaRobotul_Click(sender As Object, e As EventArgs) Handles cmdRuleazaRobotul.Click, RuleazaRobotulToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Atentie. Se va rula robotul 'Km Auto' de pe serverul 'UiPath Robots'. Continuati?", "Km Auto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            RuleazaRobotul()
            'TODO: This line of code loads data into the 'KmAutoDataSet.MasiniInexistente' table. You can move, or remove it, as needed.
            Me.MasiniInexistenteTableAdapter.Fill(Me.KmAutoDataSet.MasiniInexistente)
            'TODO: This line of code loads data into the 'KmAutoDataSet.UtilizatoriInexistenti' table. You can move, or remove it, as needed.
            Me.UtilizatoriInexistentiTableAdapter.Fill(Me.KmAutoDataSet.UtilizatoriInexistenti)
            'TODO: This line of code loads data into the 'KmAutoDataSet.GreseliLog' table. You can move, or remove it, as needed.

        End If
    End Sub
    Private Sub cmdRuleazaVBA_Click(sender As Object, e As EventArgs) Handles cmdRuleazaVBA.Click, RuleazaVBAToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Atentie. Se va rula robotul 'Km Auto' de pe serverul 'UiPath Robots' dar numai macro Executa din fisierul Procesator. Continuati?", "Km Auto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            RuleazaRobotul(True) 'ruleaza doar vba, setand 
        End If
    End Sub

    Private Sub RuleazaRobotul(Optional DoarExecutaVBA As Boolean = False)
        Dim res As String, contor As Long
        Me.Cursor = Cursors.WaitCursor
        If ReturExecutaSqlRobots("SELECT EmailSend FROM Config WHERE (NumeRobot = '" & NumeRobot & "')") = "False" And steagEmailSend = False Then
            res = ExecutaSQLRobots("Update Config SET EmailSend = 'True' Where (NumeRobot = '" & NumeRobot & "');")
            'ConfigTableAdapter.UpdateQueryEmailSend("True", NumeRobot)
            steagEmailSend = True 'pentru a sterge ulterior, fiindca nu era activa
        End If
        If DoarExecutaVBA = True Then
            'forteaza Necitirea datelor din google si incarcarea masinilor si utilizatorilor pentru a rula doar excel-ul, macro Executa.
            'ExtrageRapExcelDinBI, ExtrageRapExcelDinERP, ExecutaSQL
            res = ExecutaSQLRobots("Update Config SET ExtrageRapExcelDinBI = 'False', ExtrageRapExcelDinERP = 'False', ExecutaSQL = 'False' Where NumeRobot = '" & NumeRobot & "'")
        Else 'altfel forteaza citirea datelor din google si ...
            res = ExecutaSQLRobots("Update Config SET ExtrageRapExcelDinBI = 'True', ExtrageRapExcelDinERP = 'True', ExecutaSQL = 'True' Where NumeRobot = '" & NumeRobot & "'")

        End If
        'forteaza adaugarea tuturor spreadsheet-urilor la campul Parametri din Config pe kmAuto. Altfel raportul poate fi incomplet
        'ramas asa in urma unor teste.
        wait(3000)
        Dim parametri As String = ""
        Dim parametriDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select Nume from Spreadsheets")
        For Each row As DataRow In parametriDataTable.Rows
            parametri &= row("Nume") & ", "
        Next
        res = ExecutaSQLRobots("Update Config SET Parametri = '" & parametri & "' Where (NumeRobot = '" & NumeRobot & "');")
        'ConfigTableAdapter.UpdateQueryParametri(parametri, "KmAuto") 'pune executed pe "" pentru ca robotul la terminare il va face "Executie cu succes". 
        res = ExecutaSQLRobots("Update Config SET Executed = N'' Where (NumeRobot = '" & NumeRobot & "');")
        'ConfigTableAdapter.UpdateQueryExecute("", "KmAuto") 'pune executed pe "" pentru ca robotul la terminare il va face "Executie cu succes". 
        StartUIPathProcess(ProcessReleaseKey)
        iesire = True
        res = ""
        contor = 0
        Do
            'res = ConfigTableAdapter.ScalarQueryGetExecutedByNumeRobot("KmAuto").ToString
            res = ReturExecutaSqlRobots("Select Executed from Config Where (NumeRobot = '" & NumeRobot & "');")

            contor += 1
            wait(1000)
            txtTimer.Text = returMinuteSiSecundeDinSecunde(NumarMinuteMaximRulareRobot * 60 - contor) & " >> " & res
        Loop While contor < NumarMinuteMaximRulareRobot * 60 And res <> "Executie cu succes" And iesire = True
        If res = "Executie cu succes" Then
            MsgBox("Robotul a terminat in " & contor & " secunde.")

        ElseIf iesire = True Then
            MsgBox("Timp de asteptare depasit. Mai rulati odata robotul sau contactati departamentul IT")
        End If
        iesire = False
        If ReturExecutaSqlRobots("SELECT EmailSend FROM Config WHERE (NumeRobot = '" & NumeRobot & "')") = "True" And steagEmailSend = False Then
            res = ExecutaSQLRobots("Update Config SET EmailSend = 'False' Where (NumeRobot = '" & NumeRobot & "');")
            'ConfigTableAdapter.UpdateQueryEmailSend("False", NumeRobot)
            steagEmailSend = False  'pentru a sterge ulterior, fiindca nu era activa
        End If
        If DoarExecutaVBA = True Then
            'forteaza Necitirea datelor din google si incarcarea masinilor si utilizatorilor pentru a rula doar excel-ul, macro Executa.
            res = ExecutaSQLRobots("Update Config SET ExtrageRapExcelDinBI = 'True', ExtrageRapExcelDinERP = 'True', ExecutaSQL = 'True' Where NumeRobot = '" & NumeRobot & "'")
        End If

        getNumarGreseli(Me, "T") 'greseli totale
        getNumarGreseli(Me, "U") 'greseli pe utilizator
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub cmdEmail_Click(sender As Object, e As EventArgs) Handles cmdEmail.Click, EmailUtilizatoriToolStripMenuItem.Click
        frmEmails.Show()

    End Sub

    Private Sub cmdIesire_Click(sender As Object, e As EventArgs) Handles cmdIesire.Click, cmdIesire1.Click

        Me.Close()
        End

    End Sub

    Private Sub cmdRenuntaLaRulare_Click(sender As Object, e As EventArgs) Handles cmdRenuntaLaRulare.Click
        If iesire = True Then
            txtTimer.Text = "Iesire fortata."
            iesire = False
        End If


    End Sub

    Private Sub cmdGreseli_Click(sender As Object, e As EventArgs) Handles cmdGreseli.Click, GreseliUtilizatoriToolStripMenuItem.Click
        frmGreseliLog.ShowDialog()
        frmGreseliLog.Dispose()

    End Sub

    Private Sub Combustibili_Click(sender As Object, e As EventArgs) Handles Combustibili.Click, CombustibiliToolStripMenuItem.Click
        frmCombustibili.ShowDialog()
        frmCombustibili.Dispose()

    End Sub
    Private Sub cmdcmdFiliale_Click(sender As Object, e As EventArgs) Handles cmdFiliale.Click, ZileLibereToolStripMenuItem.Click
        frmFiliale.ShowDialog()
        frmFiliale.Dispose()

    End Sub


    Private Sub cmdDateExterne_Click(sender As Object, e As EventArgs) Handles cmdDateExterne.Click, OperatiiExterneToolStripMenuItem.Click
        frmDateExterne.ShowDialog()
        frmDateExterne.Dispose()
    End Sub

    Private Sub cmdDeschideSpreadsheet_Click(sender As Object, e As EventArgs) Handles cmdDeschideSpreadsheet.Click
        Dim spreadsheetId As String = cmbSpreadsheets.SelectedValue
        Dim url As String = "https://docs.google.com/spreadsheets/d/" & spreadsheetId
        If tabExists(url).Length > 0 Then
        Else
            Process.Start(url)
        End If

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

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs)
        Try
            cmbSpreadsheets.Text = DataGridView1.CurrentRow.Cells(1).Value

        Catch ex As System.Exception


        End Try
    End Sub

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
        Try
            cmbSpreadsheets.Text = DataGridView2.CurrentRow.Cells(1).Value

        Catch ex As System.Exception


        End Try

    End Sub

    Private Sub cmdSchimbaDataRaportarii_Click(sender As Object, e As EventArgs) Handles cmdSchimbaDataRaportarii.Click
        frmSchimbaDataRaportarii.ShowDialog()
        frmSchimbaDataRaportarii.Dispose()
        If gstrDataRaportariiSchimbata <> "" Then
            lblDataRaportarii.Text = gstrDataRaportariiSchimbata
            gstrDataRaportarii = convertDataAsStringOfFomat(convertStringDataToDate(lblDataRaportarii.Text), "yyyy-MM-dd")
            Dim res As String = ExecutaSQLRobots("Update Config SET DataInterogare = '" & lblDataRaportarii.Text & "' Where NumeRobot = '" & NumeRobot & "'")
            If res = "Ok" Then
                MessageBox.Show("Programul necesita repornire pentru a actualiza data.")
                Me.Close()
                End

            End If
            'cele 4 siruri de mai jos sunt globale
            'AflaDateleDeInceputSfarsitFinal(gstrDataRaportarii, gstrDataInceput, gstrDataSfarsit, gstrDataFinala)

        End If


    End Sub

    Private Sub GoogleFormsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoogleFormsToolStripMenuItem.Click, cmdGoogleForms.Click
        'gestioneaza formurile Google
        'adauga item-uri
        'stabileste descrieri pentru item-uri deja create
        frmGoogleForms.ShowDialog()
        frmGoogleForms.Dispose()

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        IncarcaSheets()
        If ckBoxDeschideKm.Checked = True Then
            frmKmLogView.ShowDialog()
            frmKmLogView.Dispose()
        End If

    End Sub

    Private Sub cmdGoogleSheets_Click(sender As Object, e As EventArgs) Handles GoogleSheetsToolStripMenuItem.Click, cmdGoogleSheets.Click

        frmGoogleSheets.ShowDialog()
        frmGoogleSheets.Dispose()

    End Sub

    Private Sub cmbIncarcaKmLog_Click(sender As Object, e As EventArgs) Handles IncarcaKmLogToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Atentie. Se vor incarca datele din foile Google'. Continuati?", "Km Auto", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ScrieKmLog()
        End If
    End Sub
    Sub ScrieKmLog()
        Dim gsh As New GoogleSheetsHelper
        pbIncarca.Maximum = lvSheets.Items.Count
        Me.Cursor = Cursors.WaitCursor
        pbIncarca.Value = 0
        ExecutaSQLKmAuto("Delete from KmLog")
        For Each lv As ListViewItem In lvSheets.Items
            pbIncarca.Value += 1
            lv.Selected = True
            Dim sheetName As String = ReturExecutaSqlKmAuto("Select Foaie from Spreadsheets Where Nume = '" & lv.Text & "' and activ = 'Da' and foaie = N'' and sheetid = N''")
            Dim myList As IList(Of IList(Of Object)) = gsh.GetRowsList(lv.SubItems(3).Text, sheetName)
            Dim sprId As String = lv.SubItems(3).Text
            WriteKmLog(myList, sprId)
        Next
        Me.Cursor = Cursors.Default
        pbIncarca.Value = 0
        MessageBox.Show("Terminat")

    End Sub

    Private Sub cmdProceseazaLocal_Click(sender As Object, e As EventArgs) Handles ProceseazaLocalToolStripMenuItem.Click, cmdProceseazaLocal.Click
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


    Private Sub UtilizatoriInexistentiToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles UtilizatoriInexistentiToolStripMenuItem.Click
        frmUtilizatoriInexistenti.ShowDialog()
        frmUtilizatoriInexistenti.Dispose()

    End Sub

    Private Sub MasiniInexistenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasiniInexistenteToolStripMenuItem.Click
        frmMasiniInexistente.ShowDialog()
        frmMasiniInexistente.Dispose()

    End Sub

    Private Sub cmdJurnal_Click(sender As Object, e As EventArgs) Handles cmdJurnal.Click
        frmJurnal.ShowDialog()
        frmJurnal.Dispose()

    End Sub

    Private Sub cmdOperatiiBulk_Click(sender As Object, e As EventArgs)
        frmBulk.ShowDialog()
        frmBulk.Dispose()
    End Sub

    Private Sub cmdDeschideProcesator_Click(sender As Object, e As EventArgs) Handles cmdDeschideProcesator.Click
        System.Diagnostics.Process.Start("excel.exe", AppPath & "output\procesator.xlsm")

    End Sub

    Private Sub cmdDeschideRaportCurent_Click(sender As Object, e As EventArgs) Handles cmdDeschideRaportCurent.Click
        System.Diagnostics.Process.Start("excel.exe", """" & AppPath & "output\" & gstrDataRaportarii & "\KmAuto - " & gstrDataRaportarii & ".xlsm""")


    End Sub

    Private Sub cmdOperatiiBulk_Click_1(sender As Object, e As EventArgs) Handles cmdOperatiiBulk.Click
        frmBulk.ShowDialog()
        frmBulk.Dispose()

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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmTest.ShowDialog()
        frmTest.Dispose()

    End Sub
End Class