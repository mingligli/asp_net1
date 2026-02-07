using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataGridView
{
    public partial class DataList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Server=47.109.111.226;DataBase=StudyC;User=sa;PassWord=sa8885999";
                string sql = "select * from Student";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
        }
    }
}