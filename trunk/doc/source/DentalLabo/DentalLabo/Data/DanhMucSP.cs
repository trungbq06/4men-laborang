using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DentalLabo.Data
{
    class DanhMucSP
    {
        #region Attribute
        private string _maSP;
        private string _tenSP;
        private string _phamChat;
        private string _dvt;
        private string _nhomHangHoa;
        private string _ghiChu;
        #endregion Attribute

        #region Properties
        public string MaSP
        {
            get { return _maSP; }
            set { _maSP = value; }
        }

        public string TenSP
        {
            get { return _tenSP; }
            set { _tenSP = value; }
        }

        public string PhamChat
        {
            get { return _phamChat; }
            set { _phamChat = value; }
        }

        public string DVT
        {
            get { return _dvt; }
            set { _dvt = value; }
        }

        public string NhomHangHoa
        {
            get { return _nhomHangHoa; }
            set { _nhomHangHoa = value; }
        }

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }

        #endregion Properties

        public DanhMucSP()
        {
            _maSP = "";
            _tenSP = "";
            _phamChat = "";
            _dvt = "";
            _nhomHangHoa = "";
            _ghiChu = "";
        }

    }
}
