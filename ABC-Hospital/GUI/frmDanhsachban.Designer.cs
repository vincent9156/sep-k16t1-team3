namespace GUI
{
    partial class frmDanhsachban
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhsachban));
            this._panTitle = new DevComponents.DotNetBar.PanelEx();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._grdDSBan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._btnSua = new DevComponents.DotNetBar.ButtonX();
            this._btnLuu = new DevComponents.DotNetBar.ButtonX();
            this._btnThem = new DevComponents.DotNetBar.ButtonX();
            this._chkTrangThai = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this._tbxMoTa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this._txtBanSo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this._btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._grdDSBan)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panTitle
            // 
            this._panTitle.CanvasColor = System.Drawing.SystemColors.Control;
            this._panTitle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._panTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this._panTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._panTitle.Location = new System.Drawing.Point(0, 0);
            this._panTitle.Name = "_panTitle";
            this._panTitle.Size = new System.Drawing.Size(664, 42);
            this._panTitle.Style.Alignment = System.Drawing.StringAlignment.Center;
            this._panTitle.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this._panTitle.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this._panTitle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this._panTitle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this._panTitle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this._panTitle.Style.GradientAngle = 90;
            this._panTitle.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._grdDSBan);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelEx2);
            this.splitContainer1.Size = new System.Drawing.Size(664, 364);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 1;
            // 
            // _grdDSBan
            // 
            this._grdDSBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._grdDSBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grdDSBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grdDSBan.DefaultCellStyle = dataGridViewCellStyle1;
            this._grdDSBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grdDSBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this._grdDSBan.Location = new System.Drawing.Point(0, 0);
            this._grdDSBan.Name = "_grdDSBan";
            this._grdDSBan.Size = new System.Drawing.Size(386, 364);
            this._grdDSBan.TabIndex = 0;
            this._grdDSBan.SelectionChanged += new System.EventHandler(this._grdChiTietBan_SelectionChanged);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.groupPanel1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(274, 364);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this._btnHuy);
            this.groupPanel1.Controls.Add(this._btnSua);
            this.groupPanel1.Controls.Add(this._btnLuu);
            this.groupPanel1.Controls.Add(this._btnThem);
            this.groupPanel1.Controls.Add(this._chkTrangThai);
            this.groupPanel1.Controls.Add(this._tbxMoTa);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this._txtBanSo);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DrawTitleBox = false;
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(7, 62);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(260, 290);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Thông tin chi tiết";
            // 
            // _btnSua
            // 
            this._btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSua.Image = global::GUI.Resource.Pencil_icon;
            this._btnSua.Location = new System.Drawing.Point(64, 194);
            this._btnSua.Name = "_btnSua";
            this._btnSua.Size = new System.Drawing.Size(60, 33);
            this._btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnSua.TabIndex = 38;
            this._btnSua.Text = "Sửa";
            this._btnSua.Click += new System.EventHandler(this._btnSua_Click);
            // 
            // _btnLuu
            // 
            this._btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnLuu.Image = global::GUI.Resource.Save_icon;
            this._btnLuu.Location = new System.Drawing.Point(128, 194);
            this._btnLuu.Name = "_btnLuu";
            this._btnLuu.Size = new System.Drawing.Size(60, 33);
            this._btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnLuu.TabIndex = 40;
            this._btnLuu.Text = "Lưu";
            this._btnLuu.Click += new System.EventHandler(this._btnLuu_Click);
            // 
            // _btnThem
            // 
            this._btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnThem.Image = ((System.Drawing.Image)(resources.GetObject("_btnThem.Image")));
            this._btnThem.Location = new System.Drawing.Point(1, 194);
            this._btnThem.Name = "_btnThem";
            this._btnThem.Size = new System.Drawing.Size(60, 33);
            this._btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnThem.TabIndex = 39;
            this._btnThem.Text = "Thêm";
            this._btnThem.Click += new System.EventHandler(this._btnThem_Click);
            // 
            // _chkTrangThai
            // 
            // 
            // 
            // 
            this._chkTrangThai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._chkTrangThai.Location = new System.Drawing.Point(12, 154);
            this._chkTrangThai.Name = "_chkTrangThai";
            this._chkTrangThai.Size = new System.Drawing.Size(100, 23);
            this._chkTrangThai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._chkTrangThai.TabIndex = 2;
            this._chkTrangThai.Text = "Trạng thái";
            // 
            // _tbxMoTa
            // 
            // 
            // 
            // 
            this._tbxMoTa.Border.Class = "TextBoxBorder";
            this._tbxMoTa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._tbxMoTa.Location = new System.Drawing.Point(12, 76);
            this._tbxMoTa.Multiline = true;
            this._tbxMoTa.Name = "_tbxMoTa";
            this._tbxMoTa.Size = new System.Drawing.Size(190, 72);
            this._tbxMoTa.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 47);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(50, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Mô tả";
            // 
            // _txtBanSo
            // 
            // 
            // 
            // 
            this._txtBanSo.Border.Class = "TextBoxBorder";
            this._txtBanSo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._txtBanSo.Enabled = false;
            this._txtBanSo.Location = new System.Drawing.Point(76, 15);
            this._txtBanSo.Name = "_txtBanSo";
            this._txtBanSo.Size = new System.Drawing.Size(62, 26);
            this._txtBanSo.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(50, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Bàn số";
            // 
            // _btnHuy
            // 
            this._btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnHuy.Image = global::GUI.Resource.Close_2_icon;
            this._btnHuy.Location = new System.Drawing.Point(192, 194);
            this._btnHuy.Name = "_btnHuy";
            this._btnHuy.Size = new System.Drawing.Size(60, 33);
            this._btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnHuy.TabIndex = 41;
            this._btnHuy.Text = "Hủy";
            this._btnHuy.Click += new System.EventHandler(this._btnHuy_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "_MaBan";
            this.Column1.HeaderText = "Bàn số";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "_MoTa";
            this.Column2.HeaderText = "Mô tả";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.Checked = true;
            this.Column3.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Column3.CheckValue = null;
            this.Column3.DataPropertyName = "_TrangThai";
            this.Column3.HeaderText = "Trạng thái";
            this.Column3.Name = "Column3";
            // 
            // frmDanhsachban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 406);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this._panTitle);
            this.Name = "frmDanhsachban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDanhsachban";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._grdDSBan)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx _panTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.Controls.DataGridViewX _grdDSBan;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX _tbxMoTa;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX _txtBanSo;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX _chkTrangThai;
        private DevComponents.DotNetBar.ButtonX _btnSua;
        private DevComponents.DotNetBar.ButtonX _btnLuu;
        private DevComponents.DotNetBar.ButtonX _btnThem;
        private DevComponents.DotNetBar.ButtonX _btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn Column3;
    }
}