Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web.Configuration
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Web.UI.WebControls
Partial Class Fee_Details1
    Inherits System.Web.UI.Page
    Dim conn As SqlConnection
    Dim com As SqlCommand
    Dim rd As SqlDataReader
    Dim dt10 As New DataTable


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If (IsPostBack = False) Then
            ' Session("2index") = 0
            ddl1.Items.Add("")
            ddl1.Items.Add("Nursery")
            ddl1.Items.Add("LKG")
            ddl1.Items.Add("UKG")

            For k = 1 To 12
                ddl1.Items.Add(k)
            Next

            ddl1.Text = Session("ddl1")
            ' Session("ddl1") = ""
            ' modifying feedetails and feetable
            ' entering main fields values of main table into fee details tables
            'Try
            Dim com As New SqlCommand
            If Session("cursession") <> "" Then
                'Updating main table fields values into fee details fields and fee table
                ' Dim com As New SqlCommand

                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim fm1(1) As SqlParameter
                fm1(0) = New SqlParameter("@fm118", SqlDbType.NVarChar)
                fm1(0).Value = "FeeDetails1_" & Session("cursession")
                fm1(1) = New SqlParameter("@fm119", SqlDbType.NVarChar)
                fm1(1).Value = Session("cursession")

                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg

                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "Fee_Details4"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.AddRange(fm1)
                ' com.Parameters.Add(sp11)
                'com.ExecuteNonQuery()

                rd = com.ExecuteReader

                'x = 0
                'While rd.Read
                'x = x + 1

                'End While
                rd.Read()
                rd.Close()
                com.Parameters.Clear()
                conn.Close()


                'inserting all different records of main table into fee details
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim ttt21(1) As SqlParameter
                ttt21(0) = New SqlParameter("@q18", SqlDbType.NVarChar)
                ttt21(0).Value = "FeeDetails1_" & Session("cursession")
                ttt21(1) = New SqlParameter("@q19", SqlDbType.NVarChar)
                ttt21(1).Value = Session("cursession")

                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg

                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "Fee_Details2"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.AddRange(ttt21)
                ' com.Parameters.Add(sp11)
                'com.ExecuteNonQuery()

                rd = com.ExecuteReader

                'x = 0
                'While rd.Read
                'x = x + 1

                'End While
                rd.Read()
                rd.Close()

                com.Parameters.Clear()
                conn.Close()






                ' entering updated main fields values of feemaster table into fee details tables
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim fm(1) As SqlParameter
                fm(0) = New SqlParameter("@fm18", SqlDbType.NVarChar)
                fm(0).Value = "FeeDetails1_" & Session("cursession")
                fm(1) = New SqlParameter("@fm19", SqlDbType.NVarChar)
                fm(1).Value = "FeeMaster_" & Session("cursession")

                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg
                Dim com1 As New SqlCommand
                com1.Connection = conn
                com1.CommandType = CommandType.StoredProcedure
                com1.CommandText = "Fee_Details3"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com1.Parameters.AddRange(fm)
                ' com.Parameters.Add(sp11)
                'com.ExecuteNonQuery()

                rd = com1.ExecuteReader

                'x = 0
                'While rd.Read
                'x = x + 1

                'End While
                rd.Read()
                rd.Close()
                com1.Parameters.Clear()
                conn.Close()

                ' getting the name of last session
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim query As String
                query = "select Session from Session2 where Status='Closed_Last'"
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

                'updating duebalance (last session's) into fee_details files of new session from last sessions
                If Session("lastS") <> Session("cursession") And Session("lastS") <> "" Then
                    conn = New SqlConnection
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                    conn.Open()

                    Dim fma(1) As SqlParameter
                    fma(0) = New SqlParameter("@fm82", SqlDbType.NVarChar)
                    fma(0).Value = "FeeDetails1_" & Session("cursession")
                    fma(1) = New SqlParameter("@fm81", SqlDbType.NVarChar)
                    fma(1).Value = "FeeTable1_" & Session("lastS")   'upadating using feeTable and not from fee details as fee details are many.

                    'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                    'query = strg
                    com.Connection = conn
                    com.CommandType = CommandType.StoredProcedure
                    com.CommandText = "oldbal_update1"
                    'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                    'com.ExecuteNonQuery()
                    'Session("create") = ""
                    com.Parameters.AddRange(fma)
                    ' com.Parameters.Add(sp11)
                    'com.ExecuteNonQuery()

                    rd = com.ExecuteReader

                    'x = 0
                    'While rd.Read
                    'x = x + 1

                    'End While
                    rd.Read()
                    rd.Close()
                    com.Parameters.Clear()
                    'Session("2cursession") = ""
                    Session("lastS") = ""
                    conn.Close()

                End If


                ' Catch ex As SqlException   ' to correct all these
                'Session("app") = ""
                'Session("app2") = ""
                'Session("app3") = ""
                'Session("app4") = ""
                'Session("app5") = ""
                'Session("check1") = "9"
                ' MsgBox(ex.Message)         'check its requirement
                'Response.Write("<script>window.location.href = 'Session_1_Page_1.aspx' </script>")
                'Label8.Text = "ex"
                'Response.Write("Not Connected to Internet! ")
                'Finally

                ' Response.Redirect("Fee_Details1.aspx")
            End If


            ' same as above   now in fee table
            ' same as above   now in fee table
            ' same as above   now in fee table below

            If Session("cursession") <> "" Then
                'Updating main table fields values into fee details fields and fee table
                'Dim com As New SqlCommand

                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim fem1(1) As SqlParameter
                fem1(0) = New SqlParameter("@fee118", SqlDbType.NVarChar)
                fem1(0).Value = "FeeTable1_" & Session("cursession")
                fem1(1) = New SqlParameter("@fee119", SqlDbType.NVarChar)
                fem1(1).Value = Session("cursession")

                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg

                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "Fee_Table4"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.AddRange(fem1)
                ' com.Parameters.Add(sp11)
                'com.ExecuteNonQuery()

                rd = com.ExecuteReader

                'x = 0
                'While rd.Read
                'x = x + 1

                'End While
                rd.Read()
                rd.Close()
                com.Parameters.Clear()
                conn.Close()


                'inserting all different records of main table into fee details
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim fee21(1) As SqlParameter
                fee21(0) = New SqlParameter("@fq18", SqlDbType.NVarChar)
                fee21(0).Value = "FeeTable1_" & Session("cursession")
                fee21(1) = New SqlParameter("@fq19", SqlDbType.NVarChar)
                fee21(1).Value = Session("cursession")

                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg
                ' to rresee a column with new identity we can write : dbcc checkident(' + QUOTENAME(@fq18) + ', reseed, 0)'
                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "Fee_Table2"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.AddRange(fee21)
                ' com.Parameters.Add(sp11)
                'com.ExecuteNonQuery()

                rd = com.ExecuteReader

                'x = 0
                'While rd.Read
                'x = x + 1

                'End While
                rd.Read()
                rd.Close()

                com.Parameters.Clear()
                conn.Close()






                ' entering updated main fields values of feemaster table into fee details tables
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim feem(1) As SqlParameter
                feem(0) = New SqlParameter("@feem18", SqlDbType.NVarChar)
                feem(0).Value = "FeeTable1_" & Session("cursession")
                feem(1) = New SqlParameter("@feem19", SqlDbType.NVarChar)
                feem(1).Value = "FeeMaster_" & Session("cursession")

                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg
                Dim com1 As New SqlCommand
                com1.Connection = conn
                com1.CommandType = CommandType.StoredProcedure
                com1.CommandText = "Fee_Table3"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com1.Parameters.AddRange(feem)
                ' com.Parameters.Add(sp11)
                'com.ExecuteNonQuery()

                rd = com1.ExecuteReader

                'x = 0
                'While rd.Read
                'x = x + 1

                'End While
                rd.Read()
                rd.Close()
                com1.Parameters.Clear()
                conn.Close()

                ' getting the name of last session
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim query As String
                query = "select Session from Session2 where Status='Closed_Last'"
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

                'updating duebalance (last session's) into fee_details files of new session from last sessions
                If Session("lastS") <> Session("cursession") And Session("lastS") <> "" Then
                    conn = New SqlConnection
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings(" ThenmasterConnectionString1").ConnectionString
                    conn.Open()

                    Dim feema(1) As SqlParameter
                    feema(0) = New SqlParameter("@feem82", SqlDbType.NVarChar)
                    feema(0).Value = "FeeTable1_" & Session("cursession")
                    feema(1) = New SqlParameter("@feem81", SqlDbType.NVarChar)
                    feema(1).Value = "FeeTable1_" & Session("lastS")

                    'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                    'query = strg
                    com.Connection = conn
                    com.CommandType = CommandType.StoredProcedure
                    com.CommandText = "oldbal_update_FT"
                    'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                    'com.ExecuteNonQuery()
                    'Session("create") = ""
                    com.Parameters.AddRange(feema)
                    ' com.Parameters.Add(sp11)
                    'com.ExecuteNonQuery()

                    rd = com.ExecuteReader

                    'x = 0
                    'While rd.Read
                    'x = x + 1

                    'End While
                    rd.Read()
                    rd.Close()
                    com.Parameters.Clear()
                    'Session("2cursession") = ""
                    Session("lastS") = ""
                    conn.Close()

                End If


                ' Catch ex As SqlException   ' to correct all these
                'Session("app") = ""
                'Session("app2") = ""
                'Session("app3") = ""
                'Session("app4") = ""
                'Session("app5") = ""
                'Session("check1") = "9"
                ' MsgBox(ex.Message)         'check its requirement
                'Response.Write("<script>window.location.href = 'Session_1_Page_1.aspx' </script>")
                'Label8.Text = "ex"
                'Response.Write("Not Connected to Internet! ")
                'Finally
            End If


                'Catch ex As SqlException
                ' MsgBox(ex.Message)
                ' Response.Write("Error" + ex.ToString())          REM to change

                ' Finally
                'conn.Dispose()

                ' End Try



                Dim dt10 As New DataTable()
            Session("dt10") = dt10
            conn = New SqlConnection
            conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
            conn.Open()
            Dim sda As New SqlDataAdapter


            Dim tb1 = "'%'+'" & ddl1.Text.Trim() & "'+'%'"
            '''  Dim tb2 = "'" & ddl1.Text.Trim() & "'"

            'Dim dd1 = "'%'+'" & DropDownList1.Text.Trim() & "'+'%'"
            'Dim dd2 = "'%'+'" & DropDownList2.Text.Trim() & "'+'%'"
            ' need to include other options as search option from table fields
            'Dim tb1 = "'" & dlistclass.Text.Trim() & "'"

            Dim session_name10(1) As SqlParameter
            session_name10(0) = New SqlParameter("@para1", SqlDbType.NVarChar)
            'If Session("del1") = Nothing Then
            session_name10(0).Value = "FeeTable1_" + Session("cursession")
            ' ElseIf Session("del1") = "2" Then
            'session_name(0).Value = "Recycle_" + Session("cursession")
            'End If
            session_name10(1) = New SqlParameter("@para2", SqlDbType.NVarChar)
            session_name10(1).Value = tb1
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

            'Dim com As New SqlCommand
            com.Connection = conn
            com.CommandType = CommandType.StoredProcedure


            com.CommandText = "FeeTables1"





            com.Parameters.AddRange(session_name10)
            'com = New SqlCommand(query, conn)
            'com.Parameters.Add(vari1)
            'com.Parameters.AddWithValue("@Sirname", TextBox1.Text.Trim())

            'com.Parameters.AddWithValue("@Class_Standard", DropDownList1.Text.Trim())
            'com.CommandText = query
            'com.Connection = conn
            'rd = com.ExecuteReader
            ' com.ExecuteNonQuery()


            sda.SelectCommand = com
            sda.Fill(Session("dt10"))
            GridView1.DataSource = Session("dt10")
            GridView1.DataBind()

            Dim dv1 As New DataView(Session("dt10"))
            Session("dv1") = dv1

            ' Session("dt10").Clear()
            conn.Close()

            ' Catch ex As SqlException
            ' MsgBox(ex.Message)
            'Finally
            'conn.Dispose()
            Call fun11()
            Session("1index") = 0
            'Session("2index") = 0

            ' Catch ex As SqlException
            ' MsgBox(ex.Message)
            'Finally
            ' End If

            ' Catch ex As SqlException
            '         MsgBox(ex.Message)
            ' Response.Write("Error" + ex.ToString())          REM to change

            'Finally
            conn.Dispose()

            'End Try
            Dim row As GridViewRow
            row = GridView1.Rows(Convert.ToInt32(Session("2index")))
            Session("11admsnNo") = row.Cells(7).Text
            TextBox1.Text = Session("11admsnNo")
            Session("2index") = 0   ' it makes all indexes 0, 1st row selected even if it does not got colored.
            'Session("2index") = 0
            'Response.Write("check2")
            Label1.Text = "25"
        End If


        ' Response.Write(Session("2index"))
    End Sub

    Protected Sub ddl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddl1.SelectedIndexChanged
        Dim dt10 As New DataTable()
        Session("dt10") = dt10
        conn = New SqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        conn.Open()
        Dim sda As New SqlDataAdapter
        'Dim SortExpression = "Roll_No."
        ' Dim ds As New DataSet
        REM check
        ' If (IsPostBack = False) Then
        Session("ddl1") = ddl1.Text.Trim()
        Dim tb1 = "'%'+'" & ddl1.Text.Trim() & "'+'%'"
        '''  Dim tb2 = "'" & ddl1.Text.Trim() & "'"

        'Dim dd1 = "'%'+'" & DropDownList1.Text.Trim() & "'+'%'"
        'Dim dd2 = "'%'+'" & DropDownList2.Text.Trim() & "'+'%'"
        ' need to include other options as search option from table fields
        'Dim tb1 = "'" & dlistclass.Text.Trim() & "'"

        Dim session_name10(1) As SqlParameter
        session_name10(0) = New SqlParameter("@para1", SqlDbType.NVarChar)
        'If Session("del1") = Nothing Then
        session_name10(0).Value = "FeeTable1_" + Session("cursession")
        ' ElseIf Session("del1") = "2" Then
        'session_name(0).Value = "Recycle_" + Session("cursession")
        'End If
        session_name10(1) = New SqlParameter("@para2", SqlDbType.NVarChar)
        session_name10(1).Value = tb1
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


        com.CommandText = "FeeTables1"





        com.Parameters.AddRange(session_name10)
        'com = New SqlCommand(query, conn)
        'com.Parameters.Add(vari1)
        'com.Parameters.AddWithValue("@Sirname", TextBox1.Text.Trim())

        'com.Parameters.AddWithValue("@Class_Standard", DropDownList1.Text.Trim())
        'com.CommandText = query
        'com.Connection = conn
        'rd = com.ExecuteReader
        ' com.ExecuteNonQuery()


        sda.SelectCommand = com
        sda.Fill(Session("dt10"))
        GridView1.DataSource = Session("dt10")
        GridView1.DataBind()

        Dim dv1 As New DataView(Session("dt10"))
        Session("dv1") = dv1

        'Session("dt10").Clear()
        conn.Close()

        ' Catch ex As SqlException
        ' MsgBox(ex.Message)
        'Finally
        conn.Dispose()
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Try
        Dim Table_V1 As Integer

        conn = New SqlConnection
            Dim com As New SqlCommand

            conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        If Session("cursession") <> "" Then
            conn.Open()
            ' Dim query As String
            ' getting value of table_Value1 from fee_table1
            'Query = "select * from Admin1 where Password='" & TextBox23.Text & "'"
            Dim feeT1(1) As SqlParameter
            feeT1(0) = New SqlParameter("@ft11", SqlDbType.NVarChar)
            feeT1(0).Value = "FeeTable1_" & Session("cursession")
            feeT1(1) = New SqlParameter("@ft12", SqlDbType.NVarChar)
            feeT1(1).Value = Session("11admsnNo")
            com.Connection = conn
            com.CommandType = CommandType.StoredProcedure
            com.CommandText = "Tvalue_1"
            com.Parameters.AddRange(feeT1)
            'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
            'com.ExecuteNonQuery()
            'Session("create") = ""

            rd = com.ExecuteReader

            rd.Read()
            Table_V1 = Convert.ToInt32(rd("Table_Value1"))  ' check if table value is null and can it be coverted to integer or not?

            rd.Close()
            com.Parameters.Clear()
            'Session("2cursession") = ""

            conn.Close()
            ' Response.Write(Table_V1)

            Label1.Text = Table_V1


            conn.Open()
            ' checking respective fee details table if not there then creating  a fee details table by modifying its name with table value and getting all values of fee_details table to fill the  fee receipt 
            Session("TValue") = Table_V1 + 1
            Session("NewFeeTable1") = "FeeDetails" & Session("TValue") & "_" & Session("cursession")

            Dim query As String
            conn = New SqlConnection
            conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
            conn.Open()
            Query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES where TABLE_NAME= '" & Session("NewFeeTable1") & "'"
            com = New SqlCommand(Query, conn)
            rd = com.ExecuteReader

            While rd.Read

                Session("NewFeeTable1") = ""   ' to stop creating a duplicate fee daetails table 
                'after creating one for a student.
            End While

            conn.Close()


            'Try
            ' Dim com As New SqlCommand

            'creating another new fee_details table for new fee deposit, if already not exist.
            ' Dim com As New SqlCommand

            If Session("NewFeeTable1") <> "" And Session("TValue") > 1 Then
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
                com.CommandText = "Fee_Details"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.Add(tp21)
                ' com.Parameters.Add(sp11)
                com.ExecuteNonQuery()
                ' Session("FeeDetails22") = Session("FeeDetails1")


                com.Parameters.Clear()
                conn.Close()


                'Updating main table fields values into fee details fields 
                ' Dim com As New SqlCommand

                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim fm1(1) As SqlParameter
                fm1(0) = New SqlParameter("@fm118", SqlDbType.NVarChar)
                fm1(0).Value = Session("NewFeeTable1")
                fm1(1) = New SqlParameter("@fm119", SqlDbType.NVarChar)
                fm1(1).Value = Session("cursession")

                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg

                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "Fee_Details4"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.AddRange(fm1)
                ' com.Parameters.Add(sp11)
                'com.ExecuteNonQuery()

                rd = com.ExecuteReader

                'x = 0
                'While rd.Read
                'x = x + 1

                'End While
                rd.Read()
                rd.Close()
                com.Parameters.Clear()
                conn.Close()


                'inserting all different records of main table into fee details
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim ttt21(1) As SqlParameter
                ttt21(0) = New SqlParameter("@q18", SqlDbType.NVarChar)
                ttt21(0).Value = Session("NewFeeTable1")
                ttt21(1) = New SqlParameter("@q19", SqlDbType.NVarChar)
                ttt21(1).Value = Session("cursession")

                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg

                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "Fee_Details2"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.AddRange(ttt21)
                ' com.Parameters.Add(sp11)
                'com.ExecuteNonQuery()

                rd = com.ExecuteReader

                'x = 0
                'While rd.Read
                'x = x + 1

                'End While
                rd.Read()
                rd.Close()

                com.Parameters.Clear()
                conn.Close()






                ' entering updated main fields values of feemaster table into fee details tables
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim fm(1) As SqlParameter
                fm(0) = New SqlParameter("@fm18", SqlDbType.NVarChar)
                fm(0).Value = Session("NewFeeTable1")
                fm(1) = New SqlParameter("@fm19", SqlDbType.NVarChar)
                fm(1).Value = "FeeMaster_" & Session("cursession")

                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg
                Dim com1 As New SqlCommand
                com1.Connection = conn
                com1.CommandType = CommandType.StoredProcedure
                com1.CommandText = "Fee_Details3"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com1.Parameters.AddRange(fm)
                ' com.Parameters.Add(sp11)
                'com.ExecuteNonQuery()

                rd = com1.ExecuteReader

                'x = 0
                'While rd.Read
                'x = x + 1

                'End While
                rd.Read()
                rd.Close()
                com1.Parameters.Clear()
                conn.Close()
                ' Session("NewFeeTable1") = ""


                'updating duebalance (last session's)  and last fee details into newly created fee_details files 
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Session("OTValue") = Session("TValue") - 1
                Dim feema(1) As SqlParameter
                feema(0) = New SqlParameter("@feem82", SqlDbType.NVarChar)
                feema(0).Value = Session("NewFeeTable1")
                feema(1) = New SqlParameter("@feem81", SqlDbType.NVarChar)
                feema(1).Value = "FeeDetails" & Session("OTValue") & "_" & Session("cursession")

                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg
                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "update1_feeDetails"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.AddRange(feema)
                ' com.Parameters.Add(sp11)
                'com.ExecuteNonQuery()

                rd = com.ExecuteReader

                'x = 0
                'While rd.Read
                'x = x + 1

                'End While
                rd.Read()
                rd.Close()
                com.Parameters.Clear()
                'Session("NewFeeTable1") = ""
                'Session("2cursession") = ""
                ' Session("lastS") = ""
                conn.Close()

                ' getting all values fee details table
                Dim p()
                conn.Open()
                Dim va(1) As SqlParameter
                va(0) = New SqlParameter("@para11", SqlDbType.NVarChar)
                va(0).Value = Session("NewFeeTable1")
                va(1) = New SqlParameter("@para12", SqlDbType.NVarChar)
                va(1).Value = Session("11admsnNo")

                'Dim sp12 As SqlParameter = New SqlParameter("@sp9", SqlDbType.NVarChar)
                'query = strg
                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "get1_feeDetails"
                'com.Parameters.AddWithValue("@naming", TextBox2.Text.Trim())
                'com.ExecuteNonQuery()
                'Session("create") = ""
                com.Parameters.AddRange(va)
                ' com.Parameters.Add(sp11)
                'com.ExecuteNonQuery()

                rd = com.ExecuteReader

                'x = 0
                'While rd.Read
                'x = x + 1

                'End While
                rd.Read()
                rd.Close()
                com.Parameters.Clear()
                Session("NewFeeTable1") = ""
                'Session("2cursession") = ""
                ' Session("lastS") = ""
                conn.Close()


            End If
        End If

        'Dim row As GridViewRow
        ' Row = GridView1.Rows(Convert.ToInt32(Session("1index")))

        ' Catch ex As Exception
        ' Response.Write("<script> alert ('Error Occured'); window.location.href = 'Default.aspx'</script>")

        'End Try


        'Response.Redirect("FeeDeposit1.aspx")

    End Sub
    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Session("1index") = GridView1.SelectedIndex
        Session("1color") = GridView1.SelectedRow.BackColor
        Session("2index") = Convert.ToInt32(Session("1index"))
        ' Response.Write("<script>window.location.href = 'Fee_Details1.aspx'</script>")
        Response.Redirect("Fee_Details1.aspx")
    End Sub

    Private Sub GridView1_Sorting(sender As Object, e As GridViewSortEventArgs) Handles GridView1.Sorting
        'Session("2index") = 0
        'Dim dv1 As New DataView(Session("dt10"))
        'Session("dv1") = dv1
        Session("sort1_expression1") = e.SortExpression()





        If Session("sort1_expression1") = Session("sort1_expression2") Then
            Session("sort1_expression") = Session("sort1_expression1")
            Session("sort1_expression2") = ""
            Session("direction1") = "DESC"
        ElseIf Session("direction1") = Nothing And Session("sort1_expression1") = "Class_Std" Then
            Session("direction1") = "DESC"
            Session("sort1_expression1") = e.SortExpression
        Else
            Session("sort1_expression") = Session("sort1_expression1")
            Session("sort1_expression2") = Session("sort1_expression1")
            Session("direction1") = "ASC"

        End If



        ' Response.Write(direction)
        ' If Session("sort_expression") = Nothing Then
        ' Session("sort_expression") = "Class_Standard"
        'End If

        'Session("direction") = "ASC"
        'Session("sort_expression") = e.SortExpression
        Session("dv1").Sort = String.Format(Session("sort1_expression") + " " + Session("direction1"))
        GridView1.DataSource = Session("dv1")
        GridView1.DataBind()


        'Session("sortcheck1") = "1"  ' to find  for what purpose i introduced this line, i copied it from very first grid view of student details

        '  Session("sort") = ""
        'fun4()
        '   Response.Write(Session("sort_expression"))
        ' If e.SortExpression <> "Class_Standard" Then
        'Response.Redirect("Student_Details1.aspx")
        'Response.Write("<script>window.location.href = 'Fee_Details1.aspx' </script>")
    End Sub

    Private Sub GridView1_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles GridView1.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Attributes("onclick") = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" & e.Row.RowIndex)
            e.Row.ToolTip = "CLICK TO SELECT THE ROW."
            e.Row.Attributes("style") = "cursor:pointer"

            e.Row.Attributes.Add("onmouseover", "this.originalstyle = this.style.backgroundColor;this.style.backgroundColor='orange';this.originalstyle1=this.style.color;this.style.color='white'")
            ' If e.Row.RowIndex = GridView2.SelectedIndex Then
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle; this.style.color= this.originalstyle1 ")

        End If

    End Sub
    Private Sub fun11()
        For Each Row As GridViewRow In GridView1.Rows


            ' Row = Session("Row")
            If Session("1color") <> Drawing.Color.Brown And Row.RowIndex = Convert.ToInt32(Session("1index")) Then  'And row.ForeColor <> Color.FromName("white") Then
                ' Response.Write(Convert.ToInt32(Session("index")))
                Row.BackColor = Drawing.ColorTranslator.FromHtml("Brown") REM value of session("index2") may not = 0 but 1st row gets automatically selected ...
                REM .....    each  time whenwver the  page loads and session("index")= 0.
                Row.ForeColor = Drawing.ColorTranslator.FromHtml("white")
                ' If Convert.ToInt32(Session("1index")) = 0 Then
                'Session("3index") = "1"
                ' Else
                ' Session("3index") = ""
                ' End If
                ' Response.Write("1204")
                'Session("Color") = Color.Brown
                'Row.BackColor = Color.Brown
                ' Row.ForeColor = Color.White

                Row.Font.Bold = True
                Row.ToolTip = "CLICK TO UNSELECT THE ROW." '            End If String.Empty
                Session("1index") = 0   ' to unselect a row and index disposing
                ' Session("color") = ColorTranslator.FromHtml("Brown")
                ' ch1.InnerHtml = " <center><h2>  <span style = 'color:maroon'>The Row is Selected!!</span></h2></center>"
            ElseIf Session("1color") = Drawing.Color.Brown And Row.RowIndex = Convert.ToInt32(Session("1index")) Then  'And row.ForeColor = Color.FromName("white") Then
                Row.BackColor = Drawing.ColorTranslator.FromHtml("#FFF7E7")
                Row.ForeColor = Drawing.ColorTranslator.FromHtml("#8C4510")
                'row.ForeColor = Color.FromName("#8C4510")
                ' Color.FromName("#FFF7E7")
                ' Response.Write("123")
                ' Session("Color") = Color.FromName("#FFF7E7")
                ' Row.BackColor = Color.FromName("#FFF7E7")
                ' Row.ForeColor = Color.FromName("#8C4510")
                Row.Font.Bold = False
                Row.ToolTip = "CLICK TO SELECT THE ROW."
                Session("1index") = 0    ' to unselect a row and index disposing
                Session("2index") = 0
                Session("1color") = Drawing.ColorTranslator.FromHtml("#FFF7E7")  ' to regain brown color of 1st row on refresh or back and ...
                ' ...not allowing index2 to become 0

            Else
                Row.BackColor = Drawing.ColorTranslator.FromHtml("#FFF7E7")
                Row.ForeColor = Drawing.ColorTranslator.FromHtml("#8C4510")
                Row.Font.Bold = False
                Row.ToolTip = "CLICK TO SELECT THE ROW."
            End If
            ' Row.BackColor = ColorTranslator.FromHtml("Brown")
            '#FFFFFF
            '#8C4510'
            'this.originalstyle='#FFF7E7';
        Next

    End Sub
End Class
