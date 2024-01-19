Option Explicit On
Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
'Imports Microsoft.Office.Interop
'Imports Microsoft.Office.Interop.Excel


Public Class frmPrincipal
    Dim steag As Boolean = False
    Dim iesire As Boolean = False
    'Dim myEx As New Excel.Application

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

    Private Sub cmdExecuta_Click(sender As Object, e As EventArgs) Handles cmdExecuta.Click
        Dim res As String, contor As Long
        Dim result As DialogResult = MessageBox.Show("Atentie. Se va rula robotul 'Km Auto' de pe serverul 'UiPath Robots'.", "Km Auto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            If ReturDataTable(RobotsCmd, "SELECT EmailSend FROM Config WHERE (NumeRobot = '" & NumeRobot & "')").Rows(0)(0) = "False" And steag = False Then
                ConfigTableAdapter.UpdateQueryEmailSend("True", NumeRobot)
                steag = True 'pentru a sterge ulterior, fiindca nu era activa
            End If
            ConfigTableAdapter.UpdateQueryExecute("", "KmAuto") 'pune executed pe "" pentru ca robotul la terminare il va face "Executie cu succes". 
            StartUIPathProcess(ProcessReleaseKey)
            iesire = True
            res = ""
            contor = 0
            Do
                res = ConfigTableAdapter.ScalarQueryGetExecutedByNumeRobot("KmAuto").ToString

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
            If ReturDataTable(RobotsCmd, "SELECT EmailSend FROM Config WHERE (NumeRobot = '" & NumeRobot & "')").Rows(0)(0) = "True" And steag = False Then
                ConfigTableAdapter.UpdateQueryEmailSend("False", NumeRobot)
                steag = False  'pentru a sterge ulterior, fiindca nu era activa
            End If

            Me.Cursor = Cursors.Default
            getNumarGreseli(Me, "T") 'greseli totale
            getNumarGreseli(Me, "U") 'greseli pe utilizator
        End If
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KmAutoDataSet.GreseliLog' table. You can move, or remove it, as needed.
        Me.GreseliLogTableAdapter.Fill(Me.KmAutoDataSet.GreseliLog)
        NumeRobot = "KmAuto"
        Me.ConfigTableAdapter.FillByNumeRobot(Me.RobotsDataSet.Config, NumeRobot)
        Try
            MkDir(AppPath & "scripts")
        Catch ex As Exception

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

        Catch ex As Exception

        End Try
        Me.Text = Me.Text & " " & SystemInformation.UserName
        IncarcaDimensiuniSiPozitie(Me, 691, 264, 613, 334)

        Try
            dtpDataRaportarii.Value = ConfigTableAdapter.ScalarQueryGetDataInterogare(NumeRobot)

        Catch ex As Exception

        End Try
        EmailSendCheckBox.Checked = ReturDataTable(RobotsCmd, "SELECT EmailSend FROM Config WHERE (NumeRobot = '" & NumeRobot & "')").Rows(0)(0)
        ExtrageRapExcelDinBICheckBox.Checked = ReturDataTable(RobotsCmd, "SELECT ExtrageRapExcelDinBI FROM Config WHERE (NumeRobot = '" & NumeRobot & "')").Rows(0)(0)
        ExtrageRapExcelDinERPCheckBox.Checked = ReturDataTable(RobotsCmd, "SELECT ExtrageRapExcelDinERP FROM Config WHERE (NumeRobot = '" & NumeRobot & "')").Rows(0)(0)
        ExecutaSQLCheckBox.Checked = ReturDataTable(RobotsCmd, "SELECT ExecutaSQL FROM Config WHERE (NumeRobot = '" & NumeRobot & "')").Rows(0)(0)
        NumarLuniActualizateTextBox.Text = ReturDataTable(RobotsCmd, "SELECT NumarLuniActualizate FROM Config WHERE (NumeRobot = '" & NumeRobot & "')").Rows(0)(0)
        EmailToTextBox.Text = ReturDataTable(RobotsCmd, "SELECT EmailTo FROM Config WHERE (NumeRobot = '" & NumeRobot & "')").Rows(0)(0)
        EmailMeTextBox.Text = ReturDataTable(RobotsCmd, "SELECT EmailMe FROM Config WHERE (NumeRobot = '" & NumeRobot & "')").Rows(0)(0)
        ImpartePeFilialeCheckBox.Checked = ReturDataTable(RobotsCmd, "SELECT ImpartePeFiliale FROM Config WHERE (NumeRobot = '" & NumeRobot & "')").Rows(0)(0)
        ImpartePeAgentiCheckBox.Checked = ReturDataTable(RobotsCmd, "SELECT ImpartePeAgenti FROM Config WHERE (NumeRobot = '" & NumeRobot & "')").Rows(0)(0)
        getNumarGreseli(Me, "T") 'greseli totale
        getNumarGreseli(Me, "U") 'greseli pe utilizator
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpDataRaportarii.ValueChanged
        ConfigTableAdapter.UpdateQueryDataInterogare(Format(dtpDataRaportarii.Value, "yyyy-MM-dd"), NumeRobot)

    End Sub


    Private Sub cmdVizualizareMasini_Click(sender As Object, e As EventArgs) Handles cmdVizualizareMasini.Click
        frmMasini.ShowDialog()
        frmMasini.Dispose()
    End Sub

    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)
        ConfigTableAdapter.UpdateQueryImpartePeFiliale(False)
        ConfigTableAdapter.UpdateQueryImpartePeAgenti(False)

    End Sub

    Private Sub cmdVizualizareUtilizatori_Click(sender As Object, e As EventArgs) Handles cmdVizualizareUtilizatori.Click
        frmUtilizatori.ShowDialog()
        frmUtilizatori.Dispose()
    End Sub

    Private Sub cmdVizualizareKmLogView_Click(sender As Object, e As EventArgs) Handles cmdVizualizareKmLogView.Click
        frmKmLogView.ShowDialog()
        frmKmLogView.Dispose()
    End Sub

    Private Sub cmdVizualizareUtilizatoriInexistenti_Click(sender As Object, e As EventArgs) Handles cmdVizualizareUtilizatoriInexistenti.Click
        frmUtilizatoriInexistenti.ShowDialog()
        frmUtilizatoriInexistenti.Dispose()

    End Sub

    Private Sub cmdVizualizareMasiniInexistente_Click(sender As Object, e As EventArgs) Handles cmdVizualizareMasiniInexistente.Click
        frmMasiniInexistente.ShowDialog()
        frmMasiniInexistente.Dispose()
    End Sub

    Private Sub cmdVizualizareZileLibere_Click(sender As Object, e As EventArgs) Handles cmdVizualizareZileLibere.Click
        frmZileLibere.ShowDialog()
        frmZileLibere.Dispose()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdRenunta.Click
        If iesire = True Then
            txtTimer.Text = "Iesire fortata."
            iesire = False
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        cmdRenunta.Visible = iesire
        cmdExecuta.Enabled = Not iesire
    End Sub

    Private Sub cmdGreseliUtilizatori_Click(sender As Object, e As EventArgs) Handles cmdGreseliUtilizatori.Click
        frmGreseliLog.ShowDialog()
        frmGreseliLog.Dispose()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim s As String = ReturQueryInterval()
        'Stop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        End

    End Sub



    Private Sub ImpartePeFilialeCheckBox_MouseUp(sender As Object, e As MouseEventArgs) Handles ImpartePeFilialeCheckBox.MouseUp
        ConfigTableAdapter.UpdateQueryImpartePeFiliale(ImpartePeFilialeCheckBox.Checked)

    End Sub

    Private Sub ImpartePeAgentiCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ImpartePeAgentiCheckBox.CheckedChanged
        ConfigTableAdapter.UpdateQueryImpartePeAgenti(ImpartePeAgentiCheckBox.Checked)

    End Sub
End Class