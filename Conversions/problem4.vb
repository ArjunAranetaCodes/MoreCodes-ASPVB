'Problem 4: Write a program that converts a string to array/list.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim numbers As String = "1,2,3"
        Dim arrNumbers() As String = numbers.Split(",")

        For Each num In arrNumbers
            Label1.Text = Label1.Text & num
        Next
    End Sub

End Class