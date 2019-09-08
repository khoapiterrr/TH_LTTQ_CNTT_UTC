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
    public partial class frmEx8 : Form
    {
        private List<int> _lstDaySo = new List<int>();

        public frmEx8()
        {
            InitializeComponent();
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

        private void LoadData()
        {
            lstNum.Items.Clear();
            foreach (var item in _lstDaySo)
            {
                lstNum.Items.Add(item);
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNum.Text))
            {
                MessageBox.Show("Vui lòng nhập số cần thêm vào danh sách");
                txtNum.Focus();
                return;
            }
            _lstDaySo.Add(int.Parse(txtNum.Text));
            LoadData();
            txtNum.Text = string.Empty;
            txtNum.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_lstDaySo.Count == 0) return;
            var selected = lstNum.SelectedItem;
            if (selected == null)
            {
                MessageBox.Show("Ban phải chọn phần tử để xóa");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _lstDaySo.Remove((int)selected);
                LoadData();
            }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            _lstDaySo = _lstDaySo.Select(x => x + 3).ToList();
            LoadData();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            var soChanDauTien = _lstDaySo.Find(x => (x % 2 == 0));
            lstNum.SelectedItem = soChanDauTien;
        }
    }
}