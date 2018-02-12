'Problem 7: Write a program that converts a decimal number to binary number.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dec As Integer = 10
        Dim binary As String = ""

        Do While dec > 0
            binary = (dec Mod 2).ToString & binary
            dec = Math.Floor(dec / 2)
        Loop

        Label1.Text = binary

    End Sub

End Class