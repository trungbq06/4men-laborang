using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalLabo.DataAccess;
using DentalLabo.Data;
using System.Data;

namespace DentalLabo.Bussiness
{
    class BussinessDanhMucNV
    {
        public void AddDanhMuc(DanhMucNV danhmuc)
        {
            DADanhMucNV daDanhMuc = new DADanhMucNV();
            daDanhMuc.AddDanhMuc(danhmuc);
        }

        public DataTable FindNV(string maBP)
        {
            DADanhMucNV daDanhMuc = new DADanhMucNV();
            return daDanhMuc.FindNV(maBP);
        }

        public void UpdateDanhMuc(DanhMucNV danhmuc, string id, string idUpdate)
        {
            DADanhMucNV daDanhMuc = new DADanhMucNV();
            daDanhMuc.UpdateDanhMuc(danhmuc, id, idUpdate);
        }
    }
}
