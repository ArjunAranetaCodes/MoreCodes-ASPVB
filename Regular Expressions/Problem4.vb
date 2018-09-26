'Problem 4: Write a program that matches time in 12 hour format.
Imports System.Text.RegularExpressions
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim pattern As String = "(((0[1-9])|(1[0-2])):([0-5])([0-9])\s(a|p)m)"
        TextBox1.Text = Regex.IsMatch("08:00 am", pattern)
        TextBox2.Text = Regex.IsMatch("18:00 pm", pattern)
    End Sub

End Class