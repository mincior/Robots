Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Office.Interop.Excel

Public Class frmDateExterne
    Private Sub frmDateExterne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 795, 834)

    End Sub
    Private Sub frmDateExterne_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False

    End Sub


    Private Sub ActivitateZilnicaPeIntervaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivitateZilnicaPeIntervaleToolStripMenuItem.Click, cmdActivitateZilnicaPeIntervale.Click
        OpenFileDialog1.Filter = "Fisiere excel|*.xls;*.xlsx"
        If OpenFileDialog1.ShowDialog <> DialogResult.Cancel Then

            'alege fisierul exportat din Itrack cu numele de forma Foaie activitate zilnica_Toate vehicolele_....
            Dim myfileInfo As FileInfo = My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName)
            lbInfo.Text = "Se incarca..."
            Dim myw As Workbook = myEx.Workbooks.Open(OpenFileDialog1.FileName)
            myEx.Visible = True
            myw.Sheets("Parametri").select
            If myEx.Cells(1, 2).value <> "CONSOLIGHT COM SRL, Brasov, Bucuresti, Cluj , Constanta, Craiova, Galati, Iasi, Militari, Oradea, Otopeni, Sibiu, Timisoara" And myEx.Cells(1, 2).value <> "Toate" Then
                Me.Text = "Atentie. E posibil sa nu fie incluse toate filiale in filtru."
            End If
            Dim dataInceput As String = myEx.Cells(3, 2).value
            Dim dataSfarsit As String = myEx.Cells(4, 2).value
            Dim sursaDate As String = myEx.Cells(6, 2).value
            Dim result As DialogResult = MessageBox.Show("Atentie. Se va incarca raportul 'Foaie activitate zilnica_Toate vehicolele_... pentru perioada " & dataInceput & " - " & dataSfarsit & vbCrLf & "Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then

                myw.Sheets("Sinteză zilnică").select
                If myEx.Cells(1, 1).value <> "#" Or myEx.Cells(1, 2).value <> "Vehicul" Or myEx.Cells(1, 3).value <> "Dată" Then
                    MessageBox.Show("Fisierul nu are formatul corespunzator. Trebuie sa contina pe primul rand: #, Vehicul, Data.")
                    Exit Sub
                End If
                myEx.Visible = True
                Dim numarRanduri As Long = myw.ActiveSheet.usedrange.rows.count
                'Dim numarColoane As Long = myw.ActiveSheet.usedrange.columns.count
                Dim dictNumeColoane As New Dictionary(Of String, Long)

                dictNumeColoane.Add(myEx.Cells(1, 1).value, 2)
                dictNumeColoane.Add(myEx.Cells(1, 2).value, 3)
                dictNumeColoane.Add(myEx.Cells(1, 3).value, 4)
                dictNumeColoane.Add(myEx.Cells(1, 6).value, 7)
                dictNumeColoane.Add(myEx.Cells(1, 13).value, 14)

                pbIncarca.Value = 0
                pbIncarca.Maximum = numarRanduri
                For k As Long = 2 To numarRanduri
                    pbIncarca.Value = k
                    Dim data As Date
                    Dim numarInmatriculare As String = introduceLiniuteInNumarulDeInmatriculare(myEx.Cells(k, dictNumeColoane("Vehicul")).value)
                    Dim myDataTable As System.Data.DataTable = ReturDataTablekmAuto("Select Id from Masini Where Numar = '" & numarInmatriculare & "'")
                    If myDataTable.Rows.Count > 0 Then
                        Dim kmGPS As Long, Sofer As String, res As String
                        data = myEx.Cells(k, dictNumeColoane("Dată")).value
                        'If k > 953 Then Stop
                        If myEx.Cells(k, dictNumeColoane("Șofer(i)")).value <> "" Then
                            Sofer = CType(myEx.Cells(k, dictNumeColoane("Șofer(i)")).value, String)
                        Else
                            Sofer = ""
                        End If

                        If myEx.Cells(k, dictNumeColoane("Km bord sfârșit")).value <> 0 Then
                            kmGPS = CType(myEx.Cells(k, dictNumeColoane("Km bord sfârșit")).value, Long)
                        Else
                            kmGPS = 0
                        End If

                        res = ExecutaSQLkmAuto("INSERT INTO ITrackActivitateZilnicaPeInterval (Data, Numar, Sofer, KmGPS, Sursa ) VALUES ( '" & data & "', '" & numarInmatriculare & "', '" & Trim(Sofer) & "', '" & kmGPS & "', '" & sursaDate & "');")
                        lbInfo.Text = res

                    Else
                        '                        'Stop
                    End If

                Next
                pbIncarca.Value = 0
                myEx.Visible = False
                myw.Close(False)
                lbInfo.Text = "Incarcare fisier ITrack km in bord, OK."
            End If
            myEx.Visible = False
        End If


    End Sub



    Private Sub cmdIncarcaFisiereBenzinarii_Click(sender As Object, e As EventArgs) Handles cmdIncarcaFisiereBenzinarii.Click, IncarcaFisierBenzinariiToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Fisiere excel (*.xls)|*.xls|Fisiere excel nou (*.xlsx)|*.xlsx"
        If OpenFileDialog1.ShowDialog <> DialogResult.Cancel Then
            lbInfo.Text = "Se incarca..."
            Dim myw As Workbook = myEx.Workbooks.Open(OpenFileDialog1.FileName)
            If myEx.Cells(1, 1).value <> "Data si ora" Or myEx.Cells(1, 2).value <> "Serie card" Then
                MessageBox.Show("Fisierul nu are formatul corespunzator. Trebuie sa contina pe primul rand Data si ora, Serie card.")
                Exit Sub
            End If
            myEx.Visible = True
            Dim numarRanduri As Long = myw.ActiveSheet.usedrange.rows.count
            Dim numarColoane As Long = myw.ActiveSheet.usedrange.columns.count
            Dim dictNumeColoane As New Dictionary(Of String, Long)
            For k = 1 To numarColoane
                dictNumeColoane.Add(myEx.Cells(1, k).value, k)
            Next
            pbIncarca.Value = 0
            pbIncarca.Maximum = numarRanduri
            For k As Long = 2 To numarRanduri
                pbIncarca.Value = k
                Dim data As String = myEx.Cells(k, dictNumeColoane("Data si ora")).value
                data = convertDataAsDotStringReverseToString(data)
                Dim serieCard As String = myEx.Cells(k, dictNumeColoane("Serie card")).value
                Dim numarInmatriculare As String = introduceLiniuteInNumarulDeInmatriculare(myEx.Cells(k, dictNumeColoane("Numar inmatriculare")).value)
                Dim masinaId As Long = ReturExecutaSqlkmAuto("Select Id from Masini Where Numar = '" & numarInmatriculare & "'")
                If masinaId > 0 Then
                    Dim cantitate As Double = CType(myEx.Cells(k, dictNumeColoane("Cantitate")).value, Double)
                    Dim km As Double
                    If myEx.Cells(k, dictNumeColoane("Kilometraj")).value <> "" Then
                        km = CType(myEx.Cells(k, dictNumeColoane("Kilometraj")).value, Double)
                    End If
                    Dim numeStatie As String = myEx.Cells(k, dictNumeColoane("Numele statiei")).value
                    Dim tipCombustibil As String = myEx.Cells(k, dictNumeColoane("Grup de produse")).value
                    Try
                        'avem o cheie compusa din data si masinaId. De fiecare data facem insert si va sari peste inregistrarile care au mai fost introduse
                        Dim eroare As String = ExecutaSQLkmAuto( "INSERT INTO AlimentariCombustibil (data, masinaId, cantitate, km, numeStatie, tip, serieCard, masinaVerif) VALUES ('" & data & "', " & masinaId & ", " & cantitate & ", " & km & ", '" & numeStatie & "', '" & tipCombustibil & "', '" & serieCard & "', '" & numarInmatriculare & "');")
                    Catch ex As System.Exception

                    End Try
                    Try
                        Dim res As String = ExecutaSQLkmAuto( "INSERT INTO ITrackActivitateZilnicaPeInterval (Data, Numar, Sofer, KmGPS, Sursa ) VALUES ( '" & convertStringDataToDate(data) & "', '" & numarInmatriculare & "', N'', '" & km & "', 'MOL');")

                    Catch ex As Exception

                    End Try

                Else
                    'Stop
                End If

            Next
            pbIncarca.Value = 0
            myEx.Visible = False
            myw.Close(False)
            lbInfo.Text = "Incarcare fisier benzinarie OK."
        End If

    End Sub

    Private Sub cmdIesire_Click(sender As Object, e As EventArgs) Handles cmdIesire.Click
        Me.Close()

    End Sub

    Private Sub cmdStergeTabelActivitateZilnica_Click(sender As Object, e As EventArgs) Handles cmdStergeTabelActivitateZilnica.Click
        Dim result As DialogResult = MessageBox.Show("Atentie. Se vor sterge datele culese din fisierele Itrack. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then

            'sterge toate inregistrarile din ITrackActivitateZilnicaPeInterval
            Dim eroare As String = ExecutaSQLkmAuto( "Delete from ITrackActivitateZilnicaPeInterval")
        End If
    End Sub

    Private Sub cmdStergeDateBenzinarii_Click(sender As Object, e As EventArgs) Handles cmdStergeDateBenzinarii.Click
        Dim result As DialogResult = MessageBox.Show("Atentie. Se vor sterge datele culese din fisierele de la benzinarii. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            'sterge toate inregistrarile din AlimentariCombustibil
            Dim eroare As String = ExecutaSQLkmAuto( "Delete from AlimentariCombustibil")
        End If
    End Sub
End Class