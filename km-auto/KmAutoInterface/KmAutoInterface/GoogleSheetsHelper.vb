Imports Google.Apis
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Services
Imports Google.Apis.Sheets.v4
Imports Google.Apis.Sheets.v4.Data
Imports Newtonsoft.Json
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports System.Xml.Serialization

Public Class GoogleSheetsHelper
    Public Property Service As SheetsService
    Const APPLICATION_NAME As String = "kmAuto"
    Shared ReadOnly Scopes As String() = {SheetsService.Scope.Spreadsheets}

    Public Sub New()
        InitializeService()
    End Sub

    Private Sub InitializeService()
        Dim credential = GetCredentialsFromFile()
        Service = New SheetsService(New BaseClientService.Initializer() With {
            .HttpClientInitializer = credential,
            .ApplicationName = APPLICATION_NAME
        })
    End Sub

    Private Function GetCredentialsFromFile() As GoogleCredential
        Dim credential As GoogleCredential

        Using stream = New FileStream(AppPath & "input\google_service_key.json", FileMode.Open, FileAccess.Read)
            credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes)
        End Using

        Return credential
    End Function

    Public Function AddRows(SpreadsheetId As String, SheetName As String, dictRows As Dictionary(Of String, IList(Of Object))) As String
        'adauga un rand intreg (atentie la numarul de coloane din ListRows(0) - adica primul rand ca pot fi mai multe dar toate au acelasi numar de coloane
        'returneaza un json cu rezultatul adaugarii
        Try
            AddRows = ""
            Dim listRows As New List(Of IList(Of Object))
            'rutina lucra cu listRows si nu cu dictRows dar pentru compatibilitate cu rutinele GetRows si GetRange s-a pus si aici dictionar
            For Each lst As KeyValuePair(Of String, IList(Of Object)) In dictRows
                listRows.Add(lst.Value)
            Next
            Dim googleSheetValues As SpreadsheetsResource.ValuesResource = Me.Service.Spreadsheets.Values
            Dim valueRange As New Data.ValueRange
            valueRange.Values = CType(listRows, IList(Of IList(Of Object)))
            Dim Range As String = SheetName
            Dim add As SpreadsheetsResource.ValuesResource.AppendRequest = googleSheetValues.Append(valueRange, SpreadsheetId, Range)

            add.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW
            Dim result As AppendValuesResponse = add.Execute()
            If result.Updates.UpdatedRows = 1 Then
                AddRows = "Adaugare randuri ok"
            End If

        Catch ex As System.Exception
            AddRows = "Eroare. " & ex.Message

        End Try
    End Function
    Public Function AddRows(SpreadsheetId As String, SheetName As String, listRows As List(Of IList(Of Object))) As String
        'adauga un rand intreg (atentie la numarul de coloane din ListRows(0) - adica primul rand ca pot fi mai multe dar toate au acelasi numar de coloane
        'returneaza un json cu rezultatul adaugarii
        Try
            AddRows = ""
            Dim googleSheetValues As SpreadsheetsResource.ValuesResource = Me.Service.Spreadsheets.Values
            Dim valueRange As New Data.ValueRange
            valueRange.Values = listRows

            Dim Range As String = SheetName & "!A2:L2"
            Dim add As SpreadsheetsResource.ValuesResource.AppendRequest = googleSheetValues.Append(valueRange, SpreadsheetId, Range)

            add.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW

            Dim result As AppendValuesResponse = add.Execute()
            If result.Updates.UpdatedRows = 1 Then
                AddRows = "Adaugare randuri ok"
            End If

        Catch ex As System.Exception
            AddRows = "Eroare. " & ex.Message

        End Try
    End Function
    Public Function ClearRows(SpreadsheetId As String, SheetName As String, Coloana As Long, Optional Rand As Long = 0, Optional Range As String = "") As String
        Try
            If Rand = 1 Then
                ClearRows = "Eroare. Nu se poate sterge primul rand"
                Exit Function
            End If
            Dim MyRange As String = SheetName
            If Rand > 1 Then
                MyRange &= "!A" & Rand & ":" & ReturSpreadsheetColumnNameByNumber(Coloana) & Rand

            End If
            If Range <> "" Then
                MyRange &= "!" & Range
            End If
            Dim googleSheetValues As SpreadsheetsResource.ValuesResource = Me.Service.Spreadsheets.Values
            Dim requestBody As New ClearValuesRequest
            Dim deleteRequest = googleSheetValues.Clear(requestBody, SpreadsheetId, MyRange)
            deleteRequest.Execute()
            ClearRows = "Stergere continut randuri Ok"

        Catch ex As System.Exception
            ClearRows = "Eroare. " & ex.Message
        End Try
    End Function
    Public Function DeleteRows(SpreadsheetId As String, SheetId As String, randStart As Integer, Optional randStop As Integer = 0) As String
        Try
            'sterge randuri in google sheet. Daca randStop nu este specificat va sterge tot pana la final incepand de la randStart
            Dim googleSheetResource As SpreadsheetsResource = Service.Spreadsheets
            Dim content As New BatchUpdateSpreadsheetRequest
            'Dim contentRequests As New BatchUpdateSpreadsheetRequest.
            Dim request As New Google.Apis.Sheets.v4.Data.Request
            Dim deleteDimension As New DeleteDimensionRequest
            Dim range As New DimensionRange
            With range
                .SheetId = SheetId
                .Dimension = "ROWS"
                .StartIndex = randStart
                If randStop > 0 Then
                    .EndIndex = randStop + 1
                End If
            End With
            deleteDimension.Range = range
            request.DeleteDimension = deleteDimension
            Dim requests As IList(Of Request) = New List(Of Request)
            content.Requests = requests
            requests.Add(request)
            googleSheetResource.BatchUpdate(content, SpreadsheetId).Execute()
            DeleteRows = "Succes stergere."

        Catch ex As System.Exception
            DeleteRows = "Eroare. " & ex.Message
        End Try
    End Function
    Public Function RemoveFilter(SpreadsheetId As String, sheetId As String) As String
        RemoveFilter = ""
        'scoate toate filtrele din spreadsheet (meniul Data\Remove filter)
        Dim googleSheetResource As SpreadsheetsResource = Service.Spreadsheets
        Dim content As New BatchUpdateSpreadsheetRequest
        Dim request As New Google.Apis.Sheets.v4.Data.Request
        Dim rmFilter As New ClearBasicFilterRequest
        rmFilter.SheetId = sheetId
        request.ClearBasicFilter = rmFilter
        Dim requests As IList(Of Request) = New List(Of Request)
        content.Requests = requests
        requests.Add(request)
        googleSheetResource.BatchUpdate(content, SpreadsheetId).Execute()

    End Function
    Public Function SetFilter(SpreadsheetId As String, sheetId As String) As String
        SetFilter = ""
        'pune filtrele pe toate coloanele si randurile din pagina (meniul Data\Set filter)
        Dim googleSheetResource As SpreadsheetsResource = Service.Spreadsheets
        Dim content As New BatchUpdateSpreadsheetRequest
        Dim request As New Google.Apis.Sheets.v4.Data.Request
        Dim setF As New SetBasicFilterRequest
        With setF
            .Filter = New Google.Apis.Sheets.v4.Data.BasicFilter
            With .Filter
                .Range = New Google.Apis.Sheets.v4.Data.GridRange
                With .Range
                    .SheetId = sheetId
                End With
            End With

        End With
        request.SetBasicFilter = setF
        Dim requests As IList(Of Request) = New List(Of Request)
        content.Requests = requests
        requests.Add(request)
        googleSheetResource.BatchUpdate(content, SpreadsheetId).Execute()

    End Function
    Public Function GoogleRepeatCellRequest(SpreadsheetId As String, SheetId As Integer, coloana As Integer) As String
        'aplica formatare asupra foii google
        Try
            Dim googleSheetResource As SpreadsheetsResource = Service.Spreadsheets
            Dim content As New BatchUpdateSpreadsheetRequest
            Dim requests As IList(Of Request) = New List(Of Request)
            Dim request As New Google.Apis.Sheets.v4.Data.Request
            Dim repeatCellRequest As New Google.Apis.Sheets.v4.Data.RepeatCellRequest
            request.RepeatCell = repeatCellRequest

            Dim range As New Google.Apis.Sheets.v4.Data.GridRange
            With range
                .SheetId = SheetId
                .StartRowIndex = 1
                .StartColumnIndex = coloana
                .EndColumnIndex = coloana + 1
            End With
            repeatCellRequest.Range = range

            Dim myNumberFormat As New Google.Apis.Sheets.v4.Data.NumberFormat
            myNumberFormat.Type = "DATE"
            myNumberFormat.Pattern = "yyyy-MM-dd HH:mm:ss"

            Dim myUserFormat As New Google.Apis.Sheets.v4.Data.CellFormat
            myUserFormat.NumberFormat = myNumberFormat

            Dim cell As New Google.Apis.Sheets.v4.Data.CellData
            cell.UserEnteredFormat = myUserFormat

            repeatCellRequest.Cell = cell

            repeatCellRequest.Fields = "userEnteredFormat.numberFormat"

            content.Requests = requests
            requests.Add(request)
            googleSheetResource.BatchUpdate(content, SpreadsheetId).Execute()
            GoogleRepeatCellRequest = "Updated Ok"

        Catch ex As System.Exception
            GoogleRepeatCellRequest = "Eroare. " & ex.Message
        End Try
    End Function


    Public Function UpdateCell(SpreadsheetId As String, SheetName As String, listRows As IList(Of IList(Of Object)), Rand As Long, Coloana As Long) As String
        'updateaza randul Rand incepand cu coloana Coloana. Randul nu poate fi zero (va da eroare)
        'daca exista fullrange, va lua range-ul in format "A1:C3" sa spunem
        'returneaza un json cu rezultatul adaugarii
        Try
            If Rand < 1 Then
                UpdateCell = "Eroare, nu exista randul zero."
                Exit Function
            End If
            Dim googleSheetValues As SpreadsheetsResource.ValuesResource = Me.Service.Spreadsheets.Values
            Dim valueRange As New Data.ValueRange
            valueRange.Values = listRows
            Dim Range As String = SheetName & "!" & ReturSpreadsheetColumnNameByNumber(Coloana) & Rand + 1 & ":" & ReturSpreadsheetColumnNameByNumber(Coloana + 1) & Rand + 1
            Dim add As SpreadsheetsResource.ValuesResource.UpdateRequest = googleSheetValues.Update(valueRange, SpreadsheetId, Range)
            add.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW
            Dim result As UpdateValuesResponse = add.Execute()
            UpdateCell = "Succes modificare."

        Catch ex As System.Exception
            UpdateCell = "Eroare. " & ex.Message

        End Try
    End Function
    Public Function ClearCell(SpreadsheetId As String, SheetName As String, Coloana As Long, Rand As Long, Optional Range As String = "") As String
        Try
            If Rand = 1 Then
                ClearCell = "Eroare. Nu se poate sterge o celula din primul rand"
                Exit Function
            End If
            Dim MyRange As String = SheetName
            If Rand > 1 Then
                MyRange &= "!" & ReturSpreadsheetColumnNameByNumber(Coloana) & Rand & ":" & ReturSpreadsheetColumnNameByNumber(Coloana) & Rand

            End If
            If Range <> "" Then
                MyRange &= "!" & Range
            End If
            Dim googleSheetValues As SpreadsheetsResource.ValuesResource = Me.Service.Spreadsheets.Values
            Dim requestBody As New ClearValuesRequest
            Dim deleteRequest = googleSheetValues.Clear(requestBody, SpreadsheetId, MyRange)
            deleteRequest.Execute()
            ClearCell = "Succes modificare."

        Catch ex As System.Exception
            ClearCell = "Eroare. " & ex.Message
        End Try
    End Function


    'Public Function GetRowsList(spreadsheetId As String, sheetName As String, Optional Range As String = "") As IList(Of IList(Of Object))
    '    Dim values As IList(Of IList(Of Object)) = New List(Of IList(Of Object))
    '    Try
    '        Dim googleSheetValues As SpreadsheetsResource.ValuesResource = Me.Service.Spreadsheets.Values
    '        Dim myRange = sheetName & If(Range = "", "", "!" & Range)
    '        Dim request As SpreadsheetsResource.ValuesResource.GetRequest = googleSheetValues.Get(spreadsheetId, myRange)
    '        Dim response As Google.Apis.Sheets.v4.Data.ValueRange = request.Execute()
    '        values = response.Values

    '    Catch ex As System.Exception

    '    Finally
    '        GetRowsList = values

    '    End Try

    'End Function


    Public Function GetRowsList(spreadsheetId As String, sheetName As String, Optional range As String = "") As IList(Of IList(Of Object))
        Dim values As IList(Of IList(Of Object)) = New List(Of IList(Of Object))
        Try
            Dim googleSheetValues As SpreadsheetsResource.ValuesResource = Me.Service.Spreadsheets.Values
            Dim myRange As String = sheetName & If(range.Length > 0, "!" & range, "")
            Dim request As SpreadsheetsResource.ValuesResource.GetRequest = googleSheetValues.Get(spreadsheetId, myRange)
            Dim response As Google.Apis.Sheets.v4.Data.ValueRange = request.Execute()
            values = response.Values

        Catch ex As System.Exception

        Finally
            GetRowsList = values
        End Try

    End Function

End Class
