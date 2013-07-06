using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucDichvu : UserControl
    {
        public ucDichvu()
        {
            InitializeComponent();
            lblDatetime.Text = BL.HamDungChung_BL.Updatetime();
            LoadDanhSachDichVu();
        }
        private void LoadDanhSachDichVu()
        {
            _grdDichVu.DataSource = BL.DichVu_BL.LoadDanhSachDichVu();
        }

        private void pnlTieude_Click(object sender, EventArgs e)
        {

        }

        private void _txtTimmaso_TextChanged(object sender, EventArgs e)
        {
            if (_txtTimmaso.Text == "")
            {
                _grdDichVu.DataSource = BL.DichVu_BL.LoadDanhSachDichVu();
            }
            else
            {
                _grdDichVu.DataSource = BL.DichVu_BL.TimKiemTheoMa(_txtTimmaso.Text);
            }
        }

        private void pnlArea2_Click(object sender, EventArgs e)
        {

        }

        private void gpThongtinchitiet_Click(object sender, EventArgs e)
        {

        }

        private void _btnSua_Click(object sender, EventArgs e)
        {

        }

        private void _btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void _btnThem_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX5_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX4_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEx2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void lblMaso_Click(object sender, EventArgs e)
        {

        }

        private void lblDatetime_Click(object sender, EventArgs e)
        {

        }

        private void lblThanhpho_Click(object sender, EventArgs e)
        {

        }

        private void _grdDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _lblTimmaso_Click(object sender, EventArgs e)
        {

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void _txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            if (_txtTimkiem.Text == "")
            {
                _grdDichVu.DataSource = BL.DichVu_BL.LoadDanhSachDichVu();
            }
            else
            {
                _grdDichVu.DataSource = BL.DichVu_BL.TimKiemTheoTen(_txtTimkiem.Text);
            }
        }

        private void _lblTimkiem_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void _btnHuy_Click(object sender, EventArgs e)
        {

        }

    }
}
