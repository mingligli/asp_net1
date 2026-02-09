<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataList.aspx.cs" Inherits="DataGridView.DataList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .trHead td {
            height: 25px;
            width: 100px;
            color: #669900;
            text-align: center;
        }

        .trData td {
            height: 25px;
            width: 100px;
            text-align: center;
        }

        .Pager {
            font-size: 13px;
            font-family: Arial;
        }

        .TxtPage, .BtnPage {
            border: 1px;
            border-style: solid;
            border-color: grey;
        }

        .TxtPage {
            width: 100px;
        }

        .BtnPage {
            width: 80px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" HorizontalAlign="Center" Style="margin-left: 0px" Width="874px" OnItemCommand="DataList1_ItemCommand" OnItemDataBound="DataList1_ItemDataBound">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <FooterTemplate>
                    <div class="Pager">
                        总页数：<asp:Label ID="labCount" runat="server" Text="0"></asp:Label>&nbsp;
                    当前页：<asp:Label ID="labNowPage" runat="server" Text="1"></asp:Label>&nbsp;
                    <asp:LinkButton ID="lnkbtnFirst" runat="server" CommandName="first">首页</asp:LinkButton>&nbsp;
                    <asp:LinkButton ID="lnkbtnFront" runat="server" CommandName="pre">上一页</asp:LinkButton>&nbsp;
                    <asp:LinkButton ID="lnkbtnNext" runat="server" CommandName="next">下一页</asp:LinkButton>&nbsp;
                    <asp:LinkButton ID="lnkbtnLast" runat="server" CommandName="last">尾页</asp:LinkButton>&nbsp;
                    跳转到：<asp:TextBox ID="txtPage" runat="server" CssClass="TxtPage" ></asp:TextBox>&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="跳转" CssClass="BtnPage" CommandName="search" />
                    </div>
                </FooterTemplate>
                <HeaderStyle BackColor="White" Font-Bold="True" ForeColor="White" />
                <HeaderTemplate>
                    <table style="width: 100%;" class="custom-table">
                        <tr class="trHead">
                            <td style="width: 50px" rowspan="2">编号</td>
                            <td rowspan="2">姓名</td>
                            <td colspan="4">综合信息</td>
                        </tr>
                        <tr class="trHead">
                            <td>性别</td>
                            <td>年龄</td>
                            <td>班级</td>
                            <td>操作</td>
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
                            <td>
                                <asp:LinkButton ID="LnkBtnShow" runat="server" CommandName="select">查看</asp:LinkButton></td>
                            </td>

                        </tr>
                    </table>
                </ItemTemplate>

                <SelectedItemTemplate>
                     <table>
                    <tr><td>ID：</td><td><asp:Label ID="LblID" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "ID")%>'></asp:Label></td></tr>
                    <tr><td>姓名：</td><td><asp:Label ID="LblName" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Name")%>'></asp:Label></td></tr>
                    <tr><td>性别：</td><td><asp:Label ID="LblSex" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Sex")%>'></asp:Label></td></tr>
                    <tr><td>年龄：</td><td><asp:Label ID="LblAge" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Age")%>'></asp:Label></td></tr>
                    <tr><td>班级：</td><td><asp:Label ID="LblClass" runat="server" Text='<%#DataBinder.Eval(Container.DataItem, "Class")%>'></asp:Label></td></tr>
                </table>
                    <asp:LinkButton ID="LnkBtnBack" runat="server" CommandName="back">取消</asp:LinkButton>
                </SelectedItemTemplate>

            </asp:DataList>
        </div>
    </form>
</body>
</html>
