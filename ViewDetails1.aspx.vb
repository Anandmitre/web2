Imports System.Data.SqlClient
Imports System.Data
Imports System.Net
Imports System.Configuration
Imports System.Web.Configuration
Partial Class ViewDetails1
    Inherits System.Web.UI.Page
    Dim conn As SqlConnection
    Dim com As SqlCommand
    Dim rd As SqlDataReader

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Response.Write("see")
        'Dim query As String
        'If IsPostBack = False Then
        ' Response.Write(Session("edit5"))
        '  on press back arrow page loads of current page then it goes back
        Try

            'conn = New SqlConnection
            'conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
            'conn.Open()


            'conn.Close()
            'conn.Dispose()
            ' Catch ex As Exception


            ' Finally
            ' conn.Dispose()
            '  End Try




            If IsPostBack = False Then

                If Session("del1") = Nothing Then

                    Button10.Text = "Delete Record"
                ElseIf Session("del1") = "2" Then

                    Button10.Text = "Restore the Student"
                End If

                Response.Write(Session("edit5"))









                    If Session("fore3") = "1" Then
                        Session("fore3") = ""
                        Response.Redirect("EditPage1.aspx")
                    End If

                    If Session("backward2") = "1" Then
                        Session("backward2") = ""
                        ' Session("page2") = "1"
                        Response.Redirect("Student_Details1.aspx")
                        'Response.Write("<script>window.location.href = 'Student_Details1.aspx'</script>")
                    End If

                    TextBox2.Text = Session("txb1")

                    If Session("edit5") = "3" Then
                        Session("edit5") = Nothing
                        Session("indexint1") = Convert.ToInt32(Session("index2")) + 1
                        Call Button1_Click(sender, e)

                    End If
                    If Session("search") = "11" Then
                        Session("search") = "12"
                        Response.Redirect("Student_Details1.aspx")

                    End If
                    If Session("search") = "23" Then
                        Session("search") = Nothing
                        Session("indexint1") = Session("index2") + 1
                        Call Button1_Click(sender, e)

                    End If
                    If Session("indexchec") = "3" Then
                        Session("indexchec") = Nothing

                        Session("indexint1") = Session("index2") + 1
                        Call Button1_Click(sender, e)
                        'Response.Redirect("EditPage1.aspx")
                    End If
                    If Session("indexchec") = "2" Then
                        Session("indexchec") = "3"
                        TextBox1.Text = Convert.ToInt32(Session("indexint2"))
                        Call TextBox1_TextChanged(sender, e)
                        'Call Button1_Click(sender, e)
                        'Response.Redirect("EditPage1.aspx")
                    End If


                    Response.Write(Session("max"))
                    If Session("logout2") = "1" Then
                        Session("logout2") = ""
                        Session.Clear()
                        Session.Contents.RemoveAll()
                        Session.RemoveAll()
                        'FormsAuthentication.SignOut()
                        Session.Abandon()
                        ' Response.Redirect("Default.aspx")
                        Response.Redirect("Default.aspx")
                        ' Response.Write("<script>window.location.href = 'Default.aspx'</script>")
                    End If
                    If Session("grid") = "" Then
                        If (Convert.ToInt32(Session("index2")) + 1) Mod 100 = 1 Then
                            ch.InnerHtml = " <center><h2>Total Filtered Records:   <span style = 'color:maroon'>   " + Session("max").ToString + " &nbsp&nbspShowing: " + (Convert.ToInt32(Session("index2")) + 1).ToString + "st  </span></h2></center>"
                        ElseIf (Convert.ToInt32(Session("index2")) + 1) Mod 100 = 2 Then
                            ch.InnerHtml = " <center><h2>Total Filtered Records:   <span style = 'color:maroon'>   " + Session("max").ToString + " &nbsp&nbspShowing: " + (Convert.ToInt32(Session("index2")) + 1).ToString + "nd  </span></h2></center>"
                        ElseIf (Convert.ToInt32(Session("index2")) + 1) Mod 100 = 3 Then
                            ch.InnerHtml = " <center><h2>Total Filtered Records:   <span style = 'color:maroon'>   " + Session("max").ToString + " &nbsp&nbspShowing: " + (Convert.ToInt32(Session("index2")) + 1).ToString + "rd  </span></h2></center>"
                        Else
                            ch.InnerHtml = " <center><h2>Total Filtered Records:   <span style = 'color:maroon'>   " + Session("max").ToString + " &nbsp&nbspShowing: " + (Convert.ToInt32(Session("index2")) + 1).ToString + "th  </span></h2></center>"

                        End If


                        TextBox1.Text = Session("index2") + 1

                        Session("indexint1") = Session("index2") + 1
                        'TextBox2.Enabled = False
                        'TextBox2.Visible = False
                    End If
                If Session("recordeleted") = "0" Then
                    Session("recordeleted") = ""
                    If Session("del1") = Nothing Then
                        Label46.Text = "The Record Deleted."
                    ElseIf Session("del1") = "2" Then
                        Label46.Text = "The Record Added."
                    End If
                End If
                Session("viewdetail") = ""   ' not required

                    '  =Session("sn")
                    '   = Session("rollno") 

                    lrollno.Text = Session("rollno").ToString
                    lname.Text = Session("name1").ToString
                    lsurname.Text = Session("surname")
                    lgender.Text = Session("gender")
                    lclass.Text = Session("class")
                    lsection.Text = Session("section")
                    lFphone.Text = Session("Fphone")
                    ldob.Text = Session("dob")
                    lage.Text = Session("age")
                    lsssm.Text = Session("sssm")
                    ladmsn.Text = Session("admsn")
                    laadhar.Text = Session("aadhar")
                    lNmother.Text = Session("Nmother")
                    lNfather.Text = Session("Nfather")
                    lcateg.Text = Session("categ")
                    lLaddress.Text = Session("Laddress")
                    ltown.Text = Session("town")
                    lstate.Text = Session("state")
                    lpin.Text = Session("pin")
                    lMphone.Text = Session("Mphone")
                    lOphone.Text = Session("Ophone")
                    lNguardian.Text = Session("Nguardian")
                    lRguardian.Text = Session("Rguardian")
                    lGphone.Text = Session("Gphone")
                    lemail.Text = Session("email")
                    lPaddress.Text = Session("Paddress")
                    lcity.Text = Session("city")
                    lprovince.Text = Session("province")
                    lzip.Text = Session("zip")
                    lOmother.Text = Session("Omother")
                    lOfather.Text = Session("Ofather")
                    lbro.Text = Session("bro")
                    lsis.Text = Session("sis")
                    lheight.Text = Session("height")
                    lweight.Text = Session("weight")
                    lAcSkill.Text = Session("AcSkill")
                    lOSkill.Text = Session("interest")
                    lhobbies.Text = Session("hobbies")
                    lDiAbled.Text = Session("DiAbled")
                    lKindAbility.Text = Session("KindAbility")
                    lEnrlNo.Text = Session("EnrlNo")
                    lDateEnroll.Text = Session("DateEnroll")
                    lDateLeaveLast.Text = Session("DateLeaveLast")
                    lLastClass.Text = Session("LastClass")
                    lDateLeaveThis.Text = Session("DateLeaveThis")
                    lcountry.Text = Session("country")
                End If


            ' End If

        Catch
            Label45.Text = "go back and select a row"

            '  =Session("section") Session("country") =
            ' =Session("phone") 
            ' =Session("dob") 
        End Try
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        If Session("index2") < Convert.ToInt32(Session("max")) - 1 And Session("index2") >= 0 Then
            Session("index2") = Convert.ToInt32(Session("index2")) + 1
            'Session("index4") = Session("index2") ' used in edit to get same data view
            Session("viewdetail") = "1"
            'Response.Write("<script>window.location.href = 'Student_Details1.aspx'</script>")
            Response.Redirect("Student_Details1.aspx")
        End If



    End Sub
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Session("index2") > 0 And Session("index2") <= Convert.ToInt32(Session("max")) - 1 Then
            Session("index2") = Convert.ToInt32(Session("index2")) - 1
            'Session("index4") = Session("index2")  ' used in edit to get same data view
            Session("viewdetail") = "1"
            ' Response.Write("<script>window.location.href = 'Student_Details1.aspx'</script>")
            Response.Redirect("Student_Details1.aspx")
        End If
    End Sub
    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Session("refresh") = "1"
        'Session("check2") = "1"
        ' Server.Transfer("Student_Details1.aspx")
        Session("backward2") = "1"
        'Session("index2") = -1
        'Response.Write(Session("edit5"))
        ' Response.Write("<script>window.location.href = 'ViewDetails1.aspx'</script>")
        Response.Redirect("ViewDetails1.aspx")
    End Sub


    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call logout2()
        Session("logout2") = "1"
        Response.Redirect("ViewDetails1.aspx")
        'Response.Write("<script>window.location.href = 'ViewDetails1.aspx'</script>")

    End Sub
    Private Sub logout2()

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
        Session("dt0") = Nothing
        Session("dt10") = Nothing
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
        'Session.Clear()
        'Session.Contents.RemoveAll()
        ' Session.RemoveAll()
        'FormsAuthentication.SignOut()
        'Session.Abandon()
        ' TextBox1_TextChanged(sender, e)
        'Response.Redirect("Default.aspx")
        ' Server.Transfer("Default.aspx")
        ' Response.Write("<script>window.location.href = 'Default.aspx'</script>")
        'System.Web.UI.ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "Script", "window.history.backward(1)", True)
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "script", "window.history.forward(1)", True)
        'Response.Write("<script> 'window.history.backward(1)' </script>")
        Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1D))
        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        Response.Cache.SetNoStore()
        Page.ClientScript.RegisterStartupScript(Me.GetType(), "ClearHistory", "Clearhistory()", True)


    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Val(TextBox1.Text.Trim()) <= Convert.ToInt32(Session("max")) And Val(TextBox1.Text.Trim()) >= 1 Then
            Session("index2") = Val(TextBox1.Text.Trim()) - 1
            Session("viewdetail") = "1"

            'Response.Write("<script>window.location.href = 'Student_Details1.aspx'</script>")
            Response.Redirect("Student_Details1.aspx")
        End If
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Server.Transfer("~/EditPage1.aspx") '  similar to respobse.redirect but when destination page is post back it returns on previous automatically
        If Session("grid") = "" Then
            Response.Redirect("EditPage1.aspx")
        End If
        ' Session("ram") = "enu"
        'TextBox2.Enabled = True
        'TextBox2.Visible = True
        ' Session("ram") = Session("name1")
        ' TextBox2.Text = Session("ram")
        '  Label46.Text = Session("ram")
        'lname.Visible = False
        ' lname.Enabled = False
    End Sub
    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Session("index2") = 0
        Session("sortcheck") = ""
        Session("txb1") = TextBox2.Text.Trim()
        Session("search") = "11"
        Response.Redirect("ViewDetails1.aspx")

    End Sub
    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Session("fore3") = "1"
        Response.Redirect("ViewDetails1.aspx")
    End Sub
    Protected Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Session("ddlb1") = ""

        Session("ddlb2") = ""
        Call TextBox2_TextChanged(sender, e)
    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("AddDetails1.aspx")
    End Sub
    Protected Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ' Try
        Dim count As Integer
        Dim com As New SqlCommand
        conn = New SqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        conn.Open()

        If Session("grid") = "" Then
            If Session("del1") = Nothing Then
                Dim pt(2) As SqlParameter
                pt(0) = New SqlParameter("@parama1", SqlDbType.VarChar)

                pt(0).Value = Session("cursession")

                pt(1) = New SqlParameter("@parama2", SqlDbType.VarChar)
                pt(1).Value = Session("admsn")
                pt(2) = New SqlParameter("@parama3", SqlDbType.VarChar)

                pt(2).Value = "Recycle_" + Session("cursession")

                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "Delete1"
                com.Parameters.AddRange(pt)
                rd = com.ExecuteReader


                rd.Read()
                rd.Close()
                com.Parameters.Clear()
                count = 1

                If count = 1 Then            ' rd.Read()
                    Dim pt1(1) As SqlParameter
                    pt1(0) = New SqlParameter("@paramaa1", SqlDbType.VarChar)
                    pt1(0).Value = Session("cursession")
                    pt1(1) = New SqlParameter("@paramaa2", SqlDbType.VarChar)
                    pt1(1).Value = Session("admsn")
                    com.Connection = conn
                    com.CommandType = CommandType.StoredProcedure
                    com.CommandText = "Delete2"
                    com.Parameters.AddRange(pt1)
                    rd = com.ExecuteReader
                    rd.Read()
                    rd.Close()

                    com.Parameters.Clear()
                    conn.Close()
                    conn.Dispose()
                    count = 2
                End If
            ElseIf Session("del1") = "2" Then         ' if deleted records are being executed
                Dim pt(2) As SqlParameter
                pt(0) = New SqlParameter("@parama1", SqlDbType.VarChar)

                pt(0).Value = "Recycle_" + Session("cursession")

                pt(1) = New SqlParameter("@parama2", SqlDbType.VarChar)
                pt(1).Value = Session("admsn")
                pt(2) = New SqlParameter("@parama3", SqlDbType.VarChar)

                pt(2).Value = Session("cursession")

                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "Delete1"
                com.Parameters.AddRange(pt)
                rd = com.ExecuteReader


                rd.Read()
                rd.Close()
                com.Parameters.Clear()
                count = 1

                If count = 1 Then            ' rd.Read()
                    Dim pt1(1) As SqlParameter
                    pt1(0) = New SqlParameter("@paramaa1", SqlDbType.VarChar)
                    pt1(0).Value = "Recycle_" + Session("cursession")
                    pt1(1) = New SqlParameter("@paramaa2", SqlDbType.VarChar)
                    pt1(1).Value = Session("admsn")
                    com.Connection = conn
                    com.CommandType = CommandType.StoredProcedure
                    com.CommandText = "Delete2"
                    com.Parameters.AddRange(pt1)
                    rd = com.ExecuteReader
                    rd.Read()
                    rd.Close()

                    com.Parameters.Clear()
                    conn.Close()
                    conn.Dispose()
                    count = 2
                End If
            End If

            If count = 2 Then
                    count = 0
                    Session("recordeleted") = "1"
                    Response.Redirect("Student_Details1.aspx")

                End If
                'Call Button9_Click(sender, e)

                ' ElseIf Convert.ToInt32(Session("max")) = 1 And count = 2 Then
                'count = 0
                '     Response.Redirect("Student_Details1.aspx")
                'End If
            End If
        'Catch ex As SqlException
        ' End Try


    End Sub
End Class
