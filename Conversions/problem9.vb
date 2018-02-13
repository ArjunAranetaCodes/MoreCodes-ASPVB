'Problem 9: Write a program that converys a hexadecimal number to decimal number.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dec As Integer = 0
        Dim hex As String = "100"

        hex = StrReverse(hex)

        For x As Integer = 0 To hex.Length - 1
            dec = dec + (Integer.Parse(hex(x)) * Math.Pow(16, x))
        Next

        Label1.Text = dec

    End Sub

End Class