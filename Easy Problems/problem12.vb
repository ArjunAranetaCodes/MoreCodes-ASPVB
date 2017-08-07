
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Button1_Click(sender As Object, e As EventArgs)
  Handles Button1.Click
  Dim name As String

  name = TextBox1.Text
  Label1.Text = "Hello " & name
 End Sub
End Class

