using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DA;
using BL;
using DO;
namespace GUI
{
    public partial class frmChonnhanvien : Form
    {
        private string manv;
        private int vaitro = 0;
        public frmChonnhanvien(string manhanvien)
        {
            InitializeComponent();
            manv = manhanvien;

            _cboChonnhanvien.Items.Add("Nhân viên nhập liệu");
            _cboChonnhanvien.Items.Add("Nhân viên xác nhận thu tiền");

            // load ds phòng thu ngân
            LoadDSPhongTN();
        }

        private void _btnXacnhan_Click(object sender, EventArgs e)
        {
            if (_cboChonnhanvien.SelectedIndex == 0 || _cboChonPhong.SelectedIndex == 1)
            {
                pnlLuachonvitri.Enabled = true;
            }
            
        }

        private void _btnLuachon_Click(object sender, EventArgs e)
        {
          
            if (_cboChonnhanvien.SelectedIndex == 0)
            {
                vaitro = 1;
            }
            else { vaitro = 2; }

            if (KiemTraDaDay(_cboChonPhong.SelectedValue.ToString(), _cboChonBan.SelectedValue.ToString(), true) == true)
            {
                if (KiemTraViTri(_cboChonPhong.SelectedValue.ToString(), _cboChonBan.SelectedValue.ToString(), vaitro, true) == true)
                {
                    try
                    {
                        BL.PhanCong_BL.CapNhatPhanCong(manv, vaitro, _cboChonPhong.SelectedValue.ToString(), _cboChonBan.SelectedValue.ToString(), true);
                        MessageBox.Show("Cập nhật thành công");
                        Main gdchinh = new Main(manv);
                        gdchinh.Visible = true;
                        this.Visible = false;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra");
                    }
                }
                else
                {
                    MessageBox.Show("Vai trò này đã có! Vui lòng chọn vai trò khác");
                }
            }
            else
            {
                MessageBox.Show("Bàn này đã đầy! Vùi lòng chọn bàn khác");
            }

        }
        // Đổ dữ liệu vào cbo Phòng 
        private void LoadDSPhongTN()
        {
            _cboChonPhong.DataSource = BL.ChiTietPhongBan_BL.LayChiTietPhongBan("TN");
            _cboChonPhong.DisplayMember = "_PhongSo";
            _cboChonPhong.ValueMember = "_MaCTPB";
            _cboChonPhong.Text = "";
        }

        private void _cboChonPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cboChonBan.DataSource = BL.DanhSachBan_BL.LayDanhSachBan(_cboChonPhong.SelectedValue.ToString());
            _cboChonBan.DisplayMember ="_MaBan";
            _cboChonBan.ValueMember = "_MaBan";
        }
        // Hàm kiểm tra nhân viên đó vào phòng và bàn có hợp lệ hay không ( bàn có đầy không á)
        private bool KiemTraDaDay(string phong, string ban, bool trangthaidn)
        {
            List<PhanCong_DO> pc = BL.PhanCong_BL.LocNguoiDung(phong,ban,trangthaidn);
            if (pc.Count >= 2)
            {
                return false;
            }
            return true;
        }
        // Hàm kiểm tra vị trí đó có hợp lệ không ví dụ 1 bàn không có 1 vai trò giống nhau..
        private bool KiemTraViTri(string phong, string ban, int vaitro,bool trangthaidn)
        {
            List<PhanCong_DO> dsPhancong = BL.PhanCong_BL.LocNguoiDung(phong, ban, trangthaidn);
            if (dsPhancong.Count == 1)
            {
                foreach (PhanCong_DO row in dsPhancong)
                {
                    if (row._VaiTro == vaitro)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
