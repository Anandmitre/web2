
Partial Class dates1
    Inherits System.Web.UI.Page
    Public Shared Function GetDateTime() As DateTime
        Dim dateTime As DateTime = DateTime.MinValue
        Dim request As System.Net.HttpWebRequest = DirectCast(System.Net.WebRequest.Create("http://www.microsoft.com"), System.Net.HttpWebRequest)
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
        REM .ToString("dd-MM-yyyy   hh:mm:ss  tt")
    End Function

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try


            Dim x As String
            Dim p As DateTime
            p = GetDateTime()
        x = p.ToString("dd  -  MMM  -  yyyy  hh:  mm:   ss  tt  -----")
        Response.Write(x)

        Dim s As String
            s = DateTime.Now.ToString("dd  -  MMM  -  yyyy  hh:  mm:   ss  tt  -----")
            Response.Write(s)
        Catch ex As Exception
            Response.Write("Connection problem")


        End Try

    End Sub
End Class
