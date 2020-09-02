using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CXH.BLL;

namespace CXH.Web
{
    public partial class UserDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            try
            {
                string username = Request["username"];
                UserInfoBLL bll = new UserInfoBLL();
                bll.Delete(username);
                Response.Redirect("userlist.aspx");
            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('删除失败!');window.location.href='userlist.aspx';</script>");
            }
        }
    }
}