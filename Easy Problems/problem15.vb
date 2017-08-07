
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim word As String = "programming"
  Dim strSearch As String = "program"
  If word.Contains(strSearch) Then
   Label1.Text = strSearch & " found"
  Else
   Label1.Text = strSearch & " not found"
  End If
 End Sub

End Class

