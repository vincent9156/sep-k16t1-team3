using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DA;
using BL;
using DO;
namespace GUI
{
    public partial class ucNguoidung : UserControl
    {
        public ucNguoidung()
        {
            InitializeComponent();
            lblDatetime.Text = BL.HamDungChung_BL.Updatetime();
           
        }
        private void LoadDSNguoiDung()
        {
 
        }
        private void LoadDSNhomNguoiDung()
        {

            
        }


        private void _cboNhomNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
