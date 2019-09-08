using System;
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
    public partial class frmEx7 : Form
    {
        private List<int> _lstData;

        public frmEx7()
        {
            InitializeComponent();
        }

        private void frmEx7_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNum.Text = string.Empty;
            _lstData = new List<int>();
            lblDay.Text = string.Empty;
            lblKetQua.Text = string.Empty;
            cbo.Text = null;
        }

        private void frmEx7_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNhapDay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNum.Text))
            {
                MessageBox.Show("Vui lòng nhập số phần tử");
                txtNum.Focus();
                return;
            }
            _lstData.Clear();
            var num = int.Parse(txtNum.Text);
            Random rnd = new Random();
            while (num-- != 0)
                _lstData.Add(rnd.Next(-100, 100));
            lblDay.Text = "Dãy số vừa nhập là " + string.Join(" \t ", _lstData);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lstData.Count == 0) return;
            var checkSelected = cbo.SelectedIndex;
            if (checkSelected == 0)
                lblKetQua.Text = $"Có {(_lstData.Where(x => x < 0).Count())} phần tử âm trong dãy số";
            else if (checkSelected == 1)
                lblKetQua.Text = "TBC dãy số là :" + _lstData.Average().ToString(".00");
        }
    }
}