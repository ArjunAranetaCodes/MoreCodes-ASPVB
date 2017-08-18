
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object,
  ByVal e As System.EventArgs) Handles Me.Load
  Dim arrNumbers() As Integer = {1, 2, 3}

  Label1.Text = arrNumbers.First & "<br/>"
  Label1.Text = Label1.Text & arrNumbers.Last

 End Sub

End Class

