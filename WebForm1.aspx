<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="asp_net1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>青岩开发一个页面看看</title>
    <link href="css.css" rel="stylesheet" />
</head>
<body>
    
    <form id="form1" runat="server">
                <asp:Button ID="Button6"  Text="开始抽奖" runat="server" OnClick="Button6_Click" /><p />    
        文本框：<input type="text" /><br />
        密码框：<input type="password" /><br />
        单选按钮：
        <input type="radio" name="sex" value="男" />
        男
        <input type="radio" name="sex" value="女" />
        女<br />
        复选框：
        <input type="checkbox" name="hobby" value="篮球" />
        篮球
        <input type="checkbox" name="hobby" value="足球" />
        足球
        <input type="checkbox" name="hobby" value="排球" />
        排球<br />
        下拉列表：
        <select>
            <option value="语文">语文</option>
            <option value="数学">数学</option>
            <option value="英语">英语</option>
        </select><br />
        打开百度网址：
        <a href="https://www.baidu.com" target="_blank">百度</a><br />
        提交按钮：
        <input type="submit" disabled="disabled" value="提交" runat="server"  /><br />
        <div>

            <%--设计一个表格--%>
            <table border="1" width="310" height="170" align="center">
                <caption>人员信息表</caption>
                <tr>
                    <th>姓名</th>
                    <th>年龄</th>
                    <th>性别</th>
                </tr>
                <tr>
                    <td>张三</td>
                    <td>25</td>
                    <td>男</td>
                </tr>
                <tr>
                    <td>李四</td>
                    <td>30</td>
                    <td>女</td>
                </tr>
            </table>
            <p />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="开始" /><br />
            <center>
                这是一个居中的文字<p />
                <b>写一行字看看效果粗细如何
                </b>
                <p />
            </center>
            <%--有序列表和无序列表--%>
            <ul>
                <li>项目一</li>
                <li>项目二</li>
                <li>项目三</li>
            </ul>
            <ol>
                <li>第一项</li>
                <li>第二项</li>
                <li>第三项</li>
            </ol>
            <h1 style="color: brown; font-family: STCaiyun">h1的标题大小</h1>
            <p />
            <h2>h2的标题大小</h2>
            <p />
            <h3>h3的标题大小</h3>
            <p />
            <h4>h4的标题大小</h4>
            <p />
            <h5>h5的标题大小</h5>
            <p />
            <h6>h6的标题大小</h6>
            <p />

            <asp:Label ID="Label1" runat="server" Text="Hello, World!"></asp:Label>
        </div>
    </form>
</body>
</html>
