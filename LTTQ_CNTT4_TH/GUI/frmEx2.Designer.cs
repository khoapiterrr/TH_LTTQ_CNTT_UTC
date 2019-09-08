namespace LTTQ_CNTT4_TH.GUI
{
    partial class frmEx2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lstKH = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddDS = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnPhatLoc = new System.Windows.Forms.RadioButton();
            this.rbtnThuong = new System.Windows.Forms.RadioButton();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.lstKH);
            this.groupBox2.Location = new System.Drawing.Point(397, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 501);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(365, 452);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 35);
            this.button4.TabIndex = 1;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 452);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "Tìm kiếm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstKH
            // 
            this.lstKH.FormattingEnabled = true;
            this.lstKH.ItemHeight = 16;
            this.lstKH.Location = new System.Drawing.Point(6, 20);
            this.lstKH.Name = "lstKH";
            this.lstKH.Size = new System.Drawing.Size(685, 404);
            this.lstKH.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnAddDS);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cboTime);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMoney);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAddr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 501);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng gửi tích kiệm";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(91, 229);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(121, 22);
            this.dtpDate.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "(Tháng)";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(179, 445);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddDS
            // 
            this.btnAddDS.Location = new System.Drawing.Point(48, 445);
            this.btnAddDS.Name = "btnAddDS";
            this.btnAddDS.Size = new System.Drawing.Size(113, 35);
            this.btnAddDS.TabIndex = 1;
            this.btnAddDS.Text = "Thêm vào DS";
            this.btnAddDS.UseVisualStyleBackColor = true;
            this.btnAddDS.Click += new System.EventHandler(this.btnAddDS_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnPhatLoc);
            this.groupBox3.Controls.Add(this.rbtnThuong);
            this.groupBox3.Location = new System.Drawing.Point(42, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 90);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại tích kiệm";
            // 
            // rbtnPhatLoc
            // 
            this.rbtnPhatLoc.AutoSize = true;
            this.rbtnPhatLoc.Location = new System.Drawing.Point(122, 34);
            this.rbtnPhatLoc.Name = "rbtnPhatLoc";
            this.rbtnPhatLoc.Size = new System.Drawing.Size(80, 21);
            this.rbtnPhatLoc.TabIndex = 0;
            this.rbtnPhatLoc.TabStop = true;
            this.rbtnPhatLoc.Text = "Phát lộc";
            this.rbtnPhatLoc.UseVisualStyleBackColor = true;
            // 
            // rbtnThuong
            // 
            this.rbtnThuong.AutoSize = true;
            this.rbtnThuong.Location = new System.Drawing.Point(6, 34);
            this.rbtnThuong.Name = "rbtnThuong";
            this.rbtnThuong.Size = new System.Drawing.Size(78, 21);
            this.rbtnThuong.TabIndex = 0;
            this.rbtnThuong.TabStop = true;
            this.rbtnThuong.Text = "Thường";
            this.rbtnThuong.UseVisualStyleBackColor = true;
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12"});
            this.cboTime.Location = new System.Drawing.Point(91, 277);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(121, 24);
            this.cboTime.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thời gian gửi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày gửi";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(91, 177);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(261, 22);
            this.txtMoney.TabIndex = 1;
            this.txtMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoney_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số tiền gửi";
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(91, 123);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(261, 22);
            this.txtAddr.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 22);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(91, 37);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(261, 22);
            this.txtMaKH.TabIndex = 1;
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKH_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH";
            // 
            // frmEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 529);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEx2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài tập 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEx2_FormClosed);
            this.Load += new System.EventHandler(this.frmEx2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddDS;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnPhatLoc;
        private System.Windows.Forms.RadioButton rbtnThuong;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label1;
    }
}