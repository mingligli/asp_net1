<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="ADO.Edit1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td width="80">姓名：</td>
                    <td width="180">
                        <asp:TextBox ID="txt_Name" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td width="80">性别：</td>
                    <td width="180">
                        <asp:DropDownList ID="drop_Sex" runat="server">
                            <asp:ListItem Text="男" Value="男" />
                            <asp:ListItem Text="女" Value="女" />
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td width="80">年龄：</td>
                    <td width="180">
                        <asp:TextBox ID="txt_Age" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td width="80">班级：</td>
                    <td width="180">
                        <asp:TextBox ID="txt_Class" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btn_Edit" runat="server" Text="修改" OnClick="btn_Edit_Click" />
                    </td>
                </tr>
            </table>
            <asp:HiddenField ID="EditID" runat="server" />
        </div>
    </form>
</body>
</html>
