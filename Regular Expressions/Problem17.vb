'Problem 17: Write a program that removes the last word in a string using Regular Expression.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim word As String = "Hello World"
        Dim pattern As String = "\w+$"
        TextBox1.Text = Regex.Replace(word, pattern, "")
    End Sub

End Class