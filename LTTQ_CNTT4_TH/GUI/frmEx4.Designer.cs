namespace LTTQ_CNTT4_TH.GUI
{
    partial class frmEx4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddLst = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtSoTin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstDK = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongTin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTB = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddLst);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.txtSoTin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboMonHoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnAddLst
            // 
            this.btnAddLst.Location = new System.Drawing.Point(72, 271);
            this.btnAddLst.Name = "btnAddLst";
            this.btnAddLst.Size = new System.Drawing.Size(129, 34);
            this.btnAddLst.TabIndex = 4;
            this.btnAddLst.Text = "Thêm vào DS";
            this.btnAddLst.UseVisualStyleBackColor = true;
            this.btnAddLst.Click += new System.EventHandler(this.btnAddLst_Click);
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(119, 187);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(100, 22);
            this.txtDiem.TabIndex = 3;
            this.txtDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiem_KeyPress);
            // 
            // txtSoTin
            // 
            this.txtSoTin.Location = new System.Drawing.Point(119, 127);
            this.txtSoTin.Name = "txtSoTin";
            this.txtSoTin.Size = new System.Drawing.Size(100, 22);
            this.txtSoTin.TabIndex = 3;
            this.txtSoTin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTin_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số tín chỉ";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Items.AddRange(new object[] {
            "Tin học đại cương",
            "Giải tích F1",
            "Tiếng Anh A0",
            "Triết học Mác – Lênin",
            "Vật lý F1"});
            this.cboMonHoc.Location = new System.Drawing.Point(28, 81);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(252, 24);
            this.cboMonHoc.TabIndex = 1;
            this.cboMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMonHoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn học";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDK);
            this.groupBox2.Location = new System.Drawing.Point(317, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 262);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách môn học";
            // 
            // lstDK
            // 
            this.lstDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDK.FormattingEnabled = true;
            this.lstDK.ItemHeight = 16;
            this.lstDK.Location = new System.Drawing.Point(3, 18);
            this.lstDK.Name = "lstDK";
            this.lstDK.Size = new System.Drawing.Size(454, 241);
            this.lstDK.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng số tín chỉ";
            // 
            // txtTongTin
            // 
            this.txtTongTin.Location = new System.Drawing.Point(440, 297);
            this.txtTongTin.Name = "txtTongTin";
            this.txtTongTin.Size = new System.Drawing.Size(100, 22);
            this.txtTongTin.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng số điểm";
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Location = new System.Drawing.Point(660, 297);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.Size = new System.Drawing.Size(100, 22);
            this.txtTongDiem.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Điểm trung bình";
            // 
            // txtTB
            // 
            this.txtTB.Location = new System.Drawing.Point(493, 334);
            this.txtTB.Name = "txtTB";
            this.txtTB.Size = new System.Drawing.Size(136, 22);
            this.txtTB.TabIndex = 3;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(389, 387);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(136, 34);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(601, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmEx4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTB);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongTin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "frmEx4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEx4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEx4_FormClosed);
            this.Load += new System.EventHandler(this.frmEx4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtSoTin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTB;
        private System.Windows.Forms.Button btnAddLst;
        private System.Windows.Forms.ListBox lstDK;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnExit;
    }
}