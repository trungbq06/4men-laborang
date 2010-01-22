using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalLabo.DataAccess;
using DentalLabo.Data;
using System.Data;

namespace DentalLabo.Bussiness
{
    class BussinessKhachHang
    {
        public void AddKhachHang(KhachHang danhmuc)
        {
            DAKhachHang daDanhMuc = new DAKhachHang();
            daDanhMuc.AddKhachHang(danhmuc);
        }

        
        public DataTable FindNV(string maBP)
        {
            DAKhachHang daDanhMuc = new DAKhachHang();
            return daDanhMuc.FindNV(maBP);
        }

        public void UpdateDanhMuc(KhachHang danhmuc, string id, string idUpdate)
        {
            DAKhachHang daDanhMuc = new DAKhachHang();
            daDanhMuc.UpdateKhachHang(danhmuc, id, idUpdate);
        }
    }
}
