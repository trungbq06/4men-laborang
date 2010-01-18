using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using DentalLabo.Data;
using DentalLabo.DataAccess;

namespace DentalLabo.Bussiness
{
    class BusinessDanhMucSP
    {
        public void AddDanhMuc(DanhMucSP danhmuc)
        {
            if (danhmuc.TenSP == "")
                throw new Exception("Vui lòng nhập tên sản phẩm!");
            if (danhmuc.DVT == "")
                throw new Exception("Vui lòng nhập đơn vị tính!");            
            DADanhMucSP daDanhMuc = new DADanhMucSP();
            daDanhMuc.AddDanhMuc(danhmuc);
        }

        public DataTable GetDanhMuc(string table)
        {
            DADanhMucSP daDanhMuc = new DADanhMucSP();
            return daDanhMuc.GetDanhMuc(table);
        }

        public void DeleteFromDanhMuc(ArrayList array, string table, string id)
        {
            DADanhMucSP daDanhMuc = new DADanhMucSP();
            daDanhMuc.DeleteFromDanhMuc(array, table, id);
        }

        public void DeleteFromDanhMucs(ArrayList array, ArrayList array1, string table, string id, string id1)
        {
            DADanhMucSP daDanhMuc = new DADanhMucSP();
            daDanhMuc.DeleteFromDanhMucs(array, array1, table, id, id1);
        }
        
    }
}
