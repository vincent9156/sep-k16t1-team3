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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            mainload();
            //frmChonnhanvien lg = new frmChonnhanvien();
            //lg.ShowDialog();
            
        }
        private void mainload()
        {
            pnlMain.Controls.Clear();
            ucBackground bg = new ucBackground();
            pnlMain.Controls.Add(bg);
            bg.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void rbbUsergroup_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucNhomnguoidung nnd = new ucNhomnguoidung();
            pnlMain.Controls.Add(nnd);
            nnd.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void rbbNguoidung_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucNguoidung nd = new ucNguoidung();
            pnlMain.Controls.Add(nd);
            nd.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void rbbLaphoadon_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucLaphoadon lhd = new ucLaphoadon();
            pnlMain.Controls.Add(lhd);
            lhd.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void ribbonOrbMenuItem4_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucBackground bg = new ucBackground();
            pnlMain.Controls.Add(bg);
            bg.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucBaocaoNhanviennhaplieu bc = new ucBaocaoNhanviennhaplieu();
            pnlMain.Controls.Add(bc);
            bc.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucBaocaoNhanvienthutien bc = new ucBaocaoNhanvienthutien();
            pnlMain.Controls.Add(bc);
            bc.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucBaocaoBenhnhan bc = new ucBaocaoBenhnhan();
            pnlMain.Controls.Add(bc);
            bc.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucThongkeDoanhthu tk = new ucThongkeDoanhthu();
            pnlMain.Controls.Add(tk);
            tk.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void _rbbPhanquyen_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucPhanquyen temp = new ucPhanquyen();
            pnlMain.Controls.Add(temp);
            temp.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void rbbLoaiphongban_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucLoaiphongban temp = new ucLoaiphongban();
            pnlMain.Controls.Add(temp);
            temp.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void rbbPhongban_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucPhongBan temp = new ucPhongBan();
            pnlMain.Controls.Add(temp);
            temp.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void _rbbNhomdichvu_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucNhomdichvu temp = new ucNhomdichvu();
            pnlMain.Controls.Add(temp);
            temp.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void _rbbDichvu_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucDichvu temp = new ucDichvu();
            pnlMain.Controls.Add(temp);
            temp.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void rbbThutien_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            ucXacnhanthutien temp = new ucXacnhanthutien();
            pnlMain.Controls.Add(temp);
            temp.Dock = System.Windows.Forms.DockStyle.Fill;
        }

    }
}
