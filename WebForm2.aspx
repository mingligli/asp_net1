<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="asp_net1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>以下为各客户端访问历史记录</div>
            <div>PC端：<asp:Label ID="PC" runat="server" Text="Lable1" ></asp:Label></div>
            <div>Android端：<asp:Label ID="Android" runat="server" Text="Lable1" ></asp:Label></div>
            <div>Iphoen端：<asp:Label ID="Iphone" runat="server" Text="Lable1" ></asp:Label></div>
            <div>Winhpone端：<asp:Label ID="Winhpone" runat="server" Text="Lable1" ></asp:Label></div>
        </div>
    </form>
</body>
</html>
