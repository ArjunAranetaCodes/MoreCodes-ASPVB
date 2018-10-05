'Problem 19: Write a program to print the number pattern using loop.
'11 11
'11 11

'11 11
'11 11
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = ""
        Dim row As Integer = 4
        Dim col As Integer = 4
        For y As Integer = 0 To row
            For x As Integer = 0 To col
                If Math.Round(col / 2) = x Or Math.Round(row / 2) = y Then
                    Label1.Text = Label1.Text & "&nbsp;&nbsp;"
                ElseIf (col Mod 2 = 0 And Math.Round(col / 2) = x) Or (row Mod 2 = 0 And Math.Round(row / 2) = y) Then
                    Label1.Text = Label1.Text & "&nbsp;&nbsp;"
                Else
                    Label1.Text = Label1.Text & "1"
                End If
            Next
            Label1.Text = Label1.Text & "<br/>"
        Next
    End Sub

End Class