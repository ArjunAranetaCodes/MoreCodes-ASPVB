'Problem 19: Write a program that counts all numbers in a string using Regular Expression.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim word As String = "Hello World123"
        Dim pattern As String = "[^0-9]"
        Dim count As Integer = Regex.Replace(word, pattern, "").Count
        TextBox1.Text = count
    End Sub

End Class