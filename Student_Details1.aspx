<%@ Page  culture="en-IN"   Language="VB" AutoEventWireup="false" CodeFile="Student_Details1.aspx.vb" Inherits="Student_Details1" %>

<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v20.2, Version=20.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v20.2, Version=20.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%----%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .GridViewStyle {
       
        
        }
        /*.scrolloing-table-container {
            height: 176px;
            overflow-y:scroll;
            overflow-x:scroll;
        }*/
       
        .fixed {
            top: expression(this.parentNode.parentNode.parentNode.scrollTop-1);
          }
         
        .auto-style2 {
            width: 1350px;
             margin:auto ;
            
            height:350px;
            
        }
        .auto-style3 {
          width:1350px;   
           height:350px;
          overflow: auto;
   
        }
         th {
             position:sticky;
             top : 0px;
             background-color:white;  
                   }
    
                  
        
        
        .auto-style5 {
            height: 100%;
            width: 100%; 
       
        }
       
        .auto-style6 {
            margin-top: 0px;
           
        }
      
       
        .auto-style7 {
            margin-left: 245px;
        }
       
        .auto-style8 {
            margin-left: 0px;
        }
       
        </style>
   
    
     


    <script src="plugin/jquery-3.5.1.min.js" type="text/javascript" ></script>
<script src="plugin/colResizable-1.6.min.js" type="text/javascript" ></script>
<script src="plugin/jquery.cookie.js" type="text/javascript" ></script>
 <script type="text/javascript" >
     $(document).ready(function () {
         if ($.cookie('colWidth') != null) {            
             var columns = $.cookie('colWidth').split(',');
             var i = 0;
             $('.auto-style6 th').each(function () {
                 $(this).width(columns[i++]);
             });
         }

         $(".auto-style6").colResizable({
             hoverCursor: "col-resize",
             dragCursor: "arrow",
             resizeMode: 'overflow',  
             liveDrag: true,
             gripInnerHtml: "<div class='grip' </div>",
             draggingClass: "dragging",
             onResize: onSampleResized
            
         });

     


     });

     var onSampleResized = function (e) {
         var columns = $(e.currentTarget).find("th");
         var msg = "";
         columns.each(function () { msg += $(this).width() + ","; })
         $.cookie("colWidth", msg);
     };

     //On UpdatePanel Refresh
     //var prm = Sys.WebForms.PageRequestManager.getInstance();
     //if (prm != null) {
     //    prm.add_endRequest(function (sender, e) {
     //        if (sender._postBackSettings.panelsToUpdate != null) {
     //            if ($.cookie('colWidth') != null) {            
     //                var columns = $.cookie('colWidth').split(',');
     //                var i = 0;
     //                $('.auto-style6 th').each(function () {
     //                    $(this).width(columns[i++]);
     //                });
     //            }

     //            $(".auto-style6").colResizable({
             
     //                resizeMode: 'overflow',  
     //                liveDrag: true,
     //                gripInnerHtml: "<div class='grip' </div>",
     //                draggingClass: "dragging",
     //                onResize: onSampleResized
     //            });

            

     //        var onSampleResized = function (e) {
     //            var columns = $(e.currentTarget).find("th");
     //            var msg = "";
     //            columns.each(function () { msg += $(this).width() + ","; })
     //            $.cookie("colWidth", msg);
     //        };
     //    }
     //    });
     //};








</script> 

  <%--  for getting fixed header     <script src="Scripts/jquery-1.7.1.js"></script>
         <script type="text/javascript" >
                $(document).ready(function () {
                    var gridHeader = $('#<%=GridView2.ClientID%>').clone(true); // Here Clone Copy of Gridview with style
                    $(gridHeader).find("tr:gt(0)").remove(); // Here remove all rows except first row (header row)
                    $('#<%=GridView2.ClientID%> tr th').each(function (i) {
                        // Here Set Width of each th from gridview to new table(clone table) th 
                        $("th:nth-child(" + (i + 1) + ")", gridHeader).css('width', ($(this).width()).toString() + "px");
                    });
                    $("#GHead").append(gridHeader);
                    $('#GHead').css('position', 'absolute');
                    $('#GHead').css('top', $('#<%=GridView2.ClientID%>').offset().top);
            
                });
             </script>  --%>
  
<%--<script type="text/javascript" >
   function preventBack(){window.history.forward(-1);}
    setTimeout("preventBack()", -1);
    window.onunload=function(){null};
</script>--%>

