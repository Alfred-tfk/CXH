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
    public partial class UserList : System.Web.UI.Page
    {
        UserInfoBLL userbll = new UserInfoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            DataSet dsuser = userbll.GetList("UserName like '%" + textbox1.Value + "%'");
            ListView1.DataSource = dsuser.Tables[0];
            ListView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}