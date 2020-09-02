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
    public partial class WorkInfoUpdate : System.Web.UI.Page
    {
        public string xx = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            int Id = int.Parse(Request["id"]);
            WorkInfoBLL bll = new WorkInfoBLL();
            lblId.Text = Id.ToString();
            if (!IsPostBack)
            { //修改活动
                textActivityName.Items.Clear();
                textActivityName.Items.Add("--请选择所属活动--");
                BLL.ActivityBLL bll2 = new ActivityBLL();
                DataSet ds2 = bll2.GetList("");
                for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                {
                    textActivityName.Items.Add(ds2.Tables[0].Rows[i]["activityname"].ToString());
                }
                DataSet ds = bll.GetList("Id='" + Id + "'");
                textWorkName.Value = ds.Tables[0].Rows[0]["WorkName"].ToString();
                Image1.ImageUrl = "WorkInfoimgs/" + ds.Tables[0].Rows[0]["WorkPicture"].ToString();
                textUploadTime.Value = ds.Tables[0].Rows[0]["UploadTime"].ToString();
                xx = ds.Tables[0].Rows[0]["WorkIntroduction"].ToString();
                textWorkVerify.Value = ds.Tables[0].Rows[0]["WorkVerify"].ToString();
                textUserName.Value = ds.Tables[0].Rows[0]["UserName"].ToString();
                textRecommend.Value = ds.Tables[0].Rows[0]["Recommend"].ToString();
                if (textRecommend.Value == "是")
                {
                    textRecommendTime.Value = ds.Tables[0].Rows[0]["RecommendTime"].ToString();
                }
                else
                {
                    textRecommendTime.Value = null;
                }
                //给活动赋值
                textActivityName.Text = ds.Tables[0].Rows[0]["activityname"].ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Model.WorkInfo model = new WorkInfo();
            model.WorkName = textWorkName.Value;
            model.Id = int.Parse(lblId.Text);
            if (FileUpload1.HasFile)
            {
                string filename = Guid.NewGuid().ToString() + ".jpg";
                string filpath = Server.MapPath("~") + "WorkInfoimgs\\" + filename;
                FileUpload1.PostedFile.SaveAs(filpath);
                //txtimg.Text = filename;
            }
            model.UploadTime = DateTime.Parse(textUploadTime.Value);
            string WorkIntroduction = Request["WorkIntroduction"];
            model.WorkIntroduction = WorkIntroduction;
            model.WorkVerify = textWorkVerify.Value;
            model.UserName = textUserName.Value;
            model.ActivityName = textActivityName.Text;
            model.Recommend = textRecommend.Value;
            if (textRecommend.Value == "是")
            {
                model.RecommendTime = DateTime.Parse(textUploadTime.Value);
            }
            else
            {
                model.RecommendTime = null;
            }
            string activityIntroduction = Request["ActivityIntroduction"];

            WorkInfoBLL WorkInfobll = new WorkInfoBLL();
            WorkInfobll.Update(model);
            Response.Write("<script>alert('修改成功！');window.location='WorkInfoList.aspx';</script>");
        }
    }
}