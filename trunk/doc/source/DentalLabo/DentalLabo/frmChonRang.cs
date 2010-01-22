using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DentalLabo.MauDatHang;
using DentalLabo.Mau_dat_hang;

namespace DentalLabo.MauDatHang
{
    public partial class frmChonRang : Form
    {
        bool[] arrayChoosed = new bool[32];
        private bool isChoosed = false;
        private DentalLabo.Mau_dat_hang.frmMauDatHang form;
        private string vitrirang = "";
        public frmChonRang()
        {
            InitializeComponent();
            for (int i = 0; i < 32; i++)
            {
                arrayChoosed[i] = false;
            }
        }

        // dung truyen du lieu lai form Mau dat hang
        public delegate void GetString(String MyString1);
        public GetString getString;

        private void button1_Click(object sender, EventArgs e)
        {
            if (vitrirang.Length >= 2) vitrirang = vitrirang.Substring(0, vitrirang.Length - 2);
            if (getString != null)
            {
                getString(vitrirang);
            }
            this.Close();
        }

        private void StringViTri(bool[] array)
        {
            vitrirang = "";
            for (int i = 0; i < 32; i++)
            {
                if (array[i] == true)
                {
                    int j = i+1;
                    vitrirang = vitrirang + j + ", ";
                }
            }
            txtViTri.Text = vitrirang;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[0] == false) arrayChoosed[0] = true;
            else arrayChoosed[0] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[1] == false) arrayChoosed[1] = true;
            else arrayChoosed[1] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[2] == false) arrayChoosed[2] = true;
            else arrayChoosed[2] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[3] == false) arrayChoosed[3] = true;
            else arrayChoosed[3] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[4] == false) arrayChoosed[4] = true;
            else arrayChoosed[4] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[5] == false) arrayChoosed[5] = true;
            else arrayChoosed[5] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[6] == false) arrayChoosed[6] = true;
            else arrayChoosed[6] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[7] == false) arrayChoosed[7] = true;
            else arrayChoosed[7] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[8] == false) arrayChoosed[8] = true;
            else arrayChoosed[8] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[9] == false) arrayChoosed[9] = true;
            else arrayChoosed[9] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[10] == false) arrayChoosed[10] = true;
            else arrayChoosed[10] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[11] == false) arrayChoosed[11] = true;
            else arrayChoosed[11] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[12] == false) arrayChoosed[12] = true;
            else arrayChoosed[12] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[13] == false) arrayChoosed[13] = true;
            else arrayChoosed[13] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[14] == false) arrayChoosed[14] = true;
            else arrayChoosed[14] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[15] == false) arrayChoosed[15] = true;
            else arrayChoosed[15] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[16] == false) arrayChoosed[16] = true;
            else arrayChoosed[16] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[17] == false) arrayChoosed[17] = true;
            else arrayChoosed[17] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[18] == false) arrayChoosed[18] = true;
            else arrayChoosed[18] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[19] == false) arrayChoosed[19] = true;
            else arrayChoosed[19] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[20] == false) arrayChoosed[20] = true;
            else arrayChoosed[20] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[21] == false) arrayChoosed[21] = true;
            else arrayChoosed[21] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[22] == false) arrayChoosed[22] = true;
            else arrayChoosed[22] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[23] == false) arrayChoosed[23] = true;
            else arrayChoosed[23] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[24] == false) arrayChoosed[24] = true;
            else arrayChoosed[24] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[25] == false) arrayChoosed[25] = true;
            else arrayChoosed[25] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[26] == false) arrayChoosed[26] = true;
            else arrayChoosed[26] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[27] == false) arrayChoosed[27] = true;
            else arrayChoosed[27] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[28] == false) arrayChoosed[28] = true;
            else arrayChoosed[28] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[29] == false) arrayChoosed[29] = true;
            else arrayChoosed[29] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[30] == false) arrayChoosed[30] = true;
            else arrayChoosed[30] = false;
            StringViTri(arrayChoosed);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            if (arrayChoosed[31] == false) arrayChoosed[31] = true;
            else arrayChoosed[31] = false;
            StringViTri(arrayChoosed);
        }
    }
}
