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
    public partial class Edit : System.Web.UI.Page
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

            //定义表头
            ResultList.Append("<tr><th>序号</th><th>姓名</th><th>性别</th><th>年龄</th><th>班级</th><th>操作</th><th>操作</th></tr>");
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
                        ResultList.Append("<td>" + Class + "</td>");
                        ResultList.Append("<td> <a href=\"Edit.aspx?ID="+ID+"\">编辑</td>");
                        ResultList.Append("<td> <a href=\"Delete.aspx?ID=" + ID + "\">删除</td></tr>");
                    }
                }
                comm.Dispose();
            }
            ResultList.Append("</table>");
            return ResultList.ToString();
        }
       private void DeleteStudent(string ID)
        {
            Response.Write("删除开始");
        }
    }
}