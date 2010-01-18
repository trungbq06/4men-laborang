using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalLabo.Data
{
    class DanhMucNV
    {
        #region Attribute
        private string _maNV;
        private string _maBP;
        private string _tenNV;
        private string _gioiTinh;
        private string _soCMT;
        private string _diaChi;
        private string _dienThoai;
        private int _namSinh;
        #endregion Attribute

        #region Properties
        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }

        public string MaBP
        {
            get { return _maBP; }
            set { _maBP = value; }
        }

        public string TenNV
        {
            get { return _tenNV; }
            set { _tenNV = value; }
        }

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }

        public int NamSinh
        {
            get { return _namSinh; }
            set { _namSinh = value; }
        }

        public string SoCMT
        {
            get { return _soCMT; }
            set { _soCMT = value; }
        }

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public string DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }

        #endregion Properties

        public DanhMucNV()
        {
            _maNV = "";
            _maBP = "";
            _tenNV = "";
            _gioiTinh = "Nam";
            _soCMT = "";
            _diaChi = "";
            _dienThoai = "";
        }
    }
}
