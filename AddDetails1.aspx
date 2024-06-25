<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AddDetails1.aspx.vb" Inherits="AddDetails1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 35px;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            color: #FF3300;
        }
    </style>

       <link rel="stylesheet" href="styles/jquery-ui.css"/>
    <script src="scripts/jquery-1.12.4.js"></script>
  <script src="scripts/jquery-ui.js"></script>
  <script type="text/javascript">
    var $c=  jQuery.noConflict(); </script>
     <script type="text/javascript">
  $c( function() {
      $c("#tdob, #tdoe, #tdol, #tdot ").datepicker({
        dateFormat: 'dd-mm-yy',
        changeMonth: true,
      changeYear: true,
      yearRange: '1980:2030'
  });
     
  });
  </script>




 <%-- rem query 3--%>
    
      <script type="text/javascript" src="scripts/jquery-1.12.4.min.js">    </script>      
   
    <script type="text/javascript">
        var $d = jQuery.noConflict();
         </script>

        <script type="text/javascript">
        $d(function ()
        {
           
           $d('input').each(function ()
            {
                $d(this).attr('readonly', true);
            }); 
            $d('input').click(function () {
                $d(this).attr('readonly', false);
                 $d("#tage").attr('readonly', true);
                 $d("#tdob").attr('readonly', true);
                 $d("#tdot").attr('readonly', true);
                 $d("#tdoe").attr('readonly', true);
                 $d("#tdol").attr('readonly', true);
                
            });
            $d("input, select").hover(function () {
                $d(this).css("background-color", "#fff4d8");
            }, function () {
                $d(this).css("background-color", "#FFFFFF");
                
            });
           
        });
    </script>





