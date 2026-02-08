    Imports MySql.Data.MySqlClient

    Module dbconnection
        Public conn As MySqlConnection
        Public cmd As MySqlCommand
        Public da As MySqlDataAdapter
        Public ds As DataSet
        Public dr As MySqlDataReader
        Public sql As String
        Public Property currentUserID As Integer
        ' Function to get a new connection
        Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;userid=root;password=;database=pos_grocery1")
    End Function


        ' Optional Sub to test connection
        Public Sub TestConnection()
            Try
                Using conn As MySqlConnection = GetConnection()
                    conn.Open()
                    MsgBox("Connected Successfully!")
                End Using
            Catch ex As MySqlException
                MsgBox("Connection Failed: " & ex.Message)
            End Try
        End Sub
    End Module
