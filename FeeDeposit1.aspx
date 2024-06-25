<%@ Page Language="VB" AutoEventWireup="false" CodeFile="FeeDeposit1.aspx.vb" Inherits="FeeDeposit1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 740px;
            overflow: visible;
            border-style: solid;
            border-width: 0px;
        }
        .auto-style32 {
            overflow: visible;
            height: 10px;
        }
        .auto-style117 {
            width: 2043px;
            text-align: left;
            overflow: visible;
        }
        .auto-style139 {
            overflow: visible;
            text-align: center;
        }
        .auto-style142 {
            height: 25px;
            text-align: left;
            overflow: visible;
            width: 2043px;
        }
        .auto-style166 {
            
            margin-left: 160px;
            text-align: right;
            width: 133px;
            height: 10px;
        }
        .auto-style175 {
            width: 299px;
            text-align: right;
        }
        .auto-style183 {
            width: 133px;
            text-align: center;
            height: 25px;
            }
        .auto-style187 {
            width: 60px;
            text-align: left;
        }
        .auto-style193 {
            text-align: left;
            height: 25px;
        }
        .auto-style210 {
            width: 299px;
            height: 25px;
            text-align: center;
            }
        .auto-style214 {
            width: 60px;
        }
        .auto-style220 {
            border-color: #000000;
            width: 299px;
            height: 25px;
            text-align: right;
            }
        .auto-style224 {
            height: 25px;
            text-align: left;
            overflow: visible;
            width: 60px;
        }
        .auto-style230 {
            border-color: #000000;
            text-align: left;
            width: 2043px;
            height: 25px;
        }
        .auto-style233 {
            text-align: center;
            width: 2043px;
            height: 51px;
        }
        .auto-style235 {
            width: 2043px;
            overflow: visible;
        }
        .auto-style245 {
            width: 1970px;
            height: 25px;
            text-align: center;
            }
        .auto-style248 {
            width: 1970px;
            text-align: right;
        }
        .auto-style257 {
            font-size: large;
        }
        .auto-style262 {
            text-align: right;
            }
        .auto-style269 {
            width: 133px;
            height: 6px;
        }
        .auto-style270 {
            text-align: right;
            width: 133px;
        }
        .auto-style279 {
            height: 25px;
            width: 72px;
        }
        .auto-style280 {
            text-align: right;
            width: 72px;
        }
        .auto-style281 {
            text-align: left;
            height: 28px;
        }
        .auto-style285 {
            height: 25px;
            text-align: center;
        }
        .auto-style286 {
            height: 25px;
            text-align: right;
           
        }
        .auto-style287 {
            height: 51px;
            text-align: center;
        }
        .auto-style291 {
            width: 2043px;
            overflow: visible;
            height: 28px;
        }
        .auto-style292 {
            width: 60px;
            text-align: left;
            height: 28px;
        }
        .auto-style293 {
            width: 1970px;
            height: 25px;
            text-align: right;
        }
        .auto-style296 {
            text-align: right;
            height: 28px;
            }
        .auto-style297 {
            font-size: medium;
        }
        .auto-style299 {
            height: 25px;
            width: 60px;
        }
        .auto-style306 {
            text-align: left;
            width: 101px;
        }
        .auto-style307 {
            height: 51px;
            text-align: center;
            width: 101px;
        }
        .auto-style311 {
            text-align: right;
            height: 28px;
            width: 101px;
        }
        .auto-style313 {
            overflow: visible;
            height: 8px;
        }
        .auto-style314 {
            overflow: visible;
            text-align: right;
            height: 8px;
        }
        .auto-style315 {
            text-align: right;
            width: 101px;
            height: 8px;
        }
        .auto-style317 {
            width: 60px;
            text-align: left;
            height: 25px;
        }
        .auto-style318 {
            width: 2043px;
            overflow: visible;
            height: 25px;
        }
        .auto-style319 {
            text-align: right;
            width: 133px;
            height: 25px;
        }
        .auto-style330 {
            font-weight: bold;
        }
        .auto-style331 {
            text-decoration: underline;
        }
        .auto-style332 {
            font-size: small;
        }
        .auto-style333 {
            overflow: visible;
            text-align: center;
            height: 8px;
        }
        .auto-style334 {
            width: 101px;
            text-align: center;
            height: 25px;
        }
        .auto-style336 {
            text-align: right;
            width: 101px;
            height: 25px;
        }
        .auto-style337 {
            text-align: right;
            width: 101px;
        }
        .auto-style338 {
            text-align: left;
        }
        .auto-style339 {
            text-align: right;
            width: 72px;
            height: 10px;
        }
        .auto-style340 {
            text-align: right;
            height: 10px;
        }
        .auto-style341 {
            text-align: right;
            height: 10px;
            width: 101px;
        }
        .auto-style345 {
            text-align: right;
            width: 72px;
            height: 6px;
        }
        .auto-style346 {
            width: 2043px;
            overflow: visible;
            height: 6px;
        }
        .auto-style347 {
            width: 60px;
            text-align: left;
            height: 6px;
        }
        .auto-style348 {
            text-align: right;
            height: 6px;
        }
        .auto-style349 {
            text-align: right;
            width: 101px;
            height: 6px;
        }
    </style>
