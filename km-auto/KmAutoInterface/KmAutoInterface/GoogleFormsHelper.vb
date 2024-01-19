Imports Google.Apis
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Services
Imports Google.Apis.Forms.v1

Imports Newtonsoft.Json
Imports System.IO
Imports Google.Apis.Sheets.v4

Public Class GoogleFormsHelper
    Public Property Resource As FormsResource
    Public Property Service As FormsService
    Const APPLICATION_NAME As String = "kmAuto"
    Shared ReadOnly Scopes As String() = {FormsService.Scope.FormsBody, FormsService.Scope.FormsResponsesReadonly, FormsService.Scope.Drive, FormsService.Scope.DriveFile}
    Public Sub New()
        InitializeServiceAndResource()
    End Sub

    Private Sub InitializeServiceAndResource()
        Dim credential = GetCredentialsFromFile()
        Service = New FormsService(New BaseClientService.Initializer() With {
            .HttpClientInitializer = credential,
            .ApplicationName = APPLICATION_NAME
        })
        Resource = New FormsResource(Service)
    End Sub

    Private Function GetCredentialsFromFile() As GoogleCredential
        Dim credential As GoogleCredential

        Using stream = New FileStream(AppPath & "input\google_service_key.json", FileMode.Open, FileAccess.Read)
            credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes)
        End Using

        Return credential
    End Function
    Public Function GetFormChoiceItem(formId As String, title As String, ByRef locationIndex As Integer) As Google.Apis.Forms.v1.Data.Item
        GetFormChoiceItem = New Google.Apis.Forms.v1.Data.Item
        Dim myForm = Me.Resource.Get(formId).Execute()
        For Each item As Google.Apis.Forms.v1.Data.Item In myForm.Items
            locationIndex += 1 '
            If title = item.Title Then 'sunt pe item-ul dorit
                GetFormChoiceItem = item
                Exit Function
            End If
        Next
    End Function


    Public Function GetFormChoiceItemAsDictionary(formId As String, title As String) As Dictionary(Of String, String)
        GetFormChoiceItemAsDictionary = New Dictionary(Of String, String)
        Dim myDict As New Dictionary(Of String, String) 'add new list 
        Dim myForm = Me.Resource.Get(formId).Execute(), locationIndex As Integer = -1
        For Each item As Google.Apis.Forms.v1.Data.Item In myForm.Items
            locationIndex += 1 '
            If title = item.Title Then 'sunt pe item-ul dorit
                If Not item.QuestionItem Is Nothing Then
                    If Not item.QuestionItem.Question Is Nothing Then
                        myDict.Add("LocationIndex", locationIndex)
                        myDict.Add("Id", item.ItemId)
                        myDict.Add("Title", item.Title)

                        'add item description
                        If Not item.Description Is Nothing Then
                            myDict.Add("Description", item.Description)
                        Else
                            myDict.Add("Description", "Not present")
                        End If

                        'add question id
                        myDict.Add("QuestionId", item.QuestionItem.Question.QuestionId)

                        'add question item required
                        If Not item.QuestionItem.Question.Required Is Nothing Then
                            myDict.Add("QuestionRequired", "True")
                        Else
                            myDict.Add("QuestionRequired", "Not present")
                        End If
                        If Not item.QuestionItem.Question.ChoiceQuestion Is Nothing Then
                            If Not item.QuestionItem.Question.ChoiceQuestion.Options Is Nothing Then

                                'add choiceQuestion type
                                myDict.Add("ChoiceQuestionType", item.QuestionItem.Question.ChoiceQuestion.Type)

                                'add choiceQuestion options
                                For Each queOptVal In item.QuestionItem.Question.ChoiceQuestion.Options
                                    myDict.Add(queOptVal.Value, queOptVal.Value)
                                Next
                                'Stop
                                Exit For
                            End If
                        Else
                            myDict.Add("ChoiceQuestionType", "Not present")

                        End If
                    End If
                End If
            End If
        Next
        GetFormChoiceItemAsDictionary = myDict
    End Function
    Public Function UpdateChoiceItem(formId As String, title As String, myList As List(Of String), Optional Position As Integer = 9999) As String
        UpdateChoiceItem = "Eroare setare item."
        Dim body As New Google.Apis.Forms.v1.Data.BatchUpdateFormRequest(), locationIndex As Integer = -1
        With body
            .IncludeFormInResponse = True
            .Requests = New List(Of Google.Apis.Forms.v1.Data.Request)
            With .Requests
                Dim request As New Google.Apis.Forms.v1.Data.Request
                With request
                    .UpdateItem = New Google.Apis.Forms.v1.Data.UpdateItemRequest
                    With .UpdateItem
                        Dim item As Google.Apis.Forms.v1.Data.Item = Me.GetFormChoiceItem(formId, title, locationIndex) 'returneaza byref si locationIndex
                        Dim k As Long
                        With item.QuestionItem.Question.ChoiceQuestion
                            Dim newOptions As New List(Of Google.Apis.Forms.v1.Data.Option) 'avem nevoie de un nou obiect ChoiceQuestion caruia sa-i adaugam optiunile
                            For k = 0 To .Options.Count - 1
                                If k = Position Then 'adaugam optiunile la pozitia Position 
                                    Dim i As Long
                                    For i = 0 To myList.Count - 1
                                        Dim opty = New Google.Apis.Forms.v1.Data.Option
                                        opty.Value = myList(i)
                                        newOptions.Add(opty)
                                    Next
                                End If
                                Dim optx = New Google.Apis.Forms.v1.Data.Option
                                optx.Value = .Options(k).Value 'dar avem nevoie si de obiectul vechi ChoiceQuestion pentru a citi optiunile existente
                                newOptions.Add(optx)
                            Next
                            If Position > .Options.Count - 1 Then 'adaugam optiunile la final
                                Dim i As Long
                                For i = 0 To myList.Count - 1
                                    Dim opty = New Google.Apis.Forms.v1.Data.Option
                                    opty.Value = myList(i)
                                    newOptions.Add(opty)
                                Next
                            End If
                            .Options = newOptions
                        End With
                        .Item = item
                        .UpdateMask = "*"
                        Dim location = New Google.Apis.Forms.v1.Data.Location
                        location.Index = locationIndex
                        .Location = location
                    End With
                End With
                .Add(request)
            End With
        End With
        Try
            Dim resp = Me.Resource.BatchUpdate(body, formId).Execute()
            If Not resp Is Nothing AndAlso Not resp.Form Is Nothing Then
                UpdateChoiceItem = "Item setat Ok."
            End If

        Catch ex As System.Exception

        End Try
        'Stop
    End Function
    Public Function UpdateItemDescription(formId As String, title As String, description As String) As String
        UpdateItemDescription = "Eroare setare item description."
        Dim body As New Google.Apis.Forms.v1.Data.BatchUpdateFormRequest(), locationIndex As Integer = -1
        With body
            .IncludeFormInResponse = True
            .Requests = New List(Of Google.Apis.Forms.v1.Data.Request)
            With .Requests
                Dim request As New Google.Apis.Forms.v1.Data.Request
                With request
                    .UpdateItem = New Google.Apis.Forms.v1.Data.UpdateItemRequest
                    With .UpdateItem
                        Dim item As Google.Apis.Forms.v1.Data.Item = Me.GetFormChoiceItem(formId, title, locationIndex) 'returneaza byref si locationIndex
                        item.Description = description
                        .Item = item
                        .UpdateMask = "*"
                        Dim location = New Google.Apis.Forms.v1.Data.Location
                        location.Index = locationIndex
                        .Location = location
                    End With
                End With
                .Add(request)
            End With
        End With
        Try
            Dim resp = Me.Resource.BatchUpdate(body, formId).Execute()
            If Not resp Is Nothing AndAlso Not resp.Form Is Nothing Then
                UpdateItemDescription = "Item description setat Ok."
            End If

        Catch ex As System.Exception

        End Try
        'Stop
    End Function
    Public Function DeleteOptionsFromChoiceItem(formId As String, title As String, masiniDeSters As List(Of String)) As String
        DeleteOptionsFromChoiceItem = "Eroare stergere optiuni item."
        Dim body As New Google.Apis.Forms.v1.Data.BatchUpdateFormRequest(), locationIndex As Integer = -1, cevaDeSters As Boolean
        With body
            .IncludeFormInResponse = True
            .Requests = New List(Of Google.Apis.Forms.v1.Data.Request)
            With .Requests
                Dim request As New Google.Apis.Forms.v1.Data.Request
                With request
                    .UpdateItem = New Google.Apis.Forms.v1.Data.UpdateItemRequest
                    With .UpdateItem
                        Dim item As Google.Apis.Forms.v1.Data.Item = Me.GetFormChoiceItem(formId, title, locationIndex) 'returneaza byref si locationIndex
                        Dim k As Long, gasit As Boolean
                        With item.QuestionItem.Question.ChoiceQuestion
                            Do 'trebuie reluata stergerea de fiecare data pana nu mai gaseste nimic de sters, altfel se modifica contorul
                                For k = 0 To .Options.Count - 1
                                    gasit = False
                                    Dim i As Long
                                    For i = 0 To masiniDeSters.Count - 1
                                        If .Options(k).Value = masiniDeSters(i) Then
                                            .Options.RemoveAt(k)
                                            gasit = True
                                            cevaDeSters = True
                                            Exit For
                                        End If
                                    Next
                                    If gasit = True Then Exit For
                                Next
                            Loop Until gasit = False
                        End With
                        .Item = item
                        .UpdateMask = "*"
                        Dim location = New Google.Apis.Forms.v1.Data.Location
                        location.Index = locationIndex
                        .Location = location
                    End With
                End With
                .Add(request)
            End With
        End With
        Dim resp = Me.Resource.BatchUpdate(body, formId).Execute()
        If Not resp Is Nothing AndAlso Not resp.Form Is Nothing Then
            If cevaDeSters = True Then
                DeleteOptionsFromChoiceItem = "Optiuni item sterse Ok."
            Else
                DeleteOptionsFromChoiceItem = "Nimic de sters."

            End If
        End If
        'Stop
    End Function

    Public Function CreateItem(title As String, description As String, lstOptions As List(Of String), formId As String) As String
        CreateItem = "Eroare setare item."
        Dim body As New Google.Apis.Forms.v1.Data.BatchUpdateFormRequest()
        With body
            .IncludeFormInResponse = True
            .Requests = New List(Of Google.Apis.Forms.v1.Data.Request)
            With .Requests
                Dim request As New Google.Apis.Forms.v1.Data.Request
                With request
                    .CreateItem = New Google.Apis.Forms.v1.Data.CreateItemRequest
                    With .CreateItem
                        .Item = New Google.Apis.Forms.v1.Data.Item
                        With .Item
                            .Title = title
                            .Description = description
                            .QuestionItem = New Google.Apis.Forms.v1.Data.QuestionItem
                            With .QuestionItem
                                .Question = New Google.Apis.Forms.v1.Data.Question
                                With .Question
                                    .ChoiceQuestion = New Google.Apis.Forms.v1.Data.ChoiceQuestion
                                    With .ChoiceQuestion
                                        .Type = "DROP_DOWN"
                                        .Options = New List(Of Google.Apis.Forms.v1.Data.Option)
                                        With .Options
                                            For Each opt As String In lstOptions
                                                Dim optx = New Google.Apis.Forms.v1.Data.Option
                                                optx.Value = opt
                                                .Add(optx)
                                            Next
                                        End With
                                    End With
                                End With
                            End With
                        End With
                        Dim location = New Google.Apis.Forms.v1.Data.Location
                        location.Index = 0
                        .Location = location
                    End With
                End With
                .Add(request)
            End With
        End With
        Dim resp = Me.Resource.BatchUpdate(body, formId).Execute()
        If Not resp Is Nothing AndAlso Not resp.Form Is Nothing Then
            CreateItem = "Item setat Ok."
        End If
        'Stop

    End Function

    'ciorna

    'With .Item
    '    .Title = title
    '    .Description = description
    '    .QuestionItem = New Google.Apis.Forms.v1.Data.QuestionItem
    '    With .QuestionItem
    '        .Question = New Google.Apis.Forms.v1.Data.Question
    '        With .Question
    '            .ChoiceQuestion = New Google.Apis.Forms.v1.Data.ChoiceQuestion
    '            With .ChoiceQuestion
    '                .Type = "DROP_DOWN"
    '                .Options = New List(Of Google.Apis.Forms.v1.Data.Option)
    '                With .Options
    '                    For Each opt As String In lstOptions
    '                        Dim optx = New Google.Apis.Forms.v1.Data.Option
    '                        optx.Value = opt
    '                        .Add(optx)
    '                    Next
    '                End With
    '            End With
    '        End With
    '    End With
    'End With

End Class
