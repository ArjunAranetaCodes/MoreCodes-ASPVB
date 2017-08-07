
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim word1 As String = "More"
  Dim word2 As String = "Codes"

  If word1 = word2 Then
   Label1.Text = "Equal"
  Else
   Label1.Text = "Not Equal"
  End If
 End Sub

End Class

