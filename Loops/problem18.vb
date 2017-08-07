
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  For x = 0 To 11
   Label1.Text = Label1.Text & Fibonacci(x) & "<br/>"
  Next
 End Sub

 Function Fibonacci(ByVal num As Integer) As Integer
  If num = 1 Or num = 0 Then
   Return num
  Else
   Return Fibonacci(num - 1) + Fibonacci(num - 2)
  End If
 End Function
End Class

