Public Class FormLogin

   Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
      Oracle.UserName = TextBox1.Text
      Oracle.PassWd = TextBox2.Text
      Oracle.Server = TextBox3.Text

      Oracle.Result = Oracle.ResponseType.OK

      Me.Close()

   End Sub

   Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
      Oracle.Result = Oracle.ResponseType.Cancel

      Me.Close()
   End Sub
End Class
