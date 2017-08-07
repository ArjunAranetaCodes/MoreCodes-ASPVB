'Basics of Functions

Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
  function1()
  function2(5)
  Label3.Text = function3()
  Label4.Text = function4("More", "Codes")
 End Sub

 'a sub in vbnet does not have a return value
 Sub function1()
  Label1.Text = "Hello there!"
 End Sub

 'a sub in vbnet does not have a return value but can a have a passing argument/parameter
 Sub function2(ByVal num As Integer)
  Label2.Text = "That number is " & num
 End Sub

 'function that has return value but has no passing argument/parameter
 Function function3() As Integer
  Dim sum As Integer = 1 + 1
  Return sum
 End Function

 'function that has return value and has passing argument/parameter
 Function function4(ByVal firstName As String, ByVal lastName As String) As String
  Dim fullName As String = firstName & " " & lastName
  Return fullName
 End Function

End Class
