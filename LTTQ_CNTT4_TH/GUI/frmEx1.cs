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
    public partial class frmEx1 : Form
    {
        public frmEx1()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            BackFormMain();
        }

        private void btnExit_KeyDown(object sender, KeyEventArgs e)
        {
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

        private void frmEx1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.H)
            {
                btnExit.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.M)
            {
                btnAdd.PerformClick();
            }
            if (e.Alt && e.KeyCode == Keys.T)
            {
                btnAddLst.PerformClick();
            }
        }

        private void frmEx1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtAddr.Text = string.Empty;
            txtAfter.Text = string.Empty;
            txtBefore.Text = string.Empty;
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
        }

        private void txtBefore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //&& (e.KeyChar != '.')
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAfter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddLst_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length != 6)
            {
                MessageBox.Show("Vui lòng nhập mã đủ 6 số", "Thông báo");
                txtCode.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập mã đủ họ tên", "Thông báo");
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtAddr.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ của bạn", "Thông báo");
                txtAddr.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtBefore.Text) && string.IsNullOrEmpty(txtAfter.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số điện", "Thông báo");
                txtAddr.Focus();
                return;
            }
            var obj = new ClientEx1()
            {
                DiaChi = txtAddr.Text,
                MaKH = txtCode.Text,
                NgayChot = Convert.ToDateTime(dtpChotSo.Text),
                TenKH = txtName.Text,
                ThangNay = int.Parse(txtAfter.Text),
                ThangTruoc = int.Parse(txtBefore.Text),
            };
            var checkCode = DataContext.ClientEx1Context.Find(x => x.MaKH == txtCode.Text);
            if (checkCode != null)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại vui lòng nhập mã khác", "Thông báo");
                txtCode.Focus();
                return;
            }
            DataContext.ClientEx1Context.Add(obj);
            LoadData();
        }

        private void LoadData()
        {
            lstClient.Items.Clear();
            var lst = DataContext.ClientEx1Context;
            foreach (var item in lst)
            {
                lstClient.Items.Add(item.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearchEx1 frm = new frmSearchEx1();
            frm.ShowDialog();
        }
    }
}