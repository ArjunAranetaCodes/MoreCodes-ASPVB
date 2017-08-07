
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  PrintEven(10)
 End Sub

 Function PrintEven(ByVal num As Integer) As Integer
  If num = 0 Then
   Return num
  Else
   If num Mod 2 = 0 Then
    Label1.Text = Label1.Text & num & "<br/>"
   End If
   Return PrintEven(num - 1)
  End If
 End Function

End Class

