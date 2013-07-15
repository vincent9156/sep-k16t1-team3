using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DA;
using DO;
using BL;
namespace GUI
{

    public partial class ucLaphoadon : UserControl
    {
        private string[] arrMaNhomDV = new string[50];
        private string[] arrNhomDV = new string[50];
        private string[] arrMaDV = new string[50];
        private string[] arrDV = new string[50];
        public int x = 0;
        private int demDV = 0;
        private int tongtientunghd = 0;
        private string MaNguoiNhap;
        private bool them = false;
        private int tongtien;
        public int i = 1;
        public ucLaphoadon()
        {
            InitializeComponent();
            //lblDatetime.Text = BL.Hamdungchung.Updatetime();
        }
        public ucLaphoadon(string manguoidung)
            : this()
        {
            MaNguoiNhap = manguoidung;
            LoadNhomDichVu();   
        }
        // Lấy thông tin bệnh nhân theo mã
        private void _txtMaBenhNhan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_txtMaBenhNhan.TextLength == 10)
                {
                    List<BenhNhan_DO> bn = BL.BenhNhan_BL.LayBenhNhan(_txtMaBenhNhan.Text);
                    if (bn[0]._MaBenhNhan.ToString() == _txtMaBenhNhan.Text)
                    {
                        _txtTenBenhNhan.Text = bn[0]._TenBenhNhan;
                        _txtGioiTinh.Text = bn[0]._GioiTinh;
                        _txtTuoi.Text = bn[0]._Tuoi.ToString();
                    }
                }
            }
            catch (Exception)
            {
            }

        }
        // add nhóm dv vào cobobox
        private void LoadNhomDichVu()
        {
            // Nhóm dịch vụ
            _cboNhomDichVu.DataSource = BL.NhomDichVu_BL.LayDanhSachNhomDichVuOtherUser();
            _cboNhomDichVu.ValueMember = "_MaNhomDichVu";
            _cboNhomDichVu.DisplayMember = "_TenNhomDichVu";
            _cboNhomDichVu.Text = "";
            _cboDichVu.Enabled = false;
        }
        // add dv vào combobox
        private void _cboNhomDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Dịch vụ theo nhóm
            _cboDichVu.Enabled = true;
            _cboDichVu.DataSource = BL.DichVu_BL.LayDichVuTheoNhom(_cboNhomDichVu.SelectedValue.ToString());
            _cboDichVu.ValueMember = "_MaDichVu";
            _cboDichVu.DisplayMember = "_TenDichVu";
            _cboDichVu.Text = "";
        }
        // thêm 
        private void _btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_cboNhomDichVu.Text != "" && _cboDichVu.Text != "")
                {
                    _grdBangGia.Rows.Add(i, _cboNhomDichVu.Text, _cboDichVu.Text, BL.DichVu_BL.TimKiemDichVuLayGia(_cboDichVu.Text));

                    i += 1;
                    tongtien = tongtien + Convert.ToInt32(DichVu_BL.TimKiemDichVuLayGia(_cboDichVu.Text));
                    //string hienthi="";
                    string term = tongtien.ToString();
                    /*int j;
                    for (j = 1; j <= term.Length / 3; j++)
                    {
                        hienthi = "," + term.Substring(term.Length - 3 * j, 3) + hienthi;
                    }*/
                    // Đếm nhóm dv và add nhóm dv được chọn vào mảng
                    if (x == 0)
                    {
                        arrNhomDV[x] = _cboNhomDichVu.Text;
                        arrMaNhomDV[x] = _cboNhomDichVu.SelectedValue.ToString();
                        x = x + 1;
                    }
                    else
                    {
                        bool kt = true;
                        for (int j = 0; j < x; j++)
                        {
                            if (arrNhomDV[j] == _cboNhomDichVu.Text.Trim())
                            {
                                kt = false;
                            }
                        }
                        if (kt == true)
                        {
                            arrNhomDV[x] = _cboNhomDichVu.Text;
                            arrMaNhomDV[x] = _cboNhomDichVu.SelectedValue.ToString();
                            x += 1;
                        }
                    }
                    _lblTongTien.Text = term;
                    them = true;
                    //add dv dc thêm vào mảng
                    arrMaDV[demDV] = _cboDichVu.SelectedValue.ToString();
                    demDV = demDV + 1;// đếm dv dc thêm
                }
            }
            catch (Exception)
            {


            }

        }

        private void _grdBangGia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;//lấy các chỉ số cột hoặc dòng
            int y = e.ColumnIndex;
            //_grdBangGia.Rows.RemoveAt(y);

            foreach (DataGridViewRow row in _grdBangGia.SelectedRows)
            {
                if (!row.IsNewRow)
                    _grdBangGia.Rows.Remove(row);

            }
        }
        //private void _grdBangGia_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{

        //    if(_grdBangGia.CurrentCell.ColumnIndex == 4)
        //    {
        //    Button btShow = e.Control as Button;
        //    btShow.Click += new System.EventHandler(this._btShow_Click);
        //    //Trong sự kiện btShow_Click thì bạn code như button bình thường.
        //    }
        //}
        //private void _btShow_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Hello!");
        //}

        private void _btnXemTruoc_Click(object sender, EventArgs e)
        {

        }

        private void _grdBangGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not in our 
            if (e.ColumnIndex == _grdBangGia.Columns[4].Index && e.RowIndex >= 0 && _grdBangGia.Rows[e.RowIndex].Cells[0].Value != null)
            {
                string term = _grdBangGia.Rows[e.RowIndex].Cells[3].Value.ToString();
                tongtien = tongtien - Convert.ToInt32(term);
                _lblTongTien.Text = tongtien.ToString();
                _grdBangGia.Rows.RemoveAt(e.RowIndex);
                demDV = demDV - 1; 
                //MessageBox.Show("Hello!" + e.RowIndex);
            }
        }

        private void _grdBangGia_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("" + _grdBangGia.RowCount);
        }

        private void _grdBangGia_SelectionChanged(object sender, EventArgs e)
        {
            //string tongtien = "";
            //foreach (DataGridViewRow r in _grdBangGia.Rows)
            //{
            //    tongtien = r.Cells[3].Value.ToString();
            //}
            //_lblTongTien.Text = tongtien;
            //MessageBox.Show("" + _grdBangGia.RowCount);
        }

        private void _grdBangGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // In, lưu hóa đơn 
        private void _btnIn_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                try
                {
                    //_txtTenBenhNhan.Text = "test";
                    // lưu tách hóa đơn theo nhóm dv
                    int k=0;
                    for (int a = 0; a < x; a++)
                    {
                        for (int j = 0; j < demDV; j++)
                        {
                            if (_grdBangGia.Rows[j].Cells[1].Value.ToString() == arrNhomDV[a])
                            {
                                tongtientunghd += Convert.ToInt32(_grdBangGia.Rows[j].Cells[3].Value.ToString());
                                arrDV[k] = arrMaDV[j];
                                k += 1;
                            }
                        }
                        if (tongtientunghd > 0)
                        {
                            BL.HoaDon_BL.ThemHoaDon(_txtMaBenhNhan.Text, BL.PhongBan_BL.LayMaPhongBanNhomDV(arrMaNhomDV[a]), MaNguoiNhap, MaNguoiNhap, _txtGioiTinh.Text, Convert.ToInt32(_txtTuoi.Text), tongtientunghd, DateTime.Now.ToShortDateString(), false);
                            // lưu tách chi tiết hóa đơn theo nhóm dv
                            for (int l = 0; l < k; l++)
                            {
                                BL.ChiTietHoaDon_BL.ThemCTHD("", BL.HoaDon_BL.LayMaHDTheoNhomDV(_txtMaBenhNhan.Text, BL.PhongBan_BL.LayMaPhongBanNhomDV(arrMaNhomDV[a])), arrDV[l]);
                            }
                        }
                        tongtientunghd = 0;
                        k = 0;
                        arrDV = new string[50];
                    }
                    MessageBox.Show("Đã thêm hóa đơn thành công.");

                }
                catch (Exception)
                {
                    MessageBox.Show("Đã có lỗi xảy ra.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

    }
}
