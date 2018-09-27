'Problem 16: Write a program that takes a value inside a <a> tag using Regular Expression.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim word As String = "<a>Hello World</a>"
        Dim pattern As String = "<([^""]*""|'[^']*'|[^'"">])*>"
        TextBox1.Text = Regex.Replace(word, pattern, "")
    End Sub

End Class