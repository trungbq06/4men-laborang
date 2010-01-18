using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DentalLabo.BanHangVaCongNo
{
    class BHCNModel
    {
        /**
         * Update combo box theo query va ten truong
         */
        public static void UpdateComboBoxByQuery(ComboBox cmb, String query, String field){
            DataTable result = Database.query(query);
            cmb.Items.Clear();
            foreach (DataRow row in result.Rows) {
                cmb.Items.Add(row[field]);
            }
            if (result.Rows.Count > 0)
                cmb.SelectedIndex = 0;
            else {                
                cmb.Text = "";
            }
        }
    }
}
