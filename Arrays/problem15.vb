
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object,
  ByVal e As System.EventArgs) Handles Me.Load
  Dim array1() As Integer = {1, 2, 3}
  Dim array2() As Integer

  array2 = array1
  For Each num As Integer In array2
   Label1.Text = Label1.Text & num & "<br/>"
  Next

 End Sub

End Class

