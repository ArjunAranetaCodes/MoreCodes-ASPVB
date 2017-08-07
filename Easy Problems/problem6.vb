
Public Class WebForm1
 Inherits System.Web.UI.Page

 Private Sub Button1_Click(sender As Object, e As EventArgs)
  Handles Button1.Click
  Dim num As Integer = Val(TextBox1.Text)

  If num Mod 2 = 0 Then
   Label1.Text = "Number is even"
  Else
   Label1.Text = "Number is odd"
  End If
 End Sub

End Class

