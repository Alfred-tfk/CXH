using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CXH.BLL;
using CXH.Model;

namespace CXH.Web
{
    public partial class ActivityUpdate : System.Web.UI.Page
    {
        public string xx = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            if (!IsPostBack)
            {
                int Id = int.Parse(Request["Id"]);
                ActivityBLL bll = new ActivityBLL();
                DataSet ds = bll.GetList("Id=" + Id);
                txtId.Value = ds.Tables[0].Rows[0]["Id"].ToString();
                txtname.Value = ds.Tables[0].Rows[0]["ActivityName"].ToString();
                txtuser.Value = ds.Tables[0].Rows[0]["UserName"].ToString();
                txtsummary.Value = ds.Tables[0].Rows[0]["Summary"].ToString();
                txtEndTime.Value = ds.Tables[0].Rows[0]["EndTime"].ToString();
                Image1.ImageUrl = "images/" + ds.Tables[0].Rows[0]["ActivityPicture"].ToString();
                xx = ds.Tables[0].Rows[0]["ActivityIntroduction"].ToString();
                txtimg.Text = ds.Tables[0].Rows[0]["ActivityPicture"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Model.Activity model = new Activity();
            model.Id = int.Parse(txtId.Value);
            model.ActivityName = txtname.Value;
            model.UserName = txtuser.Value;
            model.EndTime = DateTime.Parse(txtEndTime.Value);

            if (FileUpload1.HasFile)
            {
                string filename = Guid.NewGuid().ToString() + ".jpg";
                string filpath = Server.MapPath("~") + "ActivityImags\\" + filename;
                FileUpload1.PostedFile.SaveAs(filpath);
                txtimg.Text = filename;
            }
            model.Summary = txtsummary.Value;
            string activityIntroduction = Request["ActivityIntroduction"];
            model.ActivityIntroduction = activityIntroduction;
            ActivityBLL activitybll = new ActivityBLL();
            activitybll.Update(model);
            Response.Write("<script>alert('修改成功！');window.location='ActivityList.aspx';</script>");
        }
    }
}