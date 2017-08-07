
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  For x As Integer = 0 To 20
   If x Mod 2 = 1 Then
    Label1.Text = Label1.Text & x & "<br/>"
   End If
  Next
 End Sub

End Class

