<%@ Application Language="VB" %>
<script runat="server">

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)

        REM Application("app6") = ""

    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application shutdown
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when an unhandled error occurs
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        Session("del1") = Nothing
        Session("thispage") = Nothing
        Session("indexint1") = Nothing
        Session("indexint2") = Nothing
        Session("submit") = Nothing
        Session("app") = ""
        Session("app2") = ""
        Session("app3") = ""
        Session("app4") = ""
        Session("app5") = ""
        Session("IST") = Nothing
        Session("admsn2") = Nothing
        Session("user") = ""
        Session("sort_expression") = "Class_Std"
        Session("sort1_expression") = "Class_Std"
        Session("index") = Nothing
        Session("1index") = Nothing

        Session("dv") = Nothing
        Session("dv1") = Nothing
        Session("x1") = Nothing
        Session("direction") = ""
        Session("direction1") = ""
        Session("sortcheck") = ""
        Session("sortcheck1") = ""
        Session("dt") = Nothing
        Session("index2") = Nothing
        Session("2index") = Nothing

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
        Session("grid") = Nothing
        Session("default") = ""
        Session.Timeout = 10000
        Session("logout2") = ""
        Session("edit5") = Nothing
        Session("Class_Std") = Nothing
        Session("Fee_Updated") = Nothing
        'Session("dt10") = Nothing
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)

        'Session("app") = Nothing
        ' Session("app2") = Nothing
        'Session("app3") = Nothing
        ' Session("app4") = Nothing
        ' Session("app5") = Nothing
        ' Session("user") = Nothing
        '  Session.Abandon()
        ' Session.Clear()
        ' Session.RemoveAll()
        ' Session.Abandon()



        ' Code that runs when a session ends. 
        ' Note: The Session_End event is raised only when the sessionstate mode
        ' is set to InProc in the Web.config file. If session mode is set to StateServer 
        ' or SQLServer, the event is not raised.
    End Sub

</script>