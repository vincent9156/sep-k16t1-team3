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
    public partial class ucNguoidung : UserControl
    {
        public ucNguoidung()
        {
            InitializeComponent();
            lblDatetime.Text = BL.HamDungChung_BL.Updatetime();
        }

        private void lblThanhpho_Click(object sender, EventArgs e)
        {

        }

        private void pnlTieude_Click(object sender, EventArgs e)
        {

        }
    }
}
