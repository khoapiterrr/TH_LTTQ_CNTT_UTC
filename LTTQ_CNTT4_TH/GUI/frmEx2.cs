using LTTQ_CNTT4_TH.Model;
using System;
using System.Windows.Forms;

namespace LTTQ_CNTT4_TH.GUI
{
    public partial class frmEx2 : Form
    {
        public frmEx2()
        {
            InitializeComponent();
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtAddr.Text = string.Empty;
            txtMaKH.Text = string.Empty;
            txtMoney.Text = string.Empty;
            txtName.Text = string.Empty;
            cboTime.Text = null;
        }

        private void btnAddDS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMoney.Text) || string.IsNullOrEmpty(cboTime.Text))
            {
                MessageBox.Show("Bạn phải điền đầu đủ");
                return;
            }
            if (txtMaKH.Text.Length < 6)
            {
                MessageBox.Show("Bạn nhập mã lớn hơn 6 số");
                txtMaKH.Text = string.Empty;
                txtMaKH.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Bạn nhập họ tên");
                txtName.Text = string.Empty;
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtAddr.Text))
            {
                MessageBox.Show("Bạn nhập địa chỉ");
                txtAddr.Text = string.Empty;
                txtAddr.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMoney.Text))
            {
                MessageBox.Show("Bạn nhập số tiền");
                txtMoney.Text = string.Empty;
                txtMoney.Focus();
                return;
            }
            var data = new ClientEx2()
            {
                Id = txtMaKH.Text,
                ThoiGianGui = int.Parse(cboTime.Text),
                Address = txtAddr.Text,
                Money = long.Parse(txtMoney.Text),
                Name = txtName.Text,
                NgayGui = Convert.ToDateTime(dtpDate.Text),
                Loai = 1
            };
            if (rbtnPhatLoc.Checked == true)
                data.Loai = 2;

            var checkCode = DataContext.ClientEx2Context.Find(x => x.Id == txtMaKH.Text);
            if (checkCode != null)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại vui lòng nhập mã khác", "Thông báo");
                txtMaKH.Focus();
                return;
            }

            DataContext.ClientEx2Context.Add(data);
            LoadData();
        }

        private void LoadData()
        {
            lstKH.Items.Clear();
            var lst = DataContext.ClientEx2Context;
            foreach (var item in lst)
            {
                lstKH.Items.Add(item.ToString());
            }
        }

        private void frmEx2_Load(object sender, EventArgs e)
        {
            rbtnThuong.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void frmEx2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSearchEx2 frm = new frmSearchEx2();
            frm.ShowDialog();
        }
    }
}