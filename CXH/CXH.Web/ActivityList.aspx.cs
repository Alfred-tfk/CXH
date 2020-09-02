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
    public partial class ActivityList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            ActivityBLL Activitybll = new ActivityBLL();
            //获取活动列表给bll层要
            DataSet dsUsers = Activitybll.GetList("ActivityName like '%" + textbox1.Value + "%'");
            ListView1.DataSource = dsUsers.Tables[0];
            ListView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}