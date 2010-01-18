using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalLabo.Data
{
    class KhachHang
    {
        #region Attribute
        private string _maKH;
        private string _tenKH;
        private string _gioiTinh;
        private string _dienThoai;
        private string _maSoThue;
        private string _nguoiDaiDien;
        private int _maNhomKH;
        private string _diaChi;
        #endregion Attribute

        #region Properties
        public string MaKH
        {
            get { return _maKH; }
            set { _maKH = value; }
        }

        public string TenKH
        {
            get { return _tenKH; }
            set { _tenKH = value; }
        }

        public string GioiTinh
        {
            get { return _gioiTinh; }
            set { _gioiTinh = value; }
        }

        public string DienThoai
        {
            get { return _dienThoai; }
            set { _dienThoai = value; }
        }

        public string MaSoThue
        {
            get { return _maSoThue; }
            set { _maSoThue = value; }
        }

        public string NguoiDaiDien
        {
            get { return _nguoiDaiDien; }
            set { _nguoiDaiDien = value; }
        }

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }

        public int MaNhomKH
        {
            get { return _maNhomKH; }
            set { _maNhomKH = value; }
        }

        #endregion Properties

        public KhachHang()
        {
            _maKH = "";
            _tenKH = "";
            _gioiTinh = "";
            _dienThoai = "Nam";
            _maSoThue = "";
            _nguoiDaiDien = "";
            _maNhomKH = 0;
        }
    }
}
