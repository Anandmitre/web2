<%@ Page  Language="VB" AutoEventWireup="false" CodeFile="EditPage1.aspx.vb" Inherits="EditPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: auto;
            height: 1538px;
            margin-left: 149px;
            visibility: visible;
            margin-right: 0px;
            margin-top: 120px;
        }
        .auto-style33 {
            height: 23px;
            text-align: right;
        }
        .auto-style34 {
            width: 107px;
            height: 36px;
            text-align: right;
        }
        .auto-style39 {
            width: 107px;
            height: 29px;
            text-align: right;
        }
        .auto-style40 {
            text-align: center;
        }
        .auto-style59 {
            height: 29px;
            text-align: right;
        }
        .auto-style60 {
            height: 47px;
            text-align: center;
        }
        .auto-style66 {
            width: 107px;
            text-align: right;
            height: 11px;
        }
        .auto-style83 {
            height: 29px;
            text-align: center;
        }
        .auto-style84 {
            height: 23px;
            text-align: center;
        }
        .auto-style99 {
            width: 118px;
            height: 10px;
            text-align: left;
        }
        .auto-style116 {
            height: 21px;
            text-align: right;
        }
        .auto-style118 {
            height: 21px;
            }
        .auto-style119 {
            height: 21px;
            width: 107px;
            text-align: right;
        }
        .auto-style120 {
            width: 118px;
            height: 21px;
            text-align: left;
        }
        .auto-style123 {
            width: 107px;
            /*text-align: right;*/
            text-align: right;
            height: 10px;
        }
        .auto-style134 {
            width: 107px;
            /*text-align: right;*/
            text-align: right;
            height: 13px;
        }
        .auto-style150 {
            height: 29px;
            text-align: left;
            }
        .auto-style157 {
            width: 118px;
            height: 13px;
            text-align: left;
        }
        .auto-style165 {
            width: 107px;
            text-align: right;
            height: 2px;
        }
        .auto-style167 {
            text-align: left;
            height: 5px;
            }
        .auto-style171 {
            width: 107px; /*text-align: right;; */
            text-align: right;
            height: 5px;
        }
        .auto-style172 {
            height: 5px;
            }
        .auto-style174 {
            height: 20px;
            width: 107px;
            text-align: right;
        }
        .auto-style175 {
            height: 20px;
            text-align: left;
            }
        .auto-style176 {
            height: 20px;
            }
        .auto-style204 {
            width: 107px; /*text-align: right;*/
            text-align: right;
            height: 3px;
        }
        .auto-style208 {
            height: 23px;
            text-align: right;
            font-size: large;
            width: 107px;
        }
        .auto-style219 {
            height: 20px;
            width: 118px;
            text-align: left;
        }
        .auto-style220 {
            height: 11px;
            width: 118px;
        }
        .auto-style222 {
            height: 5px;
            width: 118px;
        }
        .auto-style223 {
            height: 2px;
            width: 118px;
        }
        .auto-style227 {
            height: 3px;
            width: 118px;
            text-align: left;
        }
        .auto-style228 {
            text-align: left;
        }
        .auto-style229 {
            margin-left: 45px;
        }
        .auto-style230 {
            margin-right: 0px;
        }
        .auto-style231 {
            height: 20px;
            text-align: right;
        }
        .auto-style232 {
            height: 23px;
            font-size: large;
            text-align: left;
            }
        .auto-style234 {
            height: 36px;
            width: 118px;
            text-align: left;
        }
        .auto-style239 {
            height: 41px;
            width: 73px;
            text-align: right;
        }
        .auto-style240 {
            height: 41px;
            text-align: left;
            }
        .auto-style244 {
            height: 41px;
            }
        .auto-style246 {
            height: 51px;
            }
        .auto-style247 {
            height: 51px;
            text-align: center;
        }
        .auto-style248 {
            width: 73px; /*text-align: right;*/
            text-align: right;
            height: 8px;
        }
        .auto-style249 {
            height: 8px;
            text-align: left;
            }
        .auto-style250 {
            height: 8px;
            }
        .auto-style272 {
            width: 107px;
            /*text-align: right;*/
            text-align: right;
        }
        .auto-style276 {
            height: 23px;
            width: 107px;
            text-align: right;
        }
        .auto-style279 {
            height: 36px;
            }
        .auto-style280 {
            height: 23px;
            width: 118px;
        }
        .auto-style284 {
            width: 118px;
        }
        .auto-style285 {
            height: 36px;
            width: 118px;
        }
        .auto-style287 {
            height: 29px;
        }
        .auto-style288 {
            height: 29px;
            width: 118px;
        }
        .auto-style289 {
            height: 3px;
            }
        .auto-style290 {
            height: 10px;
            }
        .auto-style292 {
            width: 118px;
            text-align: left;
        }
        .auto-style293 {
            height: 23px;
            text-align: left;
            width: 118px;
        }
        .auto-style295 {
            height: 39px;
            width: 107px;
            text-align: right;
        }
        .auto-style297 {
            height: 39px;
        }
        .auto-style298 {
            width: 118px;
            height: 39px;
            text-align: left;
        }
        .auto-style299 {
            width: 73px;
            /*text-align: right;*/
            text-align: right;
        }
        .auto-style301 {
            width: 73px; /*text-align: right;; */
            text-align: right;
            height: 5px;
        }
        .auto-style302 {
            height: 20px;
            width: 73px;
            text-align: right;
        }
        .auto-style303 {
            height: 23px;
            width: 73px;
            text-align: right;
        }
        .auto-style305 {
            width: 73px;
            height: 36px;
            text-align: right;
        }
        .auto-style306 {
            height: 23px;
            text-align: left;
        }
        .auto-style307 {
            height: 23px;
        }
        .auto-style308 {
            width: 73px;
            height: 29px;
            text-align: right;
        }
        .auto-style309 {
            width: 73px; /*text-align: right;*/
            text-align: right;
            height: 3px;
        }
        .auto-style310 {
            width: 73px;
            /*text-align: right;*/
            text-align: right;
            height: 10px;
        }
        .auto-style312 {
            height: 39px;
            width: 73px;
            text-align: right;
        }
        .auto-style313 {
            height: 39px;
            text-align: left;
        }
        .auto-style324 {
            text-align: right;
            height: 11px;
        }
        .auto-style327 {
            text-align: right;
            height: 2px;
        }
        .auto-style334 {
            height: 23px;
            text-align: right;
            font-size: large;
            }
        .auto-style347 {
            /*text-align: right;*/text-align: right;
            height: 8px;
            }
        .auto-style353 {
            height: 41px;
            text-align: right;
            }
        .auto-style368 {
            /*text-align: right;; */
            text-align: right;
            height: 5px;
        }
        .auto-style369 {
            height: 36px;
            text-align: right;
        }
        .auto-style371 {
            /*text-align: right;*/
            text-align: right;
            height: 3px;
        }
        .auto-style372 {
            /*text-align: right;*/
            text-align: right;
            height: 10px;
        }
        .auto-style373 {
            /*text-align: right;*/text-align: right;
        }
        .auto-style374 {
            /*text-align: right;*/
            text-align: right;
            height: 13px;
        }
        .auto-style375 {
            height: 39px;
            text-align: right;
        }
    </style>

  

     <%-- rem query 2--%><%--<script src="Plugin/jquery-3.5.1.min.js"></script>
