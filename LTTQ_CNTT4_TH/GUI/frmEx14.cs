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
    public partial class frmEx14 : Form
    {
        public frmEx14()
        {
            InitializeComponent();
        }

        private void frmEx14_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
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
            lstSVMuon.Items.Add(data.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSVMuon.Items.Count == 0) return;

            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selected = lstSVMuon.SelectedItem;
                if (selected == null)
                {
                    MessageBox.Show("Bạn phải chọn trước khi xóa");
                    return;
                }
                lstSVMuon.Items.Remove(selected);
            }
        }
    }
}