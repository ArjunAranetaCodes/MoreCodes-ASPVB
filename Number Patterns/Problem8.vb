'Problem 8: Write a program to print the number pattern of ones and zeros using loop.
'11111
'11111
'11011
'11111
'11111
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = ""
        Dim row As Integer = 5
        Dim col As Integer = 5
        For y As Integer = 0 To row - 1
            For x As Integer = 0 To col - 1
                If x = Math.Round(row / 2) And y = Math.Round(col / 2) Then
                    Label1.Text = Label1.Text & "0"
                Else
                    Label1.Text = Label1.Text & "1"
                End If
            Next
            Label1.Text = Label1.Text & "<br/>"
        Next
    End Sub

End Class