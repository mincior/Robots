Imports Microsoft.SqlServer
Module Module1
    Public Sub mySub()
        'Dim myFunc As Func(Of integer, long) = Function( ByVal number As Integer) As Long
        'Dim n As Long = number +1
        'Return n
        'End Function
        'Dim m As Long = myFunc(43)

        Dim ExecutaSQL1 As Func(Of SqlClient.SqlCommand, String, String) = Function(cmd As SqlClient.SqlCommand, Sql As String) As String
                                                                               Try
                                                                                   Dim ds As New DataSet
                                                                                   cmd.CommandText = Sql
                                                                                   Dim oDataAdapter As New SqlClient.SqlDataAdapter(cmd)
                                                                                   oDataAdapter.Fill(ds)
                                                                                   Return "Ok"
                                                                               Catch ex As System.Exception
                                                                                   Return ex.Message
                                                                                   'Stop
                                                                               End Try

                                                                           End Function
        Dim ReturExecutaSql1 As Func(Of SqlClient.SqlCommand, String, System.Data.DataTable) = Function(cmd As SqlClient.SqlCommand, Sql As String) As System.Data.DataTable
                                                                                                   Try
                                                                                                       Dim ds As New DataSet
                                                                                                       cmd.CommandText = Sql
                                                                                                       Dim oDataAdapter As New SqlClient.SqlDataAdapter(cmd)
                                                                                                       oDataAdapter.Fill(ds)
                                                                                                       Return ds.Tables(0)
                                                                                                       Exit Function
                                                                                                   Catch ex As System.Exception

                                                                                                       Stop
                                                                                                   End Try
                                                                                                   Return New System.Data.DataTable

                                                                                               End Function


        Dim kmAutoConnectionString As String = "Data Source=10.0.0.10;Initial Catalog=KmAuto;Persist Security Info=True;User ID=sa;Password=P@ssword"
        Dim kmAutoSqlCon As New SqlClient.SqlConnection
        Dim kmAutoCmd As New SqlClient.SqlCommand

        kmAutoSqlCon.ConnectionString = kmAutoConnectionString
        kmAutoSqlCon.Open()
        kmAutoCmd.Connection = kmAutoSqlCon
        kmAutoCmd.CommandTimeout = 20000

        Dim res As String = ExecutaSQL1(kmAutoCmd, "Delete from Utilizatori")
    End Sub

End Module