</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style2">
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="Maroon"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Medium" Font-Underline="True" Height="35px" Text="Add" Width="89px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Size="Medium" Height="30px" PostBackUrl="~/Student_Details1.aspx" Text="Home" Width="82px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Size="Medium" Height="28px" Text="View in Form" Width="131px" />
        <table class="auto-style1"  style="border: thin solid #800000; empty-cells: show;" align="center">
        <tr style="border: thin solid #FF5959">
            <td colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " class="auto-style2">&nbsp;Personal Profile </td>
            <td class="auto-style246"></td>
            <td class="auto-style228" colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " draggable="true" rowspan="5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" CssClass="auto-style230" Height="153px" Width="139px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image2" runat="server" CssClass="auto-style229" Height="155px" Width="136px" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student Photo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Parents/Guardian Photo<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
        <tr style="border: thick solid #FF5959">
            <td class="auto-style248" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Name of Student<span class="auto-style3">*</span></td>
            <td class="auto-style249" style="border-right: thin solid #800000; border-bottom: thin solid #800000; border-left-color: #800000; border-left-width: thin; border-top-color: #800000; border-top-width: thin;" aria-selected="undefined">
                <asp:TextBox ID="tname" runat="server" Font-Size="Large" Height="23px" Width="269px" CssClass="txt" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style250"></td>
        </tr>
        <tr>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Surname*</td>
            <td class="auto-style228" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tsurname" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style301" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Gender*</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style167">
                <asp:DropDownList ID="dlgender" runat="server" Height="24px" Width="89px">
                </asp:DropDownList>
            </td>
            <td class="auto-style172"></td>
        </tr>
        <tr>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Class/Standard*</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style228">
                <asp:DropDownList ID="dlclass" runat="server" Height="38px" Width="89px">
                </asp:DropDownList>
            </td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style302" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Section*</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style175">
                <asp:DropDownList ID="dlsection" runat="server" Height="28px" Width="89px">
                </asp:DropDownList>
            </td>
            <td class="auto-style176"></td>
            <td class="auto-style231" aria-selected="undefined" style="border-top-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large; border-bottom-style: solid;" draggable="true" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Roll No.</td>
            <td style="border-width: thin; border-color: #800000; border-right-style: solid; border-bottom-style: solid;">
                <asp:TextBox ID="trollno" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style279">&nbsp;</td>
            <td class="auto-style2" colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " draggable="true">Family Profile</td>
        </tr>
        <tr>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Date of Birth*<br />
                (dd-mm-yyyy)</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style228">
                <asp:TextBox ID="tdob" runat="server" Height="16px" EnableViewState="False" ></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style66" style="border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Name of&nbsp; Mother*</td>
            <td class="auto-style220" style="border-width: thin; border-color: #800000">
                <asp:TextBox ID="tNmother" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style305" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Age</td>
            <td class="auto-style279" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tage" runat="server" Font-Size="Large" Height="23px" Width="269px" ReadOnly="True" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style279"></td>
            <td class="auto-style34" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Name of&nbsp; Father*</td>
            <td class="auto-style285" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tNfather" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style239" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Category*</td>
            <td class="auto-style240" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:DropDownList ID="dlcateg" runat="server" Height="16px" Width="78px">
                </asp:DropDownList>
            </td>
            <td class="auto-style244"></td>
            <td class="auto-style171" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Mother&#39;s Occupation</td>
            <td class="auto-style222" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tOmother" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Height (Inches)</td>
            <td class="auto-style306" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:DropDownList ID="dlheight" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style307">&nbsp;</td>
            <td class="auto-style165" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Father&#39;s Occupation</td>
            <td class="auto-style223" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tOfather" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Weight (Kg)</td>
            <td class="auto-style232" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:DropDownList ID="dlweight" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style174" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Brothers</td>
            <td class="auto-style219" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:DropDownList ID="dlbro" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Academic Skills</td>
            <td class="auto-style307" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tAcSkill" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Sisters</td>
            <td class="auto-style234" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:DropDownList ID="dlsis" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Other Skills/Interests </td>
            <td class="auto-style307" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tOSkill" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Guardian&#39;s Name</td>
            <td style="border-width: thin; border-color: #800000; border-top-style: solid;" class="auto-style284">
                <asp:TextBox ID="tNguardian" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Hobbies</td>
            <td class="auto-style307" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="thobbies" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style34" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Relation with Guardian*</td>
            <td class="auto-style285" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tRguardian" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style308" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Differently Abled</td>
            <td class="auto-style150" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:DropDownList ID="dlDiAbled" runat="server" Height="44px" Width="77px">
                </asp:DropDownList>
            </td>
            <td class="auto-style287"></td>
            <td class="auto-style34" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">&nbsp;</td>
            <td class="auto-style285" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Kind of Ability</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tKindAbility" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style287">&nbsp;</td>
            <td class="auto-style33" aria-selected="undefined" style="border-top-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; border-bottom-style: solid;" colspan="2" draggable="true">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style59" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" colspan="2"></td>
            <td class="auto-style287"></td>
            <td class="auto-style2" aria-selected="undefined" colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " draggable="true">Official Details</td>
        </tr>
        <tr>
            <td colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " class="auto-style2">Contact Details</td>
            <td class="auto-style287"></td>
            <td class="auto-style276" aria-selected="undefined" style="border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Admission No.</td>
            <td class="auto-style288" style="border-width: thin; border-color: #800000">
                <asp:TextBox ID="tadmsn" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Phone No. (Mother)</td>
            <td class="auto-style307" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tMphone" runat="server" Font-Size="Large" Height="23px" Width="271px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style287"></td>
            <td class="auto-style39" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">SSSMID</td>
            <td class="auto-style288" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tsssm" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Phone No. (Father)*</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tFphone" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style287"></td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Aadhar No.</td>
            <td class="auto-style288" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="taadhar" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Phone No. (Guardian)</td>
            <td class="auto-style307" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tGphone" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Enrollment No.</td>
            <td class="auto-style280" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tEnrlNo" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style309" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Phone No. (Other)</td>
            <td class="auto-style289" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tOphone" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style289"></td>
            <td class="auto-style204" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Date of Enrollment(dd-mm-yyyy)</td>
            <td class="auto-style227" style="border-width: thin; border-color: #800000; border-top-style: solid;" aria-multiline="False">
                <asp:TextBox ID="tdoe" runat="server" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style310" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">E-mail Id.</td>
            <td class="auto-style290" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="temail" runat="server" Font-Size="Large" Height="23px" Width="271px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style290"></td>
            <td class="auto-style123" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Date of&nbsp; Leaving the Last School<br />
                (dd-mm-yyyy)</td>
            <td class="auto-style99" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tdol" runat="server" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Local Address*</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tLaddress" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style272" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Date of&nbsp; Leaving this School<br />
                (dd-mm-yyyy)</td>
            <td class="auto-style292" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tdot" runat="server" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Town/City*</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tTown" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style208" aria-selected="undefined" style="border-style: solid; border-width: thin; border-color: #800000; " draggable="true">Last Class in the Last School</td>
            <td class="auto-style293" aria-selected="undefined" style="border-top-style: solid; border-width: thin; border-color: #800000; border-bottom-style: solid;" draggable="true">
                <asp:DropDownList ID="dlLastClass" runat="server" Height="44px" Width="77px">
                </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">PIN/ZIP CODE</td>
            <td class="auto-style307" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tpin" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td colspan="2" style="border-width: thin; border-color: #800000; font-size: large; font-weight: bold; color: #800000; border-bottom-style: solid; border-left-style: solid;" aria-selected="undefined" draggable="true" class="auto-style40">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">State/Province*</td>
            <td class="auto-style306" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:DropDownList ID="dlstate" runat="server" Height="44px" Width="77px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " aria-selected="undefined" draggable="true" class="auto-style2">Student Details at the Time of Enrollment in the School</td>
        </tr>
        <tr>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Permanent Address</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tPaddress" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style276" aria-selected="undefined" style="border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Class/Standard</td>
            <td class="auto-style292" style="border-width: thin; border-color: #800000">
                <asp:DropDownList ID="DropDownList17" runat="server" Height="44px" Width="77px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Town/City</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style307">
                <asp:TextBox ID="tcity" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Section</td>
            <td class="auto-style293" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:DropDownList ID="DropDownList16" runat="server" Height="44px" Width="77px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">PIN/ZIP CODE</td>
            <td class="auto-style307" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tzip" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Roll No.</td>
            <td class="auto-style280" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="TextBox65" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">State/Province</td>
            <td class="auto-style306" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:DropDownList ID="dlprovince" runat="server" Height="44px" Width="77px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Age</td>
            <td class="auto-style284" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="TextBox33" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Country</td>
            <td class="auto-style306" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:DropDownList ID="dlcountry" runat="server" Height="44px" Width="77px">
                </asp:DropDownList>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Height (Inches)</td>
            <td class="auto-style293" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                </td>
        </tr>
        <tr>
            <td class="auto-style116" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" colspan="2"></td>
            <td class="auto-style118"></td>
            <td class="auto-style134" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Weight (Kg)</td>
            <td class="auto-style157" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="TextBox68" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" aria-selected="undefined" colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " draggable="true">Bank Details</td>
            <td class="auto-style290"></td>
            <td class="auto-style119" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Academic Skills</td>
            <td class="auto-style120" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="TextBox60" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style312" aria-selected="undefined" style="border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">Bank A/c No.</td>
            <td class="auto-style313" aria-selected="false" style="border-width: thin; border-color: #800000; border-right-style: solid;">
                <asp:TextBox ID="TextBox69" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style297"></td>
            <td class="auto-style295" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Interests</td>
            <td class="auto-style298" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="TextBox61" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style312" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">Account Holder Name</td>
            <td class="auto-style313" aria-selected="undefined" style="border-width: thin; border-color: #800000; border-top-style: solid; border-right-style: solid;">
                <asp:TextBox ID="TextBox70" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style297"></td>
            <td class="auto-style295" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Hobbies</td>
            <td class="auto-style298" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="TextBox62" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style303" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">Name of Bank</td>
            <td class="auto-style306" aria-selected="true" style="border-width: thin; border-color: #800000; border-top-style: solid; border-right-style: solid;">
                <asp:TextBox ID="TextBox71" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Differently Abled</td>
            <td class="auto-style293" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style299" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">IFSC Code</td>
            <td class="auto-style228" aria-selected="true" style="border-width: thin; border-color: #800000; border-top-style: solid; border-right-style: solid;">
                <asp:TextBox ID="TextBox72" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style272" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Kind of Ability</td>
            <td class="auto-style292" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="TextBox64" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
    </table>
    
    </div>
    </form>
</body>

</html>
