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
   public class ActivityBLL
    {
       ActivityDAl dal = new ActivityDAl();
       
        public DataSet GetList(string where)
        {
            return dal.GetList(where);
        }
        public bool Add(Activity Activity)
        {
            return dal.Add(Activity);
        }
        public bool Delete(int Id)
        {
            return dal.Delete(Id);
        }
        public bool Update(Activity ActivityName)
        {
            return dal.Update(ActivityName);
        }
    }
}
