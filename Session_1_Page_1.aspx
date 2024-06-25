
<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Session_1_Page_1.aspx.vb" Inherits="Session_1_Page_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style16 {
            text-align: center;
        }
        .auto-style18 {
            margin-left: 12px;
        }
        .auto-style39 {
            margin-left: 0px;
            margin-top: 0px;
        }
        .auto-style46 {
            margin-top: 0px;
        }
        .auto-style49 {
            table-layout: auto;
            height: 529px;
        }
        .auto-style50 {
            text-align: left;
        }
        .auto-style51 {
            width: 97%;
            height: 377px;
        }
        .auto-style52 {
            width: 1884px;
            height: 247px;
        }
        .auto-style54 {
            width: 398px;
            height: 247px;
        }
        .auto-style56 {
            width: 640px;
            height: 33px;
        }
        .auto-style58 {
            width: 398px;
            height: 33px;
            text-align: center;
        }
        .auto-style59 {
            width: 640px;
            text-align: center;
            height: 8px;
        }
        .auto-style67 {
            width: 206px;
        }
        .auto-style70 {
            text-align: center;
            width: 47px;
            height: 43px;
        }
        .auto-style71 {
            width: 47px;
        }
        .auto-style72 {
            text-align: center;
            height: 43px;
        }
        .auto-style85 {
            width: 398px;
            height: 5px;
            text-align: left;
        }
        .auto-style87 {
            width: 398px;
            height: 97px;
            text-align: center;
        }
        .auto-style88 {
            margin-left: 0px;
            margin-top: 0px;
            margin-bottom: 0px;
        }
        .auto-style91 {
            width: 640px;
            height: 5px;
        }
        .auto-style92 {
            width: 640px;
            height: 97px;
            text-align: center;
        }
        .auto-style93 {
            width: 640px;
            height: 247px;
        }
        .auto-style95 {
            width: 89px;
            text-align: left;
            height: 8px;
        }
        .auto-style96 {
            width: 89px;
        }
        .auto-style98 {
            width: 1884px;
            height: 8px;
            text-align: center;
        }
        .auto-style99 {
            width: 398px;
            height: 8px;
            text-align: center;
        }
        .auto-style100 {
            width: 206px;
            height: 8px;
        }
        .auto-style101 {
            width: 47px;
            height: 8px;
        }
        .auto-style102 {
            width: 1884px;
            text-align: center;
        }
        .auto-style103 {
            width: 1884px;
            height: 33px;
        }
        .auto-style104 {
            width: 89px;
            height: 247px;
        }
        .auto-style105 {
            width: 206px;
            height: 247px;
        }
        .auto-style106 {
            width: 47px;
            height: 247px;
        }
        .auto-style107 {
            width: 89px;
            height: 5px;
        }
        .auto-style108 {
            width: 1884px;
            height: 5px;
            text-align: center;
        }
        .auto-style109 {
            width: 206px;
            height: 5px;
        }
        .auto-style110 {
            width: 47px;
            height: 5px;
        }
        </style>

      
</head>
<body>





    <form id="form1" runat="server" class="auto-style49" style="border-spacing: inherit">
     <div>
    

    </div>
                    <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Names="Corbel" Font-Size="Large" ForeColor="#993300" Text="Home" CssClass="auto-style18" Height="41px" Width="95px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button6" runat="server" Font-Bold="True" Font-Names="Corbel"  Font-Size="Large" ForeColor="#993300" Height="41px" Text="Reset" Width="97px" CssClass="auto-style46" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button7" runat="server" Font-Bold="True" Font-Names="Corbel" Font-Size="Large" ForeColor="#993300" Height="41px" Text="Logout" Width="97px" CssClass="auto-style46" />
        <br />
        <div id= "ch4" runat="server" style="color:tomato"></div>
                <div class="auto-style50">
            &nbsp;<table class="auto-style51">
                <tr>
                    <td class="auto-style72" colspan="5">
                        &nbsp;
                    </td>
                    <td class="auto-style70"></td>
                </tr>
                <tr>
                    <td class="auto-style91">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" Text="Session Name" Font-Size="Large"></asp:Label>
                    </td>
                    <td class="auto-style107">
                    </td>
                    <td class="auto-style108">
                        <asp:Label ID="Label7" runat="server" Text="Current Session :    " Font-Bold="True" Font-Size="Large"></asp:Label>
                    </td>
                    <td class="auto-style85">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" Text="Select a Session to Start" Font-Size="Large"></asp:Label>
                    </td>
                    <td class="auto-style109">
                    </td>
                    <td class="auto-style110"></td>
                </tr>
                <tr>
                    <td class="auto-style59">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="Large" Height="32px" Width="211px" ViewStateMode="Enabled" CssClass="auto-style46" BorderColor="Black" BorderStyle="Inset"></asp:TextBox>
                    </td>
                    <td class="auto-style95">
                    </td>
                    <td class="auto-style98">
                        <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="True" ForeColor="#CC0000" Text="No Session is Running"></asp:Label>
                    </td>
                    <td class="auto-style99">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Session" DataValueField="Session" Font-Bold="True" Font-Names="Corbel" Font-Overline="False" Font-Size="X-Large" ForeColor="#993300" Height="40px" CssClass="auto-style39" Width="201px" EnableViewState="False">
                    </asp:DropDownList>
                    </td>
                    <td class="auto-style100">
                    </td>
                    <td class="auto-style101">
                    </td>
                </tr>
                <tr>
                    <td class="auto-style92">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Names="Corbel" Font-Size="Large" ForeColor="#993300" Height="38px" Text="Create Session" Width="138px" CssClass="auto-style46" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="auto-style96" rowspan="2">
                        &nbsp;</td>
                    <td class="auto-style102">
                    &nbsp;
                    <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Names="Corbel" Font-Size="Large" ForeColor="#993300" Height="37px" Text="Close the Session" Width="155px" CssClass="auto-style88" />
                    </td>
                    <td class="auto-style87">&nbsp;&nbsp; <asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Names="Corbel" Font-Size="Large" ForeColor="#993300" Height="38px" Text="Start the Session" Width="149px" CssClass="auto-style39" />
                    </td>
                    <td class="auto-style67" rowspan="2">
                        &nbsp;</td>
                    <td class="auto-style71" rowspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style56"></td>
                    <td class="auto-style103">
                    </td>
                    <td class="auto-style58">&nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="auto-style93"></td>
                    <td class="auto-style104"></td>
                    <td class="auto-style52">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style54"></td>
                    <td class="auto-style105"></td>
                    <td class="auto-style106"></td>
                </tr>
            </table>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
        </div>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <div class="auto-style16">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString1 %>" SelectCommand="SELECT [Session] FROM [Session]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
