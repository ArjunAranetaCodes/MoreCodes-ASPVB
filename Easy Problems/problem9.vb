
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Button1_Click(sender As Object, e As EventArgs)
  Handles Button1.Click
  Dim num As Integer = Val(TextBox1.Text)
  Dim sum As Integer = 0

  For x As Integer = 0 To num
   sum = sum + x
  Next

  Label1.Text = "The sum of 1 to " & num & " is " & sum

 End Sub
End Class

