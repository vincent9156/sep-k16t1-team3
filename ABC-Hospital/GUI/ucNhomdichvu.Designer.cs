﻿namespace GUI
{
    partial class ucNhomdichvu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNhomdichvu));
            this._grdNhomDichVu = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this._chkTrangthai = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.pnlTieude = new DevComponents.DotNetBar.PanelEx();
            this.lblThanhpho = new DevComponents.DotNetBar.LabelX();
            this.lblDatetime = new DevComponents.DotNetBar.LabelX();
            this._txtTennhom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblTennhom = new DevComponents.DotNetBar.LabelX();
            this.lblMaso = new DevComponents.DotNetBar.LabelX();
            this.taiDanhmucthanhpho = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpThongtinchitiet = new DevComponents.DotNetBar.Controls.GroupPanel();
            this._btnSua = new DevComponents.DotNetBar.ButtonX();
            this._btnLuu = new DevComponents.DotNetBar.ButtonX();
            this._btnThem = new DevComponents.DotNetBar.ButtonX();
            this._txtmanhomdichvu = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._tbxMota = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblMota = new DevComponents.DotNetBar.LabelX();
            this.tcDanhmucThanhpho = new DevComponents.DotNetBar.TabControl();
            this.pnlArea2 = new DevComponents.DotNetBar.PanelEx();
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this._txtTimkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._lblTimkiem = new DevComponents.DotNetBar.LabelX();
            this._txtTimmaso = new DevComponents.DotNetBar.Controls.TextBoxX();
            this._lblTimmaso = new DevComponents.DotNetBar.LabelX();
            this._btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            ((System.ComponentModel.ISupportInitialize)(this._grdNhomDichVu)).BeginInit();
            this.pnlTieude.SuspendLayout();
            this.gpThongtinchitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcDanhmucThanhpho)).BeginInit();
            this.tcDanhmucThanhpho.SuspendLayout();
            this.pnlArea2.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _grdNhomDichVu
            // 
            this._grdNhomDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grdNhomDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._grdNhomDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._grdNhomDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Ten,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._grdNhomDichVu.DefaultCellStyle = dataGridViewCellStyle2;
            this._grdNhomDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grdNhomDichVu.EnableHeadersVisualStyles = false;
            this._grdNhomDichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this._grdNhomDichVu.Location = new System.Drawing.Point(0, 44);
            this._grdNhomDichVu.Name = "_grdNhomDichVu";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._grdNhomDichVu.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._grdNhomDichVu.Size = new System.Drawing.Size(513, 423);
            this._grdNhomDichVu.TabIndex = 1;
            this._grdNhomDichVu.SelectionChanged += new System.EventHandler(this._grdNhomDichVu_SelectionChanged);
            // 
            // _chkTrangthai
            // 
            // 
            // 
            // 
            this._chkTrangthai.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._chkTrangthai.Location = new System.Drawing.Point(0, 237);
            this._chkTrangthai.Name = "_chkTrangthai";
            this._chkTrangthai.Size = new System.Drawing.Size(117, 23);
            this._chkTrangthai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._chkTrangthai.TabIndex = 32;
            this._chkTrangthai.Text = "Trạng thái SD";
            // 
            // pnlTieude
            // 
            this.pnlTieude.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlTieude.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlTieude.Controls.Add(this.lblThanhpho);
            this.pnlTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieude.Location = new System.Drawing.Point(1, 1);
            this.pnlTieude.Name = "pnlTieude";
            this.pnlTieude.Size = new System.Drawing.Size(836, 38);
            this.pnlTieude.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlTieude.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlTieude.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlTieude.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlTieude.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlTieude.Style.GradientAngle = 90;
            this.pnlTieude.TabIndex = 3;
            // 
            // lblThanhpho
            // 
            this.lblThanhpho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblThanhpho.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblThanhpho.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhpho.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblThanhpho.Location = new System.Drawing.Point(299, -6);
            this.lblThanhpho.Name = "lblThanhpho";
            this.lblThanhpho.Size = new System.Drawing.Size(393, 44);
            this.lblThanhpho.TabIndex = 2;
            this.lblThanhpho.Text = "QUẢN LÝ NHÓM DỊCH VỤ";
            // 
            // lblDatetime
            // 
            // 
            // 
            // 
            this.lblDatetime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatetime.Location = new System.Drawing.Point(95, 21);
            this.lblDatetime.Name = "lblDatetime";
            this.lblDatetime.Size = new System.Drawing.Size(152, 23);
            this.lblDatetime.TabIndex = 3;
            this.lblDatetime.Text = "Thứ 4, ngày 19/06/2013";
            // 
            // _txtTennhom
            // 
            this._txtTennhom.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this._txtTennhom.Border.Class = "TextBoxBorder";
            this._txtTennhom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._txtTennhom.ForeColor = System.Drawing.Color.Black;
            this._txtTennhom.Location = new System.Drawing.Point(76, 53);
            this._txtTennhom.Name = "_txtTennhom";
            this._txtTennhom.Size = new System.Drawing.Size(213, 26);
            this._txtTennhom.TabIndex = 31;
            // 
            // lblTennhom
            // 
            this.lblTennhom.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTennhom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTennhom.Location = new System.Drawing.Point(-1, 50);
            this.lblTennhom.Name = "lblTennhom";
            this.lblTennhom.Size = new System.Drawing.Size(104, 23);
            this.lblTennhom.TabIndex = 23;
            this.lblTennhom.Text = "Tên nhóm";
            // 
            // lblMaso
            // 
            this.lblMaso.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblMaso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMaso.Location = new System.Drawing.Point(0, 21);
            this.lblMaso.Name = "lblMaso";
            this.lblMaso.Size = new System.Drawing.Size(75, 23);
            this.lblMaso.TabIndex = 22;
            this.lblMaso.Text = "Mã số";
            // 
            // taiDanhmucthanhpho
            // 
            this.taiDanhmucthanhpho.AttachedControl = this.tabControlPanel1;
            this.taiDanhmucthanhpho.Name = "taiDanhmucthanhpho";
            this.taiDanhmucthanhpho.Text = "Danh mục thành phố";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(838, 481);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.taiDanhmucthanhpho;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã thành phố";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã thành phố";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // gpThongtinchitiet
            // 
            this.gpThongtinchitiet.BackColor = System.Drawing.Color.Transparent;
            this.gpThongtinchitiet.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpThongtinchitiet.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpThongtinchitiet.Controls.Add(this._btnHuy);
            this.gpThongtinchitiet.Controls.Add(this._btnSua);
            this.gpThongtinchitiet.Controls.Add(this._btnLuu);
            this.gpThongtinchitiet.Controls.Add(this._btnThem);
            this.gpThongtinchitiet.Controls.Add(this._chkTrangthai);
            this.gpThongtinchitiet.Controls.Add(this._txtTennhom);
            this.gpThongtinchitiet.Controls.Add(this._txtmanhomdichvu);
            this.gpThongtinchitiet.Controls.Add(this._tbxMota);
            this.gpThongtinchitiet.Controls.Add(this.lblMota);
            this.gpThongtinchitiet.Controls.Add(this.lblTennhom);
            this.gpThongtinchitiet.Controls.Add(this.lblMaso);
            this.gpThongtinchitiet.DrawTitleBox = false;
            this.gpThongtinchitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpThongtinchitiet.Location = new System.Drawing.Point(8, 57);
            this.gpThongtinchitiet.Name = "gpThongtinchitiet";
            this.gpThongtinchitiet.Size = new System.Drawing.Size(302, 347);
            // 
            // 
            // 
            this.gpThongtinchitiet.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpThongtinchitiet.Style.BackColorGradientAngle = 90;
            this.gpThongtinchitiet.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpThongtinchitiet.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpThongtinchitiet.Style.BorderBottomWidth = 1;
            this.gpThongtinchitiet.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpThongtinchitiet.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpThongtinchitiet.Style.BorderLeftWidth = 1;
            this.gpThongtinchitiet.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpThongtinchitiet.Style.BorderRightWidth = 1;
            this.gpThongtinchitiet.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpThongtinchitiet.Style.BorderTopWidth = 1;
            this.gpThongtinchitiet.Style.CornerDiameter = 4;
            this.gpThongtinchitiet.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpThongtinchitiet.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpThongtinchitiet.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpThongtinchitiet.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpThongtinchitiet.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpThongtinchitiet.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpThongtinchitiet.TabIndex = 4;
            this.gpThongtinchitiet.Text = "Thông tin chi tiết";
            // 
            // _btnSua
            // 
            this._btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnSua.Image = global::GUI.Resource.Pencil_icon;
            this._btnSua.Location = new System.Drawing.Point(75, 276);
            this._btnSua.Name = "_btnSua";
            this._btnSua.Size = new System.Drawing.Size(70, 38);
            this._btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnSua.TabIndex = 33;
            this._btnSua.Text = "Sửa";
            this._btnSua.Click += new System.EventHandler(this._btnSua_Click);
            // 
            // _btnLuu
            // 
            this._btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnLuu.Image = global::GUI.Resource.Save_icon;
            this._btnLuu.Location = new System.Drawing.Point(151, 276);
            this._btnLuu.Name = "_btnLuu";
            this._btnLuu.Size = new System.Drawing.Size(70, 38);
            this._btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnLuu.TabIndex = 35;
            this._btnLuu.Text = "Lưu";
            this._btnLuu.Click += new System.EventHandler(this._btnLuu_Click);
            // 
            // _btnThem
            // 
            this._btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnThem.Image = ((System.Drawing.Image)(resources.GetObject("_btnThem.Image")));
            this._btnThem.Location = new System.Drawing.Point(0, 276);
            this._btnThem.Name = "_btnThem";
            this._btnThem.Size = new System.Drawing.Size(70, 38);
            this._btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnThem.TabIndex = 34;
            this._btnThem.Text = "Thêm";
            this._btnThem.Click += new System.EventHandler(this._btnThem_Click);
            // 
            // _txtmanhomdichvu
            // 
            this._txtmanhomdichvu.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this._txtmanhomdichvu.Border.Class = "TextBoxBorder";
            this._txtmanhomdichvu.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._txtmanhomdichvu.Enabled = false;
            this._txtmanhomdichvu.ForeColor = System.Drawing.Color.Black;
            this._txtmanhomdichvu.Location = new System.Drawing.Point(76, 21);
            this._txtmanhomdichvu.Name = "_txtmanhomdichvu";
            this._txtmanhomdichvu.Size = new System.Drawing.Size(100, 26);
            this._txtmanhomdichvu.TabIndex = 31;
            // 
            // _tbxMota
            // 
            this._tbxMota.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this._tbxMota.Border.Class = "TextBoxBorder";
            this._tbxMota.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._tbxMota.ForeColor = System.Drawing.Color.Black;
            this._tbxMota.Location = new System.Drawing.Point(0, 106);
            this._tbxMota.Multiline = true;
            this._tbxMota.Name = "_tbxMota";
            this._tbxMota.Size = new System.Drawing.Size(289, 117);
            this._tbxMota.TabIndex = 26;
            // 
            // lblMota
            // 
            this.lblMota.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblMota.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMota.Location = new System.Drawing.Point(0, 78);
            this.lblMota.Name = "lblMota";
            this.lblMota.Size = new System.Drawing.Size(75, 23);
            this.lblMota.TabIndex = 25;
            this.lblMota.Text = "Mô tả";
            // 
            // tcDanhmucThanhpho
            // 
            this.tcDanhmucThanhpho.BackColor = System.Drawing.Color.White;
            this.tcDanhmucThanhpho.CanReorderTabs = true;
            this.tcDanhmucThanhpho.CloseButtonOnTabsVisible = true;
            this.tcDanhmucThanhpho.Controls.Add(this.tabControlPanel1);
            this.tcDanhmucThanhpho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDanhmucThanhpho.ForeColor = System.Drawing.Color.Black;
            this.tcDanhmucThanhpho.Location = new System.Drawing.Point(0, 0);
            this.tcDanhmucThanhpho.Name = "tcDanhmucThanhpho";
            this.tcDanhmucThanhpho.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tcDanhmucThanhpho.SelectedTabIndex = 0;
            this.tcDanhmucThanhpho.Size = new System.Drawing.Size(838, 507);
            this.tcDanhmucThanhpho.TabIndex = 5;
            this.tcDanhmucThanhpho.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tcDanhmucThanhpho.Text = "Danh mục thành phố";
            // 
            // pnlArea2
            // 
            this.pnlArea2.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlArea2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlArea2.Controls.Add(this.gpThongtinchitiet);
            this.pnlArea2.Controls.Add(this.lblDatetime);
            this.pnlArea2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlArea2.Location = new System.Drawing.Point(0, 0);
            this.pnlArea2.Name = "pnlArea2";
            this.pnlArea2.Size = new System.Drawing.Size(319, 467);
            this.pnlArea2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlArea2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlArea2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlArea2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlArea2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlArea2.Style.GradientAngle = 90;
            this.pnlArea2.TabIndex = 0;
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.splitContainer1);
            this.tabControlPanel2.Controls.Add(this.pnlTieude);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 0);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(838, 507);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 6;
            this.tabControlPanel2.TabItem = this.taiDanhmucthanhpho;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(1, 39);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._grdNhomDichVu);
            this.splitContainer1.Panel1.Controls.Add(this.panelEx1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.pnlArea2);
            this.splitContainer1.Size = new System.Drawing.Size(836, 467);
            this.splitContainer1.SplitterDistance = 513;
            this.splitContainer1.TabIndex = 4;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this._txtTimkiem);
            this.panelEx1.Controls.Add(this._lblTimkiem);
            this.panelEx1.Controls.Add(this._txtTimmaso);
            this.panelEx1.Controls.Add(this._lblTimmaso);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(513, 44);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(199, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(69, 23);
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "Tìm kiếm";
            // 
            // _txtTimkiem
            // 
            this._txtTimkiem.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this._txtTimkiem.Border.Class = "TextBoxBorder";
            this._txtTimkiem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._txtTimkiem.ForeColor = System.Drawing.Color.Black;
            this._txtTimkiem.Location = new System.Drawing.Point(264, 14);
            this._txtTimkiem.Name = "_txtTimkiem";
            this._txtTimkiem.Size = new System.Drawing.Size(219, 20);
            this._txtTimkiem.TabIndex = 11;
            // 
            // _lblTimkiem
            // 
            this._lblTimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this._lblTimkiem.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._lblTimkiem.Location = new System.Drawing.Point(203, 11);
            this._lblTimkiem.Name = "_lblTimkiem";
            this._lblTimkiem.Size = new System.Drawing.Size(115, 23);
            this._lblTimkiem.TabIndex = 10;
            this._lblTimkiem.Text = "Tìm mã số";
            // 
            // _txtTimmaso
            // 
            this._txtTimmaso.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this._txtTimmaso.Border.Class = "TextBoxBorder";
            this._txtTimmaso.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._txtTimmaso.ForeColor = System.Drawing.Color.Black;
            this._txtTimmaso.Location = new System.Drawing.Point(96, 14);
            this._txtTimmaso.Name = "_txtTimmaso";
            this._txtTimmaso.Size = new System.Drawing.Size(88, 20);
            this._txtTimmaso.TabIndex = 9;
            // 
            // _lblTimmaso
            // 
            // 
            // 
            // 
            this._lblTimmaso.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this._lblTimmaso.Location = new System.Drawing.Point(26, 11);
            this._lblTimmaso.Name = "_lblTimmaso";
            this._lblTimmaso.Size = new System.Drawing.Size(69, 23);
            this._lblTimmaso.TabIndex = 8;
            this._lblTimmaso.Text = "Tìm mã số";
            // 
            // _btnHuy
            // 
            this._btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this._btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this._btnHuy.Image = global::GUI.Resource.Close_2_icon;
            this._btnHuy.Location = new System.Drawing.Point(225, 276);
            this._btnHuy.Name = "_btnHuy";
            this._btnHuy.Size = new System.Drawing.Size(70, 38);
            this._btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this._btnHuy.TabIndex = 36;
            this._btnHuy.Text = "Hủy";
            this._btnHuy.Click += new System.EventHandler(this._btnHuy_Click);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "_MaNhomDichVu";
            this.Column2.HeaderText = "Mã nhóm";
            this.Column2.Name = "Column2";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "_TenNhomDichVu";
            this.Ten.HeaderText = "Tên nhóm";
            this.Ten.Name = "Ten";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "_MoTa";
            this.Column3.HeaderText = "Mô tả";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.Checked = true;
            this.Column4.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Column4.CheckValue = null;
            this.Column4.DataPropertyName = "_TrangThai";
            this.Column4.HeaderText = "Trạng thái SD";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ucNhomdichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlPanel2);
            this.Controls.Add(this.tcDanhmucThanhpho);
            this.Name = "ucNhomdichvu";
            this.Size = new System.Drawing.Size(838, 507);
            ((System.ComponentModel.ISupportInitialize)(this._grdNhomDichVu)).EndInit();
            this.pnlTieude.ResumeLayout(false);
            this.gpThongtinchitiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tcDanhmucThanhpho)).EndInit();
            this.tcDanhmucThanhpho.ResumeLayout(false);
            this.pnlArea2.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX _grdNhomDichVu;
        private DevComponents.DotNetBar.Controls.CheckBoxX _chkTrangthai;
        private DevComponents.DotNetBar.PanelEx pnlTieude;
        private DevComponents.DotNetBar.LabelX lblThanhpho;
        private DevComponents.DotNetBar.LabelX lblDatetime;
        private DevComponents.DotNetBar.Controls.TextBoxX _txtTennhom;
        private DevComponents.DotNetBar.LabelX lblTennhom;
        private DevComponents.DotNetBar.LabelX lblMaso;
        private DevComponents.DotNetBar.TabItem taiDanhmucthanhpho;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DevComponents.DotNetBar.Controls.GroupPanel gpThongtinchitiet;
        private DevComponents.DotNetBar.Controls.TextBoxX _txtmanhomdichvu;
        private DevComponents.DotNetBar.Controls.TextBoxX _tbxMota;
        private DevComponents.DotNetBar.LabelX lblMota;
        private DevComponents.DotNetBar.TabControl tcDanhmucThanhpho;
        private DevComponents.DotNetBar.PanelEx pnlArea2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX _txtTimkiem;
        private DevComponents.DotNetBar.LabelX _lblTimkiem;
        private DevComponents.DotNetBar.Controls.TextBoxX _txtTimmaso;
        private DevComponents.DotNetBar.LabelX _lblTimmaso;
        private DevComponents.DotNetBar.ButtonX _btnSua;
        private DevComponents.DotNetBar.ButtonX _btnLuu;
        private DevComponents.DotNetBar.ButtonX _btnThem;
        private DevComponents.DotNetBar.ButtonX _btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn Column4;
    }
}
