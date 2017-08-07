
Public Class WebForm1
 Inherits System.Web.UI.Page

 Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
  Dim celsius As Double = Val(TextBox1.Text)
  Dim farenheit As Double = 0.0

  farenheit = (9.0 / 5.0) * celsius + 32
  Label1.Text = celsius & "C equals to " & farenheit & "F"
 End Sub
End Class

