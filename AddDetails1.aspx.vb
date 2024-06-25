Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web.Configuration
Imports System.Data
Imports System.Drawing
Imports Class1
Imports System.Collections
Imports System.Text.RegularExpressions
Imports System.Web.UI.WebControls
Partial Class AddDetails1
    Inherits System.Web.UI.Page

    Dim conn As SqlConnection
    Dim com As SqlCommand
    Dim rd As SqlDataReader

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        If IsPostBack = False Then
            If Session("addnew1") = "1" Then
                Label1.Text = "New Student Added Successfully."
                Session("addnew1") = Nothing
            ElseIf Session("addnew1") = "0" Then
                Label1.Text = "Error: Enter Proper Details!"
                Session("addnew1") = Nothing
            End If


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


            dlbro.Items.Add(0)
            dlsis.Items.Add(0)
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

            dlLastClass.Items.Add("")
            dlLastClass.Items.Add("Nursery")
            dlLastClass.Items.Add("LKG")
            dlLastClass.Items.Add("UKG")

            For k = 1 To 12
                dlLastClass.Items.Add(k)
            Next




        End If







    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call addnew1()
        Response.Redirect("AddDetails1.aspx")

    End Sub
    Private Function addnew1() As String
        Try
            If tadmsn.Text <> "" Then
                conn = New SqlConnection
                conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
                conn.Open()
                Dim pt(47) As SqlParameter
                pt(47) = New SqlParameter("@param21", SqlDbType.VarChar)
                pt(47).Value = Session("cursession")

                pt(0) = New SqlParameter("@param20", SqlDbType.VarChar)
                pt(0).Value = "''"

                pt(1) = New SqlParameter("@param22", SqlDbType.VarChar)
                pt(1).Value = "'" & trollno.Text.Trim() & "'"
                pt(2) = New SqlParameter("@param23", SqlDbType.VarChar)
                pt(2).Value = "'" & tname.Text.Trim() & "'"
                pt(3) = New SqlParameter("@param24", SqlDbType.VarChar)
                pt(3).Value = "'" & tsurname.Text.Trim() & "'"
                pt(4) = New SqlParameter("@param25", SqlDbType.VarChar)
                pt(4).Value = "'" & dlgender.Text.Trim() & "'"
                pt(5) = New SqlParameter("@param26", SqlDbType.VarChar)
                pt(5).Value = "'" & dlclass.Text.Trim() & "'"
                pt(6) = New SqlParameter("@param27", SqlDbType.VarChar)
                pt(6).Value = "'" & dlsection.Text.Trim() & "'"
                pt(7) = New SqlParameter("@param28", SqlDbType.VarChar)
                pt(7).Value = "'" & tFphone.Text.Trim() & "'"
                pt(8) = New SqlParameter("@param29", SqlDbType.VarChar)
                pt(8).Value = "'" & tdob.Text.Trim() & "'"
                pt(9) = New SqlParameter("@param30", SqlDbType.VarChar)
                pt(9).Value = "'" & tage.Text.Trim() & "'"
                pt(10) = New SqlParameter("@param31", SqlDbType.VarChar)
                pt(10).Value = "'" & tsssm.Text.Trim() & "'"
                pt(11) = New SqlParameter("@param32", SqlDbType.VarChar)
                pt(11).Value = "'" & tadmsn.Text.Trim() & "'"
                pt(12) = New SqlParameter("@param33", SqlDbType.VarChar)
                pt(12).Value = "'" & taadhar.Text.Trim() & "'"
                pt(13) = New SqlParameter("@param34", SqlDbType.VarChar)
                pt(13).Value = "'" & tNmother.Text.Trim() & "'"
                pt(14) = New SqlParameter("@param35", SqlDbType.VarChar)
                pt(14).Value = "'" & tNfather.Text.Trim() & "'"
                pt(15) = New SqlParameter("@param36", SqlDbType.VarChar)
                pt(15).Value = "'" & dlcateg.Text.Trim() & "'"
                pt(16) = New SqlParameter("@param37", SqlDbType.VarChar)
                pt(16).Value = "'" & tLaddress.Text.Trim() & "'"
                pt(17) = New SqlParameter("@param38", SqlDbType.VarChar)
                pt(17).Value = "'" & tTown.Text.Trim() & "'"
                pt(18) = New SqlParameter("@param39", SqlDbType.VarChar)
                pt(18).Value = "'" & dlstate.Text.Trim() & "'"
                pt(19) = New SqlParameter("@param40", SqlDbType.VarChar)
                pt(19).Value = "'" & tpin.Text.Trim() & "'"
                pt(20) = New SqlParameter("@param41", SqlDbType.VarChar)
                pt(20).Value = "'" & tMphone.Text.Trim() & "'"
                pt(21) = New SqlParameter("@param42", SqlDbType.VarChar)
                pt(21).Value = "'" & tOphone.Text.Trim() & "'"
                pt(22) = New SqlParameter("@param43", SqlDbType.VarChar)
                pt(22).Value = "'" & tNguardian.Text.Trim() & "'"
                pt(23) = New SqlParameter("@param44", SqlDbType.VarChar)
                pt(23).Value = "'" & tRguardian.Text.Trim() & "'"
                pt(24) = New SqlParameter("@param45", SqlDbType.VarChar)
                pt(24).Value = "'" & tGphone.Text.Trim() & "'"
                pt(25) = New SqlParameter("@param46", SqlDbType.VarChar)
                pt(25).Value = "'" & temail.Text.Trim() & "'"
                pt(26) = New SqlParameter("@param47", SqlDbType.VarChar)
                pt(26).Value = "'" & tPaddress.Text.Trim() & "'"
                pt(27) = New SqlParameter("@param48", SqlDbType.VarChar)
                pt(27).Value = "'" & tcity.Text.Trim() & "'"
                pt(28) = New SqlParameter("@param49", SqlDbType.VarChar)
                pt(28).Value = "'" & dlprovince.Text.Trim() & "'"
                pt(29) = New SqlParameter("@param50", SqlDbType.VarChar)
                pt(29).Value = "'" & tzip.Text.Trim() & "'"
                pt(30) = New SqlParameter("@param51", SqlDbType.VarChar)
                pt(30).Value = "'" & tOmother.Text.Trim() & "'"
                pt(31) = New SqlParameter("@param52", SqlDbType.VarChar)
                pt(31).Value = "'" & tOfather.Text.Trim() & "'"
                pt(32) = New SqlParameter("@param53", SqlDbType.VarChar)
                pt(32).Value = "'" & dlbro.Text.Trim() & "'"
                pt(33) = New SqlParameter("@param54", SqlDbType.VarChar)
                pt(33).Value = "'" & dlsis.Text.Trim() & "'"
                pt(34) = New SqlParameter("@param55", SqlDbType.VarChar)
                pt(34).Value = "'" & dlheight.Text.Trim() & "'"
                pt(35) = New SqlParameter("@param56", SqlDbType.VarChar)
                pt(35).Value = "'" & dlweight.Text.Trim() & "'"
                pt(36) = New SqlParameter("@param57", SqlDbType.VarChar)
                pt(36).Value = "'" & tAcSkill.Text.Trim() & "'"
                pt(37) = New SqlParameter("@param58", SqlDbType.VarChar)
                pt(37).Value = "'" & tOSkill.Text.Trim() & "'"
                pt(38) = New SqlParameter("@param59", SqlDbType.VarChar)
                pt(38).Value = "'" & thobbies.Text.Trim() & "'"
                pt(39) = New SqlParameter("@param60", SqlDbType.VarChar)
                pt(39).Value = "'" & dlDiAbled.Text.Trim() & "'"
                pt(40) = New SqlParameter("@param61", SqlDbType.VarChar)
                pt(40).Value = "'" & tKindAbility.Text.Trim() & "'"
                pt(41) = New SqlParameter("@param62", SqlDbType.VarChar)
                pt(41).Value = "'" & tEnrlNo.Text.Trim() & "'"
                pt(42) = New SqlParameter("@param63", SqlDbType.VarChar)
                pt(42).Value = "'" & tdoe.Text.Trim() & "'"
                pt(43) = New SqlParameter("@param64", SqlDbType.VarChar)
                pt(43).Value = "'" & tdol.Text.Trim() & "'"
                pt(44) = New SqlParameter("@param65", SqlDbType.VarChar)
                pt(44).Value = "'" & dlLastClass.Text.Trim() & "'"
                pt(45) = New SqlParameter("@param66", SqlDbType.VarChar)
                pt(45).Value = "'" & tdot.Text.Trim() & "'"
                pt(46) = New SqlParameter("@param67", SqlDbType.VarChar)
                pt(46).Value = "'" & dlcountry.Text.Trim() & "'"

                ' indigit table name is written in sqr bracket as : query = update [2020-21]
                'query = "update [2020-21] set Name_of_Student= '" & tname.Text & "' where SSSMID= '" & tsssm.Text & "' "   'Session("cursession")
                'com = New SqlCommand(query, conn)



                Dim com As New SqlCommand
                com.Connection = conn
                com.CommandType = CommandType.StoredProcedure
                com.CommandText = "AddNew"
                com.Parameters.AddRange(pt)
                rd = com.ExecuteReader
                rd.Read()
                rd.Close()
                'com.Parameters.Clear()

                conn.Close()
                conn.Dispose()

                Session("addnew1") = "1"
                Session("admsn2") = tadmsn.Text.Trim()
                Session("addnew5") = "0"

            Else
                Session("addnew1") = "0"
            End If
        Catch ex As SqlException
            Response.Write(ex)
            ' MsgBox(ex.ToString)
        End Try
        Return 0
    End Function

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Session("addnew5") = "0" Then
            Session("addnew5") = "1"
            Response.Redirect("Student_Details1.aspx")
        Else
            Response.Redirect("ViewDetails1.aspx")
        End If
    End Sub
End Class
