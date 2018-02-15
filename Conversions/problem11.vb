'Problem 11: Write a program that converts numbers of day to minutes.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim day As Integer = 1
        Dim minute As Integer = day * 24 * 60

        Label1.Text = minute

    End Sub

End Class