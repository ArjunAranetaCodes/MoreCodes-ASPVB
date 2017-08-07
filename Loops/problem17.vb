
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim num1 As Integer
  Dim num2 As Integer
  num1 = 1
  num2 = 1

  Label1.Text = Label1.Text & num1 & "<br/>"

  While num2 < 100
   Label1.Text = Label1.Text & num2 & "<br/>"
   num2 = num2 + num1
   num1 = num2 - num1
  End While
 End Sub

End Class

