Public Class frmSchimbaDataRaportarii

    Private Sub cmdSalveaza_Click(sender As Object, e As EventArgs) Handles cmdSalveaza.Click
        gstrDataRaportariiSchimbata = convertDataAsStringOfFomat(dtpSchimbaDataRaportarii.Text, "yyyy-MM-dd")
        Me.Close()
    End Sub

    Private Sub frmSchimbaDataRaportarii_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gstrDataRaportariiSchimbata = ""
        Dim limitaZiIntreLuni As Long = ReturExecutaSqlRobots("Select FisiereBI from Config Where NumeRobot ='" & NumeRobot & "'")
        Dim strDataRaportarii As String = ReturExecutaSqlRobots("Select DataInterogare from Config Where NumeRobot ='" & NumeRobot & "'")
        If strDataRaportarii = "" Then
            dtpSchimbaDataRaportarii.Value = RectificaDataRaportarii(DateTime.Now, limitaZiIntreLuni)
        Else
            dtpSchimbaDataRaportarii.Value = convertStringDataToDate(strDataRaportarii)

        End If

    End Sub

    Private Sub cmdRenunta_Click(sender As Object, e As EventArgs) Handles cmdRenunta.Click
        Me.Close()

    End Sub
End Class