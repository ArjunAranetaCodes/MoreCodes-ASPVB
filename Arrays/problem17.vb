
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object,
  ByVal e As System.EventArgs) Handles Me.Load
  Dim arrNumbers() As Integer = {1, 2, 3}

  For Each num As Integer In arrNumbers
   Label1.Text = Label1.Text & num & "<br/>"
  Next

  Array.Resize(arrNumbers, arrNumbers.Length + 1)

  arrNumbers(3) = 10

  Label1.Text = Label1.Text & "New Array" & "<br/>"
  For Each num As Integer In arrNumbers
   Label1.Text = Label1.Text & num & "<br/>"
  Next

 End Sub

End Class

