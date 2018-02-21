'Problem 16: Write a program that converts feet to inch.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim feet As Integer = 1
        Dim inch As Integer = feet * 12

        Label1.Text = inch

    End Sub

End Class