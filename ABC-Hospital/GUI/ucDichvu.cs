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
    public partial class ucDichvu : UserControl
    {
        public ucDichvu()
        {
            InitializeComponent();
            lblDatetime.Text = BL.Hamdungchung.Updatetime();
        }

    }
}
