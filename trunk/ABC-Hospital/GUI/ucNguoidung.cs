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
            LoadDSNguoiDung();
        }
        private void LoadDSNguoiDung()
        {
            _grdNguoiDung.DataSource = BL.NguoiDung_BL.LayNguoiDung();
        }
        private void lblThanhpho_Click(object sender, EventArgs e)
        {

        }

        private void pnlTieude_Click(object sender, EventArgs e)
        {

        }
    }
}
