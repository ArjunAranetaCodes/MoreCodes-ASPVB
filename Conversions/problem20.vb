'Problem 20: Write a program that converts a number to its 
'corresponding month (e.g. 1 = January).
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim index As Integer = 1
        Dim month = {"January", "February", "March", "April",
         "May", "June", "July", "August",
         "September", "October", "November", "December"}

        Label1.Text = month(index - 1)

    End Sub

End Class