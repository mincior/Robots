Public Class frmFilialeChange
    Private fil As Filiala = frmFiliale.fil
    Private Sub frmFilialeChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumeTextBox.Text = fil.Nume
        EmailTextBox.Text = fil.Email
        ResponsabilTextBox.Text = fil.Responsabil
        Me.Text = "Filiale: " & fil.Operatie

    End Sub
    Private Sub cmdIesire_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub cmdSalveaza_Click(sender As Object, e As EventArgs) Handles cmdSalveaza.Click
        Dim myList As New List(Of Object), succes As String = "", sql As String = ""
        myList.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
        myList.Add(NumeTextBox.Text)
        myList.Add(EmailTextBox.Text)
        myList.Add(ResponsabilTextBox.Text)
        Select Case fil.Operatie
            Case "Modificare"
                'scrie in tabelul Masini din baza de date
                sql = "UPDATE Filiale SET 
                            Timestamp = '" & myList(0) & "', 
                            Nume = '" & myList(1) & "', 
                            Email = '" & myList(2) & "', 
                            Responsabil = '" & myList(3) & "' 
                            Where Nume = '" & fil.Nume & "'
                            ;"
                sql = clearSql(sql)
                succes = ExecutaSQLkmAuto( sql
                            )
                If succes = "Ok" Then succes = "Filiala modificata cu succes."
            Case "Adaugare"
                'adauga si in baza de date
                sql = "INSERT INTO Filiale (
                            Timestamp, 
                            Nume, 
                            Email, 
                            Responsabil 
                            ) VALUES (
                            '" & myList(0) & "', 
                            '" & myList(1) & "', 
                            '" & myList(2) & "', 
                            '" & myList(3) & "' 
                            );"
                sql = clearSql(sql)
                succes = ExecutaSQLkmAuto( sql)
                If succes = "Ok" Then
                    succes = "Filiala adaugata cu succes."
                End If
        End Select
        MessageBox.Show(succes)
        Me.Close()

    End Sub

    Private Sub cmdIesire_Click_1(sender As Object, e As EventArgs) Handles cmdIesire.Click
        Me.Close()
    End Sub
End Class