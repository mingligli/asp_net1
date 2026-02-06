using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DateBind
{
    public partial class databind : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Page.DataBind();
            }
        }

        public string Name
        {
            get { return "张三"; }
        }
        public string Age
        {
            get { return "18"; }
        }
        public string Sex
        {
            get { return "女"; }
        }
        public string Idtype
        {
            get { return "证件类型"; }
        }
        public string IdNo
        {
            get { return "512928197701011066"; }
        }

    }
}