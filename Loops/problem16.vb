
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim num As Integer = 5
  Dim fact As Integer = 1

  For x = num To 1 Step -1
   fact = fact * x
  Next
  Label1.Text = "Factorial of 5 is " & fact
 End Sub

End Class

