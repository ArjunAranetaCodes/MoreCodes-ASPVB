'If, ElseIf, and Else Structure

Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object,
  ByVal e As System.EventArgs) Handles Me.Load
  Dim num1 As Integer = 1
  Dim num2 As Integer = 2

  If num1 > num2 Then
   Label1.Text = "First number is higher!"
  End If

  If num1 = num2 Then
   Label2.Text = "They are equal!"
  Else
   Label2.Text = "They are not equal!"
  End If

  If num1 > num2 Then
   Label3.Text = "First number is greater!"
  ElseIf num1 < num2 Then
   Label3.Text = "Second number is greater!"
  End If
 End Sub

End Class
