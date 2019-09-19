using System;
using System.Windows.Forms;

namespace LTTQ_CNTT4_TH.GUI
{
    public partial class frmSearchEx2 : Form
    {
        public frmSearchEx2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã cần tìm", "Thông báo");
                txtMa.Focus();
                return;
            }
            var check = DataContext.ClientEx2Context.Find(x => x.Id == txtMa.Text);
            if (check == null)
            {
                MessageBox.Show($"khách hàng có mã {txtMa.Text} chưa có trong danh sách", "Thông báo");
                return;
            }
            MessageBox.Show($"khách hàng có mã {txtMa.Text} phải trả {check.GetMoney()}", "Thông báo");
        }
    }
}