Attribute VB_Name = "Export"
Option Explicit
Dim dictConfig As New Scripting.Dictionary
Dim arrGreseliLog()
Const numeRobot As String = "KmAuto"


Private Sub conf(seteaza As Boolean)
Application.DisplayAlerts = False
Dim mySql As String, arrMasini(), arrUtilizatori(), utilizatorId As Long, masinaId As Long
'incarca masinile
mySql = "Select * from Masini"
Call ExecutaSQLNew("MyQuery", mySql, "KmAuto")
arrMasini = Range("MyQuery").Value

'incarca utilizatorii (soferii)
mySql = "Select * from Utilizatori"
Call ExecutaSQLNew("MyQuery", mySql, "KmAuto")
arrUtilizatori = Range("MyQuery").Value

'incarca setari roboti
Set dictConfig = incarcaSetari(numeRobot)
'detecteaza celula curenta din foaia curenta
Dim foaie As Worksheet
Set foaie = ActiveWorkbook.ActiveSheet
Dim range1 As Range
Set range1 = Selection
Dim k As Long
Dim s As String, v() As String, v1() As String, v2() As String, utilizator As String, masina As String, data As String
On Error Resume Next
s = range1.Comment.Text
On Error GoTo 0
If s <> "" Then 'exista comentariu
    v = Split(s, vbLf)
    v1 = Split(v(1), "-")
    masina = Trim(v1(0)) & "-" & Trim(v1(1)) & "-" & Trim(v1(2))
    v2 = Split(v1(UBound(v1)), ":")
    utilizator = Trim(v2(0))
    For k = 4 To UBound(v)
        If InStr(1, v(k), "=") Then
            v1 = Split(v(k), " = ")
            data = Trim(v1(0)) & ".000"
            utilizatorId = ReturUtilizatorIdDupaNume(utilizator, arrUtilizatori)
            masinaId = ReturMasinaIdDupaNumar(masina, arrMasini)
            scrieAsumatInKmLog seteaza, data, utilizatorId, masinaId
        End If
        
    Next k
End If
Application.DisplayAlerts = True

range1.Select
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 5287936
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    If seteaza = True Then
        With Selection.Font
            .ThemeColor = xlThemeColorDark1
            .TintAndShade = 0
        End With
    Else
        With Selection.Font
            .Color = -16776961
            .TintAndShade = 0
        End With
    End If
End Sub

Private Sub scrieAsumatInKmLog(seteaza As Boolean, data As String, utilizatorId As Long, masinaId As Long)
'afla id-urile utilizatorului si masinii

Dim conn As New ADODB.Connection
Dim iRowNo As Integer
Dim sFirstName, sLastName As String
conn.Open "Provider=SQLOLEDB; Data Source=10.0.0.10;Initial Catalog=KmAuto ;Persist Security Info=True;User ID=sa;  Password = P@ssword"
conn.Execute "UPDATE KmLog SET Asumat ='" & IIf(seteaza = True, "Da", "Nu") & "' Where Data = '" & data & "' and MasinaId = '" & masinaId & "' and UtilizatorId = '" & utilizatorId & "'"
conn.Close
Set conn = Nothing

End Sub
Public Function incarcaSetari(numeRobot As String) As Scripting.Dictionary
'Incarca setarile din 'Configurare roboti'
Dim arrConfig(), dt As Date
arrConfig = AduceSetariRobotiDinSqlServer(numeRobot)
Dim arrNumarRand(), arrSetari(), dict As Scripting.Dictionary, ws As Workbook, k As Long
arrSetari = Array("0", _
"Nume robot", _
"Nume aplicatie", _
"Cale aplicatie", _
"Extrage rapoarte excel din BI", _
"Extrage rapoarte exccel din ERP", _
"Executa SQL", _
"Executa macro excel", _
"Imparte pe filiale", _
"Imparte pe agenti", _
"Numar luni actualizate", _
"Data interogare", _
"Fisiere BI", _
"Trimite emailuri", _
"Trimite emailuri doar la admin", _
"Tip raport", _
"Email admin", _
"Email admin BCC", _
"Email subiect", _
"Email continut", _
"Email To", _
"Email CC", _
"Email BCC", _
"Info", _
"Imparte pe filiale mail", "Imparte pe agenti mail", "Temporizare intre emailuri", "Extrage rapoarte din BI alt", "Extrage rapoarte din ERP alt", "Executa Sql alt", "Numar luni actualizate alt")
'face legatura intre numele setarii din foaia MyQuery si numarul randului (exista si randuri goale)
arrNumarRand = Array(0, 2, 18, 3, 16, 17, 20, 15, 23, 24, 21, 4, 19, 14, 13, 12, 8, 9, 10, 6, 11, 7, 5, 22, 38, 39, 41, 42, 43, 44, 45)

