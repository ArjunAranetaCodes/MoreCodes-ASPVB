'Problem 10: Write a program to print the number pattern using loop.
'12345
'23456
'34567
'45678
'56789
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = ""
        Dim row As Integer = 5
        Dim col As Integer = 5
        Dim min As Integer = 1

        For y As Integer = 0 To row - 1
            Dim num As Integer = min + y
            For x As Integer = 0 To col - 1
                Label1.Text = Label1.Text & num.ToString()
                num = num + 1
            Next
            Label1.Text = Label1.Text & "<br/>"
        Next
    End Sub

End Class