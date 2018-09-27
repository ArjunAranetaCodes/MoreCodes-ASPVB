'Problem 13: Write a program that recognizes valid hex color value using Regular Expression.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim pattern As String = "^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$"
        TextBox1.Text = Regex.IsMatch("#fff", pattern)
        TextBox2.Text = Regex.IsMatch("#asdf", pattern)
    End Sub

End Class