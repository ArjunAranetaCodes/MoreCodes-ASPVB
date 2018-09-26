'Problem 7: Write a program that counts vowels in a String using Regular Expression.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim word As String = "Hello World"
        Dim pattern As String = "[^aeiouAEIOU]"
        Dim count As Integer = Regex.Replace(word, pattern, "").Count
        TextBox1.Text = count
    End Sub

End Class