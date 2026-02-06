using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_net1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //已登录 用户
            Response.Write("欢迎 " + Session["UserName"] + " 登录，登录时间：" + Session["LoginTime"] + "<br/>");
            ////理解Response.Write();
            //string[] arr=new string[] 
            //{ 
            //    "我不相信造化弄人",
            //    "世界上出类拔萃的人", 
            //    "都主动寻找他们想要的环境" ,
            //    "而不是被动等待环境来找他们",
            //    "——杰克·韦尔奇"
            //};
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    foreach (char c in arr[i])
            //    {
            //        Response.Write(c);
            //        Response.Flush();
            //        System.Threading.Thread.Sleep(100);
            //    }
            //    Response.Write("<br/>");
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("点了开始按钮!");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}