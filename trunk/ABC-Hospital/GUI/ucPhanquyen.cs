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
    public partial class ucPhanquyen : UserControl
    {
        public ucPhanquyen()
        {
            InitializeComponent();
        }

        private void ucPhanquyen_Load(object sender, EventArgs e)
        {
            LoadDSChucNang();
            LoadDSNhomNguoiDung();
        }
        private void LoadDSChucNang()
        {
            _grdChucNang.DataSource = BL.ChucNang_BL.LayChucNang();
        }
        // Hàm hiển thị các nhóm người dùng lên combobox
        private void LoadDSNhomNguoiDung()
        {
            _cboNhomNguoiDung.DataSource = BL.NhomNguoiDung_BL.LayNhomNguoiDung();
            _cboNhomNguoiDung.ValueMember = "_MaNhom";
            _cboNhomNguoiDung.DisplayMember = "_TenNhom";
            _cboNhomNguoiDung.Text = "";

        }

        private void _btnThietLap_Click(object sender, EventArgs e)
        {
            
                try
                {
                    int n = _grdChucNang.RowCount;
                    for (int i = 0; i < n; i++)
                    {
                        string machucnang = _grdChucNang.Rows[i].Cells[1].Value.ToString();
                        int cn;
                        Int32.TryParse(machucnang, out cn);
                        string manhom = _cboNhomNguoiDung.SelectedValue.ToString();
                        bool trangthai = false;
                        if (_grdChucNang.Rows[i].Cells[0].Value.ToString() == "True")
                        {
                            trangthai = true;
                        }
                        BL.ChucNangNhom_BL.ThemQuyenChoNhom(cn, manhom, trangthai);
                    }
                    MessageBox.Show("Đã thêm thành công!");

                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra!Vui lòng xem lại nhé!","Thông báo lỗi!");   
                    
                }
                
            
        }
    }
}
