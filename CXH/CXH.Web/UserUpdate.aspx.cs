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
    public partial class UserUpdate : System.Web.UI.Page
    {
            UserInfoBLL userbll = new UserInfoBLL();
            UserInfo model = new UserInfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string username = Request["username"];
            if (!IsPostBack)
            {
                DataSet ds = userbll.GetList("username='" + username + "'");
                textname.Value = ds.Tables[0].Rows[0]["UserName"].ToString();
                qq.Value = ds.Tables[0].Rows[0]["QQ"].ToString();
                email.Value = ds.Tables[0].Rows[0]["Email"].ToString();
                DropDownList1.Text = ds.Tables[0].Rows[0]["Type"].ToString();
                password.Value = ds.Tables[0].Rows[0]["Password"].ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                UserInfoBLL userinfobll = new UserInfoBLL();
                UserInfo model = new UserInfo();
                model.UserName = textname.Value;
                model.Password = password.Value;
                model.QQ = qq.Value;
                model.Email = email.Value;
                model.Type = DropDownList1.Text;
                userinfobll.Update(model);
                Response.Write("<script>alert('修改成功！');</script>");
                Response.Redirect("userlist.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('修改失败！');</script>");
            }
        }
    }
}