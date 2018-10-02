'Problem 4: Write a program to print the number pattern of ones and zeros using loop.
'10001
'10001
'10001
'10001
'10001
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = ""
        For y As Integer = 0 To 4
            For x As Integer = 0 To 4
                If (x = 0) Or (x = 4) Then
                    Label1.Text = Label1.Text & "1"
                Else
                    Label1.Text = Label1.Text & "0"
                End If
            Next
            Label1.Text = Label1.Text & "<br/>"
        Next
    End Sub

End Class