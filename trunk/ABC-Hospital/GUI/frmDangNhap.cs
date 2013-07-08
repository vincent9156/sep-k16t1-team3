using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BL;
using DA;
using DO;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        // Hàm kiểm tra đăng nhập
        private void KiemTraDangNhap(string user, string pass)
        {
            if (BL.DangNhap_BL.KiemTraHopLe(user, pass) == true)
            {
                if (BL.DangNhap_BL.KiemTraDungTK(user, pass) == true)
                {
                    //HienThiPhanQuyen(user);
                    Main gdchinh = new Main(user);
                    gdchinh.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Sai tên đang nhập hoặc mật khẩu \n Vui lòng thử lại.");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ.\n" +
                                "Chú ý: Thông tin tài khoản phải theo định dạng sau:\n" +
                                "Tên tài khoản: Chỉ bao gồm các kí tự nằm trong khoảng (a-z, A-Z, 0-9)\n" +
                                "               Độ dài tên tài khoản phải từ 6 đến 20 kí tự.\n" +
                                "Mật khẩu:      Chỉ bao gồm các kí tự nằm trong khoảng (a-z, A-Z, 0-9)\n" +
                                "               Độ dài tên tài khoản phải từ 6 đến 50 kí tự.\n" +
                                "\n Vui lòng thử lại.");
            }
        }

        private void _btnDangNhap_Click(object sender, EventArgs e)
        {
            KiemTraDangNhap(_txtTenTaiKhoan.Text, _txtMatKhau.Text);
        }

        private void _btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _txtTenTaiKhoan_Enter(object sender, EventArgs e)
        {
            _txtTenTaiKhoan.SelectAll();
        }

        private void _txtMatKhau_Enter(object sender, EventArgs e)
        {
            _txtMatKhau.SelectAll();
        }

        

    }
}
