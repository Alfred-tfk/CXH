using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CXH.Model;
using CXH.DAL;

namespace CXH.BLL
{
  public  class CommentBLL
    {
      CommentDAL dal = new CommentDAL();
      public DataSet GetList(string where)
      {
          return dal.GetList(where);
      }
      public bool Delete(int Id)
      {
          return dal.Delete(Id);
      }
      public bool Add(Comment Comment)
      {
          return dal.Add(Comment);
      }
      public bool Update(Comment Id)
      {
          return dal.Update(Id);
      }
    }
}
