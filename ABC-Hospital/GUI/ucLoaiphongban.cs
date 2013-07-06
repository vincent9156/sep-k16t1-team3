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
    public partial class ucLoaiphongban : UserControl
    {
        bool add = false;
        bool sua = false;
        public ucLoaiphongban()
        {
            InitializeComponent();
            lblDatetime.Text = BL.HamDungChung_BL.Updatetime();
            LoadDSLoaiPhongBan();
        }
        private void LoadDSLoaiPhongBan()
        {
            _grdLoaiPhongBan.DataSource = BL.LoaiPhongBan_BL.LayLoaiPhongBan();
            // chi tiết loại phòng ban
            _btnLuu.Enabled = false;
            _btnSua.Enabled = true;
            _txtMaSo.Enabled = false;
            _btnHuy.Enabled = false;
            // gia tri
            _txtLoaiPhongBan.Enabled = false;
            _tbxMoTa.Enabled = false;
            _chkTrangThai.Enabled = false;

        }
        private void ResetText()
        {
            _txtMaSo.Text = "";
            _txtLoaiPhongBan.Text = "";
            _tbxMoTa.Text = "";
            _chkTrangThai.Checked = false;
        }
        private bool KiemTraHopLe()
        {
            if (_txtLoaiPhongBan.Text == "")
            {
                return false;
            }
            return true;
        }
        private void _btnThem_Click(object sender, EventArgs e)
        {
            ResetText();
            _btnLuu.Enabled = true;
            _btnSua.Enabled = false;
            _btnThem.Enabled = false;
            _btnHuy.Enabled = true;
            add = true;
            //
            _txtLoaiPhongBan.Enabled = true;
            _tbxMoTa.Enabled = true;
            _chkTrangThai.Enabled = true;
        }

        private void _btnLuu_Click(object sender, EventArgs e)
        {
            if (add == true)
            {
                if (KiemTraHopLe() == true)
                {
                    try
                    {
                        BL.LoaiPhongBan_BL.ThemLoaiPhongBan(_txtMaSo.Text, _txtLoaiPhongBan.Text, _tbxMoTa.Text, _chkTrangThai.Checked);
                        MessageBox.Show("Đã thêm loại phòng ban " + _txtLoaiPhongBan.Text + " thành công!");
                        LoadDSLoaiPhongBan();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra! Quá trình thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (sua == true)
                {
                    if (KiemTraHopLe() == true)
                    {
                        try
                        {
                            BL.LoaiPhongBan_BL.CapNhatLoaiPhongBan(_txtMaSo.Text, _txtLoaiPhongBan.Text, _tbxMoTa.Text, _chkTrangThai.Checked);
                            MessageBox.Show("Đã cập nhật loại phòng ban " + _txtLoaiPhongBan.Text + " thành công!");
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
            _txtLoaiPhongBan.Enabled = false;
            _tbxMoTa.Enabled = false;
            _chkTrangThai.Enabled = false;
            add = false;
            sua = false;
        }

        private void _btnSua_Click(object sender, EventArgs e)
        {
            sua = true;
            _btnLuu.Enabled = true;
            _btnThem.Enabled = false;
            _btnSua.Enabled = false;
            _btnHuy.Enabled = true;
            //
            _txtLoaiPhongBan.Enabled = true;
            _tbxMoTa.Enabled = true;
            _chkTrangThai.Enabled = true;
        }
        private void XemChiTietLoaiPhongBan(int pos)
        {
            try
            {
                _txtMaSo.Text = _grdLoaiPhongBan.Rows[pos].Cells[0].Value.ToString().Trim();
                _txtLoaiPhongBan.Text = _grdLoaiPhongBan.Rows[pos].Cells[1].Value.ToString();
                _tbxMoTa.Text = _grdLoaiPhongBan.Rows[pos].Cells[2].Value.ToString();
                if (_grdLoaiPhongBan.Rows[pos].Cells[3].Value.ToString() == "True")
                {
                    _chkTrangThai.Checked = true;
                }
                else
                {
                    if (_grdLoaiPhongBan.Rows[pos].Cells[3].Value.ToString() == "False")
                    {
                        _chkTrangThai.Checked = false;
                    }
                }
            }
            catch (Exception e)
            { }

        }
        private void _grdLoaiPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            int pos = _grdLoaiPhongBan.CurrentCell.RowIndex;
            XemChiTietLoaiPhongBan(pos);
        }
        private void _TimTheoMa_TextChanged(object sender, EventArgs e)
        {
            if (_txtTimMaSo.Text == "")
            {
                _grdLoaiPhongBan.DataSource = BL.LoaiPhongBan_BL.LayLoaiPhongBan();
            }
            else
            {
                _grdLoaiPhongBan.DataSource = BL.LoaiPhongBan_BL.TimKiemTheoMa(_txtTimMaSo.Text);
            }
        }

        private void _TimTheoTen_TextChanged_1(object sender, EventArgs e)
        {
            if (_txtTimKiemTen.Text == "")
            {
                _grdLoaiPhongBan.DataSource = BL.LoaiPhongBan_BL.LayLoaiPhongBan();
            }
            else
            {
                _grdLoaiPhongBan.DataSource = BL.LoaiPhongBan_BL.TimKiemTheoTen(_txtTimKiemTen.Text);
            }
        }

        private void _btnHuy_Click(object sender, EventArgs e)
        {
            _grdLoaiPhongBan_SelectionChanged(sender, e);
            // trạng thái button
            add = false;
            sua = false;
            _btnHuy.Enabled = false;
            _btnLuu.Enabled = false;
            _btnThem.Enabled = true;
            _btnSua.Enabled = true;
            // trạng thái dữ liệu
            _txtLoaiPhongBan.Enabled = false;
            _tbxMoTa.Enabled = false;
            _chkTrangThai.Enabled = false;
        }
    }

}
