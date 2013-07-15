namespace GUI
{
    partial class frmChonnhanvien
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
            this.pnlLuachonvaitro = new DevComponents.DotNetBar.PanelEx();
            this._cboChonnhanvien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this._btnXacnhan = new DevComponents.DotNetBar.ButtonX();
            this.pnlLuachonvitri = new DevComponents.DotNetBar.PanelEx();
            this._btnLuachon = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this._cboChonBan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this._cboChonPhong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.pnlLuachonvaitro.SuspendLayout();
            this.pnlLuachonvitri.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLuachonvaitro
            // 
            this.pnlLuachonvaitro.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlLuachonvaitro.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlLuachonvaitro.Controls.Add(this._cboChonnhanvien);
            this.pnlLuachonvaitro.Controls.Add(this.labelX1);
            this.pnlLuachonvaitro.Controls.Add(this._btnXacnhan);
            this.pnlLuachonvaitro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLuachonvaitro.Location = new System.Drawing.Point(0, 0);
            this.pnlLuachonvaitro.Name = "pnlLuachonvaitro";
            this.pnlLuachonvaitro.Size = new System.Drawing.Size(408, 96);
            this.pnlLuachonvaitro.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlLuachonvaitro.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlLuachonvaitro.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlLuachonvaitro.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlLuachonvaitro.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlLuachonvaitro.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlLuachonvaitro.Style.GradientAngle = 90;
            this.pnlLuachonvaitro.TabIndex = 0;
            // 
            // _cboChonnhanvien
            // 
            this._cboChonnhanvien.DisplayMember = "Text";
            this._cboChonnhanvien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._cboChonnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboChonnhanvien.FormattingEnabled = true;
            this._cboChonnhanvien.ItemHeight = 20;
            this._cboChonnhanvien.Location = new System.Drawing.Point(22, 56);
            this._cboChonnhanvien.Name = "_cboChonnhanvien";
            this._cboChonnhanvien.Size = new System.Drawing.Size(283, 26);
            this._cboChonnhanvien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._cboChonnhanvien.TabIndex = 6;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(22, 27);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(136, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Chọn nhân viên";
            // 
            // _btnXacnhan
            // 
            this._btnXacnhan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnXacnhan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnXacnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnXacnhan.Location = new System.Drawing.Point(321, 56);
            this._btnXacnhan.Name = "_btnXacnhan";
            this._btnXacnhan.Size = new System.Drawing.Size(75, 23);
            this._btnXacnhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnXacnhan.TabIndex = 4;
            this._btnXacnhan.Text = "Xác nhận";
            this._btnXacnhan.Click += new System.EventHandler(this._btnXacnhan_Click);
            // 
            // pnlLuachonvitri
            // 
            this.pnlLuachonvitri.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlLuachonvitri.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlLuachonvitri.Controls.Add(this._btnLuachon);
            this.pnlLuachonvitri.Controls.Add(this.labelX3);
            this.pnlLuachonvitri.Controls.Add(this._cboChonBan);
            this.pnlLuachonvitri.Controls.Add(this.labelX2);
            this.pnlLuachonvitri.Controls.Add(this._cboChonPhong);
            this.pnlLuachonvitri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLuachonvitri.Enabled = false;
            this.pnlLuachonvitri.Location = new System.Drawing.Point(0, 96);
            this.pnlLuachonvitri.Name = "pnlLuachonvitri";
            this.pnlLuachonvitri.Size = new System.Drawing.Size(408, 107);
            this.pnlLuachonvitri.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlLuachonvitri.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlLuachonvitri.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlLuachonvitri.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlLuachonvitri.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlLuachonvitri.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlLuachonvitri.Style.GradientAngle = 90;
            this.pnlLuachonvitri.TabIndex = 1;
            // 
            // _btnLuachon
            // 
            this._btnLuachon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnLuachon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnLuachon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnLuachon.Location = new System.Drawing.Point(321, 57);
            this._btnLuachon.Name = "_btnLuachon";
            this._btnLuachon.Size = new System.Drawing.Size(75, 23);
            this._btnLuachon.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnLuachon.TabIndex = 7;
            this._btnLuachon.Text = "Lựa chọn";
            this._btnLuachon.Click += new System.EventHandler(this._btnLuachon_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(19, 60);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Chọn bàn";
            // 
            // _cboChonBan
            // 
            this._cboChonBan.DisplayMember = "Text";
            this._cboChonBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._cboChonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboChonBan.FormattingEnabled = true;
            this._cboChonBan.ItemHeight = 20;
            this._cboChonBan.Location = new System.Drawing.Point(119, 57);
            this._cboChonBan.Name = "_cboChonBan";
            this._cboChonBan.Size = new System.Drawing.Size(186, 26);
            this._cboChonBan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._cboChonBan.TabIndex = 5;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(19, 22);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(99, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Chọn phòng";
            // 
            // _cboChonPhong
            // 
            this._cboChonPhong.DisplayMember = "Text";
            this._cboChonPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._cboChonPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboChonPhong.FormattingEnabled = true;
            this._cboChonPhong.ItemHeight = 20;
            this._cboChonPhong.Location = new System.Drawing.Point(119, 25);
            this._cboChonPhong.Name = "_cboChonPhong";
            this._cboChonPhong.Size = new System.Drawing.Size(186, 26);
            this._cboChonPhong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._cboChonPhong.TabIndex = 3;
            this._cboChonPhong.SelectedIndexChanged += new System.EventHandler(this._cboChonPhong_SelectedIndexChanged);
            // 
            // frmChonnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 203);
            this.Controls.Add(this.pnlLuachonvitri);
            this.Controls.Add(this.pnlLuachonvaitro);
            this.Name = "frmChonnhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vị trí làm việc";
            this.pnlLuachonvaitro.ResumeLayout(false);
            this.pnlLuachonvitri.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnlLuachonvaitro;
        private DevComponents.DotNetBar.Controls.ComboBoxEx _cboChonnhanvien;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX _btnXacnhan;
        private DevComponents.DotNetBar.PanelEx pnlLuachonvitri;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx _cboChonPhong;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx _cboChonBan;
        private DevComponents.DotNetBar.ButtonX _btnLuachon;

    }
}