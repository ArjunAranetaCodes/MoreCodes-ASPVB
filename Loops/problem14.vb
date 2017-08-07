
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Button1_Click(sender As Object, e As EventArgs)
  Handles Button1.Click
  Dim num As Integer = 0
  Dim sum As Integer = 0
  Dim ave As Integer = 0

  sum = sum + Val(TextBox1.Text)
  sum = sum + Val(TextBox2.Text)
  sum = sum + Val(TextBox3.Text)
  sum = sum + Val(TextBox4.Text)
  sum = sum + Val(TextBox5.Text)

  ave = sum / 5
  Label1.Text = "Average is " & ave

 End Sub
End Class

