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
    public partial class ucDichvu : UserControl
    {
        private bool add = false;
        private bool sua = false;
        public ucDichvu()
        {
            InitializeComponent();
            lblDatetime.Text = BL.HamDungChung_BL.Updatetime();
            LoadDanhSachDichVu();
            LoadDanhSachNhomDichVu();
        }
        private void LoadDanhSachDichVu()
        {
            _grdDichVu.DataSource = BL.DichVu_BL.LoadDanhSachDichVu();
            // Enable/Disable cho các Button
            _txtMaso.Enabled = false;
            _btnHuy.Enabled = false;
            _btnLuu.Enabled = false;
            _btnSua.Enabled = true;
            // Enable/Disable các giá trị
            _txtTendichvu.Enabled = false;
            _tbxMota.Enabled = false;
            _chkTrangthai.Enabled = false;
            _cboNhomdichvu.Enabled = false;
            _txtDongia.Enabled = false;
        }
        private void LoadDanhSachNhomDichVu()
        {
            _cboNhomdichvu.DataSource = BL.NhomDichVu_BL.LayNhomDichVu();
            _cboNhomdichvu.DisplayMember = "_TenNhom";
            _cboNhomdichvu.ValueMember = "_MaNhom";
            _cboNhomdichvu.Text = "";
        }
        private void MaTuDong()
        {
            string malonnhat = BL.DichVu_BL.LayMaDichVuLonNhat();
            string maso = "";
            if (malonnhat.Length == 0)
            {
                _txtMaso.Text = "DV001";
            }
            else
            {
                int masotam = Convert.ToInt32(malonnhat.Substring(2, malonnhat.Length - 2)) + 1;
                for (int i = 0; i < 3 - masotam.ToString().Length; i++)
                {
                    maso += "0";
                }
                _txtMaso.Text = "DV" + maso + masotam;
            }
        }
        private void ResetText()
        {
            _txtMaso.Text = "";
            _txtTendichvu.Text = "";
            _cboNhomdichvu.Text = "";
            _txtDongia.Text = "";
            _tbxMota.Text = "";
            _chkTrangthai.Checked = false;
        }
        private bool KiemTraHopLe()
        {
            if (_txtTendichvu.Text == ""  || _cboNhomdichvu.Text == "")
            {
                return false;
            }
            return true;
        }
        private void _btnThem_Click(object sender, EventArgs e)
        {
            //button
            ResetText();
            MaTuDong();
            _btnLuu.Enabled = true;
            _btnSua.Enabled = false;
            _btnThem.Enabled = false;
            _btnHuy.Enabled = true;
            add = true;
            //gia tri
            _txtTendichvu.Enabled = true;
            _tbxMota.Enabled = true;
            _chkTrangthai.Enabled = true;
            _cboNhomdichvu.Enabled = true;
            _txtDongia.Enabled = true;
        }
        private void _btnLuu_Click(object sender, EventArgs e)
        {
            if (add == true)//them
            {
                if (KiemTraHopLe() == true)
                {
                    try
                    {
                        BL.DichVu_BL.ThemDichVu(_txtMaso.Text, _cboNhomdichvu.SelectedValue.ToString(), _txtTendichvu.Text, _txtDongia.Text, _tbxMota.Text, _chkTrangthai.Checked);
                        MessageBox.Show("Đã thêm dịch vụ " + _txtTendichvu.Text + " thành công!");
                        LoadDanhSachDichVu();
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
                            BL.DichVu_BL.ThemDichVu(_txtMaso.Text, _cboNhomdichvu.SelectedValue.ToString(), _txtTendichvu.Text, _txtDongia.Text, _tbxMota.Text, _chkTrangthai.Checked);
                            MessageBox.Show("Đã cập nhật dịch vụ " + _txtTendichvu.Text + " thành công!");
                            LoadDanhSachDichVu();
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
            _txtTendichvu.Enabled = false;
            _txtDongia.Enabled = false;
            _tbxMota.Enabled = false;
            _chkTrangthai.Enabled = false;
            _cboNhomdichvu.Enabled = false;
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
            _txtTendichvu.Enabled = true;
            _tbxMota.Enabled = true;
            _chkTrangthai.Enabled = true;
            _txtDongia.Enabled = true;
            _cboNhomdichvu.Enabled = true;
        }
        private void XemChiTietDichVu(int pos)
        {
            try
            {
                _txtMaso.Text = _grdDichVu.Rows[pos].Cells[0].Value.ToString().Trim();
                _txtTendichvu.Text = _grdDichVu.Rows[pos].Cells[1].Value.ToString();
                _cboNhomdichvu.Text = _grdDichVu.Rows[pos].Cells[2].Value.ToString();
                _txtDongia.Text = _grdDichVu.Rows[pos].Cells[3].Value.ToString();
                _tbxMota.Text = _grdDichVu.Rows[pos].Cells[4].Value.ToString();
                if (_grdDichVu.Rows[pos].Cells[5].Value.ToString() == "True")
                {
                    _chkTrangthai.Checked = true;
                }
                else
                {
                    if (_grdDichVu.Rows[pos].Cells[5].Value.ToString() == "False")
                    {
                        _chkTrangthai.Checked = false;
                    }
                }
            }
            catch (Exception e)
            { }

        }
        private void _grdDichVu_SelectionChanged(object sender, EventArgs e)
        {
            int pos = _grdDichVu.CurrentCell.RowIndex;
            XemChiTietDichVu(pos);
        }
        private void _btnHuy_Click(object sender, EventArgs e)
        {
            _grdDichVu_SelectionChanged(sender, e);
            // trạng thái button
            add = false;
            sua = false;
            _btnHuy.Enabled = false;
            _btnLuu.Enabled = false;
            _btnThem.Enabled = true;
            _btnSua.Enabled = true;
            // trạng thái dữ liệu
            _txtTendichvu.Enabled = false;
            _tbxMota.Enabled = false;
            _chkTrangthai.Enabled = false;
            _txtDongia.Enabled = false;
            _cboNhomdichvu.Enabled = false;
        }
        private void _TimTheoMa_TextChanged(object sender, EventArgs e)
        {
            if (_txtTimmaso.Text == "")
            {
                _grdDichVu.DataSource = BL.DichVu_BL.LoadDanhSachDichVu();
            }
            else
            {
                _grdDichVu.DataSource = BL.DichVu_BL.TimKiemTheoMa(_txtTimmaso.Text);
            }
        }

        private void _TimTheoTen_TextChanged_1(object sender, EventArgs e)
        {
            if (_txtTimkiem.Text == "")
            {
                _grdDichVu.DataSource = BL.DichVu_BL.LoadDanhSachDichVu();
            }
            else
            {
                _grdDichVu.DataSource = BL.DichVu_BL.TimKiemTheoTen(_txtTimkiem.Text);
            }
        }
    }
}
