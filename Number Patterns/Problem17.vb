'Problem 17: Write a program to print the number pattern using loop.
'1
'12
'123
'1234
'12345
'1234
'123
'12
'1
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = ""
        Dim row As Integer = 4
        For y As Integer = 0 To row
            For x As Integer = 0 To y
                Label1.Text = Label1.Text & (x + 1).ToString()
            Next
            Label1.Text = Label1.Text & "<br/>"
        Next

        For y As Integer = row - 1 To 0 Step -1
            For x As Integer = 0 To y
                Label1.Text = Label1.Text & (x + 1).ToString()
            Next
            Label1.Text = Label1.Text & "<br/>"
        Next
    End Sub

End Class