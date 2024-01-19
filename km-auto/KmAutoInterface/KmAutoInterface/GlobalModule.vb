Imports Microsoft.Win32
Imports System.Text.RegularExpressions
'Imports Google.Apis.Sheets.v4
'Imports Google.Apis.Sheets.v4.Data
'Imports Google.Apis.Sheets.v4.SheetsService

'Imports Microsoft.SqlServer
Imports System.IO
Imports System.Threading
Imports System.Web
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Sheets.v4
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Outlook
Imports Google.Apis.Forms.v1.Data

Module GlobalModule
    Public AppName As String = "KmAutoInterface"
    Public AppPath As String = "C:\Consolight_RPA\Robots\km-auto\"
    Public MailSender As String = "Petrica Ilie - Administrator imobile si parc auto, Vicentiu Mincior - Programator compartimentul IT"
    Public NumeRobot As String = "KmAuto"
    Public NumarMinuteMaximRulareRobot As Long = 10
    Public Const ME_MIN_WIDHT As Long = 300
    Public Const ME_MAX_WIDHT As Long = 300D
    Public gstrDataRaportariiSchimbata, gstrDataRaportarii, gstrDataInceput, gstrDataSfarsit, gstrDataFinala As String

    Public kmAutoConnectionString = "Data Source=10.0.0.10;Initial Catalog=KmAuto;Persist Security Info=True;User ID=sa;Password=P@ssword"
    Public kmAutoSqlCon As New SqlClient.SqlConnection
    Public kmAutoCmd As New SqlClient.SqlCommand

    Public RobotsConnectionString = "Data Source=10.0.0.10;Initial Catalog=Robots;Persist Security Info=True;User ID=sa;Password=P@ssword"
    Public RobotsSqlCon As New SqlClient.SqlConnection
    Public RobotsCmd As New SqlClient.SqlCommand

    Public XUIPathTenantName As String = "DefaultTenant"
    Public AuthorizationBearer As String = "2AUSWcRsUVKMQu9JshNRLVT1YQDjDpMi9M6s40vq"
    Public Cookie As String = "__cf_bm=n6XTJFtEp4gfY2jOjhw25Z_Md2BhdRLM1jU4qhebCGQ-1662364053-0-AdSyasgplagjjWYj8rMZpFnIPsciyImIH4MkCS7UR135BZNTlZRSU6SGD3Nk8Tdkklc2rEaCR5qOQIhN4Jc6q1o=; did=s%3Av0%3Acb651640-2aaa-11ed-bc38-f9a3399d19ef.9fV2kd8BlhIpBOxZEDkatIAzvc1jFxhLGUASpPjuL8o; did_compat=s%3Av0%3Acb651640-2aaa-11ed-bc38-f9a3399d19ef.9fV2kd8BlhIpBOxZEDkatIAzvc1jFxhLGUASpPjuL8o"
    Public ClientId As String = "8DEv1AMNXczW3y4U15LL3jYf62jK93n5"
    Public RefreshToken As String = "lSjKVd06HhqjHRBlTlOv7h-_2bf17hCOQc-8oAS1dxiJx"
    Public ProcessReleaseKey As String = "1d3891b1-3bce-47a8-815f-c5b5a5884199"
    Public UiPathOrganizationId As String = "uipathrobots"
    Public UiPathOrganizationUnitProcessID As String = "3104132"
    Public myEx As New Excel.Application

    Public gstrSearch As String = "" 'este transmis ca parametru de cautare pentru un formular. La inchiderea formularului se reseteaza
    Public gstrSearchSecond As String = "" 'este transmis ca al doilea parametru de cautare pentru un formular. La inchiderea formularului se reseteaza
    Public memClip As String = "" 'pentru a face cautari automate cand se copie ceva in clipboard
    Public Function WriteKmLog(myList As IList(Of IList(Of Object)), sprId As String) As Boolean
        WriteKmLog = True
        Dim i As Integer
        Dim k As Integer
        Dim Spreadsheet_id As Integer = ReturExecutaSqlKmAuto("Select Id from Spreadsheets Where SpreadsheetId ='" & sprId & "'")
        If Spreadsheet_id > 0 Then
            Dim foaie As String = ReturExecutaSqlKmAuto("Select Nume from Spreadsheets Where SpreadsheetId ='" & sprId & "'")
            Dim capDetabel As New List(Of String) From {"Timestamp", "Masina", "Utilizator", "KM", "STATUS", "Poza din bord", "Data si ora citirii kilometrajului", "Email Address", "Asumat", "Observatii", "Km modificat", "Status modificat"}
            For k = 0 To capDetabel.Count - 1
                If myList(0)(k) <> capDetabel(k) Then
                    MessageBox.Show("Eroare in foaia Google '" & foaie & "'. Nu corespunde capul de tabel, coloana '" & capDetabel(k) & "' este '" & myList(0)(k) & "'")
                    WriteKmLog = False
                    Exit Function
                End If
            Next
            For k = 1 To myList.Count - 1
                Dim Data As DateTime = DateSerial(1900, 1, 1),
                MasinaId As Integer,
                    UtilizatorId As Integer,
                    Km As Integer,
                    PozaDinBord As String = "",
                    Status As String = "",
                    DataSiOraCitirii As String = "",
                    Observatii As String = "",
                    Asumat As String = "",
                    KmModificat As String = "",
                    StatusModificat As String = ""
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
                MasinaId = ReturExecutaSqlKmAuto("Select Id from Masini Where Numar ='" & myList(k)(1) & "'")
                UtilizatorId = ReturExecutaSqlKmAuto("Select Id from Utilizatori Where Nume ='" & myList(k)(2) & "'")
                If IsNumeric(myList(k)(3)) Then
                    Km = myList(k)(3)
                Else
                    Km = -1
                End If
                Status = myList(k)(4)
                PozaDinBord = myList(k)(5)

                DataSiOraCitirii = myList(k)(6)
                Asumat = myList(k)(8)
                Observatii = myList(k)(9)
                KmModificat = myList(k)(10)
                StatusModificat = myList(k)(11)

                Dim Sql As String = "INSERT INTO KmLog (
                        Data, 
                        MasinaId, 
                        UtilizatorId, 
                        Km, 
                        PozaDinBord, 
                        Status, 
                        Spreadsheets_id, 
                        DataSiOraCitirii, 
                        Observatii, 
                        Asumat, 
                        KmModificat, 
                        StatusModificat
                    ) VALUES (
                        '" & Data & "', 
                        " & MasinaId & ", 
                        " & UtilizatorId & ", 
                        " & Km & ", 
                        '" & PozaDinBord & "', 
                        '" & Status & "', 
                        " & Spreadsheet_id & ", 
                        '" & DataSiOraCitirii & "', 
                        '" & Observatii & "', 
                        '" & Asumat & "', 
                        '" & KmModificat & "', 
                        '" & StatusModificat & "'); "
                Sql = clearSql(Sql)
                Dim succes As String = ExecutaSQLKmAuto(Sql)
            Next
        End If
    End Function
    Public Function returIntervalCurent(d As Date, intervaleDataTable As System.Data.DataTable) As String
        returIntervalCurent = "Eroare"
        'returneaza intervalul curent pornind de la o data
        Dim d1 As Date, d2 As Date
        For Each row As System.Data.DataRow In intervaleDataTable.Rows
            d1 = row("DataInceput")
            d2 = row("DataSfarsit")
            If d >= d1 And d <= d2 Then
                returIntervalCurent = row("Interval")
                Exit For
            End If
        Next
    End Function
    Public Function RegexShowMatch(ByVal text As String, ByVal expr As String) As Boolean
        If text = "" Then
            RegexShowMatch = True
            Exit Function
        End If
        Console.WriteLine("The Expression: " + expr)
        Dim mc As MatchCollection = Regex.Matches(text, expr)
        RegexShowMatch = mc.Count
    End Function
    Public Function GetDatesFromInterval(interval As String) As List(Of Date)
        Dim myList As New List(Of Date)
        Dim dataInceput As Date = ReturExecutaSqlKmAuto("Select DataInceput from Intervale Where Interval = '" & interval & "' and DataRaportarii ='" & gstrDataRaportarii & "';")
        Dim dataSfarsit As Date = ReturExecutaSqlKmAuto("Select DataSfarsit from Intervale Where Interval = '" & interval & "' and DataRaportarii ='" & gstrDataRaportarii & "';")
        Dim dataFinala As Date = ReturExecutaSqlKmAuto("Select DataFinala from Intervale Where Interval = '" & interval & "' and DataRaportarii ='" & gstrDataRaportarii & "';")
        myList.Add(dataInceput)
        myList.Add(dataSfarsit)
        myList.Add(dataFinala)
        Return myList
    End Function


    Public Sub IncarcaDimensiuniSiPozitie(frm As System.Windows.Forms.Form, xMin As Long, yMin As Long, wMin As Long, hMin As Long)
        Dim x As Long = GetSetting(AppName, "Settings", "X" & frm.Name, xMin)
        Dim y As Long = GetSetting(AppName, "Settings", "Y" & frm.Name, yMin)
        frm.Location = New System.Drawing.Point(x, y)
        If x < 0 Or y < 0 Then
            frm.Location = New System.Drawing.Point(xMin, yMin)
        End If
        Dim w As Long = GetSetting(AppName, "Settings", "W" & frm.Name, wMin)
        Dim h As Long = GetSetting(AppName, "Settings", "H" & frm.Name, hMin)
        frm.Size = New System.Drawing.Point(w, h)
        If w < 300 Or h < 300 Then
            frm.Size = New System.Drawing.Point(wMin, hMin)
        End If
        'incarca latimea coloanelor la toate controalele de tip grid
        GetAllControls(frm, GetType(DataGridView)).ToList.ForEach(
           Sub(c As DataGridView)
               'Console.WriteLine("{0}.{1}", c.Parent.Name, Me.name & "-" & c.Name)
               For Each col As DataGridViewColumn In c.Columns
                   col.Width = GetSetting(AppName, "Settings", frm.Name & "-" & c.Name & col.Index & "_width", 100)

               Next

           End Sub)
        'incarca latimea coloanelor la toate controalele de tip listview
        GetAllControls(frm, GetType(ListView)).ToList.ForEach(
           Sub(c As ListView)
               For Each col In c.Columns
                   col.Width = GetSetting(AppName, "Settings", frm.Name & "-" & c.Name & col.Index & "_width", 100)

               Next

           End Sub)
        'incarca checkbox-urile cu greseli
        GetAllControls(frm, GetType(CheckBox)).ToList.ForEach(
           Sub(c As System.Windows.Forms.CheckBox)
               If Strings.Left(c.Name, 5) = "check" Then
                   c.Checked = GetSetting(AppName, "Settings", "checkBoxes" & c.Name, False)
               End If
           End Sub)
        'incarca alte checkbox-uri
        GetAllControls(frm, GetType(System.Windows.Forms.CheckBox)).ToList.ForEach(
           Sub(c As System.Windows.Forms.CheckBox)
               If Strings.Left(c.Name, 2) = "ck" Then
                   c.Checked = GetSetting(AppName, "Settings", "checkBoxesAltele" & c.Name, False)
               End If
           End Sub)
    End Sub
    Public Sub SalveazaDimensiuniSiPozitie(frm As System.Windows.Forms.Form)
        SaveSetting(AppName, "Settings", "X" & frm.Name, frm.Location.X)
        SaveSetting(AppName, "Settings", "Y" & frm.Name, frm.Location.Y)
        SaveSetting(AppName, "Settings", "H" & frm.Name, frm.Size.Height)
        SaveSetting(AppName, "Settings", "W" & frm.Name, frm.Size.Width)

        'salveaza latimea coloanelor la controalele de tip datagridview
        GetAllControls(frm, GetType(DataGridView)).ToList.ForEach(
           Sub(c As DataGridView)
               For Each col As DataGridViewColumn In c.Columns
                   SaveSetting(AppName, "Settings", frm.Name & "-" & c.Name & col.Index & "_width", col.Width)

               Next

           End Sub)

        'salveaza latimea coloanelor la toate controalele de tip listview
        GetAllControls(frm, GetType(ListView)).ToList.ForEach(
           Sub(c As ListView)
               For Each col In c.Columns
                   SaveSetting(AppName, "Settings", frm.Name & "-" & c.Name & col.Index & "_width", col.Width)

               Next

           End Sub)
        'incarca alte checkbox-uri
        GetAllControls(frm, GetType(System.Windows.Forms.CheckBox)).ToList.ForEach(
           Sub(c As System.Windows.Forms.CheckBox)
               If Strings.Left(c.Name, 2) = "ck" Then
                   SaveSetting(AppName, "Settings", "checkBoxesAltele" & c.Name, c.Checked)
               End If
           End Sub)

    End Sub
    Public Function ScrieCelulaInGoogle(data As String, masina As String, utilizator As String, SpreadsheetId As String, sheetName As String, cell As DataGridViewCell, numarColoana As Integer, Optional dataDouble As Double = 0) As String
        Dim gsh As New GoogleSheetsHelper, res As String
        'scrie si in googlesheet
        'trebuie sa incarce tot sheet-ul in memorie
        ScrieCelulaInGoogle = "Incercare modificare"
        Dim myList As List(Of IList(Of Object)) = gsh.GetRowsList(SpreadsheetId, sheetName)
        Dim k As Long
        For k = 1 To myList.Count - 1
            If myList(k)(1) = masina Then
                If myList(k)(2) = utilizator Then
                    If myList(k).Count > 6 AndAlso myList(k)(6).ToString <> "" Then
                        Dim myD As String = prelDataToString(myList(k)(6))
                        If myD = data Then
                            Dim ls As New List(Of IList(Of Object)), lss As New List(Of Object)
                            If cell.Value Is Nothing Then
                                res = gsh.ClearCell(SpreadsheetId, sheetName, numarColoana, k + 1)
                                ScrieCelulaInGoogle = res

                            Else
                                lss.Add(If(dataDouble <> 0, dataDouble, cell.Value))
                                ls.Add(lss)
                                res = gsh.UpdateCell(SpreadsheetId, sheetName, ls, k, numarColoana)
                                ScrieCelulaInGoogle = res

                            End If
                            Exit For
                        End If
                    Else
                        Dim myD As String = prelDataToString(myList(k)(0))
                        If myD = data Then
                            Dim ls As New List(Of IList(Of Object)), lss As New List(Of Object)
                            If cell.Value Is Nothing Then
                                res = gsh.ClearCell(SpreadsheetId, sheetName, numarColoana, k + 1)
                                ScrieCelulaInGoogle = res

                            Else
                                lss.Add(If(dataDouble <> 0, dataDouble, cell.Value))
                                ls.Add(lss)
                                res = gsh.UpdateCell(SpreadsheetId, sheetName, ls, k, numarColoana)
                                ScrieCelulaInGoogle = res

                            End If
                            Exit For
                        End If
                    End If
                End If
            End If
        Next
        'status ok = "Succes modificare."

    End Function

    Public Function StergeRandInGoogle(masina As String, utilizator As String, SpreadsheetId As String, sheetName As String, sheetId As String, data As Double, Optional dataSiOraCitirii As Double = 0) As String
        Dim gsh As New GoogleSheetsHelper, res As String
        'scrie si in googlesheet
        'trebuie sa incarce tot sheet-ul in memorie
        StergeRandInGoogle = "Eroare"
        Dim myList As List(Of IList(Of Object)) = gsh.GetRowsList(SpreadsheetId, sheetName)
        Dim k As Long
        For k = 1 To myList.Count - 1
            If myList(k)(1) = masina Then
                If myList(k)(2) = utilizator Then
                    Try
                        If myList(k).Count > 6 AndAlso myList(k)(6).ToString <> "" Then
                            If CDate(myList(k)(6)).ToOADate = data Then
                                'modifica
                                res = gsh.DeleteRows(SpreadsheetId, sheetId, k, k)
                                StergeRandInGoogle = res
                                'Stop
                            End If
                        Else
                            If CDate(myList(k)(0)).ToOADate = data Then
                                res = gsh.DeleteRows(SpreadsheetId, sheetId, k, k)
                                StergeRandInGoogle = res
                            End If
                        End If
                        If dataSiOraCitirii > 0 Then
                            If myList(k).Count > 6 AndAlso myList(k)(6).ToString <> "" Then
                                If CDate(myList(k)(6)).ToOADate = dataSiOraCitirii Then
                                    'modifica
                                    res = gsh.DeleteRows(SpreadsheetId, sheetId, k, k)
                                    StergeRandInGoogle = res
                                    'Stop
                                End If
                            Else
                                If CDate(myList(k)(0)).ToOADate = dataSiOraCitirii Then
                                    res = gsh.DeleteRows(SpreadsheetId, sheetId, k, k)
                                    StergeRandInGoogle = res
                                End If
                            End If

                        End If
                    Catch ex As System.Exception
                        Stop
                    End Try
                End If
            End If
        Next

    End Function



    Private Function prelDataToString(data As String) As String
        'verifica daca data vine in format corect, intoarce acceasi data, daca nu face corectia
        Dim s As String = data
        Dim v(), vv(), vvv() As String
        If data.Contains("/") Then
            'formatul este MM-dd-yyyy HH:mm:ss
            v = Split(data, " ")
            vv = Split(v(0), "/")
            vvv = Split(v(1), ":")
            prelDataToString = vv(2) & "-" & leadZero(vv(0), 2) & "-" & leadZero(vv(1), 2) & " " & leadZero(vvv(0), 2) & ":" & leadZero(vvv(1), 2) & ":" & leadZero(vvv(2), 2)
        Else
            'formatul este yyyy-MM-dd HH:mm:ss
            prelDataToString = data
        End If

    End Function



    Public Function GetAllControls(ByVal sender As Control, ByVal T As Type) As IEnumerable(Of Control)
        Dim controls = sender.Controls.Cast(Of Control)()
        Dim mm As IEnumerable(Of Control) = controls.SelectMany(
            Function(ctrl) GetAllControls(ctrl, T)).Concat(controls).Where(
            Function(c) c.GetType() Is T)
        Return mm
    End Function

    Public Function ExecutaSQLKmAuto(Sql As String) As String
        ExecutaSQLKmAuto = Nothing
        Try
            Dim cmd As SqlClient.SqlCommand = kmAutoCmd
            ExecutaSQLKmAuto = ExecutaSQL(cmd, Sql)
        Catch ex As System.Exception

        End Try

    End Function
    Public Function ExecutaSQLRobots(Sql As String) As String
        ExecutaSQLRobots = Nothing
        Try
            Dim cmd As SqlClient.SqlCommand = RobotsCmd
            ExecutaSQLRobots = ExecutaSQL(cmd, Sql)
        Catch ex As System.Exception

        End Try

    End Function
    Private Function ExecutaSQL(cmd As SqlClient.SqlCommand, Sql As String) As String
        Try
            Dim ds As New DataSet
            cmd.CommandText = Sql
            Dim oDataAdapter As New SqlClient.SqlDataAdapter(cmd)
            oDataAdapter.Fill(ds)
            ExecutaSQL = "Ok"
        Catch ex As System.Exception
            ExecutaSQL = ex.Message
            'Stop
        End Try

    End Function
    Public Function ReturExecutaSqlKmAuto(sql As String) As Object
        ReturExecutaSqlKmAuto = Nothing
        Try
            Dim cmd As SqlClient.SqlCommand = kmAutoCmd
            ReturExecutaSqlKmAuto = ReturExecutaSql(cmd, sql)
        Catch ex As System.Exception

        End Try

    End Function
    Public Function ReturExecutaSqlRobots(sql As String) As Object
        ReturExecutaSqlRobots = Nothing
        Try
            Dim cmd As SqlClient.SqlCommand = RobotsCmd
            ReturExecutaSqlRobots = ReturExecutaSql(cmd, sql)
        Catch ex As System.Exception

        End Try

    End Function
    Private Function ReturExecutaSql(cmd As SqlClient.SqlCommand, sql As String) As Object
        'returneaza o singura valoare dintr-un tabel sql
        ReturExecutaSql = Nothing
        Try
            Dim ds As New DataSet
            cmd.CommandText = sql
            Dim oDataAdapter As New SqlClient.SqlDataAdapter(cmd)
            oDataAdapter.Fill(ds)
            ReturExecutaSql = ds.Tables(0).Rows(0)(0)
            Exit Function
        Catch ex As System.Exception

        End Try

    End Function

    Public Function ReturDataTableKmAuto(Sql As String) As System.Data.DataTable
        ReturDataTableKmAuto = New System.Data.DataTable
        Try
            Dim cmd As SqlClient.SqlCommand = kmAutoCmd
            ReturDataTableKmAuto = ReturDataTable(cmd, Sql)
        Catch ex As System.Exception

        End Try


    End Function
    Public Function ReturDataTableRobots(Sql As String) As System.Data.DataTable
        ReturDataTableRobots = New System.Data.DataTable
        Try
            Dim cmd As SqlClient.SqlCommand = RobotsCmd
            ReturDataTableRobots = ReturDataTable(cmd, Sql)
        Catch ex As System.Exception

        End Try


    End Function
    Private Function ReturDataTable(cmd As SqlClient.SqlCommand, Sql As String) As System.Data.DataTable
        Try
            Dim ds As New DataSet
            cmd.CommandText = Sql
            Dim oDataAdapter As New SqlClient.SqlDataAdapter(cmd)
            oDataAdapter.Fill(ds)
            ReturDataTable = ds.Tables(0)
            Exit Function
        Catch ex As System.Exception

            Stop
        End Try
        ReturDataTable = New System.Data.DataTable

    End Function


    Public Sub WaitForExecute(fileName As String, arguments As String)
        'SystemInformation.UserName
        Dim proc = New Process With {
            .StartInfo = New ProcessStartInfo With {
            .FileName = fileName,
                    .Arguments = arguments,
                    .UseShellExecute = False,
                    .RedirectStandardError = True,
                    .CreateNoWindow = True
                    }
            }
        proc.Start()
        proc.WaitForExit()
        Dim sStdErr As String = proc.StandardError.ReadToEnd()

    End Sub
    Public Sub wait(ByVal interval As Integer)
        'interval = miliseconds
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            System.Windows.Forms.Application.DoEvents()
        Loop
        sw.Stop()
    End Sub
    Public Function returMinuteSiSecundeDinSecunde(sec As Long) As String
        Dim minute As Long, secunde As Long
        minute = Math.Floor(sec / 60)
        secunde = sec Mod 60
        returMinuteSiSecundeDinSecunde = leadZero(minute, 2) & ":" & leadZero(secunde, 2)
    End Function
    Private Function leadZero(s As String, nr As Long)
        Dim k As Long
        For k = 1 To nr - Len(s)
            s = "0" & s
        Next k
        leadZero = s
    End Function
    Public Sub stergeToateLabelurile(frm As System.Windows.Forms.Form, criteriu As String)
        GetAllControls(frm, GetType(System.Windows.Forms.Label)).ToList.ForEach(
           Sub(c As System.Windows.Forms.Label)
               If c.Name.Substring(0, 3) = "lbl" And c.Name.Substring(c.Name.Length - 1, 1) = criteriu Then
                   c.Text = "0"
               End If
           End Sub)

    End Sub
    Public Sub getNumarGreseli(frm As System.Windows.Forms.Form, Criteriu As String, Optional dictGreseli As Dictionary(Of String, Long) = Nothing, Optional dictGreseliPeUtilizatori As Dictionary(Of String, Dictionary(Of String, Long)) = Nothing)
        'afiseaza numarul total de greseli sau numarul de utilizatori care au gresit pe fiecare tip de greseala in label-uri care au numele hardcodat,
        'de forma lbl[tip greseala cu cuvinte legate si litera mare la inceput][T pentru total sau U pentru utilizator]

        'e nevoie de un table adapter nou
        Dim myTableAdapter As New KmAutoDataSetTableAdapters.GreseliLogTableAdapter
        GetAllControls(frm, GetType(System.Windows.Forms.Label)).ToList.ForEach('itereaza toate controalele de tip label
           Sub(c As System.Windows.Forms.Label)
               Dim nume As String, numeNou As String = "", toAdd As String = "", k As Long = 0
               'obtinem numele greselii din tabelul Greseli din numele label-ului pentru a obtine numarul de greseli din fiecare tip
               'itereaza toate label-urile al caror nume incep cu lbl si se sfarsesc cu T
               If c.Name.Substring(0, 3) = "lbl" And c.Name.Substring(c.Name.Length - 1, 1) = Criteriu Then 'criteriu = T sau U pentru totaluri/utilizatori
                   nume = c.Name.Substring(3, c.Name.Length - 4) 'scoate din fata lbl si de la final T
                   For Each ch As Char In nume 'itereaza fiecare caracter din numele ramas
                       If k = 0 Then
                           toAdd = ch
                       Else
                           If Asc(ch) < 97 Then 'litera mare
                               toAdd = " " & Chr(Asc(ch) + 32) 'face litera mica si-i pune un spatiu in fata
                           Else
                               toAdd = ch
                           End If

                       End If
                       numeNou &= toAdd
                       k += 1
                   Next

                   'numeNou este campul Tip din tabelul Greseli scos din numele label-ului iterat
                   If Not dictGreseli Is Nothing Then
                       If dictGreseli.ContainsKey(numeNou) Then
                           If Criteriu = "T" Then
                               c.Text = dictGreseli(numeNou)
                           ElseIf Criteriu = "U" Then
                               c.Text = dictGreseliPeUtilizatori(numeNou).Count
                           End If
                       Else
                           c.Text = "0"
                       End If
                   Else
                       If Criteriu = "T" Then
                           c.Text = myTableAdapter.ScalarQueryReturNumarGreseliDupaTip(numeNou) 'scrie numarul de greseli pe tipul detectat din nume
                       ElseIf Criteriu = "U" Then
                           c.Text = myTableAdapter.ScalarQueryReturNumarUtilizatoriDupaTip(numeNou) 'scrie numarul de utilizatori pe tipul detectat din nume
                       End If
                   End If
               End If


           End Sub)
    End Sub

    Public Sub AflaDateleDeInceputSfarsitFinal(strDataRaportarii As String, ByRef strDataInceput As String, ByRef strDataSfarsit As String, ByRef strDataFinala As String)
        'ia dataInceput din tabelul Intervale daca au fost setate daca nu creaza o data de inceput fictiva pentru a putea crea intervalele
        'Atentie. strDataInceput, strDataSfarsit, strDataFinala vin prin referinta (ByRef) adica vin goale si pleaca inapoi setate
        Dim dataInceput As Date
        dataInceput = ReturExecutaSqlKmAuto("Select Top(1) DataInceput from Intervale Where DataRaportarii = '" & strDataRaportarii & "' Order By DataInceput")
        strDataInceput = convertDataAsStringOfFomat(dataInceput, "yyyy-MM-dd")
        If strDataInceput = "0001-01-01" Then
            dataInceput = AflaDataInceputLaEroareIntervale(strDataRaportarii)
            strDataInceput = convertDataAsStringOfFomat(dataInceput, "yyyy-MM-dd")
            MessageBox.Show("Nu exista intervale programate pentru luna curenta, sau exista o eroare. Apasati butonul 'Intervale' si setati weekendurile.")
            frmIntervale.ShowDialog()
            frmIntervale.Dispose()
            dataInceput = ReturExecutaSqlKmAuto("Select Top(1) DataInceput from Intervale Where DataRaportarii = '" & strDataRaportarii & "' Order By DataInceput")
            strDataInceput = convertDataAsStringOfFomat(dataInceput, "yyyy-MM-dd")
        End If
        Dim dataSfarsit As Date = ReturExecutaSqlKmAuto("Select Top(1) DataSfarsit from Intervale Where DataRaportarii = '" & strDataRaportarii & "' Order By DataSfarsit desc")
        strDataSfarsit = convertDataAsStringOfFomat(dataSfarsit, "yyyy-MM-dd")
        Dim dataFinala As Date = DateAdd("d", 3, dataSfarsit) 'adauga 3 zile la data de sfarsit pentru a afla data Finala
        strDataFinala = convertDataAsStringOfFomat(dataFinala, "yyyy-MM-dd")

    End Sub
    Private Function AflaDataInceputLaEroareIntervale(strDataRaportarii As String) As Date
        Dim d As Date = convertStringDataToDate(strDataRaportarii)
        d = DateAdd("m", -1, d)
        AflaDataInceputLaEroareIntervale = GetFirstDayOfMonth(d)
    End Function

    'Get the first day of the month
    Public Function GetFirstDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Return New DateTime(sourceDate.Year, sourceDate.Month, 1)
    End Function

    'Get the last day of the month
    Public Function GetLastDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Dim lastDay As DateTime = New DateTime(sourceDate.Year, sourceDate.Month, 1)
        Return lastDay.AddMonths(1).AddDays(-1)
    End Function
    Public Function ReturQueryInterval(intervalComplet As String, Optional primaParte As String = "") As String
        Dim v() As String = Split(intervalComplet, ":")
        If intervalComplet = "Toate" Then
            ReturQueryInterval = " "
        Else
            ReturQueryInterval = " AND (Data >= '" & If(primaParte.Length > 0, primaParte, v(0)) & " 00:00:00') AND (Data <=  '" & v(1) & " 23:59:59') "
        End If
    End Function
    Public Function getRegistrySubKeyNames(section As String) As List(Of String)
        Dim myList As New List(Of String)
        Dim regKey As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\" & section, RegistryKeyPermissionCheck.ReadSubTree)
        Dim subKeys() As String = regKey.GetSubKeyNames
        For Each subkey As String In subKeys
            myList.Add(subkey)
        Next
        getRegistrySubKeyNames = myList

    End Function
    Public Function getRegistryValuePairs(section As String, subKey As String, Optional filterByKeysValue As String = "", Optional yesNo As Boolean = False) As Dictionary(Of String, Long)
        Dim myDict As New Dictionary(Of String, Long)
        Dim regKey As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\" & section & "\" & subKey, RegistryKeyPermissionCheck.ReadSubTree)
        Dim subNames() As String = regKey.GetValueNames
        For Each subName As String In subNames
            Dim val As String = regKey.GetValue(subName)
            If filterByKeysValue <> "" Then
                If yesNo = True Then
                    If subName.Contains(filterByKeysValue) Then
                        myDict.Add(subName, val)

                    End If
                Else
                    If Not subName.Contains(filterByKeysValue) Then
                        myDict.Add(subName, val)

                    End If
                End If
            Else
                myDict.Add(subName, val)
            End If
        Next
        getRegistryValuePairs = myDict

    End Function
    Public Function introduceLiniuteInNumarulDeInmatriculare(numar As String) As String
        If numar Is Nothing Then
            introduceLiniuteInNumarulDeInmatriculare = ""
            Exit Function
        End If


        'numarul masinii primit de la benzinarie nu contine acele liniute ca in baza noastra de date. Aici se introduc inainte si dupa grupul de cifre
        Dim s As String = "", inceputCifre As Boolean = False, sfarsitCifre As Boolean = False
        For Each c As Char In numar
            If IsNumeric(c) Then
                If inceputCifre = False Then
                    s &= "-"
                End If
                inceputCifre = True
            Else
                If inceputCifre = True And sfarsitCifre = False Then
                    s &= "-"
                    sfarsitCifre = True
                End If
            End If
            s &= c
        Next
        introduceLiniuteInNumarulDeInmatriculare = s
    End Function
    Public Function ReturSpreadsheetColumnNameByNumber(Numar As Long) As String
        'returneaza litere ca si adresa de coloana excel
        If Numar = 0 Then
            ReturSpreadsheetColumnNameByNumber = "A"
            Exit Function
        End If
        Dim listNames = New String() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim front As Long = Numar \ 26
        Dim rest As Long = Numar Mod 26
        ReturSpreadsheetColumnNameByNumber = If(front > 0, listNames(front - 1), "") & listNames(rest - 1)
    End Function
    Public Function convertDataAsDotStringReverseToString(stringData As String) As String
        'primeste data in format dd.MM.yyyy HH:mm si o returneaza yyyy-MM-dd HH:mm:ss
        convertDataAsDotStringReverseToString = ""
        Dim v() As String, s As String
        Dim datePart As String, timePart As String
        If stringData = "" Or stringData.Contains(".") = False Then
            Exit Function
        End If
        If stringData.Contains(" ") Then
            v = Split(stringData, " ")
            datePart = v(0)
            timePart = v(1)
        Else
            datePart = stringData
            timePart = ""
        End If

        v = Split(datePart, ".")
        s = v(2) & "-" & leadZero(v(1), 2) & "-" & leadZero(v(0), 2)
        If stringData.Contains(":") Then 'contine si timp
            s &= " " & timePart & ":00" 'aduaga si secundele
        End If
        convertDataAsDotStringReverseToString = s
    End Function
    Public Function convertStringDataToDouble(stringData As String) As Double
        'primeste ca parametru o data in format string (ex. 2022-05-25 23:02:56 sau 2022-05-25) si o face data in format double
        convertStringDataToDouble = 0
        Dim v() As String
        Dim d As Date
        Dim datePart As String, timePart As String
        If stringData = "" Or stringData.Contains("-") = False Then
            Exit Function
        End If

        If stringData.Contains(" ") Then 'contine si time
            v = Split(stringData, " ")
            datePart = v(0)
            timePart = v(1)
        Else
            datePart = stringData
            timePart = ""
        End If

        v = Split(datePart, "-")
        d = DateSerial(v(0), v(1), v(2))
        If stringData.Contains(":") Then
            v = Split(timePart, ":")
            d = DateAdd("h", CInt(v(0)), d)
            d = DateAdd("n", CInt(v(1)), d)
            d = DateAdd("s", CInt(v(2)), d)
        End If
        convertStringDataToDouble = d.ToOADate

    End Function

    Public Function convertStringDataToDate(stringData As String) As Date
        'primeste ca parametru o data in format string (ex. 2022-05-25 23:02:56) si o face data in format data
        If stringData <> "" Then
            Return System.DateTime.FromOADate(convertStringDataToDouble(stringData))
        Else
            Return System.DateTime.Now


        End If
    End Function
    Public Function convertDataAsStringOfFomat(d As Date, format As String) As String
        convertDataAsStringOfFomat = ""
        Dim s As String = d.ToString(format)
        Return s
    End Function
    Public Function RectificaDataRaportarii(d As Date, limitaZiIntreLuni As Long) As Date
        'data raportarii nu poate fi decat o zi de 1 a lunii.
        Dim adaugare As Long
        If DateAndTime.Day(d) >= limitaZiIntreLuni Then
            adaugare = 1
        Else
            adaugare = 0
        End If
        d = DateAdd("m", adaugare, d)
        d = DateSerial(DateAndTime.Year(d), DateAndTime.Month(d), 1)
        RectificaDataRaportarii = d
    End Function

    Public Function formeazaInterval(dataInceput As Date, dataSfarsit As Date) As String
        'formeaza intervalul asa cum apare el in raportul excel
        If DateAndTime.Month(dataInceput) = DateAndTime.Month(dataSfarsit) Then
            Return leadZero(DateAndTime.Day(dataInceput), 2) & " - " & leadZero(DateAndTime.Day(dataSfarsit), 2) & "." & leadZero(DateAndTime.Month(dataInceput), 2)
        Else
            Return leadZero(DateAndTime.Day(dataInceput), 2) & "." & leadZero(DateAndTime.Month(dataInceput), 2) & " - " & leadZero(DateAndTime.Day(dataSfarsit), 2) & "." & leadZero(DateAndTime.Month(dataSfarsit), 2)

        End If
    End Function
    Public Function clearSql(sql As String) As String
        Dim k As Long
        For k = 1 To 100
            sql = sql.Replace(vbCrLf, "")
            sql = sql.Replace("  ", " ")


        Next
        clearSql = sql
    End Function
    Public Function ReturDataComplementara(d As Date, status As String) As Date
        'daca status = Normal pune data sfarsitului de interval ce contine data d, altfel inceputul intervalului
        Dim sql As String
        If status = "Normal" Then
            'caut sfarsitul intervalului
            sql = clearSql("SELECT TOP (1) DataSfarsit " &
                     "FROM dbo.Intervale " &
                     "WHERE (DataSfarsit >= '" & d & "')")
        Else
            'caut inceputul intervalului
            sql = clearSql("SELECT TOP (1) DataInceput " &
                     "FROM dbo.Intervale " &
                     "WHERE (DataInceput <= '" & d & "') " &
                     "ORDER BY DataInceput DESC")
        End If
        d = ReturExecutaSqlKmAuto(sql)
        If status = "Normal" Then
            d = DateAdd("h", 8, d)

        Else
            d = DateAdd("h", 16, d)
        End If
        ReturDataComplementara = d
    End Function
    Public Function SearchAllFolders(ByVal FolderPath As String) As List(Of String)
        SearchAllFolders = New List(Of String) From {}
        Try
            Dim myfiles As String() = IO.Directory.GetFiles(FolderPath, "*.*", IO.SearchOption.AllDirectories)
            For Each str As String In myfiles
                SearchAllFolders.Add(str)
            Next
        Catch ex As System.Exception
            Stop
        End Try

    End Function
    Public Function AdaugaWeekendNul(interval As String, spreadsheetName As String, utilizator As String, masina As String, observatii As String, grid As DataGridView)
        'scoate data de inceput din interval
        AdaugaWeekendNul = ""

        Dim dataInceput As Date = GetDatesFromInterval(interval)(0)

        Dim d As DateTime = New DateTime(DateAndTime.Year(dataInceput), DateAndTime.Month(dataInceput), DateAndTime.Day(dataInceput), DateAndTime.Hour(dataInceput), DateAndTime.Minute(dataInceput), 0, DateTime.Now.Kind)
        Dim km As Long = -1
        Dim status As String = "Referinta"
        Dim gsh As New GoogleSheetsHelper
        Dim spreadsheetId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
        Dim sheetId As String = ReturExecutaSqlKmAuto("Select SheetId from Spreadsheets where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
        If spreadsheetId <> "" And sheetId <> "" Then
            gsh.RemoveFilter(spreadsheetId, sheetId)
            wait(3000)
            Dim ret As String = AdaugaRandInGoogle(d, km, status, spreadsheetName, utilizator, masina, observatii, grid)
            If ret = "Salvat cu succes" Then
                'adauga 10 min la data anterioara
                d = New DateTime(DateAndTime.Year(dataInceput), DateAndTime.Month(dataInceput), DateAndTime.Day(dataInceput), DateAndTime.Hour(dataInceput), DateAndTime.Minute(DateAdd("n", 10, dataInceput)), 0, DateTime.Now.Kind)
                km = -1
                status = "Normal"
                ret = AdaugaRandInGoogle(d, km, status, spreadsheetName, utilizator, masina, observatii, grid)
                If ret = "Salvat cu succes" Then
                    AdaugaWeekendNul = "Adaugare Ok"
                End If
            End If
        End If
    End Function
    Public Function AdaugaRandInGoogle(data As Date, km As Long, status As String, spreadsheetName As String, utilizator As String, masina As String, observatii As String, grid As DataGridView) As String
        AdaugaRandInGoogle = ""
        'adauga un nou rand la foaia google corespunzatoare masinii 
        AdaugaRandInGoogle = ""
        Dim currentDate As Date = DateSerial(DateAndTime.Year(Now), DateAndTime.Month(Now), DateAndTime.Day(Now))
        currentDate = DateAdd("h", DateAndTime.Hour(Now), currentDate)
        currentDate = DateAdd("n", DateAndTime.Minute(Now), currentDate)
        currentDate = DateAdd("s", DateAndTime.Second(Now), currentDate)
        Dim gsh As New GoogleSheetsHelper
        Dim SpreadsheetId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
        Dim sprId As Long = ReturExecutaSqlKmAuto("Select Id from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
        Dim sheetName As String = ReturExecutaSqlKmAuto("Select Foaie from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")
        Dim sheetId As String = ReturExecutaSqlKmAuto("Select SheetId from Spreadsheets Where Nume = '" & spreadsheetName & "' and Activ = 'Da' and 'SheetId' <> N'' and Foaie <> N''")

        Dim myList As New List(Of IList(Of Object)), ls As New List(Of Object) From {currentDate.ToOADate, masina, utilizator, "", "", "", data.ToOADate, "", "Da", observatii, km, status}
        myList.Add(ls)
        Dim retur As String = gsh.AddRows(SpreadsheetId, sheetName, myList)
        If retur = "Adaugare randuri ok" Then
            'scrie in baza de date in kmLog 
            Dim masinaId, utilizatorId As Long
            masinaId = ReturExecutaSqlKmAuto("Select id from Masini Where Numar ='" & masina & "'")
            utilizatorId = ReturExecutaSqlKmAuto("Select id from Utilizatori Where Nume ='" & utilizator & "'")
            Dim ret As String = ExecutaSQLKmAuto("INSERT Into KmLog (Data, MasinaId, UtilizatorId, Spreadsheets_id, DataSiOraCitirii, KmModificat, StatusModificat, Observatii, Asumat) VALUES ('" & data.ToString("yyyy-MM-dd HH:mm:ss") & "', " & masinaId & ", " & utilizatorId & ", " & sprId & ", '" & currentDate & "', " & km & ", '" & status & "',  '" & observatii & "', 'Da');")
            If ret = "Ok" Then
                'adauga in grid
                Dim inputData(11) As String
                inputData(0) = data.ToString("yyyy-MM-dd HH:mm:ss")
                inputData(2) = km
                inputData(5) = status
                inputData(6) = spreadsheetName
                inputData(7) = currentDate.ToString("yyyy-MM-dd HH:mm:ss")
                inputData(8) = observatii
                inputData(9) = "Da" 'asumat
                grid.Rows.Add(inputData)
                AdaugaRandInGoogle = "Salvat cu succes"
            End If
        End If

    End Function

End Module
