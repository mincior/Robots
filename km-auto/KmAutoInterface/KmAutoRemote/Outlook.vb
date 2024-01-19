Imports System.IO
Imports ol = Microsoft.Office.Interop.Outlook
Module Outlook

    Public Function sendSimpleEmail(toAddress As String, subject As String, body As String, Optional anotherToAddress As String = "") As String
        Dim OutlookMessage As ol.MailItem
        Dim AppOutlook As New ol.Application
        Try
            OutlookMessage = AppOutlook.CreateItem(ol.OlItemType.olMailItem)
            Dim Recipents As ol.Recipients = OutlookMessage.Recipients

            Recipents.Add(toAddress)
            If anotherToAddress <> "" Then
                Recipents.Add(anotherToAddress)
            End If
            OutlookMessage.Subject = subject
            OutlookMessage.Body = body
            OutlookMessage.BodyFormat = ol.OlBodyFormat.olFormatPlain
            OutlookMessage.Send()
            sendSimpleEmail = "Mail sent!" 'if you dont want this message, simply delete this line 
        Catch ex As Exception
            sendSimpleEmail = "Mail could not be sent!" 'if you dont want this message, simply delete this line 
        Finally
            OutlookMessage = Nothing
            AppOutlook = Nothing
        End Try
    End Function
    Public Sub sendEmailViaOutlook(ByVal sFromAddress As String, ByVal sToAddress As String, ByVal sCc As String, ByVal sSubject As String, ByVal sBody As String, ByVal Optional arrAttachments As List(Of String) = Nothing)
        'o alta varianta, nefolosita in aceasta aplicatie
        Try
            Dim app As ol.Application = New ol.Application()
            Dim newMail As ol.MailItem = CType(app.CreateItem(ol.OlItemType.olMailItem), ol.MailItem)

            If Not String.IsNullOrWhiteSpace(sToAddress) Then
                Dim arrAddTos As String() = sToAddress.Split(New Char() {";"c, ","c})

                For Each strAddr As String In arrAddTos
                    If Not String.IsNullOrWhiteSpace(strAddr) AndAlso strAddr.IndexOf("@"c) <> -1 Then
                        newMail.Recipients.Add(strAddr.Trim())
                    Else
                        Throw New Exception("Bad to-address: " & sToAddress)
                    End If
                Next
            Else
                Throw New Exception("Must specify to-address")
            End If

            If Not String.IsNullOrWhiteSpace(sCc) Then
                Dim arrAddTos As String() = sCc.Split(New Char() {";"c, ","c})

                For Each strAddr As String In arrAddTos

                    If Not String.IsNullOrWhiteSpace(strAddr) AndAlso strAddr.IndexOf("@"c) <> -1 Then
                        newMail.Recipients.Add(strAddr.Trim())
                    Else
                        Throw New Exception("Bad CC-address: " & sCc)
                    End If
                Next
            End If

            If Not newMail.Recipients.ResolveAll() Then
                Throw New Exception("Failed to resolve all recipients: " & sToAddress & ";" & sCc)
            End If

            If arrAttachments IsNot Nothing Then

                For Each strPath As String In arrAttachments

                    If File.Exists(strPath) Then
                        newMail.Attachments.Add(strPath)
                    Else
                        Throw New Exception("Attachment file is not found: """ & strPath & """")
                    End If
                Next
            End If

            If Not String.IsNullOrWhiteSpace(sSubject) Then newMail.Subject = sSubject
            If Not String.IsNullOrWhiteSpace(sBody) Then newMail.Body = sBody
            Dim accounts As ol.Accounts = app.Session.Accounts
            Dim acc As ol.Account = Nothing

            For Each account As ol.Account In accounts

                If account.SmtpAddress.Equals(sFromAddress, StringComparison.CurrentCultureIgnoreCase) Then
                    acc = account
                    Exit For
                End If
            Next

            If acc IsNot Nothing Then
                newMail.SendUsingAccount = acc
                newMail.Send()
            Else
                Throw New Exception("Account does not exist in ol: " & sFromAddress)
            End If

        Catch ex As Exception
            Console.WriteLine("ERROR: Failed to send mail: " & ex.Message)
        End Try
    End Sub
End Module
