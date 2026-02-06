using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_net1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "mr" && txtPWD.Text == "mrsoft")
            {
                Session["UserName"] = txtUserName.Text;
                Session["LoginTime"] = DateTime.Now;
                Response.Redirect("WebForm1.aspx");
            }
            else
            {
                Response.Write("<script>alert('登录失败，请查找原因后再试');</script>");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton1.ForeColor= System.Drawing.Color.Yellow;
            Response.Redirect("http://lml0126.ysepan.com/");
        }
    }
}