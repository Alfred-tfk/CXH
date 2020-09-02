using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CXH.Model;
using System.Data.SqlClient;

namespace CXH.DAL
{
   public class CommentDAL
    {
       public bool Delete(int Id)
        {
            string sql = "";
            sql = string.Format("delete from Comment where Id='{0}'", Id);
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
            string sql = "select * from Comment ";
            if (where != "")
            {
                sql += " where " + where;
            }
            return SqlHelper.Query(sql);
        }
        public bool Add(Comment Comment)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append("insert into Comment(");
            strsql.Append("WorkID,WorkName,UserName,CommentContent,CommentTime)");
            strsql.Append("values(");
            strsql.Append("@Id,@WorkID,@WorkName,@UserName,@CommentContent,@CommentTime)");
            SqlParameter[] parameters ={                                       
                                        new SqlParameter("@WorkID",SqlDbType.Int),
                                        new SqlParameter("@WorkName",SqlDbType.NVarChar),
                                        new SqlParameter("@UserName",SqlDbType.NVarChar),
                                        new SqlParameter("@CommentContent",SqlDbType.NVarChar),
                                        new SqlParameter("@CommentTime",SqlDbType.DateTime)
                                    };
            parameters[0].Value = Comment.WorkID;
            parameters[1].Value = Comment.WorkName;
            parameters[2].Value = Comment.UserName;
            parameters[3].Value = Comment.CommentContent;
            parameters[4].Value = Comment.CommentTime;;
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
        public bool Update(Comment Comment)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append("update Comment set ");
            strsql.Append("WorkID=@WorkID,WorkName=@WorkName,UserName=@UserName,CommentContent=@CommentContent,CommentTime=@CommentTime ");
            strsql.Append(" where Id=@Id");
            SqlParameter[] parameters ={
                                        new SqlParameter("@WorkID",SqlDbType.Int),
                                        new SqlParameter("@WorkName",SqlDbType.NVarChar),
                                        new SqlParameter("@UserName",SqlDbType.NVarChar),
                                        new SqlParameter("@CommentContent",SqlDbType.NVarChar),
                                        new SqlParameter("@CommentTime",SqlDbType.DateTime),
                                        new SqlParameter("@Id",SqlDbType.Int)
                                    };
            parameters[0].Value = Comment.WorkID;
            parameters[1].Value = Comment.WorkName;
            parameters[2].Value = Comment.UserName;
            parameters[3].Value = Comment.CommentContent;
            parameters[4].Value = Comment.CommentTime;
            parameters[5].Value = Comment.Id;
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
