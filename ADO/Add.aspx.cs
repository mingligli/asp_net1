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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string data = GetSqlData();
                Response.Write(data);
            }
         
        }
        private string GetSqlData()
        {
            StringBuilder ResultList = new StringBuilder();
            ResultList.Append("<table>");

            // 先添加样式标签，统一定义table、th、td样式
            //ResultList.Append("<style>");
            //ResultList.Append("table { border-collapse: collapse; width: 70%; margin: 20px auto; }");
            //ResultList.Append("th, td { border: 1px solid #333; padding: 8px; text-align: center; }");
            //ResultList.Append("th { background-color: #f5f5f5; }"); // 表头背景色
            //ResultList.Append("</style>");

            //定义表头
            ResultList.Append("<tr><th>序号</th><th>姓名</th><th>性别</th><th>年龄</th><th>班级</th></tr>");
            //读数据到表
            using (SqlConnection conn = new SqlConnection("Server=47.109.111.226;DataBase=StudyC;User=sa;PassWord=sa8885999"))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                comm.CommandText = "Select * from Student ORDER BY ID ASC";//升序
                comm.Connection = conn;
                using (SqlDataReader dataReader = comm.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        int ID = (int)dataReader["ID"];
                        string Name = (string)dataReader["Name"];
                        string Sex = (string)dataReader["Sex"];
                        int Age = (int)dataReader["Age"];
                        string Class = (string)dataReader["Class"];
                        //以上变量放入表格中
                        ResultList.Append("<tr><td>" + ID + "</td>");
                        ResultList.Append("<td>" + Name + "</td>");
                        ResultList.Append("<td>" + Sex + "</td>");
                        ResultList.Append("<td>" + Age + "</td>");
                        ResultList.Append("<td>" + Class + "</td></tr>");
                    }
                }
                comm.Dispose();
            }
            ResultList.Append("</table>");
            return ResultList.ToString();
        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            string Name = this.txt_Name.Text;
            string Sex = this.drop_Sex.SelectedValue;
            string Age = this.txt_Age.Text;
            string Class = this.txt_Class.Text;
            if (Name==string.Empty)
            {
                Response.Redirect("Add.aspx");
                return;
            }
            using (SqlConnection conn=new SqlConnection("Server=47.109.111.226;DataBase=StudyC;User=sa;PassWord=sa8885999"))
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandType = CommandType.Text;
                comm.CommandText = "INSERT INTO Student([Name],[Sex],[Age],[Class]) VALUES ('"+Name+ "','"+ Sex + "','"+ Age + "','"+ Class + "')";
                comm.Connection = conn;
                int addRows = comm.ExecuteNonQuery();
                if (addRows > 0)
                {
                    Response.Redirect("Add.aspx");
                }
            }

        }
    }
}