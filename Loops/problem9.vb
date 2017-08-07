
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim num As Integer = 2

  For x As Integer = 1 To 10
   Label1.Text = Label1.Text & num & " x " & x &
   " = " & (num * x) & "<br/>"
  Next
 End Sub

End Class

