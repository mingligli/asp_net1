using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADO
{
    public partial class Edit1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["ID"];
                this.EditID.Value= id;
                GetDataItem(id);
            }
        }
        /// <summary>
        /// 根据ID获取数据
        /// </summary>
        /// <param name="id"></param>
        private void GetDataItem(string id)
        {
            using (SqlConnection conn = new SqlConnection("Server=47.109.111.226;DataBase=StudyC;User=sa;PassWord=sa8885999"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType=System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM Student WHERE ID="+id;
                using (SqlDataReader reader = cmd.ExecuteReader())
                { 
                    reader.Read();
                    this.txt_Name.Text = reader["Name"].ToString();
                    this.txt_Class.Text = reader["Class"].ToString();
                    this.txt_Age.Text = reader["Age"].ToString();
                    string Sex= reader["Sex"].ToString();
                    foreach (ListItem item in this.drop_Sex.Items)
                    {
                        if (item.Value==Sex)
                        {
                            item.Selected = true;
                            break;
                        }
                    }
                }
                cmd.Dispose();
            }
            
        }
        /// <summary>
        /// 修改按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Edit_Click(object sender, EventArgs e)
        {
            string id = this.EditID.Value;
            string name = this.txt_Name.Text;
            string className = this.txt_Class.Text;
            string age = this.txt_Age.Text;
            string sex= this.drop_Sex.SelectedValue;
            using (SqlConnection conn = new SqlConnection("Server=47.109.111.226;DataBase=StudyC;User=sa;PassWord=sa8885999"))
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE Student SET Name='"+name+"',Sex='"+sex+"',Age="+age+",Class='" + className+"'where ID="+id;
                int editrows = command.ExecuteNonQuery();
                if (editrows > 0)
                {
                    Response.Redirect("Select.aspx");
                }
            }
        }
    }
}