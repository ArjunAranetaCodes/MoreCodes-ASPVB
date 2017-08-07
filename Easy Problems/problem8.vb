
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim sum As Integer = 0

  For x As Integer = 0 To 30
   If x Mod 5 = 0 Then
    sum = sum + x
   End If
  Next

  Label1.Text = "The sum of numbers divisible by 5 from 1 to 30 is " & sum

 End Sub

End Class

