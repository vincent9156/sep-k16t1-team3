namespace GUI
{
    partial class ucPhanquyen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlNhomnguoidung = new DevComponents.DotNetBar.PanelEx();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblphanquyen = new DevComponents.DotNetBar.LabelX();
            this.lblNhomnguoidung = new DevComponents.DotNetBar.LabelX();
            this._cboNhomNguoiDung = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this._btnThietLap = new DevComponents.DotNetBar.ButtonX();
            this.pnlControl = new DevComponents.DotNetBar.PanelEx();
            this._grdChucNang = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._gTenChucnang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlNhomnguoidung.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grdChucNang)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNhomnguoidung
            // 
            this.pnlNhomnguoidung.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlNhomnguoidung.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlNhomnguoidung.Controls.Add(this.textBox1);
            this.pnlNhomnguoidung.Controls.Add(this.lblphanquyen);
            this.pnlNhomnguoidung.Controls.Add(this.lblNhomnguoidung);
            this.pnlNhomnguoidung.Controls.Add(this._cboNhomNguoiDung);
            this.pnlNhomnguoidung.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhomnguoidung.Location = new System.Drawing.Point(0, 0);
            this.pnlNhomnguoidung.Name = "pnlNhomnguoidung";
            this.pnlNhomnguoidung.Size = new System.Drawing.Size(838, 82);
            this.pnlNhomnguoidung.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlNhomnguoidung.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlNhomnguoidung.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlNhomnguoidung.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlNhomnguoidung.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlNhomnguoidung.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlNhomnguoidung.Style.GradientAngle = 90;
            this.pnlNhomnguoidung.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(485, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblphanquyen
            // 
            this.lblphanquyen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            // 
            // 
            // 
            this.lblphanquyen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblphanquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphanquyen.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblphanquyen.Location = new System.Drawing.Point(307, 2);
            this.lblphanquyen.Name = "lblphanquyen";
            this.lblphanquyen.Size = new System.Drawing.Size(393, 44);
            this.lblphanquyen.TabIndex = 3;
            this.lblphanquyen.Text = "PHÂN QUYỀN SỬ DỤNG";
            // 
            // lblNhomnguoidung
            // 
            // 
            // 
            // 
            this.lblNhomnguoidung.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNhomnguoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhomnguoidung.Location = new System.Drawing.Point(7, 52);
            this.lblNhomnguoidung.Name = "lblNhomnguoidung";
            this.lblNhomnguoidung.Size = new System.Drawing.Size(134, 23);
            this.lblNhomnguoidung.TabIndex = 1;
            this.lblNhomnguoidung.Text = "Nhóm người dùng";
            // 
            // _cboNhomNguoiDung
            // 
            this._cboNhomNguoiDung.DisplayMember = "Text";
            this._cboNhomNguoiDung.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._cboNhomNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cboNhomNguoiDung.FormattingEnabled = true;
            this._cboNhomNguoiDung.ItemHeight = 20;
            this._cboNhomNguoiDung.Location = new System.Drawing.Point(147, 50);
            this._cboNhomNguoiDung.Name = "_cboNhomNguoiDung";
            this._cboNhomNguoiDung.Size = new System.Drawing.Size(224, 26);
            this._cboNhomNguoiDung.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._cboNhomNguoiDung.TabIndex = 0;
            this._cboNhomNguoiDung.SelectedIndexChanged += new System.EventHandler(this._cboNhomNguoiDung_SelectedIndexChanged);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this._btnThietLap);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx2.Location = new System.Drawing.Point(0, 461);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(838, 46);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // _btnThietLap
            // 
            this._btnThietLap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnThietLap.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnThietLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnThietLap.Location = new System.Drawing.Point(605, 5);
            this._btnThietLap.Name = "_btnThietLap";
            this._btnThietLap.Size = new System.Drawing.Size(161, 37);
            this._btnThietLap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnThietLap.TabIndex = 0;
            this._btnThietLap.Text = "Thiết lập";
            this._btnThietLap.Click += new System.EventHandler(this._btnThietLap_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlControl.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlControl.Controls.Add(this._grdChucNang);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControl.Location = new System.Drawing.Point(0, 82);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(838, 379);
            this.pnlControl.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlControl.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlControl.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlControl.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlControl.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlControl.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlControl.Style.GradientAngle = 90;
            this.pnlControl.TabIndex = 2;
            // 
            // _grdChucNang
            // 
            this._grdChucNang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grdChucNang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._grdChucNang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grdChucNang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this._gTenChucnang,
            this.Column4,
            this.MaNhom});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grdChucNang.DefaultCellStyle = dataGridViewCellStyle2;
            this._grdChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grdChucNang.EnableHeadersVisualStyles = false;
            this._grdChucNang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this._grdChucNang.Location = new System.Drawing.Point(0, 0);
            this._grdChucNang.Name = "_grdChucNang";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grdChucNang.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._grdChucNang.Size = new System.Drawing.Size(838, 379);
            this._grdChucNang.TabIndex = 0;
            this._grdChucNang.SelectionChanged += new System.EventHandler(this._grdChucNang_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "_MaChucNang";
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // _gTenChucnang
            // 
            this._gTenChucnang.DataPropertyName = "_TenChucNang";
            this._gTenChucnang.HeaderText = "Tên phân hệ";
            this._gTenChucnang.Name = "_gTenChucnang";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "_TrangThai";
            this.Column4.FillWeight = 120F;
            this.Column4.HeaderText = "Phân quyền";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.ToolTipText = "Chọn quyền cho nhóm";
            this.Column4.Width = 120;
            // 
            // MaNhom
            // 
            this.MaNhom.DataPropertyName = "_MaNhom";
            this.MaNhom.HeaderText = "MaNhom";
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.Visible = false;
            // 
            // ucPhanquyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.pnlNhomnguoidung);
            this.Name = "ucPhanquyen";
            this.Size = new System.Drawing.Size(838, 507);
            this.Load += new System.EventHandler(this.ucPhanquyen_Load);
            this.pnlNhomnguoidung.ResumeLayout(false);
            this.pnlNhomnguoidung.PerformLayout();
            this.panelEx2.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grdChucNang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnlNhomnguoidung;
        private DevComponents.DotNetBar.LabelX lblNhomnguoidung;
        private DevComponents.DotNetBar.Controls.ComboBoxEx _cboNhomNguoiDung;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.ButtonX _btnThietLap;
        private DevComponents.DotNetBar.PanelEx pnlControl;
        private DevComponents.DotNetBar.Controls.DataGridViewX _grdChucNang;
        private DevComponents.DotNetBar.LabelX lblphanquyen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn _gTenChucnang;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
    }
}
