Imports System.ComponentModel
Imports Google.Apis.Util

Public Class frmJurnal
    Private inEditare, inAdaugare As Boolean
    Private Sub frmJurnal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IncarcaDimensiuniSiPozitie(Me, 300, 48, 934, 534)
        incarcaMasiniSiUtilizatori
        UpdateGrid()
    End Sub
    Private Sub incarcaMasiniSiUtilizatori()
        Dim sql As String = "Select Numar from Masini order by Numar"
        sql = clearSql(sql)
        Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto(sql)
        cmbMasini.Items.Add("")
        For Each row As DataRow In myDataTable.Rows
            cmbMasini.Items.Add(row("Numar"))
        Next

        sql = "Select Nume from Utilizatori order by Nume"
        sql = clearSql(sql)
        Dim myDataTableUtilizatori As System.Data.DataTable = ReturDataTableKmAuto(sql)
        cmbUtilizatori.Items.Add("")
        For Each row As DataRow In myDataTableUtilizatori.Rows
            cmbUtilizatori.Items.Add(row("Nume"))
        Next

    End Sub
    Private Sub UpdateGrid()
        DataGridView1.Rows.Clear()
        Dim sql As String = "SELECT Nume, Numar, Observatii, Data " &
                     "FROM dbo.Jurnal Order by data desc"
        sql = clearSql(sql)
        Dim myDataTable As System.Data.DataTable = ReturDataTableKmAuto(sql)
        For Each row As DataRow In myDataTable.Rows
            Dim inputData(3) As Object
            inputData(0) = CType(row("Data"), Date).ToString("yyyy-MM-dd HH:mm:ss")
            inputData(1) = row("Nume")
            inputData(2) = row("Numar")
            Try
                inputData(3) = row("Observatii")

            Catch ex As System.Exception

            End Try
            DataGridView1.Rows.Add(inputData)
        Next

    End Sub

    Private Sub frmJurnal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SalveazaDimensiuniSiPozitie(Me)

    End Sub
    Private Sub txtCautareMasina_TextChanged(sender As Object, e As EventArgs) Handles txtCautareMasina.TextChanged
        txtCautareMasina.BackColor = System.Drawing.Color.Red
        txtCautareMasina.ForeColor = System.Drawing.Color.Yellow
        For Each item As String In cmbMasini.Items
            If LCase(item).Contains(LCase(txtCautareMasina.Text)) Then
                cmbMasini.SelectedItem = item

                txtCautareMasina.BackColor = System.Drawing.Color.Green
                txtCautareMasina.ForeColor = System.Drawing.Color.White
                Exit For
            End If
        Next
    End Sub
    Private Sub txtCautareUtilizator_TextChanged(sender As Object, e As EventArgs) Handles txtCautareUtilizator.TextChanged
        txtCautareUtilizator.BackColor = System.Drawing.Color.Red
        txtCautareUtilizator.ForeColor = System.Drawing.Color.Yellow
        For Each item As String In cmbUtilizatori.Items
            If LCase(item).Contains(LCase(txtCautareUtilizator.Text)) Then
                cmbUtilizatori.SelectedItem = item
                txtCautareUtilizator.BackColor = System.Drawing.Color.Green
                txtCautareUtilizator.ForeColor = System.Drawing.Color.White
                Exit For
            End If
        Next

    End Sub


    Private Sub cmdKm_Click(sender As Object, e As EventArgs) Handles cmdKm.Click
        frmKmLogView.ShowDialog()
        frmKmLogView.Dispose()

    End Sub

    Private Sub cmdGreseli_Click(sender As Object, e As EventArgs) Handles cmdGreseli.Click
        frmGreseliLog.ShowDialog()
        frmGreseliLog.Dispose()

    End Sub

    Private Sub cmdEmail_Click(sender As Object, e As EventArgs) Handles cmdEmail.Click
        frmEmails.ShowDialog()
    End Sub

    Private Sub cmdMasini_Click(sender As Object, e As EventArgs) Handles cmdMasini.Click
        frmMasini.ShowDialog()
        frmMasini.Dispose()

    End Sub

    Private Sub cmdUtilizatori_Click(sender As Object, e As EventArgs) Handles cmdUtilizatori.Click
        frmUtilizatori.ShowDialog()
        frmUtilizatori.Dispose()

    End Sub

    Private Sub cmdIesire_Click(sender As Object, e As EventArgs) Handles cmdIesire.Click
        Me.Close()

    End Sub



    Private Sub chkMasina_CheckedChanged(sender As Object, e As EventArgs) Handles chkMasina.CheckedChanged
        GetAllControls(Me, GetType(System.Windows.Forms.Label)).ToList.ForEach(
           Sub(c As System.Windows.Forms.Label)
               If c.Name.Substring(0, 2) = "xl" Then
                   c.Enabled = chkMasina.Checked
               End If
           End Sub)
        cmbMasini.Visible = chkMasina.Checked
        txtCautareMasina.Visible = chkMasina.Checked
        If chkMasina.Checked = True Then
            txtCautareMasina.Select()
        Else
            txtCautareUtilizator.Select()

        End If
    End Sub

    Private Sub cmbMasini_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMasini.SelectedIndexChanged
        Try
            xlFiliala.Text = ReturExecutaSqlKmAuto("Select Nume from Filiale where id=" & cmbMasini.SelectedItem.row("FilialaId"))

        Catch ex As Exception
            xlFiliala.Text = ""
        End Try
    End Sub

    Private Sub cmbUtilizatori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUtilizatori.SelectedIndexChanged
        Try
            lblFiliala.Text = ReturExecutaSqlKmAuto("Select Nume from Filiale where id=" & cmbUtilizatori.SelectedItem.row("FilialaId"))
            txtCautareMasina.Text = ReturExecutaSqlKmAuto("SELECT TOP (1) dbo.Masini.Numar " &
                     "FROM dbo.Masini INNER JOIN " &
                     "dbo.KmLog ON dbo.Masini.Id = dbo.KmLog.MasinaId INNER JOIN " &
                     "dbo.Utilizatori ON dbo.KmLog.UtilizatorId = dbo.Utilizatori.Id " &
                     "WHERE (dbo.Utilizatori.Nume = N'" & cmbUtilizatori.Text & "') " &
                     "ORDER BY dbo.KmLog.Data DESC"
)
        Catch ex As Exception
            lblFiliala.Text = ""
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Try
            xlFiliala.Text = ReturExecutaSqlKmAuto("Select Nume from Filiale where id=" & cmbMasini.SelectedItem.row("FilialaId"))

        Catch ex As Exception
            xlFiliala.Text = ""
        End Try
        Try
            lblFiliala.Text = ReturExecutaSqlKmAuto("Select Nume from Filiale where id=" & cmbUtilizatori.SelectedItem.row("FilialaId"))

        Catch ex As Exception
            lblFiliala.Text = ""
        End Try
        txtCautareUtilizator.Select()
        incarcaDinGrid()
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        incarcaDinGrid()

    End Sub

    Private Sub incarcaDinGrid()
        Try
            Dim row As DataGridViewRow = DataGridView1.CurrentRow
            cmbUtilizatori.Text = row.Cells("Nume").Value
            txtObservatii.Text = row.Cells("Observatii").Value
            cmbMasini.Text = row.Cells("Numar").Value

        Catch ex As Exception

        End Try


    End Sub

    Private Sub cmdAdauga_Click(sender As Object, e As EventArgs) Handles cmdAdauga.Click
        inAdaugare = True
        txtCautareUtilizator.Select()
    End Sub

    Private Sub cmdEditeaza_Click(sender As Object, e As EventArgs) Handles cmdEditeaza.Click
        inEditare = True
        txtObservatii.Select()

    End Sub

    Private Sub cmdRenunta_Click(sender As Object, e As EventArgs) Handles cmdRenunta.Click
        inEditare = False
        inAdaugare = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        cmdAdauga.Enabled = Not (inEditare Or inAdaugare)
        cmdEditeaza.Enabled = Not (inEditare Or inAdaugare)
        cmdRenunta.Enabled = (inEditare Or inAdaugare)
        cmdSalveaza.Enabled = (inEditare Or inAdaugare)
        txtCautareUtilizator.Enabled = (inEditare Or inAdaugare)
        txtCautareMasina.Enabled = (inEditare Or inAdaugare)
        chkMasina.Enabled = (inEditare Or inAdaugare)
        cmbUtilizatori.Enabled = (inEditare Or inAdaugare)
        cmbMasini.Enabled = (inEditare Or inAdaugare)
        txtObservatii.Enabled = (inEditare Or inAdaugare)
    End Sub

    Private Sub cmdSalveaza_Click(sender As Object, e As EventArgs) Handles cmdSalveaza.Click
        'daca este bifata caseta Masini va salva si masina, altfel nu
        Dim myd As Date = DateAndTime.Now
        If inadaugare = True Then
            If ExecutaSQLKmAuto("Insert into Jurnal (Data, Nume, " & If(chkMasina.Checked = True, "Numar, ", "") & " Observatii) values ('" & DateAndTime.Now & "', '" & cmbUtilizatori.Text & "', " & If(chkMasina.Checked = True, "'" & cmbMasini.Text & "', ", "") & " '" & txtObservatii.Text & "');") = "Ok" Then
                UpdateGrid()
            End If
        Else
            If ExecutaSQLKmAuto("Update Jurnal SET Data = '" & myd & "', Nume ='" & cmbUtilizatori.Text & "', Numar = " & If(chkMasina.Checked = True, "'" & cmbMasini.Text & "'", "N''") & ", Observatii ='" & txtObservatii.Text & "' Where Data = '" & DataGridView1.CurrentRow.Cells("Data").Value & "';") = "Ok" Then
                UpdateGrid()
            End If

        End If
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells("Data").Value = CType(myd, Date).ToString("yyyy-MM-dd HH:mm:ss") Then
                DataGridView1.CurrentCell = row.Cells("Data")
                Exit For
            End If
        Next
        inEditare = False
        inAdaugare = False
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub cmdSterge_Click(sender As Object, e As EventArgs) Handles cmdSterge.Click
        Try
            If ExecutaSQLKmAuto("Delete from Jurnal Where Data ='" & DataGridView1.CurrentRow.Cells("Data").Value & "'") = "Ok" Then
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class