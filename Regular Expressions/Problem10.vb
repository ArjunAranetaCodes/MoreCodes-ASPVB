'Problem 10: Write a program that prints an integer with commas separator using Regular Expression.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim word As String = "1000"
        Dim pattern As String = "(\d)(?=(\d{3})+$)"
        TextBox1.Text = Regex.Replace(word, pattern, "$1,")
    End Sub

End Class