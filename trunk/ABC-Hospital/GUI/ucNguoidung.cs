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
            LoadDSNhomNguoiDung();
        }
        private void LoadDSNguoiDung()
        {
            _grdNguoiDung.DataSource = BL.NguoiDung_BL.LayNguoiDung();
        }
        private void LoadDSNhomNguoiDung()
        {
            _cboNhomNguoiDung.DataSource = BL.NhomNguoiDung_BL.LayNhomNguoiDungTheoTen();
            _cboNhomNguoiDung.DisplayMember = "_TenNhom";
            _cboNhomNguoiDung.SelectedIndex = -1;
            
        }
        private void MaTuDong(string manhom)
        {
            string malonnhat = BL.NguoiDung_BL.LayMaLonNhat(manhom);
            string maso = "";
            int masotam = Convert.ToInt32(malonnhat.Substring(2, malonnhat.Length - 2)) + 1;
            for (int i = 0; i < 5 - masotam.ToString().Length; i++)
            {
                maso += "0";
            }
            _txtMaNguoiDung.Text = manhom + maso + masotam;
            //_txtMaNguoiDung.Text = malonnhat;
        }
        private void lblThanhpho_Click(object sender, EventArgs e)
        {

        }

        private void pnlTieude_Click(object sender, EventArgs e)
        {

        }

        private void _cboNhomNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string TenNhom = _cboNhomNguoiDung.SelectedItem.ToString();
            //string MaNhom = BL.NhomNguoiDung_BL.TimMaNhomNguoiDung("AD");
            //MaTuDong(MaNhom);
            //_txtMatKhau.Text = MaNhom;
        }
    }
}
