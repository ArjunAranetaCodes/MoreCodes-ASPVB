'Problem 10: Write a program that converts a decimal number to octal number.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dec As Integer = 256
        Dim oct As String = ""

        Do While dec > 0
            oct = (dec Mod 8).ToString & oct
            dec = Math.Floor(dec / 8)
        Loop

        Label1.Text = oct

    End Sub

End Class