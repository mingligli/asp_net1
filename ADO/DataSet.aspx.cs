using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADO
{
    public partial class DataSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Result = GetSqlData();
            Response.Write(Result);
        }
        private string GetSqlData()
        {
            StringBuilder Resultlist = new StringBuilder();
            Resultlist.Append("<table>");
            Resultlist.Append("<tr><th>序号</th><th>姓名</th><th>性别</th><th>年龄</th><th>班级</th></tr>");
            using (SqlConnection conn = new SqlConnection("Server=47.109.111.226;DataBase=StudyC;User=sa;PassWord=sa8885999"))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                comm.CommandText = "SELECT * FROM Student";
                comm.Connection = conn;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comm;
                System.Data.DataSet ds = new System.Data.DataSet();
                adapter.Fill(ds);
                adapter.Dispose();
                comm.Dispose();

                DataTable dt = ds.Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int ID = (int)dt.Rows[i]["ID"];
                    string Name = (string )dt.Rows[i]["Name"];
                    string Sex = (string)dt.Rows[i]["Sex"];
                    int Age = (int)dt.Rows[i]["Age"];
                    string Class = (string)dt.Rows[i]["Class"];

                    //写到表格中
                    Resultlist.Append("<tr><td>" + ID + "</td>");
                    Resultlist.Append("<td>" + Name + "</td>");
                    Resultlist.Append("<td>" + Sex + "</td>");
                    Resultlist.Append("<td>" + Age + "</td>");
                    Resultlist.Append("<td>" + Class + "</td></tr>");
                }

            }
            Resultlist.Append("/<table>");
            return Resultlist.ToString();
        }
    }
}