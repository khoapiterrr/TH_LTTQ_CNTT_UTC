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
    public partial class frmEx4 : Form
    {
        private readonly List<SubjectEx4> _lstDKMonHoc;

        public frmEx4()
        {
            _lstDKMonHoc = new List<SubjectEx4>();
            InitializeComponent();
        }

        private void frmEx4_Load(object sender, EventArgs e)
        {
            txtTongTin.Enabled = false;
            txtTB.Enabled = false;
            txtTongDiem.Enabled = false;
            txtSoTin.Enabled = false;
        }

        private void txtSoTin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
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

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkSelected = cboMonHoc.SelectedIndex;
            if (checkSelected == 0 || checkSelected == 3)
            {
                txtSoTin.Text = "2";
            }
            else
            {
                txtSoTin.Text = "3";
            }
        }

        private void btnAddLst_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboMonHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập chọn môn học", "Thông báo");
                cboMonHoc.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDiem.Text))
            {
                MessageBox.Show("Vui lòng nhập số điểm", "Thông báo");
                txtDiem.Focus();
                return;
            }
            if (txtDiem.Text.ToCharArray().Where(x => x == '.').Count() > 1 || float.Parse(txtDiem.Text) > 10)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số điểm", "Thông báo");
                txtDiem.Focus();
                return;
            }
            var data = new SubjectEx4()
            {
                Diem = txtDiem.Text,
                SoTin = int.Parse(txtSoTin.Text),
                TenMonHoc = cboMonHoc.Text
            };
            _lstDKMonHoc.Add(data);
            LoadData();
        }

        private void LoadData()
        {
            lstDK.Items.Clear();
            foreach (var item in _lstDKMonHoc)
            {
                lstDK.Items.Add(item.ToString());
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (_lstDKMonHoc.Count == 0)
                return;
            txtTongTin.Text = _lstDKMonHoc.Select(x => x.SoTin).Sum().ToString();
            txtTongDiem.Text = _lstDKMonHoc.Select(x => x.SoTin * float.Parse(x.Diem)).Sum().ToString();
            txtTB.Text = (double.Parse(txtTongDiem.Text) / double.Parse(txtTongTin.Text)).ToString(".00");
        }

        private void frmEx4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}