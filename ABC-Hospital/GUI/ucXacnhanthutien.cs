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
    public partial class ucXacnhanthutien : UserControl
    {
        public ucXacnhanthutien()
        {
            InitializeComponent();
            //lblDatetime.Text = BL.Hamdungchung.Updatetime();
            LoadDSBenhNhanCho();
        }

        private void textBoxX6_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadDSBenhNhanCho()
        {
            //_grdDSBenhNhanCHo.DataSource = BL.HoaDon_BL.LayDSBenhNhanCho("AD00001",DateTime.Now,false);
        }

    }
}