</head>
<body style="height: 6px">

   
    <form id="form1" runat="server">
        <div style="text-align:center">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>       
        <asp:UpdatePanel ID="UpdatePanel1" runat="server"   >
           <ContentTemplate>
                    <asp:Label ID="Label2" runat="server" Text="Waiting..."></asp:Label>        
               &nbsp;
                 <asp:Timer ID="Timer1" runat="server"  OnTick = "Timer1_Tick" Interval="1000"> </asp:Timer>             
              <asp:Button ID="Button9" runat="server" Text="Check Internet Connection" Width="302px" Font-Bold="False" Font-Size="Large" CssClass="auto-style7" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button14" runat="server" CssClass="auto-style8" Font-Bold="True" Font-Size="Medium" Text="Fee Management" Width="171px" />
</ContentTemplate>
         
        </asp:UpdatePanel>
           
      <%--<asp:UpdatePanel ID="UpdatePanel2" runat="server">
           <ContentTemplate>
       <asp:Label ID="Label3" runat="server" Text="Waiting..."></asp:Label> 
                 <asp:Timer ID="Timer3" runat="server" Interval="200">
        </asp:Timer>
       </ContentTemplate>
        </asp:UpdatePanel>--%>
     
       
       
     
       
       
     
        <asp:Button ID="Button6" runat="server" Text="Backward" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Text="Foreward" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button10" runat="server" PostBackUrl="~/EditPage1.aspx" Text="Button" />
        &nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
            <asp:Button ID="Button13" runat="server" Font-Bold="True" Font-Size="Medium" Text="Fee Master" />
    
        <asp:Button ID="Button3" type="button" runat="server" Text="Logout" Width="92px" style="height: 26px" />
    
        &nbsp;&nbsp;&nbsp;
    
        <asp:Button ID="Button1" runat="server" Text="Session Management" Height="34px" />
    
        <br />
    
   
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      
         <p>
             
            Name&nbsp;
             
    
            <asp:TextBox ID="TextBox1" runat="server"  Height="29px" Width="202px" AutoCompleteType="Disabled" AutoPostBack="True" ></asp:TextBox>
              
    
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Class&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         
             <asp:DropDownList ID="DropDownList1" runat="server"   Height="39px" Width="115px" Font-Bold="True" Font-Size="Large" AutoPostBack="True">
        </asp:DropDownList>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           
              <asp:DropDownList ID="DropDownList2" runat="server" Font-Bold="True" Font-Size="Medium" Height="33px" Width="57px" AutoPostBack="True">
            </asp:DropDownList>
             
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="Reset" Font-Bold="True" Font-Size="Large" Height="33px" Width="82px" />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Size="Large" Height="28px" Text="FormView - Edit - Add" Width="252px" ToolTip="SELECT A PARTICULAR TO SEE FORM VIEW" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button7" runat="server" Font-Bold="True" Font-Size="Medium" Text="Update Age" Width="124px" />
            &nbsp;&nbsp;
             <asp:Button ID="Button11" runat="server" Font-Bold="True" Font-Size="Medium" Text="Deleted Records" />
             <asp:Button ID="Button12" runat="server" Font-Bold="True" Font-Size="Medium" Font-Underline="True" Text="Student Details" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
        <%--</p>--%><%-- <div id="ch1" runat="server" style = 'color:blue'>
        </div>--%>
        <div id="ch" runat="server" style = 'color:blue'> </div>        

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
              <table class="auto-style2" border="1" style= "text-align:center" >
             
             <tr> 
         <th class="auto-style5"> &nbsp;
   
      <%--    <div id="GHead"  class ="auto-style13"></div> --%>
                 <div class ="auto-style3" >
          
           
         <asp:GridView ID="GridView2"    runat="server" Width="5000px" AllowSorting="True" CssClass="auto-style6"   BackColor ="#DEBA84"    BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" HorizontalAlign="Center" >
             <EditRowStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
             <EmptyDataRowStyle HorizontalAlign="Left" VerticalAlign="Middle" Wrap="False" />
             <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
             <HeaderStyle   horizontalalign="center" BackColor="#A55129"   Font-Bold="True" ForeColor="#A55129" VerticalAlign="Middle" Wrap="False"  />
             <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
             <RowStyle     HorizontalAlign="Left"  BackColor  ="#FFF7E7"      ForeColor  ="#8C4510" VerticalAlign="Middle" Wrap="False" />
             <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
             <SortedAscendingCellStyle BackColor="#FFF1D4" />
             <SortedAscendingHeaderStyle BackColor="#B95C30" />
             <SortedDescendingCellStyle BackColor="#F1E5CE" />
             <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>

                
            </div>
        
     

        </th>
            </tr>
                  
        </table>
    

   
    

   
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:masterConnectionString1 %>" SelectCommand="SELECT * FROM [CBSPS]"></asp:SqlDataSource>
       


       

   
        <%--type="date"--%>       
       

   </div>
    </form>
    </body>
</html>
