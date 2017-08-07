
Public Class WebForm1
 Inherits System.Web.UI.Page

 Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
  Dim radius As Integer = Val(TextBox1.Text)
  Dim PI As Double = 3.14
  Dim dia As Double = 0.0
  Dim area As Double = 0.0
  Dim cir As Double = 0.0

  dia = radius + radius
  area = PI * dia
  cir = 2 * PI * radius

  Label1.Text = "Diameter of circle is " & dia
  Label2.Text = "Area of circle is " & area
  Label3.Text = "Circumference of circle is " & cir
 End Sub
End Class

