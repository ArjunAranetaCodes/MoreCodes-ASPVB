
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object,
  ByVal e As System.EventArgs) Handles Me.Load
  Dim array1() As Integer = {1, 2, 3}
  Dim array2() As Integer = {1, 2, 3, 4}

  If array1.SequenceEqual(array2) Then
   Label1.Text = "Equal Arrays"
  Else
   Label1.Text = "Not Equal"
  End If

 End Sub

End Class

