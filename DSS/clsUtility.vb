Public Class clsUtility

    ''' <summary>
    ''' Execute a SQL command
    ''' </summary>
    ''' <param name="sqlString">SQL command</param>
    ''' <param name="sqlConnection">SQL Server connection</param>
    ''' <returns>number of record affected, -1 in case of error</returns>
    ''' <remarks></remarks>
    Public Shared Function ExecuteSQL(ByVal sqlString As String, ByVal sqlConnection As System.Data.SqlClient.SqlConnection) As Integer
        Dim cmd As System.Data.SqlClient.SqlCommand
        Dim ret As Integer = -1
        Dim connectionAlreadyOpen As Boolean = False

        Try
            Try
                If sqlConnection.State = ConnectionState.Closed Then
                    sqlConnection.Open()
                Else
                    connectionAlreadyOpen = True
                End If
            Catch ex1 As Exception
            End Try

            sqlString = "SET DATEFORMAT dmy;" & sqlString
            Try
                cmd = New SqlClient.SqlCommand(sqlString, sqlConnection)
                ret = cmd.ExecuteNonQuery()
            Catch ex2 As Exception
                ret = -1
            End Try
        Catch ex As Exception
            ret = -1
        Finally
            If Not connectionAlreadyOpen Then
                sqlConnection.Close()
            End If
        End Try

        Return ret
    End Function
End Class
