'Switch Statement

Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object,
 ByVal e As System.EventArgs) Handles Me.Load
  Dim num1 As Integer = 10

  Select Case num1
   Case 1
    Label1.Text = "Seems it is number 1"
   Case 5, 10
    Label1.Text = "Feels like it is five or 10"
  End Select
End Sub

End Class
