Imports System.ComponentModel

Public Class frmGoogleMuta
    Private masina As String = "", utilizatorul As String = "", filiala As String = ""
    Private Sub frmGoogleMuta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 334, 578)
        Dim s As String = Me.Tag.ToString, v() As String = Split(s, " : ")
        If s.Length > 0 Then
            If v(2) = "Masina" Then
                masina = v(0)
            Else
                utilizatorul = v(0)

            End If
            filiala = v(1)
        End If
        Me.lblIntro.Text = "Ati ales sa mutati " & If(v(2) = "Masina", "masina ", "utilizatorul ") & v(0) & " din filiala " & filiala
        incarcaFiliale()
    End Sub
    Private Sub incarcaFiliale()
        Dim myDatatable As System.Data.DataTable = ReturDataTableKmAuto("Select Nume from Spreadsheets where activ = 'Da' and foaie = N'' and sheetid = N''")
        For Each row As DataRow In myDatatable.Rows
            cmbFiliala.Items.Add(row("Nume"))
        Next
    End Sub
    Private Sub frmGoogleMuta_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdIesire_Click(sender As Object, e As EventArgs) Handles cmdIesire.Click
        Me.Close()

    End Sub

    Private Sub lblIntro_Click(sender As Object, e As EventArgs) Handles lblIntro.Click

    End Sub

    Private Sub cmdSalveaza_Click(sender As Object, e As EventArgs) Handles cmdSalveaza.Click
        'daca totul este ok, returneaza in tag id-ul formului destinatie pentru a efectua copierea la apelant
        If cmbFiliala.Text <> "" And cmbFiliala.Text <> filiala Then
            Me.Tag = ReturExecutaSqlKmAuto("Select SpreadsheetId from Spreadsheets where Nume = '" & cmbFiliala.Text & "' and Foaie =N'' and SheetId = N'' And activ = 'Da'")
            Me.Close()
        Else
            MessageBox.Show("Selectati filiala, sau filiala destinatie este aceeasi cu cea sursa.")
        End If
    End Sub

    Private Sub frmGoogleMuta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)

    End Sub

End Class