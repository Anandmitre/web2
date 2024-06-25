Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web.Configuration
Imports System.Data
Imports System.Text.RegularExpressions
Imports System.Web.UI.WebControls

Partial Class Session_1_Page_1
    Inherits System.Web.UI.Page

    Dim conn As SqlConnection
    Dim com As SqlCommand
    Dim rd As SqlDataReader



    Protected Sub Page_load(sender As Object, e As EventArgs) Handles Me.Load


        ' Response.Buffer = True
        'Response.ClearHeaders()
        ' Response.AddHeader("pragma", "no-cache")
        ' Response.AddHeader("Cache-control", "no-cache, max aged, no-store, must-revalidate")
        'If (IsPostBack = False) Then
        If Session("check1") = "1" Then
            ch4.InnerHtml = "<center> <h2> Incorrect Value! The Session may already exist!!</h1> </center>"
            Session("check1") = Nothing
        ElseIf Session("check1") = "2" Then
            ch4.InnerHtml = "<center> <h2> Select a Session to Start!!</h1> </center>"
            Session("check1") = Nothing
        ElseIf Session("check1") = "6" Then
            ch4.InnerHtml = "<center> <h2> Session Creation Successful!!</h1> </center>"
            Session("check1") = Nothing
        ElseIf Session("check1") = "7" Then
            ch4.InnerHtml = "<center> <h2> Session Started!!</h1> </center>"
            Session("check1") = Nothing
        ElseIf Session("check1") = "8" Then
            ch4.InnerHtml = "<center> <h2> Session Closed!!</h1> </center>"
            Session("check1") = Nothing
        ElseIf Session("check1") = "9" Then
            ch4.InnerHtml = "<center> <h2> Not Connected to Internet!!</h1> </center>"
            Session("check1") = Nothing
        End If
        'FormsAuthentication.SignOut()
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "ClearHistory", "Clearhistory()", True)
        ' Session("user") = Nothing
        ' Response.ExpiresAbsolute = DateTime.UtcNow.AddDays(-1D)
        'Response.Expires = -1500
        ' Response.CacheControl = "no-cache"
        'End If

        ' getting the name of last session
        Dim query As String
        conn = New SqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        conn.Open()
        Query = "select Session from Session2 where Status='Closed_Last'"
        com = New SqlCommand(Query, conn)

        rd = com.ExecuteReader
        Dim count21 As Integer
        count21 = 1
        While rd.Read
            count21 = count21 + 1
            REM   reading last session name
            Session("lastS") = rd("Session")
            REM DropDownList1.Enabled = False


        End While



        conn.Close()

        conn = New SqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        conn.Open()

        REM     alert ('session expired');    using semi colon within script we can write many stmts
        REM Response.Redirect("Default.aspx")
        REM   Response.Write("<script></script>")

        query = "Select * from Session2 where Status = 'Running'"
        com = New SqlCommand(query, conn)
        rd = com.ExecuteReader
        Dim count41 As Integer
        count41 = 1
        While rd.Read
            count41 = count41 + 1
            REM   DropDownList1.SelectedValue = rd("Session")
            Session("app4") = rd("Session")
            REM DropDownList1.Enabled = False
            ' Button3.Enabled = False
            'Label8.Text = Session("app4")

        End While
        conn.Close()
        'Button1_Click(New Object(), New EventArgs())  REM  to call a button from page load
        '  Response.Redirect("dates1.aspx")   REM if called same page in same page cannot load

        REM If Application("app6") = "1" Then
        REM  Page.ClientScript.RegisterStartupScript(Me.GetType(), "ClearHistory", "Clearhistory()", True)
        REM Page.ClientScript.RegisterStartupScript(Me.GetType(), "script", "window.history.forward(1)", True)


        REM End If

        REM important: System.Web.UI.ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "Script", "window.history.backward(1)", True)


        ' Try

        REM check
        ' If (IsPostBack = True) And Session("user") = Nothing Then                     REM to discontinue if browser closed
        '  REM   If Application("app6") = Nothing Then       REM     to continue sesssion even after broser closed
        '  Dim sc As String = "<script> alert ('session expired'); window.location.href = 'Default.aspx'</script>"
        '    Response.Write(sc)
        '  End If
        ' If (IsPostBack = False) And Session("user") = Nothing Then
        '  Dim sc As String = "<script> alert ('session expired'); window.location.href = 'Default.aspx'</script>"
        ' Response.Write(sc)
        'End If
        If Session("user") = Nothing Then
                Response.Write("<script>window.location.href = 'Default.aspx' </script>")   ' Response.Redirect("Default.aspx")
            End If
        If (IsPostBack = False) And Session("user") = "1" Then






            conn = New SqlConnection
            conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
            conn.Open()

            REM     alert ('session expired');    using semi colon within script we can write many stmts
            REM Response.Redirect("Default.aspx")
            REM   Response.Write("<script></script>")

            Query = "Select * from Session2 where Status = 'Running'"
            com = New SqlCommand(Query, conn)
            rd = com.ExecuteReader
            Dim count As Integer
            count = 1
            While rd.Read
                count = count + 1
                REM   DropDownList1.SelectedValue = rd("Session")
                Session("app4") = rd("Session")
                REM DropDownList1.Enabled = False
                Button3.Enabled = False
                Label8.Text = Session("app4")

            End While

            If count = 1 Then

                Button4.Enabled = False

            End If
            conn.Close()
            'conn.Dispose()  '' checkout is it necessary to dispose it??

            conn = New SqlConnection
            conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
            conn.Open()
            If (IsPostBack = False) And Session("app") <> "" And Session("app5") = "1" Then


                Dim dt11 As String
                Dim dt1 As DateTime
                dt1 = GetDateTime()
                dt11 = dt1.ToString("dd MMM yyyy  hh : mm : ss tt  ")

                Query = "insert into Session (Session, DateTime) values ('" & Session("app") & "', '" & dt11 & "')"
                com = New SqlCommand(Query, conn)

                rd = com.ExecuteReader
                Session("app") = ""
                Session("app5") = ""
                REM Response.Write("<Script>alert('Session Creation Successful')</script>")
                Session("check1") = "6"
                Response.Write("<script>window.location.href = 'Session_1_Page_1.aspx' </script>")
                'Dim s5 As String = "alert ('Session Creation Successful')"
                'Page.ClientScript.RegisterStartupScript(Me.GetType(), "Script", s5, True)
                REM Response.Write("Session Creation Successful")
                REM Response.Redirect("Default.aspx")
                conn.Close()
            ElseIf (IsPostBack = False) And Session("app2") <> "" And Session("app5") = "1" Then
                Dim dt21 As String
                Dim dt2 As DateTime
                dt2 = GetDateTime()
                dt21 = dt2.ToString("dd MMM yyyy  hh : mm : ss tt  ")
                Query = "insert into Session2 (Session, Started_on, Status) values ('" & Session("app2") & "', '" & dt21 & "', 'Running')"
                com = New SqlCommand(Query, conn)

                rd = com.ExecuteReader
                Label8.Text = Session("app2")
                Session("Create") = Convert.ToString(Session("app2")) ' to create tables taking value of session
                Session("recycle") = "Recycle_" + Session("Create")
                Session("feemaster") = "FeeMaster_" + Session("Create")
                Session("FeeDetails1") = "FeeDetails1_" + Session("Create")
                Session("FeeTable1") = "FeeTable1_" + Session("Create")

                ' Session("2cursession") = Session("Create")
                'Session("create2") = Session("Create")
                Session("create3") = Session("Create")
                Session("create4") = Session("Create")

                Session("app2") = ""

                Session("app5") = ""
                REM Response.Redirect("Session_1_Page_1.aspx")
                REM  DropDownList1.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = True




                conn.Close()

                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES where TABLE_NAME= '" & Session("create") & "'"
                com = New SqlCommand(Query, conn)
                rd = com.ExecuteReader

                While rd.Read

                    Session("Create") = ""   ' to stop creating a duplicate main session table 
                    'after starting the previous session again
                End While

                conn.Close()

                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES where TABLE_NAME= '" & Session("feemaster") & "'"
                com = New SqlCommand(Query, conn)
                rd = com.ExecuteReader

                While rd.Read

                    Session("feemaster") = ""   ' to stop creating a duplicate main session table 
                    'after starting the previous session again
                End While

                conn.Close()

                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()

                Query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES where TABLE_NAME= '" & Session("recycle") & "'"
                com = New SqlCommand(Query, conn)
                rd = com.ExecuteReader
                ' Dim count2 As Integer
                ' count2 = 1

                While rd.Read
                    'count2 = count2 + 1
                    Session("recycle") = ""   ' to stop creating a duplicate main session table 
                    'after starting the previous session again
                End While

                conn.Close()

                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()

                Query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES where TABLE_NAME= '" & Session("FeeDetails1") & "'"
                com = New SqlCommand(Query, conn)
                rd = com.ExecuteReader
                ' Dim count2 As Integer
                ' count2 = 1

                While rd.Read
                    'count2 = count2 + 1
                    Session("FeeDetails1") = ""   ' to stop creating a duplicate main session table 
                    'after starting the previous session again
                End While

                conn.Close()

                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()

                Query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES where TABLE_NAME= '" & Session("FeeTable1") & "'"
                com = New SqlCommand(Query, conn)
                rd = com.ExecuteReader
                ' Dim count2 As Integer
                ' count2 = 1

                While rd.Read
                    'count2 = count2 + 1
                    Session("FeeTable1") = ""   ' to stop creating a duplicate main session table 
                    'after starting the previous session again
                End While

                conn.Close()


                Session("check1") = "7"
                Response.Write("<script>window.location.href = 'Session_1_Page_1.aspx' </script>")
                'Response.Write("<Script>alert('Session Started')</script>")
            ElseIf (IsPostBack = False) And Session("app3") <> "" And Session("app5") = "1" Then
                Dim dt31 As String
                Dim dt3 As DateTime
                dt3 = GetDateTime()
                dt31 = dt3.ToString("dd MMM yyyy  hh : mm : ss tt  ")
                Query = "update Session2 set Closed_on='" & dt31 & "', Status='Closed' where Status='Closed_Last'"
                com = New SqlCommand(Query, conn)

                rd = com.ExecuteReader
                'rd.Read()
                'rd.Close()
                conn.Close()

                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Query = "update Session2 set Closed_on='" & dt31 & "', Status='Closed_Last' where Status='Running'"
                com = New SqlCommand(Query, conn)

                rd = com.ExecuteReader
                'rd.Read()
                'rd.Close()
                conn.Close()



                Label8.Text = "No Session Running"
                Session("app3") = ""
                Session("app5") = ""
                Button4.Enabled = False
                REM DropDownList1.Enabled = True
                Button3.Enabled = True
                Session("check1") = "8"
                Session("cursession") = ""
                Response.Write("<script>window.location.href = 'Session_1_Page_1.aspx' </script>")
                ' Response.Write("<Script>alert('Session Closed')</script>")
                REM Response.Redirect("Session_1_Page_1.aspx")

                ' getting the name of last session
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Query = "select Session from Session2 where Status='Closed_Last'"
                com = New SqlCommand(Query, conn)

                rd = com.ExecuteReader
                Dim count1 As Integer
                count1 = 1
                While rd.Read
                    count1 = count1 + 1
                    REM   reading last session name
                    Session("lastS") = rd("Session")
                    REM DropDownList1.Enabled = False


                End While



                conn.Close()



            End If



            If (IsPostBack = False) And Session("create") <> "" And Label8.Text <> "No Session is Running" Then
                Dim com As New SqlCommand

                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString

                conn.Open()
                Dim sp11 As SqlParameter = New SqlParameter("@x6", SqlDbType.NVarChar)
                sp11.Value = Session("create")
                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg
                'com = New SqlCommand(query, conn)
                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "spData1"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                Session("create") = ""
                com.Parameters.Add(sp11)
                ' com.Parameters.Add(sp11)
                com.ExecuteNonQuery()

                com.Parameters.Clear()
                conn.Close()


                ' inserting all students details in new session file from last session file
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString

                conn.Open()

                Dim Sdetails(1) As SqlParameter
                Sdetails(0) = New SqlParameter("@stud1", SqlDbType.NVarChar)
                Sdetails(0).Value = Session("lastS")
                Sdetails(1) = New SqlParameter("@stud2", SqlDbType.NVarChar)
                Sdetails(1).Value = Session("create3")
                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg
                'com = New SqlCommand(query, conn)
                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "spData11"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.AddRange(Sdetails)
                ' com.Parameters.Add(sp11)
                rd = com.ExecuteReader
                rd.Read()
                rd.Close()
                'com.Parameters.Clear()

                conn.Close()
                Session("create3") = ""

            End If

            If (IsPostBack = False) And Session("recycle") <> "" And Label8.Text <> "No Session is Running" Then
                Dim com As New SqlCommand

                ' Dim str As String
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim sp21 As SqlParameter = New SqlParameter("@x6", SqlDbType.NVarChar)
                sp21.Value = Session("recycle")
                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg
                ' Dim com As New SqlCommand
                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "spData1"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.Add(sp21)
                ' com.Parameters.Add(sp11)
                com.ExecuteNonQuery()
                Session("recycle") = ""
                com.Parameters.Clear()
                conn.Close()
            End If

            If (IsPostBack = False) And Session("feemaster") <> "" And Label8.Text <> "No Session is Running" Then
                Dim com As New SqlCommand

                ' Dim str As String
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim sp21 As SqlParameter = New SqlParameter("@x8", SqlDbType.NVarChar)
                sp21.Value = Session("feemaster")
                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg
                ' Dim com As New SqlCommand
                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "feemaster1"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.Add(sp21)
                ' com.Parameters.Add(sp11)
                com.ExecuteNonQuery()
                Session("feemaster") = ""
                com.Parameters.Clear()
                conn.Close()


                ' inserting all feemaster in new session feemaster file from last session file
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString

                conn.Open()

                Dim Fmas(1) As SqlParameter
                Fmas(0) = New SqlParameter("@fmast1", SqlDbType.NVarChar)
                Fmas(0).Value = "FeeMaster_" & Session("lastS")
                Fmas(1) = New SqlParameter("@fmast2", SqlDbType.NVarChar)
                Fmas(1).Value = "FeeMaster_" & Session("create4")
                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg
                'com = New SqlCommand(query, conn)
                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "feemaster3"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.AddRange(Fmas)
                ' com.Parameters.Add(sp11)
                rd = com.ExecuteReader
                rd.Read()
                rd.Close()
                com.Parameters.Clear()

                conn.Close()
                Session("create4") = ""

            End If




            If (IsPostBack = False) And Session("FeeDetails1") <> "" And Label8.Text <> "No Session is Running" Then
                Dim com As New SqlCommand

                ' Dim str As String
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim tp21 As SqlParameter = New SqlParameter("@p8", SqlDbType.NVarChar)
                tp21.Value = Session("FeeDetails1")
                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg
                ' Dim com As New SqlCommand
                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "Fee_Details"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.Add(tp21)
                ' com.Parameters.Add(sp11)
                com.ExecuteNonQuery()
                ' Session("FeeDetails22") = Session("FeeDetails1")

                Session("FeeDetails1") = ""
                com.Parameters.Clear()
                conn.Close()

            End If

            If (IsPostBack = False) And Session("FeeTable1") <> "" And Label8.Text <> "No Session is Running" Then
                Dim com As New SqlCommand

                ' Dim str As String
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim tps21 As SqlParameter = New SqlParameter("@tp8", SqlDbType.NVarChar)
                tps21.Value = Session("FeeTable1")
                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg
                ' Dim com As New SqlCommand
                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "Fee_Table1"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.Add(tps21)
                ' com.Parameters.Add(sp11)
                com.ExecuteNonQuery()
                ' Session("FeeDetails22") = Session("FeeDetails1")

                Session("FeeTable1") = ""
                com.Parameters.Clear()
                conn.Close()

            End If



            ' Dim str As String


            conn.Dispose()

            'Session("check1") = "7"
            'Response.Write("<script>window.location.href = 'Session_1_Page_1.aspx' </script>")
            ' why above 2 lines ,also written on line no. 257 and 258 are not suitable here--find out.
        End If
        'End Try
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' If Session("user") = Nothing Then
        'Session.Clear()
        'Session.RemoveAll()
        'Session.Abandon()
        'Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1D))
        'Response.Cache.SetCacheability(HttpCacheability.NoCache)
        'Response.Cache.SetNoStore()
        ' Page.ClientScript.RegisterStartupScript(Me.GetType(), "ClearHistory", "Clearhistory()", True)
        'Response.Write("<script>window.location.href = 'Default.aspx' </script>") 'Response.Redirect("Default.aspx")
        ' End If
        conn = New SqlConnection
            conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        Try
            conn.Open()

            Dim query As String
            query = "Select Session from Session where Session='" & TextBox1.Text & "'"
            com = New SqlCommand(query, conn)
            rd = com.ExecuteReader
            Dim count As Integer
            count = 1
            While rd.Read
                count = count + 1
            End While

            If count = 1 Then
                Session("app") = TextBox1.Text



                Response.Write("<script>window.location.href = 'Password_1_Page_3.aspx' </script>")


            Else

                ' Response.Write("<Script>  alert('Incorrect Value! The Session may already exist'); window.location.href='Session_1_Page_1.aspx'</script>")
                ' Response.Write("<Script> setTimeout(function() { alert('Incorrect Value! The Session may already exist'); window.location.href='Session_1_Page_1.aspx'}, 200)</script>")

                ' Response.Write("Incorrect Value! The Session may already exist")
                Session("Check1") = "1"
                Response.Write("<script>window.location.href = 'Session_1_Page_1.aspx' </script>")
                ' Response.Write("Incorrect Value! The Session may already exist")
            End If

            conn.Close()

        Catch ex As SqlException
            Response.Write("Error Occured")
        Finally
            conn.Dispose()

        End Try


        REM Response.Redirect("/Session_1_Page_1.aspx")
        REM   Response.Redirect(Request.Url.AbsoluteUri) Rem to call oneself

    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Response.Write("<script>window.location.href = 'Default.aspx' </script>")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        conn = New SqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        Try
            conn.Open()

            If DropDownList1.SelectedValue <> "" Then
                Session("app2") = DropDownList1.SelectedValue
                Response.Write("<script>window.location.href = 'Password_1_Page_3.aspx' </script>")
            Else

                Session("check1") = "2"
                ' Response.Write("Select a Session to Start ")
                Response.Write("<script>window.location.href = 'Session_1_Page_1.aspx' </script>")
            End If
            conn.Close()
        Catch ex As SqlException
            Response.Write("Error Occured")
        Finally
            conn.Dispose()

        End Try
        REM Response.Redirect("/Session_1_Page_1.aspx")
        REM   Response.Redirect(Request.Url.AbsoluteUri)

    End Sub

    Public Shared Function GetDateTime() As DateTime
        Dim dateTime As DateTime = DateTime.MinValue
        Dim request As System.Net.HttpWebRequest = DirectCast(System.Net.WebRequest.Create("http://www.microsoft.com/"), System.Net.HttpWebRequest)
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

        Return dateTime

    End Function
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        conn = New SqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        Try
            conn.Open()

            If Session("app4") <> "" Then
                Session("app3") = Session("app4")
                Session("app4") = ""
                Response.Write("<script>window.location.href = 'Password_1_Page_3.aspx' </script>")
            End If
            conn.Close()
        Catch ex As SqlException
            Response.Write("Error Occured")
        Finally
            conn.Dispose()

        End Try

    End Sub



    REM many ways for writing j script in the page also how to get alert/comfirm box and the page together
    REM    Dim a As String


    REM  a = "<script>if (window.confirm('Are you sure?')){ window.location.href = 'Login_1_Page_2.aspx' } else {window.location.href = }</script>"

    REM   Response.Write(a)

    REM  how to freeze the page during vb msgbox popup  how to get title of msgbox ant alert boxes
    REM a = "<script>setTimeout(function() {if (window.confirm('Are you sure?')){ window.location.href = 'Login_1_Page_2.aspx' } else {window.location.href = 'https://www.facebook.com/'}}, 200)</script>"

    REM    Response.Write(a)


    ' Dim s As String
    ' s = "alert ('hello sir')"
    ' Page.ClientScript.RegisterStartupScript(Me.GetType(), "Script", s, True)

    '  Page.ClientScript.RegisterStartupScript(Me.GetType(), "ClearHistory", "Clearhistory()", True)
    ' Session("user") = Nothing
    ' Response.ExpiresAbsolute = DateTime.UtcNow.AddDays(-1D)
    ' Response.Expires = -1500
    ' Response.CacheControl = "no-cache"



    ' Session.Contents.RemoveAll()  rem to make all session variables nothing
    'FormsAuthentication.SignOut()
    'HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache)
    ' Response.ExpiresAbsolute = DateTime.Now.AddMonths(-1)

    'Response.Buffer = True

    ' Response.Expires = -100
    'Response.CacheControl = "no-cache"
    ' Response.ExpiresAbsolute = DateTime.Now.AddDays(-1D)
    ' Response.ClearHeaders()
    'Response.AddHeader("pragma", "no-cache")
    ' Response.AddHeader("Cache-control", "no-cache, max aged, no-store, must-revalidate")

    'Response.Redirect("default.aspx")

    ' <script type="text/javascript" >        history.forward()    </script> ;  put in back html page for forwarding by 1 page

    REM Page.ClientScript.RegisterStartupScript(Me.GetType(), "Script", s, True)

    REM System.Web.UI.ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "Script", abc() / s, True) 


    '    Dim strScript As String = "<script>"
    '   strScript += "alert('Hello bcvb Pavan');"
    '   strScript += "</script>"
    '   Page.ClientScript.RegisterStartupScript(Page.GetType(), "starScript", strScript, False)
    REM MsgBox("hi", vbOKCancel + vbQuestion, "test")
    REM in case of true above j script is written without start and end tags but in case of --
    REM --false, end tags must be written for j script
    ' MsgBox(findArea())


    Function findArea() As Double
        Dim Length As Integer
        REM Dim Width As Integer
        Length = InputBox("Enter Length ", "Enter a Number")
        REM  Width = InputBox("Enter Width", "Enter a Number")
        findArea = Length    REM * Width

    End Function


    REM writing a function


    ' Function abc() As String

    ' Dim s As String = "<script>"
    '    s += " alert('Hello, Pavan') "
    '    s += "</script>"
    ' Return s
    ' End Function
    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Session("check1") = Nothing

        'Session("user") = Nothing
        ' Session("app") = Nothing
        ' Session("app2") = Nothing
        ' Session("app3") = Nothing
        'Session("app4") = Nothing
        ' Session("app5") = Nothing
        ' Response.Redirect("Session_1_Page_1.aspx")
        Response.Write("<script>window.location.href = 'Session_1_Page_1.aspx' </script>")

    End Sub
    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        REM Session.Abandon()
        REM Session.Clear()
        REM to discontinue if browser closed
        REM Session.RemoveAll()
        REM check

        'FormsAuthentication.SignOut()

        ' Response.ExpiresAbsolute = DateTime.UtcNow.AddDays(-1D)
        ' Response.Expires = -1500
        ' Response.CacheControl = "no-cache"


        REM check
        Session("user") = Nothing
        Session("check1") = Nothing
        Session("app") = Nothing
        Session("app2") = Nothing
        Session("app3") = Nothing
        Session("app4") = Nothing
        Session("app5") = Nothing
        Session.Clear()
        Session.RemoveAll()
        Session.Abandon()
        'Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1D))
        'Response.Cache.SetCacheability(HttpCacheability.NoCache)
        'Response.Cache.SetNoStore()
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "ClearHistory", "Clearhistory()", True)
        ' FormsAuthentication.SignOut()
        'Response.ExpiresAbsolute = DateTime.UtcNow.AddDays(-1D)
        'Response.Expires = -1500
        'Response.CacheControl = "no-cache"
        'Response.ClearHeaders()
        'Response.AddHeader("pragma", "no-cache")
        ' Response.AddHeader("Cache-control", "no-cache, max aged, no-store, must-revalidate")
        ' Response.Buffer = True
        'System.Web.UI.ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "Script", "self.close()", True)

        ' Response.Redirect("Default.aspx")
        Response.Write("<script>window.location.href = 'default.aspx' </script>")
    End Sub




End Class
