
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim word As String = "MoreCodes"
  Dim newWord As String = ""

  For x = Len(word) - 1 To 0 Step -1
   newWord = newWord & word.Substring(x, 1)
  Next
  Label1.Text = newWord
 End Sub

End Class

