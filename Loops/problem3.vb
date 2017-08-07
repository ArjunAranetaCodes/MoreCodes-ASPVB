
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim word As String = "MoreCodes"
  Dim count As Integer = 0

  For Each element As Char In word
   count = count + 1
  Next

  Label1.Text = "String Length: " & count
 End Sub

End Class

