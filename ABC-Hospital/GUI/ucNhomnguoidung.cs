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
    public partial class ucNhomnguoidung : UserControl
    {
        bool add = false;
        bool update = false;
        public ucNhomnguoidung()
        {
            InitializeComponent();
            lblDatetime.Text = BL.HamDungChung_BL.Updatetime();
            LoadDSNhomNguoiDung();
        }
        private void LoadDSNhomNguoiDung()
        {
            _grdNhomNguoiDung.DataSource = BL.NhomNguoiDung_BL.LayNhomNguoiDung();
           // XemChiTietNhomNguoiDung();
            _btnThem.Enabled = true;
            _btnLuu.Enabled = false;
            _btnSua.Enabled = true;
        }
        private void ResetText()
        {
            _txtMaNhom.Text = "";
            _txtTenNhom.Text = "";
            _txtMoTa.Text = "";
            _chkTrangThai.Checked = false;
            
        }
        private bool KiemtraHopLe()
        {
            if (_txtMaNhom.Text == "" || _txtTenNhom.Text =="")
            {
                return false;
            }
            return true;
        }

        private void _btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            update = false;
            _btnSua.Enabled = false;
            _btnThem.Enabled = false;
            _btnLuu.Enabled = true;
            _btnHuy.Enabled = true;
            ResetText();
        }

        private void _btnLuu_Click(object sender, EventArgs e)
        {
            _btnLuu.Enabled = false;
            if (add == true) // Thêm
            {
                if (KiemtraHopLe() == true)
                {
                    try
                    {
                        BL.NhomNguoiDung_BL.ThemNhomNguoiDung(_txtMaNhom.Text, _txtTenNhom.Text, _txtMoTa.Text, _chkTrangThai.Checked);
                        LoadDSNhomNguoiDung();
                        MessageBox.Show("Đã thêm nhóm người dùng " + _txtTenNhom.Text + " thành công!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra! Quá trình thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (update == false)// sửa
                {
                    if (KiemtraHopLe() == true)
                    {
                        try
                        {
                            BL.NhomNguoiDung_BL.CapNhatNhomNguoiDung(_txtMaNhom.Text, _txtTenNhom.Text, _txtMoTa.Text, _chkTrangThai.Checked);
                            LoadDSNhomNguoiDung();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Đã có lỗi xảy ra! Quá trình Sửa đã thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }

         
        }

        private void _btnSua_Click(object sender, EventArgs e)
        {
            add = false;
            update = true;
            _btnSua.Enabled = false;
            _btnThem.Enabled = false;
            _btnLuu.Enabled = true;
            _btnHuy.Enabled = true;
        }
        private void _btnHuy_Click(object sender, EventArgs e)
        {
            add = false;
            update = false;
            _btnHuy.Enabled = false;
            _btnLuu.Enabled = false;
            _btnThem.Enabled = true;
            _btnSua.Enabled = true;
        }

        private void _TimTheoMa_TextChanged(object sender, EventArgs e)
        {
            if (_txtTimTheoMa.Text == "")
            {
                _grdNhomNguoiDung.DataSource = BL.NhomNguoiDung_BL.LayNhomNguoiDung();
            }
            else
            {
                _grdNhomNguoiDung.DataSource = BL.NhomNguoiDung_BL.TimKiemTheoMa(_txtTimTheoMa.Text);
            }
        }

        private void _TimTheoTen_TextChanged_1(object sender, EventArgs e)
        {
            if (_txtTimTheoTen.Text == "")
            {
                _grdNhomNguoiDung.DataSource = BL.NhomNguoiDung_BL.LayNhomNguoiDung();
            }
            else
            {
                _grdNhomNguoiDung.DataSource = BL.NhomNguoiDung_BL.TimKiemTheoTen(_txtTimTheoTen.Text);
            }
        }
        private void XemChiTietNhomNguoiDung()
        {
            string manhom = _grdNhomNguoiDung.CurrentRow.Cells[0].Value.ToString();
            List<NhomNguoiDung_DO> dsNhom = BL.NhomNguoiDung_BL.LayNhomNguoiDungTheoMa(manhom);
            _txtMaNhom.Text = dsNhom[0]._MaNhom;
            _txtTenNhom.Text = dsNhom[0]._TenNhom;
            _txtMoTa.Text = dsNhom[0]._MoTa;
            _chkTrangThai.Checked = dsNhom[0]._TrangThai.Value;

        }
        



    }
}
