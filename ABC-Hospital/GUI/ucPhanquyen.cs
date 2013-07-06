using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DA;
using BL;
using DO;
namespace GUI
{
    public partial class ucPhanquyen : UserControl
    {
        public ucPhanquyen()
        {
            InitializeComponent();
        }

        private void ucPhanquyen_Load(object sender, EventArgs e)
        {
            //LoadDSChucNang();
            LoadDSNhomNguoiDung();
            LoadDSPhanQuyenTheoNhom();
        }
        private void LoadDSChucNang()
        {
            _grdChucNang.DataSource = BL.ChucNang_BL.LayChucNang();
        }
        // Hàm hiển thị các nhóm người dùng lên combobox
        private void LoadDSNhomNguoiDung()
        {
            _cboNhomNguoiDung.DataSource = BL.NhomNguoiDung_BL.LayNhomNguoiDung();
            _cboNhomNguoiDung.ValueMember = "_MaNhom";
            _cboNhomNguoiDung.DisplayMember = "_TenNhom";
            _cboNhomNguoiDung.Text = "";

        }

        private void _btnThietLap_Click(object sender, EventArgs e)
        {

            try
            {
                int n = _grdChucNang.RowCount;
                foreach (DataGridViewRow r in _grdChucNang.Rows)
                {
                    string machucnang = r.Cells[1].Value.ToString();
                    //   MessageBox.Show(machucnang);
                    int cn;
                    Int32.TryParse(machucnang, out cn);
                    string manhom = _cboNhomNguoiDung.SelectedValue.ToString();
                    //MessageBox.Show(manhom);
                    bool trangthai = false;
                    DataGridViewCheckBoxCell chk = r.Cells[0] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(chk.Value) == true)
                    {
                        trangthai = true;
                        //MessageBox.Show("" + trangthai);
                    }
                    if (Convert.ToBoolean(chk.Value) == false)
                    {

                        trangthai = false;
                        // MessageBox.Show(""+trangthai);

                    }
                    BL.ChucNangNhom_BL.ThemQuyenChoNhom(cn, manhom, trangthai);

                }
                MessageBox.Show("Đã thêm thành công!");
            }
            catch (Exception)
            {

                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo lỗi");
            }
          
        }

        private void _grdChucNang_SelectionChanged(object sender, EventArgs e)
        {
            int pos = _grdChucNang.CurrentCell.RowIndex;
            if (_grdChucNang.Rows[pos].Cells[0].Value == null)
            {
               // textBox1.Text = "null";
            }
        }
        private bool KiemTraDaPhanQuyen(string manhom)
        {
            DataGridView grd = new DataGridView();
            grd.DataSource = BL.ChucNangNhom_BL.LayChucNangTatCa();
            foreach (DataGridViewRow r in grd.Rows)
            {
                if (manhom == r.Cells[1].Value.ToString())
                {
                    return true;
                }  
            }
            return false;
        }

        private void _cboNhomNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manhom = _cboNhomNguoiDung.SelectedValue.ToString();
            if (KiemTraDaPhanQuyen(manhom) == true)
            {
                _grdChucNang.DataSource = DA.ChucNangNhom_DA.LayChucNangNhom(manhom);
            }
            else
            {
                _grdChucNang.DataSource = BL.ChucNang_BL.LayChucNang();
            }
        }
        private void LoadDSPhanQuyenTheoNhom()
        {
            _grdChucNang.DataSource = BL.ChucNangNhom_BL.LayChucNangNhom(_cboNhomNguoiDung.SelectedValue.ToString());
        }
    }
}
