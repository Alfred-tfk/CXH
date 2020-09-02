using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CXH.DAL;
using System.Data;
using CXH.Model;
namespace CXH.BLL
{
 public   class UserInfoBLL
    {
     UserInfoDAL dal = new UserInfoDAL();
     public bool Login(string userName,string pwd)
     {
         string where = string.Format("username='{0}' and password='{1}'",userName,pwd);
         DataSet dsUser = dal.GetList(where);
         if (dsUser.Tables[0].Rows.Count ==0)
         {
             return false;
         }
         else
         {
             return true;
         }
     }
     public DataSet GetList(string where)
     {
         return dal.GetList(where);
     }
     public bool Add(UserInfo userinfo)
     {
         return dal.Add(userinfo);
     }
     public bool Delete(string userName)
     { 
     return  dal. Delete( userName);
     }
     public bool Update(UserInfo userinfo)
     {
         return dal.Update(userinfo);
     }
    }
}
