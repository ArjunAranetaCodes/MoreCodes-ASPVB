
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim strVowels As String = "a"
  Dim letterCount As Integer = 0
  Dim word As String = "program"

  For i As Integer = 0 To Len(word) - 1
   If strVowels.Contains(word.Substring(i, 1)) Then
    letterCount = letterCount + 1
   End If
  Next
  Label1.Text = "Total: " & letterCount
 End Sub

End Class

