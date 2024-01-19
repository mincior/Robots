Imports System.ComponentModel
Imports System.Windows.Automation
Imports System.Windows.Automation.Text
Imports Google.Apis.Sheets.v4.Data
Imports Microsoft.Office.Interop.Outlook

Public Class frmGoogleForms
    Private Sub cmdIesire_Click(sender As Object, e As EventArgs) Handles cmdIesire.Click
        Me.Close()

    End Sub

    Private Sub frmGoogleForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 795, 834)

    End Sub

    Private Sub frmGoogleForms_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)

    End Sub
    Private Sub cmdMasiniUtilizatori_Click(sender As Object, e As EventArgs) Handles cmdMasiniUtilizatori.Click
        gstrSearch = ""
        Try
            gstrSearch = ListBoxItemContent.SelectedItem

        Catch ex As System.Exception

        End Try
        If gstrSearch <> "" Then
            If ListBoxItems.SelectedItem = "Masina" Then
                frmMasini.ShowDialog()
                frmMasini.Dispose()

            Else
                frmUtilizatori.ShowDialog()
                frmUtilizatori.Dispose()

            End If
        End If
    End Sub


    Private Sub IncarcaFormuri()
        lvForms.Items.Clear()

        Dim formsDataTable As System.Data.DataTable = ReturDataTableKmAuto("Select Nume, Filiala, Activ, SpreadsheetId from Spreadsheets Where Foaie = N'' and SheetId = N'' and Activ = 'Da'")
        For Each row As DataRow In formsDataTable.Rows
            Dim lvu As ListViewItem = lvForms.Items.Add(row("Nume"))
            lvu.SubItems.Add(row("Filiala"))
            lvu.SubItems.Add(row("Activ"))
            lvu.SubItems.Add(row("SpreadsheetId"))
        Next
        lvForms.EndUpdate()
        lvForms.Refresh()
        ' cmbItems.SelectedIndex = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        IncarcaFormuri()
        ListBoxItems.SelectedIndex = 0
        lvForms.Items(0).Selected = True
        txtCautareMasinaSauUtilizator.Select()

    End Sub


    Private Sub incarcaItems()
        'incarca item
        lblItemLocation.Text = ""
        lblId.Text = ""
        lblTitle.Text = ""
        TextBoxDescription.Text = ""
        lblQuestionId.Text = ""
        lblQuestionRequired.Text = ""
        lblChoiceQuestionType.Text = ""
        lblId.Text = ""

        If lvForms.SelectedItems.Count > 0 And ListBoxItems.SelectedItems.Count > 0 Then
            ListBoxItemContent.Items.Clear()
            Dim gsh As New GoogleFormsHelper
            Dim myDict As Dictionary(Of String, String), item As String = ListBoxItems.SelectedItem, formId As String = lvForms.SelectedItems(0).SubItems(3).Text
            myDict = gsh.GetFormChoiceItemAsDictionary(formId, item)
            If myDict.Keys.Count > 0 Then
                Dim k As Long
                For Each s As String In myDict.Keys
                    If k > 6 Then
                        ListBoxItemContent.Items.Add(myDict(s))
                    End If
                    k += 1
                Next
                k = 0
                lblItemLocation.Text = myDict("LocationIndex")
                lblId.Text = myDict("Id")
                lblTitle.Text = myDict("Title")
                TextBoxDescription.Text = myDict("Description")
                lblQuestionId.Text = myDict("QuestionId")
                lblQuestionRequired.Text = myDict("QuestionRequired")
                lblChoiceQuestionType.Text = myDict("ChoiceQuestionType")
                lblId.Text = myDict("Id")
            End If
        End If
        SelectListBoxItemContent(cmbMasiniSauUtilizatori.Text)

    End Sub

    Private Sub ListBoxItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxItems.SelectedIndexChanged
        incarcaItems()
        Select Case ListBoxItems.SelectedItem
            Case "Masina"
                cmbMasiniSauUtilizatori.Items.Clear()
                'incarca toate masinile in cmb cmbMasiniSauUtilizatori
                Dim masiniDataTable = ReturDataTableKmAuto("Select Numar from Masini order by Numar asc")
                For Each row As DataRow In masiniDataTable.Rows
                    cmbMasiniSauUtilizatori.Items.Add(row("Numar"))
                Next

            Case "Utilizator"
                cmbMasiniSauUtilizatori.Items.Clear()
                'incarca toate masinile in cmb cmbMasiniSauUtilizatori
                Dim masiniDataTable = ReturDataTableKmAuto("Select Nume from Utilizatori order by Nume asc")
                For Each row As DataRow In masiniDataTable.Rows
                    cmbMasiniSauUtilizatori.Items.Add(row("Nume"))
                Next

        End Select
    End Sub

    Private Sub lvSpreadsheets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvForms.SelectedIndexChanged
        incarcaItems()
    End Sub

    Private Sub cmdSelecteazaTot_Click(sender As Object, e As EventArgs) Handles cmdSelecteazaTot.Click
        sel(lvForms, True)
    End Sub
    Private Sub sel(listView As ListView, sel As Boolean)
        For Each lv As ListViewItem In listView.Items
            lv.Checked = sel
        Next
    End Sub

    Private Sub cmdDeselecteazaTot_Click(sender As Object, e As EventArgs) Handles cmdDeselecteazaTot.Click
        sel(lvForms, False)

    End Sub

    Private Sub cmdUpdateDescription_Click(sender As Object, e As EventArgs) Handles cmdUpdateDescription.Click
        pbIncarca.Maximum = lvForms.CheckedItems.Count
        Dim result As DialogResult = MessageBox.Show("Atentie. Se va modifica descrierea pentru item-ul curent pentru toate formulare Google bifate. " & vbCrLf & "Continuati? ", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            pbIncarca.Value = 0
            Dim k As Integer = 0
            Dim gfh As New GoogleFormsHelper, succes As String = "Update description: "
            For Each lv As ListViewItem In lvForms.CheckedItems
                pbIncarca.Value = k
                k += 1
                Dim formId As String = lv.SubItems(3).Text
                Dim res As String = gfh.UpdateItemDescription(formId, ListBoxItems.SelectedItem, TextBoxDescription.Text)
                If res = "Item description setat Ok." Then succes &= lv.SubItems(0).Text & " - Ok" & vbCrLf
            Next
            pbIncarca.Value = pbIncarca.Maximum
            MessageBox.Show(succes)
        Else
            pbIncarca.Value = pbIncarca.Maximum
            MessageBox.Show("Selectati cel putin un formular.")
        End If
        pbIncarca.Value = 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdDeschideFoaiaGoogle_Click(sender As Object, e As EventArgs) Handles cmdDeschideFoaiaGoogle.Click
        Dim formId As String = lvForms.SelectedItems(0).SubItems(3).Text
        Dim url As String = "https://docs.google.com/forms/d/" & formId
        If tabExists(url).Length > 0 Then
        Else
            Process.Start(url)
        End If


    End Sub
    Private Sub CautaMasinaSauUtilizator(what As String)
        If ListBoxItems.SelectedItem = "Masina" Then
            Dim sql As String = "SELECT  dbo.MasiniInGoogle.Numar, dbo.Spreadsheets.Nume AS foaie, dbo.Spreadsheets.Filiala " &
                     "FROM dbo.MasiniInGoogle INNER JOIN " &
                     "dbo.Spreadsheets ON dbo.MasiniInGoogle.SpreadsheetId = dbo.Spreadsheets.SpreadsheetId " &
                     "WHERE (dbo.Spreadsheets.Activ = 'Da') AND (dbo.Spreadsheets.Foaie = N'') AND (dbo.Spreadsheets.SheetId = N'') AND (dbo.MasiniInGoogle.Numar LIKE '%" & what & "%')"
            sql = clearSql(sql)
            Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto(sql)
            For Each row As DataRow In myDataTable.Rows
                If lvExists(lvOutput, row("Numar"), "--", row("foaie")) = False Then
                    Dim lvu As ListViewItem = lvOutput.Items.Add(row("Numar"))
                    lvu.SubItems.Add("--")
                    lvu.SubItems.Add(row("foaie"))
                    lvu.SubItems.Add(row("filiala"))
                End If

            Next

        ElseIf ListBoxItems.SelectedItem = "Utilizator" Then
            Dim sql As String = "SELECT dbo.UtilizatoriInGoogle.Nume, dbo.Spreadsheets.Nume AS foaie, dbo.Spreadsheets.Filiala " &
                     "FROM dbo.UtilizatoriInGoogle INNER JOIN " &
                     "dbo.Spreadsheets ON dbo.UtilizatoriInGoogle.SpreadsheetId = dbo.Spreadsheets.SpreadsheetId " &
                     "WHERE (dbo.Spreadsheets.Activ = 'Da') AND (dbo.Spreadsheets.Foaie = N'') AND (dbo.Spreadsheets.SheetId = N'') AND (dbo.UtilizatoriInGoogle.Nume LIKE '%" & what & "%')"
            sql = clearSql(sql)
            Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto(sql)
            For Each row As DataRow In myDataTable.Rows
                If lvExists(lvOutput, "----------", row("Nume"), row("foaie")) = False Then
                    Dim lvu As ListViewItem = lvOutput.Items.Add("----------")
                    lvu.SubItems.Add(row("Nume"))
                    lvu.SubItems.Add(row("foaie"))
                    lvu.SubItems.Add(row("filiala"))
                End If
            Next

        End If

    End Sub
    Private Sub txtCautareMasinaSauUtilizator_TextChanged(sender As Object, e As EventArgs) Handles txtCautareMasinaSauUtilizator.TextChanged
        lvOutput.Items.Clear()
        ListBoxItemContent.SelectedIndex = -1
        txtCautareMasinaSauUtilizator.BackColor = System.Drawing.Color.Red
        txtCautareMasinaSauUtilizator.ForeColor = System.Drawing.Color.Yellow
        For Each item As String In cmbMasiniSauUtilizatori.Items
            If LCase(item).Contains(LCase(txtCautareMasinaSauUtilizator.Text)) Then
                cmbMasiniSauUtilizatori.SelectedItem = item
                txtCautareMasinaSauUtilizator.BackColor = System.Drawing.Color.Green
                txtCautareMasinaSauUtilizator.ForeColor = System.Drawing.Color.White
                Exit For
            End If
        Next
        CautaMasinaSauUtilizator(txtCautareMasinaSauUtilizator.Text)
    End Sub
    Private Function lvExists(listView As ListView, Numar As String, Nume As String, Foaie As String) As Boolean
        lvExists = False
        For Each lv As ListViewItem In listView.Items
            If lv.Text = Numar And lv.SubItems(1).Text = Nume And lv.SubItems(2).Text = Foaie Then
                lvExists = True
                Exit Function
            End If
        Next
    End Function

    Private Sub SelectListBoxItemContent(item As String)
        'selecteaza in ListBoxItemContent item-ul transmis de caseta de cautare sau altceva
        For k As Long = 0 To ListBoxItemContent.Items.Count - 1
            If ListBoxItemContent.Items(k) = item Then
                ListBoxItemContent.SetSelected(k, True)
                Exit For
            End If
        Next
    End Sub

    Private Sub cmbMasiniSauUtilizatori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMasiniSauUtilizatori.SelectedIndexChanged

        SelectListBoxItemContent(cmbMasiniSauUtilizatori.Text)
        CautaMasinaSauUtilizator(cmbMasiniSauUtilizatori.Text)

    End Sub

    Private Sub txtCautareMasinaSauUtilizator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCautareMasinaSauUtilizator.KeyPress
        If e.KeyChar = Chr(27) Then
            txtCautareMasinaSauUtilizator.Text = ""
        End If
    End Sub

    Private Sub cmdAdaugaInGoogle_Click(sender As Object, e As EventArgs) Handles cmdAdaugaInGoogle.Click
        Dim formId As String = getSelectedLvFormSpreadsheetId()
        If cmbMasiniSauUtilizatori.Text.Length > 0 Then
            If MasinaSauUtilizatorulExista(cmbMasiniSauUtilizatori.Text) = False Then
                AdaugaInGoogle(cmbMasiniSauUtilizatori.Text, formId, DialogResult.No)
            Else
                MessageBox.Show("Nu puteti adauga. Masina sau utilizatorul exista deja.", "KmAuto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Selectati mai intai masina sau utilizatorul pe care vreti sa le introduceti in foaia Google (Vedeti 'Selectati aici pentru adaugare in Google').", "KmAuto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub AdaugaInGoogle(what As String, formId As String, result As DialogResult)
        Me.Cursor = Cursors.WaitCursor
        Dim spreadsheet As String = getSelectedLvForm(), item As String = If(ListBoxItems.SelectedItem = "Masina", "masina ", If(ListBoxItems.SelectedItem = "Utilizator", "utilizatorul ", " "))
        If result <> DialogResult.Yes Then
            result = MessageBox.Show("Atentie. Se va adauga " & item & what & " in speadsheet-ul Google " & spreadsheet & " " & vbCrLf & "Continuati? ", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        End If
        If result = DialogResult.Yes Then
            Dim gfh As New GoogleFormsHelper
            'adauga optiuni 
            Dim succes As String = item & what
            If ListBoxItems.SelectedItem = "Masina" Then
                Dim masinaNoua As List(Of String) = New List(Of String) From {what}
                Dim res As String = gfh.UpdateChoiceItem(formId, "Masina", masinaNoua)
                If res = "Item setat Ok." Then
                    succes &= " a fost adaugata in foia Google. Acum utilizatorii pot introduce km la aceasta masina."
                    incarcaItems()
                Else
                    succes &= "nu a putut fi adaugata in foaia Google. " & res
                    MessageBox.Show(succes)
                End If
            ElseIf ListBoxItems.SelectedItem = "Utilizator" Then
                Dim utilizatorNou As List(Of String) = New List(Of String) From {what}
                Dim res As String = gfh.UpdateChoiceItem(formId, "Utilizator", utilizatorNou)
                If res = "Item setat Ok." Then
                    succes &= " a fost adaugat in foia Google. Acum utilizatorul pot introduce km, daca are si masina introdusa."
                    incarcaItems()
                Else
                    succes &= "nu a putut fi adaugat in foaia Google. " & res
                    MessageBox.Show(succes)
                End If

            End If
        End If
        Me.Cursor = Cursors.Default

    End Sub
    Private Sub cmdScoateDinGoogle_Click(sender As Object, e As EventArgs) Handles cmdScoateDinGoogle.Click
        Dim formId As String = getSelectedLvFormSpreadsheetId()
        If Not IsNothing(ListBoxItemContent.SelectedItem) Then
            ScoateDinGoogle(ListBoxItemContent.SelectedItem, formId, DialogResult.No)
        Else
            MessageBox.Show("Selectati mai intai masina sau utilizatorul pe care vreti sa le stergeti din foaia Google.", "KmAuto", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub
    Private Sub ScoateDinGoogle(what As String, formId As String, result As DialogResult)
        Me.Cursor = Cursors.WaitCursor
        Dim spreadsheet As String = getSelectedLvForm(), item As String = If(ListBoxItems.SelectedItem = "Masina", "masina ", If(ListBoxItems.SelectedItem = "Utilizator", "utilizatorul ", " "))
        If result <> DialogResult.Yes Then
            result = MessageBox.Show("Atentie. Se va scoate " & item & what & " din speadsheet-ul Google " & spreadsheet & " " & vbCrLf & "Continuati? ", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        End If
        If result = DialogResult.Yes Then
            Dim gfh As New GoogleFormsHelper

            'adauga optiuni 
            Dim succes As String = item & what
            If ListBoxItems.SelectedItem = "Masina" Then
                Dim masiniDeSters As List(Of String) = New List(Of String) From {what}
                Dim res As String = gfh.DeleteOptionsFromChoiceItem(formId, "Masina", masiniDeSters)
                If res = "Optiuni item sterse Ok." Then
                    succes &= " a fost scoasa din foia Google. Acum utilizatorii nu mai pot introduce km pe aceasta masina."
                    incarcaItems()
                Else
                    succes &= "nu a putut fi scoasa din foaia Google. " & res
                    MessageBox.Show(succes)
                End If
            ElseIf ListBoxItems.SelectedItem = "Utilizator" Then
                Dim utilizatorDeSters As List(Of String) = New List(Of String) From {what}
                Dim res As String = gfh.DeleteOptionsFromChoiceItem(formId, "Utilizator", utilizatorDeSters)
                If res = "Optiuni item sterse Ok." Then
                    succes &= " a fost sters in foia Google. Acum utilizatorul nu mai poate introduce km."
                    incarcaItems()
                Else
                    succes &= "nu a putut fi sters din foaia Google. " & res
                    MessageBox.Show(succes)
                End If

            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Private Function getSelectedLvForm() As String
        getSelectedLvForm = ""
        For Each item As ListViewItem In lvForms.Items
            If item.Selected = True Then
                getSelectedLvForm = item.Text
                Exit Function
            End If
        Next
    End Function
    Private Function MasinaSauUtilizatorulExista(item As String) As Boolean
        MasinaSauUtilizatorulExista = False
        For Each itemx As String In ListBoxItemContent.Items
            If itemx = item Then
                MasinaSauUtilizatorulExista = True
                Exit Function
            End If
        Next
    End Function
    Private Function getSelectedLvFormSpreadsheetId() As String
        getSelectedLvFormSpreadsheetId = ""
        For Each item As ListViewItem In lvForms.Items
            If item.Selected = True Then
                getSelectedLvFormSpreadsheetId = item.SubItems(3).Text
                Exit Function
            End If
        Next
    End Function

    Private Sub ListBoxItemContent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxItemContent.SelectedIndexChanged
        cmbMasiniSauUtilizatori.Text = ListBoxItemContent.SelectedItem
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblGoogleForm.Text = getSelectedLvForm()
        cmdMutaInAltaFoaie.Enabled = (ListBoxItems.SelectedItem = "Masina" Or ListBoxItems.SelectedItem = "Utilizator")
    End Sub

    Private Sub cmdIncarcaDateVerificareGoogle_Click(sender As Object, e As EventArgs) Handles cmdIncarcaDateVerificareGoogle.Click
        pbIncarca.Maximum = lvForms.Items.Count
        pbIncarca.Value = 0
        Dim result As DialogResult = MessageBox.Show("Atentie. Se vor incarca toate datele din foile Google in vederea analizei. " & vbCrLf & "Continuati? ", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        If result = DialogResult.Yes Then
            'face o lista cu toate masinile si toti utilizatorii din toate foile si compara cu alocarea din baza de date din tabelele Utilziatori si Masini. 
            'Va raporta toate diferentele: lipsa in Google, lipsa in baza de date, dublat in alta foaie, etc.
            'Dim dictMasini As Dictionary(Of String, List(Of String)) = New Dictionary(Of String, List(Of String))
            'Dim dictUtilizatori As Dictionary(Of String, List(Of String)) = New Dictionary(Of String, List(Of String))
            ExecutaSQLKmAuto("Delete from MasiniInGoogle")
            ExecutaSQLKmAuto("Delete from UtilizatoriInGoogle")
            Dim k As Long
            For Each lv As ListViewItem In lvForms.Items
                lblGoogleForm.Text = lv.Text
                lblGoogleForm.Refresh()
                pbIncarca.Value = k
                k = k + 1
                lv.Selected = True
                ListBoxItems.SelectedIndex = 0
                For Each itemx As String In ListBoxItemContent.Items
                    Dim Sql As String = "INSERT INTO MasiniInGoogle (
                            SpreadsheetId, 
                            Numar
                            ) VALUES (
                            '" & lv.SubItems(3).Text & "', 
                            '" & itemx & "');"
                    Sql = clearSql(Sql)
                    Dim succes As String = ExecutaSQLKmAuto(Sql)

                Next

                'dictMasini.Add(lv.Text & " -- " & lv.SubItems(1).Text, myListMasini)
                ListBoxItems.SelectedIndex = 1
                'Dim myListUtilizatori As New List(Of String)
                'myListUtilizatori = getListBoxItemContentItemsAsList()
                For Each itemx As String In ListBoxItemContent.Items
                    Dim Sql As String = "INSERT INTO UtilizatoriInGoogle (
                            SpreadsheetId, 
                            Nume
                            ) VALUES (
                            '" & lv.SubItems(3).Text & "', 
                            '" & itemx & "');"
                    Sql = clearSql(Sql)
                    Dim succes As String = ExecutaSQLKmAuto(Sql)

                Next

                'dictUtilizatori.Add(lv.Text & " -- " & lv.SubItems(1).Text, myListUtilizatori)
                lvForms.Refresh()
                Me.Refresh()
            Next
            pbIncarca.Value = 0
            Me.Cursor = Cursors.Default
            frmGoogleInfo.ShowDialog()
            frmGoogleInfo.Dispose()

        End If
    End Sub
    Private Function getListBoxItemContentItemsAsList() As List(Of String)
        Dim myList As New List(Of String)
        For Each item As String In ListBoxItemContent.Items
            myList.Add(item)
        Next
        getListBoxItemContentItemsAsList = myList
    End Function

    Private Sub cmdGoogleInfo_Click(sender As Object, e As EventArgs) Handles cmdGoogleInfo.Click
        frmGoogleInfo.ShowDialog()
        frmGoogleInfo.Dispose()

    End Sub

    Private Sub cmdMutaInAltaFoaie_Click(sender As Object, e As EventArgs) Handles cmdMutaInAltaFoaie.Click

        Dim frm As System.Windows.Forms.Form = New frmGoogleMuta, what As String = ListBoxItemContent.SelectedItem
        frm.Tag = what & " : " & getSelectedLvForm() & " : " & ListBoxItems.SelectedItem
        Dim memTag As String = frm.Tag
        frm.ShowDialog()
        Dim idFormSursa = getSelectedLvFormSpreadsheetId()
        Dim idFormDestinatie As String = frm.Tag, succes As Boolean = False
        frm.Dispose()
        If memTag <> idFormDestinatie Then
            If what.Length > 0 Then
                If MasinaSauUtilizatorulExista(what) = True Then 'o masina sau u
                    AdaugaInGoogle(what, idFormDestinatie, DialogResult.Yes)
                    succes = True
                Else
                    MessageBox.Show("Nu puteti adauga. Masina sau utilizatorul exista deja.", "KmAuto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Nu puteti muta o masina/utilizator care nu este inregistrat/a in tabelul Masini/Utilizatori din baza de date. Adaugati mai intai masina/utilizatorul si apoi puteti sa o/il mutati. Situatia aceasta apare cand o masina a fost adaugata manual in formularul google si nu a fost introdusa mai intai in aplicatie.", "KmAuto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            If succes = True Then
                ScoateDinGoogle(what, idFormSursa, DialogResult.Yes)
            End If

        End If
        Dim NumeFormDestinatie As String = ReturExecutaSqlKmAuto("Select Nume from Spreadsheets where SpreadsheetId = '" & idFormDestinatie & "' and Foaie =N'' and SheetId = N'' And activ = 'Da'")
        For Each lv As ListViewItem In lvForms.Items
            If lv.Text = NumeFormDestinatie Then
                lv.Selected = True
                Exit For
            End If
        Next

    End Sub


    Private Sub lvOutput_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lvOutput.SelectedIndexChanged
        For Each lv As ListViewItem In lvOutput.Items
            If lv.Selected = True Then
                For Each lv1 As ListViewItem In lvForms.Items
                    If lv.SubItems(2).Text = lv1.Text Then
                        lv1.Selected = True
                        Exit For
                    End If
                Next
                For Each it As String In cmbMasiniSauUtilizatori.Items
                    If it = If(ListBoxItems.SelectedItem = "Masina", lv.Text, If(ListBoxItems.SelectedItem = "Utilizator", lv.SubItems(1).Text, "")) Then
                        cmbMasiniSauUtilizatori.Text = it
                        Exit For
                    End If
                Next
                Exit For
            End If
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lvOutput.Items.Clear()
    End Sub
End Class