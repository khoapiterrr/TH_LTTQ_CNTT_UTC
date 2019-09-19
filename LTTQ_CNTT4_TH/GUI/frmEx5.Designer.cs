namespace LTTQ_CNTT4_TH.GUI
{
    partial class frmEx5
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstNum = new System.Windows.Forms.ListBox();
            this.btnAddLst = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(83, 24);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(116, 42);
            this.txtNum.TabIndex = 3;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập số";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstNum);
            this.groupBox1.Location = new System.Drawing.Point(205, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 307);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dãy số";
            // 
            // lstNum
            // 
            this.lstNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNum.FormattingEnabled = true;
            this.lstNum.ItemHeight = 16;
            this.lstNum.Location = new System.Drawing.Point(3, 18);
            this.lstNum.Name = "lstNum";
            this.lstNum.Size = new System.Drawing.Size(191, 286);
            this.lstNum.TabIndex = 0;
            // 
            // btnAddLst
            // 
            this.btnAddLst.Location = new System.Drawing.Point(44, 97);
            this.btnAddLst.Name = "btnAddLst";
            this.btnAddLst.Size = new System.Drawing.Size(141, 33);
            this.btnAddLst.TabIndex = 5;
            this.btnAddLst.Text = "Thêm vào danh sách";
            this.btnAddLst.UseVisualStyleBackColor = true;
            this.btnAddLst.Click += new System.EventHandler(this.btnAddLst_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(44, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 33);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa khỏi danh sách";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Location = new System.Drawing.Point(44, 209);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(141, 33);
            this.btnRefesh.TabIndex = 5;
            this.btnRefesh.Text = "Làm mới";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(408, 33);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(96, 33);
            this.btnSum.TabIndex = 5;
            this.btnSum.Text = "Tính tổng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(408, 89);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(96, 33);
            this.btnMax.TabIndex = 5;
            this.btnMax.Text = "Tìm max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(408, 145);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.ForeColor = System.Drawing.Color.Red;
            this.lblSum.Location = new System.Drawing.Point(529, 41);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(61, 17);
            this.lblSum.TabIndex = 2;
            this.lblSum.Text = "Nhập số";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.ForeColor = System.Drawing.Color.Red;
            this.lblMax.Location = new System.Drawing.Point(529, 97);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(61, 17);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Nhập số";
            // 
            // frmEx5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 344);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnAddLst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label1);
            this.Name = "frmEx5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEx5";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEx5_FormClosed);
            this.Load += new System.EventHandler(this.frmEx5_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstNum;
        private System.Windows.Forms.Button btnAddLst;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblMax;
    }
}