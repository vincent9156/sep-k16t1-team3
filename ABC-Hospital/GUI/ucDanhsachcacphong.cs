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
    public partial class ucDanhsachcacphong : UserControl
    {
        public ucDanhsachcacphong()
        {
            InitializeComponent();
            lblDatetime.Text = BL.Hamdungchung.Updatetime();
        }

        private void labelX5_Click(object sender, EventArgs e)
        {
            frmDanhsachban temp = new frmDanhsachban();
            temp.ShowDialog();
        }
    }
}
