'Problem 18: Write a program that converts liter to milliliter.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim liter As Integer = 1
        Dim milliliter As Integer = liter * 1000

        Label1.Text = milliliter

    End Sub

End Class