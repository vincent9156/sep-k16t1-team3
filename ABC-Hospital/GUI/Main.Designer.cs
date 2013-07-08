namespace GUI
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.rbbMain = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItem4 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem3 = new System.Windows.Forms.RibbonOrbMenuItem();
            this._rbtQuantrihethong = new System.Windows.Forms.RibbonTab();
            this._rbpQuanlytaiKhoan = new System.Windows.Forms.RibbonPanel();
            this._rbbNhomNguoiDung = new System.Windows.Forms.RibbonButton();
            this._rbbNguoiDung = new System.Windows.Forms.RibbonButton();
            this._rbbPhanQuyen = new System.Windows.Forms.RibbonButton();
            this._rbpQuanLyPhongBan = new System.Windows.Forms.RibbonPanel();
            this._rbbLoaiPhongBan = new System.Windows.Forms.RibbonButton();
            this._rbbPhongban = new System.Windows.Forms.RibbonButton();
            this._rbpQuanLyDichVu = new System.Windows.Forms.RibbonPanel();
            this._rbbNhomdichvu = new System.Windows.Forms.RibbonButton();
            this._rbbDichvu = new System.Windows.Forms.RibbonButton();
            this._rbtQuanlythungan = new System.Windows.Forms.RibbonTab();
            this._rbpQuanlyHoadon = new System.Windows.Forms.RibbonPanel();
            this._rbbLaphoadon = new System.Windows.Forms.RibbonButton();
            this._rbbThutien = new System.Windows.Forms.RibbonButton();
            this._rbtThongKeBaoCao = new System.Windows.Forms.RibbonTab();
            this._rbpDanhSachBienLai = new System.Windows.Forms.RibbonPanel();
            this._rbbBaoCaoNhapLieu = new System.Windows.Forms.RibbonButton();
            this._rbbBaoCaoThuTien = new System.Windows.Forms.RibbonButton();
            this._rbpDanhSachThuTien = new System.Windows.Forms.RibbonPanel();
            this._rbbBaoCaoBenhNhan = new System.Windows.Forms.RibbonButton();
            this._rbpThongKe = new System.Windows.Forms.RibbonPanel();
            this._rbbDoanhThu = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.rbpBaocao = new System.Windows.Forms.RibbonPanel();
            this.rbtBaocaothongke = new System.Windows.Forms.RibbonTab();
            this.rbpThongke = new System.Windows.Forms.RibbonPanel();
            this.rbtQuanlythongke = new System.Windows.Forms.RibbonButton();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.rbbBaocao = new System.Windows.Forms.RibbonButton();
            this.pnlMain = new DevComponents.DotNetBar.PanelEx();
            this.SuspendLayout();
            // 
            // rbbMain
            // 
            this.rbbMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbbMain.Location = new System.Drawing.Point(0, 0);
            this.rbbMain.Minimized = false;
            this.rbbMain.Name = "rbbMain";
            // 
            // 
            // 
            this.rbbMain.OrbDropDown.AllowDrop = true;
            this.rbbMain.OrbDropDown.BorderRoundness = 8;
            this.rbbMain.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.rbbMain.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem4);
            this.rbbMain.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem1);
            this.rbbMain.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem2);
            this.rbbMain.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem3);
            this.rbbMain.OrbDropDown.Name = "";
            this.rbbMain.OrbDropDown.Size = new System.Drawing.Size(150, 248);
            this.rbbMain.OrbDropDown.TabIndex = 0;
            this.rbbMain.OrbImage = null;
            this.rbbMain.Size = new System.Drawing.Size(834, 157);
            this.rbbMain.TabIndex = 0;
            this.rbbMain.Tabs.Add(this._rbtQuantrihethong);
            this.rbbMain.Tabs.Add(this._rbtQuanlythungan);
            this.rbbMain.Tabs.Add(this._rbtThongKeBaoCao);
            this.rbbMain.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.rbbMain.Text = "ribbon1";
            // 
            // ribbonOrbMenuItem4
            // 
            this.ribbonOrbMenuItem4.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem4.Image")));
            this.ribbonOrbMenuItem4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem4.SmallImage")));
            this.ribbonOrbMenuItem4.Text = "Trang chủ";
            this.ribbonOrbMenuItem4.Click += new System.EventHandler(this.ribbonOrbMenuItem4_Click);
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "Thông tin tài khoản";
            // 
            // ribbonOrbMenuItem2
            // 
            this.ribbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.Image")));
            this.ribbonOrbMenuItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.SmallImage")));
            this.ribbonOrbMenuItem2.Text = "Đổi mật khẩu";
            // 
            // ribbonOrbMenuItem3
            // 
            this.ribbonOrbMenuItem3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem3.Image")));
            this.ribbonOrbMenuItem3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem3.SmallImage")));
            this.ribbonOrbMenuItem3.Text = "Thoát";
            // 
            // _rbtQuantrihethong
            // 
            this._rbtQuantrihethong.Panels.Add(this._rbpQuanlytaiKhoan);
            this._rbtQuantrihethong.Panels.Add(this._rbpQuanLyPhongBan);
            this._rbtQuantrihethong.Panels.Add(this._rbpQuanLyDichVu);
            this._rbtQuantrihethong.Text = "Quản trị hệ thống";
            // 
            // _rbpQuanlytaiKhoan
            // 
            this._rbpQuanlytaiKhoan.Items.Add(this._rbbNhomNguoiDung);
            this._rbpQuanlytaiKhoan.Items.Add(this._rbbNguoiDung);
            this._rbpQuanlytaiKhoan.Items.Add(this._rbbPhanQuyen);
            this._rbpQuanlytaiKhoan.Text = "Quản lý tài khoản";
            // 
            // _rbbNhomNguoiDung
            // 
            this._rbbNhomNguoiDung.Image = ((System.Drawing.Image)(resources.GetObject("_rbbNhomNguoiDung.Image")));
            this._rbbNhomNguoiDung.MinimumSize = new System.Drawing.Size(130, 0);
            this._rbbNhomNguoiDung.SmallImage = ((System.Drawing.Image)(resources.GetObject("_rbbNhomNguoiDung.SmallImage")));
            this._rbbNhomNguoiDung.Text = "Nhóm người dùng";
            this._rbbNhomNguoiDung.Click += new System.EventHandler(this.rbbUsergroup_Click);
            // 
            // _rbbNguoiDung
            // 
            this._rbbNguoiDung.Image = global::GUI.Resource.User_red_icon;
            this._rbbNguoiDung.MinimumSize = new System.Drawing.Size(100, 0);
            this._rbbNguoiDung.SmallImage = ((System.Drawing.Image)(resources.GetObject("_rbbNguoiDung.SmallImage")));
            this._rbbNguoiDung.Text = "Người dùng";
            this._rbbNguoiDung.Click += new System.EventHandler(this.rbbNguoidung_Click);
            // 
            // _rbbPhanQuyen
            // 
            this._rbbPhanQuyen.Image = global::GUI.Resource.Keys_icon;
            this._rbbPhanQuyen.MinimumSize = new System.Drawing.Size(100, 0);
            this._rbbPhanQuyen.SmallImage = ((System.Drawing.Image)(resources.GetObject("_rbbPhanQuyen.SmallImage")));
            this._rbbPhanQuyen.Text = "Phân quyền";
            this._rbbPhanQuyen.Click += new System.EventHandler(this._rbbPhanquyen_Click);
            // 
            // _rbpQuanLyPhongBan
            // 
            this._rbpQuanLyPhongBan.Items.Add(this._rbbLoaiPhongBan);
            this._rbpQuanLyPhongBan.Items.Add(this._rbbPhongban);
            this._rbpQuanLyPhongBan.Text = "Quản lý phòng ban";
            // 
            // _rbbLoaiPhongBan
            // 
            this._rbbLoaiPhongBan.Image = global::GUI.Resource.department_1_;
            this._rbbLoaiPhongBan.MinimumSize = new System.Drawing.Size(100, 0);
            this._rbbLoaiPhongBan.SmallImage = ((System.Drawing.Image)(resources.GetObject("_rbbLoaiPhongBan.SmallImage")));
            this._rbbLoaiPhongBan.Text = "Loại phòng ban";
            this._rbbLoaiPhongBan.Click += new System.EventHandler(this.rbbLoaiphongban_Click);
            // 
            // _rbbPhongban
            // 
            this._rbbPhongban.Image = global::GUI.Resource.logout_icon;
            this._rbbPhongban.MinimumSize = new System.Drawing.Size(100, 0);
            this._rbbPhongban.SmallImage = ((System.Drawing.Image)(resources.GetObject("_rbbPhongban.SmallImage")));
            this._rbbPhongban.Text = "Phòng ban";
            this._rbbPhongban.Click += new System.EventHandler(this.rbbPhongban_Click);
            // 
            // _rbpQuanLyDichVu
            // 
            this._rbpQuanLyDichVu.Items.Add(this._rbbNhomdichvu);
            this._rbpQuanLyDichVu.Items.Add(this._rbbDichvu);
            this._rbpQuanLyDichVu.Text = "Quản lý dịch vụ";
            // 
            // _rbbNhomdichvu
            // 
            this._rbbNhomdichvu.Image = global::GUI.Resource.Hospital_icon;
            this._rbbNhomdichvu.MinimumSize = new System.Drawing.Size(100, 0);
            this._rbbNhomdichvu.SmallImage = ((System.Drawing.Image)(resources.GetObject("_rbbNhomdichvu.SmallImage")));
            this._rbbNhomdichvu.Text = "Nhóm dịch vụ";
            this._rbbNhomdichvu.Click += new System.EventHandler(this._rbbNhomdichvu_Click);
            // 
            // _rbbDichvu
            // 
            this._rbbDichvu.Image = global::GUI.Resource.Service_icon;
            this._rbbDichvu.MinimumSize = new System.Drawing.Size(100, 0);
            this._rbbDichvu.SmallImage = ((System.Drawing.Image)(resources.GetObject("_rbbDichvu.SmallImage")));
            this._rbbDichvu.Text = "Dịch vụ";
            this._rbbDichvu.Click += new System.EventHandler(this._rbbDichvu_Click);
            // 
            // _rbtQuanlythungan
            // 
            this._rbtQuanlythungan.Panels.Add(this._rbpQuanlyHoadon);
            this._rbtQuanlythungan.Text = "Quản lý thu ngân";
            // 
            // _rbpQuanlyHoadon
            // 
            this._rbpQuanlyHoadon.Items.Add(this._rbbLaphoadon);
            this._rbpQuanlyHoadon.Items.Add(this._rbbThutien);
            this._rbpQuanlyHoadon.Text = "Quản lý thu ngân";
            // 
            // _rbbLaphoadon
            // 
            this._rbbLaphoadon.Image = global::GUI.Resource.invoice_icon;
            this._rbbLaphoadon.MinimumSize = new System.Drawing.Size(100, 0);
            this._rbbLaphoadon.SmallImage = ((System.Drawing.Image)(resources.GetObject("_rbbLaphoadon.SmallImage")));
            this._rbbLaphoadon.Text = "Lập hóa đơn";
            this._rbbLaphoadon.Click += new System.EventHandler(this.rbbLaphoadon_Click);
            // 
            // _rbbThutien
            // 
            this._rbbThutien.Image = global::GUI.Resource.Cash_register_icon;
            this._rbbThutien.MinimumSize = new System.Drawing.Size(100, 0);
            this._rbbThutien.SmallImage = ((System.Drawing.Image)(resources.GetObject("_rbbThutien.SmallImage")));
            this._rbbThutien.Text = "Thu tiền";
            this._rbbThutien.Click += new System.EventHandler(this.rbbThutien_Click);
            // 
            // _rbtThongKeBaoCao
            // 
            this._rbtThongKeBaoCao.Panels.Add(this._rbpDanhSachBienLai);
            this._rbtThongKeBaoCao.Panels.Add(this._rbpDanhSachThuTien);
            this._rbtThongKeBaoCao.Panels.Add(this._rbpThongKe);
            this._rbtThongKeBaoCao.Text = "Thống kê báo cáo";
            // 
            // _rbpDanhSachBienLai
            // 
            this._rbpDanhSachBienLai.Items.Add(this._rbbBaoCaoNhapLieu);
            this._rbpDanhSachBienLai.Items.Add(this._rbbBaoCaoThuTien);
            this._rbpDanhSachBienLai.Text = "Danh sách các biên lai";
            // 
            // _rbbBaoCaoNhapLieu
            // 
            this._rbbBaoCaoNhapLieu.Image = global::GUI.Resource.medical_report_icon;
            this._rbbBaoCaoNhapLieu.MinimumSize = new System.Drawing.Size(80, 0);
            this._rbbBaoCaoNhapLieu.SmallImage = ((System.Drawing.Image)(resources.GetObject("_rbbBaoCaoNhapLieu.SmallImage")));
            this._rbbBaoCaoNhapLieu.Text = "Nhân viên nhập liệu";
            this._rbbBaoCaoNhapLieu.Click += new System.EventHandler(this.ribbonButton4_Click);
            // 
            // _rbbBaoCaoThuTien
            // 
            this._rbbBaoCaoThuTien.Image = global::GUI.Resource.medical_report_icon;
            this._rbbBaoCaoThuTien.MinimumSize = new System.Drawing.Size(80, 0);
            this._rbbBaoCaoThuTien.SmallImage = ((System.Drawing.Image)(resources.GetObject("_rbbBaoCaoThuTien.SmallImage")));
            this._rbbBaoCaoThuTien.Text = "Nhân viên thu tiền";
            this._rbbBaoCaoThuTien.Click += new System.EventHandler(this.ribbonButton6_Click);
            // 
            // _rbpDanhSachThuTien
            // 
            this._rbpDanhSachThuTien.Items.Add(this._rbbBaoCaoBenhNhan);
            this._rbpDanhSachThuTien.Text = "Danh sách thu tiền";
            // 
            // _rbbBaoCaoBenhNhan
            // 
            this._rbbBaoCaoBenhNhan.Image = global::GUI.Resource.medical_report_icon;
            this._rbbBaoCaoBenhNhan.MinimumSize = new System.Drawing.Size(90, 0);
            this._rbbBaoCaoBenhNhan.SmallImage = ((System.Drawing.Image)(resources.GetObject("_rbbBaoCaoBenhNhan.SmallImage")));
            this._rbbBaoCaoBenhNhan.Text = "Bệnh nhân";
            this._rbbBaoCaoBenhNhan.Click += new System.EventHandler(this.ribbonButton7_Click);
            // 
            // _rbpThongKe
            // 
            this._rbpThongKe.Items.Add(this._rbbDoanhThu);
            this._rbpThongKe.Text = "Thống kê";
            // 
            // _rbbDoanhThu
            // 
            this._rbbDoanhThu.Image = global::GUI.Resource.SEO_icon;
            this._rbbDoanhThu.MinimumSize = new System.Drawing.Size(100, 0);
            this._rbbDoanhThu.SmallImage = ((System.Drawing.Image)(resources.GetObject("_rbbDoanhThu.SmallImage")));
            this._rbbDoanhThu.Text = "Doanh thu";
            this._rbbDoanhThu.Click += new System.EventHandler(this.ribbonButton8_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Text = "Thống kê";
            // 
            // rbpBaocao
            // 
            this.rbpBaocao.Text = "Danh sách các biên lai";
            // 
            // rbtBaocaothongke
            // 
            this.rbtBaocaothongke.Panels.Add(this.rbpBaocao);
            this.rbtBaocaothongke.Panels.Add(this.ribbonPanel2);
            this.rbtBaocaothongke.Text = "Báo cáo thống kê";
            // 
            // rbpThongke
            // 
            this.rbpThongke.Items.Add(this.rbtQuanlythongke);
            this.rbpThongke.Text = "Danh sách thu tiền";
            // 
            // rbtQuanlythongke
            // 
            this.rbtQuanlythongke.Image = global::GUI.Resource.medical_report_icon;
            this.rbtQuanlythongke.MinimumSize = new System.Drawing.Size(100, 0);
            this.rbtQuanlythongke.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtQuanlythongke.SmallImage")));
            this.rbtQuanlythongke.Text = "Bệnh nhân";
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = global::GUI.Resource.SEO_icon;
            this.ribbonButton3.MinimumSize = new System.Drawing.Size(80, 0);
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "Doanh thu";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = global::GUI.Resource.Pie_chart_icon;
            this.ribbonButton2.MinimumSize = new System.Drawing.Size(80, 0);
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "Nhân viên thu tiền";
            // 
            // rbbBaocao
            // 
            this.rbbBaocao.Image = global::GUI.Resource.Pie_chart_icon;
            this.rbbBaocao.MinimumSize = new System.Drawing.Size(80, 0);
            this.rbbBaocao.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbbBaocao.SmallImage")));
            this.rbbBaocao.Text = "Nhân viên nhập liệu";
            // 
            // pnlMain
            // 
            this.pnlMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 157);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(834, 525);
            this.pnlMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlMain.Style.GradientAngle = 90;
            this.pnlMain.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(834, 682);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.rbbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon rbbMain;
        private System.Windows.Forms.RibbonOrbMenuItem _rbiThongtintaikhoan;
        private System.Windows.Forms.RibbonOrbMenuItem _rbiChangePass;
        private System.Windows.Forms.RibbonOrbMenuItem _rbiThoat;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonTab _rbtQuantrihethong;
        private System.Windows.Forms.RibbonPanel _rbpQuanlytaiKhoan;
        private System.Windows.Forms.RibbonButton _rbbNhomNguoiDung;
        private System.Windows.Forms.RibbonTab _rbtQuanlythungan;
        private System.Windows.Forms.RibbonPanel _rbpQuanlyHoadon;
        private System.Windows.Forms.RibbonButton _rbbLaphoadon;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem2;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem3;
        private System.Windows.Forms.RibbonButton _rbbNguoiDung;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem4;
        private System.Windows.Forms.RibbonTab _rbtThongKeBaoCao;
        private System.Windows.Forms.RibbonPanel _rbpDanhSachBienLai;
        private System.Windows.Forms.RibbonButton _rbbBaoCaoNhapLieu;
        private System.Windows.Forms.RibbonButton _rbbBaoCaoThuTien;
        private System.Windows.Forms.RibbonPanel _rbpDanhSachThuTien;
        private System.Windows.Forms.RibbonButton _rbbBaoCaoBenhNhan;
        private System.Windows.Forms.RibbonPanel _rbpThongKe;
        private System.Windows.Forms.RibbonButton _rbbDoanhThu;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonPanel rbpBaocao;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton rbbBaocao;
        private System.Windows.Forms.RibbonTab rbtBaocaothongke;
        private System.Windows.Forms.RibbonButton rbtQuanlythongke;
        private System.Windows.Forms.RibbonPanel rbpThongke;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.RibbonButton _rbbPhanQuyen;
        private System.Windows.Forms.RibbonPanel _rbpQuanLyPhongBan;
        private System.Windows.Forms.RibbonButton _rbbLoaiPhongBan;
        private System.Windows.Forms.RibbonButton _rbbPhongban;
        private System.Windows.Forms.RibbonPanel _rbpQuanLyDichVu;
        private System.Windows.Forms.RibbonButton _rbbNhomdichvu;
        private System.Windows.Forms.RibbonButton _rbbDichvu;
        private System.Windows.Forms.RibbonButton _rbbThutien;
        private DevComponents.DotNetBar.PanelEx pnlMain;
    }
}

