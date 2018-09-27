'Problem 15: Write a program that takes a value inside a <div> tag using Regular Expression.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim word As String = "<div>Hello World</div>"
        Dim pattern As String = "<([^""]*""|'[^']*'|[^'"">])*>"
        TextBox1.Text = Regex.Replace(word, pattern, "")
    End Sub

End Class