<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ViewDetails1.aspx.vb" Inherits="ViewDetails1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 65%;
            height: 1688px;
            margin-left: 50px;
            visibility: visible;
            margin-right: 50px;
            margin-top: 0px;
           
        }
        .auto-style60 {
            height: 47px;
            text-align: center;
        }
        .auto-style228 {
            text-align: left;
        }
        .auto-style230 {
            margin-right: 0px;
        }
        .auto-style229 {
            margin-left: 59px;
        }
        .auto-style64 {
            width: 178px;
            /*text-align: right;*/
            text-align: right;
            height: 11px;
        }
        .auto-style63 {
            height: 11px;
            text-align: left;
            width: 269px;
        }
        .auto-style65 {
            height: 11px;
            width: 3px;
        }
        .auto-style41 {
            width: 178px;
            /*text-align: right;*/
            text-align: right;
        }
        .auto-style171 {
            width: 178px; /*text-align: right;*/;
            text-align: right;
            height: 5px;
        }
        .auto-style167 {
            text-align: left;
            height: 5px;
            width: 269px;
        }
        .auto-style172 {
            height: 5px;
            width: 3px;
        }
        .auto-style163 {
            width: 178px; /*text-align: right;*/;
            text-align: right;
            height: 2px;
        }
        .auto-style159 {
            text-align: left;
            height: 2px;
            width: 269px;
        }
        .auto-style164 {
            height: 2px;
            width: 3px;
        }
        .auto-style174 {
            height: 20px;
            width: 178px;
            text-align: right;
        }
        .auto-style175 {
            height: 20px;
            text-align: left;
            width: 269px;
        }
        .auto-style176 {
            height: 20px;
            width: 3px;
        }
        .auto-style231 {
            height: 20px;
            text-align: right;
        }
        .auto-style42 {
            height: 23px;
            width: 178px;
            text-align: right;
        }
        .auto-style66 {
            width: 322px;
            text-align: right;
            height: 11px;
        }
        .auto-style220 {
            height: 11px;
            width: 270px;
        }
        .auto-style34 {
            width: 178px;
            height: 36px;
            text-align: right;
        }
        .auto-style213 {
            height: 23px;
            width: 322px;
            text-align: right;
        }
        .auto-style221 {
            height: 23px;
            width: 270px;
        }
        .auto-style173 {
            width: 322px;
            text-align: right;
            height: 5px;
        }
        .auto-style222 {
            height: 5px;
            width: 270px;
        }
        .auto-style165 {
            width: 322px;
            text-align: right;
            height: 2px;
        }
        .auto-style223 {
            height: 2px;
            width: 270px;
        }
        .auto-style177 {
            height: 20px;
            width: 322px;
            text-align: right;
        }
        .auto-style219 {
            height: 20px;
            width: 270px;
        }
        .auto-style224 {
            height: 36px;
            width: 270px;
        }
        .auto-style225 {
            width: 270px;
        }
        .auto-style39 {
            width: 178px;
            height: 29px;
            text-align: right;
        }
        .auto-style150 {
            height: 29px;
            text-align: left;
            width: 269px;
        }
        .auto-style50 {
            height: 29px;
            width: 3px;
        }
        .auto-style35 {
            height: 36px;
            width: 322px;
            text-align: right;
        }
        .auto-style33 {
            height: 23px;
            text-align: right;
        }
        .auto-style59 {
            height: 29px;
            text-align: right;
        }
        .auto-style83 {
            height: 29px;
            text-align: center;
        }
        .auto-style40 {
            text-align: center;
        }
        .auto-style226 {
            height: 29px;
            width: 270px;
        }
        .auto-style214 {
            height: 29px;
            width: 322px;
            text-align: right;
        }
        .auto-style204 {
            width: 178px; /*text-align: right;*/;
            text-align: right;
            height: 3px;
        }
        .auto-style206 {
            width: 322px;
            text-align: right;
            height: 3px;
        }
        .auto-style227 {
            height: 3px;
            width: 270px;
        }
        .auto-style123 {
            width: 178px;
            /*text-align: right;*/
            text-align: right;
            height: 10px;
        }
        .auto-style124 {
            height: 10px;
            width: 269px;
        }
        .auto-style125 {
            width: 322px;
            text-align: right;
            height: 10px;
        }
        .auto-style99 {
            width: 270px;
            height: 10px;
            text-align: left;
        }
        .auto-style139 {
            width: 178px; /*text-align: right;*/;
            text-align: right;
            height: 4px;
        }
        .auto-style141 {
            height: 4px;
            width: 269px;
        }
        .auto-style142 {
            width: 322px;
            text-align: right;
            height: 4px;
        }
        .auto-style143 {
            width: 270px;
            height: 4px;
            text-align: left;
        }
        .auto-style208 {
            height: 23px;
            text-align: right;
            font-size: large;
            width: 322px;
        }
        .auto-style209 {
            height: 23px;
            text-align: left;
            width: 270px;
        }
        .auto-style155 {
            width: 270px;
            text-align: left;
        }
        .auto-style134 {
            width: 178px;
            /*text-align: right;*/
            text-align: right;
            height: 13px;
        }
        .auto-style136 {
            height: 13px;
            width: 3px;
        }
        .auto-style116 {
            height: 21px;
            text-align: right;
        }
        .auto-style118 {
            height: 21px;
            width: 3px;
        }
        .auto-style137 {
            width: 322px;
            text-align: right;
            height: 13px;
        }
        .auto-style157 {
            width: 270px;
            height: 13px;
            text-align: left;
        }
        .auto-style84 {
            height: 23px;
            text-align: center;
        }
        .auto-style119 {
            height: 21px;
            width: 322px;
            text-align: right;
        }
        .auto-style120 {
            width: 270px;
            height: 21px;
            text-align: left;
        }
        .auto-style103 {
            height: 39px;
            width: 178px;
            text-align: right;
        }
        .auto-style102 {
            height: 39px;
            width: 3px;
        }
        .auto-style215 {
            height: 39px;
            width: 322px;
            text-align: right;
        }
        .auto-style217 {
            width: 270px;
            height: 39px;
            text-align: left;
        }
        .auto-style133 {
            width: 322px;
            text-align: right;
            height: 19px;
        }
        .auto-style130 {
            width: 270px;
            text-align: left;
            height: 19px;
        }
        .auto-style232 {
            height: 23px;
            width: 3px;
        }
        .auto-style233 {
            height: 36px;
            width: 3px;
        }
        .auto-style234 {
            width: 3px;
        }
        .auto-style235 {
            height: 3px;
            width: 3px;
        }
        .auto-style236 {
            height: 10px;
            width: 3px;
        }
        .auto-style237 {
            height: 4px;
            width: 3px;
        }
        .auto-style238 {
            height: 23px;
            text-align: left;
            width: 269px;
        }
        .auto-style239 {
            width: 269px;
        }
        .auto-style240 {
            width: 269px;
            text-align: left;
        }
        .auto-style241 {
            height: 36px;
            width: 269px;
        }
        .auto-style244 {
            width: 269px;
            height: 13px;
            text-align: left;
        }
        .auto-style245 {
            width: 269px;
            height: 39px;
            text-align: left;
        }
        .auto-style246 {
            height: 24px;
            text-align: center;
        }
        .auto-style247 {
            height: 24px;
            width: 3px;
        }
        .auto-style248 {
            height: 100%;
            width: 100%;
            text-align: left;
        }
        .auto-style249 {
            margin-left: 4px;
        }
        .auto-style250 {
            width: 178px; /*text-align: right;*/;
            text-align: right;
            font-size: large;
        }
        .auto-style251 {
            width: 269px;
            height: 23px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style248">
    
        <asp:Button ID="Button5" runat="server" Font-Bold="True" Font-Size="Large" Text="Backword" Width="124px" />
        <asp:Button ID="Button7" runat="server" Text="Foreward" Font-Bold="True" Font-Size="Large" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button10" runat="server" Font-Bold="True" Font-Size="Medium" Height="36px" Text="Delete Record" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Large" Height="31px" Text="Edit" Width="123px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Size="Large" Height="33px" Text="Add New Student" Width="237px" />
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button8" runat="server" Font-Bold="True" Font-Size="Large" Text="Logout" Width="124px" />
    
        <br />
        <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Size="Large" Text="&lt;&lt;Previous" Width="107px" />
        <asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Size="Large" Text="Next&gt;&gt;" Width="124px" style="height: 33px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button9" runat="server" Text="Reset" Font-Bold="True" Font-Size="Medium" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label45" runat="server" Text="Record No." Font-Bold="True" Font-Size="Larger" Height="32px" Width="122px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" AutoCompleteType="Disabled" AutoPostBack="True" Height="27px" Width="71px" BackColor="#990000" Font-Size="Larger" ForeColor="White"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style249" Height="34px" Width="132px" AutoCompleteType="Disabled" AutoPostBack="True"></asp:TextBox>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label46" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" ForeColor="#990000"></asp:Label>
&nbsp;<div id="ch" runat="server" style = 'color:blue'>
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table class="auto-style1"   style="border: thin solid #800000; empty-cells: show; ">
        <tr style="border: thin solid #FF5959">
            <td colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " class="auto-style246">Current Personal Profile   </td>     
            <td class="auto-style247"></td>
            <td class="auto-style228" colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " draggable="true" rowspan="5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" CssClass="auto-style230" Height="153px" Width="139px" />
                <asp:Image ID="Image2" runat="server" CssClass="auto-style229" Height="155px" Width="135px" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student Photo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Parents/Guardian Photo<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
        <tr style="border: thick solid #FF5959">
            <td class="auto-style64" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Name of Student</td>
            <td class="auto-style63" style="border-right: thin solid #800000; border-bottom: thin solid #800000; border-left-color: #800000; border-left-width: thin; border-top-color: #800000; border-top-width: thin;" aria-selected="undefined">
                <asp:Label ID="lname" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style65"></td>
        </tr>
        <tr>
            <td class="auto-style42" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Surname</td>
            <td class="auto-style238" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lsurname" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style232"></td>
        </tr>
        <tr>
            <td class="auto-style171" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Gender</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style167">
                <asp:Label ID="lgender" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style172">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style163" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Class/Standard</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style159">
                <asp:Label ID="lclass" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style164"></td>
        </tr>
        <tr>
            <td class="auto-style174" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Section</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style175">
                <asp:Label ID="lsection" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style176"></td>
            <td class="auto-style231" aria-selected="undefined" style="border-top-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large; border-bottom-style: solid;" draggable="true" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style42" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Roll No.</td>
            <td style="border-width: thin; border-color: #800000; border-right-style: solid; border-bottom-style: solid;" class="auto-style239">
                <asp:Label ID="lrollno" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style233">&nbsp;</td>
            <td class="auto-style60" colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " draggable="true">Family Profile</td>
        </tr>
        <tr>
            <td class="auto-style41" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Date of Birth</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style240">
                <asp:Label ID="ldob" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style234"></td>
            <td class="auto-style66" style="border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Name of&nbsp; Mother</td>
            <td class="auto-style220" style="border-width: thin; border-color: #800000">
                <asp:Label ID="lNmother" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style34" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Age</td>
            <td class="auto-style241" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lage" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style233"></td>
            <td class="auto-style213" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Name of&nbsp; Father</td>
            <td class="auto-style221" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="lNfather" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style34" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Category</td>
            <td class="auto-style241" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lcateg" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style233">&nbsp;</td>
            <td class="auto-style173" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Mother&#39;s Occupation</td>
            <td class="auto-style222" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="lOmother" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style41" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Height (Inches)</td>
            <td class="auto-style238" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lheight" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style232">&nbsp;</td>
            <td class="auto-style165" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Father&#39;s Occupation</td>
            <td class="auto-style223" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="lOfather" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style42" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Weight (Kg)</td>
            <td class="auto-style239" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lweight" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style232"></td>
            <td class="auto-style177" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Brothers</td>
            <td class="auto-style219" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="lbro" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style42" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Academic Skills</td>
            <td class="auto-style239" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lAcSkill" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style232"></td>
            <td class="auto-style213" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Sisters</td>
            <td class="auto-style224" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="lsis" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style250" style="border-right: thin solid #800000; border-bottom: thin solid #800000; border-left-color: #800000; border-left-width: thin; border-top-color: #800000; border-top-width: thin;">Other Skills</td>
            <td class="auto-style239" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lOSkill" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style232"></td>
            <td class="auto-style213" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Guardian&#39;s Name</td>
            <td style="border-width: thin; border-color: #800000; border-top-style: solid;" class="auto-style225">
                <asp:Label ID="lNguardian" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style41" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Hobbies</td>
            <td class="auto-style239" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lhobbies" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style232"></td>
            <td class="auto-style35" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Relation with Guardian</td>
            <td class="auto-style224" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="lRguardian" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style39" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Differently Abled</td>
            <td class="auto-style150" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lDiAbled" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style50"></td>
            <td class="auto-style35" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">&nbsp;</td>
            <td class="auto-style224" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style41" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Kind of Ability</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style239">
                <asp:Label ID="lKindAbility" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style50">&nbsp;</td>
            <td class="auto-style33" aria-selected="undefined" style="border-top-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; border-bottom-style: solid;" colspan="2" draggable="true">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style59" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" colspan="2"></td>
            <td class="auto-style50"></td>
            <td class="auto-style83" aria-selected="undefined" colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " draggable="true">Official Details</td>
        </tr>
        <tr>
            <td colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " class="auto-style83">Contact Details</td>
            <td class="auto-style50"></td>
            <td class="auto-style214" aria-selected="undefined" style="border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Admission No.</td>
            <td class="auto-style226" style="border-width: thin; border-color: #800000">
                <asp:Label ID="ladmsn" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style39" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Phone No. (Mother)</td>
            <td class="auto-style239" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
            <asp:Label ID="lMphone" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style50"></td>
            <td class="auto-style214" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">SSSMID</td>
            <td class="auto-style226" style="border-width: thin; border-color: #800000; border-top-style: solid;">
            <asp:Label ID="lsssm" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style41" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Phone No. (Father)</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style239">
             <asp:Label ID="lFphone" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style50"></td>
            <td class="auto-style213" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Aadhar No.</td>
            <td class="auto-style226" style="border-width: thin; border-color: #800000; border-top-style: solid;">
             <asp:Label ID="laadhar" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style42" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Phone No. (Guardian)</td>
            <td class="auto-style251" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lGphone" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style232"></td>
            <td class="auto-style213" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Enrollment No.</td>
            <td class="auto-style221" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="lEnrlNo" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style204" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Phone No. (Other)</td>
            <td class="auto-style239" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lOphone" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style235"></td>
            <td class="auto-style206" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Date of Enrollment&nbsp; </td>
            <td class="auto-style227" style="border-width: thin; border-color: #800000; border-top-style: solid;" aria-multiline="False">
                <asp:Label ID="lDateEnroll" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style123" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">E-mail Id.</td>
            <td class="auto-style124" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lemail" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style236"></td>
            <td class="auto-style125" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Date of&nbsp; Leaving the Last School</td>
            <td class="auto-style99" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="lDateLeaveLast" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style139" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Local Address</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style141">
                <asp:Label ID="lLaddress" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style237"></td>
            <td class="auto-style142" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Date of&nbsp; Leaving this School</td>
            <td class="auto-style143" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="lDateLeaveThis" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style41" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Town/City</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style239">
                <asp:Label ID="ltown" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style232"></td>
            <td class="auto-style208" aria-selected="undefined" style="border-style: solid; border-width: thin; border-color: #800000; " draggable="true">Last Class in the Last School</td>
            <td class="auto-style209" aria-selected="undefined" style="border-top-style: solid; border-width: thin; border-color: #800000; border-bottom-style: solid;" draggable="true">
                <asp:Label ID="lLastClass" runat="server" Text="No data"></asp:Label>
                </td>
        </tr>
        <tr>
            <td class="auto-style42" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">PIN/ZIP CODE</td>
            <td class="auto-style239" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lpin" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style234">&nbsp;</td>
            <td colspan="2" style="border-width: thin; border-color: #800000; font-size: large; font-weight: bold; color: #800000; border-bottom-style: solid; border-left-style: solid;" aria-selected="undefined" draggable="true" class="auto-style40">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style41" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">State/Province</td>
            <td class="auto-style238" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lstate" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style234">&nbsp;</td>
            <td colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " aria-selected="undefined" draggable="true" class="auto-style40">Student Details at the Time of Enrollment in the School</td>
        </tr>
        <tr>
            <td class="auto-style41" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Permanent Address</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style239">
                <asp:Label ID="lPaddress" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style232"></td>
            <td class="auto-style213" aria-selected="undefined" style="border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Class/Standard</td>
            <td class="auto-style155" style="border-width: thin; border-color: #800000">
                <asp:Label ID="Label35" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style42" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Town/City</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style239">
                <asp:Label ID="lcity" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style232"></td>
            <td class="auto-style213" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Section</td>
            <td class="auto-style209" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="Label36" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style41" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">PIN/ZIP CODE</td>
            <td class="auto-style239" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lzip" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style234">&nbsp;</td>
            <td class="auto-style213" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Roll No.</td>
            <td class="auto-style221" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="Label37" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style42" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">State/Province</td>
            <td class="auto-style238" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lprovince" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style234">&nbsp;</td>
            <td class="auto-style213" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Age</td>
            <td class="auto-style225" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="Label38" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style134" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Country</td>
            <td class="auto-style244" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:Label ID="lcountry" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style136"></td>
            <td class="auto-style213" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Height (Inches)</td>
            <td class="auto-style209" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="Label39" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style116" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" colspan="2"></td>
            <td class="auto-style118"></td>
            <td class="auto-style137" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Weight (Kg)</td>
            <td class="auto-style157" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="Label40" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style84" aria-selected="undefined" colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " draggable="true">Bank Details</td>
            <td class="auto-style236"></td>
            <td class="auto-style119" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Academic Skills</td>
            <td class="auto-style120" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="Label41" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style103" aria-selected="undefined" style="border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">Bank A/c No.</td>
            <td class="auto-style245" aria-selected="false" style="border-width: thin; border-color: #800000; border-right-style: solid;">
                <asp:Label ID="Label30" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style102"></td>
            <td class="auto-style215" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Interests</td>
            <td class="auto-style217" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="Label42" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style103" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">Account Holder Name</td>
            <td class="auto-style245" aria-selected="undefined" style="border-width: thin; border-color: #800000; border-top-style: solid; border-right-style: solid;">
                <asp:Label ID="Label31" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style102"></td>
            <td class="auto-style215" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Hobbies</td>
            <td class="auto-style217" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="Label43" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style42" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">Name of Bank</td>
            <td class="auto-style238" aria-selected="true" style="border-width: thin; border-color: #800000; border-top-style: solid; border-right-style: solid;">
                <asp:Label ID="Label32" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style236"></td>
            <td class="auto-style133" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Differently Abled</td>
            <td class="auto-style130" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="Label44" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style39" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">IFSC Code</td>
            <td class="auto-style150" aria-selected="true" style="border-width: thin; border-color: #800000; border-top-style: solid; border-right-style: solid;">
                <asp:Label ID="Label33" runat="server" Text="No data"></asp:Label>
            </td>
            <td class="auto-style236">&nbsp;</td>
            <td class="auto-style125" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Kind of Ability</td>
            <td class="auto-style99" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:Label ID="Label34" runat="server" Text="No data"></asp:Label>
            </td>
        </tr>
    </table>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString1 %>" SelectCommand="SELECT * FROM [_2020]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
