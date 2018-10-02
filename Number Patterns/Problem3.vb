'Problem 3: Write a program to print the number pattern of ones and zeros using loop.
'01010
'01010
'01010
'01010
'01010
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = ""
        For y As Integer = 0 To 4
            For x As Integer = 0 To 4
                If x Mod 2 = 0 Then
                    Label1.Text = Label1.Text & "0"
                Else
                    Label1.Text = Label1.Text & "1"
                End If
            Next
            Label1.Text = Label1.Text & "<br/>"
        Next
    End Sub

End Class