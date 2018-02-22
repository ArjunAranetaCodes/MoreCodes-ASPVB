'Problem 17: Write a program that converts kilometer to meter.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim kilometer As Integer = 1
        Dim meter As Integer = kilometer * 1000

        Label1.Text = meter

    End Sub

End Class