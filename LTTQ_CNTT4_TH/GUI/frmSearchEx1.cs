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
    public partial class frmSearchEx1 : Form
    {
        public frmSearchEx1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên trước khi tìm kiếm", "Thông báo");
                txtName.Focus();
                return;
            }
            var checkExist = DataContext.ClientEx1Context.Find(x => string.Compare(x.TenKH, txtName.Text, true) == 0);
            if (checkExist == null)
            {
                MessageBox.Show($"Khách hàng {txtName.Text} chưa có trong hệ thống", "Thông báo");
            }
            else
            {
                MessageBox.Show($"Khách hàng {txtName.Text} phải đống {checkExist.GetMoney()} đ", "Thông báo");
            }
        }
    }
}