Set dict = New Scripting.Dictionary
'Set ws = Workbooks.Open("C:\Robots\Configurare roboti.xlsm")
    Sheets("MyQuery").Select
    dict(arrSetari(1)) = numeRobot
    'Debug.Print dict(arrSetari(1))
For k = 2 To UBound(arrSetari)
    dict(arrSetari(k)) = arrConfig(1, arrNumarRand(k))
    'Debug.Print dict(arrSetari(k))
Next k
If dict.Exists("Data interogare") Then
    If dict("Data interogare") = "" Then
        dt = Now()
        dict("Data interogare") = Format(dt, "yyyy-mm-dd")
    End If
End If

Set incarcaSetari = dict
Set dict = Nothing
Sheets("Sheet1").Select
End Function
Public Function AduceSetariRobotiDinSqlServer(numeRobot As String) As Variant
Dim mySql As String, dictSettings As New Scripting.Dictionary
On Error Resume Next
    ActiveWorkbook.Queries("MyQuery").Delete
    Sheets("MyQuery").Delete
    ActiveSheet.ListObjects("MyQuery").Delete
    'MkDir dictSettings("Cale aplicatie") & dictSettings("Nume aplicatie") & "\data\" & dictSettings("Data interogare")
    
On Error GoTo 0
    mySql = "Select * from Config Where NumeRobot = '" & numeRobot & "'"
    Call ExecutaSQLNew("MyQuery", mySql, "Robots")
    AduceSetariRobotiDinSqlServer = Range("MyQuery").Value
End Function


Sub ExecutaSQL(Nume As String, Sql As String)

On Error Resume Next
    ActiveWorkbook.Queries("MyQuery").Delete
    Sheets("MyQuery").Delete
    ActiveSheet.ListObjects("MyQuery").Delete
    'MkDir dictSettings("Cale aplicatie") & dictSettings("Nume aplicatie") & "\data\" & dictSettings("Data interogare")
    
On Error GoTo 0

