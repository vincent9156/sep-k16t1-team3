namespace GUI
{
    partial class frmDangNhap
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
            this._lblTenTaiKhoan = new DevComponents.DotNetBar.LabelX();
            this._btnDangNhap = new DevComponents.DotNetBar.ButtonX();
            this._txtTenTaiKhoan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._lblMatkhau = new DevComponents.DotNetBar.LabelX();
            this._txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._btnThoat = new DevComponents.DotNetBar.ButtonX();
            this._lblLogo = new System.Windows.Forms.PictureBox();
            this._lblTieuDe = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this._lblLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblTenTaiKhoan
            // 
            // 
            // 
            // 
            this._lblTenTaiKhoan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._lblTenTaiKhoan.Location = new System.Drawing.Point(25, 83);
            this._lblTenTaiKhoan.Name = "_lblTenTaiKhoan";
            this._lblTenTaiKhoan.Size = new System.Drawing.Size(75, 23);
            this._lblTenTaiKhoan.TabIndex = 0;
            this._lblTenTaiKhoan.Text = "Tên tài khoản";
            // 
            // _btnDangNhap
            // 
            this._btnDangNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnDangNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnDangNhap.Location = new System.Drawing.Point(73, 146);
            this._btnDangNhap.Name = "_btnDangNhap";
            this._btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this._btnDangNhap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnDangNhap.TabIndex = 2;
            this._btnDangNhap.Text = "Đăng nhập";
            this._btnDangNhap.Click += new System.EventHandler(this._btnDangNhap_Click);
            // 
            // _txtTenTaiKhoan
            // 
            // 
            // 
            // 
            this._txtTenTaiKhoan.Border.Class = "TextBoxBorder";
            this._txtTenTaiKhoan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._txtTenTaiKhoan.Location = new System.Drawing.Point(106, 86);
            this._txtTenTaiKhoan.Name = "_txtTenTaiKhoan";
            this._txtTenTaiKhoan.Size = new System.Drawing.Size(167, 20);
            this._txtTenTaiKhoan.TabIndex = 0;
            this._txtTenTaiKhoan.Enter += new System.EventHandler(this._txtTenTaiKhoan_Enter);
            // 
            // _lblMatkhau
            // 
            // 
            // 
            // 
            this._lblMatkhau.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._lblMatkhau.Location = new System.Drawing.Point(25, 112);
            this._lblMatkhau.Name = "_lblMatkhau";
            this._lblMatkhau.Size = new System.Drawing.Size(75, 23);
            this._lblMatkhau.TabIndex = 0;
            this._lblMatkhau.Text = "Mật khẩu";
            // 
            // _txtMatKhau
            // 
            // 
            // 
            // 
            this._txtMatKhau.Border.Class = "TextBoxBorder";
            this._txtMatKhau.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._txtMatKhau.Location = new System.Drawing.Point(106, 109);
            this._txtMatKhau.Name = "_txtMatKhau";
            this._txtMatKhau.Size = new System.Drawing.Size(167, 20);
            this._txtMatKhau.TabIndex = 1;
            this._txtMatKhau.Enter += new System.EventHandler(this._txtMatKhau_Enter);
            // 
            // _btnThoat
            // 
            this._btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnThoat.Location = new System.Drawing.Point(177, 146);
            this._btnThoat.Name = "_btnThoat";
            this._btnThoat.Size = new System.Drawing.Size(75, 23);
            this._btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnThoat.TabIndex = 3;
            this._btnThoat.Text = "Thoát";
            this._btnThoat.Click += new System.EventHandler(this._btnThoat_Click);
            // 
            // _lblLogo
            // 
            this._lblLogo.Image = global::GUI.Properties.Resources.childrens_hospital_logo;
            this._lblLogo.Location = new System.Drawing.Point(25, 9);
            this._lblLogo.Name = "_lblLogo";
            this._lblLogo.Size = new System.Drawing.Size(63, 57);
            this._lblLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._lblLogo.TabIndex = 3;
            this._lblLogo.TabStop = false;
            // 
            // _lblTieuDe
            // 
            // 
            // 
            // 
            this._lblTieuDe.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._lblTieuDe.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this._lblTieuDe.Location = new System.Drawing.Point(94, 9);
            this._lblTieuDe.Name = "_lblTieuDe";
            this._lblTieuDe.Size = new System.Drawing.Size(202, 68);
            this._lblTieuDe.TabIndex = 0;
            this._lblTieuDe.Text = "ABC HEALTH";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 182);
            this.Controls.Add(this._lblLogo);
            this.Controls.Add(this._txtMatKhau);
            this.Controls.Add(this._txtTenTaiKhoan);
            this.Controls.Add(this._lblMatkhau);
            this.Controls.Add(this._btnThoat);
            this.Controls.Add(this._btnDangNhap);
            this.Controls.Add(this._lblTieuDe);
            this.Controls.Add(this._lblTenTaiKhoan);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this._lblLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX _lblTenTaiKhoan;
        private DevComponents.DotNetBar.ButtonX _btnDangNhap;
        private DevComponents.DotNetBar.Controls.TextBoxX _txtTenTaiKhoan;
        private DevComponents.DotNetBar.LabelX _lblMatkhau;
        private DevComponents.DotNetBar.Controls.TextBoxX _txtMatKhau;
        private DevComponents.DotNetBar.ButtonX _btnThoat;
        private System.Windows.Forms.PictureBox _lblLogo;
        private DevComponents.DotNetBar.LabelX _lblTieuDe;
    }
}