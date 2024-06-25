Imports System.Data.SqlClient
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim conn As SqlConnection

    Dim com As SqlCommand
    Dim rd As SqlDataReader


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' If e.keycode = 13 Then


        conn = New SqlConnection

        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString

        'Try

        conn.Open()
            Dim query As String
            query = "Select * from Admin1 where Administrators='" & TextBox1.Text & "' and  Password= '" & TextBox2.Text & "' "
            com = New SqlCommand(query, conn)
            rd = com.ExecuteReader

            REM Response.Redirect("Default.aspx")
            REM Response.Write("registered")

            Dim Count As Integer
            Count = 0
            While rd.Read
                Count = Count + 1
            End While

        If Count = 1 Then
            Session("Account1") = TextBox1.Text.Trim()
            Session("user") = "1"                            REM to discontinue if browser closed
            Session("forward1") = "1"
            REM   Application("app6") = "1"     REM login started  ....... to continue even after browser closed
            'TextBox1.Text = ""
            'Page.ClientScript.RegisterStartupScript(Me.GetType(), "ClearHistory", "Clearhistory()", True)
            'Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1D))
            'Response.Cache.SetCacheability(HttpCacheability.NoCache)
            ' Response.Cache.SetNoStore()
            Session("default") = "1"
            Response.Write("<script>window.location.href = 'Default.aspx' </script>")
            'Response.Redirect("Student_Details1.aspx")
            'Button2_Click(sender, e)


        Else
            Session("crendential") = "5"
                Response.Write("<script>window.location.href = 'Default.aspx' </script>")
                ' Response.Write("Wrong Credentials")

            End If
            conn.Close()

        ' End If
        'Catch ex As SqlException
        '  Response.Write("Error" + ex.ToString())          REM to change
        ' Finally
        conn.Dispose()

            'Session.Clear()
        'Session.RemoveAll()
        'Session.Abandon()


        'End Try


    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Session("forward1") = "1" Then
            Session("forward11") = "1"

            Response.Write("<script>window.location.href = 'Default.aspx' </script>")
        End If


    End Sub

    'Private Sub Fun2(ByVal sender As Object, e As EventArgs)
    'If TextBox1.Text = "anand" Then
    '   TextBox1.Text = "rohit"
    'End If
    ' End Sub


    'Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
    'Fun2_KeyPress()

    ' End If
    'Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1))
    'Response.Cache.SetCacheability(HttpCacheability.NoCache)
    'Response.Cache.SetNoStore()

    ' Response.ClearHeaders()
    'Response.AddHeader("pragma", "no-cache")
    'Response.AddHeader("Cache-control", "no-cache, max aged, no-store, must-revalidate")

    'Response.Buffer = True
    'Response.ExpiresAbsolute = DateTime.Now.AddDays(-1D)
    'Response.Expires = -100
    ' Response.CacheControl = "no-cache"

    'Session.Abandon() REM to make all session variables nothing
    ' FormsAuthentication.SignOut()
    'Page.ClientScript.RegisterStartupScript(Me.GetType(), "ClearHistory", "Clearhistory()", True)



    REM   System.Web.UI.ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "Script", "self.close()", True)

    'End Sub








    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' SetFocus(Button1)

    End Sub
    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' SetFocus(Button1)

    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim ctdate As DateTime

        ctdate = Now
        Session("currentdate") = ctdate.ToString("dd-MM-yyyy") REM getting datein session variable

        'Session("cd") = Convert.ToInt32(Right(Session("currentdate"), 4)) + Convert.ToInt32(Left(Session("currentdate"), 2))
        Response.Write(Session("currentdate"))
        'If Session("offline") = "1" Then Response.Write("Your System is Running Offline! Check Your Current Date  & TIme")
        'Console.WriteLine("Current Date: ")




        'Console.WriteLine("Today is: {0}", dt)
        'Console.ReadKey()

        If IsPostBack = False Then
            If Session("forward11") = "1" Then
                Session("forward1") = ""
                Session("forward11") = ""
                Response.Redirect("Student_Details1.aspx")
                'Response.Write("<script>window.location.href = 'Student_Details1.aspx' </script>")

            ElseIf Session("crendential") = "5" Then
                ch3.InnerHtml = "<center><h2>Wrong Crendentials!!!</h2></center>"
                Session("crendential") = ""
            ElseIf Session("default") = "1" Then
                Session("default") = ""
                Response.Redirect("Student_Details1.aspx")
                ' Response.Write("<script>window.location.href = 'Student_Details1.aspx' </script>")
            End If
            ' End If
            '  If IsPostBack = False Then
            '  TextBox1.Text = ""
            '  TextBox2.Text = ""
        End If
    End Sub


    'Public Shared Function GetDateTime() As DateTime
    '    Dim dateTime As DateTime = DateTime.MinValue
    '    Dim request As System.Net.HttpWebRequest = DirectCast(System.Net.WebRequest.Create("http://www.microsoft.com"), System.Net.HttpWebRequest)
    '    request.Method = "GET"
    '    request.Accept = "text/html, application/xhtml+xml, /"
    '    request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/6.0)"
    '    request.ContentType = "application/x-www-form-urlencoded"
    '    request.CachePolicy = New System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore)
    '    Dim response As System.Net.HttpWebResponse = DirectCast(request.GetResponse(), System.Net.HttpWebResponse)
    '    If response.StatusCode = System.Net.HttpStatusCode.OK Then
    '        Dim todaysDates As String = response.Headers("date")
    '        dateTime = DateTime.ParseExact(todaysDates, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat, System.Globalization.DateTimeStyles.AssumeUniversal)
    '    End If

    '    Return dateTime

    'End Function


End Class
