using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LTTQ_CNTT4_TH.GUI
{
    public partial class frmEx6 : Form
    {
        private List<float> _lstData;

        public frmEx6()
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

        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSo.Text))
            {
                MessageBox.Show("Vui lòng nhập số trước", "Thông báo");
                txtSo.Focus();
                return;
            }
            if (txtSo.Text.ToCharArray().Where(x => x == '.').Count() > 1)
            {
                MessageBox.Show("Vui lòng nhập số đúng định dạng của số thực", "Thông báo");
                txtSo.Focus();
                return;
            }
            _lstData.Add(float.Parse(txtSo.Text));
            LoadData();
            btnXoa.Enabled = true;
        }

        private void LoadData()
        {
            lstNum.Items.Clear();
            foreach (var item in _lstData)
            {
                lstNum.Items.Add(item);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSo.Text = string.Empty;
            lblCheck.Text = string.Empty;
            lstNum.Items.Clear();
            _lstData = new List<float>();
            btnXoa.Enabled = false;
        }

        private void frmEx6_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_lstData.Count == 0) return;
            lblCheck.Text = "Giá trị lớn nhất của dãy là : " + _lstData.Max();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_lstData.Count == 0) return;
            var selected = lstNum.SelectedItem;
            if (selected == null)
            {
                MessageBox.Show("Chọn số cần xóa khỏi DS", "Thông báo");
                return;
            }
            _lstData.Remove((float)selected);
            if (_lstData.Count == 0) btnXoa.Enabled = false;
            LoadData();
        }

        private void frmEx6_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}