'Problem 14: Write a program that converts lower case to upper case characters.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim str As String = "abc"
        str = str.ToUpper()

        Label1.Text = str

    End Sub

End Class