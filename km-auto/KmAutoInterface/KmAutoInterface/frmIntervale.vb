Imports System.ComponentModel
Imports System.Linq
Public Class frmIntervale
    Private dataRaportarii As Date


    Private Sub frmIntervale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 982, 879)
        'gstrDataRaportarii = "2022-12-01"
        dataRaportarii = convertStringDataToDate(gstrDataRaportarii)
    End Sub

    Private Sub frmIntervale_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        SalveazaDimensiuniSiPozitie(Me)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False

        Dim datMin As Date
        'Try
        '    kmAutoSqlCon.ConnectionString = kmAutoConnectionString
        '    kmAutoSqlCon.Open()
        '    kmAutoCmd.Connection = kmAutoSqlCon
        '    kmAutoCmd.CommandTimeout = 20000

        '    RobotsSqlCon.ConnectionString = RobotsConnectionString
        '    RobotsSqlCon.Open()
        '    RobotsCmd.Connection = RobotsSqlCon
        '    RobotsCmd.CommandTimeout = 20000

        'Catch ex As System.Exception

        'End Try
        datMin = ReturExecutaSqlKmAuto("Select TOP(1) DataSfarsit from Intervale Where (DataRaportarii< '" & dataRaportarii & "') ORDER BY DataSfarsit Desc ")
        If DateAndTime.Year(datMin) = 1 Then
            datMin = DateAdd("d", -40, dataRaportarii) 'implicit zece zile din luna anterioara raportarii

        Else
            datMin = DateAdd("d", 1, datMin) 'adauga o zi la dataSfarsit a lunii anterioare

        End If
        Me.MonthCalendar1.MinDate = datMin
        Me.MonthCalendar1.MaxDate = DateAdd("d", 45, datMin)
        Me.MonthCalendar1.SelectionStart = datMin
        Me.MonthCalendar1.SelectionEnd = datMin
        Me.MonthCalendar1.Select()
        Me.MonthCalendar1.Refresh()
        lblIntervale.Text = "Intervale: " & vbCrLf

        Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select * from Intervale Where DataRaportarii = '" & gstrDataRaportarii & "'")
        Dim row As System.Data.DataRow
        For Each row In myDataTable.Rows
            Dim dataInceput As Date = DateAdd("d", 1, row("DataInceput"))
            Dim dataSfarsit As Date = DateAdd("d", -1, row("DataSfarsit"))
            Dim d As Date = dataInceput
            Do Until d > dataSfarsit
                Me.MonthCalendar1.AddBoldedDate(d)
                d = DateAdd("d", 1, d)
            Loop
            lblIntervale.Text &= row("Interval") & vbCrLf
            Me.MonthCalendar1.UpdateBoldedDates()
            Me.MonthCalendar1.Refresh()

        Next
        Try
            'scrie numarul de zile pana la weekendul urmator in GroupBox1
            'afla datafinala pentru ultimul interval din luna curenta
            Dim ultimaDataFinala As Date = ReturExecutaSqlKmAuto("Select Top(1) DataFinala from Intervale Where DataRaportarii = '" & gstrDataRaportarii & "' Order by DataFinala desc")
            Dim ultimaDataSfarsit As Date = ReturExecutaSqlKmAuto("Select  DataSfarsit from Intervale Where DataFinala = '" & ultimaDataFinala & "'")
            Dim diferenta As Long = 3
            If ultimaDataFinala <> #1/1/0001 12:00:00 AM# Then
                diferenta = Math.Abs(DateDiff("d", ultimaDataFinala, ultimaDataSfarsit))

            End If
            Select Case diferenta
                Case 0
                    RadioButton1.Checked = True
                Case 1
                    RadioButton2.Checked = True
                Case 2
                    RadioButton3.Checked = True
                Case 3
                    RadioButton4.Checked = True
            End Select
            lblNumarZilePanaLaWeekendulUrmator.Text = convertDataAsStringOfFomat(ultimaDataFinala, "yyyy-MM-dd")
            lbInfo.Text = "Perioada curenta : " & convertDataAsStringOfFomat(datMin, "yyyy-MM-dd") & " - " & convertDataAsStringOfFomat(Me.MonthCalendar1.MaxDate, "yyyy-MM-dd")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdIesire_Click(sender As Object, e As EventArgs) Handles cmdIesire.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub


    Private Sub cmdAdaugare_Click(sender As Object, e As EventArgs) Handles cmdAdaugare.Click
        ' Add dates to BoldedDates array.
        Dim d As Date = Me.MonthCalendar1.SelectionStart
        Do Until d > Me.MonthCalendar1.SelectionEnd
            Me.MonthCalendar1.AddBoldedDate(d)
            d = DateAdd("d", 1, d)
        Loop
        Me.MonthCalendar1.UpdateBoldedDates()
        Me.MonthCalendar1.Refresh()

    End Sub

    Private Sub cmdStergere_Click(sender As Object, e As EventArgs) Handles cmdStergere.Click
        ' Add dates to BoldedDates array.
        Dim d As Date = Me.MonthCalendar1.SelectionStart
        Do Until d > Me.MonthCalendar1.SelectionEnd
            Me.MonthCalendar1.RemoveBoldedDate(d)
            d = DateAdd("d", 1, d)
        Loop
        Me.MonthCalendar1.UpdateBoldedDates()
        Me.MonthCalendar1.Refresh()


    End Sub

    Private Sub cmdStergereTot_Click(sender As Object, e As EventArgs) Handles cmdStergereTot.Click
        ' Add dates to BoldedDates array.
        Dim d As Date = Me.MonthCalendar1.MinDate
        Do Until d > Me.MonthCalendar1.MaxDate
            Me.MonthCalendar1.RemoveBoldedDate(d)
            d = DateAdd("d", 1, d)
        Loop
        Me.MonthCalendar1.UpdateBoldedDates()
        Me.MonthCalendar1.Refresh()

    End Sub

    Private Sub cmdAdaugareWeekend_Click(sender As Object, e As EventArgs) Handles cmdAdaugareWeekend.Click
        Dim limitaZiIntreLuni As Long = CLng(ReturExecutaSqlRobots("Select FisiereBI from Config Where NumeRobot ='" & NumeRobot & "'"))
        Dim d As Date = Me.MonthCalendar1.MinDate
        Dim strDataRaportarii = frmPrincipal.lblDataRaportarii.Text
        Do Until d > Me.MonthCalendar1.MaxDate
            If (d.DayOfWeek = 6 Or d.DayOfWeek = 0) Then
                If DateAndTime.Month(d) = DateAndTime.Month(convertStringDataToDate(gstrDataInceput)) Then
                    Me.MonthCalendar1.AddBoldedDate(d)
                End If
            End If
            d = DateAdd("d", 1, d)
        Loop
        Me.MonthCalendar1.UpdateBoldedDates()
        Me.MonthCalendar1.Refresh()

    End Sub

    Private Sub cmdSalvare_Click(sender As Object, e As EventArgs) Handles cmdSalvare.Click
        'In tabelul intervale se salveaza toate intervalele dorite. 
        'Data inceput, de obicei Vineri 'inceputul intervalului
        'Data sfarsit, de obicei Luni 'sfarsitul intervalului
        'Data finala, de obicei joi - ultima zi in care se interpreteaza inregistrarile ca apartinand weekendului curent
        'La final de luna nu se cunoaste anticipat cand este dataFinala datorita posibilitatii existentei sarbatorilor legale,
        'care modifica data finala cu o zi inaintea primei sarbatori legale din seria de sarbatori legale legate de weekend.
        'De aceea s-a pus grupul de radio butoane cu textul = un numar de la 1 la 4 si se alege (intre 3 si 0) numarul de zile de la sfarsitul intervalului
        'pana la finalul lui. In formular se bifeaza doar zilele de weekend si sarbatori legale, zile libere, nu si inceputul si sfarsitul intervalului
        'adica vineri si luni. In baza de date intervalul cuprinde si zilele de vineri si luni.
        Dim steagStart As Boolean, steagStop As Boolean, memDataInceput As Date
        Dim d As Date = Me.MonthCalendar1.MinDate
        Dim numarZilePanaLaWeekendulUrmator As Long = CLng(GroupBox1.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True).Text) - 1
        Dim result As String = ExecutaSQLKmAuto("Delete from Intervale where DataRaportarii = '" & gstrDataRaportarii & "'")
        lblIntervale.Text = "Intervale: " & vbCrLf

        Do Until d > Me.MonthCalendar1.MaxDate
            If BoldDateExists(d, Me.MonthCalendar1) = True And steagStart = False Then
                memDataInceput = d
                steagStart = True
            End If
            If BoldDateExists(DateAdd("d", 1, d), Me.MonthCalendar1) = False And steagStart = True Then
                'scrie datele
                Dim contorAflareDataFinala As Long = 0
                Dim interval As String = formeazaInterval(DateAdd("d", -1, memDataInceput), DateAdd("d", 1, d))
                Dim dataFinala As Date = DateAdd("d", 1, d) 'Data finala este prima zi a intervalului urmator minus 1. Daca nu exista, pune numarZilePanaLaWeekendulUrmator zile dupa finalul intervalului (de obicei joi)
                Dim dataSfarsit As Date = DateAdd("d", 1, d)
                Do Until BoldDateExists(DateAdd("d", 1, dataFinala), Me.MonthCalendar1) = True Or contorAflareDataFinala = 3
                    contorAflareDataFinala += 1
                    dataFinala = DateAdd("d", 1, dataFinala) 'adauga o zi la dd
                Loop
                Dim res As String = ExecutaSQLKmAuto("INSERT INTO Intervale (DataRaportarii, DataInceput, DataSfarsit, DataFinala, Interval) values ('" & convertStringDataToDate(gstrDataRaportarii) & "', '" & DateAdd("d", -1, memDataInceput) & "', '" & dataSfarsit & "', '" & dataFinala & "', '" & interval & "')")
                lblIntervale.Text &= interval & vbCrLf
                steagStop = True
                steagStart = False
            End If
            d = DateAdd("d", 1, d)
        Loop

        'scrie numarul de zile pana la weekendul urmator in GroupBox1
        'afla datafinala pentru ultimul interval din luna curenta
        Dim ultimaDataSfarsit As Date = ReturExecutaSqlKmAuto("Select Top(1) DataSfarsit from Intervale Where DataRaportarii = '" & gstrDataRaportarii & "' Order by DataFinala desc")
        Dim ultimaDataFinala As Date = DateAdd("d", numarZilePanaLaWeekendulUrmator, ultimaDataSfarsit)

        result = ExecutaSQLKmAuto("Update Intervale Set DataFinala = '" & ultimaDataFinala & "' Where DataSfarsit = '" & ultimaDataSfarsit & "' and DataRaportarii ='" & gstrDataRaportarii & "'")
        lblNumarZilePanaLaWeekendulUrmator.Text = convertDataAsStringOfFomat(ultimaDataFinala, "yyyy-MM-dd")
        Me.MonthCalendar1.UpdateBoldedDates()
        Me.MonthCalendar1.Refresh()
        lbInfo.Text = result
    End Sub
    Private Function BoldDateExists(d As Date, mc As MonthCalendar) As Boolean
        BoldDateExists = False

        For Each dd In mc.BoldedDates
            If d = dd Then 'add
                BoldDateExists = True
                Exit For
            End If
        Next

    End Function



    'ciorna
    ' Label1.Text = Me.MonthCalendar1.

    'Me.MonthCalendar1.BackColor = System.Drawing.SystemColors.Info
    'Me.MonthCalendar1.ForeColor = System.Drawing.Color.FromArgb(
    '                        CType(192, System.Byte), CType(0, System.Byte), CType(192, System.Byte))
    'Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.Purple
    'Me.MonthCalendar1.TitleForeColor = System.Drawing.Color.Yellow
    'Me.MonthCalendar1.TrailingForeColor = System.Drawing.Color.FromArgb(
    '                        CType(192, System.Byte), CType(192, System.Byte), CType(0, System.Byte))

    ' Add dates to the AnnuallyBoldedDates array.
    'Me.MonthCalendar1.AnnuallyBoldedDates = New System.DateTime() _
    '             {New System.DateTime(2002, 4, 20, 0, 0, 0, 0),
    '              New System.DateTime(2002, 4, 28, 0, 0, 0, 0),
    '              New System.DateTime(2002, 5, 5, 0, 0, 0, 0),
    '              New System.DateTime(2002, 7, 4, 0, 0, 0, 0),
    '              New System.DateTime(2002, 12, 15, 0, 0, 0, 0),
    '              New System.DateTime(2002, 12, 18, 0, 0, 0, 0)}


    ' Add dates to MonthlyBoldedDates array.
    'Me.MonthCalendar1.MonthlyBoldedDates = New System.DateTime() _
    '             {New System.DateTime(2002, 1, 15, 0, 0, 0, 0),
    '              New System.DateTime(2002, 1, 30, 0, 0, 0, 0)}

    '' Configure the calendar to display 3 rows by 4 columns of months.
    'Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(4, 3)

    '' Set the week to begin on Monday.
    'Me.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday

    '' Sets the maximum visible date on the calendar to 12/31/2010.
    'Me.MonthCalendar1.MaxDate = New System.DateTime(2070, 12, 31, 0, 0, 0, 0)

    '' Set the minimum visible date on the calendar to 12/31/2010.
    'Me.MonthCalendar1.MinDate = New System.DateTime(1999, 1, 1, 0, 0, 0, 0)

    '' Only allow 21 days to be selected at the same time.
    'Me.MonthCalendar1.MaxSelectionCount = 21

    '' Set the calendar to move one month at a time when navigating using the arrows.
    'Me.MonthCalendar1.ScrollChange = 1

    '' Do not show the "Today" banner.
    'Me.MonthCalendar1.ShowToday = False

    '' Do not circle today's date.
    'Me.MonthCalendar1.ShowTodayCircle = False

    ' Show the week numbers to the left of each week.
    'Me.MonthCalendar1.AddBoldedDate()

End Class