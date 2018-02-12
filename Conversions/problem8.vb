'Problem 8: Write a program that converts a decimal number to hexadecimal number.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dec As Integer = 256
        Dim hex As String = ""

        Do While dec > 0
            hex = (dec Mod 16).ToString & hex
            dec = Math.Floor(dec / 16)
        Loop

        Label1.Text = hex

    End Sub

End Class