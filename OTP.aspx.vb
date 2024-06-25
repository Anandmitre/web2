Imports System.Web
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Collections.Specialized
Partial Class OTP
    Inherits System.Web.UI.Page



    ' Public Function OTP()



    ' Console.WriteLine(result)


    'Return result
    ' End Function

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim apikey = TextBox1.Text
        Dim sender1 = TextBox2.Text
        Dim numbers = TextBox3.Text
        Dim message = TextBox4.Text
        Dim strGet As String
        Dim url As String = "https://api.textlocal.in/send/?"


        strGet = url + "apikey=" + apikey _
        + "&numbers=" + numbers _
        + "&message=" + WebUtility.UrlEncode(message) _
        + "&sender=" + sender1

        Dim webClient As New System.Net.WebClient


        Dim result As String = webClient.DownloadString(strGet)
        'Console.WriteLine(result)
        MsgBox(result)
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
