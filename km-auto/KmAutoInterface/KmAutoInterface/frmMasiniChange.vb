Imports System.ComponentModel

Public Class frmMasiniChange
    Private spreadsheetName As String = "Masini"
    Private mas As Masini = frmMasini.mas
    Private Sub frmMasiniChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KmAutoDataSet.Filiale' table. You can move, or remove it, as needed.
        Me.FilialeTableAdapter.Fill(Me.KmAutoDataSet.Filiale)
        Me.Text = "Masini: " & mas.Operatie
        NumarTextBox.Text = mas.Numar
        ConsumMediuTextBox.Text = mas.ConsumMediu
        cmbCarburant.Text = mas.Carburant
        If mas.FilialaId = -1 Then
            cmbFiliala.SelectedIndex = 0
        Else
            cmbFiliala.Text = ReturExecutaSqlKmAuto("Select Nume from Filiale where id = " & mas.FilialaId)

        End If
        ActivComboBox.Text = mas.Activ
        ObservatiiTextBox.Text = mas.Observatii
        cmbMarca.Text = mas.Marca
        cmbModel.Text = mas.Model
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 334, 334)

    End Sub
    Private Sub frmMasiniChange_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)

    End Sub

    Private Sub MasiniBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdIesire_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub



    Private Sub cmdSalvare_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub cmdSalveaza_Click(sender As Object, e As EventArgs) Handles cmdSalveaza.Click
        Cursor = Cursors.WaitCursor
        Dim myList As New List(Of Object), succes As String = ""
        myList.Add(DateTime.Now.ToOADate)
        myList.Add(NumarTextBox.Text)
        myList.Add(cmbMarca.Text)
        myList.Add(cmbModel.Text)
        myList.Add(ConsumMediuTextBox.Text)
        myList.Add(cmbFiliala.Text)
        myList.Add(cmbCarburant.Text)
        myList.Add(ActivComboBox.Text)
        myList.Add(ObservatiiTextBox.Text)
        Select Case mas.Operatie
            Case "Modificare"
                'scrie si in tabelul Masini din baza de date
                succes = ExecutaSQLKmAuto("UPDATE Masini SET 
                            DataInrolarii = '" & DateTime.FromOADate(myList(0)) & "', 
                            Numar = '" & myList(1) & "', 
                            Marca = '" & myList(2) & "', 
                            Model = '" & myList(3) & "', 
                            ConsumMediu = '" & myList(4) & "', 
                            FilialaId = " & ReturExecutaSqlKmAuto("Select Id from Filiale where Nume = '" & myList(5) & "'") & ", 
                            Carburant = '" & myList(6) & "', 
                            Activ = '" & myList(7) & "', 
                            Observatii = '" & myList(8) & "' 
                            Where Numar = '" & mas.Numar & "'
                            ;"
                            )
                If succes = "Ok" Then succes = "Masina modificata cu succes."
            Case "Adaugare"
                'adauga si in baza de date
                succes = ExecutaSQLKmAuto("INSERT INTO Masini (
                            DataInrolarii, 
                            Numar, 
                            Marca, 
                            Model, 
                            ConsumMediu, 
                            FilialaId, 
                            Carburant, 
                            Activ,
                            Observatii
                            ) VALUES (
                            '" & DateTime.FromOADate(myList(0)) & "', 
                            '" & myList(1) & "', 
                            '" & myList(2) & "', 
                            '" & myList(3) & "', 
                            '" & myList(4) & "', 
                            " & ReturExecutaSqlKmAuto("Select Id from Filiale where Nume = '" & myList(5) & "'") & ", 
                            '" & myList(6) & "', 
                            '" & myList(7) & "', 
                            '" & myList(8) & "' 
                            );")
                If succes = "Ok" Then
                    succes = ExecutaSQLKmAuto("Delete from MasiniInexistente Where Nume = '" & myList(1) & "'")
                    succes = "Masina adaugata cu succes."
                End If
        End Select

        If myList(5) = "" Then
            Me.Cursor = Cursors.Default
            Me.Close()
            Exit Sub 'daca utilizatorul nu are filiala atunci iese
        End If

        If succes = "Masina modificata cu succes." Or succes = "Masina adaugata cu succes." Then
            'adauga sau scoate masina din foaia google
            If ckOpereazaSiInGoogle.Checked = True Then
                'obtine id-ul foii google dupa id-ul filialei
                Dim gfh As New GoogleFormsHelper
                Dim formId As String = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets Where Filiala = '" & myList(5) & "' and Foaie = N'' and SheetId = N'' and Activ = 'Da'")
                If formId <> "" Then
                    If myList(7) = "Da" Then 'daca masina este activa o adauga daca nu este
                        'adauga optiuni 
                        Dim masinaNoua As List(Of String) = New List(Of String) From {myList(1)}
                        Dim result As String = gfh.UpdateChoiceItem(formId, "Masina", masinaNoua)
                        If result = "Item setat Ok." Then succes &= " (A fost adaugata si in Google pentru ca utilizatorii sa poata introduce km)"
                    Else 'o scoate daca nu e scoasa
                        'sterge optiuni
                        Dim masiniDeSters As List(Of String) = New List(Of String) From {myList(1)}
                        Dim result As String = gfh.DeleteOptionsFromChoiceItem(formId, "Masina", masiniDeSters)
                        If result = "Optiuni item sterse Ok." Then succes &= " (A fost scoasa si din Google. Utilizatorii nu mai pot introduce km.)"

                    End If
                End If
            End If
        End If
        Cursor = Cursors.Default

        MessageBox.Show(succes)
        Me.Close()
    End Sub

    Private Sub cmdIesire_Click_1(sender As Object, e As EventArgs) Handles cmdIesire.Click
        Me.Close()
    End Sub

End Class