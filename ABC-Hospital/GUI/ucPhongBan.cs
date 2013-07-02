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
    public partial class ucPhongBan : UserControl
    {
        public ucPhongBan()
        {
            InitializeComponent();
        }

        private void labelX5_Click(object sender, EventArgs e)
        {
            frmChiTietPhongBan temp = new frmChiTietPhongBan();
            temp.ShowDialog();
        }
    }
}
