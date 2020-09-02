using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CXH.BLL;
namespace CXH.Web
{
    public partial class WorkInfoDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            try
            {
                string id = Request["id"];
                WorkInfoBLL bll = new WorkInfoBLL();
                bll.Delete(int.Parse(id));
                Response.Redirect("WorkInfolist.aspx");
            }
            catch (Exception ex)
            {

                Response.Write("<script>alert('删除失败!');window.location.href='WorkInfolist.aspx';</script>");
            }
        }
    }
}