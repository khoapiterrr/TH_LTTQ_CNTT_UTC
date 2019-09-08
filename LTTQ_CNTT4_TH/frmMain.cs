using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTTQ_CNTT4_TH.GUI;

namespace LTTQ_CNTT4_TH
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuitem1_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEx1());
        }

        private void mnuitem2_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEx2());
        }

        private void mnuitem4_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEx4());
        }

        private void mnuitem5_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEx5());
        }

        private void mnuitem6_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEx6());
        }

        private void mnuitem7_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEx7());
        }

        private void mnuitem8_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEx8());
        }

        private void mnuitem9_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEx9());
        }

        private void mnuitem10_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEx10());
        }

        private void mnuitem11_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEx11());
        }

        private void mnuitem12_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEx12());
        }

        private void mnuitem13_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEx13());
        }

        private void mnuitem14_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEx14());
        }

        private void mnuitem3_Click(object sender, EventArgs e)
        {
            OpenForm(new frmEx3());
        }

        private void OpenForm(Form frm)
        {
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}