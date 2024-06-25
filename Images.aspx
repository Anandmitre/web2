<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Images.aspx.vb" Inherits="Images" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." Height="249px" Width="558px">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [image1] FROM [images]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString1 %>" ProviderName="<%$ ConnectionStrings:masterConnectionString1.ProviderName %>" SelectCommand="SELECT [image1] FROM [images]"></asp:SqlDataSource>
    </form>
</body>
</html>
