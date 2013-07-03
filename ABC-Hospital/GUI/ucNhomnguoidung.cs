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
            _btnHuy.Enabled = false;
        }
        private void ResetTextValue()
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
            // trạng thái button
            add = true;
            update = false;
            _btnSua.Enabled = false;
            _btnThem.Enabled = false;
            _btnLuu.Enabled = true;
            _btnHuy.Enabled = true;
            // trạng thái dữ liệu
            // trạng thái dữ liệu
            _txtMaNhom.Enabled = true;
            _txtTenNhom.Enabled = true;
            _txtMoTa.Enabled = true;
            _chkTrangThai.Enabled = true;

            ResetTextValue();
        }

        private void _btnLuu_Click(object sender, EventArgs e)
        {
            
            if (add == true) // Thêm
            {
                if (KiemtraHopLe() == true)
                {
                    try
                    {
                        BL.NhomNguoiDung_BL.ThemNhomNguoiDung(_txtMaNhom.Text, _txtTenNhom.Text, _txtMoTa.Text, _chkTrangThai.Checked);
                        MessageBox.Show("Đã thêm nhóm người dùng " + _txtTenNhom.Text + " thành công!");
                        LoadDSNhomNguoiDung();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra! Quá trình thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (update == true)// sửa
                {
                    if (KiemtraHopLe() == true)
                    {
                        try
                        {
                            BL.NhomNguoiDung_BL.CapNhatNhomNguoiDung(_txtMaNhom.Text, _txtTenNhom.Text, _txtMoTa.Text, _chkTrangThai.Checked);
                            MessageBox.Show("Đã thay đổi dữ liệu thành công", "Thông báo");
                            LoadDSNhomNguoiDung();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Đã có lỗi xảy ra! Quá trình Sửa đã thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                // trạng thái buttons
                _btnLuu.Enabled = false;
                _btnThem.Enabled = true;
                _btnSua.Enabled = true;
                _btnHuy.Enabled = false;
                // trạng thái dữ liệu
                _txtMaNhom.Enabled = false;
                _txtTenNhom.Enabled = false;
                _txtMoTa.Enabled = false;
                _chkTrangThai.Enabled = false;
            }

         
        }

        private void _btnSua_Click(object sender, EventArgs e)
        {
            // trạng thái button
            add = false;
            update = true;
            _btnSua.Enabled = false;
            _btnThem.Enabled = false;
            _btnLuu.Enabled = true;
            _btnHuy.Enabled = true;
            // trạng thái dữ liệu
            _txtMaNhom.Enabled = true;
            _txtTenNhom.Enabled = true;
            _txtMoTa.Enabled = true;
            _chkTrangThai.Enabled = true;

        }
        private void _btnHuy_Click(object sender, EventArgs e)
        {
            _grdNhomNguoiDung_SelectionChanged(sender,e);
            // trạng thái button
            add = false;
            update = false;
            _btnHuy.Enabled = false;
            _btnLuu.Enabled = false;
            _btnThem.Enabled = true;
            _btnSua.Enabled = true;
            // trạng thái dữ liệu
            _txtMaNhom.Enabled = false;
            _txtTenNhom.Enabled = false;
            _txtMoTa.Enabled = false;
            _chkTrangThai.Enabled = false;
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
        private void XemChiTietNhomNguoiDung(int pos)
        {
            try
            {
                _txtMaNhom.Text = _grdNhomNguoiDung.Rows[pos].Cells[0].Value.ToString().Trim();
                _txtTenNhom.Text = _grdNhomNguoiDung.Rows[pos].Cells[1].Value.ToString();
                _txtMoTa.Text = _grdNhomNguoiDung.Rows[pos].Cells[2].Value.ToString();
                if (_grdNhomNguoiDung.Rows[pos].Cells[3].Value.ToString() == "True")
                {
                    _chkTrangThai.Checked = true;
                }
                else
                {
                    if (_grdNhomNguoiDung.Rows[pos].Cells[3].Value.ToString() == "False")
                    {
                        _chkTrangThai.Checked = false;
                    }
                }
            }
            catch (Exception e)
            {}

        }

        private void _grdNhomNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            int pos = _grdNhomNguoiDung.CurrentCell.RowIndex;
            XemChiTietNhomNguoiDung(pos);
        }

        



    }
}
