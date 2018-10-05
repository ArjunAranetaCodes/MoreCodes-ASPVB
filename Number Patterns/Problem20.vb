'Problem 20: Write a program to print the number pattern using loop.
'  1
' 222
'33333
' 444
'  5
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = ""
        Dim rows As Integer = 3
        Dim stars As Integer = 1
        Dim blank As Integer = rows - 1

        For y As Integer = 1 To rows * 2
            For x As Integer = 1 To blank
                Label1.Text = Label1.Text & "&nbsp;&nbsp;"
            Next

            For x As Integer = 1 To (stars * 2) - 1
                Label1.Text = Label1.Text & y.ToString()
            Next

            Label1.Text = Label1.Text & "<br/>"

            If y < rows Then
                blank = blank - 1
                stars = stars + 1
            Else
                blank = blank + 1
                stars = stars - 1
            End If
        Next
    End Sub

End Class