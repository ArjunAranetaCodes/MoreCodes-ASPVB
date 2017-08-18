
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object,
  ByVal e As System.EventArgs) Handles Me.Load
  Dim arrNumbers() As Integer = {1, 2, 3, 4}

  For Each num As Integer In arrNumbers
   If num Mod 2 = 1 Then
    Label1.Text = Label1.Text & num & "<br/>"
   End If
  Next

 End Sub

End Class

