using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalLabo.Data
{
    class BangGiaSP
    {
        #region Attribute
        private string _maSP;
        private string _maVL;
        private double _donGia;
        private double _tinhThem;
        #endregion Attribute

        #region Properties
        public string MaSP
        {
            get { return _maSP; }
            set { _maSP = value; }
        }

        public string MaVL
        {
            get { return _maVL; }
            set { _maVL = value; }
        }

        public double DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }

        public double TinhThem
        {
            get { return _tinhThem; }
            set { _tinhThem = value; }
        }

        #endregion Properties

        public BangGiaSP()
        {
            _maSP = "";
            _maVL = "";
            _donGia = 0;
            _tinhThem = 0;
        }
    }
}
