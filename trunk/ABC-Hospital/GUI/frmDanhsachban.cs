using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDanhsachban : Form
    {
        private bool add = false;
        private bool sua = false;
        private string _mactpb;
        public frmDanhsachban()
        {
            InitializeComponent();
        }
        public frmDanhsachban(string mactpb, string tenphong)
            : this()
        {
            _mactpb = mactpb;
            LoadCTPhongBan();
            _panTitle.Text = "Danh Sách Bàn Tại Phòng " + tenphong;
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadCTPhongBan()
        {
            _grdDSBan.DataSource = BL.DanhSachBan_BL.LayDanhSachBan(_mactpb);
            // button
            _btnLuu.Enabled = false;
            _btnHuy.Enabled = false;
            // du lieu
            _txtBanSo.Enabled = false;
            _tbxMoTa.Enabled = false;
            _chkTrangThai.Enabled = false;
        }
        private void ResetText()
        {
            _tbxMoTa.Text = "";
            _chkTrangThai.Checked = false;
        }
        private void MaTuDong()
        {
            string malonnhat = BL.DanhSachBan_BL.MaBanLonNhat();
            string maso = "";
            if (malonnhat.Length == 0)
            {
                _txtBanSo.Text = "B01";
            }
            else
            {
                int masotam = Convert.ToInt32(malonnhat.Substring(1, malonnhat.Length - 1)) + 1;
                for (int i = 0; i < 2 - masotam.ToString().Length; i++)
                {
                    maso += "0";
                }
                _txtBanSo.Text = "B" + maso + masotam;
            }
        }
        private void _btnThem_Click(object sender, EventArgs e)
        {
            add = true;
            ResetText();
            MaTuDong();
            // button
            _btnLuu.Enabled = true;
            _btnHuy.Enabled = true;
            _btnThem.Enabled = false;
            _btnSua.Enabled = false;
            // du lieu
            _tbxMoTa.Enabled = true;
            _chkTrangThai.Enabled = true;
        }

        private void _btnHuy_Click(object sender, EventArgs e)
        {
            add = false;
            sua = false;
            _grdDSBan.DataSource = BL.DanhSachBan_BL.LayDanhSachBan(_mactpb);
            //button
            _btnThem.Enabled = true;
            _btnSua.Enabled = true;
            _btnLuu.Enabled = false;
            _btnHuy.Enabled = false;
            // gia tri
            _tbxMoTa.Enabled = false;
            _chkTrangThai.Enabled = false;
        }

        private void _btnSua_Click(object sender, EventArgs e)
        {
            sua = true;
            // button
            _btnLuu.Enabled = true;
            _btnHuy.Enabled = true;
            _btnThem.Enabled = false;
            _btnSua.Enabled = false;
            // du lieu
            _tbxMoTa.Enabled = true;
            _chkTrangThai.Enabled = true;
        }
        private void _btnLuu_Click(object sender, EventArgs e)
        {
            if (add == true)//them
            {
                try
                {
                    BL.DanhSachBan_BL.ThemBan(_txtBanSo.Text,_mactpb, _tbxMoTa.Text, _chkTrangThai.Checked);
                    MessageBox.Show("Đã thêm phòng ban " + _txtBanSo.Text + " thành công!");
                    LoadCTPhongBan();
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra! Quá trình thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                if (sua == true)//sua
                {
                    try
                    {
                        BL.DanhSachBan_BL.CapNhatBan(_txtBanSo.Text, _tbxMoTa.Text, _chkTrangThai.Checked);
                        MessageBox.Show("Đã cập nhật phòng ban " + _txtBanSo.Text + " thành công!");
                        LoadCTPhongBan();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra! Quá trình sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            _btnSua.Enabled = true;
            _btnThem.Enabled = true;
            _btnLuu.Enabled = false;
            _btnHuy.Enabled = false;
            _tbxMoTa.Enabled = false;
            _chkTrangThai.Enabled = false;
            add = false;
            sua = false;
        }
        private void XemChiTietBan(int pos)
        {
            try
            {
                _txtBanSo.Text = _grdDSBan.Rows[pos].Cells[0].Value.ToString().Trim();
                _tbxMoTa.Text = _grdDSBan.Rows[pos].Cells[1].Value.ToString();
                if (_grdDSBan.Rows[pos].Cells[2].Value.ToString() == "True")
                {
                    _chkTrangThai.Checked = true;
                }
                else
                {
                    if (_grdDSBan.Rows[pos].Cells[2].Value.ToString() == "False")
                    {
                        _chkTrangThai.Checked = false;
                    }
                }
            }
            catch (Exception e)
            { }

        }
        private void _grdChiTietBan_SelectionChanged(object sender, EventArgs e)
        {
            int pos = _grdDSBan.CurrentCell.RowIndex;
            XemChiTietBan(pos);
        }
    }
}
