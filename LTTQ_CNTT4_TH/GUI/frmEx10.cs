using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LTTQ_CNTT4_TH.GUI
{
    public partial class frmEx10 : Form
    {
        public frmEx10()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtc.Enabled = false;
            txtc.Text = string.Empty;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtc.Enabled = true;
        }

        private void frmEx10_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            txtRes.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txta.Text = string.Empty;
            txtb.Text = string.Empty;
            txtc.Text = string.Empty;
            radioButton1.Checked = true;
            txtRes.Text = string.Empty;
        }

        private bool ValidNumber(string num)
        {
            if (num.ToCharArray().Where(x => x.Equals('.')).Count() > 1)
                return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(ValidNumber(txta.Text) && ValidNumber(txtb.Text) && ValidNumber(txtc.Text)))
            {
                MessageBox.Show("Số không đúng định dạng", "Thông báo");
            }
            if (string.IsNullOrEmpty(txta.Text))
            {
                MessageBox.Show("Vui lòng nhập số a");
                txta.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtb.Text))
            {
                MessageBox.Show("Vui lòng nhập số b");
                txtb.Focus();
                return;
            }
            if (radioButton1.Checked)
            {
                txtRes.Text = ptb2(0, double.Parse(txta.Text), double.Parse(txtb.Text));
                return;
            }
            if (string.IsNullOrEmpty(txtc.Text))
            {
                MessageBox.Show("Vui lòng nhập số b");
                txtb.Focus();
                return;
            }
            txtRes.Text = ptb2(double.Parse(txta.Text), double.Parse(txtb.Text), double.Parse(txtc.Text));
            return;
        }

        //private double ptbn(double a, double b) => -b / a;
        private string ptb2(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);
            if (a == 0)
            {
                if (b == 0 && c != 0)
                    return "Phương trình vô nghiệm";
                else
                {
                    return "Phương trình có nghiệm là : " + (-c / b).ToString();
                }
            }
            else
            {
                if (delta < 0)
                    return "Phương trình vô nghiệm";
                else if (delta == 0)
                {
                    return "Phương trình có nghiệm là : " + (-b / 2 * a).ToString();
                }
                else
                {
                    var x1 = (-b - (double)Math.Sqrt(delta)) / 2 * a;
                    var x2 = (-b + (double)Math.Sqrt(delta)) / 2 * a;
                    return $"Phương trình có nghiệm là : \n x1= {x1} \n x2 = {x2}";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
                e.Handled = true;
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
                e.Handled = true;
        }

        private void txtc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
                e.Handled = true;
        }
    }
}