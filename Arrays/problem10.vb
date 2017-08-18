
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object,
  ByVal e As System.EventArgs) Handles Me.Load
  Dim arrNumbers() As Integer = {1, 2, 3, 4}

  Label1.Text = "Average is " & arrNumbers.Average

 End Sub

End Class

