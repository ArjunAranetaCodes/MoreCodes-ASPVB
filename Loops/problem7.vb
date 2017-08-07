
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim n As Integer = 10
  Dim sum As Integer = 0
  For x As Integer = 1 To n
   sum = sum + x
  Next
  Label1.Text = "Sum is " & sum
 End Sub

End Class

