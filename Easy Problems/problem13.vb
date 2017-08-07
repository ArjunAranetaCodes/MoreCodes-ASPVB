
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim word As String = "MoreCodes"
  Dim strLength As Integer = Len(word)
  Label1.Text = "String Length: " & strLength.ToString()
 End Sub

End Class

