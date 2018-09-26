'Problem 8: Write a program that checks if the String if valid url using Regular Expression.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim pattern As String = "^(https?:\/\/)?(www\.)?([\w]+\.)+[‌​\w]{2,63}\/?$"
        TextBox1.Text = Regex.IsMatch("http://www.example.com", pattern)
        TextBox2.Text = Regex.IsMatch("wwwexamplecom", pattern)
    End Sub

End Class