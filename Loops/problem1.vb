
Public Class WebForm1
Inherits System.Web.UI.Page

Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
 Handles Me.Load
 For x As Integer = 1 To 50
  If x Mod 3 = 0 And x Mod 5 = 0 Then
   Label1.Text = Label1.Text & "FizzBuzz" & "<br/>"
  ElseIf x Mod 3 = 0 Then
   Label1.Text = Label1.Text & "Fizz" & "<br/>"
  ElseIf x Mod 5 = 0 Then
   Label1.Text = Label1.Text & "Buzz" & "<br/>"
  Else
   Label1.Text = Label1.Text & x & "<br/>"
 End If
 Next
End Sub

End Class

