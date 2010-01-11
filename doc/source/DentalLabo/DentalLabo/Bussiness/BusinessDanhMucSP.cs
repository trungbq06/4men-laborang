using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalLabo.Data;

namespace DentalLabo.Bussiness
{
    class BusinessDanhMucSP
    {
        public void AddDanhMuc(DanhMucSP danhmuc)
        {
            if (danhmuc.DVT == "")
                throw new Exception("Vui lòng nhập đơn vị tính!");
            if (danhmuc.TenSP == "")
                throw new Exception("Vui lòng nhập tên sản phẩm!");
            DADanhMucSP daDanhMuc = new DADanhMucSP();
            daDanhMuc.AddDanhMuc(danhmuc);
        }
    }
}
