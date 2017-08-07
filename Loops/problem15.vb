
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Button1_Click(sender As Object, e As EventArgs)
  Handles Button1.Click
  Dim num As Integer = Val(TextBox1.Text)

  If num < 0 Then
   Label1.Text = "Terminated."
  End If

 End Sub
End Class

