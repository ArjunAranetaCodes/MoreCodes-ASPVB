'Problem 14: Write a program to print the number pattern using loop.
'1
'22
'333
'4444
'55555
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = ""
        Dim row As Integer = 5
        For y As Integer = 0 To row
            For x As Integer = 1 To y
                Label1.Text = Label1.Text & y.ToString()
            Next
            Label1.Text = Label1.Text & "<br/>"
        Next
    End Sub

End Class