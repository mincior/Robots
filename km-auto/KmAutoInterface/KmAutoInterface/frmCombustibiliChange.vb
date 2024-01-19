Public Class frmCombustibiliChange
    Private comb As Combustibil = frmCombustibili.comb
    Private Sub frmCombustibiliChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTip.Text = comb.Tip
        dtpDataSchimbariiPretului.Value = comb.Data
        PretTextBox.Text = comb.Pret
        Me.Text = "Combustibili: " & comb.operatie

    End Sub
    Private Sub cmdIesire_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub cmdSalveaza_Click(sender As Object, e As EventArgs) Handles cmdSalveaza.Click
        Dim myList As New List(Of Object), succes As String = "", sql As String = ""
        myList.Add(cmbTip.Text)
        myList.Add(dtpDataSchimbariiPretului.Value)
        myList.Add(CDbl(PretTextBox.Text))
        myList.Add(If(cmbTip.Text = "Benzina", 2, 1))
        Select Case comb.operatie
            Case "Modificare"
                'scrie in tabelul Masini din baza de date
                sql = "UPDATE Combustibili SET 
                            TipCombustibil = '" & myList(0) & "', 
                            Data = '" & myList(1) & "', 
                            Pret = '" & myList(2) & "', 
                            Id = '" & myList(3) & "' 
                            Where TipCombustibil = '" & comb.Tip & "' and Data = '" & comb.Data & "'
                            ;"
                sql = clearSql(sql)
                succes = ExecutaSQLkmAuto( sql
                            )
                If succes = "Ok" Then succes = "Combustibil modificat cu succes."
            Case "Adaugare"
                'adauga si in baza de date
                sql = "INSERT INTO Combustibili (
                            TipCombustibil, 
                            Data, 
                            Pret, 
                            id 
                            ) VALUES (
                            '" & myList(0) & "', 
                            '" & myList(1) & "', 
                            '" & myList(2) & "', 
                            '" & myList(3) & "' 
                            );"
                sql = clearSql(sql)
                succes = ExecutaSQLkmAuto( sql)
                If succes = "Ok" Then
                    succes = "Combustibil adaugat cu succes."
                End If
        End Select
        MessageBox.Show(succes)
        Me.Close()
    End Sub

    Private Sub cmdIesire_Click_1(sender As Object, e As EventArgs) Handles cmdIesire.Click
        Me.Close()
    End Sub

End Class