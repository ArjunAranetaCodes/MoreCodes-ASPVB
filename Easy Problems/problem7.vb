
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim sum As Integer = 0

  For x As Integer = 0 To 20
   sum = sum + x
  Next

  Label1.Text = "The sum of 1 to 20 is " & sum
 End Sub

End Class

