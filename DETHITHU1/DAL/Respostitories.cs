using DETHITHU1.Context;
using DETHITHU1.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DETHITHU1.DAL
{
    internal class Respostitories
    {
        DBContext dbContext = new DBContext();

        public List<XeMay> GetAll(int? status)
        {
            if(status == null)
            {
              return  dbContext.XeMays.ToList();
            }
          return dbContext.XeMays.Where(x => x.TrangThai == status).ToList();
        }
        public bool AddXeMay(XeMay xemay)
        {
            if(xemay == null)
            {
                return false;
            }
            dbContext.XeMays.Add(xemay);
            dbContext.SaveChanges();
            return true;
        }
         public bool DeleteXeMay(Guid? id)
        {
            var XemayDelete = dbContext.XeMays.FirstOrDefault(x => x.Id == id);
            if(XemayDelete == null)
            {
                return false;
            }
            dbContext.XeMays.Remove(XemayDelete);
            dbContext.SaveChanges();
            return true;
        }

    }
}
