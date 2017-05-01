Public Class Oracle
   Friend Shared UserName As String
   Friend Shared PassWd As String
   Friend Shared Server As String

   ' Make sure to add reference to System.Data.OracleClient
   Friend Shared myOracleDataAdapter As New System.Data.OracleClient.OracleDataAdapter
   Friend Shared myOracleCommand As New System.Data.OracleClient.OracleCommand
   Friend Shared myOracleConnection As New System.Data.OracleClient.OracleConnection
   Friend Shared myOracleCommandBuilder As System.Data.OracleClient.OracleCommandBuilder

   Friend Shared myTable As New System.Data.DataTable

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
      LogInAtRunTime()

      Application.Run(New Form1)
   End Sub

End Class
