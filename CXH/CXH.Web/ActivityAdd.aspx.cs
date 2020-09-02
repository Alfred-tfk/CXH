using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CXH.Model;
using CXH.BLL;


namespace CXH.Web
{
    public partial class ActivityAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string filename = Guid.NewGuid().ToString() + ".jpg";
            if (FileUpload1.HasFile)
            {
                string filpath = Server.MapPath("~") + "ActivityImags\\" + filename;
                FileUpload1.PostedFile.SaveAs(filpath);

            }
            ActivityBLL activitybll = new ActivityBLL();
            Activity model = new Activity();
            model.ActivityName = txtname.Value;
            model.ActivityPicture = filename;
            model.UserName = txtuser.Value;
            model.Summary = txtsummary.Value;
            string activityIntroduction = Request["ActivityIntroduction"];
            model.ActivityIntroduction = activityIntroduction;
            //model.ActivityStatus = "未结束";
            //model.ActivityVerify = "审核通过";
            try
            {
                model.EndTime = DateTime.Parse(txtEndTime.Value);
            }
            catch (Exception ex)
            {

            }
            activitybll.Add(model);
            Response.Write("<script>alert('添加成功！');window.location='ActivityList.aspx';</script>");
        }
    }
}