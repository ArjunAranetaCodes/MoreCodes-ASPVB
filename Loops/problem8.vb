
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim strVowels As String = "aeiou"
  Dim vowelCount As Integer = 0
  Dim word As String = "program"

  For i As Integer = 0 To Len(word) - 1
   If strVowels.Contains(word.Substring(i, 1)) Then
    vowelCount = vowelCount + 1
   End If
  Next
  Label1.Text = "Total Vowels: " & vowelCount
 End Sub

End Class

