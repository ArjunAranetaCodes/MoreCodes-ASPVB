
Public Class WebForm1
Inherits System.Web.UI.Page

Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
 Handles Me.Load
 Dim rand As Random = New Random

 For x As Integer = 0 To 4
  Label1.Text = Label1.Text & (rand.Next(1, 9)) & "<br/>"
 Next
End Sub

End Class

