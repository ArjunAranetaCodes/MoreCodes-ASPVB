
Public Class WebForm1
 Inherits System.Web.UI.Page

 Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
  Dim num1 As Integer = Val(TextBox1.Text)
  Dim num2 As Integer = Val(TextBox2.Text)
  Dim sum As Integer = num1 + num2

  Label1.Text = "Sum is " & (sum)
 End Sub
End Class

