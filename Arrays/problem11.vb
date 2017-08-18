
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object,
  ByVal e As System.EventArgs) Handles Me.Load
  Dim arrNumbers() As Integer = {1, 2, 3, 4}
  Array.Reverse(arrNumbers)

  For Each num As Integer In arrNumbers
   Label1.Text = Label1.Text & num & "<br/>"
  Next

 End Sub

End Class