Dim sh As Worksheet
    'Sql = "let" & Chr(13) & "" & Chr(10) & "    Source = Sql.Database(""10.0.0.10"", """ & DatabaseName & """, [Query=""" & Sql & """])" & Chr(13) & "" & Chr(10) & "in" & Chr(13) & "" & Chr(10) & "    Source"
    ActiveWorkbook.Queries.Add Name:=Nume, Formula:=Sql
    Set sh = ActiveWorkbook.Worksheets.Add(After:=ActiveWorkbook.Sheets(1))
    sh.Name = Nume
    
    With ActiveSheet.ListObjects.Add(SourceType:=0, Source:= _
        "OLEDB;Provider=Microsoft.Mashup.OleDb.1;Data Source=$Workbook$;Location=" & Nume & ";Extended Properties=""""" _
        , Destination:=Range("$A$1")).QueryTable
        .CommandType = xlCmdSql
        .CommandText = Array("SELECT * FROM [" & Nume & "]")
        .RowNumbers = False
        .FillAdjacentFormulas = False
        .PreserveFormatting = True
        .RefreshOnFileOpen = False
        .BackgroundQuery = True
        .RefreshStyle = xlInsertDeleteCells
        .SavePassword = False
        .SaveData = True
        .AdjustColumnWidth = True
        .RefreshPeriod = 0
        .PreserveColumnInfo = True
        .ListObject.DisplayName = Nume
        .Refresh BackgroundQuery:=False
    End With
End Sub
Sub ExecutaWebQuery()
On Error Resume Next
    ActiveWorkbook.Queries("MyQuery").Delete
    Sheets("MyQuery").Delete
    ActiveSheet.ListObjects("MyQuery").Delete
    'MkDir dictSettings("Cale aplicatie") & dictSettings("Nume aplicatie") & "\data\" & dictSettings("Data interogare")
    
On Error GoTo 0

    ActiveWorkbook.Queries.Add Name:="MyQuery", Formula:= _
        "let" & Chr(13) & "" & Chr(10) & "    Source = Excel.Workbook(Web.Contents(""https://docs.google.com/spreadsheets/d/1ZPJOW3ue_x8q-y72lKvE600qRdYS7dPoEUHshzxVOWw/export?format=xlsx&id=1ZPJOW3ue_x8q-y72lKvE600qRdYS7dPoEUHshzxVOWw""), null, true)," & Chr(13) & "" & Chr(10) & "    #""Form Responses 1_Sheet"" = Source{[Item=""Form Responses 1"",Kind=""Sheet""]}[Data]," & Chr(13) & "" & Chr(10) & "    #""Promoted Headers"" = Table.PromoteHeaders(#""Form R" & _
        "esponses 1_Sheet"", [PromoteAllScalars=true])," & Chr(13) & "" & Chr(10) & "    #""Changed Type"" = Table.TransformColumnTypes(#""Promoted Headers"",{{""Timestamp"", type datetime}, {""Nume"", type text}, {""Email"", type text}, {""Limita km"", Int64.Type}, {""Filiala"", type text}, {""Activ"", type text}, {""Retinere"", type text}})" & Chr(13) & "" & Chr(10) & "in" & Chr(13) & "" & Chr(10) & "    #""Changed Type"""
    ActiveWorkbook.Worksheets.Add
    With ActiveSheet.ListObjects.Add(SourceType:=0, Source:= _
        "OLEDB;Provider=Microsoft.Mashup.OleDb.1;Data Source=$Workbook$;Location=""MyQuery"";Extended Properties=""""" _
        , Destination:=Range("$A$1")).QueryTable
        .CommandType = xlCmdSql
        .CommandText = Array("SELECT * FROM [MyQuery]")
        .RowNumbers = False
        .FillAdjacentFormulas = False
        .PreserveFormatting = True
        .RefreshOnFileOpen = False
        .BackgroundQuery = True
        .RefreshStyle = xlInsertDeleteCells
        .SavePassword = False
        .SaveData = True
        .AdjustColumnWidth = True
        .RefreshPeriod = 0
        .PreserveColumnInfo = True
        .ListObject.DisplayName = "MyQuery"
        .Refresh BackgroundQuery:=False
    End With
    Sheets("config").Select

End Sub
Public Sub ExecutaNativeSQL(Sql, DatabaseName As String)
Dim conn As New ADODB.Connection
Dim iRowNo As Integer
Dim sFirstName, sLastName As String
On Error GoTo errP
conn.Open "Provider=SQLOLEDB; Data Source=10.0.0.10;Initial Catalog=" & DatabaseName & ";Persist Security Info=True;User ID=sa;  Password = P@ssword"
conn.Execute Sql
conn.Close
Set conn = Nothing
Exit Sub
errP:
Debug.Print (Err.Description)
End Sub
Sub exec()
'Dim mySql As String
'mySql = "insert into dbo.GreseliLog (UtilizatorId, Interval, GresealaId) Values (1,'27',3), (4,'57',6); "
'Call ExecutaNativeSQL(mySql, "KmAuto")
'Stop


End Sub
Sub ExecutaSQLNew(Nume As String, Sql As String, DatabaseName As String)

On Error Resume Next
    ActiveWorkbook.Queries("MyQuery").Delete
    Sheets("MyQuery").Delete
    ActiveSheet.ListObjects("MyQuery").Delete
    'MkDir dictSettings("Cale aplicatie") & dictSettings("Nume aplicatie") & "\data\" & dictSettings("Data interogare")
    
On Error GoTo 0

Dim sh As Worksheet
    Sql = "let" & Chr(13) & "" & Chr(10) & "    Source = Sql.Database(""10.0.0.10"", """ & DatabaseName & """, [Query=""" & Sql & """])" & Chr(13) & "" & Chr(10) & "in" & Chr(13) & "" & Chr(10) & "    Source"
    ActiveWorkbook.Queries.Add Name:=Nume, Formula:=Sql
    Set sh = ActiveWorkbook.Worksheets.Add(After:=ActiveWorkbook.Sheets(1))
    sh.Name = Nume
    
    With ActiveSheet.ListObjects.Add(SourceType:=0, Source:= _
        "OLEDB;Provider=Microsoft.Mashup.OleDb.1;Data Source=$Workbook$;Location=" & Nume & ";Extended Properties=""""" _
        , Destination:=Range("$A$1")).QueryTable
        .CommandType = xlCmdSql
        .CommandText = Array("SELECT * FROM [" & Nume & "]")
        .RowNumbers = False
        .FillAdjacentFormulas = False
        .PreserveFormatting = True
        .RefreshOnFileOpen = False
        .BackgroundQuery = True
        .RefreshStyle = xlInsertDeleteCells
        .SavePassword = False
        .SaveData = True
        .AdjustColumnWidth = True
        .RefreshPeriod = 0
        .PreserveColumnInfo = True
        .ListObject.DisplayName = Nume
        .Refresh BackgroundQuery:=False
    End With
End Sub
Private Function ReturUtilizatorIdDupaNume(Nume As String, arrUtilizatori()) As Long
Dim k As Long
For k = 1 To UBound(arrUtilizatori, 1)
    If arrUtilizatori(k, 2) = Nume Then
        ReturUtilizatorIdDupaNume = arrUtilizatori(k, 1)
        Exit For
    End If
Next k
'Stop
End Function
Private Function ReturMasinaIdDupaNumar(Numar As String, arrMasini()) As Long
Dim k As Long
For k = 1 To UBound(arrMasini, 1)
    If arrMasini(k, 2) = Numar Then
        ReturMasinaIdDupaNumar = arrMasini(k, 1)
        Exit For
    End If
Next k
'Stop
End Function



Sub confirma()

End Sub
Sub infirma()

End Sub
