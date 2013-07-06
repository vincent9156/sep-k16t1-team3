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
    public partial class ucNhomdichvu : UserControl
    {
        bool add = false;
        bool update = false;
        public ucNhomdichvu()
        {
            InitializeComponent();
            lblDatetime.Text = BL.HamDungChung_BL.Updatetime();
            LoadDanhSachNhomDichVu();
            _txtmanhomdichvu.Enabled = false;
            _btnLuu.Enabled = false;
            _btnHuy.Enabled = false;
        }
        private void LoadDanhSachNhomDichVu()
        {
            _grdNhomDichVu.DataSource = BL.NhomDichVu_BL.LayDanhSachNhomDichVu();
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
           // _txtmanhomdichvu.Enabled = true;
            _txtTennhom.Enabled = true;
            _tbxMota.Enabled = true;
            _chkTrangthai.Enabled = true;

            ResetTextValue();

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
           // _txtmanhomdichvu.Enabled = true;
            _txtTennhom.Enabled = true;
            _tbxMota.Enabled = true;
            _chkTrangthai.Enabled = true;

        }
        private void ResetTextValue()
        {
            _txtmanhomdichvu.Text = "";
            _txtTennhom.Text = "";
            _tbxMota.Text = "";
            _chkTrangthai.Checked = false;

        }
        private void _btnHuy_Click(object sender, EventArgs e)
        {
            _grdNhomDichVu_SelectionChanged(sender, e);
            // trạng thái button
            add = false;
            update = false;
            _btnHuy.Enabled = false;
            _btnLuu.Enabled = false;
            _btnThem.Enabled = true;
            _btnSua.Enabled = true;
            // trạng thái dữ liệu
        //    _txtmanhomdichvu.Enabled = false;
            _txtTennhom.Enabled = false;
            _tbxMota.Enabled = false;
            _chkTrangthai.Enabled = false;
        }
        private bool KiemtraHopLe()
        {
            if ( _txtTennhom.Text == "")
            {
                return false;
            }
            return true;
        }
        // Hàm lấy dự liệu từ datagirdview hiển thị sang các componets detail
        private void XemChiTietNhomDichVu(int pos)
        {
            try
            {
                _txtmanhomdichvu.Text = _grdNhomDichVu.Rows[pos].Cells[0].Value.ToString().Trim();
                _txtTennhom.Text = _grdNhomDichVu.Rows[pos].Cells[1].Value.ToString();
                _tbxMota.Text = _grdNhomDichVu.Rows[pos].Cells[2].Value.ToString();
                if (_grdNhomDichVu.Rows[pos].Cells[3].Value.ToString() == "True")
                {
                    _chkTrangthai.Checked = true;
                }
                else
                {
                    if (_grdNhomDichVu.Rows[pos].Cells[3].Value.ToString() == "False")
                    {
                        _chkTrangthai.Checked = false;
                    }
                }
            }
            catch (Exception e)
            { }

        }
        // Hàm bắt sự kiện click chuột vào các row trên datagirdview
        private void _grdNhomDichVu_SelectionChanged(object sender, EventArgs e)
        {
            int pos = _grdNhomDichVu.CurrentCell.RowIndex;
            XemChiTietNhomDichVu(pos);
        }
        private void _btnLuu_Click(object sender, EventArgs e)
        {

            if (add == true) // Thêm
            {
                if (KiemtraHopLe() == true)
                {
                    try
                    {
                        BL.NhomDichVu_BL.ThemNhomDichVu(_txtmanhomdichvu.Text, _txtTennhom.Text, _tbxMota.Text, _chkTrangthai.Checked);
                        MessageBox.Show("Đã thêm nhóm dịch vụ " + _txtTennhom.Text + " thành công!");
                        LoadDanhSachNhomDichVu();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã " + _txtmanhomdichvu.Text + " đã có trong hệ thống, hoặc có 1 số lỗi xảy ra! \n Đề nghị xem lại quá trình thao tác dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            BL.NhomDichVu_BL.CapNhatNhomDichVu(_txtmanhomdichvu.Text, _txtTennhom.Text, _tbxMota.Text, _chkTrangthai.Checked);
                            MessageBox.Show("Đã thay đổi dữ liệu thành công", "Thông báo");
                            LoadDanhSachNhomDichVu();
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
            //    _txtmanhomdichvu.Enabled = false;
                _txtTennhom.Enabled = false;
                _tbxMota.Enabled = false;
                _chkTrangthai.Enabled = false;
            }
        }
    }
}
