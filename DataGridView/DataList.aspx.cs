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
        public static PagedDataSource ps = new PagedDataSource();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind(0);
            }
        }
        private void Bind(int currentPage)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=47.109.111.226;DataBase=StudyC;User=sa;PassWord=sa8885999";
            string sql = "select * from Student";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            System.Data.DataSet ds = new System.Data.DataSet();
            da.Fill(ds);

            ps.DataSource = ds.Tables[0].DefaultView;
            ps.AllowPaging = true;
            ps.PageSize = 2;
            ps.CurrentPageIndex = currentPage;

            DataList1.DataSource = ps;
            DataList1.DataKeyField = "ID";
            DataList1.DataBind();
        }

        protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Footer)
            {
                //得到页脚模板中的控件，并赋值给变量
                Label CurrentPage = e.Item.FindControl("labNowPage") as Label;
                Label PageCount = e.Item.FindControl("labCount") as Label;
                LinkButton FirstPage = e.Item.FindControl("lnkbtnFirst") as LinkButton;
                LinkButton PrePage = e.Item.FindControl("lnkbtnFront") as LinkButton;
                LinkButton NextPage = e.Item.FindControl("lnkbtnNext") as LinkButton;
                LinkButton LastPage = e.Item.FindControl("lnkbtnLast") as LinkButton;
                //在绑定PagedDataSource时，页面设置为从0开始，所以在显示时要进行加1
                CurrentPage.Text = (ps.CurrentPageIndex + 1).ToString();
                PageCount.Text = ps.PageCount.ToString();//绑定显示总页数
                if (ps.IsFirstPage)//如果是第1页，设置“首页”和“上一页”按钮不可用
                {
                    FirstPage.Enabled = false;
                    PrePage.Enabled = false;
                }
                if (ps.IsLastPage)//如果是最后一页，设置“下一页”和“尾页”按钮不可用
                {
                    NextPage.Enabled = false;
                    LastPage.Enabled = false;
                }

            }
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "fist":
                    ps.CurrentPageIndex = 0;
                    Bind(ps.CurrentPageIndex);
                    break;
                case "pre":
                    ps.CurrentPageIndex -= 1;
                    Bind(ps.CurrentPageIndex);
                    break;
                case "next":
                    ps.CurrentPageIndex += 1;
                    Bind(ps.CurrentPageIndex);
                    break;
                case "last":
                    ps.CurrentPageIndex = ps.PageCount - 1;
                    Bind(ps.CurrentPageIndex);
                    break;
                case "search":
                    if (e.Item.ItemType == ListItemType.Footer)
                    {
                        int pagecount = int.Parse(ps.PageCount.ToString());
                        TextBox txtpage = e.Item.FindControl("TxtPage") as TextBox;
                        int mypageNum = 0;                        
                        if (!txtpage.Text.Equals(""))
                        {
                            mypageNum =int.Parse( txtpage.Text.ToString());
                        }
                        if (mypageNum<=0 ||mypageNum>pagecount)
                        {                            
                            Response.Write("<script>alert('请输入页数并确定没有超出总页数！')</script>");
                            Bind(0);
                        }
                        else
                        {
                            Bind(mypageNum - 1);
                        }
                    }
                    break;
                case "select":
                    //设置选中行的索引为当前选择行的索引
                    DataList1.SelectedIndex = e.Item.ItemIndex;
                    //数据绑定                   
                    Bind(ps.CurrentPageIndex);
                    break;
                case "back":
                    //设置选中行的索引为-1，取消该数据项的选择
                    DataList1.SelectedIndex = -1;
                    //数据绑定
                    Bind(ps.CurrentPageIndex);
                    break;
            }
        }

    }
}