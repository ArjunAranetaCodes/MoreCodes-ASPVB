'Problem 11: Write a program that counts the occurrence of a string in a string using Regular Expression.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim word As String = "HelloWorldHelloWorld"
        Dim pattern As String = "Hello"
        Dim count As Integer = Regex.Matches(word, pattern).Count
        TextBox1.Text = count
    End Sub

End Class