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
    public partial class PROCEDURE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Result = GetSqlData();
                this.tablist.InnerHtml = Result;
            }
        }
        private string GetSqlData()
        {
            //从存储过程GetStudentList中获取数据，参数@searchValue为@Name
            string searchValue = this.textbox1.Text.Trim();
            StringBuilder ResultList = new StringBuilder();
            ResultList.Append("<table>");
            ResultList.Append("<tr><th>序号</th><th>姓名</th><th>性别</th><th>年龄</th><th>班级</th></tr>");
            using (SqlConnection conn = new SqlConnection("Server=47.109.111.226;DataBase=StudyC;User=sa;PassWord=sa8885999"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;//存储过程类型
                cmd.CommandText = "GetStudentList";//存储过程名称
                SqlParameter param = new SqlParameter("searchValue", SqlDbType.VarChar, 256);
                param.Value = searchValue;
                cmd.Parameters.Add(param);//添加参数
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int ID = Convert.ToInt32(reader["ID"]);
                        string Name = (string)reader["Name"];
                        string Sex = (string)reader["Sex"];
                        int Age = (int)reader["Age"];
                        string Class = (string)reader["Class"];
                        //将数据添加到表格中
                        ResultList.Append("<tr><td>" + ID + "</td>");
                        ResultList.Append("<td>" + Name + "</td>");
                        ResultList.Append("<td>" + Sex + "</td>");
                        ResultList.Append("<td>" + Age + "</td>");
                        ResultList.Append("<td>" + Class + "</td></tr>");
                    }

                }
                cmd.Dispose();

            }

            ResultList.Append("</table>");
            return ResultList.ToString();
        }

        protected void buttun1_Click(object sender, EventArgs e)
        {
            string Result = GetSqlData();
            this.tablist.InnerHtml = Result;
        }
    }
}