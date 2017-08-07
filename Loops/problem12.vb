
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim num1 As Integer = 3
  Dim num2 As Integer = 5
  Dim prod As Integer = 0

  For x = 1 To 5
   prod = prod + num1
  Next
  Label1.Text = "3 * 5 = " & prod
 End Sub

End Class

