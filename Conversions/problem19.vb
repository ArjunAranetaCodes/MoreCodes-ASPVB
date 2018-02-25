'Problem 19: Write a program that converts numbers to words.
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label1.Text = NumberToWords(1000, "")

    End Sub

    Public Function NumberToWords(ByVal number As Integer, ByVal word As String) As String

        If number >= 1 And number <= 19 Then
            Dim map As Array = {"One", "Two", "Three", "Four", "Five", "Six", "Seven",
            "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
            "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
            word = map(Convert.ToInt32(number - 1))
            Return word

        ElseIf number >= 20 And number <= 99 Then
            Dim map As Array = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy",
            "Eighty", "Ninety"}
            word = map((Convert.ToInt32(number) / 10) - 3)
            Return word & " " & NumberToWords(number Mod 10, "")

        ElseIf (number >= 100 And number <= 999) Then
            Return NumberToWords(Convert.ToInt32(number) / 100, "") + " Hundred " + NumberToWords(number Mod 100, "")

        ElseIf (number >= 1000 And number <= 999999) Then
            Return NumberToWords(Convert.ToInt32(number) / 1000, "") + " Thousand " + NumberToWords(number Mod 1000, "")

        ElseIf (number >= 1000000 And number <= 999999999) Then
            Return NumberToWords(Convert.ToInt32(number) / 1000000, "") + " Million " + NumberToWords(number Mod 1000000, "")

        End If
        Return word

    End Function


End Class