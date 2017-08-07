
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim word1 As String = "More"
  Dim word2 As String = "Codes"
  Dim newWord As String = word1 & word2

  Label1.Text = newWord
 End Sub

End Class

