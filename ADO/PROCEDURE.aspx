<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PROCEDURE.aspx.cs" Inherits="ADO.PROCEDURE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <style type="text/css">
      /*设置表格、表头、单元格的边框宽度及颜色和样式*/
      table, table th, table td {
          margin:20px auto;
          border:1px;
          border-style:solid;
          border-color:#22bbad;
      }
      /*重写表头的边框颜色*/
      table th {
          border-color:white;
      }
      /*将表格中的边框进行合并*/
      table {            
          border-collapse:collapse;
      }
      /*设置表头的大小及颜色*/
      table th {
          width:150px;
          height:30px;
          text-align:center;
          background-color:#22bbad;
          color:white;
      }
      /*设置单元格的高度与文本位置*/
      table td {
          height:30px;
          text-align:center;
      }
      /*设置表格边框为0像素，即：无边框样式*/
      .addtab, .addtab th, .addtab td { 
          border:0px;
      }
      /*设置单元格内所有的控件宽度为150像素*/
      .addtab td *{
          width:150px;
      }
      /*设置按钮控件宽度以及边框样式*/
      .addtab td [type=submit]{
          width:80px;
          border:1px;
          border-style:solid;
          border-color:#808080;
      }
  </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:TextBox ID="textbox1" runat="server"></asp:TextBox>
                <asp:Button ID="buttun1" runat="server" Text="搜索" OnClick="buttun1_Click" />
            </div>
            <div id="tablist" runat="server">   </div>
        </div>
    </form>
</body>
</html>
