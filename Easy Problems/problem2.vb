
Public Class WebForm1
 Inherits System.Web.UI.Page

 Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
  Dim num1 As Integer = Val(TextBox1.Text)
  Dim num2 As Integer = Val(TextBox2.Text)

  Label1.Text = "Sum is " & (num1 + num2)
  Label2.Text = "Difference is " & (num1 - num2)
  Label3.Text = "Product is " & (num1 * num2)
  Label4.Text = "Quotient is " & (num1 / num2)
 End Sub
End Class

