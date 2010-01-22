using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DentalLabo.Nhap_kho_va_ban_hang;

namespace DentalLabo.BanHangVaCongNo
{
    class Validation
    {        
        public static bool ChuaNhap(string field, string message)
        {
            if (field == "")
            {
                Database.Warning(message);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
