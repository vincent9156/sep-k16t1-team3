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
        public int i = 1;
        public ucLaphoadon()
        {
            InitializeComponent();
            //lblDatetime.Text = BL.Hamdungchung.Updatetime();
        }

        private void ucLaphoadon_Load(object sender, EventArgs e)
        {
            LoadDichVu();    
        }


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
        private void LoadDichVu()
        {
            // Nhóm dịch vụ
            _cboNhomDichVu.DataSource = BL.NhomDichVu_BL.LayDanhSachNhomDichVu();
            _cboNhomDichVu.ValueMember = "_MaNhomDichVu";
            _cboNhomDichVu.DisplayMember = "_TenNhomDichVu";  
            _cboNhomDichVu.Text = "";
        }

        private void _cboNhomDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Dịch vụ theo nhóm
            _cboDichVu.DataSource = BL.DichVu_BL.LayDichVuTheoNhom(_cboNhomDichVu.SelectedValue.ToString());
            _cboDichVu.ValueMember = "_MaDichVu";
            _cboDichVu.DisplayMember = "_TenDichVu";
            _cboDichVu.Text = "";
        }
        private void _btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_cboNhomDichVu.Text != "" && _cboDichVu.Text != "")
                {
                    _grdBangGia.Rows.Add(i, _cboNhomDichVu.Text, _cboDichVu.Text,BL.DichVu_BL.TimKiemDichVuLayGia(_cboDichVu.Text));
                    
                    i += 1;
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
            if (e.ColumnIndex == _grdBangGia.Columns[4].Index && e.RowIndex >= 0)
            {
                _grdBangGia.Rows.RemoveAt(e.RowIndex);
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
    }
}
