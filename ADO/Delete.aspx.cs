using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADO
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ID = Request.QueryString["ID"];
            DeleteData(ID);
        }
        private void DeleteData(string id)
        {
            
            using (SqlConnection conn = new SqlConnection("Server=47.109.111.226;DataBase=StudyC;User=sa;PassWord=sa8885999"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType=System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM Student WHERE ID="+id;
                cmd.Connection=conn;
                int Delcount = cmd.ExecuteNonQuery();
                if (Delcount>0)
                {
                    Response.Redirect("Select.aspx");
                }
                cmd.Dispose();
            }
        }
    }
}