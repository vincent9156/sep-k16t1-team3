﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucNhomdichvu : UserControl
    {
        public ucNhomdichvu()
        {
            InitializeComponent();
            lblDatetime.Text = BL.HamDungChung_BL.Updatetime();
        }
    }
}