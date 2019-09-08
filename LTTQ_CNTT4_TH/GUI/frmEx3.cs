using LTTQ_CNTT4_TH.Model;
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
    public partial class frmEx3 : Form
    {
        public frmEx3()
        {
            InitializeComponent();
        }

        private void frmEx3_Load(object sender, EventArgs e)
        {
            txtMoney.Enabled = false;
            txtPriceFood.Enabled = false;
            rbtn1.Checked = true;
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            BackFormMain();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMoney.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPriceFood.Text = string.Empty;
            cboAmount.Text = null;
            cboFood.SelectedValue = null;
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

        private void rbtn1_CheckedChanged(object sender, EventArgs e)
        {
            txtMoney.Text = 200 + "";
        }

        private void rbtn2_CheckedChanged(object sender, EventArgs e)
        {
            txtMoney.Text = 100 + "";
        }

        private void cboAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboFood.Text))
                return;
            var obj = new ClientEx3()
            {
                DoUong = cboFood.SelectedIndex + 1,
                SoLuong = int.Parse(cboAmount.Text)
            };
            txtPriceFood.Text = obj.GetFoodMoney().ToString();
        }

        private void cboFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboAmount.Text))
                return;
            var obj = new ClientEx3()
            {
                DoUong = cboFood.SelectedIndex + 1,
                SoLuong = int.Parse(cboAmount.Text)
            };
            txtPriceFood.Text = obj.GetFoodMoney().ToString();
        }

        private void LoadData()
        {
            lstClient.Items.Clear();
            var lst = DataContext.ClientEx3Context;
            foreach (var item in lst)
            {
                lstClient.Items.Add(item.ToString());
            }
        }

        private void btnAddLst_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên");
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cboAmount.Text) || string.IsNullOrEmpty(cboFood.Text))
            {
                MessageBox.Show("Vui lòng chọn đồ uống");
                return;
            }
            var data = new ClientEx3()
            {
                DoUong = cboFood.SelectedIndex + 1,
                SoLuong = int.Parse(cboAmount.Text),
                TenKH = txtName.Text,
                ThoiGianThue = rbtn1.Checked == true ? 1 : 2
            };
            DataContext.ClientEx3Context.Add(data);
            LoadData();
        }

        private void frmEx3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}