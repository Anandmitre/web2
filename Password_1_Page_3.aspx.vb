Imports System.Data.SqlClient
Partial Class Password_1_Page_3
    Inherits System.Web.UI.Page
    Dim conn As SqlConnection
    Dim com As SqlCommand
    Dim rd As SqlDataReader

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'If Session("user") = Nothing Then
        'Session.Clear()
        'Session.RemoveAll()
        'Session.Abandon()
        'Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1D))
        'Response.Cache.SetCacheability(HttpCacheability.NoCache)
        'Response.Cache.SetNoStore()
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "ClearHistory", "Clearhistory()", True)
        ' End If

        conn = New SqlConnection
        conn.ConnectionString = ConfigurationManager.ConnectionStrings("masterConnectionString1").ConnectionString
        Try

            conn.Open()
            Dim query As String
            query = "select * from Admin1 where Password='" & TextBox1.Text & "'"
            com = New SqlCommand(query, conn)
            rd = com.ExecuteReader
            Dim count As Integer
            count = 0
            While rd.Read
                count = count + 1

            End While

            If count = 1 Then


                Session("app5") = "1"



                Response.Write("<script>window.location.href = 'Session_1_Page_1.aspx' </script>")


            ElseIf TextBox1.Text <> "" Then
                Session("check1") = "4"
                'Response.Write("Incorrect Password!!!")
                Response.Write("<script>    window.location.href = 'Password_1_Page_3.aspx' </script>")
            Else
                'Response.Write("Enter the Password")
                Session("check1") = "3"
                Response.Write("<script>  window.location.href = 'Password_1_Page_3.aspx' </script>")

            End If

            REM Response.Redirect("Default.aspx")



            conn.Close()


        Catch ex As SqlException
            Response.Write("Error")
        Finally
            conn.Dispose()

        End Try
        ' Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1))
        ' Response.Cache.SetCacheability(HttpCacheability.NoCache)
        'Response.Cache.SetNoStore()

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        'If Session("user") = Nothing Then
        'Session.Clear()
        'Session.RemoveAll()
        'Session.Abandon()
        'Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1D))
        'Response.Cache.SetCacheability(HttpCacheability.NoCache)
        'Response.Cache.SetNoStore()
        'Page.ClientScript.RegisterStartupScript(Me.GetType(), "ClearHistory", "Clearhistory()", True)
        ' End If

        Session("app") = ""
        Session("app2") = ""
        Session("app3") = ""
        Session("app4") = ""
        Session("app5") = ""
        ' Session("check1") = 3
        Response.Write("<script>window.location.href = 'Session_1_Page_1.aspx' </script>") 'Response.Redirect("Session_1_Page_1.aspx")
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("user") = Nothing Then
            'Dim sc As String = "<script> alert ('session expired'); window.location.href = 'Default.aspx'</script>"
            Dim sc As String = "<script> window.location.href = 'Default.aspx'</script>"
            Response.Write(sc)
        End If

        If Session("check1") = "4" Then

            ch2.InnerHtml = " <center> <h2> Incorrect Password!!!</h2> </center>"
            Session("check1") = Nothing
        ElseIf Session("check1") = "3" Then
            ch2.InnerHtml = " <center> <h2> Enter The Password</h2> </center>"
            Session("check1") = Nothing

        End If


    End Sub
End Class
