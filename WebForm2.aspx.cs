using System;

namespace asp_net1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //显示各类设备的访问量
            this.PC.Text = Application["PC"].ToString();
            this.Android.Text = Application["Android"].ToString();
            this.Iphone.Text = Application["Iphone"].ToString();
            this.Winhpone.Text = Application["WinPhone"].ToString();

            //Response.Write("欢迎来到WebForm2页面！");
            DateTime Now = DateTime.Now;
            Random ran = new Random();
            int Draw = ran.Next(1, 101);
            if (Draw >= 1 && Draw <= 5)
            {
                Response.Write("恭喜你，获得一等奖");
            }
            else if (Draw >= 6 && Draw <= 15)
            {
                Response.Write("恭喜你，获得二等奖");
            }
            else if (Draw >= 16 && Draw <= 30)
            {
                Response.Write("恭喜你，获得三等奖");
            }
            else if (Draw >= 30 && Draw < 90)
            {
                Response.Write($"恭喜你，获得纪念奖");
            }
            else
            {
                Response.Write("很遗憾，未中奖");
            }

        }
    }
}