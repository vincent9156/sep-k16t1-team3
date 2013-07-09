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
    public partial class frmChiTietPhongBan : Form
    {
        private bool add = false;
        private bool sua = false;
        private string _maphong;
        public frmChiTietPhongBan()
        {
            InitializeComponent();
            
        }
        public frmChiTietPhongBan(string Maphong)
            : this()
        {
            _maphong = Maphong;
            LoadCTPhongBan();
            lblDatetime.Text = BL.HamDungChung_BL.Updatetime();
        }
        private void labelX5_Click(object sender, EventArgs e)
        {
            frmDanhsachban temp = new frmDanhsachban(_txtMaSo.Text, _txtPhongSo.Text);
            temp.ShowDialog();
        }
        private void LoadCTPhongBan()
        {
            _grdChiTietPhongBan.DataSource = BL.ChiTietPhongBan_BL.LayChiTietPhongBan(_maphong);
            // button
            _btnLuu.Enabled = false;
            _btnHuy.Enabled = false;
            // du lieu
            _txtMaSo.Enabled = false;
            _txtPhongSo.Enabled = false;
            _tbxMoTa.Enabled = false;
            _chkTrangthai.Enabled = false;
        }
        private void ResetText()
        {
            _txtPhongSo.Text = "";
            _tbxMoTa.Text = "";
            _chkTrangthai.Checked = false;
        }
        private void MaTuDong()
        {
            string malonnhat = BL.ChiTietPhongBan_BL.MaChiTietPhongBanLonNhat(_maphong);
            int x = _maphong.Length;
            string maso = "";
            if (malonnhat.Length == 0)
            {
                _txtMaSo.Text = _maphong + "01";
            }
            else
            {
                int masotam = Convert.ToInt32(malonnhat.Substring(x, malonnhat.Length - x)) + 1;
                for (int i = 0; i < 2 - masotam.ToString().Length; i++)
                {
                    maso += "0";
                }
                _txtMaSo.Text = _maphong + maso + masotam;
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
            _txtPhongSo.Enabled = true;
            _tbxMoTa.Enabled = true;
            _chkTrangthai.Enabled = true;
        }

        private void _btnHuy_Click(object sender, EventArgs e)
        {
            add = false;
            sua = false;
            _grdChiTietPhongBan.DataSource = BL.ChiTietPhongBan_BL.LayChiTietPhongBan(_maphong);
            //button
            _btnThem.Enabled = true;
            _btnSua.Enabled = true;
            _btnLuu.Enabled = false;
            _btnHuy.Enabled = false;
            // gia tri
            _txtPhongSo.Enabled = false;
            _tbxMoTa.Enabled = false;
            _chkTrangthai.Enabled = false;
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
            _txtPhongSo.Enabled = true;
            _tbxMoTa.Enabled = true;
            _chkTrangthai.Enabled = true;
        }
        private bool KiemTraHopLe()
        {
            if (_txtPhongSo.Text == "")
            {
                return false;
            }
            return true;
        }
        private void _btnLuu_Click(object sender, EventArgs e)
        {
            if (add == true)//them
            {
                if (KiemTraHopLe() == true)
                {
                    try
                    {
                        BL.ChiTietPhongBan_BL.ThemChiTietPhongBan(_txtMaSo.Text, _txtPhongSo.Text, _maphong, _tbxMoTa.Text, _chkTrangthai.Checked);
                        MessageBox.Show("Đã thêm phòng ban " + _txtPhongSo.Text + " thành công!");
                        LoadCTPhongBan();
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
                            BL.ChiTietPhongBan_BL.CapNhatChiTietPhongBan(_txtMaSo.Text, _txtPhongSo.Text, _tbxMoTa.Text, _chkTrangthai.Checked);
                            MessageBox.Show("Đã cập nhật phòng ban " + _txtPhongSo.Text + " thành công!");
                            LoadCTPhongBan();
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
            _txtPhongSo.Enabled = false;
            _tbxMoTa.Enabled = false;
            _chkTrangthai.Enabled = false;
            add = false;
            sua = false;
        }
        private void XemChiTietPhongBan(int pos)
        {
            try
            {
                _txtMaSo.Text = _grdChiTietPhongBan.Rows[pos].Cells[0].Value.ToString().Trim();
                _txtPhongSo.Text = _grdChiTietPhongBan.Rows[pos].Cells[1].Value.ToString();
                _tbxMoTa.Text = _grdChiTietPhongBan.Rows[pos].Cells[2].Value.ToString();
                if (_grdChiTietPhongBan.Rows[pos].Cells[3].Value.ToString() == "True")
                {
                    _chkTrangthai.Checked = true;
                }
                else
                {
                    if (_grdChiTietPhongBan.Rows[pos].Cells[3].Value.ToString() == "False")
                    {
                        _chkTrangthai.Checked = false;
                    }
                }
            }
            catch (Exception e)
            { }

        }
        private void _grdChiTietPhongBan_SelectionChanged(object sender, EventArgs e)
        {
            int pos = _grdChiTietPhongBan.CurrentCell.RowIndex;
            XemChiTietPhongBan(pos);
        }
        private void _TimTheoMa_TextChanged(object sender, EventArgs e)
        {
            if (_txtTimmaso.Text == "")
            {
                _grdChiTietPhongBan.DataSource = BL.ChiTietPhongBan_BL.LayChiTietPhongBan(_maphong);
            }
            else
            {
                _grdChiTietPhongBan.DataSource = BL.ChiTietPhongBan_BL.TimKiemTheoMa(_txtTimmaso.Text,_maphong);
            }
        }

        private void _TimTheoTen_TextChanged_1(object sender, EventArgs e)
        {
            if (_txtTimkiem.Text == "")
            {
                _grdChiTietPhongBan.DataSource = BL.ChiTietPhongBan_BL.LayChiTietPhongBan(_maphong);
            }
            else
            {
                _grdChiTietPhongBan.DataSource = BL.ChiTietPhongBan_BL.TimKiemTheoTen(_txtTimkiem.Text,_maphong);
            }
        }
    }
}
