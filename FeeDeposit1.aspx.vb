Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web.Configuration
Imports System
Imports System.Data
Partial Class FeeDeposit1
    Inherits System.Web.UI.Page
    Dim conn As SqlConnection
    Dim com As SqlCommand
    Dim rd As SqlDataReader

    Shared WithEvents mybutton As New Button()
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        conn = New SqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        conn.Open()
        'Dim query As String
        'query = "select table_value from FeeDetails1_2022 add column new1 int after Section"
        'com = New SqlCommand(query, conn)
        'rd = com.ExecuteReader


        'rd.Read()


        conn.Close()



        ' Label56.Text = "Connection Status"
        If Label56.Text = "ONLINE- Time Updated" Then
            Label56.Text = "Click for Connection Status"   ' on each post back but not on page load as page load contains time function button
        End If


        'Button2_Click(sender, e)


        Label55.Text = Date.Now.ToString("dd/MM/yyyy  hh:mm:ss tt ddd")





        If (IsPostBack = False) Then

            Label27.Text = Session("Account1")

            Button2_Click(sender, e)  'in the start-to get internet connection status and update online time  
            ' and on each refresh or page load
            Dim i1, i2, i3 As Integer
            i1 = Left(Label55.Text.Trim, 2)
            i2 = Mid(Label55.Text.Trim, 4, 2)
            i3 = Mid(Label55.Text.Trim, 7, 4)

            ' instalment due date
            If (i1 >= 1 And (i2 = 5 Or i2 = 6)) Or (i1 <= 15 And i2 = 7) Then
                Label54.Text = "15/07/" & i3
            ElseIf (i1 >= 16 And i2 = 7) Or (i1 >= 1 And (i2 = 9 Or i2 = 8)) Then
                Label54.Text = "30/09/" & i3
            ElseIf (i1 >= 1 And (i2 = 11 Or i2 = 10)) Or (i1 <= 15 And i2 = 12) Then
                Label54.Text = "15/12/" & i3
            ElseIf (i1 >= 16 And i2 = 12) Or (i1 >= 1 And (i2 >= 1 And i2 <= 4)) Then
                Label54.Text = "28/02/" & i3
            End If

            CList1.Items.Add("No Discount")
            CList1.Items.Add("RTE")
            CList1.Items.Add("Minority")

            Label51.Text = Session("1receiptno")
            Label5.Text = Session("1rollno")
            Label1.Text = Session("1name") + " " + Session("1surname")

            Label32.Text = Session("1gender")
            Label2.Text = Session("1class")
            Label3.Text = Session("1section")
            Label6.Text = Session("1Fphone")
            Label4.Text = Session("1admsnNo")
            Label8.Text = Session("1Nmother")
            Label7.Text = Session("1Nfather")
            Label9.Text = Session("1Laddress") + " " + Session("1town")
            Label28.Text = Session("cursession")


            Label41.Text = Session("1tuition")
            Label39.Text = Session("1admsnf")
            Label12.Text = Session("1trnspt")
            Label13.Text = Session("1other")
            Label36.Text = Session("1total")

            Label15.Text = Session("1tuitiond")
            Label40.Text = Session("1admsnd")
            Label17.Text = Session("1trnsptd")
            Label18.Text = Session("1otherd")
            Label44.Text = Session("1totalfd")
            Label57.Text = Session("1Tdiscount")
            Label66.Text = Session("1TValue")
            'Label26.Text = Session("1NetBal")

            If Session("1tuitiond") = 0 Then
                Label15.Text = Session("1tuition")
            End If
            If Session("1admsnd") = 0 Then
                Label40.Text = Session("1admsnf")
            End If
            If Session("1trnsptd") = 0 Then
                Label17.Text = Session("1trnspt")
            End If
            If Session("1otherd") = 0 Then
                Label18.Text = Session("1other")
            End If
            If Session("1totalfd") = 0 Then
                Label44.Text = Session("1total")
            End If
            ' If Session("1totald") = 0 Then
            'Label44.Text = Val(Label15.Text) + Val(Label40.Text) + Val(Label17.Text) + Val(Label18.Text)
            ' End If

            TextBox15.Text = Session("1oChargeD")
            Label45.Text = Session("1PreviousSdue")

            Label42.Text = Val(Label44.Text) + Val(Label45.Text) + Val(TextBox15.Text)


            Label47.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox5.Text)

            'Label23.Text = Val(Label44.Text) - Val(label47.Text)

            TextBox19.Text = Val(TextBox17.Text) + Val(TextBox7.Text) + Val(Label47.Text)





            Label46.Text = Val(Label15.Text) - Val(TextBox1.Text)
            Label20.Text = Val(Label40.Text) - Val(TextBox2.Text)
            Label21.Text = Val(Label17.Text) - Val(TextBox5.Text)
            Label22.Text = Val(Label18.Text) - Val(TextBox3.Text)
            Label23.Text = Val(Label44.Text) - Val(Label47.Text)

            Label24.Text = Val(Label45.Text) - Val(TextBox17.Text)
            Label38.Text = Val(TextBox15.Text) - Val(TextBox7.Text)
            Label43.Text = Val(Label42.Text) - Val(TextBox19.Text)

            Label26.Text = Val(Label43.Text) - Val(TextBox12.Text) - Val(Label57.Text)


            Label62.Text = "Fee Installment (Rs." & Val(Label36.Text) / 4 & ") Due"


            'Dim dd2, dd1 As Date
            'dd2 = Label54.Text
            ' dd1 = Label55.Text
            If Val(Label23.Text) >= 3 * Val(Label36.Text) / 4 Then
                Label58.Text = Val(Label36.Text) / 4 - Val(Label36.Text) + Val(Label23.Text)
            Else
                Label58.Text = 0
            End If

            If (Val(Label23.Text) >= Val(Label36.Text) / 2) And (Val(Label23.Text) < 3 * Val(Label36.Text) / 4) Then
                Label63.Text = Val(Label36.Text) / 4 - (3 * Val(Label36.Text) / 4) + Val(Label23.Text)
            ElseIf Val(Label23.Text) < Val(Label36.Text) / 2 Then
                Label63.Text = 0
            Else
                Label63.Text = Val(Label36.Text) / 4
            End If

            If (Val(Label23.Text) >= Val(Label36.Text) / 4) And (Val(Label23.Text) < Val(Label36.Text) / 2) Then
                Label64.Text = Val(Label36.Text) / 4 - (Val(Label36.Text) / 2) + Val(Label23.Text)
            ElseIf Val(Label23.Text) < Val(Label36.Text) / 4 Then
                Label64.Text = 0
            Else
                Label64.Text = Val(Label36.Text) / 4
            End If

            If (Val(Label23.Text) >= 0) And (Val(Label23.Text) < Val(Label36.Text) / 4) Then
                Label65.Text = Val(Label23.Text)
            ElseIf Val(Label23.Text) < Val(Label36.Text) / 4 Then
                Label65.Text = 0
            Else
                Label65.Text = Val(Label36.Text) / 4
            End If



        End If



    End Sub
    Protected Sub CList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CList1.SelectedIndexChanged
        If CList1.SelectedIndex = 0 Then
            TextBox12.Text = 0
        ElseIf CList1.SelectedIndex = 1 Then
            TextBox12.Text = 5000
        Else
            TextBox12.Text = 2000
        End If

        Label26.Text = Val(Label43.Text) - Val(TextBox12.Text) - Val(Label57.Text)

    End Sub
    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Label20.Text = Val(Label40.Text) - Val(TextBox2.Text)
        Label47.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox5.Text)
        Label23.Text = Val(Label44.Text) - Val(Label47.Text)
        TextBox19.Text = Val(TextBox17.Text) + Val(TextBox7.Text) + Val(Label47.Text)
        Label43.Text = Val(Label42.Text) - Val(TextBox19.Text)
        Label26.Text = Val(Label43.Text) - Val(TextBox12.Text) - Val(Label57.Text)
        'Label56.Text = "Connection Status"
    End Sub
    Protected Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Label22.Text = Val(Label18.Text) - Val(TextBox3.Text)
        Label47.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox5.Text)
        Label23.Text = Val(Label44.Text) - Val(Label47.Text)
        TextBox19.Text = Val(TextBox17.Text) + Val(TextBox7.Text) + Val(Label47.Text)
        Label43.Text = Val(Label42.Text) - Val(TextBox19.Text)
        Label26.Text = Val(Label43.Text) - Val(TextBox12.Text) - Val(Label57.Text)
        ' Label56.Text = "Connection Status"
    End Sub
    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label46.Text = Val(Label15.Text) - Val(TextBox1.Text)
        Label47.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox5.Text)
        Label23.Text = Val(Label44.Text) - Val(Label47.Text)
        TextBox19.Text = Val(TextBox17.Text) + Val(TextBox7.Text) + Val(Label47.Text)
        Label43.Text = Val(Label42.Text) - Val(TextBox19.Text)
        Label26.Text = Val(Label43.Text) - Val(TextBox12.Text) - Val(Label57.Text)

        ' Label56.Text = "Connection Status"

    End Sub

    Protected Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Label21.Text = Val(Label17.Text) - Val(TextBox5.Text)
        Label47.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox5.Text)
        Label23.Text = Val(Label44.Text) - Val(Label47.Text)
        TextBox19.Text = Val(TextBox17.Text) + Val(TextBox7.Text) + Val(Label47.Text)
        Label43.Text = Val(Label42.Text) - Val(TextBox19.Text)
        Label26.Text = Val(Label43.Text) - Val(TextBox12.Text) - Val(Label57.Text)
        ' Label56.Text = "Connection Status"
    End Sub

    Protected Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        Label24.Text = Val(Label45.Text) - Val(TextBox17.Text)
        TextBox19.Text = Val(TextBox17.Text) + Val(TextBox7.Text) + Val(Label47.Text)
        Label43.Text = Val(Label42.Text) - Val(TextBox19.Text)
        Label26.Text = Val(Label43.Text) - Val(TextBox12.Text) - Val(Label57.Text)
        ' Label56.Text = "Connection Status"
    End Sub
    Protected Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Label38.Text = Val(TextBox15.Text) - Val(TextBox7.Text)
        TextBox19.Text = Val(TextBox17.Text) + Val(TextBox7.Text) + Val(Label47.Text)
        Label43.Text = Val(Label42.Text) - Val(TextBox19.Text)
        Label26.Text = Val(Label43.Text) - Val(TextBox12.Text) - Val(Label57.Text)
        ' Label56.Text = "Connection Status"
    End Sub

    Protected Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        Label42.Text = Val(Label44.Text) + Val(Label45.Text) + Val(TextBox15.Text)
        Label38.Text = Val(TextBox15.Text) - Val(TextBox7.Text)
        Label43.Text = Val(Label42.Text) - Val(TextBox19.Text)
        Label26.Text = Val(Label43.Text) - Val(TextBox12.Text) - Val(Label57.Text)
        'Label56.Text = "Connection Status"
    End Sub
    Protected Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        Label26.Text = Val(Label43.Text) - Val(TextBox12.Text) - Val(Label57.Text)
        ' Label56.Text = "Connection Status"

    End Sub
    ' Protected Sub label57_TextChanged(sender As Object, e As EventArgs) Handles label57.TextChanged
    ' Label26.Text = Val(Label43.Text) - Val(TextBox12.Text) - Val(label57.Text)
    ' Label56.Text = "Connection Status"
    ' End Sub

    Protected Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox5.Text = 0
        TextBox17.Text = 0
        TextBox7.Text = 0
        TextBox12.Text = 0
        ' Label56.Text = "Connection Status"
        If Val(Label45.Text) >= Val(TextBox19.Text) Then
            TextBox17.Text = Val(TextBox19.Text)
        ElseIf Val(Label45.Text) + Val(Label40.Text) >= Val(TextBox19.Text) Then
            TextBox17.Text = Val(Label45.Text)
            TextBox2.Text = Val(TextBox19.Text) - Val(Label45.Text)
        ElseIf Val(Label45.Text) + Val(Label15.Text) + Val(Label40.Text) >= Val(TextBox19.Text) Then
            TextBox17.Text = Val(Label45.Text)
            TextBox2.Text = Val(Label40.Text)
            TextBox1.Text = Val(TextBox19.Text) - Val(Label40.Text) - Val(Label45.Text)
        ElseIf Val(Label45.Text) + Val(Label18.Text) + Val(Label15.Text) + Val(Label40.Text) >= Val(TextBox19.Text) Then
            TextBox17.Text = Val(Label45.Text)
            TextBox2.Text = Val(Label40.Text)
            TextBox1.Text = Val(Label15.Text)
            TextBox3.Text = Val(TextBox19.Text) - Val(Label40.Text) - Val(Label15.Text) - Val(Label45.Text)
        ElseIf Val(Label45.Text) + Val(Label17.Text) + Val(Label18.Text) + Val(Label15.Text) + Val(Label40.Text) >= Val(TextBox19.Text) Then
            TextBox17.Text = Val(Label45.Text)
            TextBox2.Text = Val(Label40.Text)
            TextBox1.Text = Val(Label15.Text)
            TextBox3.Text = Val(Label18.Text)
            TextBox5.Text = Val(TextBox19.Text) - Val(Label40.Text) - Val(Label15.Text) - Val(Label18.Text) - Val(Label45.Text)
        ElseIf Val(TextBox15.Text) + Val(Label45.Text) + Val(Label17.Text) + Val(Label18.Text) + Val(Label15.Text) + Val(Label40.Text) >= Val(TextBox19.Text) Then
            TextBox17.Text = Val(Label45.Text)
            TextBox2.Text = Val(Label40.Text)
            TextBox1.Text = Val(Label15.Text)
            TextBox3.Text = Val(Label18.Text)
            TextBox5.Text = Val(Label17.Text)
            TextBox7.Text = Val(TextBox19.Text) - Val(Label40.Text) - Val(Label15.Text) - Val(Label18.Text) - Val(Label45.Text) - Val(Label17.Text)
        ElseIf Val(TextBox15.Text) + Val(Label45.Text) + Val(Label17.Text) + Val(Label18.Text) + Val(Label15.Text) + Val(Label40.Text) < Val(TextBox19.Text) Then
            TextBox17.Text = Val(Label45.Text)
            TextBox2.Text = Val(Label40.Text)
            TextBox1.Text = Val(Label15.Text)
            TextBox3.Text = Val(Label18.Text)
            TextBox5.Text = Val(Label17.Text)
            TextBox7.Text = Val(TextBox15.Text)
        End If

        Label47.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + +Val(TextBox5.Text)
        Label46.Text = Val(Label15.Text) - Val(TextBox1.Text)
        Label20.Text = Val(Label40.Text) - Val(TextBox2.Text)
        Label21.Text = Val(Label17.Text) - Val(TextBox5.Text)
        Label22.Text = Val(Label18.Text) - Val(TextBox3.Text)
        Label23.Text = Val(Label44.Text) - Val(Label47.Text)

        Label24.Text = Val(Label45.Text) - Val(TextBox17.Text)
        Label38.Text = Val(TextBox15.Text) - Val(TextBox7.Text)
        Label43.Text = Val(Label42.Text) - Val(TextBox19.Text)

        Label26.Text = Val(Label43.Text) - Val(TextBox12.Text) - Val(Label57.Text)







    End Sub
    Private Sub fun22()  ' not using this fun right now
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox5.Text = 0
        TextBox17.Text = 0
        TextBox7.Text = 0
        TextBox12.Text = 0

        If Val(Label45.Text) >= Val(TextBox19.Text) Then
            TextBox17.Text = Val(TextBox19.Text)
        ElseIf Val(Label45.Text) + Val(Label40.Text) >= Val(TextBox19.Text) Then
            TextBox17.Text = Val(Label45.Text)
            TextBox2.Text = Val(TextBox19.Text) - Val(Label45.Text)
        ElseIf Val(Label45.Text) + Val(Label15.Text) + Val(Label40.Text) >= Val(TextBox19.Text) Then
            TextBox17.Text = Val(Label45.Text)
            TextBox2.Text = Val(Label40.Text)
            TextBox1.Text = Val(TextBox19.Text) - Val(Label40.Text) - Val(Label45.Text)
        ElseIf Val(Label45.Text) + Val(Label18.Text) + Val(Label15.Text) + Val(Label40.Text) >= Val(TextBox19.Text) Then
            TextBox17.Text = Val(Label45.Text)
            TextBox2.Text = Val(Label40.Text)
            TextBox1.Text = Val(Label15.Text)
            TextBox3.Text = Val(TextBox19.Text) - Val(Label40.Text) - Val(Label15.Text) - Val(Label45.Text)
        ElseIf Val(Label45.Text) + Val(Label17.Text) + Val(Label18.Text) + Val(Label15.Text) + Val(Label40.Text) >= Val(TextBox19.Text) Then
            TextBox17.Text = Val(Label45.Text)
            TextBox2.Text = Val(Label40.Text)
            TextBox1.Text = Val(Label15.Text)
            TextBox3.Text = Val(Label18.Text)
            TextBox5.Text = Val(TextBox19.Text) - Val(Label40.Text) - Val(Label15.Text) - Val(Label18.Text) - Val(Label45.Text)
        ElseIf Val(TextBox15.Text) + Val(Label45.Text) + Val(Label17.Text) + Val(Label18.Text) + Val(Label15.Text) + Val(Label40.Text) >= Val(TextBox19.Text) Then
            TextBox17.Text = Val(Label45.Text)
            TextBox2.Text = Val(Label40.Text)
            TextBox1.Text = Val(Label15.Text)
            TextBox3.Text = Val(Label18.Text)
            TextBox5.Text = Val(Label17.Text)
            TextBox7.Text = Val(TextBox19.Text) - Val(Label40.Text) - Val(Label15.Text) - Val(Label18.Text) - Val(Label45.Text) - Val(Label17.Text)
        ElseIf Val(TextBox15.Text) + Val(Label45.Text) + Val(Label17.Text) + Val(Label18.Text) + Val(Label15.Text) + Val(Label40.Text) < Val(TextBox19.Text) Then
            TextBox17.Text = Val(Label45.Text)
            TextBox2.Text = Val(Label40.Text)
            TextBox1.Text = Val(Label15.Text)
            TextBox3.Text = Val(Label18.Text)
            TextBox5.Text = Val(Label17.Text)
            TextBox7.Text = Val(TextBox15.Text)
        End If

        Label47.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) + +Val(TextBox5.Text)
        Label46.Text = Val(Label15.Text) - Val(TextBox1.Text)
        Label20.Text = Val(Label40.Text) - Val(TextBox2.Text)
        Label21.Text = Val(Label17.Text) - Val(TextBox5.Text)
        Label22.Text = Val(Label18.Text) - Val(TextBox3.Text)
        Label23.Text = Val(Label44.Text) - Val(Label47.Text)

        Label24.Text = Val(Label45.Text) - Val(TextBox17.Text)
        Label38.Text = Val(TextBox15.Text) - Val(TextBox7.Text)
        Label43.Text = Val(Label42.Text) - Val(TextBox19.Text)

        Label26.Text = Val(Label43.Text) - Val(TextBox12.Text) - Val(Label57.Text)


    End Sub
    'Protected Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged

    ' End Sub

    Public Shared Function GetDateTime() As DateTime
        Try
            Dim dateTime As DateTime = DateTime.MinValue
            Dim request As System.Net.HttpWebRequest = DirectCast(System.Net.WebRequest.Create("http://www.youtube.com/"), System.Net.HttpWebRequest)
            request.Timeout = 25000
            request.Method = "GET"
            request.Accept = "text/html, application/xhtml+xml, /"
            request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/6.0)"
            request.ContentType = "application/x-www-form-urlencoded"
            request.CachePolicy = New System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore)
            Dim response As System.Net.HttpWebResponse = DirectCast(request.GetResponse(), System.Net.HttpWebResponse)
            If response.StatusCode = System.Net.HttpStatusCode.OK Then
                Dim todaysDates As String = response.Headers("date")
                dateTime = DateTime.ParseExact(todaysDates, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat, System.Globalization.DateTimeStyles.AssumeUniversal)
            End If
            mybutton.Text = "ONLINE- Time Updated"     ' shared button, in the beginning
            Return dateTime
        Catch
            ' Dim p as String 
            'FeeDeposit1 instance = New FeeDeposit1()
            'Dim button2 As Button = DirectCast(button2)
            'FeeDeposit1.button = Button2.button
            mybutton.Text = "OFFLINE"
            Return Date.Now.ToString("dd-MM-yyyy hh:mm:ss tt")
            'instance.p = "OFFLINE"
            'Response.Write("<script> alert (instance.p); window.location.href = 'Default.aspx'</script>")
            'Return Nothing
        End Try



    End Function
    ' Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    'Label56.Text = Date.Now.ToString("dd/MM/yyyy  hh:mm:ss tt")

    'Dim dt31 As String
    ' Dim dt3 As DateTime
    ' dt3 = GetDateTime()
    ' dt31 = dt3.ToString("dd MMM yyyy  hh : mm : ss tt  ")
    'Label56.Text = dt31
    ' End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Button2.Text = mybutton.Text
        Dim datetime1 As String = GetDateTime().ToString
        Dim y As Integer = Mid(datetime1, 7, 4)
        Dim m As Integer = Mid(datetime1, 4, 2)
        Dim d As Integer = Left(datetime1, 2)
        Dim d1 As DateTime = Mid(datetime1, 12, 11)
        'Dim y As Integer = Mid(GetDateTime(), 7, 4)
        'Dim m As Integer = Mid(GetDateTime(), 4, 2)
        'Dim d As Integer = Left(GetDateTime(), 2)
        ' Dim d1 As DateTime = Mid(GetDateTime(), 12, 11)

        'Dim d1 As
        'Microsoft.VisualBasic.TimeOfDay = d1 'Your time...
        ' Microsoft.VisualBasic.DateString = New Date(y, m, d) 'The date...


        ' Dim d1 As DateTime
        ' d1 = "22:30:00"



        TimeOfDay = d1
        Today = New Date(y, m, d)
        'Button2.Text = "Time Updated"
        Label55.Text = Date.Now.ToString("dd/MM/yyyy hh:mm:ss tt ddd")
        Label56.Text = mybutton.Text

        Dim i1, i2, i3 As Integer
        i1 = Left(Label55.Text.Trim, 2)
        i2 = Mid(Label55.Text.Trim, 4, 2)
        i3 = Mid(Label55.Text.Trim, 7, 4)

        ' instalment due date
        If i1 <= 15 And (i2 >= 5 And i2 <= 7) Then
            Label54.Text = "15/07/" & i3
        ElseIf (i1 >= 16 And i2 = 7) Or (i1 >= 1 And (i2 = 9 Or i2 = 8)) Then
            Label54.Text = "30/09/" & i3
        ElseIf (i1 >= 1 And (i2 = 11 Or i2 = 10)) Or (i1 <= 15 And i2 = 12) Then
            Label54.Text = "15/12/" & i3
        ElseIf (i1 >= 16 And i2 = 12) Or (i1 >= 1 And (i2 >= 1 And i2 <= 4)) Then
            Label54.Text = "28/02/" & i3
        End If
    End Sub


    Protected Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged

    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim dd2, dd1 As Date
        'dd2 = Label54.Text
        ' dd1 = Label55.Text
        If Val(Label23.Text) >= 3 * Val(Label36.Text) / 4 Then
            Label58.Text = Val(Label36.Text) / 4 - Val(Label36.Text) + Val(Label23.Text)
        Else
            Label58.Text = 0
        End If

        If (Val(Label23.Text) >= Val(Label36.Text) / 2) And (Val(Label23.Text) < 3 * Val(Label36.Text) / 4) Then
            Label63.Text = Val(Label36.Text) / 4 - (3 * Val(Label36.Text) / 4) + Val(Label23.Text)
        ElseIf Val(Label23.Text) < Val(Label36.Text) / 2 Then
            Label63.Text = 0
        Else
            Label63.Text = Val(Label36.Text) / 4
        End If

        If (Val(Label23.Text) >= Val(Label36.Text) / 4) And (Val(Label23.Text) < Val(Label36.Text) / 2) Then
            Label64.Text = Val(Label36.Text) / 4 - (Val(Label36.Text) / 2) + Val(Label23.Text)
        ElseIf Val(Label23.Text) < Val(Label36.Text) / 4 Then
            Label64.Text = 0
        Else
            Label64.Text = Val(Label36.Text) / 4
        End If

        If (Val(Label23.Text) >= 0) And (Val(Label23.Text) < Val(Label36.Text) / 4) Then
            Label65.Text = Val(Label23.Text)
        ElseIf Val(Label23.Text) < Val(Label36.Text) / 4 Then
            Label65.Text = 0
        Else
            Label65.Text = Val(Label36.Text) / 4
        End If


        conn = New SqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        conn.Open()
        Dim query As String
        query = "select col_length('FeeDetails1_2022', 'Tuition_Fee_Due1'); alter table FeeDetails1_2022 add Tuition_Fee_Due1 bigint, Admission_Fee_Due1 bigint, Transport_Fee_Due1 bigint, Other_Fee_Due1, Total_Due_Fee1, Previous_Sessions_Due1, Other_Charges_Due1, Total_Due_Amount1,"
        com = New SqlCommand(query, conn)
        'com.ExecuteNonQuery()
        rd = com.ExecuteReader
        'rd.Read()
        If rd.Read() = 0 Then
            com.ExecuteNonQuery()

            'rd.Read()

            'rd.Read()
        End If

        conn.Close()





        conn.Dispose()
    End Sub
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conn = New SqlConnection
        Dim com As New SqlCommand

        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString

        conn.Open()
        Dim query As String

        query = "select * from Admin1 where Password='" & TextBox23.Text & "'"
        com = New SqlCommand(query, conn)
        rd = com.ExecuteReader
        Dim count As Integer
        count = 0
        While rd.Read
            count = count + 1

        End While
        conn.Close()

        If count = 1 And Val(TextBox19.Text) > 0 Then
            Session("TValue") = Convert.ToInt32(Session("1TValue")) + 1
            Session("NewFeeTable1") = "FeeDetails" & Session("TValue") & Session("cursession")

            ' Dim query As String
            conn = New SqlConnection
            conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
            conn.Open()
            query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES where TABLE_NAME= '" & Session("NewFeeTable1") & "'"
            com = New SqlCommand(query, conn)
            rd = com.ExecuteReader

            While rd.Read

                Session("NewFeeTable1") = ""   ' to stop creating a duplicate fee daetails table 
                'after creating one for a student.
            End While

            conn.Close()


            If Session("NewFeeTable1") <> "" Then
                ' Dim com As New SqlCommand
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim tp21 As SqlParameter = New SqlParameter("@p8", SqlDbType.NVarChar)
                tp21.Value = Session("NewFeeTable1")
                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg
                ' Dim com As New SqlCommand
                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "NewFeeTable1"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.Add(tp21)
                ' com.Parameters.Add(sp11)
                com.ExecuteNonQuery()
                ' Session("FeeDetails22") = Session("FeeDetails1")

                Session("NewFeeTable1") = ""
                com.Parameters.Clear()
                conn.Close()
            End If
            ' Dim query As String
            'conn.Open()
            ' Dim query As String
            ' query = "select Table_Value from FeeDetails1_2022 where Admsn_Number="
            ' com = New SqlCommand(query, conn)
            ' rd = com.ExecuteReader


            'rd.Read()
            'Label53.Text = "Approved"

            'conn.Close()
            ' Dim query As String
            conn.Open()
            ' Dim query As String
            Query = "update FeeDetails1_2022 set Tuition_Fee_Due1= '" & Val(Label46.Text) & "', Admission_Fee_Due1= '" & Val(Label20.Text) & "', Transport_Fee_Due1= '" & Val(Label21.Text) & "' where Admsn_Number= '" & Val(Label4.Text) & "'"
            com = New SqlCommand(Query, conn)
            rd = com.ExecuteReader


            rd.Read()
            Label53.Text = "Approved"

            conn.Close()


            conn.Dispose()
        End If
    End Sub
    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class
