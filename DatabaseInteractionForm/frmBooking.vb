Public Class frmBooking

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      ' Binding it to myTable
      DataGridView1.DataSource = Oracle.myTable
   End Sub

   Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
      Try
         Me.BindingContext(Oracle.myTable).EndCurrentEdit()
         Oracle.myOracleDataAdapter.Update(Oracle.myTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub SearcButton_Click(sender As Object, e As EventArgs) Handles SearcButton.Click


      If TableColumn.SelectedItem = "Date_From" Or TableColumn.SelectedItem = "Date_To" Then
         Oracle.myOracleCommand.CommandText =
                       "Select * " &
                       "From Booking " &
                       "Where " & TableColumn.SelectedItem & CompareValue.SelectedItem & "to_Date('" & Value.Text & "', 'mm/dd/yyyy')"
      Else
         Oracle.myOracleCommand.CommandText =
                          "Select * " &
                          "From Booking " &
                          "Where " & TableColumn.SelectedItem & CompareValue.SelectedItem & " '" & Value.Text & "'"
      End If
      Try
         Oracle.myTable.Clear()
         Oracle.myOracleDataAdapter.Fill(Oracle.myTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub ShowAllButton_Click(sender As Object, e As EventArgs) Handles ShowAllButton.Click
      Oracle.myOracleCommand.CommandText = "Select * from booking"
      Try
         Oracle.myTable.Clear()
         Oracle.myOracleDataAdapter.Fill(Oracle.myTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub
   Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
      Application.Exit()
   End Sub
End Class