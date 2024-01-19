
Imports Microsoft.Win32

Module GlobalModule
    Public AppName As String = "KmAutoInterface"
    Public AppPath As String = "C:\Robots\KmAutoInterface\"
    Public NumeRobot As String
    Public NumarMinuteMaximRulareRobot As Long = 10
    Public Const ME_MIN_WIDHT As Long = 300
    Public Const ME_MAX_WIDHT As Long = 300
    'Public ds As New DataSet
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

    Public Sub IncarcaDimensiuniSiPozitie(frm As Form, xMin As Long, yMin As Long, wMin As Long, hMin As Long)
        Dim x As Long = GetSetting(AppName, "Settings", "X" & frm.Name, xMin)
        Dim y As Long = GetSetting(AppName, "Settings", "Y" & frm.Name, yMin)
        If x < 0 Or y < 0 Then
            frm.Location = New System.Drawing.Point(30, 30)
        End If
        frm.Location = New System.Drawing.Point(x, y)
        Dim w As Long = GetSetting(AppName, "Settings", "W" & frm.Name, wMin)
        Dim h As Long = GetSetting(AppName, "Settings", "H" & frm.Name, hMin)
        If w < 100 Or h < 100 Then
            frm.Size = New System.Drawing.Point(100, 100)
        End If
        frm.Size = New System.Drawing.Point(w, h)
        'incarca latimea coloanelor la toate controalele de tip grid
        GetAllControls(frm, GetType(DataGridView)).ToList.ForEach(
           Sub(c As DataGridView)
               'Console.WriteLine("{0}.{1}", c.Parent.Name, Me.name & "-" & c.Name)
               For Each col As DataGridViewColumn In c.Columns
                   col.Width = GetSetting(AppName, "Settings", frm.Name & "-" & c.Name & col.Index & "_width", 100)

               Next

           End Sub)
        'incarca checkbox-urile cu greseli
        GetAllControls(frm, GetType(CheckBox)).ToList.ForEach(
           Sub(c As CheckBox)
               If Strings.Left(c.Name, 5) = "check" Then
                   c.Checked = GetSetting(AppName, "Settings", "checkBoxes" & c.Name, False)
               End If
           End Sub)
    End Sub
    Public Sub SalveazaDimensiuniSiPozitie(frm As Form)
        SaveSetting(AppName, "Settings", "X" & frm.Name, frm.Location.X)
        SaveSetting(AppName, "Settings", "Y" & frm.Name, frm.Location.Y)
        SaveSetting(AppName, "Settings", "H" & frm.Name, frm.Size.Height)
        SaveSetting(AppName, "Settings", "W" & frm.Name, frm.Size.Width)
        GetAllControls(frm, GetType(DataGridView)).ToList.ForEach(
           Sub(c As DataGridView)
               'Console.WriteLine("{0}.{1}", c.Parent.Name, Me.name & "-" & c.Name)
               For Each col As DataGridViewColumn In c.Columns
                   SaveSetting(AppName, "Settings", frm.Name & "-" & c.Name & col.Index & "_width", col.Width)

               Next

           End Sub)
    End Sub

    Public Function GetAllControls(ByVal sender As Control, ByVal T As Type) As IEnumerable(Of Control)
        Dim controls = sender.Controls.Cast(Of Control)()
        Return controls.SelectMany(
            Function(ctrl) GetAllControls(ctrl, T)).Concat(controls).Where(
            Function(c) c.GetType() Is T)
    End Function

    Public Function ReturValueFromTable(what As String, from As String, where As String, value As String, Optional sql As String = "") As String

        Dim ret As String
        Try
            Dim ds As New DataSet
            kmAutoCmd.CommandText = If(sql = "", "Select " & what & " from " & from & " Where " & where & " " & " = " & value, sql)
            Dim oDataAdapter As New SqlClient.SqlDataAdapter(kmAutoCmd)
            oDataAdapter.Fill(ds)
            ret = ds.Tables(0).Rows(0)(what)

        Catch ex As Exception
            ret = ""
        End Try
        ReturValueFromTable = ret
    End Function
    Public Function ReturDataTable(cmd As SqlClient.SqlCommand, Sql As String) As DataTable
        Try
            Dim ds As New DataSet
            cmd.CommandText = Sql
            Dim oDataAdapter As New SqlClient.SqlDataAdapter(cmd)
            oDataAdapter.Fill(ds)
            ReturDataTable = ds.Tables(0)

        Catch ex As Exception

        End Try

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
        Dim sw As New Stopwatch
        sw.Start()
        Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            Application.DoEvents()
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
    Public Sub stergeToateLabelurile(frm As Form, criteriu As String)
        GetAllControls(frm, GetType(Label)).ToList.ForEach(
           Sub(c As Label)
               If c.Name.Substring(0, 3) = "lbl" And c.Name.Substring(c.Name.Length - 1, 1) = criteriu Then
                   c.Text = "0"
               End If
           End Sub)

    End Sub
    Public Sub getNumarGreseli(frm As Form, Criteriu As String, Optional dictGreseli As Dictionary(Of String, Long) = Nothing, Optional dictGreseliPeUtilizatori As Dictionary(Of String, Dictionary(Of String, Long)) = Nothing)
        'afiseaza numarul total de greseli sau numarul de utilizatori care au gresit pe fiecare tip de greseala in label-uri care au numele hardcodat,
        'de forma lbl[tip greseala cu cuvinte legate si litera mare la inceput][T pentru total sau U pentru utilizator]

        'e nevoie de un table adapter nou
        Dim myTableAdapter As New KmAutoDataSetTableAdapters.GreseliLogTableAdapter
        GetAllControls(frm, GetType(Label)).ToList.ForEach('itereaza toate controalele de tip label
           Sub(c As Label)
               Dim nume As String, numeNou As String, toAdd As String = "", k As Long = 0
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

    'Public Function ReturRecordsFromTable(what As String, from As String, where As String, value As String, Optional sql As String = "") As DataTable

    '    Dim ret As DataTable
    '    Try
    '        Dim ds As New DataSet
    '        kmAutoCmd.CommandText = If(sql = "", "Select " & what & " from " & from & " Where " & where & " " & " = " & value, sql)
    '        Dim oDataAdapter As New SqlClient.SqlDataAdapter(kmAutoCmd)
    '        oDataAdapter.Fill(ds)
    '        ret = ds.Tables(0)

    '    Catch ex As Exception
    '        ret = Nothing
    '    End Try
    '    ReturRecordsFromTable = ret
    'End Function

    Public Sub AflaDateleDeInceputSfarsitFinal(strDataRaportarii As String, ByRef strDataInceput As String, ByRef strDataSfarsit As String, ByRef strDataFinala As String, dictZileLibere As Dictionary(Of String, String))
        Dim d As Date, dd As Date, v() As String, wd As Long, k As Long, ziuaDelimitare As Long
        'Afla data de inceput a primului weekend (ziua de vineri) si data de sfarsit a ultimului weekend (ziua de luni) si le returneaza prin referinta
        'La data de inceput se adauga (in fata) zilele libere iar la data de sfarsit se adauga (la final) zilele libere
        'La data de final se adauga zilele pana la ziua de joi inclusiv, pentru ca cineva poate introduce indexe si in alte zile, ulterioare zilei de luni dar nu mai tarziu de ziua de joi inclusiv
        'Daca se gasesc inregistrari succesive intr-o alta zi decat intervalul convenit (sa zicem miercuri) cu kilometraj diferit, acestea se vor trata ca si cum ar apartine week-endului anterior introducerii
        'cu cerinta ca prima data (identificata prin timestamp) sa contina indexul mai mic. In felul acesta se pot introduce kilometrii si dupa ziua de luni.
        'Data finala este data pana la care se pot introduce indexe, dupa dataSfarsit (prima zi de joi dupa ziua de luni (data sfarsit)) pentru ultimul weekend

        'afla ziua de luni cea mai apropiata de data curenta
        k = 0
        v = Split(strDataRaportarii, "-")
        d = DateSerial(v(0), v(1), v(2))
        ziuaDelimitare = v(2)

        If ziuaDelimitare < 8 Then 'raportul se va face pentru luna anterioara

            'coboara data pana la ziua de 1 a lunii curente
            Do While DateAndTime.Day(d) <> 1 And k < 50
                k = k + 1
                d = DateAdd("d", -1, d) 'scade o zi
            Loop
        End If

        'coboara data pana la prima zi de luni fata de ziua raportarii (daca ziuaDelimitare < 8, pana la ultima zi de luni a lunii anterioare)
        k = 0
        wd = DateAndTime.Weekday(d, vbMonday)
        Do While wd <> 1 And k < 50
            k = k + 1
            d = DateAdd("d", -1, d) 'scade o zi
            wd = DateAndTime.Weekday(d, vbMonday) 'afla ziua din saptamana (1 = luni, 7 = duminica)
        Loop

        'adauga la sfarsit zilele de sarbatoare
        k = 0
        Do While dictZileLibere.ContainsKey(d) And k < 100
            d = DateAdd("d", 1, d) 'adauga o zi

        Loop
        dd = d 'face o copie a datei pentru a afla data finala
        strDataSfarsit = Year(d) & "-" & leadZero(Month(d), 2) & "-" & leadZero(DateAndTime.Day(d), 2)

        'urca pana la ziua de joi dupa data sfarsit pentru a obtine data finala
        k = 0
        'dd = DateAdd("d", 1, dd) 'adauga o zi
        Do While DateAndTime.Weekday(dd, vbMonday) <> 4 And k < 50
            k = k + 1
            dd = DateAdd("d", 1, dd) 'adauga o zi
        Loop
        strDataFinala = Year(dd) & "-" & leadZero(Month(dd), 2) & "-" & leadZero(DateAndTime.Day(dd), 2)


        'coboara data pana la ziua de 7 a lunii curente
        k = 0
        d = DateAdd("d", -1, d) 'scade o zi
        Do While DateAndTime.Day(d) <> 7 And k < 50
            k = k + 1
            d = DateAdd("d", -1, d) 'scade o zi
        Loop

        'coboara data pana la prima zi de luni fata de ziua de 7 a lunii anterioare
        k = 0
        wd = DateAndTime.Weekday(d, vbMonday)
        Do While wd <> 1 And k < 50
            k = k + 1
            d = DateAdd("d", -1, d) 'scade o zi
            wd = DateAndTime.Weekday(d, vbMonday) 'afla ziua din saptamana (1 = luni, 7 = duminica)
        Loop
        If DateAndTime.Day(d) = 1 Then 'ziua de 1 pica lunea si n-ar trebui inclusa in luna. Se va creste la lunea urmatoare
            'urca data pana la prima zi de luni fata de ziua de 1 a lunii anterioare
            k = 0
            d = DateAdd("d", 1, d) 'adauga o zi
            wd = DateAndTime.Weekday(d, vbMonday)
            Do While wd <> 1 And k < 50
                k = k + 1
                d = DateAdd("d", 1, d) 'adauga o zi
                wd = DateAndTime.Weekday(d, vbMonday) 'afla ziua din saptamana (1 = luni, 7 = duminica)
            Loop
        End If

        'scade 3 zile pentru a ajunge pe ziua de vineri
        For k = 1 To 3
            d = DateAdd("d", -1, d) 'scade o zi

        Next k

        'adauga la inceput zilele de sarbatoare
        k = 0
        Do While dictZileLibere.ContainsKey(d) And k < 100
            d = DateAdd("d", -1, d) 'scade o zi

        Loop
        strDataInceput = Year(d) & "-" & leadZero(Month(d), 2) & "-" & leadZero(DateAndTime.Day(d), 2)

    End Sub
    Public Sub AflaIntervaleleDePlata(dataInceput As Date, dataSfarsit As Date, dictZileLibere As Dictionary(Of String, String), ByRef arrStart() As Date, ByRef arrStop() As Date)
        'afla intervalele de weekend plus sarbatori legale care vor conta la plata km parcursi in interes personal
        'se pleaca de la data de inceput care va fi intotdeauna prima zi a primului interval (cu tot cu sarbatori legale) si se itereaza toate zilele pana la data de sfarsit
        'de fiecare data cand se gaseste un inceput de interval se creaza o intrare in arrStart si una in arrStop. In arrStart se scrie data de inceput
        'iar la urmatoarele iteratii se va gasi si data de sfarsit a intervalului ce se va scrie in arrStop
        'Daca exista sarbatori legale care nu sunt legate de weekend se trateaza ca intervale separate

        Dim cont As Long, k As Long, wd As Long, d As Date, memD As Date, steagZiLucratoareFaraSarbatoareLegala As Boolean, steagPrimaZiDeSarbatoareDinInterval As Boolean
        cont = 0

        ReDim Preserve arrStart(cont)
        ReDim Preserve arrStop(cont) 'se creaza simultan doar pentru a fi siguri ca cele doua array-uri nu vor fi desperecheate, dar trebuie sa ne asiguram ca arrStop va fi completat cumva

        'se trateaza separat primul interval, deoarece se stie ca e valid si contine si sarbatorile legale
        arrStart(cont) = dataInceput 'se scrie inceputul primului interval
        'se merge pana la urmatoarea zi de luni
        k = 0
        d = dataInceput
        wd = DateAndTime.Weekday(d, vbMonday)
        Do While wd <> 1 And k < 50
            d = DateAdd("d", 1, d) 'adauga o zi
            wd = DateAndTime.Weekday(d, vbMonday)
        Loop

        'adauga la sfarsit zilele de sarbatoare
        k = 0
        Do While dictZileLibere.ContainsKey(d) And k < 100
            d = DateAdd("d", 1, d) 'adauga o zi
            k = k + 1
        Loop
        arrStop(cont) = d 'si scriem si finalul primului interval

        d = DateAdd("d", 1, d) 'adauga o zi
        wd = DateAndTime.Weekday(d, vbMonday)
        k = 0
        Do 'incepe o bucla intre data de sfarsit a primului interval si dataSfarsit
            'If d = #8/16/2022# Then Stop
            steagZiLucratoareFaraSarbatoareLegala = False
            steagPrimaZiDeSarbatoareDinInterval = False
            Do While wd <> 5 And k < 50 And d <= dataSfarsit 'cauta urmatoarea zi de vineri
                If dictZileLibere.ContainsKey(d) = True And steagZiLucratoareFaraSarbatoareLegala = True And steagPrimaZiDeSarbatoareDinInterval = False Then 'prima zi de sarbatoare legala inainte de vineri dar nelegata de ziua de luni anterioara. Daca ar fi fost legata ar fi fost gasita mai sus, nu aici.
                    memD = d 'posibil inceput de interval sarbatori legale distinct (nelegat de weekend). Pentru a fi siguri, trebuie sa mai gasim o zi fara sarbatoare legala pana vineri inclusiv
                    steagPrimaZiDeSarbatoareDinInterval = True
                End If
                If dictZileLibere.ContainsKey(d) = False Then steagZiLucratoareFaraSarbatoareLegala = True 'o zi fara sarbatoare legala necesara pentru detectarea sarbatorilor legale nelegate de weekend
                d = DateAdd("d", 1, d) 'adauga o zi
                wd = DateAndTime.Weekday(d, vbMonday)
                If dictZileLibere.ContainsKey(d) = False And steagPrimaZiDeSarbatoareDinInterval = True Then  'este o zi care nu e sarbatoare legala inainte de ziua de vineri. Daca ar fi fost vineri, nu s-ar fi ajuns aici (conditia din do while)
                    'sunt pe sfarsitul unui interval cu sarbatori legale nelegat de weekend
                    cont = cont + 1
                    ReDim Preserve arrStart(cont)
                    ReDim Preserve arrStop(cont) 'se creaza simultan doar pentru a fi siguri ca cele doua array-uri nu vor fi desperecheate, dar trebuie sa ne asiguram ca arrStop va fi completat cumva
                    arrStart(cont) = memD
                    memD = d 'trebuie sa aflu data zile anterioare lui d (ultima zi din interval cu sarbatoare legala)
                    arrStop(cont) = DateAdd("d", -1, memD)
                    steagPrimaZiDeSarbatoareDinInterval = False
                End If
                k = k + 1
            Loop

            'adauga la inceput zilele de sarbatoare
            k = 0
            Do While dictZileLibere.ContainsKey(d) And k < 100 And d >= dataInceput
                d = DateAdd("d", -1, d) 'scade o zi

            Loop
            If d <= dataSfarsit Then
                'sunt pe inceputul unui interval
                cont = cont + 1
                ReDim Preserve arrStart(cont)
                ReDim Preserve arrStop(cont) 'se creaza simultan doar pentru a fi siguri ca cele doua array-uri nu vor fi desperecheate, dar trebuie sa ne asiguram ca arrStop va fi completat cumva
                arrStart(cont) = d

                'cauta sfarsitul intervalului
                k = 0
                d = DateAdd("d", 1, d) 'adauga o zi
                wd = DateAndTime.Weekday(d, vbMonday)
                Do While wd <> 1 And k < 50 And d <= dataSfarsit 'cauta urmatoarea zi de luni
                    d = DateAdd("d", 1, d) 'adauga o zi
                    wd = DateAndTime.Weekday(d, vbMonday)
                    k = k + 1
                Loop

                'adauga la sfarsit zilele de sarbatoare
                k = 0
                Do While dictZileLibere.ContainsKey(d) And k < 100 And d <= dataSfarsit
                    d = DateAdd("d", 1, d) 'adauga o zi

                Loop
                'sunt pe sfarsitul unui interval
                arrStop(cont) = d
            End If
        Loop While d < dataSfarsit

    End Sub
    Public Function formateazaDataAsString(d As Date, format As String) As String
        Dim s As String = d.ToString(format)
        formateazaDataAsString = s
    End Function

    Public Function ReturQueryInterval(intervalComplet As String, Optional primaParte As String = "") As String
        'Me.Text = sendSimpleEmail("vicentiu.mincior@consolight.ro", "mama mia", "Hello" & vbCrLf & "Vica", "mincior@yahoo.com")
        'sendEmailViaOutlook("vicentiu.mincior@consolight.ro", "vicentiu.mincior@consolight.ro", "", "Hello", "Hello")
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

End Module
