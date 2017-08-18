
Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object,
  ByVal e As System.EventArgs) Handles Me.Load
  Dim arrNumbers() As Integer = {4, 2, 3, -1}
  Dim closest As Integer = 0
  Dim numDiff As Integer = arrNumbers.Max

  For Each num As Integer In arrNumbers
   Dim diff = 0 - num
   diff = Math.Abs(diff)
   If diff < numDiff Then
    numDiff = diff
    closest = num
   End If
  Next

  Label1.Text = "Closest to zero is " & closest

 End Sub

End Class

