Imports DatabaseInteractionForm

Public Class Oracle
   Friend Shared UserName As String
   Friend Shared PassWd As String
   Friend Shared Server As String

   ' Make sure to add reference to System.Data.OracleClient
   Friend Shared myOracleDataAdapter As New System.Data.OracleClient.OracleDataAdapter
   Friend Shared myOracleCommand As New System.Data.OracleClient.OracleCommand
   Friend Shared myOracleConnection As New System.Data.OracleClient.OracleConnection
   Friend Shared myOracleCommandBuilder As System.Data.OracleClient.OracleCommandBuilder
   Friend Shared frmLogin As New FormLogin
   Private Shared frmBooking As New frmBooking
   Friend Shared myTable As New System.Data.DataTable
   Friend Shared Result As ResponseType
   Public Enum ResponseType
      OK
      Cancel
   End Enum



   Public Shared Sub LogInAtRunTime()

      myOracleConnection.ConnectionString = "Data Source = " & Server & ";Persist Security Info=True;User ID=" & UserName & ";Password=" & PassWd & ";Unicode=True"

      myOracleCommand.CommandType = CommandType.Text
      myOracleCommand.CommandText = "Select * from booking"
      myOracleCommand.Connection = myOracleConnection

      myOracleDataAdapter.SelectCommand = myOracleCommand
      myOracleCommandBuilder = New System.Data.OracleClient.OracleCommandBuilder(myOracleDataAdapter)

      myOracleDataAdapter.Fill(myTable)
   End Sub

   Public Shared Sub main()
      Dim connected As Boolean

      While Not connected
         frmLogin.ShowDialog()
         If Result = ResponseType.Cancel Then
            Exit While
         End If

         Try
            LogInAtRunTime()
            connected = True
         Catch ex As Exception
            MessageBox.Show(ex.Message)
         End Try
      End While

      If connected Then
         Application.Run(frmBooking)
      End If
   End Sub

End Class
