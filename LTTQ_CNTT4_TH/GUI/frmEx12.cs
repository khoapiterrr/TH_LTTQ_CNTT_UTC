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
    public partial class frmEx12 : Form
    {
        private bool checkSNT(long n)
        {
            if (n <= 2) return false;
            if (n % 2 == 0) return false;
            for (int i = 3; i * i < n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        private List<int> _lstNum = new List<int>();

        public frmEx12()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSo.Text = string.Empty;
            lblCheck.Text = string.Empty;
            _lstNum = new List<int>();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_lstNum.Count == 0) return;
            var current = lstSo.SelectedItem.ToString();
            var check = _lstNum.Find(x => x.ToString() == current);
            if (check != 0)
            {
                _lstNum.Remove(int.Parse(current));
                LoadData();
            }
        }

        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSo.Text))
            {
                MessageBox.Show("Vui lòng nhập số trước khi thêm");
                txtSo.Focus();
                return;
            }

            var check = _lstNum.Find(x => x.ToString() == txtSo.Text);
            if (check == 0)
            {
                _lstNum.Add(int.Parse(txtSo.Text));
                LoadData();
                return;
            }
            MessageBox.Show(txtSo.Text + " đã tồn tại trong danh sách");
        }

        private void LoadData()
        {
            lstSo.Items.Clear();
            var lst = _lstNum;
            foreach (var item in lst)
            {
                lstSo.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_lstNum.Count == 0) return;
            var num = lstSo.SelectedItem.ToString();
            var ok = checkSNT(long.Parse(num));
            if (ok == true)
                lblCheck.Text = num + " là số nguyên tố";
            else
                lblCheck.Text = num + " không phải là số nguyên tố là số nguyên tố";
        }

        private void frmEx12_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}