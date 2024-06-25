Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web.Configuration
Imports System.Data
Imports System.Drawing
Imports Class1
Imports System.Collections
Imports System.Text.RegularExpressions
Imports System.Web.UI.WebControls

Partial Class EditPage1
    Inherits System.Web.UI.Page
    Dim conn As SqlConnection
    Dim com As SqlCommand
    Dim rd As SqlDataReader
    Dim chb As Integer
    Dim chb2 As Integer
    Dim colum(60) As String
    Dim Valu(60) As String
    Dim chec44 As Integer
    Dim k As Integer
    ' Dim checkBoxes As New List(Of CheckBox)


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load


        ' Response.Write(Session("ss") & "14")

        'Button1_Click(sender, e)

        'End If

        'tdob.Text = Date()
        If IsPostBack = False Then
            ' Response.Write(Session("i3"))

            ' If Session("submit1") = "3" Then
            'Session("submit1") = "2"
            'Response.Redirect("Student_Details1.aspx")
            'End If
            If Session("i3") = "" Then Session("tst") = New ArrayList

            'Dim a2list As New ArrayList(50)
            'a2list.Add(0)
            'a2list = Session("tst")


            TextBox73.Text = Convert.ToInt32(Session("index2")) + 1

                If Session("edit5") = "1" Then
                    Session("edit5") = "2"
                    Response.Redirect("Student_Details1.aspx")
                    'Response.Write("<script>window.location.href = 'Student_Details1.aspx'</script>")
                End If
                If Session("back4") = "1" Then
                    Session("back4") = ""
                    Response.Redirect("ViewDetails1.aspx")
                End If
                chk.Text = Session("txb1")
                If Session("search") = "21" Then
                    Session("search") = "22"
                    Response.Redirect("Student_Details1.aspx")

                End If
                If Session("indexchec") = "1" Then
                    Session("indexchec") = "2"
                    Response.Redirect("ViewDetails1.aspx")
                End If
            If Session("k") = "1" Then
                Session("k") = ""
                If Val(TextBox73.Text.Trim()) <= Convert.ToInt32(Session("max")) - 1 And Val(TextBox73.Text.Trim()) >= 1 Then
                    TextBox73.Text = Convert.ToInt32(TextBox73.Text.Trim()) + 1
                    Call TextBox73_TextChanged(sender, e)
                End If

            ElseIf Session("k") = "2" Then
                Session("k") = ""
                If Val(TextBox73.Text.Trim()) <= Convert.ToInt32(Session("max")) And Val(TextBox73.Text.Trim()) >= 2 Then
                    TextBox73.Text = Convert.ToInt32(TextBox73.Text.Trim()) - 1
                    Call TextBox73_TextChanged(sender, e)
                End If

            End If

            If Session("x1") = "1" Then
                label3.Text = Session("chb2") + " Field(s) Updated."
                Session("chb2") = Nothing
                Session("x1") = Nothing
            ElseIf Session("x1") = "0" Then
                label3.Text = "No Fields Updated! Select the required fields."
                Session("chb2") = Nothing
                Session("x1") = Nothing
            End If
            Response.Write(Session("x11"))
            Session("x11") = Nothing

            dlgender.Items.Add("Female")
                dlgender.Items.Add("Male")
                dlgender.Items.Add("Other")

                dlclass.Items.Add("Nursery")
                dlclass.Items.Add("LKG")
                dlclass.Items.Add("UKG")

                For k = 1 To 12
                    dlclass.Items.Add(k)
                Next


                dlsection.Items.Add("A")
                dlsection.Items.Add("B")
                dlsection.Items.Add("C")



                dlcateg.Items.Add("Gen")
                dlcateg.Items.Add("OBC")
                dlcateg.Items.Add("SC")
                dlcateg.Items.Add("ST")

                dlstate.Items.Add("Madhya Pradesh")
                dlstate.Items.Add("Uttar Pradesh")
                dlstate.Items.Add("Chhattisgarh")
                dlstate.Items.Add("Andhra Pradesh")
                dlstate.Items.Add("Arunachal Pradesh")
                dlstate.Items.Add("Assam")
                dlstate.Items.Add("Bihar")
                dlstate.Items.Add("Goa")
                dlstate.Items.Add("Gujarat")
                dlstate.Items.Add("Haryana")
                dlstate.Items.Add("Himachal Pradesh")
                dlstate.Items.Add("Jharkhand")
                dlstate.Items.Add("Karnataka")
                dlstate.Items.Add("Kerala")
                dlstate.Items.Add("Maharashtra")
                dlstate.Items.Add("Manipur")
                dlstate.Items.Add("Meghalaya")
                dlstate.Items.Add("Mizoram")
                dlstate.Items.Add("Nagaland")
                dlstate.Items.Add("Odisha")
                dlstate.Items.Add("Punjab")
                dlstate.Items.Add("Rajasthan")
                dlstate.Items.Add("Sikkim")
                dlstate.Items.Add("Tamil Nadu")
                dlstate.Items.Add("Telangana")
                dlstate.Items.Add("Tripura")
                dlstate.Items.Add("Uttarakhand")
                dlstate.Items.Add("West Bengal")
                dlstate.Items.Add("Delhi")
                dlstate.Items.Add("Chandigarh")
                dlstate.Items.Add("J & K")

                dlprovince.Items.Add("Madhya Pradesh")
                dlprovince.Items.Add("Uttar Pradesh")
                dlprovince.Items.Add("Chhattisgarh")
                dlprovince.Items.Add("Andhra Pradesh")
                dlprovince.Items.Add("Arunachal Pradesh")
                dlprovince.Items.Add("Assam")
                dlprovince.Items.Add("Bihar")
                dlprovince.Items.Add("Goa")
                dlprovince.Items.Add("Gujarat")
                dlprovince.Items.Add("Haryana")
                dlprovince.Items.Add("Himachal Pradesh")
                dlprovince.Items.Add("Jharkhand")
                dlprovince.Items.Add("Karnataka")
                dlprovince.Items.Add("Kerala")
                dlprovince.Items.Add("Maharashtra")
                dlprovince.Items.Add("Manipur")
                dlprovince.Items.Add("Meghalaya")
                dlprovince.Items.Add("Mizoram")
                dlprovince.Items.Add("Nagaland")
                dlprovince.Items.Add("Odisha")
                dlprovince.Items.Add("Punjab")
                dlprovince.Items.Add("Rajasthan")
                dlprovince.Items.Add("Sikkim")
                dlprovince.Items.Add("Tamil Nadu")
                dlprovince.Items.Add("Telangana")
                dlprovince.Items.Add("Tripura")
                dlprovince.Items.Add("Uttarakhand")
                dlprovince.Items.Add("West Bengal")
                dlprovince.Items.Add("Delhi")
                dlprovince.Items.Add("Chandigarh")
                dlprovince.Items.Add("J & K")


                dlbro.Items.Add("None")
                dlsis.Items.Add("None")
                For g = 1 To 6
                    dlbro.Items.Add(g)
                    dlsis.Items.Add(g)
                Next

                For n = 20 To 80
                    dlheight.Items.Add(n)
                Next

                For n = 10 To 100
                    dlweight.Items.Add(n)
                Next

                dlDiAbled.Items.Add("No")
                dlDiAbled.Items.Add("Yes")
                dlcountry.Items.Add("Bharat")

                dlLastClass.Items.Add("Nursery")
                dlLastClass.Items.Add("LKG")
                dlLastClass.Items.Add("UKG")

                For k = 1 To 12
                    dlLastClass.Items.Add(k)
                Next

                If (Convert.ToInt32(Session("index2")) + 1) Mod 100 = 1 Then
                    ch.InnerHtml = " <center><h2>Total Filtered Records:   <span style = 'color:maroon'>   " + Session("max").ToString + " &nbsp&nbspShowing: " + (Convert.ToInt32(Session("index2")) + 1).ToString + "st  </span></h2></center>"
                ElseIf (Convert.ToInt32(Session("index2")) + 1) Mod 100 = 2 Then
                    ch.InnerHtml = " <center><h2>Total Filtered Records:   <span style = 'color:maroon'>   " + Session("max").ToString + " &nbsp&nbspShowing: " + (Convert.ToInt32(Session("index2")) + 1).ToString + "nd  </span></h2></center>"
                ElseIf (Convert.ToInt32(Session("index2")) + 1) Mod 100 = 3 Then
                    ch.InnerHtml = " <center><h2>Total Filtered Records:   <span style = 'color:maroon'>   " + Session("max").ToString + " &nbsp&nbspShowing: " + (Convert.ToInt32(Session("index2")) + 1).ToString + "rd  </span></h2></center>"
                Else
                    ch.InnerHtml = " <center><h2>Total Filtered Records:   <span style = 'color:maroon'>   " + Session("max").ToString + " &nbsp&nbspShowing: " + (Convert.ToInt32(Session("index2")) + 1).ToString + "th  </span></h2></center>"

                End If

                trollno.Text = Session("rollno").trim()
                tname.Text = Session("name1").trim()
                tsurname.Text = Session("surname").trim()
                dlgender.Text = Session("gender").trim()
                dlclass.Text = Session("class").trim()
                dlsection.Text = Session("section").trim()
                tFphone.Text = Session("Fphone").trim()
                tdob.Text = Session("dob").trim()


                tage.Text = Session("age").trim()
                tsssm.Text = Session("sssm").trim()
                tadmsn.Text = Session("admsn").trim()
                taadhar.Text = Session("aadhar").trim()
                tNmother.Text = Session("Nmother").trim()
                tNfather.Text = Session("Nfather").trim()
                dlcateg.Text = Session("categ").trim()
                tLaddress.Text = Session("Laddress").trim()
                tTown.Text = Session("town").trim()
                dlstate.Text = Session("state").trim()
                tpin.Text = Session("pin").trim()
                tMphone.Text = Session("Mphone").trim()
                tOphone.Text = Session("Ophone").trim()
                tNguardian.Text = Session("Nguardian").trim()
                tRguardian.Text = Session("Rguardian").trim()
                tGphone.Text = Session("Gphone").trim()
                temail.Text = Session("email").trim()
                tPaddress.Text = Session("Paddress").trim()
                tcity.Text = Session("city").trim()
                dlprovince.Text = Session("province").trim()
                tzip.Text = Session("zip").trim()
                tOmother.Text = Session("Omother").trim()
                tOfather.Text = Session("Ofather").trim()
                dlbro.Text = Session("bro").trim()
                dlsis.Text = Session("sis").trim()
                dlheight.Text = Session("height").trim()
                dlweight.Text = Session("weight").trim()
                tAcSkill.Text = Session("AcSkill").trim()
                tOSkill.Text = Session("oskill").trim()
                thobbies.Text = Session("hobbies").trim()
                dlDiAbled.Text = Session("DiAbled").trim()
                tKindAbility.Text = Session("KindAbility").trim()
                tEnrlNo.Text = Session("EnrlNo").trim()
                tdoe.Text = Session("DateEnroll").trim()

                tdol.Text = Session("DateLeaveLast").trim()
            dlLastClass.Text = Session("LastClass").trim()
            tdot.Text = Session("DateLeaveThis").trim()

                dlcountry.Text = Session("country").trim()



            Dim i As Integer
            If Session("i3") = "1" Then
                Session("i3") = ""
                For Each i In Session("tst")

                    If i = 1 Then
                        Check1.BackColor = ColorTranslator.FromHtml("cornflowerblue")

                    ElseIf i = 2 Then
                        Check2.BackColor = ColorTranslator.FromHtml("cornflowerblue")

                    ElseIf i = 3 Then
                        Check3.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 4 Then
                        Check4.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 5 Then
                        Check5.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 6 Then
                        Check6.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 7 Then
                        Check7.BackColor = ColorTranslator.FromHtml("cornflowerblue")
                        tage.BackColor = ColorTranslator.FromHtml("lightgreen")

                    ElseIf i = 9 Then
                        Check9.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 10 Then
                        Check10.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 11 Then
                        Check11.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 12 Then
                        Check12.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 13 Then
                        Check13.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 14 Then
                        Check14.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 15 Then
                        Check15.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 16 Then
                        Check16.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 18 Then
                        Check18.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 19 Then
                        Check19.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 20 Then
                        Check20.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 21 Then
                        Check21.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 22 Then
                        Check22.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 23 Then
                        Check23.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 24 Then
                        Check24.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 25 Then
                        Check25.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 26 Then
                        Check26.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 27 Then
                        Check27.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 28 Then
                        Check28.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 29 Then
                        Check29.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 30 Then
                        Check30.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 31 Then
                        Check31.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 36 Then
                        Check36.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 37 Then
                        Check37.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 38 Then
                        Check38.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 39 Then
                        Check39.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 40 Then
                        Check40.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 41 Then
                        Check41.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 42 Then
                        Check42.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 43 Then
                        Check43.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 44 Then
                        Check44.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 45 Then
                        Check45.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 46 Then
                        Check46.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 47 Then
                        Check47.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 48 Then
                        Check48.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 49 Then
                        Check49.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 50 Then
                        Check50.BackColor = ColorTranslator.FromHtml("cornflowerblue")


                    ElseIf i = 51 Then
                        Check51.BackColor = ColorTranslator.FromHtml("cornflowerblue")






                    End If
                Next i
                Session("tst").clear
            End If
        End If
    End Sub
    ' Protected Sub ImageButton1_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton1.Click
    ' If Calendar1.Visible = False Then
    ' Calendar1.Visible = True
    ' Else
    ' Calendar1.Visible = False
    '  End If
    ' End Sub
    ' Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged
    'TextBox76.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy")
    ' Calendar1.Visible = False
    ' End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Dim x As Integer

            Try
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
            Dim pt(3) As SqlParameter
            pt(0) = New SqlParameter("@param11", SqlDbType.VarChar)
            If Session("del1") = Nothing Then
                pt(0).Value = Session("cursession")
            ElseIf Session("del1") = "2" Then
                pt(0).Value = "Recycle_" + Session("cursession")
            End If
            pt(1) = New SqlParameter("@param12", SqlDbType.VarChar)
                'pt(1).Value = "'" & tname.Text & "'"
                pt(2) = New SqlParameter("@param13", SqlDbType.VarChar)
                pt(2).Value = Session("admsn")
            pt(3) = New SqlParameter("@param14", SqlDbType.VarChar)
            'pt(2).Value = Session("admsn")

            If chb = 0 And chec44 = 0 Then
                x = 0
                Session("x11") = 0
            ElseIf chec44 = 0 Then
                If chb2 <= chb Then chb2 = chb
                ' Response.Write(x + 14)
                Do Until (chb = 0)
                    ' indigit table name is written in sqr bracket as : query = update [2020-21]
                    'query = "update [2020-21] set Name_of_Student= '" & tname.Text & "' where SSSMID= '" & tsssm.Text & "' "   'Session("cursession")
                    'com = New SqlCommand(query, conn)


                    pt(3).Value = colum(chb)
                    pt(1).Value = Valu(chb)
                    Dim com As New SqlCommand
                    com.Connection = conn
                    com.CommandType = CommandType.StoredProcedure
                    com.CommandText = "oedit"

                    com.Parameters.AddRange(pt)

                    com.Parameters.Add("@param15", SqlDbType.Int)
                        ' to get values from stored procedure just add the variable without any value
                        com.Parameters("@param15").Direction = ParameterDirection.Output
                    ' to get values from stored procedure reverse the direction

                    rd = com.ExecuteReader

                    'x = 0
                    'While rd.Read
                    'x = x + 1

                    'End While
                    rd.Read()
                    rd.Close()
                    If chb = 1 Then
                        x = com.Parameters("@param15").Value
                        Session("x11") = x.ToString
                    End If
                    com.Parameters.Clear()

                chb = chb - 1

                Loop
                ' Session("ss") = x.ToString
                'x = 1
            ElseIf chec44 = 1 Then
                If chb2 <= chb Then chb2 = chb + 1
                Do Until (chb = -1)
                    ' indigit table name is written in sqr bracket as : query = update [2020-21]
                    'query = "update [2020-21] Set Name_of_Student= '" & tname.Text & "' where SSSMID= '" & tsssm.Text & "' "   'Session("cursession")
                    'com = New SqlCommand(query, conn)


                    pt(3).Value = colum(chb)
                    pt(1).Value = Valu(chb)
                    Dim com As New SqlCommand
                    com.Connection = conn
                    com.CommandType = CommandType.StoredProcedure
                    com.CommandText = "oedit"
                    com.Parameters.AddRange(pt)

                    com.Parameters.Add("@param15", SqlDbType.Int)
                    ' to get values from stored procedure just add the variable without any value

                    com.Parameters("@param15").Direction = ParameterDirection.Output
                    ' to get values from stored procedure reverse the direction


                    rd = com.ExecuteReader
                    'x = 0
                    'While rd.Read
                    'x = x + 1

                    ' End While
                    rd.Read()
                    rd.Close()

                    If chb = 0 Then
                        x = com.Parameters("@param15").Value
                        Session("x11") = x.ToString
                    End If

                    com.Parameters.Clear()

                    chb = chb - 1
                Loop
                ' x = 1
                Session("admsn") = tadmsn.Text.Trim()

                End If

                chb = 0
            ' Response.Write("x + 14")
            'End If
            'If Check2.Checked = True Then
            'Response.Write(chec44 + 5)
            ' query = "update [2020-21] set Surname= '" & tsurname.Text & "' where SSSMID=  '" & tsssm.Text & "' "
            'com = New SqlCommand(query, conn)
            ' rd = com.ExecuteReader
            ' rd.Read()
            ' rd.Close()
            '  x = 1
            '     End If



            conn.Close()
                conn.Dispose()


            'Session("index2") = Class1.index9()

            'Session("gh") = 3



            '  If (Convert.ToInt32(Session("index2")) + 1) Mod 100 = 1 Then
            'ch.InnerHtml = " <center><h2>Total Filtered Records:   <span style = 'color:maroon'>   " + Session("max").ToString + " &nbsp&nbspShowing: " + (Convert.ToInt32(Session("index2")) + 1).ToString + "st  </span></h2></center>"
            ' ElseIf (Convert.ToInt32(Session("index2")) + 1) Mod 100 = 2 Then
            '  ch.InnerHtml = " <center><h2>Total Filtered Records:   <span style = 'color:maroon'>   " + Session("max").ToString + " &nbsp&nbspShowing: " + (Convert.ToInt32(Session("index2")) + 1).ToString + "nd  </span></h2></center>"
            ' ElseIf (Convert.ToInt32(Session("index2")) + 1) Mod 100 = 3 Then
            'ch.InnerHtml = " <center><h2>Total Filtered Records:   <span style = 'color:maroon'>   " + Session("max").ToString + " &nbsp&nbspShowing: " + (Convert.ToInt32(Session("index2")) + 1).ToString + "rd  </span></h2></center>"
            ' Else
            'ch.InnerHtml = " <center><h2>Total Filtered Records:   <span style = 'color:maroon'>   " + Session("max").ToString + " &nbsp&nbspShowing: " + (Convert.ToInt32(Session("index2")) + 1).ToString + "th  </span></h2></center>"

            ' End If


            REM label3.Text = "Data Updated"

            REM label3.Text = "Select the field"

            If x >= 1 Then
                Session("i3") = "1"

                Session("admsn2") = Session("admsn")
                Session("edit5") = "1"
                'Response.Write(chb2)
                Session("x1") = "1"
                Session("chb2") = chb2.ToString()
                ' label3.Text = chb2.ToString() + " Fields Updated."
                chb2 = 0

                'Response.Write(index9() + 1)
                'If (Not (Me.Page.PreviousPage) Is Nothing) Then
                ' Dim GridView2 As GridView = CType(Me.Page.PreviousPage.FindControl("GridView2"), GridView)
                'If Session("GridData") <> Nothing Then






                'End If
            ElseIf x = 0 Then
                Session("x1") = "0"
                'label3.Text = "No Fields Updated! Select the required fields."
            End If
            Response.Redirect("EditPage1.aspx")
        Catch ex As SqlException
                Response.Write(ex)
                ' MsgBox(ex.ToString)
            End Try


    End Sub


    Protected Sub Check1_CheckedChanged(sender As Object, e As EventArgs) Handles Check1.CheckedChanged
        If Check1.Checked = True Then
            'Session("tst") = New ArrayList()
            chb = chb + 1
            colum(chb) = "Name_of_Student"
            Valu(chb) = "'" & tname.Text & "'"

            Check1.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(1)
            Check1.Checked = False
            'Dim tst(1) As String
            'Session("tst") = New ArrayList




            ' TryCast(Session("tst"), ArrayList).Add(1)
        End If

    End Sub
    Protected Sub Check2_CheckedChanged(sender As Object, e As EventArgs) Handles Check2.CheckedChanged
        If Check2.Checked = True Then
            'Session("tst") = New ArrayList()
            chb = chb + 1
            colum(chb) = "Surname"
            Valu(chb) = "'" & tsurname.Text & "'"

            Check2.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Check2.Checked = False
            Session("tst").add(2)

            'TryCast(Session("tst"), ArrayList).Add(2)
        End If
    End Sub
    Protected Sub Check3_CheckedChanged(sender As Object, e As EventArgs) Handles Check3.CheckedChanged
        If Check3.Checked = True Then

            chb = chb + 1
            colum(chb) = "Gender"
            Valu(chb) = "'" & dlgender.Text & "'"
            Check3.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(3)
            Check3.Checked = False
        End If
    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Call Button1_Click(sender, e)
    End Sub
    Protected Sub Check4_CheckedChanged(sender As Object, e As EventArgs) Handles Check4.CheckedChanged
        If Check4.Checked = True Then
            chb = chb + 1
            Valu(chb) = "'" & dlclass.Text & "'"
            colum(chb) = "Class_Std"
            Check4.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(4)
            Check4.Checked = False
        End If
    End Sub
    Protected Sub Check5_CheckedChanged(sender As Object, e As EventArgs) Handles Check5.CheckedChanged
        If Check5.Checked = True Then
            chb = chb + 1
            colum(chb) = "Section"
            Valu(chb) = "'" & dlsection.Text & "'"
            Check5.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(5)
            Check5.Checked = False
        End If
    End Sub
    Protected Sub Check6_CheckedChanged(sender As Object, e As EventArgs) Handles Check6.CheckedChanged
        If Check6.Checked = True Then
            chb = chb + 1
            colum(chb) = "Roll_Number"
            Valu(chb) = "'" & trollno.Text & "'"
            Check6.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(6)
            Check6.Checked = False
        End If
    End Sub
    Protected Sub Check7_CheckedChanged(sender As Object, e As EventArgs) Handles Check7.CheckedChanged
        If Check7.Checked = True Then
            chb = chb + 2
            colum(chb) = "Date_of_Birth"
            Valu(chb) = "'" & tdob.Text & "'"
            Check7.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            tage.BackColor = ColorTranslator.FromHtml("lightgreen")
            tage.Text = age(tdob.Text)
            colum(chb - 1) = "Age"
            Valu(chb - 1) = "'" & tage.Text & "'"
            Session("tst").add(7)
            Check7.Checked = False
        End If
    End Sub
    ' Protected Sub Check8_CheckedChanged(sender As Object, e As EventArgs) Handles Check8.CheckedChanged
    'If Check8.Checked = True Then
    'chb = chb + 1
    'colum(chb) = "Age"
    'Valu(chb) = "'" & tage.Text & "'"
    'Check8.BackColor = ColorTranslator.FromHtml("cornflowerblue")
    'Check8.Checked = False
    '  End If
    'End Sub
    Protected Sub Check9_CheckedChanged(sender As Object, e As EventArgs) Handles Check9.CheckedChanged
        If Check9.Checked = True Then
            chb = chb + 1
            colum(chb) = "Category"
            Valu(chb) = "'" & dlcateg.Text & "'"
            Check9.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(9)
            Check9.Checked = False
        End If

    End Sub
    Protected Sub Check10_CheckedChanged(sender As Object, e As EventArgs) Handles Check10.CheckedChanged
        If Check10.Checked = True Then
            chb = chb + 1
            colum(chb) = "Height"
            Valu(chb) = "'" & dlheight.Text & "'"
            Check10.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(10)
            Check10.Checked = False
        End If
    End Sub
    Protected Sub Check11_CheckedChanged(sender As Object, e As EventArgs) Handles Check11.CheckedChanged
        If Check11.Checked = True Then
            chb = chb + 1
            colum(chb) = "Weight"
            Valu(chb) = "'" & dlweight.Text & "'"
            Check11.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(11)
            Check11.Checked = False
        End If
    End Sub
    Protected Sub Check12_CheckedChanged(sender As Object, e As EventArgs) Handles Check12.CheckedChanged
        If Check12.Checked = True Then
            chb = chb + 1
            colum(chb) = "Academic_Skills"
            Valu(chb) = "'" & tAcSkill.Text & "'"
            Check12.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(12)
            Check12.Checked = False
        End If
    End Sub
    Protected Sub Check13_CheckedChanged(sender As Object, e As EventArgs) Handles Check13.CheckedChanged
        If Check13.Checked = True Then
            chb = chb + 1
            colum(chb) = "Interests"
            Valu(chb) = "'" & tOSkill.Text & "'"
            Check13.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(13)
            Check13.Checked = False
        End If
    End Sub
    Protected Sub Check14_CheckedChanged(sender As Object, e As EventArgs) Handles Check14.CheckedChanged
        If Check14.Checked = True Then
            chb = chb + 1
            colum(chb) = "Hobbies"
            Valu(chb) = "'" & thobbies.Text & "'"
            Check14.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(14)
            Check14.Checked = False
        End If
    End Sub
    Protected Sub Check15_CheckedChanged(sender As Object, e As EventArgs) Handles Check15.CheckedChanged


        If Check15.Checked = True Then
            chb = chb + 1
            colum(chb) = "Differently_Abled"
            Valu(chb) = "'" & dlDiAbled.Text & "'"
            Check15.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(15)
            Check15.Checked = False
        End If
    End Sub
    Protected Sub Check16_CheckedChanged(sender As Object, e As EventArgs) Handles Check16.CheckedChanged
        If Check16.Checked = True Then
            chb = chb + 1
            colum(chb) = "Kind_of_Ability"
            Valu(chb) = "'" & tKindAbility.Text & "'"
            Check16.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(16)
            Check16.Checked = False
        End If
    End Sub
    Protected Sub Check18_CheckedChanged(sender As Object, e As EventArgs) Handles Check18.CheckedChanged
        If Check18.Checked = True Then
            chb = chb + 1
            colum(chb) = "Phone_No_Mother"
            Valu(chb) = "'" & tMphone.Text & "'"
            Check18.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(18)
            Check18.Checked = False
        End If
    End Sub
    Protected Sub Check19_CheckedChanged(sender As Object, e As EventArgs) Handles Check19.CheckedChanged


        If Check19.Checked = True Then
            chb = chb + 1
            colum(chb) = "Phone_No_Father"
            Valu(chb) = "'" & tFphone.Text & "'"
            Check19.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(19)
            Check19.Checked = False
        End If
    End Sub
    Protected Sub Check20_CheckedChanged(sender As Object, e As EventArgs) Handles Check20.CheckedChanged
        If Check20.Checked = True Then
            chb = chb + 1
            colum(chb) = "Phone_No_Guardian"
            Valu(chb) = "'" & tGphone.Text & "'"
            Check20.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(20)
            Check20.Checked = False
        End If
    End Sub
    Protected Sub Check21_CheckedChanged(sender As Object, e As EventArgs) Handles Check21.CheckedChanged
        If Check21.Checked = True Then
            chb = chb + 1
            colum(chb) = "Phone_No_Other"
            Valu(chb) = "'" & tOphone.Text & "'"
            Check21.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(21)
            Check21.Checked = False
        End If
    End Sub
    Protected Sub Check22_CheckedChanged(sender As Object, e As EventArgs) Handles Check22.CheckedChanged


        If Check22.Checked = True Then
            chb = chb + 1
            colum(chb) = "E_Mail_Id"
            Valu(chb) = "'" & temail.Text & "'"
            Check22.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(22)
            Check22.Checked = False
        End If
    End Sub
    Protected Sub Check23_CheckedChanged(sender As Object, e As EventArgs) Handles Check23.CheckedChanged
        If Check23.Checked = True Then
            chb = chb + 1
            colum(chb) = "Local_Address"
            Valu(chb) = "'" & tLaddress.Text & "'"
            Check23.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(23)
            Check23.Checked = False
        End If
    End Sub
    Protected Sub Check24_CheckedChanged(sender As Object, e As EventArgs) Handles Check24.CheckedChanged
        If Check24.Checked = True Then
            chb = chb + 1
            colum(chb) = "Town_City"
            Valu(chb) = "'" & tTown.Text & "'"
            Check24.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(24)
            Check24.Checked = False
        End If
    End Sub
    Protected Sub Check25_CheckedChanged(sender As Object, e As EventArgs) Handles Check25.CheckedChanged


        If Check25.Checked = True Then
            chb = chb + 1
            colum(chb) = "PIN_ZIP_Code"
            Valu(chb) = "'" & tpin.Text & "'"
            Check25.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(25)
            Check25.Checked = False
        End If
    End Sub
    Protected Sub Check26_CheckedChanged(sender As Object, e As EventArgs) Handles Check26.CheckedChanged
        If Check26.Checked = True Then
            chb = chb + 1
            colum(chb) = "State_Province"
            Valu(chb) = "'" & dlstate.Text & "'"
            Check26.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(26)
            Check26.Checked = False
        End If
    End Sub
    Protected Sub Check27_CheckedChanged(sender As Object, e As EventArgs) Handles Check27.CheckedChanged
        If Check27.Checked = True Then
            chb = chb + 1
            colum(chb) = "Permanent_Address"
            Valu(chb) = "'" & tPaddress.Text & "'"
            Check27.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(27)
            Check27.Checked = False
        End If
    End Sub
    Protected Sub Check28_CheckedChanged(sender As Object, e As EventArgs) Handles Check28.CheckedChanged


        If Check28.Checked = True Then
            chb = chb + 1
            colum(chb) = "City_Town"
            Valu(chb) = "'" & tcity.Text & "'"
            Check28.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(28)
            Check28.Checked = False
        End If
    End Sub
    Protected Sub Check29_CheckedChanged(sender As Object, e As EventArgs) Handles Check29.CheckedChanged
        If Check29.Checked = True Then
            chb = chb + 1
            colum(chb) = "ZIP_PIN_Code"
            Valu(chb) = "'" & tzip.Text & "'"
            Check29.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(29)
            Check29.Checked = False
        End If
    End Sub
    Protected Sub Check30_CheckedChanged(sender As Object, e As EventArgs) Handles Check30.CheckedChanged
        If Check30.Checked = True Then
            chb = chb + 1
            colum(chb) = "Province_State"
            Valu(chb) = "'" & dlprovince.Text & "'"
            Check30.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(30)
            Check30.Checked = False
        End If
    End Sub
    Protected Sub Check31_CheckedChanged(sender As Object, e As EventArgs) Handles Check31.CheckedChanged


        If Check31.Checked = True Then
            chb = chb + 1
            colum(chb) = "Country"
            Valu(chb) = "'" & dlcountry.Text & "'"
            Check31.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(31)
            Check31.Checked = False
        End If
    End Sub
    Protected Sub Check36_CheckedChanged(sender As Object, e As EventArgs) Handles Check36.CheckedChanged
        If Check36.Checked = True Then
            chb = chb + 1
            colum(chb) = "Name_of_Mother"
            Valu(chb) = "'" & tNmother.Text & "'"
            Check36.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(36)
            Check36.Checked = False
        End If
    End Sub
    Protected Sub Check37_CheckedChanged(sender As Object, e As EventArgs) Handles Check37.CheckedChanged
        If Check37.Checked = True Then
            chb = chb + 1
            colum(chb) = "Name_of_Father"
            Valu(chb) = "'" & tNfather.Text & "'"
            Check37.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(37)
            Check37.Checked = False
        End If
    End Sub
    Protected Sub Check38_CheckedChanged(sender As Object, e As EventArgs) Handles Check38.CheckedChanged


        If Check38.Checked = True Then
            chb = chb + 1
            colum(chb) = "Occupation_of_Mother"
            Valu(chb) = "'" & tOmother.Text & "'"
            Check38.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(38)
            Check38.Checked = False
        End If
    End Sub
    Protected Sub Check39_CheckedChanged(sender As Object, e As EventArgs) Handles Check39.CheckedChanged
        If Check39.Checked = True Then
            chb = chb + 1
            colum(chb) = "Occupation_of_Father"
            Valu(chb) = "'" & tOfather.Text & "'"
            Check39.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(39)
            Check39.Checked = False
        End If
    End Sub
    Protected Sub Check40_CheckedChanged(sender As Object, e As EventArgs) Handles Check40.CheckedChanged
        If Check40.Checked = True Then
            chb = chb + 1
            colum(chb) = "Brothers"
            Valu(chb) = "'" & dlbro.Text & "'"
            Check40.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(40)
            Check40.Checked = False
        End If
    End Sub
    Protected Sub Check41_CheckedChanged(sender As Object, e As EventArgs) Handles Check41.CheckedChanged


        If Check41.Checked = True Then
            chb = chb + 1
            colum(chb) = "Sisters"
            Valu(chb) = "'" & dlsis.Text & "'"
            Check41.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(41)
            Check41.Checked = False
        End If
    End Sub
    Protected Sub Check42_CheckedChanged(sender As Object, e As EventArgs) Handles Check42.CheckedChanged
        If Check42.Checked = True Then
            chb = chb + 1
            colum(chb) = "Name_of_Guardian"
            Valu(chb) = "'" & tNguardian.Text & "'"
            Check42.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(42)
            Check42.Checked = False
        End If
    End Sub
    Protected Sub Check43_CheckedChanged(sender As Object, e As EventArgs) Handles Check43.CheckedChanged
        If Check43.Checked = True Then
            chb = chb + 1
            colum(chb) = "Relation_with_Guardian"
            Valu(chb) = "'" & tRguardian.Text & "'"
            Check43.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(43)
            Check43.Checked = False
        End If
    End Sub
    Protected Sub Check44_CheckedChanged(sender As Object, e As EventArgs) Handles Check44.CheckedChanged


        If Check44.Checked = True Then
            chec44 = 1
            Response.Write(chec44)
            'chb = chb + 1
            colum(0) = "Admsn_Number"
            Valu(0) = "'" & tadmsn.Text & "'"
            Check44.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(44)
            Check44.Checked = False

        Else
            chec44 = 0

        End If
    End Sub
    Protected Sub Check45_CheckedChanged(sender As Object, e As EventArgs) Handles Check45.CheckedChanged
        If Check45.Checked = True Then
            chb = chb + 1
            colum(chb) = "SSSMID"
            Valu(chb) = "'" & tsssm.Text & "'"
            Check45.BackColor = ColorTranslator.FromHtml("cornflowerblue")

            Session("tst").add(45)
            Check45.Checked = False
        End If
    End Sub
    Protected Sub Check46_CheckedChanged(sender As Object, e As EventArgs) Handles Check46.CheckedChanged

        If Check46.Checked = True Then
            chb = chb + 1
            colum(chb) = "Aadhar_Number"
            Valu(chb) = "'" & taadhar.Text & "'"
            Check46.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(46)
            Check46.Checked = False
        End If
    End Sub
    Protected Sub Check47_CheckedChanged(sender As Object, e As EventArgs) Handles Check47.CheckedChanged
        If Check47.Checked = True Then
            chb = chb + 1
            colum(chb) = "Enrollment_Number"
            Valu(chb) = "'" & tEnrlNo.Text & "'"
            Check47.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(47)
            Check47.Checked = False
        End If
    End Sub
    Protected Sub Check48_CheckedChanged(sender As Object, e As EventArgs) Handles Check48.CheckedChanged

        If Check48.Checked = True Then
            chb = chb + 1
            colum(chb) = "Date_of_Enrollment"
            Valu(chb) = "'" & tdoe.Text & "'"
            Check48.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(48)
            Check48.Checked = False
        End If
    End Sub
    Protected Sub Check49_CheckedChanged(sender As Object, e As EventArgs) Handles Check49.CheckedChanged
        If Check49.Checked = True Then
            chb = chb + 1
            colum(chb) = "Date_of_Leaving_the_Last_School"
            Valu(chb) = "'" & tdol.Text & "'"
            Check49.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(49)
            Check49.Checked = False
        End If
    End Sub
    Protected Sub Check50_CheckedChanged(sender As Object, e As EventArgs) Handles Check50.CheckedChanged

        If Check50.Checked = True Then
            chb = chb + 1
            colum(chb) = "Date_of_Leaving_This_School"
            Valu(chb) = "'" & tdot.Text & "'"
            Check50.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(50)
            Check50.Checked = False
        End If
    End Sub
    Protected Sub Check51_CheckedChanged(sender As Object, e As EventArgs) Handles Check51.CheckedChanged
        If Check51.Checked = True Then
            chb = chb + 1
            colum(chb) = "Last_Class_in_the_Last_School"
            Valu(chb) = "'" & dlLastClass.Text & "'"
            Check51.BackColor = ColorTranslator.FromHtml("cornflowerblue")
            Session("tst").add(51)
            Check51.Checked = False
        End If
    End Sub
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Session("back4") = "1"
        Response.Redirect("EditPage1.aspx")
    End Sub
    Protected Sub chk_TextChanged(sender As Object, e As EventArgs) Handles chk.TextChanged
        Session("edit5") = ""
        Session("index2") = 0
        Session("sortcheck") = ""
        Session("txb1") = chk.Text.Trim()
        Session("search") = "21"
        Response.Redirect("EditPage1.aspx")
    End Sub
    Protected Sub TextBox73_TextChanged(sender As Object, e As EventArgs) Handles TextBox73.TextChanged
        Session("edit5") = ""
        If Val(TextBox73.Text.Trim()) <= Convert.ToInt32(Session("max")) And Val(TextBox73.Text.Trim()) >= 1 Then

            Session("indexint2") = TextBox73.Text
            Session("indexchec") = "1"
            Response.Redirect("EditPage1.aspx")
        End If
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        chk.Text = ""
        TextBox73.Text = ""
        Call chk_TextChanged(sender, e)
    End Sub

    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Session("k") = "1"
        Response.Redirect("EditPage1.aspx")



    End Sub
    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Session("k") = "2"
        Response.Redirect("EditPage1.aspx")
    End Sub



End Class
