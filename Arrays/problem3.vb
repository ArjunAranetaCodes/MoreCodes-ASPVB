
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object,
  ByVal e As System.EventArgs) Handles Me.Load
  Dim arrNumbers() As Integer = {1, 1, 2, 3}
  Dim count As Integer = 0


  For Each num As Integer In arrNumbers
   If num = 1 Then
    count = count + 1
   End If
  Next

  Label1.Text = "Occurrence: " & count
 End Sub

End Class

