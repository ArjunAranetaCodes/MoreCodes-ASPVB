
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Label1.Text = Label1.Text & "Sum is " & GetSum(10, 0) & "<br/>"
 End Sub

 Function GetSum(ByVal num As Integer, ByVal sum As Integer) As Integer
  If num = 0 Then
   Return sum
  Else
   Return GetSum((num - 1), (sum + num))
  End If
 End Function

End Class