</head>
<body>
   
   
    <form id="form1" runat="server">

      
    <div>
    
       
        
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString1 %>" SelectCommand="SELECT * FROM [FeeDetails1_2022]"></asp:SqlDataSource>
                <div class="auto-style338">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
       
                
                </div>
       
                
    </div>
       
            

   
                            <asp:Label ID="Label56" runat="server" CssClass="auto-style297" Font-Size="Medium" Text="Label"></asp:Label>

                                     <br />
       
            

   
                <asp:Button ID="Button2" runat="server" Text="Refresh Time" Font-Bold="True" Width="190px" />
      
                             
                                     <table border="2" class="auto-style1" style="border-color: #333300; background-color: #FFFFFF;">
                                         <tr>
                                             <td class="auto-style233" style="border-color: #000000">Receipt No.-<br /> <strong>
                                                 <asp:Label ID="Label51" runat="server" Text="Label"></asp:Label>
                                                 </strong></td>
                                             <td class="auto-style287" colspan="7" style="border-color: #000000"><span class="auto-style257"><strong>FEE RECEIPT</strong></span><br />
                                                 <asp:Label ID="Label48" runat="server" Font-Bold="False" Font-Size="Large" Text="Chandrabhan Singh Public School Chanderi"></asp:Label>
                                                 &nbsp; <span class="auto-style257">&nbsp;Session- </span>
                                                 <asp:Label ID="Label28" runat="server" CssClass="auto-style257" Text="Label"></asp:Label>
                                             </td>
                                             <td class="auto-style307" style="border-color: #000000">Instl.DueDate-<br /> <strong>
                                                 <asp:Label ID="Label54" runat="server" Text="Label"></asp:Label>
                                                 </strong></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style230">&nbsp; Student&#39;s Name</td>
                                             <td class="auto-style193" colspan="3" style="border-color: #000000">&nbsp; <strong>
                                                 <asp:Label ID="Label1" runat="server" CssClass="auto-style297" Font-Size="Medium" Text="Label"></asp:Label>
                                                 </strong></td>
                                             <td class="auto-style285" colspan="3" style="border-color: #000000"><strong>
                                                 <asp:Label ID="Label55" runat="server" Text="Label"></asp:Label>
                                                 </strong></td>
                                             <td class="auto-style286" style="border-color: #000000"><strong>Status&nbsp;&nbsp; </strong></td>
                                             <td class="auto-style334" style="border-color: #000000">&nbsp;<strong><asp:Label ID="Label53" runat="server" Text="Label"></asp:Label>
                                                 </strong></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style142" style="border-color: #000000; ">&nbsp; Class/Std.</td>
                                             <td class="auto-style224" style="border-color: #000000; ">&nbsp; <strong>
                                                 <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                                 </strong></td>
                                             <td class="auto-style210" colspan="2"><strong>FEE TYPE</strong></td>
                                             <td class="auto-style245" colspan="2"><strong>PAYABLE FEE</strong></td>
                                             <td class="auto-style183"><strong>FEE DUE</strong></td>
                                             <td class="auto-style285"><strong>FEE PAID</strong></td>
                                             <td class="auto-style334"><strong>BALANCE</strong></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style117" style="border-color: #000000; ">&nbsp; Section</td>
                                             <td class="auto-style187" style="border-color: #000000">&nbsp;
                                                 <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                                             </td>
                                             <td class="auto-style175" colspan="2">Tuition_Fee<strong>&nbsp;&nbsp; </strong></td>
                                             <td class="auto-style248" colspan="2">
                                                 <asp:Label ID="Label41" runat="server" Text="Label"></asp:Label>
                                                 &nbsp; </td>
                                             <td class="auto-style270">&nbsp;<asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                                                 &nbsp; </td>
                                             <td class="auto-style280">
                                                 <asp:TextBox ID="TextBox1" runat="server" style="text-align: right" AutoPostBack="True" Height="16px" Width="83px" BackColor="#FFCCCC">0</asp:TextBox>
                                             </td>
                                             <td class="auto-style337">
                                                 <asp:Label ID="Label46" runat="server" Text="Label"></asp:Label>
                                                 &nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style117" style="border-color: #000000; ">&nbsp; Admission No.</td>
                                             <td class="auto-style214" style="border-color: #000000">&nbsp;
                                                 <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                                             </td>
                                             <td class="auto-style175" colspan="2">Admission_Fee<strong>&nbsp;&nbsp; </strong></td>
                                             <td class="auto-style248" colspan="2">
                                                 <asp:Label ID="Label39" runat="server" Text="Label"></asp:Label>
                                                 &nbsp; </td>
                                             <td class="auto-style270">
                                                 <asp:Label ID="Label40" runat="server" Text="Label"></asp:Label>
                                                 &nbsp; </td>
                                             <td class="auto-style280">
                                                 <asp:TextBox ID="TextBox2" style="text-align: right" runat="server" AutoPostBack="True" Height="16px" Width="83px" BackColor="#FFCCCC">0</asp:TextBox>
                                             </td>
                                             <td class="auto-style337">
                                                 <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
                                                 &nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style235" style="border-color: #000000; ">&nbsp; Gender </td>
                                             <td class="auto-style214" style="border-color: #000000">&nbsp;
                                                 <asp:Label ID="Label32" runat="server" Text="Label"></asp:Label>
                                             </td>
                                             <td class="auto-style175" colspan="2">Transport_Fee<strong>&nbsp;&nbsp; </strong></td>
                                             <td class="auto-style248" colspan="2">
                                                 <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
                                                 &nbsp; </td>
                                             <td class="auto-style270">
                                                 <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
                                                 &nbsp; </td>
                                             <td class="auto-style280">
                                                 <asp:TextBox ID="TextBox5" style="text-align: right" runat="server" AutoPostBack="True" Height="16px" Width="83px" BackColor="#FFCCCC">0</asp:TextBox>
                                             </td>
                                             <td class="auto-style337">
                                                 <asp:Label ID="Label21" runat="server" Text="Label"></asp:Label>
                                                 &nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style235" style="border-color: #000000; ">&nbsp; Roll No.</td>
                                             <td class="auto-style187" style="border-color: #000000">&nbsp;
                                                 <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                                             </td>
                                             <td class="auto-style175" colspan="2">Other_Fee&nbsp;&nbsp; </td>
                                             <td class="auto-style248" colspan="2">
                                                 <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
                                                 &nbsp; </td>
                                             <td class="auto-style270">
                                                 <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
                                                 &nbsp; </td>
                                             <td class="auto-style262">
                                                 <asp:TextBox ID="TextBox3" style="text-align: right" runat="server" AutoPostBack="True" Height="16px" Width="83px" BackColor="#FFCCCC">0</asp:TextBox>
                                             </td>
                                             <td class="auto-style337">
                                                 <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
                                                 &nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style318" style="border-color: #000000; ">&nbsp; Phone No.</td>
                                             <td class="auto-style317" style="border-color: #000000">&nbsp; <strong>
                                                 <asp:Label ID="Label6" runat="server" CssClass="auto-style297" Font-Size="Medium" Text="Label"></asp:Label>
                                                 </strong></td>
                                             <td class="auto-style220" colspan="2"><strong><span class="auto-style331">TOTAL FEE</span>&nbsp;&nbsp; </strong></td>
                                             <td class="auto-style293" colspan="2"><strong>
                                                 <asp:Label ID="Label36" runat="server">Label</asp:Label>
                                                 &nbsp; </strong></td>
                                             <td class="auto-style319"><strong>
                                                 <asp:Label ID="Label44" runat="server" Text="Label"></asp:Label>
                                                 &nbsp; </strong></td>
                                             <td class="auto-style286"><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                                 <asp:Label ID="Label47" runat="server" Text="Label"></asp:Label>
                                                 </strong></td>
                                             <td class="auto-style336"><strong>
                                                 <asp:Label ID="Label23" runat="server" Text="Label"></asp:Label>
                                                 &nbsp;</strong></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style32" colspan="2" style="border-color: #000000; ">
                                                 <asp:TextBox ID="TextBox22" style="text-align: right" runat="server" Enabled="False" Height="16px" Width="228px"></asp:TextBox>
                                             </td>
                                             <td class="auto-style340" colspan="2"><strong><em>Previous S. Due&nbsp;&nbsp; </em></strong> </td>
                                             <td class="auto-style340" colspan="2">
                                                 <asp:Label ID="Label45" runat="server" Text="Label"></asp:Label>
                                             </td>
                                             <td class="auto-style166">
                                                 &nbsp; </td>
                                             <td class="auto-style339">
                                                 <asp:TextBox ID="TextBox17" style="text-align: right" runat="server" AutoPostBack="True" Height="16px" Width="83px" BackColor="#FFCCCC">0</asp:TextBox>
                                             </td>
                                             <td class="auto-style341">
                                                 <asp:Label ID="Label24" runat="server" Text="Label"></asp:Label>
                                                 &nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style346" style="border-color: #000000; ">&nbsp; Father&#39;s Name</td>
                                             <td class="auto-style347" style="border-color: #000000">
                                                 <asp:Label ID="Label7" runat="server" CssClass="auto-style297" Font-Size="Medium" Text="Label"></asp:Label>
                                             </td>
                                             <td class="auto-style348" colspan="2"><strong><em>Other Charges&nbsp;&nbsp; </em></strong> </td>
                                             <td class="auto-style348" colspan="2">
                                                 <asp:TextBox ID="TextBox15" style="text-align: right" runat="server" AutoPostBack="True" Height="16px" Width="70px" CssClass="auto-style332" Font-Bold="True" Font-Size="Small"></asp:TextBox>
                                             </td>
                                             <td class="auto-style269">
                                             </td>
                                             <td class="auto-style345">
                                                 <asp:TextBox ID="TextBox7" style="text-align: right" runat="server" AutoPostBack="True" Height="16px" Width="83px" BackColor="#FFCCCC">0</asp:TextBox>
                                             </td>
                                             <td class="auto-style349">
                                                 <asp:Label ID="Label38" runat="server" Text="Label"></asp:Label>
                                                 &nbsp;</td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style318" style="border-color: #000000; ">&nbsp; Mother&#39;s Name</td>
                                             <td class="auto-style299" style="border-color: #000000">
                                                 <asp:Label ID="Label8" runat="server" CssClass="auto-style297" Font-Size="Medium" Text="Label"></asp:Label>
                                             </td>
                                             <td class="auto-style286" colspan="2"><strong><span class="auto-style331">GRAND TOTAL </span> </strong></td>
                                             <td class="auto-style286" colspan="2">&nbsp;</td>
                                             <td class="auto-style319"><strong>
                                                 <asp:Label ID="Label42" runat="server" Text="Label"></asp:Label>
                                                 &nbsp;</strong></td>
                                             <td class="auto-style279"><strong>
                                                 <asp:TextBox ID="TextBox19" style="text-align: right" runat="server" AutoPostBack="True" CssClass="auto-style330" Height="18px" Width="83px" Font-Bold="True" Font-Size="small" BackColor="#FF99FF">0</asp:TextBox>
                                                 </strong></td>
                                             <td class="auto-style336"><strong>
                                                 <asp:Label ID="Label43" runat="server" Text="Label"></asp:Label>
                                                 &nbsp;</strong></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style313" colspan="2" style="border-color: #000000; ">&nbsp;
                                                 <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
                                             </td>
                                             <td class="auto-style333" colspan="4">
                                                 <asp:Label ID="Label62" runat="server" Text="Label"></asp:Label>
                                                 </td>
                                             <td class="auto-style314" colspan="2">Total Previous Discount&nbsp;&nbsp; </td>
                                             <td class="auto-style315">
                                                 <strong>
                                                 &nbsp;&nbsp; </strong>
                                                 <asp:Label ID="Label57" runat="server" Text="Label"></asp:Label>
                                                 <strong>
                                                 &nbsp; </strong>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style235" style="border-color: #000000; ">&nbsp; Deposited by</td>
                                             <td class="auto-style187" style="border-color: #000000">
                                                 <asp:TextBox ID="TextBox10"  runat="server" Height="16px" Width="108px" AutoPostBack="True"></asp:TextBox>
                                             </td>
                                             <td class="auto-style139">
                                                 <asp:Label ID="Label58" runat="server" Text="Label" Width="45px"></asp:Label>
                                             </td>
                                             <td class="auto-style139">
                                                 <asp:Label ID="Label63" runat="server" Text="Label" Width="45px"></asp:Label>
                                             </td>
                                             <td class="auto-style139">
                                                 <asp:Label ID="Label64" runat="server" Text="Label" Width="45px"></asp:Label>
                                             </td>
                                             <td class="auto-style139">
                                                 <asp:Label ID="Label65" runat="server" Text="Label" Width="45px"></asp:Label>
                                             </td>
                                             <td class="auto-style270">Discount&nbsp;&nbsp; </td>
                                             <td class="auto-style280">
                                                 <asp:DropDownList ID="CList1" runat="server" AutoPostBack="True" Height="21px" Width="91px">
                                                 </asp:DropDownList>
                                             </td>
                                             <td class="auto-style306">
                                                 <asp:TextBox ID="TextBox12" style="text-align: right" runat="server" AutoPostBack="True" Width="87px" Font-Bold="True" Font-Size="Small" Height="16px" BackColor="#FFCCCC"></asp:TextBox>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style291" style="border-color: #000000; ">&nbsp; Contact No.</td>
                                             <td class="auto-style292" style="border-color: #000000">
                                                 <asp:TextBox ID="TextBox9" runat="server" Height="20px" Width="108px" AutoPostBack="True"></asp:TextBox>
                                             </td>
                                             <td class="auto-style281" colspan="4">
                                                 <asp:TextBox ID="TextBox21" runat="server" Height="20px" Width="234px" AutoPostBack="True"></asp:TextBox>
                                             </td>
                                             <td class="auto-style296" colspan="2"><strong><span class="auto-style331">NET BALANCE</span>&nbsp;&nbsp; </strong></td>
                                             <td class="auto-style311"><strong>
                                                 <asp:Label ID="Label26" runat="server" Text="Label"></asp:Label>
                                                 &nbsp;</strong></td>
                                         </tr>
                                         <tr>
                                             <td class="auto-style139" colspan="2" style="border-color: #000000; ">
                                                 <br />
                                                 Parents/Guardian&#39;s Sign&nbsp;</td>
                                             <td class="auto-style139" colspan="5" style="border-color: #000000; ">
                                                 <br />
                                                 Authorised Seal and Signatory</td>
                                             <td class="auto-style139" colspan="2" style="border-color: #000000; ">
                                                 <asp:Label ID="Label27" runat="server" Text="Label"></asp:Label>
                                             </td>
                                         </tr>
                                     </table>
                                 




        <asp:Button ID="Button1" runat="server" Text="Check" />
                                 




        <asp:Button ID="Button3" runat="server" Text="Approve" />
    &nbsp;&nbsp;&nbsp;&nbsp;
       
            

   
                <asp:Button ID="Button4" runat="server" Text="Cancel         " Font-Bold="True" Width="190px" />
      
                             
                                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
            

   
                <asp:Button ID="Button5" runat="server" Text="Refresh Time" Font-Bold="True" Width="190px" />
      
                             
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label66" runat="server" Text="Label"></asp:Label>
                                                 <asp:TextBox ID="TextBox23" style="text-align: right" runat="server" AutoPostBack="True" Height="16px" Width="83px" BackColor="#FFCCCC"></asp:TextBox>
                                             </p>
      
                             
    </form>
                
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
