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
    public partial class Main : Form
    {
        string username;
        public Main(string usertruyen)
        {
            InitializeComponent();
            username = usertruyen;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            mainload();
            //frmChonnhanvien lg = new frmChonnhanvien();
            //lg.ShowDialog();
            //GiaoDienMacDinh();
            HienThiPhanQuyen(username);
            
        }
        private void mainload()
        {
            pnlMain.Controls.Clear();
            ucBackground bg = new ucBackground();
            pnlMain.Controls.Add(bg);
            bg.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void rbbUsergroup_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucNhomnguoidung nnd = new ucNhomnguoidung();
            pnlMain.Controls.Add(nnd);
            nnd.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void rbbNguoidung_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucNguoidung nd = new ucNguoidung();
            pnlMain.Controls.Add(nd);
            nd.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void rbbLaphoadon_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucLaphoadon lhd = new ucLaphoadon();
            pnlMain.Controls.Add(lhd);
            lhd.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void ribbonOrbMenuItem4_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucBackground bg = new ucBackground();
            pnlMain.Controls.Add(bg);
            bg.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucBaocaoNhanviennhaplieu bc = new ucBaocaoNhanviennhaplieu();
            pnlMain.Controls.Add(bc);
            bc.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucBaocaoNhanvienthutien bc = new ucBaocaoNhanvienthutien();
            pnlMain.Controls.Add(bc);
            bc.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucBaocaoBenhnhan bc = new ucBaocaoBenhnhan();
            pnlMain.Controls.Add(bc);
            bc.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucThongkeDoanhthu tk = new ucThongkeDoanhthu();
            pnlMain.Controls.Add(tk);
            tk.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void _rbbPhanquyen_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucPhanquyen temp = new ucPhanquyen();
            pnlMain.Controls.Add(temp);
            temp.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void rbbLoaiphongban_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucLoaiphongban temp = new ucLoaiphongban();
            pnlMain.Controls.Add(temp);
            temp.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void rbbPhongban_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucPhongBan temp = new ucPhongBan();
            pnlMain.Controls.Add(temp);
            temp.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void _rbbNhomdichvu_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucNhomdichvu temp = new ucNhomdichvu();
            pnlMain.Controls.Add(temp);
            temp.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void _rbbDichvu_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucDichvu temp = new ucDichvu();
            pnlMain.Controls.Add(temp);
            temp.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void rbbThutien_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucXacnhanthutien temp = new ucXacnhanthutien();
            pnlMain.Controls.Add(temp);
            temp.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        // Hàm hiển thị những quyền theo nhóm người dùng ( sử dụng tên tài khoản )
        private void HienThiPhanQuyen(string username)
        {
            string manhom = username.Substring(0, 2);
            List<ChucNangNhom_DO> dsQuyen = BL.DangNhap_BL.LayQuyen(manhom);
            foreach (ChucNangNhom_DO qu in dsQuyen)
            {
                if (qu._TrangThai == true && qu._MaChucNang == 1)
                {
                    _rbbNhomNguoiDung.Visible = true;
                    _rbpQuanlytaiKhoan.Visible = true;
                    _rbtQuantrihethong.Visible = true;
                }
                if (qu._TrangThai == true && qu._MaChucNang == 2)
                {
                    _rbbNguoiDung.Visible = true;
                    _rbpQuanlytaiKhoan.Visible = true;
                    _rbtQuantrihethong.Visible = true;
                }
                if (qu._TrangThai == true && qu._MaChucNang == 3)
                {
                    _rbbPhanQuyen.Visible = true;
                    _rbpQuanlytaiKhoan.Visible = true;
                    _rbtQuantrihethong.Visible = true;
                }
                if (qu._TrangThai == true && qu._MaChucNang == 4)
                {
                    _rbbLoaiPhongBan.Visible = true;
                    _rbpQuanLyPhongBan.Visible = true;
                    _rbtQuantrihethong.Visible = true;
                }
                if (qu._TrangThai == true && qu._MaChucNang == 5)
                {
                    _rbbPhongban.Visible = true;
                    _rbpQuanLyPhongBan.Visible = true;
                    _rbtQuantrihethong.Visible = true;
                }
                if (qu._TrangThai == true && qu._MaChucNang == 6)
                {
                    _rbbNhomdichvu.Visible = true;
                    _rbpQuanLyDichVu.Visible = true;
                    _rbtQuantrihethong.Visible = true;
                }
                if (qu._TrangThai == true && qu._MaChucNang == 7)
                {
                    _rbbDichvu.Visible = true;
                    _rbpQuanLyDichVu.Visible = true;
                    _rbtQuantrihethong.Visible = true;
                }
                if (qu._TrangThai == true && qu._MaChucNang == 8)
                {
                    _rbbLaphoadon.Visible = true;
                    _rbpQuanlyHoadon.Visible = true;
                    _rbtQuanlythungan.Visible = true;
                }
                if (qu._TrangThai == true && qu._MaChucNang == 9)
                {
                    _rbbThutien.Visible = true;
                    _rbpQuanlyHoadon.Visible = true;
                    _rbtQuanlythungan.Visible = true;
                }
                if (qu._TrangThai == true && qu._MaChucNang == 10)
                {
                    _rbbBaoCaoNhapLieu.Visible = true;
                    _rbpDanhSachBienLai.Visible = true;
                    _rbtThongKeBaoCao.Visible = true;
                }
                if (qu._TrangThai == true && qu._MaChucNang == 11)
                {
                    _rbbBaoCaoThuTien.Visible = true;
                    _rbpDanhSachBienLai.Visible = true;
                    _rbtThongKeBaoCao.Visible = true;
                }
                if (qu._TrangThai == true && qu._MaChucNang == 12)
                {
                    _rbbBaoCaoBenhNhan.Visible = true;
                    _rbtThongKeBaoCao.Visible = true;
                    _rbtThongKeBaoCao.Visible = true;
                }
                if (qu._TrangThai == true && qu._MaChucNang == 13)
                {
                    _rbbDoanhThu.Visible = true;
                    _rbpThongKe.Visible = true;
                    _rbtThongKeBaoCao.Visible = true;
                }

            }
        }
        
        // Hàm ẩn tất cả from
        private void GiaoDienMacDinh()
        {
            
            _rbtQuantrihethong.Visible = false;
            _rbpQuanlytaiKhoan.Visible = false;
            _rbbNhomNguoiDung.Visible = false;
            _rbbNguoiDung.Visible = false;
            _rbbPhanQuyen.Visible = false;
            _rbpQuanLyPhongBan.Visible = false;
            _rbbLoaiPhongBan.Visible = false;
            _rbbPhongban.Visible = false;
            _rbpQuanLyDichVu.Visible = false;
            _rbbNhomdichvu.Visible = false;
            _rbbDichvu.Visible = false;
            _rbtQuanlythungan.Visible = false;
            _rbpQuanlyHoadon.Visible = false;
            _rbbLaphoadon.Visible = false;
            _rbbThutien.Visible = false;
            _rbtThongKeBaoCao.Visible = false;
            _rbpDanhSachBienLai.Visible = false;
            _rbbBaoCaoNhapLieu.Visible = false;
            _rbbBaoCaoThuTien.Visible = false;
            _rbpDanhSachThuTien.Visible = false;
            _rbbBaoCaoBenhNhan.Visible = false;
            _rbpThongKe.Visible = false;
            _rbbDoanhThu.Visible = false;
            
        }
    }
}
