'Basic Operations

Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object,
  ByVal e As System.EventArgs) Handles Me.Load
  Label1.Text = "1 + 1 = " & (1 + 1)
  Label2.Text = "1 - 1 = " & (1 - 1)
  Label3.Text = "1 * 1 = " & (1 * 1)
  Label4.Text = "1 / 1 = " & (1 / 1)
  Label5.Text = "4 % 2 = " & (4 Mod 2) &
   " - no remainder"
  Label6.Text = "5 % 2 = " & (5 Mod 2) &
   " - remainder 1"
 End Sub

End Class
