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
        private double _donGia2_9;
        private double _donGia10;
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

        public double DonGia10
        {
            get { return _donGia10; }
            set { _donGia10 = value; }
        }

        public double DonGia2_9
        {
            get { return _donGia2_9; }
            set { _donGia2_9 = value; }
        }

        #endregion Properties

        public BangGiaSP()
        {
            _maSP = "";
            _maVL = "";
            _donGia = 0;
            _donGia2_9 = 0;
            _donGia10 = 0;
        }
    }
}
