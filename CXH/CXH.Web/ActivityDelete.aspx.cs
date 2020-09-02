using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CXH.BLL;

namespace CXH.Web
{
    public partial class ActivityDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            try
            {
                string Id = Request["Id"];
                ActivityBLL bll = new ActivityBLL();
                bll.Delete(int.Parse(Id));
                Response.Redirect("ActivityList.aspx");
            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('删除失败!');window.location.href='ActivityList.aspx';</script>");
            }
        }
    }
}