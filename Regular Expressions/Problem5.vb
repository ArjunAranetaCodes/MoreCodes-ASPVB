'Problem 5: Write a program that matches time in 24 hour format.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim pattern As String = "^(0?[1-9]|1[012])(:[0-5]\d) [APap][mM]$"
        TextBox1.Text = Regex.IsMatch("25:00 am", pattern)
        TextBox2.Text = Regex.IsMatch("08:01 am", pattern)
    End Sub

End Class