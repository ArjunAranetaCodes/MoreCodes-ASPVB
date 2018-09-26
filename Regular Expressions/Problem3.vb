'Problem 3: Write a program that checks if string contains sample format date of (yyyy-mm-dd)
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim pattern As String = "([0-9]{4})-([0-9]{2})-([0-9]{2})"
        TextBox1.Text = Regex.IsMatch("2018-01-02", pattern)
        TextBox2.Text = Regex.IsMatch("01-01-02", pattern)
    End Sub

End Class