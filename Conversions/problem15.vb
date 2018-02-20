'Problem 15: Write a program that converts letters to ASCII.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim letter As String = "x"
        Dim ascii As Integer = Asc(letter)

        Label1.Text = ascii

    End Sub

End Classs