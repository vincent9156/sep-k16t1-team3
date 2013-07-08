using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmChonnhanvien : Form
    {
        public frmChonnhanvien()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            pnlLuachonvitri.Enabled = true;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            //Main key = new Main();
            //key.ShowDialog();
            //this.Close();
            
        }
    }
}
