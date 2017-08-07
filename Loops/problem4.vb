
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  For y As Integer = 0 To 5
   For x As Integer = 0 To y
    Label1.Text = Label1.Text & "*"
   Next
   Label1.Text = Label1.Text & "<br/>"
  Next
 End Sub

End Class

