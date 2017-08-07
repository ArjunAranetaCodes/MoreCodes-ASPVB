'Loop Structures

Public Class WebForm1
 Inherits System.Web.UI.Page

 Protected Sub Page_Load(ByVal sender As Object,
  ByVal e As System.EventArgs) Handles Me.Load
  Label1.Text = "For Loop"
  Dim x As Integer = 0
  For x = 0 To 10
   Label2.Text = Label2.Text & x
  Next

  Label3.Text = "While Loop"
  x = 0
  While x <= 10
   Label4.Text = Label4.Text & x
   x += 1
  End While

  Label5.Text = "Do Loop"
  x = 0
  Do
   Label6.Text = Label6.Text & x
   x += 1
  Loop While x <= 10

  Label7.Text = "Do-While Loop"
  x = 0
  Do While x <= 10
   Label8.Text = Label8.Text & x
   x += 1
  Loop

  Label9.Text = "Do-Until Loop"
  x = 0
  Do Until x = 11
   Label10.Text = Label10.Text & x
   x += 1
  Loop

  Label11.Text = "Do-Loop-Until Loop"
  x = 0
  Do
   Label12.Text = Label12.Text & x
   x += 1
  Loop Until x = 11

 End Sub

End Class
