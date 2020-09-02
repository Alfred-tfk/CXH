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
    public partial class UserAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");
            }
            try
            {
                UserInfoBLL userinfobll = new UserInfoBLL();
                UserInfo model = new UserInfo();
                model.UserName = username.Value;
                model.Password = password.Value;
                model.QQ = qq.Value;
                model.Email = email.Value;
                model.Type = DropDownList1.Text;
                userinfobll.Add(model);
                jg.InnerText = "添加成功";
                Response.Redirect("userlist.aspx");
            }
            catch (Exception ex)
            {

                jg.InnerText = "添加失败" + ex.Message;
            }
        }
    }
}