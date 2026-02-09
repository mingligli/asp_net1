<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListView.aspx.cs" Inherits="DataGridView.ListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <style type="text/css">
        .tabList {
            border:1px;
            border-style:solid;
            border-collapse:collapse;
            width:600px;
        }
        .tabList tr th,.tabList tr td {
            border:1px;
            border-style:solid;
        }
        .tabList tr th {
            border-color:white;
        }
        .tabList tr td{
            border-color:#4dcfcf;
            text-align:center;
        }
        .tabList tr th {
            background-color:#4dcfcf;
            color:white;
            height:30px;
        }
        .tabList tr td input{
            border:1px;
            border-style:solid;
            border-color:#4dcfcf;
        }
    </style>
</head>
<body>
      <form id="form1" runat="server">
    <div>
         <asp:ListView runat="server" DataSourceID="SqlDataSource1"  ID="ListView1">
             <LayoutTemplate>
                 <table class="tabList">
                     <thead>
                         <tr>
                             <th>ID</th>
                             <th>姓名</th>
                             <th>性别</th>
                             <th>年龄</th>
                             <th>班级</th>
                         </tr>
                     </thead>
                     <tbody>
                         <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                     </tbody>
                     <tfoot>
                         <tr>
                             <td colspan="5">
                                 <asp:DataPager ID="DataPager1" runat="server" PagedControlID="ListView1" PageSize="2">
 	                        <Fields>
 	                            <asp:NextPreviousPagerField ShowFirstPageButton="True" 
 	                                ShowNextPageButton="True" ShowPreviousPageButton="False" />
 	                            <asp:NumericPagerField ButtonType="Button" />
 	                            <asp:NextPreviousPagerField ShowLastPageButton="True" 
 	                                ShowPreviousPageButton="True" ShowNextPageButton="False" />
 	                        </Fields>
 	                    </asp:DataPager>
                             </td>
                         </tr>
                     </tfoot>
                 </table>
             </LayoutTemplate>
             <ItemTemplate>
                 <tr>
                     <td><%#Eval("ID") %></td>
                     <td><%#Eval("Name") %></td>
                     <td><%#Eval("Sex") %></td>
                     <td><%#Eval("Age") %></td>
                     <td><%#Eval("Class") %></td>
                 </tr>
             </ItemTemplate>            
         </asp:ListView>
         <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:studyCConnectionString2 %>" SelectCommand="SELECT * FROM [Student]"></asp:SqlDataSource>      
    </div>
    </form>
</body>
</html>
