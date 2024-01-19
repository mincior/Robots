Imports System.ComponentModel
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Office.Core
Imports Microsoft.Win32

Public Class frmEmails
    Private Sub frmEmails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 795, 834)

    End Sub

    Private Sub frmEmails_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        SalveazaDimensiuniSiPozitie(Me)
        Try
            Registry.CurrentUser.DeleteSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInMailuriUtilizatori\")

        Catch

        End Try
        SaveSetting(AppName, "Settings", "CautareInMailuriUtilizatori_selectedIndex", cmbCautare.SelectedIndex)

        Registry.CurrentUser.CreateSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInMailuriUtilizatori\")
        For Each item As String In cmbCautare.Items
            Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInMailuriUtilizatori\", item, item)
        Next

        Me.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        IncarcaMailuriFiliale()
        Try
            Registry.CurrentUser.CreateSubKey("SOFTWARE\VB and VBA Program Settings\" & AppName & "\Settings" & "\CautareInMailuriUtilizatori\")

            Dim CautareInKmLogCombo As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\VB and VBA Program Settings\KmAutoInterface\Settings\CautareInMailuriUtilizatori")
            For Each ValueName As String In CautareInKmLogCombo.GetValueNames()
                Dim Value As Object = CautareInKmLogCombo.GetValue(ValueName) 'Get the value (data) of the specified value name.
                If Value IsNot Nothing Then 'Make sure it exists.
                    cmbCautare.Items.Add(Value.ToString())
                End If
            Next
            cmbCautare.SelectedIndex = GetSetting(AppName, "Settings", "CautareInMailuriUtilizatori_selectedIndex", 0)


        Catch

        End Try
        IncarcaMailuriUtilizatori(cmbCautare.Text)
        cmbCautareSelectare.Select()
        cmbSubiect.SelectedIndex = 0
        textBoxEmail.Text = "Buna ziua. " & vbCrLf & vbCrLf &
            "Acesta este un mail de informare catre toti utilizatorii aplicatiei KmAuto. Chiar daca apare trimis individual, este trimis din aplicatie de catre un robot. " & vbCrLf & vbCrLf &
            "In fisierul atasat aveti cateva sfaturi, observatii referitoare la modul in care ati introdus dv. km in aplicatie." & vbCrLf & vbCrLf &
            "Adresa aplicatiei pe telefon: https://auto.consolight.ro/ ." & vbCrLf & vbCrLf &
            "Daca aveti orice fel de nelamuriri legate de introducerea datelor In aplicatie, va rog sa ma sunati la numarul  0742134762 sau pe dl. Petrica Ilie la nr. 0742130761 " & vbCrLf & vbCrLf & "Cu respect, Mincior V."
        TextBoxSelectareAutomataText.Text = GetSetting(AppName, "Settings", "TextBoxSelectareAutomataText", "")
        If gstrSearch <> "" Then
            cmbCautare.Text = gstrSearch
            gstrSearch = ""
        End If
        cmbCautareSelectare.Select()
    End Sub
    Private Sub IncarcaMailuriFiliale()
        Dim filialeDataTable As DataTable = ReturDataTableKmAuto("Select Nume, Responsabil, Email from Filiale")
        For Each row As DataRow In filialeDataTable.Rows
            If row("Email") <> "" Then
                Dim lvf As ListViewItem = lvFiliale.Items.Add(row("Nume"))
                lvf.SubItems.Add(row("Responsabil"))
                lvf.SubItems.Add(row("Email"))
            End If
        Next
        lvFiliale.EndUpdate()
        lvFiliale.Refresh()
    End Sub
    Private Sub IncarcaMailuriUtilizatori(Optional search As String = "")
        lvUtilizatori.Items.Clear()
        Dim searchWord As String = If(search.Length > 0, " And (dbo.Utilizatori.Nume LIKE '%" & Trim(search) & "%')", "")

        Dim utilizatoriDataTable As DataTable = ReturDataTableKmAuto("Select Nume, Email, EmailConsolight, Telefon from Utilizatori Where Activ ='Da' " & searchWord & " Order by Nume ;")
        For Each row As DataRow In utilizatoriDataTable.Rows
            If row("Email") <> "" Or row("EmailConsolight") <> "" Then
                Dim lvu As ListViewItem = lvUtilizatori.Items.Add(row("Nume"))
                lvu.SubItems.Add(row("Email"))
                lvu.SubItems.Add(row("EmailConsolight"))
                lvu.SubItems.Add(row("Telefon"))
            End If
        Next
        lvUtilizatori.EndUpdate()
        lvUtilizatori.Refresh()

    End Sub

    Private Sub cmbCautare_TextChanged(sender As Object, e As EventArgs) Handles cmbCautare.TextChanged, cmbCautare.SelectedIndexChanged
        Timer3.Enabled = False
        Timer3.Enabled = True

    End Sub
    Private Sub cmbCautare_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCautare.KeyPress
        If e.KeyChar = Chr(27) Then
            cmbCautare.Text = ""
        End If
        Dim gasit As Boolean = False
        If e.KeyChar = Chr(13) Then
            For Each item As String In cmbCautare.Items
                If item = cmbCautare.Text Then
                    gasit = True
                End If
            Next
            If gasit = False Then
                cmbCautare.Items.Add(cmbCautare.Text)
            End If
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If cmbCautare.Text = "" Then
            cmbCautare.BackColor = SystemColors.Window
        Else
            cmbCautare.BackColor = Color.Yellow

        End If



    End Sub



    Private Sub cmdStergeListaCautare_Click(sender As Object, e As EventArgs) Handles cmdStergeListaCautare.Click
        Dim result As DialogResult = MessageBox.Show("Stergeti lista de cautare?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            cmbCautare.Items.Clear()
            cmbCautare.Text = ""
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Enabled = False
        IncarcaMailuriUtilizatori(cmbCautare.Text)
        cmbCautare.Select(cmbCautare.Text.Length, 0)        'pune cursorul la final

    End Sub

    Private Sub cmdStergeCrt_Click(sender As Object, e As EventArgs) Handles cmdStergeCrt.Click
        cmbCautare.Items.Remove(cmbCautare.Text)
        Try
            cmbCautare.SelectedIndex = 0

        Catch

        End Try
    End Sub
    Private Sub cmdSelecteazaTotFiliale_Click(sender As Object, e As EventArgs) Handles cmdSelecteazaTotFiliale.Click
        For Each lvf As ListViewItem In lvFiliale.Items
            lvf.Checked = True
        Next
    End Sub

    Private Sub cmdDeselecteazaTotFiliale_Click(sender As Object, e As EventArgs) Handles cmdDeselecteazaTotFiliale.Click
        For Each lvf As ListViewItem In lvFiliale.Items
            lvf.Checked = False
        Next

    End Sub

    Private Sub cmdSelecteazaTotUtilizatori_Click(sender As Object, e As EventArgs) Handles cmdSelecteazaTotUtilizatori.Click
        For Each lvu As ListViewItem In lvUtilizatori.Items
            lvu.Checked = True
        Next

    End Sub

    Private Sub cmdDeselecteazaTotUtilizatori_Click(sender As Object, e As EventArgs) Handles cmdDeselecteazaTotUtilizatori.Click
        For Each lvu As ListViewItem In lvUtilizatori.Items
            lvu.Checked = False
        Next

    End Sub

    Private Sub cmdTrimite_Click(sender As Object, e As EventArgs) Handles cmdTrimite.Click
        pbIncarca.Value = 0
        Dim attach = New List(Of String)
        Dim v() As String = Split(TextBoxAtasamente.Text, vbCrLf)
        Dim k As Long
        For k = 0 To UBound(v) - 1
            attach.Add(v(k))

        Next
        Dim result As DialogResult = MessageBox.Show("Se vor trimite emailuri catre selectiile facute, cu subiectul si continutul din partea dreapta a ferestrei. Continuati?", "KmAuto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim numarDestinatari As Long = 0
            Cursor = Cursors.WaitCursor
            For Each lvf As ListViewItem In lvFiliale.Items
                If lvf.Checked = True Then
                    numarDestinatari += 1
                End If
            Next
            For Each lvu As ListViewItem In lvUtilizatori.Items
                If lvu.Checked = True Then
                    numarDestinatari += 1
                End If
            Next
            pbIncarca.Maximum = numarDestinatari + 1
            numarDestinatari = 0
            For Each lvf As ListViewItem In lvFiliale.Items
                If lvf.Checked = True Then
                    numarDestinatari += 1
                    sendSimpleEmail(lvf.SubItems(2).Text, cmbSubiect.Text, textBoxEmail.Text, attach)
                End If
                pbIncarca.Value = numarDestinatari
            Next
            For Each lvu As ListViewItem In lvUtilizatori.Items
                If lvu.Text = "Ilie Petrica" Then
                    lvu.Selected = True
                End If
            Next
            For Each lvu As ListViewItem In lvUtilizatori.Items
                If lvu.Checked = True Then
                    Dim em As String
                    If lvu.SubItems(1).Text.Length > 0 And lvu.SubItems(2).Text.Length > 0 Then
                        em = lvu.SubItems(1).Text & "; " & lvu.SubItems(2).Text
                    Else
                        em = lvu.SubItems(1).Text & lvu.SubItems(2).Text
                    End If
                    numarDestinatari += 1
                    pbIncarca.Value = numarDestinatari
                    sendSimpleEmail(em, cmbSubiect.Text, textBoxEmail.Text, attach)

                End If
            Next
            MessageBox.Show("S-au transmis " & numarDestinatari & " emailuri")
            pbIncarca.Value = 0
            Cursor = Cursors.Default
        End If

    End Sub

    Private Sub cmdAddAtach_Click(sender As Object, e As EventArgs) Handles cmdAddAtach.Click
        ' Call ShowDialog.
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then

            ' Get the file name.
            Try

                Dim paths() As String = OpenFileDialog1.FileNames
                For Each str As String In paths
                    TextBoxAtasamente.Text &= str & vbCrLf
                Next

            Catch ex As System.Exception

                ' Report an error.
                Me.Text = "Error"

            End Try
        End If

    End Sub

    Private Sub cmdInchide_Click(sender As Object, e As EventArgs) Handles cmdInchide.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxSelectareAutomataText.Text <> "" Then
            Dim s As String = TextBoxSelectareAutomataText.Text
            Dim v() As String = Split(s, vbCrLf)
            If UBound(v) > 0 Then
                Dim k As Integer, i As Integer
                For i = 0 To lvUtilizatori.Items.Count - 1
                    lvUtilizatori.Items(i).Checked = False
                    For k = 0 To UBound(v)
                        If lvUtilizatori.Items(i).Text = v(k) Then
                            lvUtilizatori.Items(i).Checked = True
                            Exit For
                        End If
                    Next
                Next
                SaveSetting(AppName, "Settings", "TextBoxSelectareAutomataText", TextBoxSelectareAutomataText.Text)

            End If
        End If
    End Sub

    Private Sub cmbCautareSelectare_TextChanged(sender As Object, e As EventArgs) Handles cmbCautareSelectare.TextChanged
        Timer4.Enabled = False
        Timer4.Enabled = True

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim cnt As Integer = 0
        Timer4.Enabled = False
        lvUtilizatori.Select()
        For i = 0 To lvUtilizatori.Items.Count - 1
            lvUtilizatori.Items(i).Selected = False
            If lvUtilizatori.Items(i).Checked = True Then
                cnt += 1
            End If
        Next
        For i = 0 To lvUtilizatori.Items.Count - 1
            If LCase(lvUtilizatori.Items(i).Text).Contains(LCase(cmbCautareSelectare.Text)) = True Then
                lvUtilizatori.Items(i).EnsureVisible()
                lvUtilizatori.Items(i).Focused = True
                lvUtilizatori.Items(i).Selected = True
                Exit For
            End If
        Next
        Me.Text = "Utilizatori selectati: " & cnt
    End Sub

    Private Sub cmbCautareSelectare_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCautareSelectare.SelectedIndexChanged

    End Sub

    Private Sub lvUtilizatori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvUtilizatori.SelectedIndexChanged

    End Sub

    Private Sub lvUtilizatori_KeyUp(sender As Object, e As KeyEventArgs) Handles lvUtilizatori.KeyUp
        If e.KeyCode = 32 Then
            cmbCautareSelectare.Select()
        End If
    End Sub

    Private Sub cmdTot_Click(sender As Object, e As EventArgs) Handles cmdTot.Click
        cmbCautare.Text = ""
    End Sub
End Class