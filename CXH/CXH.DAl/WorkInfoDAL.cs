using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CXH.Model;
using System.Data;
using System.Data.SqlClient;

namespace CXH.DAL
{
   public class WorkInfoDAL
    {
        public DataSet GetList(string where)
        {
            string sql = "select * from WorkInfo ";
            if (where != "")
            {
                sql += " where " + where;
            }
            return SqlHelper.Query(sql);
        }
        public bool Delete(int Id)
        {
            string sql = "";
            sql = string.Format("delete from WorkInfo where Id='{0}'", Id);
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
        public bool Add(WorkInfo WorkInfo)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append("insert into WorkInfo(");
            strsql.Append("WorkName,WorkPicture,UploadTime,WorkIntroduction,WorkVerify,UserName,ActivityName,Recommend,RecommendTime)");
            strsql.Append("values(");
            strsql.Append("@WorkName,@WorkPicture,@UploadTime,@WorkIntroduction,@WorkVerify,@UserName,@ActivityName,@Recommend,@RecommendTime)");
            SqlParameter[] parameters ={
                                        new SqlParameter("@WorkName",SqlDbType.NVarChar),
                                        new SqlParameter("@WorkPicture",SqlDbType.NVarChar),
                                        new SqlParameter("@UploadTime",SqlDbType.DateTime),
                                        new SqlParameter("@WorkIntroduction",SqlDbType.NVarChar),
                                        new SqlParameter("@WorkVerify",SqlDbType.NVarChar),
                                        new SqlParameter("@UserName",SqlDbType.NChar),
                                        new SqlParameter("@ActivityName",SqlDbType.NChar),
                                        new SqlParameter("@Recommend",SqlDbType.NVarChar),
                                        new SqlParameter("@RecommendTime",SqlDbType.DateTime)
                                    };
            parameters[0].Value = WorkInfo.WorkName;
            parameters[1].Value = WorkInfo.WorkPicture;
            parameters[2].Value = WorkInfo.UploadTime;
            parameters[3].Value = WorkInfo.WorkIntroduction;
            parameters[4].Value = WorkInfo.WorkVerify;
            parameters[5].Value = WorkInfo.UserName;
            parameters[6].Value = WorkInfo.ActivityName;
            parameters[7].Value = WorkInfo.Recommend;
            parameters[8].Value = WorkInfo.RecommendTime;
            int n = SqlHelper.ExcuteSql(strsql.ToString(), parameters);
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Update(WorkInfo WorkInfo)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append("update WorkInfo set ");
            strsql.Append("WorkName=@WorkName,WorkPicture=@WorkPicture,UploadTime=@UploadTime,WorkIntroduction=@WorkIntroduction,WorkVerify=@WorkVerify,UserName=@UserName,ActivityName=@ActivityName,Recommend=@Recommend,RecommendTime=@RecommendTime ");
            strsql.Append(" where Id=@Id");
            SqlParameter[] parameters ={
                                        new SqlParameter("@WorkName",SqlDbType.NVarChar),
                                        new SqlParameter("@WorkPicture",SqlDbType.NVarChar),
                                        new SqlParameter("@UploadTime",SqlDbType.DateTime),
                                        new SqlParameter("@WorkIntroduction",SqlDbType.NVarChar),
                                        new SqlParameter("@WorkVerify",SqlDbType.NVarChar),
                                        new SqlParameter("@UserName",SqlDbType.NChar),
                                        new SqlParameter("@ActivityName",SqlDbType.NChar),
                                        new SqlParameter("@Recommend",SqlDbType.NVarChar),
                                        new SqlParameter("@RecommendTime",SqlDbType.DateTime),
                                        new SqlParameter("@Id",SqlDbType.Int)
                                    };
            parameters[0].Value = WorkInfo.WorkName;
            parameters[1].Value = WorkInfo.WorkPicture;
            parameters[2].Value = WorkInfo.UploadTime;
            parameters[3].Value = WorkInfo.WorkIntroduction;
            parameters[4].Value = WorkInfo.WorkVerify;
            parameters[5].Value = WorkInfo.UserName;
            parameters[6].Value = WorkInfo.ActivityName;
            parameters[7].Value = WorkInfo.Recommend;
            parameters[8].Value = WorkInfo.RecommendTime;
            parameters[9].Value = WorkInfo.Id;
            int n = SqlHelper.ExcuteSql(strsql.ToString(), parameters);
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
