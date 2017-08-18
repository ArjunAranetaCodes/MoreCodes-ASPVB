
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object,
  ByVal e As System.EventArgs) Handles Me.Load
  Dim arrNumbers() As Integer = {1, 2, 3}

  If arrNumbers.Contains(2) Then
   Label1.Text = "Contains 2"
  Else
   Label1.Text = "Does not contains 2"
  End If

 End Sub

End Class

