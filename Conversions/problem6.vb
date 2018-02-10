'Problem 6: Write a program that converts a binary number to decimal number.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dec As Integer = 0
        Dim binary As String = "110"
        Dim values() As Integer = {1, 2, 4, 6, 16, 32, 64, 128}

        binary = StrReverse(binary)

        For x As Integer = 0 To binary.Length - 1
            If binary(x) = "1" Then
                dec = dec + values(x)
            End If
        Next

        Label1.Text = Label1.Text & dec
    End Sub

End Class