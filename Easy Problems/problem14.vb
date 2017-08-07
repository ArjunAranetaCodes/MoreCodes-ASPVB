
Public Class WebForm1
Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim word As String = "program"
  Dim newWord As String = Replace(word, "a", "e")
  Label1.Text = newWord
 End Sub

End Class

