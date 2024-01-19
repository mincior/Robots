
Imports System.ComponentModel

Public Class frmUtilizatoriChange
    Private spreadsheetName As String = "Utilizatori"
    Private util As Utilizator = frmUtilizatori.util
    Private Sub frmUtilizatoriChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KmAutoDataSet.Filiale' table. You can move, or remove it, as needed.
        Me.FilialeTableAdapter.Fill(Me.KmAutoDataSet.Filiale)
        Me.Text = "Utilizatori: " & util.Operatie
        NumeTextBox.Text = util.Nume
        EmailTextBox.Text = util.Email
        LimitaKmTextBox.Text = util.LimitaKm
        If util.FilialaId = -1 Then
            cmbFiliala.SelectedIndex = 0
        Else
            cmbFiliala.Text = ReturExecutaSqlKmAuto("Select Nume from Filiale where id = " & util.FilialaId)

        End If
        ActivComboBox.Text = util.Activ
        RetinereComboBox.Text = util.Retinere
        EmailConsolightTextBox.Text = util.EmailConsolight
        DeObiceiFolosesteMasinaComboBox.Text = util.DeObiceiFolosesteMasina
        AliasTextBox.Text = util.Alias_
        ObservatiiTextBox.Text = util.Observatii
        TelefonTextBox.Text = util.Telefon
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 334, 334)

    End Sub
    Private Sub frmMasiniChange_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)

    End Sub

    Private Sub UtilizatoriBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdIesire_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub



    Private Sub cmdSalveaza_Click(sender As Object, e As EventArgs) Handles cmdSalveaza.Click
        Me.Cursor = Cursors.WaitCursor
        Dim myList As New List(Of Object), succes As String = ""
        myList.Add(DateTime.Now.ToOADate)
        myList.Add(NumeTextBox.Text)
        myList.Add(EmailTextBox.Text)
        myList.Add(If(LimitaKmTextBox.Text.Length = 0, 20, CLng(LimitaKmTextBox.Text)))
        myList.Add(cmbFiliala.Text)
        myList.Add(ActivComboBox.Text)
        myList.Add(RetinereComboBox.Text)
        myList.Add(EmailConsolightTextBox.Text)
        myList.Add(DeObiceiFolosesteMasinaComboBox.Text)
        myList.Add(AliasTextBox.Text)
        myList.Add(ObservatiiTextBox.Text)
        myList.Add(TelefonTextBox.Text)
        Select Case util.Operatie
            Case "Modificare"
                'scrie si in tabelul Utilizatori din baza de date
                Dim filialaId As Long = ReturExecutaSqlKmAuto("Select Id from Filiale where Nume = '" & myList(4) & "'")
                succes = ExecutaSQLKmAuto("UPDATE Utilizatori SET 
                            DataInrolarii = '" & DateTime.FromOADate(myList(0)) & "', 
                            Nume = '" & myList(1) & "', 
                            Email = '" & myList(2) & "', 
                            LimitaKm = " & myList(3) & ", 
                            FilialaId = " & filialaId & ", 
                            Activ = '" & myList(5) & "', 
                            Retinere = '" & myList(6) & "', 
                            EmailConsolight = '" & myList(7) & "', 
                            DeObiceiFolosesteMasina = '" & myList(8) & "', 
                            Alias = '" & myList(9) & "', 
                            Observatii = '" & myList(10) & "', 
                            Telefon = '" & myList(11) & "' 
                            Where Nume = '" & util.Nume & "'
                            ;"
                            )
                If succes = "Ok" Then succes = "Utilizator modificat cu succes."
            Case "Adaugare"
                'adauga si in baza de date
                Dim filialaId As Long = ReturExecutaSqlKmAuto("Select Id from Filiale where Nume = '" & myList(4) & "'")
                succes = ExecutaSQLKmAuto("INSERT INTO utilizatori (
                            DataInrolarii, 
                            Nume, 
                            Email, 
                            LimitaKm, 
                            FilialaId, 
                            Activ, 
                            Retinere, 
                            EmailConsolight, 
                            DeObiceiFolosesteMasina, 
                            Alias, 
                            Observatii, 
                            Telefon
                            ) VALUES (
                            '" & DateTime.FromOADate(myList(0)) & "', 
                            '" & myList(1) & "', 
                            '" & myList(2) & "', 
                            " & myList(3) & ", 
                            " & filialaId & ", 
                            '" & myList(5) & "', 
                            '" & myList(6) & "', 
                            '" & myList(7) & "', 
                            '" & myList(8) & "', 
                            '" & myList(9) & "', 
                            '" & myList(10) & "', 
                            '" & myList(11) & "'
                            );")
                If succes = "Ok" Then
                    succes = ExecutaSQLKmAuto("Delete from UtilizatoriInexistenti Where Nume = '" & myList(1) & "'")
                    succes = "Utilizator adaugat cu succes."

                End If
        End Select
        If myList(4) = "" Then
            Me.Cursor = Cursors.Default
            Me.Close()
            Exit Sub 'daca utilizatorul nu are filiala atunci iese
        End If
        If succes = "Utilizator modificat cu succes." Or succes = "Utilizator adaugat cu succes." Then
            'adauga sau scoate utilizatorul din foaia google
            If ckOpereazaSiInGoogle.Checked = True Then
                'obtine id-ul foii google dupa id-ul filialei
                Dim gfh As New GoogleFormsHelper
                Dim formId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets Where Filiala = '" & myList(4) & "' and Foaie = N'' and SheetId = N'' and Activ = 'Da'")
                If myList(5) = "Da" Then 'daca utilizatorul este activ il adauga daca nu este
                    'adauga optiuni 
                    Dim utilizatorNou As List(Of String) = New List(Of String) From {myList(1)}
                    Dim result As String = gfh.UpdateChoiceItem(formId, "Utilizator", utilizatorNou)
                    If result = "Item setat Ok." Then succes &= " (A fost adaugat si in Google pentru ca utilizatorul sa poata introduce km)"
                Else 'il scoate daca nu e scos
                    'sterge optiuni
                    Dim utilizatorDeSters As List(Of String) = New List(Of String) From {myList(1)}
                    Dim result As String = gfh.DeleteOptionsFromChoiceItem(formId, "Utilizator", utilizatorDeSters)
                    If result = "Optiuni item sterse Ok." Then succes &= " (A fost scos si din Google. Utilizatorul nu mai poate introduce km.)"

                End If
            End If
        Else
            MessageBox.Show(succes)

        End If
        Me.Close()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdIesire_Click_1(sender As Object, e As EventArgs) Handles cmdIesire.Click
        Me.Close()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub NumeTextBox_TextChanged(sender As Object, e As EventArgs) Handles NumeTextBox.TextChanged
        'TODO: This line of code loads data into the 'ConsolightDataSet.A_Useri' table. You can move, or remove it, as needed.
        Me.A_UseriTableAdapter.Fill(Me.ConsolightDataSet.A_Useri, "%" & NumeTextBox.Text & "%")

    End Sub

    Private Sub cmdCompleteazaAliasDinERP_Click(sender As Object, e As EventArgs) Handles cmdCompleteazaAliasDinERP.Click
        If DataGridView1.Rows.Count = 1 Then
            If util.Operatie = "Modificare" Then
                AliasTextBox.Text = DataGridView1.CurrentCell.Value
            Else
                NumeTextBox.Text = DataGridView1.CurrentCell.Value

            End If

        End If
    End Sub
End Class