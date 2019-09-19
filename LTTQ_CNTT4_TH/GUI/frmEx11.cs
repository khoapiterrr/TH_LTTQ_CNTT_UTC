using System;
using System.Drawing;
using System.Windows.Forms;

namespace LTTQ_CNTT4_TH.GUI
{
    public partial class frmEx11 : Form
    {
        public frmEx11()
        {
            InitializeComponent();
        }

        private void frmEx11_Load(object sender, EventArgs e)
        {
            //txtText. = HorizontalAlignment.Center;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fontFamily = comboBox1.Text;
            var x = txtText.Font.FontFamily;
            txtText.Font = new Font(fontFamily, txtText.Font.Size, txtText.Font.Style, txtText.Font.Unit);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fontsize = comboBox2.Text;
            txtText.Font = new Font(txtText.Font.FontFamily, float.Parse(fontsize), txtText.Font.Style, txtText.Font.Unit);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtText.ForeColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtText.ForeColor = Color.FromArgb(15, 255, 79);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtText.ForeColor = Color.Black;
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                var data = txtText.Font.Style ^ FontStyle.Italic;
                txtText.Font = new Font(txtText.Font, txtText.Font.Style | FontStyle.Italic);
            }
            else
            {
                txtText.Font = new Font(txtText.Font, txtText.Font.Style ^ FontStyle.Italic);
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtText.Font = new Font(txtText.Font, txtText.Font.Style | FontStyle.Bold);
            }
            else
            {
                txtText.Font = new Font(txtText.Font, txtText.Font.Style ^ FontStyle.Bold);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                txtText.Font = new Font(txtText.Font, txtText.Font.Style | FontStyle.Underline);
            }
            else
            {
                txtText.Font = new Font(txtText.Font, txtText.Font.Style ^ FontStyle.Underline);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton4.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain frm = new frmMain();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}