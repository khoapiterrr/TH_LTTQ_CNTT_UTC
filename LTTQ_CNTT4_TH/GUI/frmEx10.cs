﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ_CNTT4_TH.GUI
{
    public partial class frmEx10 : Form
    {
        public frmEx10()
        {
            InitializeComponent();
        }

        private void frmEx10_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain frm = new frmMain();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}