<script type="text/javascript">
        $(document).ready(function () {
            $(".txt").hover(function () {
                $(this).css("background-color", "#fff4d8");
            }, function () {
                $(this).css("background-color", "#FFFFFF");
            });
        });
    </script>--%><%-- rem query 1--%>
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
            $d('input').dblclick(function () {
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
                <%--  $d(this).attr('readonly', true);      this was for  making no input on mouse out--%>
            });
           
        });
    </script>

   


     <%-- rem query 4--%><%--  <script type="text/javascript" src="scripts/jquery-1.4.2.min.js">  </script>     
    <script type="text/javascript">
        $(function ()
        {
            $('input:text[value!=]').dblclick(function ()
            {
                $(this).attr('readonly', false);
            });
        });
    </script>--%>

</head>
<body>
   
 
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    </div>
        <p class="auto-style40">
            <asp:TextBox ID="TextBox73" runat="server" AutoPostBack="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="chk" runat="server" CssClass="txt" AutoPostBack="True"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#990000" Text="Session: "></asp:Label>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#990000" Text="set"></asp:Label>
       &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Font-Size="Large" Height="38px" Text="Update" Width="148px" />
            &nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Text="Back" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Reset" />
        </p>
        <p class="auto-style40">
            <asp:Button ID="Button5" runat="server" Text="Previous" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" Text="Next" Width="77px" />
            &nbsp;<asp:Label ID="label3" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#FF3300" Height="35px" Width="556px"></asp:Label>
       </p>

        <div id="ch" runat="server" style = 'color:blue'>
        </div>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" SelectCommand="SELECT [Class_Std], [Name_of_Student] FROM [2020-21]"></asp:SqlDataSource>
    <table class="auto-style1"   style="border: thin solid #800000; empty-cells: show; ">
        <tr style="border: thin solid #FF5959">
            <td style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " class="auto-style247">&nbsp;</td>
            <td colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " class="auto-style247">Current Personal Profile </td>
            <td class="auto-style246"></td>
            <td class="auto-style228" colspan="3" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " draggable="true" rowspan="5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Image ID="Image1" runat="server" CssClass="auto-style230" Height="153px" Width="139px" />
                <asp:Image ID="Image2" runat="server" CssClass="auto-style229" Height="155px" Width="136px" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Student Photo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Parents/Guardian Photo<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
        </tr>
        <tr style="border: thick solid #FF5959">
            <td class="auto-style347" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check1" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style248" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Name of Student</td>
            <td class="auto-style249" style="border-right: thin solid #800000; border-bottom: thin solid #800000; border-left-color: #800000; border-left-width: thin; border-top-color: #800000; border-top-width: thin;" aria-selected="undefined">
                <asp:TextBox ID="tname" runat="server" Font-Size="Large" Height="23px" Width="269px" CssClass="txt" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style250"></td>
        </tr>
        <tr>
            <td class="auto-style373" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check2" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Surname</td>
            <td class="auto-style228" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tsurname" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style368" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check3" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style301" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Gender</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style167">
                <asp:DropDownList ID="dlgender" runat="server" Height="24px" Width="89px">
                </asp:DropDownList>
            </td>
            <td class="auto-style172"></td>
        </tr>
        <tr>
            <td class="auto-style373" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check4" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Class/Standard</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style228">
                <asp:DropDownList ID="dlclass" runat="server" Height="38px" Width="89px">
                </asp:DropDownList>
            </td>
            <td></td>
        </tr>
        <tr>
            <td class="auto-style231" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check5" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style302" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Section</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style175">
                <asp:DropDownList ID="dlsection" runat="server" Height="28px" Width="89px">
                </asp:DropDownList>
            </td>
            <td class="auto-style176"></td>
            <td class="auto-style231" aria-selected="undefined" style="border-top-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large; border-bottom-style: solid;" draggable="true">&nbsp;</td>
            <td class="auto-style231" aria-selected="undefined" style="border-top-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large; border-bottom-style: solid;" draggable="true" colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style33" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check6" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Roll No.</td>
            <td style="border-width: thin; border-color: #800000; border-right-style: solid; border-bottom-style: solid;">
                <asp:TextBox ID="trollno" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style279">&nbsp;</td>
            <td class="auto-style60" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " draggable="true">&nbsp;</td>
            <td class="auto-style60" colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " draggable="true">Family Profile</td>
        </tr>
        <tr>
            <td class="auto-style373" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check7" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Date of Birth<br />
                (dd-mm-yyyy)</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style228">
                <asp:TextBox ID="tdob" runat="server" Height="16px" EnableViewState="False" ></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style324" style="border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check36" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style66" style="border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Name of&nbsp; Mother</td>
            <td class="auto-style220" style="border-width: thin; border-color: #800000">
                <asp:TextBox ID="tNmother" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style369" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                </td>
            <td class="auto-style305" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Age</td>
            <td class="auto-style279" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tage" runat="server" Font-Size="Large" Height="23px" Width="269px" ReadOnly="True" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style279"></td>
            <td class="auto-style369" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check37" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style34" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Name of&nbsp; Father</td>
            <td class="auto-style285" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tNfather" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style353" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check9" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style239" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Category</td>
            <td class="auto-style240" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:DropDownList ID="dlcateg" runat="server" Height="16px" Width="78px">
                </asp:DropDownList>
            </td>
            <td class="auto-style244"></td>
            <td class="auto-style368" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check38" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style171" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Mother&#39;s Occupation</td>
            <td class="auto-style222" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tOmother" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style373" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check10" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Height (Inches)</td>
            <td class="auto-style306" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:DropDownList ID="dlheight" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style307">&nbsp;</td>
            <td class="auto-style327" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check39" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style165" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Father&#39;s Occupation</td>
            <td class="auto-style223" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tOfather" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style33" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check11" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Weight (Kg)</td>
            <td class="auto-style232" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:DropDownList ID="dlweight" runat="server">
                </asp:DropDownList>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style231" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check40" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style174" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Brothers</td>
            <td class="auto-style219" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:DropDownList ID="dlbro" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style33" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check12" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Academic Skills</td>
            <td class="auto-style307" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tAcSkill" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style33" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check41" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Sisters</td>
            <td class="auto-style234" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:DropDownList ID="dlsis" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style373" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check13" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Other Skills/Interests </td>
            <td class="auto-style307" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tOSkill" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style33" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check42" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Guardian&#39;s Name</td>
            <td style="border-width: thin; border-color: #800000; border-top-style: solid;" class="auto-style284">
                <asp:TextBox ID="tNguardian" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style373" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check14" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Hobbies</td>
            <td class="auto-style307" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="thobbies" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style369" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check43" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style34" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Relation with Guardian</td>
            <td class="auto-style285" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tRguardian" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style59" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check15" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style308" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Differently Abled</td>
            <td class="auto-style150" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:DropDownList ID="dlDiAbled" runat="server" Height="44px" Width="77px">
                </asp:DropDownList>
            </td>
            <td class="auto-style287"></td>
            <td class="auto-style369" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">&nbsp;</td>
            <td class="auto-style34" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">&nbsp;</td>
            <td class="auto-style285" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style373" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check16" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Kind of Ability</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tKindAbility" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style287">&nbsp;</td>
            <td class="auto-style33" aria-selected="undefined" style="border-top-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; border-bottom-style: solid;" draggable="true">&nbsp;</td>
            <td class="auto-style33" aria-selected="undefined" style="border-top-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; border-bottom-style: solid;" colspan="2" draggable="true">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style59" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                &nbsp;</td>
            <td class="auto-style59" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" colspan="2"></td>
            <td class="auto-style287"></td>
            <td class="auto-style83" aria-selected="undefined" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " draggable="true">&nbsp;</td>
            <td class="auto-style83" aria-selected="undefined" colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " draggable="true">Official Details</td>
        </tr>
        <tr>
            <td style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " class="auto-style40">&nbsp;</td>
            <td colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " class="auto-style40">Contact Details</td>
            <td class="auto-style287"></td>
            <td class="auto-style33" aria-selected="undefined" style="border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check44" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style276" aria-selected="undefined" style="border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Admission No.</td>
            <td class="auto-style288" style="border-width: thin; border-color: #800000">
                <asp:TextBox ID="tadmsn" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style373" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check18" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Phone No. (Mother)</td>
            <td class="auto-style307" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tMphone" runat="server" Font-Size="Large" Height="23px" Width="271px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style287"></td>
            <td class="auto-style59" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check45" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style39" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">SSSMID</td>
            <td class="auto-style288" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tsssm" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style373" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check19" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Phone No. (Father)</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tFphone" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style287"></td>
            <td class="auto-style33" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check46" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Aadhar No.</td>
            <td class="auto-style288" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="taadhar" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style33" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check20" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Phone No. (Guardian)</td>
            <td class="auto-style307" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tGphone" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style33" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check47" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Enrollment No.</td>
            <td class="auto-style280" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tEnrlNo" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style371" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check21" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style309" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Phone No. (Other)</td>
            <td class="auto-style289" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tOphone" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style289"></td>
            <td class="auto-style371" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check48" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style204" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Date of Enrollment(dd-mm-yyyy)</td>
            <td class="auto-style227" style="border-width: thin; border-color: #800000; border-top-style: solid;" aria-multiline="False">
                <asp:TextBox ID="tdoe" runat="server" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style372" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check22" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style310" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">E-mail Id.</td>
            <td class="auto-style290" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="temail" runat="server" Font-Size="Large" Height="23px" Width="271px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style290"></td>
            <td class="auto-style372" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check49" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style123" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Date of&nbsp; Leaving the Last School<br />
                (dd-mm-yyyy)</td>
            <td class="auto-style99" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tdol" runat="server" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style373" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check23" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Local Address</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tLaddress" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style373" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check50" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style272" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Date of&nbsp; Leaving this School<br />
                (dd-mm-yyyy)</td>
            <td class="auto-style292" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="tdot" runat="server" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style373" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check24" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Town/City</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tTown" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style334" aria-selected="undefined" style="border-style: solid; border-width: thin; border-color: #800000; " draggable="true">
                <asp:CheckBox ID="Check51" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style208" aria-selected="undefined" style="border-style: solid; border-width: thin; border-color: #800000; " draggable="true">Last Class in the Last School</td>
            <td class="auto-style293" aria-selected="undefined" style="border-top-style: solid; border-width: thin; border-color: #800000; border-bottom-style: solid;" draggable="true">
                <asp:DropDownList ID="dlLastClass" runat="server" Height="44px" Width="77px">
                </asp:DropDownList>
                </td>
        </tr>
        <tr>
            <td class="auto-style33" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check25" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">PIN/ZIP CODE</td>
            <td class="auto-style307" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tpin" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td style="border-width: thin; border-color: #800000; font-size: large; font-weight: bold; color: #800000; border-bottom-style: solid; border-left-style: solid;" aria-selected="undefined" draggable="true" class="auto-style40">&nbsp;</td>
            <td colspan="2" style="border-width: thin; border-color: #800000; font-size: large; font-weight: bold; color: #800000; border-bottom-style: solid; border-left-style: solid;" aria-selected="undefined" draggable="true" class="auto-style40">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style373" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check26" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">State/Province</td>
            <td class="auto-style306" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:DropDownList ID="dlstate" runat="server" Height="44px" Width="77px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " aria-selected="undefined" draggable="true" class="auto-style40">&nbsp;</td>
            <td colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " aria-selected="undefined" draggable="true" class="auto-style40">Student Details at the Time of Enrollment in the School</td>
        </tr>
        <tr>
            <td class="auto-style373" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check27" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Permanent Address</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tPaddress" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style33" aria-selected="undefined" style="border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check52" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style276" aria-selected="undefined" style="border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Class/Standard</td>
            <td class="auto-style292" style="border-width: thin; border-color: #800000">
                <asp:DropDownList ID="DropDownList17" runat="server" Height="44px" Width="77px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style33" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check28" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Town/City</td>
            <td style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" class="auto-style307">
                <asp:TextBox ID="tcity" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style33" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check53" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Section</td>
            <td class="auto-style293" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:DropDownList ID="DropDownList16" runat="server" Height="44px" Width="77px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style373" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check29" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style299" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">PIN/ZIP CODE</td>
            <td class="auto-style307" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:TextBox ID="tzip" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style33" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check54" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Roll No.</td>
            <td class="auto-style280" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="TextBox65" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style33" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check30" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">State/Province</td>
            <td class="auto-style306" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:DropDownList ID="dlprovince" runat="server" Height="44px" Width="77px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td class="auto-style33" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check55" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Age</td>
            <td class="auto-style284" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="TextBox33" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style33" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">
                <asp:CheckBox ID="Check31" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style303" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000; font-size: large;">Country</td>
            <td class="auto-style306" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">
                <asp:DropDownList ID="dlcountry" runat="server" Height="44px" Width="77px">
                </asp:DropDownList>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style33" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check56" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Height (Inches)</td>
            <td class="auto-style293" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                </td>
        </tr>
        <tr>
            <td class="auto-style116" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000">&nbsp;</td>
            <td class="auto-style116" style="border-right-style: solid; border-bottom-style: solid; border-width: thin; border-color: #800000" colspan="2"></td>
            <td class="auto-style118"></td>
            <td class="auto-style374" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check57" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style134" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Weight (Kg)</td>
            <td class="auto-style157" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="TextBox68" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style84" aria-selected="undefined" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " draggable="true">&nbsp;</td>
            <td class="auto-style84" aria-selected="undefined" colspan="2" style="border: thin solid #800000; font-size: large; font-weight: bold; color: #800000; " draggable="true">Bank Details</td>
            <td class="auto-style290"></td>
            <td class="auto-style116" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check58" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style119" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Academic Skills</td>
            <td class="auto-style120" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="TextBox60" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style375" aria-selected="undefined" style="border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">
                <asp:CheckBox ID="Check32" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style312" aria-selected="undefined" style="border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">Bank A/c No.</td>
            <td class="auto-style313" aria-selected="false" style="border-width: thin; border-color: #800000; border-right-style: solid;">
                <asp:TextBox ID="TextBox69" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style297"></td>
            <td class="auto-style375" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check59" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style295" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Interests</td>
            <td class="auto-style298" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="TextBox61" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style375" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">
                <asp:CheckBox ID="Check33" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style312" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">Account Holder Name</td>
            <td class="auto-style313" aria-selected="undefined" style="border-width: thin; border-color: #800000; border-top-style: solid; border-right-style: solid;">
                <asp:TextBox ID="TextBox70" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style297"></td>
            <td class="auto-style375" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check60" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style295" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Hobbies</td>
            <td class="auto-style298" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="TextBox62" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style33" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">
                <asp:CheckBox ID="Check34" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style303" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">Name of Bank</td>
            <td class="auto-style306" aria-selected="true" style="border-width: thin; border-color: #800000; border-top-style: solid; border-right-style: solid;">
                <asp:TextBox ID="TextBox71" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td class="auto-style307"></td>
            <td class="auto-style33" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check61" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style276" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Differently Abled</td>
            <td class="auto-style293" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style373" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">
                <asp:CheckBox ID="Check35" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style299" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-width: thin; border-color: #800000; " draggable="true">IFSC Code</td>
            <td class="auto-style228" aria-selected="true" style="border-width: thin; border-color: #800000; border-top-style: solid; border-right-style: solid;">
                <asp:TextBox ID="TextBox72" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
            <td></td>
            <td class="auto-style373" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">
                <asp:CheckBox ID="Check62" runat="server" EnableViewState="False" />
            </td>
            <td class="auto-style272" aria-selected="undefined" style="border-top-style: solid; border-right-style: solid; border-left-style: solid; border-width: thin; border-color: #800000; font-size: large;" draggable="true">Kind of Ability</td>
            <td class="auto-style292" style="border-width: thin; border-color: #800000; border-top-style: solid;">
                <asp:TextBox ID="TextBox64" runat="server" Font-Size="Large" Height="23px" Width="269px" EnableViewState="False"></asp:TextBox>
            </td>
        </tr>
    </table>
        
        <p class="auto-style40">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="Large" Height="40px" Text="Update" Width="132px" />
        </p>
        <p class="auto-style40">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </form>
    <p>
        &nbsp;</p>
</body>
</html>
