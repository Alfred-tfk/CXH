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
    public partial class WorkInfodatail : System.Web.UI.Page
    {
        WorkInfoBLL bll = new WorkInfoBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            int id = int.Parse(Request["id"]);
            DataSet ds = bll.GetList("id=" + id);
            l1.InnerText = ds.Tables[0].Rows[0]["Id"].ToString();
            l2.InnerText = ds.Tables[0].Rows[0]["WorkName"].ToString();
            l3.InnerText = ds.Tables[0].Rows[0]["WorkPicture"].ToString();
            l4.InnerText = ds.Tables[0].Rows[0]["UploadTime"].ToString();
            l5.InnerText = ds.Tables[0].Rows[0]["WorkIntroduction"].ToString();
            l6.InnerText = ds.Tables[0].Rows[0]["WorkVerify"].ToString();
            l7.InnerText = ds.Tables[0].Rows[0]["UserName"].ToString();
            l8.InnerText = ds.Tables[0].Rows[0]["ActivityName"].ToString();
            l9.InnerText = ds.Tables[0].Rows[0]["Recommend"].ToString();
            l10.InnerText = ds.Tables[0].Rows[0]["RecommendTime"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WorkInfoList.aspx");
        }
    }
}