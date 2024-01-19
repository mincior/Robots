Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Services
Imports Google.Apis.Sheets.v4
Imports Newtonsoft.Json
Imports System
Imports Data = Google.Apis.Sheets.v4.Data

Namespace SheetsSample
    Public Class SheetsExample
        Public Shared Sub Main(ByVal args As String())
            Dim sheetsService As SheetsService = New SheetsService(New BaseClientService.Initializer With {
                .HttpClientInitializer = GetCredential(),
                .ApplicationName = "Google-SheetsSample/0.1"
            })
            Dim spreadsheetId As String = "my-spreadsheet-id"
            Dim range As String = "my-range"
            Dim valueInputOption As SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum = CType(0, SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum)
            Dim insertDataOption As SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum = CType(0, SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum)
            Dim requestBody As Data.ValueRange = New Data.ValueRange()
            Dim request As SpreadsheetsResource.ValuesResource.AppendRequest = sheetsService.Spreadsheets.Values.Append(requestBody, spreadsheetId, range)
            request.ValueInputOption = valueInputOption
            request.InsertDataOption = insertDataOption
            Dim response As Data.AppendValuesResponse = request.Execute()
            Console.WriteLine(JsonConvert.SerializeObject(response))
        End Sub

        Public Shared Function GetCredential() As UserCredential
            Return Nothing
        End Function
    End Class
End Namespace
