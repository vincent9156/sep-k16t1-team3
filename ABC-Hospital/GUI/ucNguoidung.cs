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
        // biến kiểm tra trạng thái các nút buttons
        bool add = false;
        bool update = false;

        public ucNguoidung()
        {
            InitializeComponent();
            lblDatetime.Text = BL.HamDungChung_BL.Updatetime();
            LoadDSNguoiDung();
            LoadDSNhomNguoiDung(); // hiển thị lên combobox
            LoadDSNguoiDungTheoNhom(); // hiển thị lên grd temp để lấy mã cuối cùng

        }
        // Hàm hiển thị danh sách người dùng dưới csdl lên form
        private void LoadDSNguoiDung()
        {
            _grdNguoiDung.DataSource = BL.NguoiDung_BL.LayNguoiDung();
            // XemChiTietNhomNguoiDung();
            _btnThem.Enabled = true;
            _btnLuu.Enabled = false;
            _btnSua.Enabled = true;
            _btnHuy.Enabled = false;
        }
        // Hàm hiển thị các nhóm người dùng lên combobox
        private void LoadDSNhomNguoiDung()
        {
            _cboNhomNguoiDung.DataSource = BL.NhomNguoiDung_BL.LayNhomNguoiDung();
            _cboNhomNguoiDung.ValueMember = "_MaNhom";
            _cboNhomNguoiDung.DisplayMember = "_TenNhom";
            _cboNhomNguoiDung.Text = "";

        }
        // Hàm trả về giá trị rỗng của các components khi người dùng thêm mới 1 record
        private void ResetTextValue()
        {
            _txtMaNguoiDung.Text = "";
            _cboNhomNguoiDung.Text = "";
            _txtTenNguoiDung.Text = "";
            _txtMatKhau.Text = "";
            _chkTrangThai.Checked = false;


        }
        // Hàm kiểm tra hợp lệ khi người dùng nhập vào
        private bool KiemtraHopLe()
        {
            if (_txtMaNguoiDung.Text == "" || _cboNhomNguoiDung.Text == "" || _txtTenNguoiDung.Text == "" || _txtMatKhau.Text == "")
            {
                return false;
            }
            return true;
        }
        // Hàm hiển thị dữ liệu mã người dùng theo nhóm người dùng
        private void LoadDSNguoiDungTheoNhom()
        {
            string temp = _cboNhomNguoiDung.SelectedValue.ToString();   
            _grdTemp.DataSource = BL.NguoiDung_BL.LayNguoiDungTheoMaNhom(temp);
        }
        // Hàm lấy mã cuối cùng theo nhóm người dùng
        private String LayMaCuoiCung()
        {
            int count = _grdTemp.RowCount;
            string lastid = "";
            if (count < 1)
            {
                lastid = "";
            }
            else
            {
                lastid = _grdTemp.Rows[count - 1].Cells[0].Value.ToString(); 
            }
            return lastid;
        }
        // Hàm next ID mã người dùng theo nhóm
        private string IDNext(string manhom)
        {
            string NextID = "";
            string id = LayMaCuoiCung();
            if (id == "")
            {
                NextID = manhom + "0000" + 1;
            }
            else
            {
                string cut = id.Substring(2);
                int con;
                Int32.TryParse(cut, out con);
                int next = con + 1;
                if (next < 10)
                {
                    NextID = manhom + "0000" + next;
                }
                else 
                {
                    if (next < 100)
                    {
                        NextID = manhom + "000" + next;
                    }
                    else
                    {
                        if (next < 1000)
                        {
                            NextID = manhom + "00" + next;
                        }
                        else
                        {
                            if (next < 10000)
                            {
                                NextID = manhom + "0" + next;
                            }
                        }
                    }
                }

            }

            return NextID;
        }

        // Hàm cập nhật dữ liệu datagirdview Tạm (_grdTemp) để lấy mã người dùng cuối theo nhóm
        private void _cboNhomNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            _txtTemp.Text = _cboNhomNguoiDung.SelectedValue.ToString();
            LoadDSNguoiDungTheoNhom();
            if (add == true)
            {
                _txtMaNguoiDung.Text = IDNext(_cboNhomNguoiDung.SelectedValue.ToString());
            }
        }
        // Sự kiện cho các button Thêm/Lưu/Sửa/Hủy
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
            _cboNhomNguoiDung.Enabled = true;
            _txtTenNguoiDung.Enabled = true;
            _txtMatKhau.Enabled = true;
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
                        BL.NguoiDung_BL.ThemNguoiDung(_txtMaNguoiDung.Text, _cboNhomNguoiDung.SelectedValue.ToString(), _txtTenNguoiDung.Text, _txtMatKhau.Text, _chkTrangThai.Checked);
                        MessageBox.Show("Đã thêm  người dùng " + _txtTenNguoiDung.Text + " thành công!");
                        LoadDSNguoiDung();
                        LoadDSNguoiDungTheoNhom();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đã số lỗi xảy ra! \n Đề nghị xem lại quá trình thao tác dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                            BL.NguoiDung_BL.CapNhatNguoiDung(_txtMaNguoiDung.Text, _cboNhomNguoiDung.SelectedValue.ToString(), _txtTenNguoiDung.Text, _txtMatKhau.Text, _chkTrangThai.Checked);
                            MessageBox.Show("Đã thay đổi dữ liệu thành công", "Thông báo");
                            LoadDSNguoiDung();
                            LoadDSNguoiDungTheoNhom();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Đã có lỗi xảy ra! Quá trình Sửa đã thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                // trạng thái button
                add = false;
                update = true;
                _btnSua.Enabled = true;
                _btnThem.Enabled = true;
                _btnLuu.Enabled = false;
                _btnHuy.Enabled = false;
                // trạng thái dữ liệu
                _cboNhomNguoiDung.Enabled = false;
                _txtTenNguoiDung.Enabled = false;
                _txtMatKhau.Enabled = false;
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
            _cboNhomNguoiDung.Enabled = true;
            _txtTenNguoiDung.Enabled = true;
            _txtMatKhau.Enabled = true;
            _chkTrangThai.Enabled = true;
        }
        private void _btnHuy_Click(object sender, EventArgs e)
        {
            _grdNguoiDung_SelectionChanged(sender, e);
            // trạng thái button
            add = false;
            update = false;
            _btnHuy.Enabled = false;
            _btnLuu.Enabled = false;
            _btnThem.Enabled = true;
            _btnSua.Enabled = true;
            // trạng thái dữ liệu
            _cboNhomNguoiDung.Enabled = false;
            _txtTenNguoiDung.Enabled = false;
            _txtMatKhau.Enabled = false;
            _chkTrangThai.Enabled = false;
        }
        // Tìm kiếm người dùng theo mã người dùng
        private void _txtTimTheoMa_TextChanged(object sender, EventArgs e)
        {
            if (_txtTimTheoMa.Text == "")
            {
                _grdNguoiDung.DataSource = BL.NguoiDung_BL.LayNguoiDung();
                //_grdTemp.DataSource = BL.NguoiDung_BL.LayNguoiDungTheoMaNhom(_cboNhomNguoiDung.SelectedValue.ToString());
            }
            else
            {
                _grdNguoiDung.DataSource = BL.NguoiDung_BL.TimKiemTheoMa(_txtTimTheoMa.Text);
            }
        }
        // Tìm kiếm người dùng theo tên người dùgn
        private void _txtTimTheoTen_TextChanged(object sender, EventArgs e)
        {
            if (_txtTimTheoTen.Text == "")
            {
                _grdNguoiDung.DataSource = BL.NguoiDung_BL.LayNguoiDung();
                //_grdTemp.DataSource = BL.NguoiDung_BL.LayNguoiDungTheoMaNhom(_cboNhomNguoiDung.SelectedValue.ToString());
            }
            else
            {
                _grdNguoiDung.DataSource = BL.NguoiDung_BL.TimKiemTheoTen(_txtTimTheoTen.Text);
            }
        }
        // Hàm lấy dự liệu từ datagirdview hiển thị sang các componets detail
        private void XemChiTietNhomNguoiDung(int pos)
        {
            try
            {
                _txtMaNguoiDung.Text = _grdNguoiDung.Rows[pos].Cells[0].Value.ToString().Trim();
                _txtTenNguoiDung.Text = _grdNguoiDung.Rows[pos].Cells[2].Value.ToString(); 
                _txtMatKhau.Text = _grdNguoiDung.Rows[pos].Cells[3].Value.ToString();
                _cboNhomNguoiDung.DataSource = BL.NhomNguoiDung_BL.LayNhomNguoiDung();
                _cboNhomNguoiDung.SelectedValue = _grdNguoiDung.Rows[pos].Cells[1].Value.ToString();
                _cboNhomNguoiDung.DisplayMember = "_TenNhom";
            
                if (_grdNguoiDung.Rows[pos].Cells[4].Value.ToString() == "True")
                {
                    _chkTrangThai.Checked = true;
                }
                else
                {
                    if (_grdNguoiDung.Rows[pos].Cells[4].Value.ToString() == "False")
                    {
                        _chkTrangThai.Checked = false;
                    }
                }
            }
            catch (Exception e)
            { }

        }
        // Hàm bắt sự kiện click chuột vào các row trên datagirdview
        private void _grdNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            int pos = _grdNguoiDung.CurrentCell.RowIndex;
            
            XemChiTietNhomNguoiDung(pos);
            
        }


    }
}
