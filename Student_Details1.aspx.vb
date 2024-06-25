
Imports System.Data
Imports System.Security.Permissions

Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text.RegularExpressions
Imports System.Web.UI.WebControls
Imports System.Globalization
Imports System.Timers
Imports System.Drawing
Imports System.net
Imports System.Net.Mail
Imports System.Net.Sockets
Imports WebClientExtended     'importing user defined class
Imports DevExpress.Data.Helpers.ExpressiveSortInfo
'Imports DevExpress.Data.Helpers.ExpressiveSortInfo

Partial Class Student_Details1

    Inherits System.Web.UI.Page
    Dim dt As New DataTable
    Dim conn As SqlConnection
    Dim com As SqlCommand
    Dim query As String
    Dim rd As SqlDataReader
    Dim Dat(25) As String
    Dim ags(25) As String
    Dim count1 As Integer
    Dim k As Integer











    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Response.Redirect("Session_1_Page_1.aspx")


    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load



        ' If DropDownList1.Text = "" Then DropDownList1.Text = ""
        'TextBox1.Text = Session("txb1")
        'Session("txb1") = TextBox1.Text

        'Dim i1 As String
        ' i1 = Session("ddlb1")
        ' Dim i2 As String
        ' i2 = Session("ddlb2")
        'HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache)
        'TextBox1.Text = Session("txb1")
        'TextBox1.Text = ""
        ' GridView2_Sorting(sender, e)


        ' If Session("user") = Nothing Then
        'Response.Redirect("Default.aspx")
        'Dim sc As String = "<script> alert ('session expired'); window.location.href = 'Default.aspx'</script>"

        '  End If
        ' If Session("refresh") = "1" Then
        'Session("refresh") = ""
        'Button2_Click(sender, e)
        ' End If If Session("page2") = "1" Then

        'If Session("page2") = "1" Then
        'Session("page2") = ""
        'Response.redirect
        'Response.Write("<script>window.location.href = 'Student_Details1.aspx'</script>")
        'End If
        Try
            If (IsPostBack = False) Then


                'If Session("search") = 1 Then
                'Call
                'End If
                Response.Write(Session("logout"))

                If Session("edit5") = "2" Or Session("addnew5") = "1" Then
                    'Session("edit5") = "3"
                    'Call Button2_Click(sender, e)
                    'ElseIf Session("edit5") = "3" Then
                    'Session("test") = "test1"
                    Call Button4_Click(sender, e)

                End If
                If Session("search") = "12" Then
                    Session("search") = Nothing
                    Call Button4_Click(sender, e)
                ElseIf Session("search") = "22" Then
                    Session("search") = "23"
                    'Response.Redirect("EditPage1.aspx")
                    Call Button4_Click(sender, e)

                End If
                If Session("recordeleted") = "1" Then
                    Session("recordeleted") = "0"

                    Call Button4_Click(sender, e)
                End If
                ' If Mid(Label2.Text.ToString, 19, 1) = "0" Then Button9.Text = "Check Connection"

                'If Right(GetDateTime(), 6) = "ONLINE" Then
                '    Label2.Text = GetDateTime()
                'Else
                '    Label2.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm:ss tt") + " OFFLINE"
                'End If

                If Session("logout") = "1" Then
                        Session("logout") = ""
                        Session.Clear()
                        Session.Contents.RemoveAll()
                        Session.RemoveAll()
                        'FormsAuthentication.SignOut()
                        Session.Abandon()
                        'Response.Redirect("Default.aspx")

                        Response.Write("<script>window.location.href = 'Default.aspx'</script>")
                    End If
                    'If Session("view2") = "1" Then
                    'Response.Redirect("ViewDetails1.aspx")
                    'Response.Write("<script>window.location.href = 'ViewDetails1.aspx'</script>")
                    'Session("view2") = ""
                    'End If
                    'Label2.Text = CheckForInternetConnection()
                    'Response.Write(CheckForInternetConnection())
                    If Session("cursession") = "" Then
                        conn = New SqlConnection
                        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                        conn.Open()

                        query = "Select * from Session2 where Status = 'Running'"
                        com = New SqlCommand(query, conn)
                        rd = com.ExecuteReader
                        Dim count As Integer
                        count = 1
                        While rd.Read
                            count = count + 1
                            REM   DropDownList1.SelectedValue = rd("Session")
                            Session("cursession") = rd("Session")

                        End While
                        '  If count = 1 Then Session("cursession") = ""
                        conn.Close()
                        conn.Dispose()
                    End If

                    If Session("forward21") = "1" Then
                        Session("forward21") = ""
                        Session("view") = "1"
                        'Response.Write("<script>window.location.href = 'ViewDetails1.aspx' </script>")
                    ElseIf Session("backward1") = "1" Then
                        Session("backward1") = ""
                        ' Response.Redirect("Default.aspx")
                        Response.Write("<script>window.location.href = 'Default.aspx' </script>")
                    End If



                    ' TextBox1.Text = ""
                    TextBox1.Text = Session("txb1")

                    ' Session("direction") = "ASC"
                    'Fun2()
                    DropDownList2.Items.Add("")
                    DropDownList2.Items.Add("A")
                    DropDownList2.Items.Add("B")
                    DropDownList2.Items.Add("C")
                    DropDownList1.Items.Add("")
                    DropDownList1.Items.Add("Nursery")
                    DropDownList1.Items.Add("LKG")
                    DropDownList1.Items.Add("UKG")
                    Dim x2 As Integer
                    For x2 = 1 To 12
                        DropDownList1.Items.Add(x2)
                    Next


                    'DropDownList1.SelectedValue = i1
                    ' DropDownList2.SelectedValue = i2
                    'Response.Write(Session("txb1"))
                    'ch.InnerHtml = Session("ddlb1")

                    DropDownList1.SelectedValue = Session("ddlb1")

                    DropDownList2.SelectedValue = Session("ddlb2")

                    If Session("cursession") <> "" Then   'Session("sortcheck") = "" And 
                        Call Fun1()

                    ElseIf Session("cursession") = "" Then
                        Session("grid") = "2"            'no session running
                        ch.InnerHtml = " <center> <h1> No Session Running!</h1> </center>"
                    End If




                    'Response.Write(Session("index"))

                    ' Response.Write(GridView2.SelectedIndex)

                    If Session("sortcheck") = "1" Then
                        'Call Fun1()  'just added
                        Call fun4()   'finally this data view will be seen on the page 
                        'until reset, sortcheck will not be none
                    End If
                    'If (Convert.ToInt32(Session("index"))) > -1 Then

                    Call fun3()  'selecting and coloring grid rows making index 0

                    '  Else
                    '  GridView2.SelectedIndex = -1

                    'End If
                    If Session("view") = "1" Then

                        If Session("edit5") = "2" Or Session("addnew5") = "1" Then
                            Dim a As Integer
                            'Dim x As Integer
                            Dim b As String

                            Dim row As GridViewRow
                            'Dim session("gv") As GridView 'use In app code
                            ' just declared can be erase if needed
                            'b = Convert.ToInt32(s)
                            For a = 0 To Convert.ToInt32(Session("max")) - 1
                                row = GridView2.Rows(a)  ' just changed gridview2 by Session("gv")
                                b = row.Cells(11).Text.Trim()

                                If String.Compare(Session("admsn2").trim(), b) = 0 Then
                                    Session("index2") = a
                                    Exit For
                                End If

                            Next a
                            If Session("addnew5") = "1" Then
                                Session("addnew5") = Nothing
                            Else
                                Session("edit5") = "3"
                            End If

                            'Session("test") = "test2"  ' just for test
                        End If

                        Call fun5()

                        '   If Session("thispage") = "4" And Session("admsn") <> Nothing Then
                        Session("thispage") = ""
                        Session("view") = ""
                        'Session("view2") = "1"
                        'Response.Redirect("Student_Details1.aspx")
                        Response.Redirect("ViewDetails1.aspx")
                        ' Response.Write("<script>window.location.href = 'Student_Details1.aspx' </script>")
                        ' above command not work if written below the follwing code . but response.redirect do work.
                    End If

                    If Session("viewdetail") = "1" Then
                        Session("thispage") = "1"
                        Session("viewdetail") = ""
                        Session("view") = "1"

                        Response.Redirect("Student_Details1.aspx")
                        'Response.Write("<script>window.location.href = 'Student_Details1.aspx'</script>")
                    End If


                    If Session("time1") = "" Then
                        Sysdate1()
                        Session("time1") = "1"
                    End If



                    ' DropDownList1.Text = ""

                    'Response.Write(DropDownList1.SelectedValue = Session("ddlb1"))
                    ' ch.InnerHtml = Session("ddlb1")
                    'DropDownList1.SelectedValue = ch.InnerHtml
                    'DropDownList1.Visible = True



                    ' If DropDownList1.Text <> "" Then DropDownList1.Items.Clear()

                End If

                ' Button2_Click(sender, e)
                ' GridView2_Sorting(sender, e)
                ' DropDownList1.SelectedValue = ""
                'Fun1()
                ' Dim xp = Session("txb1")
                ' TextBox1.Text = xp
                ' If (IsPostBack = True) Then
                'If TextBox1.Text = "" Then TextBox1.Text = Session("txb1")
                ' Response.Write("<script id=Textbox1 value=xp></script> ")
                'TextBox1.Text = Response.Write(xp)
                'If (IsPostBack = True) Then
                'Session("ddlb1") = DropDownList1.SelectedValue
                'End If


                'Response.Write("</br> < center > Results For " + Session("ddlb1") + " ... </center> ")

                ' TextBox1.Text = <% Response.Write(Session("ddlb1")) %>
                ' End If..........
                'Call Fun1()
                ' GridView2.Sort(GridView2.Surname(), System.ComponentModel.ListSortDirection.Ascending)
                'Func2()
                REM if a submit button does "Not Get us  To" the other page then following code ....
                REM ....has some meaning otherwise no meaning, no deletion of history
                'Page.ClientScript.RegisterStartupScript(Me.GetType(), "ClearHistory", "Clearhistory()", True)
                'Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1))
                'Response.Cache.SetCacheability(HttpCacheability.NoCache)
                'Response.Cache.SetNoStore()

                If Session("logout") = "1" Then  ' it is out side of postback false
                Session("logout") = ""
                Session.Clear()
                Session.Contents.RemoveAll()
                Session.RemoveAll()
                'FormsAuthentication.SignOut()
                Session.Abandon()
                Response.Redirect("Default.aspx")

                'Response.Write("<script>window.location.href = 'Default.aspx'</script>")
            End If
        Catch sc As SqlException
            'Dim sc As String = "<script> alert ('Timed Out. Refresh!')</script>" '; window.location.href = 'Default.aspx'</script>"
            Response.Write(sc)
        End Try

    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ''If Session("user") = Nothing Then
        '    Fun1()

        Session("index2") = 0
        Session("sortcheck") = ""
        Session("txb1") = TextBox1.Text
        'TextBox1.Text = ""
        'TextBox1.Text = Session("txb1")

        'Response.Redirect("Default.aspx")
        ' End If
        'Session("txb1") = TextBox1.Text
        'Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1))
        'Response.Cache.SetCacheability(HttpCacheability.NoCache)
        'Response.Cache.SetNoStore()
        ' Response.Redirect("Student_Details1.aspx")
        Response.Write("<script>window.location.href = 'Student_Details1.aspx' </script>")

        ' Fun1()

        'Dim dv As New DataView(dt)
        'dv.RowFilter = String.Format("@Surname like '%(0)%'", TextBox1.Text.Trim())
        'GridView2.DataSource = dv
        ' GridView2.DataBind()
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Session.Clear()
        Session.Contents.RemoveAll()
        Session.RemoveAll()
        Session("txb1") = ""
        Session("ddlb1") = ""
        Session("ddlb2") = ""
        Session("sort_expression") = "Class_Std"
        Session("sortcheck") = ""
        Session("index") = 0
        Session("direction") = "ASC"
        Session("dv") = Nothing
        Session("dt") = Nothing
        Session("index2") = 0
        Session("view") = ""
        Session("color") = Nothing
        Session("viewdetail") = ""
        Session("forward2") = ""
        Session("forward1") = ""
        Session("backward1") = ""
        Session("backward2") = ""
        Session("logout") = ""
        Session("max") = 0
        Session("crendential") = ""
        Session("grid") = ""
        Session("default") = ""
        Session("logout2") = ""
        DropDownList1.SelectedValue = ""
        DropDownList2.SelectedValue = ""
        TextBox1.Text = ""


        'Session("sort_expression") = "Class_Standardd"
        'Session("index") = -1
        'Session("dv") = Nothing
        'Session("direction") = "ASC"
        ' Session("sortcheck") = ""
        'Session("dt") = Nothing
        ' Session("select") = ""

        ' Response.Redirect("Student_Details1.aspx")
        ' Fun1()

        Response.Write("<script>window.location.href = 'Student_Details1.aspx' </script>")


        'Response.Redirect("Student_Details1.aspx")
        'Dim sc1 As String = "<script> alert ('session expired'); window.location.href = 'Default.aspx'</script>"

        'If (IsPostBack = True) Then
        'Dim dv As New DataView(dt)

        'dv.RowFilter = String.Format(" '&Surname&' Like '%gupta%' ")
        'GridView2.DataSource = dv
        ''cmd.Parameters.AddWithValue("@ContactName", txtSearch.Text.Trim())
        'Func2()
        ' End If
        'End Sub
        'Private Sub Func2()
        ' Dim dv As New DataView(dt)
        'dv.RowFilter = String.Format("Surname Like '%' + @Surname +'%'")
        'com.Parameters.AddWithValue("@Surname", TextBox1.Text.Trim())
        ' GridView2.DataSource = dv

    End Sub
    Private Sub fun10()   REM  need a better way to takeover do until loop
        ' Dim cdt1 As String = Left(GetDateTime(), 10)
        ' Dim dupdate As Integer
        ' Dim cdt2 As String = ""
        'Session("sortcheck") = "1"
        conn = New SqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        conn.Open()
        'query = "Select Date_of_Birth from CBSPS"
        Dim tabname As SqlParameter
        tabname = New SqlParameter("@param6", SqlDbType.VarChar)
        tabname.Value = Session("cursession")

        Dim com As New SqlCommand
        com.Connection = conn
        com.CommandType = CommandType.StoredProcedure
        com.CommandText = "age2"
        com.Parameters.Add(tabname)

        rd = com.ExecuteReader
        Dim count1 As Integer = 0

        While rd.Read
            count1 = count1 + 1
            REM   DropDownList1.SelectedValue = rd("Session")
            Dat(count1) = rd("Date_of_Birth")
            ags(count1) = age(Dat(count1))
            ' Dat(count1) = Left()
            'Response.Write(Dat(count))
            REM DropDownList1.Enabled = False
        End While
        Session("IST") = Nothing
        conn.Close()
        conn.Dispose()


        'If (dupdate = 1) Or (cdt2 <> cdt1) Then
        ' Do Until (count1 = 0)    '  old
        ' Response.Write(count1)

        'For count1 =
        'Dim count() As Integer = ({1, 2})

        conn = New SqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        conn.Open()
        Do Until (count1 = 0)   ' new
            'query = "update CBSPS set Age = '" & ags(count1) & "'  where  Date_of_Birth = '" & Dat(count1) & "'"
            Dim q(2) As SqlParameter
            q(0) = New SqlParameter("@param1", SqlDbType.VarChar)
            q(0).Value = Session("cursession")
            q(1) = New SqlParameter("@param2", SqlDbType.VarChar)
            q(1).Value = "'" & ags(count1) & "'"
            q(2) = New SqlParameter("@param3", SqlDbType.VarChar)
            q(2).Value = "'" & Dat(count1) & "'"


            'Dim 
            com = New SqlCommand
            com.Connection = conn
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "age1"
            com.Parameters.AddRange(q)    '  edit
            'Dim n As Integer
            'For n = 0 To 1
            'com.Parameters.AddWithValue("@cc", ags(n))
            'Next
            rd = com.ExecuteReader
            rd.Read()
            rd.Close()  ' new
            'conn.Close()  'old
            count1 = count1 - 1

        Loop
        conn.Close()  'new
        conn.Dispose()




        'query = "update dbo.[2021] Set Age= @age   where Date_of_Birth = @datess"
        ' For count1 = 1 To 2
        'com.Parameters.AddWithValue("@age", age(Dat(count1)))
        ' com.Parameters.AddWithValue("@datess", Dat(count1))
        'Next
        'conn = New SqlConnection
        'conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        'conn.Open()
        'query = "update 2021 Set age=" & age(Session("ddate")(count)) & " * from 2021 where age="""
    End Sub




    Private Sub Fun1()

        'If Session("sort_expression") = Nothing Then
        'Session("sort_expression") = "Class_Standard"
        ' Session("Sort") = ""
        'If Session("Sort") = "1" Then Session("Sort") = ""
        '  End If
        'selected row variable to unselected value

        TextBox1.Text = Session("txb1")

            'Session("query") = query

            'Try
            Dim dt As New DataTable()
            Session("dt") = dt
            conn = New SqlConnection
            conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
            conn.Open()
            Dim sda As New SqlDataAdapter
            'Dim SortExpression = "Roll_No."
            ' Dim ds As New DataSet
            REM check
            ' If (IsPostBack = False) Then
            Dim tb1 = "'%'+'" & TextBox1.Text.Trim() & "'+'%'"
            Dim dd1 = "'%'+'" & DropDownList1.Text.Trim() & "'+'%'"
            Dim dd2 = "'%'+'" & DropDownList2.Text.Trim() & "'+'%'"
            ' need to include other options as search option from table fields

            Dim session_name(3) As SqlParameter
            session_name(0) = New SqlParameter("@para1", SqlDbType.NVarChar)
            If Session("del1") = Nothing Then
                session_name(0).Value = Session("cursession")
            ElseIf Session("del1") = "2" Then
                session_name(0).Value = "Recycle_" + Session("cursession")
            End If
            session_name(1) = New SqlParameter("@para2", SqlDbType.VarChar)
                session_name(1).Value = tb1
                session_name(2) = New SqlParameter("@para3", SqlDbType.NVarChar)
                session_name(2).Value = dd1
                session_name(3) = New SqlParameter("@para4", SqlDbType.NVarChar)
                session_name(3).Value = dd2



                'Dim str1 As String = "Select * from CBSPS  where (((Surname Like  '%' + @Sirname + '%'  ) or"
                'Dim str2 As String = " (Name_of_Student  LIKE  '%' + '" & TextBox1.Text.Trim() & "' + '%'  )"
                'Dim str6 As String = " Or (Name_of_Mother  LIKE  '%' + '" & TextBox1.Text.Trim() & "' + '%'  )"
                'Dim str7 As String = " Or (Name_of_Father  LIKE  '%' + '" & TextBox1.Text.Trim() & "' + '%'  )"
                'Dim str3 As String = " Or (Phone_No_Father  Like  '%' + '" & TextBox1.Text.Trim() & "' + '%'  ))"
                'Dim str4 As String = " And (Class_Std Like  '%' + '" & DropDownList1.Text.Trim() & "' + '%')"
                REM Dim str11 As String = " And (Class_Standard Like  '%' + '" & DropDownList3.Text.Trim() & "' + '%')"
                'Dim str5 As String = " And (Section Like  '%' + '" & DropDownList2.Text.Trim() & "' + '%'))"
                REM Dim str9 As String = "order by" + Session(sort_expression) + "Asc"
                'query = str1 + str2 + str6 + str7 + str3 + str4 + str5 + "order by Class_Std Asc"
                REM query = "Select * from CBSPS " ' where (((Surname  LIKE  '%' + @Surname +'%'  ) or (Name_of_Student  LIKE  '%' + '" & TextBox1.Text.Trim() & "' + '%'  ) or (Phone_Number  LIKE  '%' + '" & TextBox1.Text.Trim() & "' + '%'  )) and (Class_Standard LIKE  '%' + '" & DropDownList1.Text.Trim() & "' + '%'))"
                'com = New SqlCommand(query, conn)

                Dim com As New SqlCommand
                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "StudentDetails1"
                com.Parameters.AddRange(session_name)
                'com = New SqlCommand(query, conn)
                'com.Parameters.Add(vari1)
                'com.Parameters.AddWithValue("@Sirname", TextBox1.Text.Trim())

                'com.Parameters.AddWithValue("@Class_Standard", DropDownList1.Text.Trim())
                'com.CommandText = query
                'com.Connection = conn
                'rd = com.ExecuteReader
                ' com.ExecuteNonQuery()


                sda.SelectCommand = com
                sda.Fill(Session("dt"))
                GridView2.DataSource = Session("dt") '
                GridView2.DataBind()

                'Session("GridData") = Session("dt")
                'sda.Dispose()
                'Panel1.Update()
                Session("max") = GridView2.Rows.Count
                Session("dt").Clear()
                Session("grid") = ""

                'sda.Update(dt)
                If sda.Fill(Session("dt")) = Nothing Then
                    Session("grid") = "1"
            ' Session("1grid") = "1"

            Response.Write(Session("grid"))
                    '  Dim sp As String = Space(20)
                    ch.InnerHtml = " <center> <h1> No Result!</h1> </center>"
                ElseIf (Session("txb1") <> "" Or Session("ddlb1") <> "" Or Session("ddlb2") <> "") Then
                    'Response.Write()
                    ch.InnerHtml = " <center><h2> Search Results For &nbsp  <span style = 'color:brown'><u> " + Session("txb1") + " </u>, &nbsp Class: <u>" + Session("ddlb1") + "</u>, &nbsp Section: <u>" + Session("ddlb2") + ",</u> &nbsp; </span>  Total Records-   " & Session("max") & ",&nbsp&nbsp&nbsp&nbsp&nbspSorted by:<span style = 'color:maroon'>   Class_Standard  </span></h2></center>"
                ElseIf Session("del1") = Nothing Then
                    ch.InnerHtml = " <center><h2> Showing Students Details:   <span style = 'color:maroon'> Total Records-   " & Session("max") & ", &nbsp; Class_Standard Wise </span></h2></center>"
                ElseIf Session("del1") = "2" Then
                    ch.InnerHtml = " <center><h2> Showing Deleted Students Details:   <span style = 'color:maroon'> Total Records-   " & Session("max") & ", &nbsp; Class_Standard Wise </span></h2></center>"

                End If

                'Session("dt") = dt
                'Session("query") = query
                'dt.Dispose()
                'sda.Dispose()

                'dim dv1 As New DataView(Session("dt"))
                'dv1.RowFilter = String.Format("Surname  Like   '%' + '" & TextBox1.Text.Trim() & "' + '%'")
                ' GridView2.DataSource = dv1
                ' GridView2.DataBind()
                ' End If
                conn.Close()

                ' Catch ex As SqlException
                ' MsgBox(ex.Message)
                'Finally
                conn.Dispose()
        '  End Try







    End Sub



    '  conn = New SqlConnection
    '  conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
    ' conn.Open()


    ' Dim ds As New DataSet
    REM check
    ' If (IsPostBack = True) Then
    ' Dim str8 As String = " Select * from CBSPS " 'order by Surname Asc"

    ' Session("query") = str8
    'query = "Select * from CBSPS  where (((Surname  LIKE  '%' + @Surname +'%'  ) or (Name_of_Student  LIKE  '%' + '" & TextBox1.Text.Trim() & "' + '%'  ) or (Phone_Number  LIKE  '%' + '" & TextBox1.Text.Trim() & "' + '%'  )) and (Class_Standard LIKE  '%' + '" & DropDownList1.Text.Trim() & "' + '%'))"

    '  com = New SqlCommand(Session("query"), conn)
    '  sda.SelectCommand = com
    '  sda.Fill(Session("dt"))

    '  GridView2.DataSource = Session("dt")
    '  GridView2.DataBind()
    ' sda.Dispose()
    'sda.Update(Session("dt"))
    ' conn.Close()




    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Session("index2") = 0   ' for table in page 3
        Session("sortcheck") = ""
        'If Session("user") = Nothing Then
        'Session.Clear()
        'Session.RemoveAll()
        'Session.Abandon()
        'Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1D))
        'Re'sponse.Cache.SetCacheability(HttpCacheability.NoCache)
        'Response.Cache.SetNoStore()
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "ClearHistory", "Clearhistory()", True)
        ' End If

        'Fun1()
        'Panel1.Update()
        Session("ddlb1") = DropDownList1.SelectedValue   'Response.Write(DropDownList1.SelectedValue)
        'Response.Redirect("Student_Details1.aspx")
        Response.Write("<script>window.location.href = 'Student_Details1.aspx' </script>")


    End Sub
    Protected Sub DropDownList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged
        Session("index2") = 0
        Session("sortcheck") = ""
        'Fun1()
        ' Panel1.Update()
        Session("ddlb2") = DropDownList2.SelectedValue
        'Response.Redirect("Student_Details1.aspx")

        Response.Write("<script>window.location.href = 'Student_Details1.aspx' </script>")
        ' Fun1()
        ' If Session("user") = Nothing Then
        'Session.Clear()
        'Session.RemoveAll()
        ' Session.Abandon()
        'Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1D))
        'Response.Cache.SetCacheability(HttpCacheability.NoCache)
        'Response.Cache.SetNoStore()
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "ClearHistory", "Clearhistory()", True)
        ' End If


    End Sub
    ' Private Sub Fun2()
    ' SortDirection() = "Desc"
    'Dim dv As New DataView(Session("dt"))
    'Dim dv As DataView = dt.AsDataView

    'dv.RowFilter = String.Format("Surname Like  '%' + '" & TextBox1.Text.Trim() & "' + '%' ")

    ' dv.Sort = "Surname"
    'dv.Sort = "Admission_Number"
    'dv.Sort = String.Format(no)

    'If GridView2.SortDirection = "Asc" Then
    ' GridView2.SortDirection = "Desc"
    'End If
    'dv.Sort = GridView2.SortDirection()
    'dim dv as new dataview(dt)
    'GridView2.Rowfilter=string.format(Surname LIKE '%'+ gupta +'%',)
    ' GridView2.datasource=dv
    ' Session("dt") = dt
    ' GridView2.DataSource = dv
    ' GridView2.DataBind()
    ' End Sub


    Private Sub GridView2_Sorting(sender As Object, e As GridViewSortEventArgs) Handles GridView2.Sorting

        Session("index2") = 0
        Dim dv As New DataView(Session("dt"))
        Session("dv") = dv
        Session("sort_expression1") = e.SortExpression()





        If Session("sort_expression1") = Session("sort_expression2") Then
            Session("sort_expression") = Session("sort_expression1")
            Session("sort_expression2") = ""
            Session("direction") = "DESC"
        ElseIf Session("direction") = Nothing And Session("sort_expression1") = "Class_Std" Then
            Session("direction") = "DESC"
            Session("sort_expression1") = e.SortExpression
        Else
            Session("sort_expression") = Session("sort_expression1")
            Session("sort_expression2") = Session("sort_expression1")
            Session("direction") = "ASC"

        End If



        ' Response.Write(direction)
        ' If Session("sort_expression") = Nothing Then
        ' Session("sort_expression") = "Class_Standard"
        'End If

        'Session("direction") = "ASC"
        'Session("sort_expression") = e.SortExpression
        Session("dv").Sort = String.Format(Session("sort_expression") + " " + Session("direction"))
        Session("sortcheck") = "1"

        '  Session("sort") = ""
        'fun4()
        '   Response.Write(Session("sort_expression"))
        ' If e.SortExpression <> "Class_Standard" Then
        'Response.Redirect("Student_Details1.aspx")
        Response.Write("<script>window.location.href = 'Student_Details1.aspx' </script>")
        ' End If
        ' Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1D))
        'Response.Cache.SetCacheability(HttpCacheability.NoCache)
        'Response.Cache.SetNoStore()
        'Dim dv As New DataView(dt)
        'Fun2()
        'Dim sortExpression As Object = Nothing
        ' dv.Sort = e.SortExpression + " " + e.SortDirection
        '  GridView2.DataSource = dv
        ' GridView2.DataBind()

    End Sub

    Private Sub logout()

        Session("app") = ""
        Session("app2") = ""
        Session("app3") = ""
        Session("app4") = ""
        Session("app5") = ""
        Session("user") = ""
        Session("sort_expression") = "Class_Std"
        Session("index") = Nothing
        Session("dv") = Nothing
        Session("direction") = "ASC"
        Session("sortcheck") = ""
        Session("dt") = Nothing
        Session("index2") = Nothing
        Session("view") = ""
        Session("viewdetail") = ""
        Session("color") = Nothing
        Session("ddlb1") = ""
        Session("ddlb2") = ""
        Session("txb1") = ""
        Session("forward2") = ""
        Session("forward1") = ""
        Session("backward1") = ""
        Session("backward2") = ""
        Session("logout") = ""
        Session("max") = Nothing
        Session("crendential") = ""
        Session("grid") = ""
        Session("default") = ""
        Session("logout2") = ""
        Session("edit5") = Nothing
        ' Session.Clear()
        'Session.Contents.RemoveAll()
        'Session.RemoveAll()
        FormsAuthentication.SignOut()
        'Session.Abandon()
        ' TextBox1_TextChanged(sender, e)
        'Response.Redirect("Default.aspx")
        ' Server.Transfer("Default.aspx")
        ' Response.Write("<script>window.location.href = 'Default.aspx'</script>")
        'System.Web.UI.ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "Script", "window.history.backward(1)", True)
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "script", "window.history.forward(1)", True)
        'Response.Write("<script> 'window.history.backward(1)' </script>")
        ' Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1D))
        ' Response.Cache.SetCacheability(HttpCacheability.NoCache)
        ' Response.Cache.SetNoStore()
        ' Page.ClientScript.RegisterStartupScript(Me.GetType(), "ClearHistory", "Clearhistory()", True)


    End Sub


    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call logout()
        Session("logout") = "1"
        Response.Write(Session("logout"))
        Response.Redirect("Student_Details1.aspx")

        ' Response.Write("<script>window.location.href = 'Student_Details1.aspx'</script>")


    End Sub



    'Private Sub Student_Details1_Init(sender As Object, e As EventArgs) Handles Me.Init
    'If Session("user") = Nothing Then
    'Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1))
    'Response.Cache.SetCacheability(HttpCacheability.NoCache)
    'Response.Cache.SetNoStore()
    ' Response.Redirect("Default.aspx")
    ' End If
    ' End Sub



    'Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    'Session("ddlb2") = DropDownList2.SelectedValue
    ' Session("ddlb1") = DropDownList1.SelectedValue
    'Session("txb1") = TextBox1.Text

    'Fun1()
    ' Response.Write("<script>window.location.href = 'Student_Details1.aspx' </script>")
    ' End Sub









    '<pages  enableEventValidation="false">  require code in web.config for following codes selection row in gridview


    Public Sub GridView2_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GridView2.RowDataBound
        ' i added this in web config: <pages  enableEventValidation="false" to excape error >
        ' it fires no of times of and change occurs in all rows
        If e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Attributes("onclick") = Page.ClientScript.GetPostBackClientHyperlink(GridView2, "Select$" & e.Row.RowIndex)
            e.Row.ToolTip = "CLICK TO SELECT THE ROW."
            e.Row.Attributes("style") = "cursor:pointer"

            e.Row.Attributes.Add("onmouseover", "this.originalstyle = this.style.backgroundColor;this.style.backgroundColor='orange';this.originalstyle1=this.style.color;this.style.color='white'")
            ' If e.Row.RowIndex = GridView2.SelectedIndex Then
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle; this.style.color= this.originalstyle1 ")




            ' If Session("view") = "1" Or Session("viewdetail") = "1" Then



            'highlighting the matched values
            'Dim p As String

            'Dim p1 As String ', p2, p3, p4 As Date
            '' If (Len(e.Row.Cells(8).Text.Trim()) = 0) And (Len(e.Row.Cells(8).Text.Trim()) = 0) And (Len(e.Row.Cells(42).Text.Trim()) = 0) And (Len(e.Row.Cells(45).Text.Trim()) = 0) Then
            'p1 = e.Row.Cells(8).Text.Trim()
            'p1 = p1.ToShortDateString
            'p2 = e.Row.Cells(42).Text
            'p2 = p2.ToShortDateString
            'p3 = e.Row.Cells(43).Text
            'p3 = p3.ToShortDateString
            'p4 = e.Row.Cells(45).Text
            'p4 = p4.ToShortDateString

            'e.Row.Cells(8).Text = p1         'dob
            'e.Row.Cells(42).Text = p2
            'e.Row.Cells(43).Text = p3
            'e.Row.Cells(45).Text = p4
            ' End If


            ' Response.Write(e.Row.Cells(9).Text)
            ' If (e.Row.Cells(9).Text = "&nbsp;") Or (e.Row.Cells(9).Text = "20") Then 'checking
            REM _____AGE CLACULATOR_____________________________________________________________
            'Dim age As String
            'Dim dd1, mm1, yy1, dd2, mm2, yy2 As Integer 'cd1, cm1, cy1 As Integer
            'Dim days, months, years, d2, ddi, m2, mdi, ydi As Integer

            'dd1 = Left(p1, 2)
            'mm1 = Mid(p1, 4, 2)
            'yy1 = Right(p1, 4)
            'dd2 = Left(GetDateTime(), 2)
            'mm2 = Mid(GetDateTime(), 4, 2)
            'yy2 = Mid(GetDateTime(), 7, 4)

            'ddi = dd2 - dd1
            'mdi = mm2 - mm1
            'ydi = yy2 - yy1
            'If ddi < 0 Then d2 = 1
            'If (mdi < 0) Or (mdi = 0 And ddi < 0) Then m2 = 1
            'days = System.DateTime.DaysInMonth(yy2, mm1) * d2 + ddi    'method t get days in a month
            'months = 12 * m2 + mdi - 1 * d2
            'years = ydi - 1 * m2
            'e.Row.Cells(9).Text = years & " Years,  " & months & " Months,  " & days & " Days"
            'age = e.Row.Cells(9).Text

            REM _____AGE CLACULATOR_____________________________________________________________

            '   changing color of highlighted searched texts: below coding changes the value in gridviews in textboex and 
            If Session("thispage") = "" Then
                For a = 2 To 20
                    e.Row.Cells(a).Text = Regex.Replace(e.Row.Cells(a).Text, TextBox1.Text.Trim(), Function(match As Match) String.Format("<span style = 'background-color:yellow'>{0}</span>", match.Value), RegexOptions.IgnoreCase)
                Next a
            End If


            ' If ("onmouseout", "this.style.backgroundColor='black';this.style.color= 'white') Then
            'e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#FFF7E7';this.style.color= '#8C4510'")
            ' e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='black';this.style.color= 'white'")
            ' End If
            ' e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#FFF7E7';this.style.color= '#8C4510'")
            ' Session("index") = e.Row.RowIndex
            ' If GridView2.SelectedIndex = e.Row.RowIndex Then
            'Session("color") = e.Row.BackColor
            'End If
            ' End If
            ' If Row.backcolor = Color.Yellow Then
            'Row.backcolor = Color.Blue
            'If e.Row.RowIndex = 7 Then

            'Response.Write(GridView2.SelectedIndex)
            ' End If




        End If

        ' Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1D))
        ' Response.Cache.SetCacheability(HttpCacheability.NoCache)
        ' Response.Cache.SetNoStore()
        'Color.FromName("Yellow")
    End Sub
    Public Function age(d As String) As String         'function returns a value while sub does not.

        If Session("IST") = Nothing Then Session("IST") = GetDateTime()
        Dim age1, day, month, year As String
        Dim dd1, mm1, yy1, dd2, mm2, yy2 As Integer 'cd1, cm1, cy1 As Integer
        Dim days, months, years, d2, ddi, m2, mdi, ydi As Integer
        dd1 = Left(d, 2)
        mm1 = Mid(d, 4, 2)
        yy1 = Mid(d, 7, 4)
        dd2 = Left(Session("IST"), 2)
        mm2 = Mid(Session("IST"), 4, 2)
        yy2 = Mid(Session("IST"), 7, 4)

        ddi = dd2 - dd1
        mdi = mm2 - mm1
        ydi = yy2 - yy1
        If ddi < 0 Then d2 = 1
        If (mdi < 0) Or (mdi = 0 And ddi < 0) Then m2 = 1


        days = System.DateTime.DaysInMonth(yy1, mm1) * d2 + ddi    'method t get days in a month


        months = 12 * m2 + mdi - 1 * d2
        years = ydi - 1 * m2
        If days < 10 Then
            day = "0" & days
        Else
            day = days.ToString
        End If
        If months < 10 Then
            month = "0" & months
        Else
            month = months.ToString
        End If
        If years < 10 Then
            year = "0" & years
        Else
            year = years.ToString
        End If

        age1 = year & " Years,  " & month & " Months,  " & day & " Days"
        Return age1

    End Function

    Protected Sub GridView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView2.SelectedIndexChanged
        Session("index") = GridView2.SelectedIndex
        Session("color") = GridView2.SelectedRow.BackColor
        'If Session("color") = Drawing.Color.Brown Then
        'Session("color") = Drawing.Color.FromName("#FFF7E7")
        ' Else
        'Session("color") = Drawing.Color.Brown
        ' End If
        'Response.Write(Session("color"))

        Session("index2") = Convert.ToInt32(Session("index"))
        'Response.Write(GridView2.SelectedIndex)
        'Session("Row") = GridView2.SelectedRow
        'Response.Write(Session("index"))
        'Response.Write(Session("color"))
        ' Response.Redirect("Student_Details1.aspx")

        Response.Write("<script>window.location.href = 'Student_Details1.aspx'</script>")

        ' Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1D))
        'Response.Cache.SetCacheability(HttpCacheability.NoCache)
        ' Response.Cache.SetNoStore()
    End Sub
    Private Sub fun5()
        Try
            If Session("grid") = "" Then

                Dim row As GridViewRow
                row = GridView2.Rows(Convert.ToInt32(Session("index2")))
                'Session("row") = row
                Session("rollno") = row.Cells(1).Text
                Session("name1") = row.Cells(2).Text
                Session("surname") = row.Cells(3).Text
                Session("gender") = row.Cells(4).Text
                Session("class") = row.Cells(5).Text
                Session("section") = row.Cells(6).Text
                Session("Fphone") = row.Cells(7).Text
                Session("dob") = row.Cells(8).Text
                Session("age") = row.Cells(9).Text
                Session("sssm") = row.Cells(10).Text
                Session("admsn") = row.Cells(11).Text
                Session("aadhar") = row.Cells(12).Text
                Session("Nmother") = row.Cells(13).Text
                Session("Nfather") = row.Cells(14).Text
                Session("categ") = row.Cells(15).Text
                Session("Laddress") = row.Cells(16).Text
                Session("town") = row.Cells(17).Text
                Session("state") = row.Cells(18).Text
                Session("pin") = row.Cells(19).Text
                Session("Mphone") = row.Cells(20).Text
                Session("Ophone") = row.Cells(21).Text
                Session("Nguardian") = row.Cells(22).Text
                Session("Rguardian") = row.Cells(23).Text
                Session("Gphone") = row.Cells(24).Text
                Session("email") = row.Cells(25).Text
                Session("Paddress") = row.Cells(26).Text
                Session("city") = row.Cells(27).Text
                Session("province") = row.Cells(28).Text
                Session("zip") = row.Cells(29).Text
                Session("Omother") = row.Cells(30).Text
                Session("Ofather") = row.Cells(31).Text
                Session("bro") = row.Cells(32).Text
                Session("sis") = row.Cells(33).Text
                Session("height") = row.Cells(34).Text
                Session("weight") = row.Cells(35).Text
                Session("AcSkill") = row.Cells(36).Text
                Session("oskill") = row.Cells(37).Text
                Session("hobbies") = row.Cells(38).Text
                Session("DiAbled") = row.Cells(39).Text
                Session("KindAbility") = row.Cells(40).Text
                Session("EnrlNo") = row.Cells(41).Text
                Session("DateEnroll") = row.Cells(42).Text
                Session("DateLeaveLast") = row.Cells(43).Text
                Session("LastClass") = row.Cells(44).Text
                Session("DateLeaveThis") = row.Cells(45).Text
                Session("country") = row.Cells(46).Text
                'Session("sortcheck") = ""


                ' Session("index2") = -1

                ' Session("view") = "1"
                Session("forward2") = "1"    ' to go to next page only if view button excute fully(forward button)
                ' ElseIf Session("grid") = "1" Then
                'Session("index2") = vbNull
                ' 'Session("grid") = "1"

                'Session("forward2") = "1"
            ElseIf Session("grid") = "1" Then
                ' Dim row As GridViewRow   ' peculiar behaviour if i remove the comment, value of session does not change.
                'Row = GridView2.Rows(Convert.ToInt32(Session("index2")))
                'Session("row") = row
                Session("rollno") = ""
                Session("name1") = ""
                Session("surname") = ""
                Session("gender") = ""
                Session("class") = ""
                Session("section") = ""
                Session("Fphone") = ""
                Session("dob") = ""
                Session("age") = ""
                Session("sssm") = ""
                Session("admsn") = ""
                Session("aadhar") = ""
                Session("Nmother") = ""
                Session("Nfather") = ""
                Session("categ") = ""
                Session("Laddress") = ""
                Session("town") = ""
                Session("state") = ""
                Session("pin") = ""
                Session("Mphone") = ""
                Session("Ophone") = ""
                Session("Nguardian") = ""
                Session("Rguardian") = ""
                Session("Gphone") = ""
                Session("email") = ""
                Session("Paddress") = ""
                Session("city") = ""
                Session("province") = ""
                Session("zip") = ""
                Session("Omother") = ""
                Session("Ofather") = ""
                Session("bro") = ""
                Session("sis") = ""
                Session("height") = ""
                Session("weight") = ""
                Session("AcSkill") = ""
                Session("oskill") = ""
                Session("hobbies") = ""
                Session("DiAbled") = ""
                Session("KindAbility") = ""
                Session("EnrlNo") = ""
                Session("DateEnroll") = ""
                Session("DateLeaveLast") = ""
                Session("LastClass") = ""
                Session("DateLeaveThis") = ""
                Session("country") = ""
                'Session("sortcheck") = ""


                ' Session("index2") = -1

                ' Session("view") = "1"
                Session("forward2") = "1"



            End If





        Catch ex As Exception
            Response.Write("<script> alert ('Error Occured'); window.location.href = 'Default.aspx'</script>")

        End Try

    End Sub
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Session("Grid") <> "2" Then
            Session("thispage") = "1"

            ' Try
            If Session("index3") = "1" Then Session("index2") = 0



            Session("view") = "1"
            '  Session("forward2") = "1"    ' to go to next page only if view button excute fully(forward button)



            '  Catch ex As Exception
            ' Response.Write("<script> alert ('Error Occured'); window.location.href = 'Default.aspx'</script>")

            '  End Try


            'Session("test") = "test3"
            'Response.Redirect("Student_Details1.aspx")  'checking

            Response.Write("<script>window.location.href = 'Student_Details1.aspx'</script>")
        End If
        ' Session("test") = "test4"
        ' Response.Write(GridView2.SelectedIndex)
        ' conn = New SqlConnection
        '  conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        ' Try
        'conn.Open()
        'query = "Select * from cbsps"
        'com = New SqlCommand(query, conn)
        'rd = com.ExecuteReader
        'Dim count As Integer
        'count = 1
        'While rd.Read
        'count = count + 1
        'REM   DropDownList1.SelectedValue = rd("Session")
        ' Session("app4") = rd("Session")
        'REM DropDownList1.Enabled = False
        ' Button3.Enabled = False
        'Label8.Text = Session("app4")

        'End While



        '  Catch ex As SqlException
        ' Response.Write("Error Occured")
        '  Finally
        'conn.Dispose()

        '  End Try


        ' Response.Write("<script>window.location.href = 'ViewDetails1.aspx' </script>")







    End Sub
    Private Sub fun3()


        'GridView2.SelectedIndex = Session("Index")
        For Each Row As GridViewRow In GridView2.Rows


            ' Row = Session("Row")
            If Session("color") <> Color.Brown And Row.RowIndex = Convert.ToInt32(Session("index")) Then  'And row.ForeColor <> Color.FromName("white") Then
                ' Response.Write(Convert.ToInt32(Session("index")))
                Row.BackColor = ColorTranslator.FromHtml("Brown") REM value of session("index2") may not = 0 but 1st row gets automatically selected ...
                REM .....    each  time whenwver the  page loads and session("index")= 0.
                Row.ForeColor = ColorTranslator.FromHtml("white")
                If Convert.ToInt32(Session("index")) = 0 Then
                    Session("index3") = "1"
                Else
                    Session("index3") = ""
                End If
                ' Response.Write("1204")
                'Session("Color") = Color.Brown
                'Row.BackColor = Color.Brown
                ' Row.ForeColor = Color.White

                Row.Font.Bold = True
                Row.ToolTip = "CLICK TO UNSELECT THE ROW." '            End If String.Empty
                Session("index") = 0   ' to unselect a row and index disposing
                ' Session("color") = ColorTranslator.FromHtml("Brown")
                ' ch1.InnerHtml = " <center><h2>  <span style = 'color:maroon'>The Row is Selected!!</span></h2></center>"
            ElseIf Session("color") = Color.Brown And Row.RowIndex = Convert.ToInt32(Session("index")) Then  'And row.ForeColor = Color.FromName("white") Then
                Row.BackColor = ColorTranslator.FromHtml("#FFF7E7")
                Row.ForeColor = ColorTranslator.FromHtml("#8C4510")
                'row.ForeColor = Color.FromName("#8C4510")
                ' Color.FromName("#FFF7E7")
                ' Response.Write("123")
                ' Session("Color") = Color.FromName("#FFF7E7")
                ' Row.BackColor = Color.FromName("#FFF7E7")
                ' Row.ForeColor = Color.FromName("#8C4510")
                Row.Font.Bold = False
                Row.ToolTip = "CLICK TO SELECT THE ROW."
                Session("index") = 0    ' to unselect a row and index disposing
                Session("index2") = 0
                Session("color") = ColorTranslator.FromHtml("#FFF7E7")  ' to regain brown color of 1st row on refresh or back and ...
                ' ...not allowing index2 to become 0

            Else
                Row.BackColor = ColorTranslator.FromHtml("#FFF7E7")
                Row.ForeColor = ColorTranslator.FromHtml("#8C4510")
                Row.Font.Bold = False
                Row.ToolTip = "CLICK TO SELECT THE ROW."
            End If
            ' Row.BackColor = ColorTranslator.FromHtml("Brown")
            '#FFFFFF
            '#8C4510'
            'this.originalstyle='#FFF7E7';
        Next

    End Sub
    Private Sub fun4()

        'Session("dv").Sort = String.Format(Session("sort_expression") + " " + Session("direction"))
        Dim dv As New DataView(Session("dt"))
        Session("dv") = dv
        Session("dv").Sort = String.Format(Session("sort_expression") + " " + Session("direction"))


        GridView2.DataSource = Session("dv")
        GridView2.DataBind()

        'If Session("direction") = "DESC" Then

        '    Session("direction") = "ASC"

        'ElseIf Session("direction") = "ASC" Then

        '    Session("direction") = "DESC"


        'End If


        'Session("sortcheck") = "2"
        ' Session("select") = ""
        If DropDownList1.Text = "" And DropDownList1.Text = "" And TextBox1.Text = "" Then
            ch.InnerHtml = " <center><h2> <u style = 'color:brown'>Showing Students Details</u> &nbsp; Sorted by:<span style = 'color:maroon'>   " + Session("sort_expression") + "    </span></h2></center>"
        Else
            ch.InnerHtml = " <center><h2> Search Results For &nbsp  <span style = 'color:brown'><u>" + Session("txb1") + "</u>, &nbsp Class: <u>" + Session("ddlb1") + "</u>, &nbsp Section: <u>" + Session("ddlb2") + "</u> </span> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Sorted by:<span style = 'color:maroon'>   " + Session("sort_expression") + "  </span></h2></center>"
        End If
        'Fun1()
        ' Response.Write(e.SortExpression)

    End Sub
    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If Session("forward2") = "1" Then
            Session("forward21") = "1"
        End If
        '  Response.Redirect("Student_Details1.aspx")

        Response.Write("<script>window.location.href = 'Student_Details1.aspx'</script>")

    End Sub
    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Session("backward1") = "1"
        ' Response.Redirect("Student_Details1.aspx")

        Response.Write("<script>window.location.href = 'Student_Details1.aspx'</script>")
    End Sub
    Public Shared Function CheckForInternetConnection() As String

        Try
            Dim client = New WebClientExtended
            REM Dim stream2 As IO.Stream
            '    'stream1 = client.OpenRead("http:/www.nist.com")

            Dim stream2 = client.OpenRead("http://www.youtube.com/")

            '    'stream3 = client.OpenRead("http:/www.rbi.org.in")
            'If stream2.CanTimeout Then 'Or stream3.CanRead Then

            Return " ONLINE"

            'Else
            '    Return " OFFLINE"
            'End If

            '    ' stream2 = client.OpenRead("http:/\/www.nist.gov")
            '    'client.Timeout = 10000

            '    'Dim w = Net.WebRequest.Create("http:/\/www.microsoft.com")
            '    ' Dim r As WebResponse = w.GetResponse()
            '    'w.Timeout = 10000

            '    'r = w.GetResponse()
            '    ' If r.ToString <> "" Then 'Or stream2.CanRead Then
            '    'stream2.ReadTimeout = 1000



        Catch
            Return " OFFLINE"

        End Try

    End Function


    Public Shared Function GetDateTime() As String

        Try
            Dim dateTime As DateTime = DateTime.MinValue
            Dim request As System.Net.HttpWebRequest = DirectCast(System.Net.WebRequest.Create("http://www.microsoft.com/"), System.Net.HttpWebRequest)
            'request.Timeout = 25000   if used create problem
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
            Return dateTime.ToString("dd-MM-yyyy hh:mm:ss tt") + " ONLINE"
        Catch


            REM    dtt1 = DateTime.Now.ToString '("dd-MM-yyyy  hh:mm:ss")
            'Dim f As String
            'f = " offline"
            'Dim f1 As String = dtt1.ToString + f
            ''Response.Write("RUNNING OFFLINE-")
            ''Response.Write(dtt)
            REM Return dtt1 '+ " OFFLINE"
            Return Date.Now.ToString("dd-MM-yyyy hh:mm:ss tt") + " OFFLINE"



        End Try




    End Function
    Private Function func1(ss1 As String) As String
        Dim p As String
        p = ss1
        Return p
    End Function


    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Timer1.Enabled = False

        ' updating age and regaing all of the page as it is
        If Session("cursession") <> "" Then
            Call fun10()
            ' Fun1()
            ' Dim dv As New DataView(Session("dt"))
            ' Session("dv") = dv
            'Session("dv").Sort = String.Format(Session("sort_expression") + " " + Session("direction"))
            'recently changed above 4 lines coz of repetition in fun 4
            Response.Write("<script>window.location.href = 'Student_Details1.aspx' </script>")
        End If
        ' Timer1.Enabled = True

    End Sub



    'Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    'If Right(GetDateTime(), 6) = "ONLINE" Then
    '    'Label2.Text = GetDateTime().ToString
    '    ' Else


    '    Label2.Text = CheckForInternetConnection()
    '    If Right(Label2.Text, 6) = "ONLINE" Then
    '        Label2.ForeColor = ColorTranslator.FromHtml("#008000")
    '        Session("wat") = "1"
    '        Timer1.Enabled = False
    '        Timer2.Enabled = True


    '    Else
    '        Label2.ForeColor = ColorTranslator.FromHtml("#FF0000")
    '        '    'Label3.ForeColor = ColorTranslator.FromHtml("#0000FF")
    '        Session("wat") = "2"

    '        Timer1.Enabled = False
    '        Timer2.Enabled = True
    '        '    'Timer2.Enabled = False
    '    End If

    '    ' Else
    '    ' Label2.Text = GetDateTime()

    '    'Label2.Text = CheckForInternetConnection()
    '    'Label2.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm:ss tt") + " OFFLINE"
    '    'End If
    'End Sub

    'Protected Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.tick
    '    Label3.Text = GetDateTime()


    '    If Right(Label3.Text, 7) = "OFFLINE" Then 'And Session("wat") = "1" Then
    '        'Label3.Text = GetDateTime()
    '        Label3.ForeColor = ColorTranslator.FromHtml("#FF0000")

    '    ElseIf Right(Label3.Text, 6) = "ONLINE" Then 'And Session("wat") = "2" Then
    '        'Label3.Text = GetDateTime()
    '        Label3.ForeColor = ColorTranslator.FromHtml("#008000")

    '    End If


    '    'If Right(Label2.Text, 6) = "ONLINE" Then
    '    '    Label2.ForeColor = ColorTranslator.FromHtml("#008000")

    '    'Else
    '    '    Label2.ForeColor = ColorTranslator.FromHtml("#FF0000")
    '    'End If
    '    ' Else
    '    ' Label2.Text = GetDateTime()

    '    'Label2.Text = CheckForInternetConnection()
    '    'Label2.Text = DateTime.Now.ToString("dd/MM/yyyy  hh:mm:ss tt") + " OFFLINE"
    '    'End If
    'End Sub


    Protected Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Session("time1")
        Button9.Text = CheckForInternetConnection()

        If Button9.Text.Trim() = "ONLINE" Then
            Sysdate1()

        End If
        'Response.Write("<script>window.location.href = 'Student_Details1.aspx' </script>")
        ' If Button9.Text = " ONLINE" Then Session("time1") = "1"
    End Sub

    Private Sub Sysdate1() 'As Date
        Dim y As Integer = Mid(GetDateTime(), 7, 4)
        Dim m As Integer = Mid(GetDateTime(), 4, 2)
        Dim d As Integer = Left(GetDateTime(), 2)
        Dim d1 As DateTime = Mid(GetDateTime(), 12, 11)
        'Dim d1 As
        'Microsoft.VisualBasic.TimeOfDay = d1 'Your time...
        ' Microsoft.VisualBasic.DateString = New Date(y, m, d) 'The date...


        ' Dim d1 As DateTime
        ' d1 = "22:30:00"



        TimeOfDay = d1
        Today = New Date(y, m, d) 'The date...'
        'Return Today
        'You might have to run as Administrator...?
        'Return Today + d1

    End Sub

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If Mid(Label2.Text, 19, 1) = 0 Then
        '    Button9.Text = "Refresh Connection Status"
        'end End If

        Label2.Text = Date.Now.ToString("dd/MM/yyyy  hh:mm:ss tt")

        If Mid(Label2.Text, 19, 2) Mod 15 = 0 Then
            Button9.Text = "Check Internet Connection"

        End If
        '  DropDownList1.Attributes("onclick") = "javascript: document.body.style.cursor = 'wait';"
    End Sub
    'Protected Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
    '    ' If Label3.Text = "Waiting..." Then
    '    Timer1.Enabled = True
    '    Label3.Text = CheckForInternetConnection()
    '    'If Label3.Text = " ONLINE" Then

    '    Timer3.Enabled = False
    '    '    Timer3.Interval = 1000
    '    '    Timer1.Interval = 200
    '    'Else
    '    '    Label3.Text = " OFFLINE"
    '    '    Timer3.Interval = 1000
    '    '    Timer1.Interval = 200
    '    'End If




    'End Sub

    Protected Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click


    End Sub


    Protected Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Session("del1") = "2"
        Response.Redirect("Student_Details1.aspx")
    End Sub

    Private Sub deleted()

        'If Session("sort_expression") = Nothing Then
        'Session("sort_expression") = "Class_Standard"
        ' Session("Sort") = ""
        'If Session("Sort") = "1" Then Session("Sort") = ""
        '  End If
        'selected row variable to unselected value


        TextBox1.Text = Session("txb1")

        'Session("query") = query

        'Try
        Dim dt As New DataTable()
        Session("dt") = dt
        conn = New SqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        conn.Open()
        Dim sda As New SqlDataAdapter
        'Dim SortExpression = "Roll_No."
        ' Dim ds As New DataSet
        REM check
        ' If (IsPostBack = False) Then
        Dim ttb1 = "'%'+'" & TextBox1.Text.Trim() & "'+'%'"
        Dim ddd1 = "'%'+'" & DropDownList1.Text.Trim() & "'+'%'"
        Dim ddd2 = "'%'+'" & DropDownList2.Text.Trim() & "'+'%'"
        ' need to include other options as search option from table fields



        Dim session_name3(3) As SqlParameter
        session_name3(0) = New SqlParameter("@para1", SqlDbType.NVarChar)
        session_name3(0).Value = "Recycle_" + Session("cursession")
        session_name3(1) = New SqlParameter("@para2", SqlDbType.VarChar)
        session_name3(1).Value = ttb1
        session_name3(2) = New SqlParameter("@para3", SqlDbType.NVarChar)
        session_name3(2).Value = ddd1
        session_name3(3) = New SqlParameter("@para4", SqlDbType.NVarChar)
        session_name3(3).Value = ddd2


        'Dim str1 As String = "Select * from CBSPS  where (((Surname Like  '%' + @Sirname + '%'  ) or"
        'Dim str2 As String = " (Name_of_Student  LIKE  '%' + '" & TextBox1.Text.Trim() & "' + '%'  )"
        'Dim str6 As String = " Or (Name_of_Mother  LIKE  '%' + '" & TextBox1.Text.Trim() & "' + '%'  )"
        'Dim str7 As String = " Or (Name_of_Father  LIKE  '%' + '" & TextBox1.Text.Trim() & "' + '%'  )"
        'Dim str3 As String = " Or (Phone_No_Father  Like  '%' + '" & TextBox1.Text.Trim() & "' + '%'  ))"
        'Dim str4 As String = " And (Class_Std Like  '%' + '" & DropDownList1.Text.Trim() & "' + '%')"
        REM Dim str11 As String = " And (Class_Standard Like  '%' + '" & DropDownList3.Text.Trim() & "' + '%')"
        'Dim str5 As String = " And (Section Like  '%' + '" & DropDownList2.Text.Trim() & "' + '%'))"
        REM Dim str9 As String = "order by" + Session(sort_expression) + "Asc"
        'query = str1 + str2 + str6 + str7 + str3 + str4 + str5 + "order by Class_Std Asc"
        REM query = "Select * from CBSPS " ' where (((Surname  LIKE  '%' + @Surname +'%'  ) or (Name_of_Student  LIKE  '%' + '" & TextBox1.Text.Trim() & "' + '%'  ) or (Phone_Number  LIKE  '%' + '" & TextBox1.Text.Trim() & "' + '%'  )) and (Class_Standard LIKE  '%' + '" & DropDownList1.Text.Trim() & "' + '%'))"
        'com = New SqlCommand(query, conn)

        Dim com As New SqlCommand
        com.Connection = conn
        com.CommandType = CommandType.StoredProcedure
        com.CommandText = "Deleted1"
        com.Parameters.AddRange(session_name3)
        'com = New SqlCommand(query, conn)
        'com.Parameters.Add(vari1)
        'com.Parameters.AddWithValue("@Sirname", TextBox1.Text.Trim())

        'com.Parameters.AddWithValue("@Class_Standard", DropDownList1.Text.Trim())
        'com.CommandText = query
        'com.Connection = conn
        'rd = com.ExecuteReader
        ' com.ExecuteNonQuery()


        sda.SelectCommand = com
        sda.Fill(Session("dt"))
        GridView2.DataSource = Session("dt") '
        GridView2.DataBind()

        'Session("GridData") = Session("dt")
        'sda.Dispose()
        'Panel1.Update()
        Session("max3") = GridView2.Rows.Count
        Session("dt").Clear()
        Session("grid") = ""        ' to check

        'sda.Update(dt)
        If sda.Fill(Session("dt")) = Nothing Then
            Session("grid") = "1"         ' to check all following
            '  Dim sp As String = Space(20)
            ch.InnerHtml = " <center> <h1> No Result!</h1> </center>"
        ElseIf (Session("txb1") <> "" Or Session("ddlb1") <> "" Or Session("ddlb2") <> "") Then
            'Response.Write()
            ch.InnerHtml = " <center><h2> Search Results For &nbsp  <span style = 'color:brown'><u> " + Session("txb1") + " </u>, &nbsp Class: <u>" + Session("ddlb1") + "</u>, &nbsp Section: <u>" + Session("ddlb2") + ",</u> &nbsp; </span>  Total Records-   " & Session("max") & ",&nbsp&nbsp&nbsp&nbsp&nbspSorted by:<span style = 'color:maroon'>   Class_Standard  </span></h2></center>"
        Else
            ch.InnerHtml = " <center><h2> Showing Deleted Students Details:   <span style = 'color:maroon'> Total Records-   " & Session("max") & ", &nbsp; Class_Standard Wise </span></h2></center>"

        End If

        'Session("dt") = dt
        'Session("query") = query
        'dt.Dispose()
        'sda.Dispose()

        'dim dv1 As New DataView(Session("dt"))
        'dv1.RowFilter = String.Format("Surname  Like   '%' + '" & TextBox1.Text.Trim() & "' + '%'")
        ' GridView2.DataSource = dv1
        ' GridView2.DataBind()
        ' End If
        conn.Close()

        ' Catch ex As SqlException
        ' MsgBox(ex.Message)
        'Finally
        conn.Dispose()
        '  End Try
    End Sub
    Protected Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Session("del1") = Nothing
        Response.Redirect("Student_Details1.aspx")
    End Sub
    Protected Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Response.Redirect("Fee_Master1.aspx")
    End Sub
    Protected Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click


        Response.Redirect("Fee_Details1.aspx")

    End Sub
End Class



Public Class WebClientExtended  '  to get  timeout while requesig for connection  online
    Inherits WebClient
    Public Property Timeout() As Integer
        Get
            Return m_Timeout
        End Get
        Set(value As Integer)
            m_Timeout = 3000
        End Set
    End Property
    Private m_Timeout As Integer

    Protected Overrides Function GetWebRequest(address As Uri) As WebRequest
        Dim request = MyBase.GetWebRequest(address)
        request.Timeout = 3000
        Return request
    End Function
End Class
Public Class gv
    Inherits Student_Details1
End Class