<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataList.aspx.cs" Inherits="DataGridView.DataList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .trHead td {
            height: 25px;
            width: 150px;
            color: #669900;
            text-align: center;
        }

        .trData td {
            height: 25px;
            width: 150px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" HorizontalAlign="Center">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <HeaderTemplate>
                    <table style="width: 100%;">
                        <tr class="trHead">
                            <td style="width: 50px">编号</td>
                            <td>姓名</td>
                            <td>性别</td>
                            <td>年龄</td>
                            <td>班级</td>
                        </tr>
                    </table>
                </HeaderTemplate>

                <ItemTemplate>
                    <table style="width: 100%">
                        <tr class="trData">
                            <td style="width: 50px">
                                <asp:Label ID="lblID" runat="server" Text='<%# Eval("ID") %>'></asp:Label></td>
                            <td>
                                <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSex" runat="server" Text='<%# Eval("Sex") %>'></asp:Label></td>
                            <td>
                                <asp:Label ID="lblAge" runat="server" Text='<%# Eval("Age") %>'></asp:Label></td>
                            <td>
                                <asp:Label ID="lblClass" runat="server" Text='<%# Eval("Class") %>'></asp:Label></td>

                        </tr>
                    </table>

                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
