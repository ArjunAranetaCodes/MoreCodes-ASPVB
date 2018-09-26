'Problem 9: Write a program that checks if the string is alphanumeric using Regular Expression.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim pattern As String = "(([A-Z].*[0-9])|([0-9].*[A-Z]))"
        TextBox1.Text = Regex.IsMatch("HelloWorld", pattern)
        TextBox2.Text = Regex.IsMatch("HelloWorld123", pattern)
    End Sub

End Class