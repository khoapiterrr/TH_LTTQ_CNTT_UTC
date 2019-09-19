using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LTTQ_CNTT4_TH.GUI
{
    public partial class frmEx5 : Form
    {
        private List<int> lstDataNum;

        public frmEx5()
        {
            InitializeComponent();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            lblMax.Text = string.Empty;
            lblSum.Text = string.Empty;
            txtNum.Text = string.Empty;
            lstDataNum = new List<int>();
            lstNum.Items.Clear();
        }

        private void LoadData()
        {
            lstNum.Items.Clear();
            foreach (var item in lstDataNum)
            {
                lstNum.Items.Add(item);
            }
        }

        private void frmEx5_Load(object sender, EventArgs e)
        {
            btnRefesh.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (lstDataNum.Count == 0) return;
            lblSum.Text = "Tổng = " + lstDataNum.Sum();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (lstDataNum.Count == 0) return;
            lblMax.Text = "Max = " + lstDataNum.Max();
        }

        private void btnAddLst_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNum.Text))
            {
                MessageBox.Show("Vui lòng nhập số cần thêm vào danh sách", "Thông báo");
                txtNum.Focus();
                return;
            }
            lstDataNum.Add(int.Parse(txtNum.Text));
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstDataNum.Count == 0) return;
            var selectedItem = lstNum.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn số muốn xóa", "Thông báo");
                return;
            }
            lstDataNum.Remove((int)selectedItem);
            LoadData();
        }

        private void frmEx5_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}