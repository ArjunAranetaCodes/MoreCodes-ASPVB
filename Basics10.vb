'Array Basics

Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
  Handles Me.Load
  Dim array() As Integer = {1, 2, 3}
  Label1.Text = array(0)
  Label2.Text = array(1)
  Label3.Text = array(2)
 End Sub

End Class
