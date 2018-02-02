'Problem 2: Write a program that converts a string to integer.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim num As String = "10"
        Label1.Text = Integer.Parse(num)
    End Sub

End Class