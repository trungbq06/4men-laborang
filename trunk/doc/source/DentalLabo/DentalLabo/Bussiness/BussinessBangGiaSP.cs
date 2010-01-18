using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalLabo.DataAccess;
using DentalLabo.Data;
using System.Data;

namespace DentalLabo.Bussiness
{
    class BussinessBangGiaSP
    {
        public void AddDanhMuc(BangGiaSP danhmuc)
        {
            DABangGiaSP banggia = new DABangGiaSP();
            banggia.AddDanhMuc(danhmuc);
        }

        public void UpdateDanhMuc(BangGiaSP banggia, string id, string idUpdate, string id1, string idUpdate1)
        {
            DABangGiaSP dabanggia = new DABangGiaSP();
            dabanggia.UpdateDanhMuc(banggia, id, idUpdate, id1, idUpdate1);
        }
    }
}
