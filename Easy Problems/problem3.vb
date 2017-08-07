
Public Class WebForm1
 Inherits System.Web.UI.Page

 Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
  Dim length As Integer = Val(TextBox1.Text)
  Dim width As Integer = Val(TextBox2.Text)
  Dim area As Integer = length * width

  Label1.Text = "Area of Rectangle is " & area
 End Sub
End Class

