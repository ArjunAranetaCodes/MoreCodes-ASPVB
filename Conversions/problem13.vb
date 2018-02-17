'Problem 13: Write a program that converts celsius to farenheit.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim celsius As Double = 10.0
        Dim farenheit As Double = 0.0
        farenheit = (9.0 / 5.0) * celsius + 32
        Label1.Text = celsius & "C equals to " & farenheit & "F"

    End Sub

End Class