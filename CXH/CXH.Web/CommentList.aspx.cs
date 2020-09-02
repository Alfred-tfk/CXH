using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CXH.BLL;


namespace CXH.Web
{
    public partial class CommentList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            CommentBLL bll = new CommentBLL();
            //获取活动列表给bll层
            DataSet dsUsers = bll.GetList("WorkName like '%" + TextBox1.Value + "%'");
            ListView1.DataSource = dsUsers.Tables[0];
            ListView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}