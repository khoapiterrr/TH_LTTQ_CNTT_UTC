using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LTTQ_CNTT4_TH.GUI
{
    public partial class frmEx13 : Form
    {
        private readonly List<int> _lstNumber;

        public frmEx13()
        {
            _lstNumber = new List<int>();
            InitializeComponent();
        }

        private void BackFormMain()
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnEnterArr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNum.Text))
            {
                MessageBox.Show("Vui lòng nhập số phần tử");
                txtNum.Focus();
                return;
            }
            _lstNumber.Clear();
            var num = int.Parse(txtNum.Text);
            Random rnd = new Random();
            while (num-- != 0)
                _lstNumber.Add(rnd.Next(-100, 100));
            lblArr.Text = "Dãy số vừa nhập là " + string.Join(" \t ", _lstNumber);
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            txtNum.Text = string.Empty;
            lblArr.Text = string.Empty;
            lblMin.Text = string.Empty;
            txtNumSearch.Text = string.Empty;
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearchMin_Click(object sender, EventArgs e)
        {
            if (_lstNumber.Count == 0)
                return;
            lblMin.Text = "Số dương nhỏ nhất là" + _lstNumber.Where(x => x > 0).Min();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            BackFormMain();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_lstNumber.Count == 0)
                return;
            if (string.IsNullOrEmpty(txtNumSearch.Text))
            {
                MessageBox.Show("Vui lòng nhập số phần tử cần tìm");
                txtNumSearch.Focus();
                return;
            }
            var index = new List<int>();
            foreach (var item in _lstNumber)
            {
                if (item.ToString() == txtNumSearch.Text)
                    index.Add(item);
            }
            if (index.Count == 0)
                MessageBox.Show("Không tìm thấy");
            else
                MessageBox.Show($"Phần tử {txtNumSearch.Text} ở vị trí thứ {string.Join(",", index)}");
        }

        private void txtNumSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}