
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim word As String = "anna"
  Dim tempWord As String = StrReverse(word)

  If word = tempWord Then
   Label1.Text = "Palindrome"
  Else
   Label1.Text = "Not Palindrome"
  End If
 End Sub

End Class

