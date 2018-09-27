'Problem 18: Write a program that extracts string inside quotation marks using Regular Expression.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim word As String = "Hello 'World'"
        Dim pattern As String = "'([^""]*)'"
        Dim extract As String = Regex.Matches(word, pattern).Item(0).ToString
        TextBox1.Text = extract
    End Sub

End Class