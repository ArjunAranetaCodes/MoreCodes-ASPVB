'Problem 1: Write a program to test if the first character of the String is uppercase.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim pattern As String = "^[A-Z][a-z0-9_-]{3,19}$"
        TextBox1.Text = Regex.IsMatch("Hello", pattern)
        TextBox2.Text = Regex.IsMatch("world", pattern)
    End Sub

End Class