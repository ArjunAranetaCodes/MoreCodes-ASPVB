'Problem 1: Write a program that converts a number to string.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim num As Integer = 10
        Label1.Text = num.ToString()
    End Sub

End Class