using DETHITHU1.DAL;
using DETHITHU1.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DETHITHU1.BUS
{
    internal class Service
    {
        Respostitories _res  = new Respostitories();

        public List<XeMay> GetAllService(int? status) // int? là giá trị status được phép null
        {
            return _res.GetAll(status);
        }

        public void AddXeMayService(XeMay xemay)
        {
            if(_res.AddXeMay(xemay))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        public void DeleteXeMayService(Guid id)
        {
            if (_res.DeleteXeMay(id))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
