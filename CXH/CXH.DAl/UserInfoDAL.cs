using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CXH.Model;
using System.Data;
using CXH.Model;
namespace CXH.DAL
{
    public class UserInfoDAL
    {
        public bool Add(UserInfo userinfo)
        {
            string sql = "";
            sql = string.Format("insert into userinfo([UserName],[Password],[QQ],[Email],[Type],[UserImg]) " +
                "values('{0}','{1}','{2}','{3}','{4}','{5}')", userinfo.UserName, userinfo.Password,
                userinfo.QQ, userinfo.Email, userinfo.Type, userinfo.UserImg);
            int n = SqlHelper.ExcuteSql(sql);
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete(string userName)
        {
            string sql = "";
            sql = string.Format("delete from userinfo where username='{0}'",userName );
            int n = SqlHelper.ExcuteSql(sql);
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(UserInfo userinfo)
        {
            string sql = "";
            sql = string.Format("update userinfo set Password='{0}',QQ='{1}',Email='{2}',Type='{3}',UserImg='{4}' where UserName='{5}'" 
                , userinfo.Password,userinfo.QQ, userinfo.Email, userinfo.Type, userinfo.UserImg, userinfo.UserName);
            int n = SqlHelper.ExcuteSql(sql);
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataSet GetList(string where)
        {
            string sql = "select * from userinfo ";
            if (where !="")
            {
                sql += " where " + where;
            }
            return SqlHelper.Query(sql);
        }

    }
}
