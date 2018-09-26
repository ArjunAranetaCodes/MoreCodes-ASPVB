'Problem 6: Write a program that removes white space and non-visible characters.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim word As String = "Hello World"
        Dim pattern As String = "\s"
        TextBox1.Text = Regex.Replace(word, pattern, "")
    End Sub

End Class