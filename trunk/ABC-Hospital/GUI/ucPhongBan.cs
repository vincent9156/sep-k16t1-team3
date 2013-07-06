using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucPhongBan : UserControl
    {
        bool add = false;
        bool sua = false;
        string MaLoaiPhongBan;
        string MaNhomDichVu;
        public ucPhongBan()
        {
            InitializeComponent();
            lblDatetime.Text = BL.HamDungChung_BL.Updatetime();
            LoadDSPhongBan();
            LoadDSLoaiPhongBan();
            LoadDSNhomDichVu();
            
        }

        private void labelX5_Click(object sender, EventArgs e)
        {
            frmChiTietPhongBan temp = new frmChiTietPhongBan();
            temp.ShowDialog();
        }
        private void LoadDSPhongBan()
        {
            _grdDSPhongBan.DataSource = BL.PhongBan_BL.LayPhongBan();
            // chi tiết phòng ban
            _btnLuu.Enabled = false;
            _btnSua.Enabled = true;
            _txtMaSo.Enabled = false;
            _btnHuy.Enabled = false;
            // gia tri
            _txtTenPhong.Enabled = false;
            _tbxMota.Enabled = false;
            _chkTrangthai.Enabled = false;
            _cboLoaiPhongBan.Enabled = false;
            _cboNhomDichVu.Enabled = false;
        }
        private void MaTuDong()
        {
            string ten = _txtTenPhong.Text;
            string[] s = ten.Split(' ');
            string result ="";
            foreach (string word in s)
            {
                if (word.Length > 0)
                {
                    result = result + word[0].ToString();
                }
            }
            _txtMaSo.Text = result.ToUpper();
        }

        private void _txtTenPhong_TextChanged(object sender, EventArgs e)
        {
            if (_txtTenPhong.Text.Length != 0)
            {
                MaTuDong();
            }
        }
        // load danh sách tên loại phòng ban add vô combobox
        private void LoadDSLoaiPhongBan()
        {
            _cboLoaiPhongBan.DataSource = BL.LoaiPhongBan_BL.LayLoaiPhongBan();
            _cboLoaiPhongBan.DisplayMember = "_TenLoaiPhongBan";
            _cboLoaiPhongBan.ValueMember = "_MaLoaiPhongBan";
            _cboLoaiPhongBan.Text = "";
        }
        // load danh sách tên nhóm dịch vụ add vô combobox
        private void LoadDSNhomDichVu()
        {
            _cboNhomDichVu.DataSource = BL.NhomDichVu_BL.LayNhomDichVu();
            _cboNhomDichVu.DisplayMember = "_TenNhom";
            _cboNhomDichVu.ValueMember = "_MaNhom";
            _cboNhomDichVu.Text = "";
        }
        private void ResetText()
        {
            _txtMaSo.Text = "";
            _txtTenPhong.Text = "";
            _cboLoaiPhongBan.Text = "";
            _cboNhomDichVu.Text = "";
            _tbxMota.Text = "";
            _chkTrangthai.Checked = false;
        }
        private bool KiemTraHopLe()
        {
            if (_txtTenPhong.Text == ""||_cboLoaiPhongBan.Text==""||_cboNhomDichVu.Text=="")
            {
                return false;
            }
            return true;
        }
        private void _btnThem_Click(object sender, EventArgs e)
        {
            //button
            ResetText();
            _btnLuu.Enabled = true;
            _btnSua.Enabled = false;
            _btnThem.Enabled = false;
            _btnHuy.Enabled = true;
            add = true;
            //gia tri
            _txtTenPhong.Enabled = true;
            _tbxMota.Enabled = true;
            _chkTrangthai.Enabled = true;
            _cboLoaiPhongBan.Enabled = true;
            _cboNhomDichVu.Enabled = true;
        }
        private void _btnLuu_Click(object sender, EventArgs e)
        {
            if (add == true)//them
            {
                if (KiemTraHopLe() == true)
                {
                    try
                    {
                        BL.PhongBan_BL.ThemPhongBan(_txtMaSo.Text, _txtTenPhong.Text,MaLoaiPhongBan,MaNhomDichVu,0,_tbxMota.Text, _chkTrangthai.Checked);
                        MessageBox.Show("Đã thêm phòng ban " + _txtTenPhong.Text + " thành công!");
                        LoadDSPhongBan();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra! Quá trình thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (sua == true)//sua
                {
                    if (KiemTraHopLe() == true)
                    {
                        try
                        {
                            BL.PhongBan_BL.CapNhatPhongBan(_txtMaSo.Text, _txtTenPhong.Text, MaLoaiPhongBan, MaNhomDichVu, 0, _tbxMota.Text, _chkTrangthai.Checked);
                            MessageBox.Show("Đã cập nhật phòng ban " + _txtTenPhong.Text + " thành công!");
                            LoadDSLoaiPhongBan();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Đã có lỗi xảy ra! Quá trình sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            _btnSua.Enabled = true;
            _btnThem.Enabled = true;
            _btnLuu.Enabled = false;
            _btnHuy.Enabled = false;
            _txtTenPhong.Enabled = false;
            _tbxMota.Enabled = false;
            _chkTrangthai.Enabled = false;
            _cboLoaiPhongBan.Enabled = false;
            _cboNhomDichVu.Enabled = false;
            add = false;
            sua = false;
        }
        private void _btnSua_Click(object sender, EventArgs e)
        {
            sua = true;
            //button
            _btnLuu.Enabled = true;
            _btnThem.Enabled = false;
            _btnSua.Enabled = false;
            _btnHuy.Enabled = true;
            //gia tri
            _txtTenPhong.Enabled = true;
            _tbxMota.Enabled = true;
            _chkTrangthai.Enabled = true;
            _cboLoaiPhongBan.Enabled = true;
            _cboNhomDichVu.Enabled = true;
        }
        private void XemChiTietPhongBan(int pos)
        {
            try
            {
                _txtMaSo.Text = _grdDSPhongBan.Rows[pos].Cells[0].Value.ToString().Trim();
                _txtTenPhong.Text = _grdDSPhongBan.Rows[pos].Cells[1].Value.ToString();
                _cboLoaiPhongBan.Text = _grdDSPhongBan.Rows[pos].Cells[2].Value.ToString();
                _cboNhomDichVu.Text = _grdDSPhongBan.Rows[pos].Cells[3].Value.ToString();
                _tbxMota.Text = _grdDSPhongBan.Rows[pos].Cells[5].Value.ToString();
                if (_grdDSPhongBan.Rows[pos].Cells[6].Value.ToString() == "True")
                {
                    _chkTrangthai.Checked = true;
                }
                else
                {
                    if (_grdDSPhongBan.Rows[pos].Cells[6].Value.ToString() == "False")
                    {
                        _chkTrangthai.Checked = false;
                    }
                }
            }
            catch (Exception e)
            { }

        }
        private void _grdDSPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            int pos = _grdDSPhongBan.CurrentCell.RowIndex;
            XemChiTietPhongBan(pos);
        }
        private void _TimTheoMa_TextChanged(object sender, EventArgs e)
        {
            if (_txtTimMaSo.Text == "")
            {
                _grdDSPhongBan.DataSource = BL.PhongBan_BL.LayPhongBan();
            }
            else
            {
                _grdDSPhongBan.DataSource = BL.PhongBan_BL.TimKiemTheoMa(_txtTimMaSo.Text);
            }
        }

        private void _TimTheoTen_TextChanged_1(object sender, EventArgs e)
        {
            if (_txtTimKiemTen.Text == "")
            {
                _grdDSPhongBan.DataSource = BL.PhongBan_BL.LayPhongBan();
            }
            else
            {
                _grdDSPhongBan.DataSource = BL.PhongBan_BL.TimKiemTheoTen(_txtTimKiemTen.Text);
            }
        }

        private void _btnHuy_Click(object sender, EventArgs e)
        {
            _grdDSPhongBan_SelectionChanged(sender, e);
            // trạng thái button
            add = false;
            sua = false;
            _btnHuy.Enabled = false;
            _btnLuu.Enabled = false;
            _btnThem.Enabled = true;
            _btnSua.Enabled = true;
            // trạng thái dữ liệu
            _txtTenPhong.Enabled = false;
            _tbxMota.Enabled = false;
            _chkTrangthai.Enabled = false;
            _cboLoaiPhongBan.Enabled = false;
            _cboNhomDichVu.Enabled = false;
        }
        private void _cboLoaiPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            MaLoaiPhongBan = _cboLoaiPhongBan.SelectedValue.ToString();
        }
        private void _cboNhomDichVu_SelectionChanged(object sender, EventArgs e)
        {
            MaNhomDichVu = _cboNhomDichVu.SelectedValue.ToString();
        }
    }
}
