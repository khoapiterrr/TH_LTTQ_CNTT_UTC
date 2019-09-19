using LTTQ_CNTT4_TH.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LTTQ_CNTT4_TH.GUI
{
    public partial class frmEx9 : Form
    {
        /// <summary>
        /// Danh sách các loại sách và giá tiền
        /// </summary>
        private List<Tuple<long, string>> lstBooks = new List<Tuple<long, string>>()
        {
            new Tuple<long, string>(22000,"Tin đại cương"),
            new Tuple<long, string>(27000,"Tiếng Anh F2"),
            new Tuple<long, string>(25000,"Giải tích F1"),
            new Tuple<long, string>(26000,"Đại số tuyến tính "),
        };

        private readonly List<Ex9> _lstSachMua;

        public frmEx9()
        {
            InitializeComponent();

            _lstSachMua = new List<Ex9>();
        }

        /// <summary>
        /// Fill data từ list vào combox
        /// </summary>
        private void LoadCbo()
        {
            cboBooks.ValueMember = "item1";
            cboBooks.DisplayMember = "item2";
            cboBooks.DataSource = lstBooks;
        }

        private void frmEx9_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void cboBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Text = cboBooks.SelectedValue.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtTT.Text = "5";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtTT.Text = "10";
        }

        private void frmEx9_Load(object sender, EventArgs e)
        {
            LoadCbo();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("VUi lòng nhập số lượng sách");
                return;
            }
            var data = new Ex9()
            {
                Gia = long.Parse(txtPrice.Text),
                GiamGia = int.Parse(txtTT.Text),
                SoLuong = int.Parse(txtAmount.Text),
                TenSach = cboBooks.Text
            };
            _lstSachMua.Add(data);
            LoadData();
        }

        private void LoadData()
        {
            listBox1.Items.Clear();
            foreach (var item in _lstSachMua)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTongTIen.Text = _lstSachMua.Select(x => x.ThanhTien()).Sum().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_lstSachMua.Count() == 0) return;
            var selected = listBox1.SelectedIndex;
            if (selected == -1)
            {
                MessageBox.Show("Vui lòng chọn trước khi xóa");
                return;
            }
            _lstSachMua.RemoveAt(selected);
            LoadData();
        }
    }
}