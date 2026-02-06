<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="asp_net1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="css.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" >
        <asp:Label Text="这是一个Lable控件的外观设置" runat="server" CssClass="sty_lable" />
        <table>
            <tr>
                <td>用户名：</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server">mr</asp:TextBox></td>
            </tr>
            <tr>
                <td>密码：</td>
                <td>
                    <asp:TextBox ID="txtPWD" runat="server">mrsoft</asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnLogin" runat="server" Text="登录" OnClick="btnLogin_Click" />
                    <asp:Button ID="btnCancel" runat="server" Text="取消" />

                </td>
            </tr>
        </table>
        <requiredFieldValidator ControlToValidate="txtUserName" Errormessage="姓名不能为空" ></requiredFieldValidator>
        <p>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">打开我的网盘</asp:LinkButton>
        </p>
        <p>
            &nbsp;</p>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Text="语文" Value="1" />
            <asp:ListItem Text="数学" Value="2"/>
            <asp:ListItem Text="英语" Value="3" />

        </asp:DropDownList>
    </form>
</body>
</html>
