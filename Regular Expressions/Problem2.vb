'Problem 2: Write a program that matches email address.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim pattern As String = "^[_A-Za-z0-9-\+]+(\.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(\.[A-Za-z0-9]+)*(\.[A-Za-z]{2,})$"
        TextBox1.Text = Regex.IsMatch("mark@yahoo.com", pattern)
        TextBox2.Text = Regex.IsMatch("mark-yahoo.com", pattern)
    End Sub

End Class