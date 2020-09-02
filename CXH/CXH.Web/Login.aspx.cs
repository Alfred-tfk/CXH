using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CXH.BLL;

namespace CXH.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserInfoBLL userbll = new UserInfoBLL();
            bool result = userbll.Login(TxtUserName.Value, TxtPwd.Value);
            if (result)
            {
                Session["user"] = TxtUserName.Value;
                Response.Write("登录成功!");
                Response.Redirect("index.aspx");
            }
            else
            {
                Response.Write("登录失败!");
            }
        }
    }
}