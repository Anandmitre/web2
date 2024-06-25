<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Fee_Master1.aspx.vb" Inherits="Fee_Master1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1291px;
            height: 522px;
        }
        .auto-style29 {
            height: 27px;
            text-align: center;
            font-size: xx-large;
            }
        .auto-style30 {
            height: 27px;
            font-size: large;
            text-decoration: underline;
            width: 245px;
            right: 0px;
            font-weight: bold;
            text-align: right;
        }
        .auto-style68 {
            font-size: medium;
        }
        .auto-style69 {
            font-size: medium;
        }
        .auto-style75 {
            width: 120px;
            height: 14px;
            text-align: left;
        }
        .auto-style76 {
            width: 308px;
            height: 14px;
            text-align: right;
        }
        .auto-style80 {
            width: 245px;
            height: 21px;
            text-align: right;
            right: 0px;
        }
        .auto-style83 {
            width: 120px;
            height: 21px;
            text-align: left;
        }
        .auto-style84 {
            width: 308px;
            height: 21px;
            text-align: right;
        }
        .auto-style101 {
            font-size: xx-large;
            text-decoration: underline;
            width: 245px;
            right: 0px;
            height: 1px;
        }
        .auto-style130 {
            width: 120px;
            height: 31px;
            text-align: left;
        }
        .auto-style131 {
            width: 308px;
            height: 31px;
            }
        .auto-style153 {
            text-decoration: underline;
        }
        .auto-style158 {
            height: 12px;
            text-align: center;
        }
        .auto-style165 {
            height: 31px;
            width: 226px;
        }
        .auto-style166 {
            height: 14px;
            width: 226px;
        }
        .auto-style167 {
            height: 21px;
            width: 226px;
        }
        .auto-style183 {
            width: 282px;
            height: 21px;
            text-align: right;
        }
        .auto-style197 {
            width: 245px;
            height: 39px;
            text-align: right;
        }
        .auto-style199 {
            height: 39px;
            text-align: right;
        }
        .auto-style200 {
            width: 308px;
            height: 39px;
            text-align: left;
        }
        .auto-style201 {
            height: 39px;
            width: 226px;
        }
        .auto-style206 {
            height: 5px;
            text-align: right;
            font-size: xx-large;
            text-decoration: underline;
            width: 120px;
        }
        .auto-style208 {
            width: 308px;
            height: 5px;
            text-align: right;
        }
        .auto-style210 {
            height: 5px;
            font-size: xx-large;
            text-decoration: underline;
            width: 245px;
            text-align: right;
            right: 0px;
        }
        .auto-style211 {
            height: 5px;
            width: 226px;
        }
        .auto-style221 {
            width: 282px;
            height: 31px;
            text-align: right;
        }
        .auto-style222 {
            width: 282px;
            height: 14px;
            text-align: right;
        }
        .auto-style223 {
            width: 130px;
            height: 14px;
            text-align: left;
        }
        .auto-style224 {
            width: 130px;
            height: 21px;
            text-align: left;
        }
        .auto-style230 {
            width: 245px;
            height: 31px;
            text-align: right;
            right: auto;
        }
        .auto-style231 {
            width: 245px;
            height: 14px;
            text-align: right;
            right: 0px;
        }
        .auto-style235 {
            width: 130px;
            height: 39px;
            right: 0px;
            text-align: left;
        }
        .auto-style236 {
            width: 130px;
            height: 64px;
            right: 0px;
        }
        .auto-style237 {
            height: 5px;
            text-align: left;
            font-size: xx-large;
            text-decoration: underline;
            width: 130px;
        }
        .auto-style240 {
            height: 31px;
            width: 130px;
        }
        .auto-style241 {
            height: 5px;
            font-size: xx-large;
            text-decoration: underline;
            width: 282px;
        }
        .auto-style242 {
            text-align: left;
            font-size: xx-large;
            text-decoration: underline;
            width: 282px;
            height: 1px;
        }
        .auto-style245 {
            margin-left: 0px;
        }
        .auto-style246 {
            font-weight: bold;
            font-size: medium;
        }
        .auto-style247 {
            height: 64px;
            text-align: right;
            width: 282px;
        }
        .auto-style250 {
            height: 64px;
            width: 245px;
        }
        .auto-style256 {
            height: 17px;
            width: 226px;
        }
        .auto-style257 {
            height: 64px;
            text-align: left;
            width: 120px;
        }
        .auto-style258 {
            width: 245px;
            text-align: right;
            right: 0px;
            height: 17px;
        }
        .auto-style259 {
            width: 130px;
            text-align: left;
            height: 17px;
        }
        .auto-style262 {
            width: 308px;
            text-align: right;
            height: 17px;
        }
        .auto-style263 {
            width: 282px;
            height: 17px;
            text-align: right;
        }
        .auto-style264 {
            width: 120px;
            height: 17px;
            text-align: left;
        }
        .auto-style265 {
            width: 245px;
            text-align: right;
            right: 0px;
            height: 10px;
        }
        .auto-style266 {
            width: 130px;
            text-align: left;
            height: 10px;
        }
        .auto-style267 {
            width: 282px;
            height: 10px;
            text-align: right;
        }
        .auto-style268 {
            width: 120px;
            height: 10px;
            text-align: left;
        }
        .auto-style269 {
            width: 308px;
            text-align: right;
            height: 10px;
        }
        .auto-style270 {
            height: 10px;
            width: 226px;
        }
        .auto-style271 {
            height: 12px;
            width: 130px;
        }
        .auto-style272 {
            width: 245px;
            text-align: right;
            right: 0px;
            height: 8px;
        }
        .auto-style273 {
            width: 130px;
            text-align: left;
            height: 8px;
        }
        .auto-style274 {
            width: 282px;
            height: 8px;
            text-align: right;
        }
        .auto-style275 {
            width: 120px;
            height: 8px;
            text-align: left;
        }
        .auto-style276 {
            width: 308px;
            text-align: right;
            height: 8px;
        }
        .auto-style277 {
            height: 8px;
            width: 226px;
        }
        .auto-style281 {
            height: 36px;
            width: 245px;
            text-align: right;
        }
        .auto-style282 {
            width: 130px;
            height: 36px;
            right: 0px;
            text-align: left;
        }
        .auto-style283 {
            height: 36px;
            text-align: justify;
        }
        .auto-style284 {
            height: 36px;
            width: 226px;
        }
        .auto-style285 {
            height: 64px;
            text-align: left;
        }
        .auto-style289 {
            width: 308px;
            height: 1px;
        }
        .auto-style290 {
            height: 1px;
            text-align: left;
            font-size: xx-large;
            text-decoration: underline;
            width: 130px;
        }
        .auto-style291 {
            height: 1px;
            text-align: right;
            font-size: xx-large;
            text-decoration: underline;
            width: 120px;
        }
        .auto-style292 {
            height: 1px;
            width: 226px;
        }
        .auto-style294 {
            font-size: x-large;
        }
        .auto-style295 {
            height: 27px;
            width: 226px;
        }
        .auto-style296 {
            font-size: small;
            text-align: justify;
            height: 40px;
        }
        .auto-style297 {
            width: 245px;
            text-align: right;
            right: 0px;
            height: 12px;
        }
        .auto-style298 {
            width: 282px;
            height: 12px;
            text-align: right;
        }
        .auto-style299 {
            width: 120px;
            height: 12px;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
 
            <table class="auto-style1">
                <tr>
                    <td class="auto-style30">Select the Class to view</td>
                    <td class="auto-style29" colspan="4"><strong><span class="auto-style153"><span class="auto-style294">Education Fee Structure</span></span></strong></td>
                    <td class="auto-style295"></td>
                </tr>
                <tr>
                    <td class="auto-style210" style="text-align: right;">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Class"></asp:Label>
                    </td>
                    <td class="auto-style237">
                        <asp:DropDownList ID="dlistclass" runat="server" CssClass="auto-style68" Font-Bold="True" Font-Size="Large" Height="27px" Width="100px" AutoPostBack="True" ToolTip="Select the Class">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style241"></td>
                    <td class="auto-style206"></td>
                    <td class="auto-style208">
                        <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Instalments" Font-Size="Medium" CssClass="auto-style153"></asp:Label>
                    </td>
                    <td class="auto-style211">
                        <asp:DropDownList ID="dinstal" runat="server" CssClass="auto-style68" Font-Bold="True" Font-Size="Large" Height="25px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style101" style="text-align: right;">
                    </td>
                    <td class="auto-style290">
                    </td>
                    <td class="auto-style242"></td>
                    <td class="auto-style291"></td>
                    <td class="auto-style289"></td>
                    <td class="auto-style292"></td>
                </tr>
                <tr>
                    <td class="auto-style297">
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" Text="Fee Type" CssClass="auto-style153"></asp:Label>
                    </td>
                    <td class="auto-style271">
                        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Medium" Text="Amount (in Rs.)" CssClass="auto-style153"></asp:Label>
                    </td>
                    <td class="auto-style298">
                        <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Medium" Text="Fee Type" CssClass="auto-style153"></asp:Label>
                    </td>
                    <td class="auto-style299">
                        <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="Medium" Text="Amount (in Rs.)" CssClass="auto-style153"></asp:Label>
                    </td>
                    <td class="auto-style158" colspan="2">
                        <asp:Label ID="Label31" runat="server" CssClass="auto-style153" Font-Bold="True" Font-Size="Medium" Text="Discounts"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style230">
                        &nbsp;<asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Size="Medium" Text="Tuition"></asp:Label>
                    </td>
                    <td class="auto-style240">
                        <asp:TextBox ID="TextBox14" runat="server" CssClass="auto-style68" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                    <td class="auto-style221">
                        &nbsp;<asp:Label ID="Label24" runat="server" Font-Bold="True" Font-Size="Medium" Text="Transport"></asp:Label>
                    </td>
                    <td class="auto-style130">
                        <asp:TextBox ID="TextBox17" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                    <td class="auto-style131" style="text-align: right">
                        <asp:Label ID="Label27" runat="server" Font-Bold="True" Font-Size="Medium" Text="Govt. Discount Category"></asp:Label>
                    </td>
                    <td class="auto-style165">
                        <asp:DropDownList ID="ddiscount1" runat="server" CssClass="auto-style68" Font-Bold="True" Font-Size="Large" Height="25px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style231">
                        <asp:Label ID="Label14" runat="server" Font-Bold="True" Font-Size="Medium" Text="Admission"></asp:Label>
                    </td>
                    <td class="auto-style223">
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                    <td class="auto-style222">
                        <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Size="Medium" Text="Caution"></asp:Label>
                    </td>
                    <td class="auto-style75">
                        <asp:TextBox ID="TextBox9" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                    <td class="auto-style76">
                        <asp:Label ID="Label28" runat="server" Font-Bold="True" Font-Size="Medium" Text="Discount %"></asp:Label>
                    </td>
                    <td class="auto-style166">
                        <asp:TextBox ID="TextBox19" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style80">
                        <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="Medium" Text="Exam"></asp:Label>
                    </td>
                    <td class="auto-style224">
                        <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                    <td class="auto-style183">
                        <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="Medium" Text="Cultural"></asp:Label>
                    </td>
                    <td class="auto-style83">
                        <asp:TextBox ID="TextBox10" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                    <td class="auto-style84">
                        <asp:Label ID="Label32" runat="server" Font-Bold="True" Font-Size="Medium" Text="Discount Amount"></asp:Label>
                    </td>
                    <td class="auto-style167">
                        <asp:TextBox ID="TextBox21" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style265">
                        <asp:Label ID="Label16" runat="server" Font-Bold="True" Font-Size="Medium" Text="Library"></asp:Label>
                    </td>
                    <td class="auto-style266">
                        <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                    <td class="auto-style267">
                        <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Size="Medium" Text="Sports"></asp:Label>
                    </td>
                    <td class="auto-style268">
                        <asp:TextBox ID="TextBox16" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                    <td class="auto-style269">
                        <asp:Label ID="Label33" runat="server" Font-Bold="True" Font-Size="Medium" Text="Govt. Discount Category"></asp:Label>
                    </td>
                    <td class="auto-style270">
                        <asp:DropDownList ID="ddiscount2" runat="server" CssClass="auto-style68" Font-Bold="True" Font-Size="Large" Height="25px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style258">
                        <asp:Label ID="Label17" runat="server" Font-Bold="True" Font-Size="Medium" Text="Computer"></asp:Label>
                    </td>
                    <td class="auto-style259">
                        <asp:TextBox ID="TextBox7" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                    <td class="auto-style263">
                        <asp:Label ID="Label4" runat="server" Font-Bold="True" Text="Study Material Cost (in Rs.)" Font-Size="Medium"></asp:Label>
                    </td>
                    <td class="auto-style264">
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                    <td class="auto-style262">
                        <asp:Label ID="Label34" runat="server" Font-Bold="True" Font-Size="Medium" Text="Discount %"></asp:Label>
                    </td>
                    <td class="auto-style256">
                        <asp:TextBox ID="TextBox22" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style272">
                        <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Size="Medium" Text="Development"></asp:Label>
                    </td>
                    <td class="auto-style273">
                        <asp:TextBox ID="TextBox15" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                    <td class="auto-style274">
                        <asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Size="Medium" Text="Other Charges"></asp:Label>
                    </td>
                    <td class="auto-style275">
                        <asp:TextBox ID="TextBox11" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                    <td class="auto-style276">
                        <asp:Label ID="Label35" runat="server" Font-Bold="True" Font-Size="Medium" Text="Discount Amount"></asp:Label>
                    </td>
                    <td class="auto-style277">
                        <asp:TextBox ID="TextBox23" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style197" style="margin: auto">
                        <asp:Label ID="Label18" runat="server" Font-Bold="True" Font-Size="Medium" Text="Recreational"></asp:Label>
                    </td>
                    <td class="auto-style235">
                        <asp:TextBox ID="TextBox8" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                    <td class="auto-style199" colspan="2">
                        <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Total Fee (in Rs.) : "></asp:Label>
                    </td>
                    <td class="auto-style200">&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="X-Large" Width="75px">0</asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label37" runat="server" Font-Bold="True" Font-Size="Medium" Text="Other Fee"></asp:Label>
                    </td>
                    <td class="auto-style201">
                        <asp:TextBox ID="TextBox25" runat="server" CssClass="auto-style69" Font-Bold="True" Font-Size="Large" Width="94px"></asp:TextBox>
                    </td>
                    <td class="auto-style201"></td>
                </tr>
                <tr>
                    <td class="auto-style250" style="margin: auto"></td>
                    <td class="auto-style236" style="text-align: right;"></td>
                    <td class="auto-style247">
                        <span class="auto-style246">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style246">
                        <asp:Label ID="Label36" runat="server" Font-Bold="True" Font-Size="Medium" Text="Enter Password" Width="150px"></asp:Label>
                        &nbsp;to Update</span></td>
                    
                    <td class="auto-style257">
                        <asp:TextBox ID="TextBox24" runat="server" AutoCompleteType="Disabled" EnableViewState="False" Height="27px" Width="94px" TextMode="Password" ToolTip="Enter the Password"></asp:TextBox>
                    </td>
                    <td class="auto-style285" colspan="3">
                          <div id="ch2" runat="server" style='color:#FF0000' class="auto-style296">
    
    </div>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style281" style="margin: auto">
                        &nbsp;</td>
                    <td class="auto-style282">
            <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Size="Large" Text="Reset" Height="35px" Width="111px" ToolTip="Reset the Page" />
                    </td>
                    <td class="auto-style283" colspan="3">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Medium" Height="35px" Text="Update" Width="172px" CssClass="auto-style245" ToolTip="Click to Update" />
                    </td>
                    <td class="auto-style284"></td>
                    <td class="auto-style284"></td>
                </tr>
                </table>
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString1 %>" SelectCommand="SELECT * FROM [Admin1]"></asp:SqlDataSource>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
