Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web.Configuration
Imports System.Data
Imports System.Text.RegularExpressions
Imports System.Web.UI.WebControls
Partial Class Fee_Master1
    Inherits System.Web.UI.Page
    Dim conn As SqlConnection
    Dim com As SqlCommand
    Dim rd As SqlDataReader
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Session("TBValue") = dlistclass.SelectedValue
        If (IsPostBack = False) Then
            dlistclass.Items.Add("")
            dlistclass.Items.Add("Nursery")
            dlistclass.Items.Add("LKG")
            dlistclass.Items.Add("UKG")

            For k = 1 To 12
                dlistclass.Items.Add(k)
            Next





            dinstal.Items.Add("")
            dinstal.Items.Add("Monthly")
            dinstal.Items.Add("Quarterly")
            dinstal.Items.Add("Half Yearly")

            ddiscount1.Items.Add("")
            ddiscount1.Items.Add("RTE")
            ddiscount1.Items.Add("Minority")
            ddiscount2.Items.Add("")
            ddiscount2.Items.Add("RTE")
            ddiscount2.Items.Add("Minority")
            If Session("Fee_Updated") = "1" Then
                ch2.InnerHtml = " <center> <h2> Success! Fee Structure Updated.</h2> </center>"
                Session("Fee_Updated") = Nothing

            End If
            Call Fun12()



        End If

    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Response.Write("<script>window.location.href = 'Password_1_Page_3.aspx' </script>")
        Try
            conn = New SqlConnection
            Dim com As New SqlCommand

            conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString

            conn.Open()
            Dim query As String

            query = "select * from Admin1 where Password='" & TextBox24.Text & "'"
            com = New SqlCommand(query, conn)
            rd = com.ExecuteReader
            Dim count As Integer
            count = 0
            While rd.Read
                count = count + 1

            End While

            If count = 1 And dlistclass.SelectedValue <> "" Then
                Session("Class_Std") = "1"
                ' If Session("user") = Nothing Then
                'not in codingDim sc As String = "<script> alert ('session expired'); window.location.href = 'Default.aspx'</script>"
                ' Dim sc As String = "<script> window.location.href = 'Default.aspx'</script>"
                'Response.Write(sc)
                'End If
                ' consider this later ie  to expire the page if session ha ended
                ' ElseIf TextBox24.Text <> "" Then

                ' ch2.InnerHtml = " <center> <h2> Incorrect Password!!!</h2> </center>"

                ' ElseIf TextBox24.Text = "" Then
                '  ch2.InnerHtml = " <center> <h2> Enter The Password!!!</h2> </center>"
            Else
                ch2.InnerHtml = " <center> <h2> Select the Class and Enter the Correct Password!</h2> </center>"

            End If



            conn.Close()




            ' Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1))
            ' Response.Cache.SetCacheability(HttpCacheability.NoCache)
            'Response.Cache.SetNoStore()
            If Session("Class_Std") = "1" Then

                Session("Class_Std") = Nothing
                Dim x As Integer
                x = Val(TextBox2.Text.Trim()) + Val(TextBox5.Text.Trim()) + Val(TextBox6.Text.Trim()) + Val(TextBox7.Text.Trim()) + Val(TextBox8.Text.Trim())
                x = x + Val(TextBox9.Text.Trim()) + Val(TextBox10.Text.Trim()) + Val(TextBox14.Text.Trim()) + Val(TextBox15.Text.Trim()) + Val(TextBox16.Text.Trim())
                x = x + Val(TextBox1.Text.Trim()) + Val(TextBox17.Text.Trim())
                Label8.Text = x   'total ffee  below is other fee
                TextBox25.Text = x - Val(TextBox2.Text) - Val(TextBox14.Text) - Val(TextBox17.Text)

                conn = New SqlConnection

                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                '  Dim query As String
                Dim lit(17) As SqlParameter
                lit(0) = New SqlParameter("@vari15", SqlDbType.NVarChar)
                lit(0).Value = "FeeMaster_" + Session("cursession")
                'lit(15) = New SqlParameter("@vari16", SqlDbType.NVarChar)
                ' lit(15).Value = "''"
                lit(1) = New SqlParameter("@vari1", SqlDbType.NVarChar)
                lit(1).Value = "'" & dlistclass.Text.Trim() & "'"
                lit(2) = New SqlParameter("@vari2", SqlDbType.NVarChar)
                lit(2).Value = "'" & TextBox14.Text.Trim() & "'"
                lit(3) = New SqlParameter("@vari3", SqlDbType.NVarChar)
                lit(3).Value = "'" & TextBox2.Text.Trim() & "'"

                lit(4) = New SqlParameter("@vari4", SqlDbType.NVarChar)
                lit(4).Value = "'" & TextBox5.Text.Trim() & "'"

                lit(5) = New SqlParameter("@vari5", SqlDbType.NVarChar)
                lit(5).Value = "'" & TextBox6.Text.Trim() & "'"

                lit(6) = New SqlParameter("@vari6", SqlDbType.NVarChar)
                lit(6).Value = "'" & TextBox7.Text.Trim() & "'"

                lit(7) = New SqlParameter("@vari7", SqlDbType.NVarChar)
                lit(7).Value = "'" & TextBox15.Text.Trim() & "'"

                lit(8) = New SqlParameter("@vari8", SqlDbType.NVarChar)
                lit(8).Value = "'" & TextBox8.Text.Trim() & "'"

                lit(9) = New SqlParameter("@vari9", SqlDbType.NVarChar)
                lit(9).Value = "'" & TextBox9.Text.Trim() & "'"

                lit(10) = New SqlParameter("@vari10", SqlDbType.NVarChar)
                lit(10).Value = "'" & TextBox10.Text.Trim() & "'"

                lit(11) = New SqlParameter("@vari11", SqlDbType.NVarChar)
                lit(11).Value = "'" & TextBox16.Text.Trim() & "'"

                lit(12) = New SqlParameter("@vari12", SqlDbType.NVarChar)
                lit(12).Value = "'" & TextBox11.Text.Trim() & "'"

                lit(13) = New SqlParameter("@vari13", SqlDbType.VarChar)
                lit(13).Value = "'" & dinstal.Text.Trim() & "'"

                lit(14) = New SqlParameter("@vari14", SqlDbType.NVarChar)
                lit(14).Value = "'" & TextBox1.Text.Trim() & "'"
                lit(16) = New SqlParameter("@vari17", SqlDbType.NVarChar)
                lit(16).Value = "'" & Label8.Text.Trim() & "'"
                lit(17) = New SqlParameter("@vari18", SqlDbType.NVarChar)
                lit(17).Value = "'" & TextBox17.Text.Trim() & "'"
                lit(15) = New SqlParameter("@vari19", SqlDbType.NVarChar)
                lit(15).Value = "'" & TextBox25.Text.Trim() & "'"




                'query = "insert into  (Session, DateTime) values ('" & Session("app") & "', '" & dt11 & "')"

                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "fee_master"
                com.Parameters.AddRange(lit)
                rd = com.ExecuteReader
                rd.Read()
                rd.Close()
                com.Parameters.Clear()
                conn.Close()
                conn.Dispose()

                Session("Fee_Updated") = "1"
                Response.Redirect("Fee_Master1.aspx")

            End If
            'End If


            REM Response.Redirect("Default.aspx")



        Catch ex As SqlException
            MsgBox(Left(ex.ToString, 200))  ' Response.Write("Error")
        Finally
            conn.Dispose()

        End Try




        'Response.Write("<script>window.location.href = 'Fee_Master1.aspx' </script>")
        'rd = com.ExecuteReader
        '  Session("app") = ""



    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Fee_Master1.aspx")

    End Sub

    Private Sub Fun12()   ' working on fun12 and auto post back of list box 

        '  TextBox1.Text = Session("txb1")

        'Session("query") = query

        'Try
        Dim dt0 As New DataTable()
        Session("dt0") = dt0
        conn = New SqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        conn.Open()
        Dim sda As New SqlDataAdapter
        'Dim SortExpression = "Roll_No."
        ' Dim ds As New DataSet
        REM check
        ' If (IsPostBack = False) Then
        Dim tb1 = "'%'+'" & dlistclass.Text.Trim() & "'+'%'"
        'Dim dd1 = "'%'+'" & DropDownList1.Text.Trim() & "'+'%'"
        'Dim dd2 = "'%'+'" & DropDownList2.Text.Trim() & "'+'%'"
        ' need to include other options as search option from table fields
        'Dim tb1 = "'" & dlistclass.Text.Trim() & "'"

        Dim session_name(1) As SqlParameter
        session_name(0) = New SqlParameter("@para1", SqlDbType.NVarChar)
        'If Session("del1") = Nothing Then
        session_name(0).Value = "FeeMaster_" + Session("cursession")
        ' ElseIf Session("del1") = "2" Then
        'session_name(0).Value = "Recycle_" + Session("cursession")
        'End If
        session_name(1) = New SqlParameter("@para2", SqlDbType.NVarChar)
        session_name(1).Value = tb1
        'session_name(2) = New SqlParameter("@para3", SqlDbType.NVarChar)
        ' session_name(2).Value = dd1
        ' session_name(3) = New SqlParameter("@para4", SqlDbType.NVarChar)
        ' session_name(3).Value = dd2



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
        com.CommandText = "FeeStruc1"
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
        sda.Fill(Session("dt0"))
        GridView1.DataSource = Session("dt0") '
        GridView1.DataBind() '

        Session("dt0").Clear()
        conn.Close()

        ' Catch ex As SqlException
        ' MsgBox(ex.Message)
        'Finally
        conn.Dispose()

    End Sub



    Protected Sub dlistclass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dlistclass.SelectedIndexChanged
        ' showing fee structure detail in grid view when value changed in list box 
        ' to create change in character type or int type to get proper sort
        ' getting value in form same as gridview first row

        'TextBox1.Text = Session("txb1")

        'Session("query") = query

        dlistclass.SelectedValue = Session("TBValue")
        'Try
        ch2.InnerHtml = " <center> <h2> </h2> </center>"

        Dim dt0 As New DataTable()
        Session("dt0") = dt0
        conn = New SqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        conn.Open()
        Dim sda As New SqlDataAdapter
        'Dim SortExpression = "Roll_No."
        ' Dim ds As New DataSet
        REM check
        ' If (IsPostBack = False) Then
        Dim tb1 = "'%'+'" & dlistclass.Text.Trim() & "'+'%'"
        Dim tb2 = "'" & dlistclass.Text.Trim() & "'"

        'Dim dd1 = "'%'+'" & DropDownList1.Text.Trim() & "'+'%'"
        'Dim dd2 = "'%'+'" & DropDownList2.Text.Trim() & "'+'%'"
        ' need to include other options as search option from table fields
        'Dim tb1 = "'" & dlistclass.Text.Trim() & "'"

        Dim session_name(1) As SqlParameter
        session_name(0) = New SqlParameter("@para1", SqlDbType.NVarChar)
        'If Session("del1") = Nothing Then
        session_name(0).Value = "FeeMaster_" + Session("cursession")
        ' ElseIf Session("del1") = "2" Then
        'session_name(0).Value = "Recycle_" + Session("cursession")
        'End If
        session_name(1) = New SqlParameter("@para2", SqlDbType.NVarChar)
        session_name(1).Value = tb1
        'session_name(2) = New SqlParameter("@para3", SqlDbType.NVarChar)
        ' session_name(2).Value = dd1
        ' session_name(3) = New SqlParameter("@para4", SqlDbType.NVarChar)
        ' session_name(3).Value = dd2



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
        If dlistclass.Text = "" Then

            com.CommandText = "FeeStruc1"
        Else
            session_name(1).Value = tb2

            com.CommandText = "FeeStruc2"

        End If
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
        sda.Fill(Session("dt0"))
        GridView1.DataSource = Session("dt0") '
        GridView1.DataBind() '

        Session("dt0").Clear()
        conn.Close()

        ' Catch ex As SqlException
        ' MsgBox(ex.Message)
        'Finally
        conn.Dispose()

        'checking below stmt "and convert ..", you can remove it.
        If dlistclass.Text <> "" Then
            Dim row As GridViewRow
            row = GridView1.Rows(0)
            'Session("row") = row
            TextBox14.Text = Val(row.Cells(2).Text)
            TextBox2.Text = Val(row.Cells(3).Text)
            TextBox5.Text = Val(row.Cells(4).Text)
            TextBox6.Text = Val(row.Cells(5).Text)
            TextBox7.Text = Val(row.Cells(6).Text)
            TextBox15.Text = Val(row.Cells(7).Text)
            TextBox8.Text = Val(row.Cells(8).Text)
            TextBox9.Text = Val(row.Cells(9).Text)
            TextBox10.Text = Val(row.Cells(10).Text)
            TextBox16.Text = Val(row.Cells(11).Text)
            TextBox11.Text = Val(row.Cells(12).Text)
            TextBox1.Text = Val(row.Cells(13).Text)
            TextBox17.Text = Val(row.Cells(14).Text)
            If row.Cells(15).Text <> "Monthly" And row.Cells(15).Text <> "Quarterly" And row.Cells(15).Text <> "Half Yearly" Then
                dinstal.SelectedItem.Text = ""
            Else
                dinstal.SelectedItem.Text = row.Cells(15).Text
            End If
            Label8.Text = Val(row.Cells(17).Text)
            TextBox25.Text = Val(row.Cells(16).Text)


        Else
            Response.Redirect("Fee_Master1.aspx")

        End If

    End Sub



End Class
