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
    public partial class WorkInfoadd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            if (!IsPostBack)
            {
                DropDownList1.Items.Clear();
                DropDownList1.Items.Add("--请选择所属活动--");
                BLL.ActivityBLL bll = new ActivityBLL();
                DataSet ds = bll.GetList("");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DropDownList1.Items.Add(ds.Tables[0].Rows[i]["activityname"].ToString());
                }
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string filename = Guid.NewGuid().ToString() + ".jpg";
            if (FileUpload1.HasFile)
            {
                string filpath = Server.MapPath("~") + "WorkInfoimgs\\" + filename;
                FileUpload1.PostedFile.SaveAs(filpath);

            }
            WorkInfoBLL workInfobll = new WorkInfoBLL();
            WorkInfo model = new WorkInfo();
            model.WorkName = txtname.Value;
            model.WorkPicture = filename;
            model.UserName = txtuser.Value;;
            string WorkIntroduction = Request["WorkIntroduction"];
            model.WorkIntroduction = WorkIntroduction;
            model.ActivityName = DropDownList1.Text;
            model.UploadTime = DateTime.Now;
            model.RecommendTime=DateTime.Now;
            model.Recommend = "是";
            model.WorkVerify = "审核通过";
            workInfobll.Add(model);
            Response.Write("<script>alert('添加成功！');window.location='WorkInfoList.aspx';</script>");
        
        }
    }
}