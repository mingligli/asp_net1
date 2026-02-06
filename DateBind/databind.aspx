<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="databind.aspx.cs" Inherits="DateBind.databind" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <table align="center">

        <tr>
            <th colspan="2">简单数据绑定</th>
        </tr>

        <tr>
            <td width="150px" align="center">姓&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;名:</td>
            <td width="200px"><%# Name %> </td>
        </tr>

        <tr>
            <td width="150px" align="center">年&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;龄:</td>
            <td width="200px"><%# Age %> </td>
        </tr>

        <tr>
            <td width="150px" align="center">性&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;别:</td>
            <td width="200px"><%# Sex %> </td>
        </tr>

        <tr>
            <td width="150px" align="center">证件类型:</td>
            <td width="200px"><%# Idtype %> </td>
        </tr>

        <tr>
            <td width="150px" align="center">证件号码:</td>
            <td width="200px"><%# IdNo %> </td>
        </tr>

    </table>
</body>
</html>
