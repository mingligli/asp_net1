using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace asp_net1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["PC"] = 0;
            Application["Android"] = 0;
            Application["Iphone"] = 0;
            Application["WinPhone"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            var Names = new
            {
                Android = "Android",
                Iphone = "Iphone",
                Winphone = "Winphone",
            };
            string userAgent = Request.UserAgent.ToLower();
            if (userAgent.Contains(Names.Android.ToLower()))
            {
                Application["Android"] = (int)Application["Android"] + 1;
            }
            else if (userAgent.Contains(Names.Iphone.ToLower()))
            {
                Application["Iphone"] = (int)Application["Iphone"] + 1;
            }
            else if (userAgent.Contains(Names.Winphone.ToLower()))
            {
                Application["WinPhone"] = (int)Application["WinPhone"] + 1;
            }
            else
            {
                Application["PC"] = (int)Application["PC"] + 1;
            }
                Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}