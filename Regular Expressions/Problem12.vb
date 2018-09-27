'Problem 12: Write a program that counts the occurrence of digits in a string using Regular Expression.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim word As String = "Hello12 World12"
        Dim pattern As String = "\D"
        TextBox1.Text = Regex.Replace(word, pattern, "").Count
    End Sub

End Class