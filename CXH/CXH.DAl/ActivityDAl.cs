using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CXH.Model;

namespace CXH.DAL
{
   public class ActivityDAl
    {
       public DataSet GetList(string where)
       {
           string sql = "select * from Activity ";
           if (where != "")
           {
               sql += " where " + where;
           }
           return SqlHelper.Query(sql);
       }
       public bool Delete(int Id)
       {
           string sql = "";
           sql = string.Format("delete from Activity where Id='{0}'", Id);
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
       public bool Add(Activity Activity)
       {
           StringBuilder strsql = new StringBuilder();
           strsql.Append("insert into Activity(");
           strsql.Append("ActivityName,EndTime,ActivityPicture,ActivityIntroduction,Summary,ActivityVerify,ActivityStatus,UserName)");
           strsql.Append("values(");
           strsql.Append("@ActivityName,@EndTime,@ActivityPicture,@ActivityIntroduction,@Summary,@ActivityVerify,@ActivityStatus,@UserName)");
           SqlParameter[] parameters ={
                                        new SqlParameter("@ActivityName",SqlDbType.NVarChar),
                                        new SqlParameter("@EndTime",SqlDbType.DateTime),
                                        new SqlParameter("@ActivityPicture",SqlDbType.NVarChar),
                                        new SqlParameter("@ActivityIntroduction",SqlDbType.NVarChar),
                                        new SqlParameter("@Summary",SqlDbType.NVarChar),
                                        new SqlParameter("@ActivityVerify",SqlDbType.NChar),
                                        new SqlParameter("@ActivityStatus",SqlDbType.NChar),
                                        new SqlParameter("@UserName",SqlDbType.NVarChar)
                                    };
           parameters[0].Value = Activity.ActivityName;
           parameters[1].Value = Activity.EndTime;
           parameters[2].Value = Activity.ActivityPicture;
           parameters[3].Value = Activity.ActivityIntroduction;
           parameters[4].Value = Activity.Summary;
           parameters[5].Value = Activity.ActivityVerify;
           parameters[6].Value = Activity.ActivityStatus;
           parameters[7].Value = Activity.UserName;    
           int n = SqlHelper.ExcuteSql(strsql.ToString(),parameters);
           if (n > 0)
           {
               return true;
           }
           else
           {
               return false;
           }
       }
       public bool Update(Activity Activity)
       {
           StringBuilder strsql = new StringBuilder();
           strsql.Append("update Activity set ");
           strsql.Append("ActivityName=@ActivityName,EndTime=@EndTime,ActivityPicture=@ActivityPicture,ActivityIntroduction=@ActivityIntroduction,Summary=@Summary,ActivityVerify=@ActivityVerify,ActivityStatus=@ActivityStatus,UserName=@UserName ");
           strsql.Append(" where Id=@Id");
           SqlParameter[] parameters ={
                                        new SqlParameter("@ActivityName",SqlDbType.NVarChar),
                                        new SqlParameter("@EndTime",SqlDbType.DateTime),
                                        new SqlParameter("@ActivityPicture",SqlDbType.NVarChar),
                                        new SqlParameter("@ActivityIntroduction",SqlDbType.NVarChar),
                                        new SqlParameter("@Summary",SqlDbType.NVarChar),
                                        new SqlParameter("@ActivityVerify",SqlDbType.NChar),
                                        new SqlParameter("@ActivityStatus",SqlDbType.NChar),
                                        new SqlParameter("@UserName",SqlDbType.NVarChar),
                                        new SqlParameter("@Id",SqlDbType.Int)
                                    };
           parameters[0].Value = Activity.ActivityName;
           parameters[1].Value = Activity.EndTime;
           parameters[2].Value = Activity.ActivityPicture;
           parameters[3].Value = Activity.ActivityIntroduction;
           parameters[4].Value = Activity.Summary;
           parameters[5].Value = Activity.ActivityVerify;
           parameters[6].Value = Activity.ActivityStatus;
           parameters[7].Value = Activity.UserName;
           parameters[8].Value = Activity.Id;    
           int n = SqlHelper.ExcuteSql(strsql.ToString(),parameters);
           if (n > 0)
           {
               return true;
           }
           else
           {
               return false;
           }
       }
       
    }
}
