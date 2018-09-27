'Problem 20: Write a program that validates if string length is between 5 to 10 using Regular Expression.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim pattern As String = "\w{5,10}\b"
        TextBox1.Text = Regex.IsMatch("Hello World", pattern)
        TextBox2.Text = Regex.IsMatch("Hi", pattern)
    End Sub

End Class