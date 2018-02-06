'Problem 5: Write a program that converts an array/list to string.
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
  Dim arrNumbers() As String = {"1", "2", "3"}
  Dim numbers As String = String.Join("", arrNumbers)

  Label1.Text = numbers
 
 End Sub

End Class