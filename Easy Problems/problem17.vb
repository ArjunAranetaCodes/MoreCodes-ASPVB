
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim word As String = "program"
  Dim letter As String = "a"

  If word.Contains(letter) Then
   Label1.Text = "Contains a"
  Else
   Label1.Text = "Does Not Contain a"
  End If
 End Sub

End Class

