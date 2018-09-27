'Problem 14: Write a program that recognizes valid hex color value using Regular Expression.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim pattern As String = "^([01]?\d\d?|2[0-4]\d|25[0-5])\.([01]?\d\d?|2[0-4]\d|25[0-5])\." &
                     "([01]?\d\d?|2[0-4]\d|25[0-5])\.([01]?\d\d?|2[0-4]\d|25[0-5])$"
        TextBox1.Text = Regex.IsMatch("192.168.1.1", pattern)
        TextBox2.Text = Regex.IsMatch("1.1.1.1.1", pattern)
    End Sub

End Class