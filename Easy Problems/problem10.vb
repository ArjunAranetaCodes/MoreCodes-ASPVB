
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Button1_Click(sender As Object, e As EventArgs)
  Handles Button1.Click
  Dim ave As Integer = 0
  Dim num1 As Integer = Val(TextBox1.Text)
  Dim num2 As Integer = Val(TextBox2.Text)
  Dim num3 As Integer = Val(TextBox3.Text)
  ave = (num1 + num2 + num3) / 3

  Label1.Text = "Average is " & ave
 End Sub
End Class

