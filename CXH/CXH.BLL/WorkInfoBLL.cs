using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CXH.Model;
using CXH.DAL;
using System.Data;

namespace CXH.BLL
{
   public class WorkInfoBLL
    {
       WorkInfoDAL dal = new WorkInfoDAL();

        public DataSet GetList(string where)
        {
            return dal.GetList(where);
        }
        public bool Add(WorkInfo WorkInfo)
        {
            return dal.Add(WorkInfo);
        }
        public bool Delete(int Id)
        {
            return dal.Delete(Id);
        }
        public bool Update(WorkInfo workinfo)
        {
            return dal.Update(workinfo);
        }
    }
}
