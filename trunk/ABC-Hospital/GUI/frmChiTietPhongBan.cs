﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmChiTietPhongBan : Form
    {
        public frmChiTietPhongBan()
        {
            InitializeComponent();
        }

        private void labelX5_Click(object sender, EventArgs e)
        {
            frmDanhsachban temp = new frmDanhsachban();
            temp.ShowDialog();
        }
    }
}
