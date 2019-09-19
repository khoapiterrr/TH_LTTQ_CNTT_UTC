using LTTQ_CNTT4_TH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LTTQ_CNTT4_TH.GUI
{
    public partial class frmEx14 : Form
    {
        private readonly List<Ex14> _lstEx14;

        public frmEx14()
        {
            _lstEx14 = new List<Ex14>();
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            cboKhoa.Text = null;
            cboNganh.Text = null;
            lstSach.SelectedItem = null;
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ họ tên", "Thông báo");
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cboNganh.Text))
            {
                MessageBox.Show("Bạn phải chọn ngành học", "Thông báo");
                cboNganh.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cboKhoa.Text))
            {
                MessageBox.Show("Bạn phải chọn khóa", "Thông báo");
                cboKhoa.Focus();
                return;
            }
            var lstSachMuon = lstSach.SelectedItems;
            if (lstSachMuon.Count == 0)
            {
                MessageBox.Show("Bạn phải giáo trình cần mượn", "Thông báo");
                return;
            }
            var data = new Ex14()
            {
                HoTen = txtName.Text,
                Khoa = cboKhoa.Text,
                Nganh = cboNganh.Text,
                Sachs = lstSachMuon.Cast<string>().ToList()
            };
            _lstEx14.Add(data);
            LoadData();
        }

        private void LoadData()
        {
            lstSVMuon.Items.Clear();
            int index = 1;
            foreach (var item in _lstEx14)
            {
                lstSVMuon.Items.Add($"{index++}. {item.ToString()}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSVMuon.Items.Count == 0) return;

            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selected = lstSVMuon.SelectedIndex;
                if (selected == -1)
                {
                    MessageBox.Show("Bạn phải chọn trước khi xóa");
                    return;
                }
                _lstEx14.RemoveAt(selected);
                LoadData();
            }
        }
    }
}