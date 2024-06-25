<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 93%;
            margin-top: 0px;
            height: 257px;
        }
        .auto-style7 {
            text-align: center;
            width: 240px;
            margin-left: 80px;
            height: 52px;
        }
        .auto-style8 {
            width: 240px;
            height: 43px;
            color: #990000;
            font-size: x-large;
            font-family: corbel;
            font-weight: bold;
            text-align: center;
        }
        .auto-style17 {
            margin-left: 0px;
        }
        .auto-style28 {
            text-align: center;
            width: 240px;
            height: 73px;
        }
        .auto-style31 {
            text-align: right;
            color: #CC0000;
        }
        .auto-style37 {
            color: #CC0000;
        }
        .auto-style38 {
            color: #990000;
        }
        .auto-style39 {
            color: #CC0000;
            text-align: center;
            height: 37px;
        }
        .auto-style48 {
            text-align: right;
        }
        .auto-style50 {
            margin-top: 39px;
        }
        .auto-style51 {
            height: 1px;
            text-align: center;
        }
        .auto-style52 {
            color: #CC0000;
            text-align: center;
            height: 11px;
        }
        .auto-style54 {
            text-align: center;
            height: 103px;
        }
        .auto-style55 {
            height: 43px;
            width: 540px;
        }
        .auto-style58 {
            text-align: center;
            width: 675px;
            height: 103px;
        }
        .auto-style62 {
            width: 675px;
            height: 73px;
            text-align: right;
        }
        .auto-style63 {
            height: 43px;
            width: 675px;
        }
        .auto-style66 {
            height: 73px;
            text-align: left;
            width: 540px;
        }
        .auto-style67 {
            height: 52px;
            width: 675px;
            text-align: right;
        }
        .auto-style68 {
            height: 52px;
            text-align: left;
            width: 540px;
        }
        .auto-style69 {
            text-align: center;
            width: 240px;
            height: 103px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="button1">
        <div class="auto-style48">
        <h1 class="auto-style52"><span class="auto-style38">&nbsp;&nbsp;&nbsp;&nbsp;</span></h1>
            <h1 class="auto-style39"><span class="auto-style38">&nbsp; Chandrabhan Singh Public School Chanderi&nbsp;&nbsp;</span>&nbsp;</h1>
            <div  id= "ch3"   runat="server" style= "color:olive"> </div>
               <div>   <asp:Button ID="Button2" runat="server"  Font-Bold="True" Font-Names="Corbel" Font-Size="X-Large" ForeColor="#993300" Height="39px" Text="Forward" Width="95px" CssClass="auto-style37" TabIndex="5" CausesValidation="False" />
  
            </div>
  
        <table class="auto-style1">
            <tr>
                <td class="auto-style51"   style="font-size: x-large; font-family: corbel; font-weight: bold; color: #993300" colspan="3"></td>
            </tr>
            <tr>
                <td class="auto-style63" style="font-size: x-large; font-family: corbel; font-weight: bold; color: #993300"></td>
                <td class="auto-style8">Login into Database</td>
                <td class="auto-style55" style="font-size: x-large; font-family: corbel; font-weight: bold; color: #993300"></td>
            </tr>
            <tr>
                <td class="auto-style62" style="color: #993300; font-family: Corbel; font-size: x-large; font-weight: bold;">Username</td>
                <td class="auto-style28" style="font-size: x-large; font-family: corbel; font-weight: bold; color: #993300">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style17"  Font-Bold="True" Font-Names="Calibri" Font-Overline="False" Font-Size="Large" Height="39px" Width="230px" EnableViewState="False" ViewStateMode="Enabled" AutoCompleteType="Disabled"></asp:TextBox>
                </td>
                <td class="auto-style66" style="font-size: x-large; font-family: corbel; font-weight: bold; color: #993300">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" Font-Size="Large" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style67" style="font-size: x-large; font-family: corbel; font-weight: bold; color: #993300">Password</td>
                <td class="auto-style7" style="font-size: x-large; font-family: corbel; font-weight: bold; color: #993300">
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style17"   Font-Bold="True" Font-Names="Calibri" Font-Overline="False" Font-Size="Large" Height="39px" TextMode="Password" Width="230px" MaxLength="6" ViewStateMode="Enabled" AutoCompleteType="Disabled"></asp:TextBox>
                </td>
                <td style="font-size: x-large; font-family: corbel; font-weight: bold; color: #993300" class="auto-style68">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator" Font-Size="Large" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style58" style="font-size: x-large; font-family: corbel; font-weight: bold; color: #993300">
                </td>
                <td class="auto-style69" style="font-size: x-large; font-family: corbel; font-weight: bold; color: #993300">
                    <asp:Button id= "Button1" runat="server" type="IButtonControl"  Font-Bold="True" Font-Names="Corbel" Font-Size="X-Large" ForeColor="#993300" Height="40px" Text="Submit" Width="125px" Deafultfocus="Button1" EnableTheming="True" CssClass="auto-style50" />
                    </td>
                <td class="auto-style54" style="font-size: x-large; font-family: corbel; font-weight: bold; color: #993300"></td>
            </tr>
            </table>
            </div>
          <p class="auto-style31">
                    &nbsp;</p>
        <p>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString1 %>" SelectCommand="SELECT * FROM [Admin1]"></asp:SqlDataSource>
        </p>
    <div>
    
    </div>
        
    
        
    </form>
</body>
</html>
