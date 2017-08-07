
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim num As Integer = 371
  Dim sum As Integer = 0
  Dim temp As Integer = 0
  Dim rmdr As Integer = 0

  temp = num

  While Not (temp = 0)
   rmdr = temp Mod 10
   sum = sum + (rmdr * rmdr * rmdr)
   temp = temp \ 10
  End While

  If (num = sum) Then
   Label1.Text = "Armstrong number."
  Else
   Label1.Text = "Not an Armstrong number."
  End If
 End Sub

End Class

