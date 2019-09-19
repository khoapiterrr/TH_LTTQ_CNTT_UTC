namespace LTTQ_CNTT4_TH.GUI
{
    partial class frmEx13
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnEnterArr = new System.Windows.Forms.Button();
            this.lblArr = new System.Windows.Forms.Label();
            this.btnSearchMin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số phần tử";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(153, 22);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(234, 22);
            this.txtNum.TabIndex = 1;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // btnEnterArr
            // 
            this.btnEnterArr.Location = new System.Drawing.Point(417, 14);
            this.btnEnterArr.Name = "btnEnterArr";
            this.btnEnterArr.Size = new System.Drawing.Size(135, 39);
            this.btnEnterArr.TabIndex = 2;
            this.btnEnterArr.Text = "Nhập dãy";
            this.btnEnterArr.UseVisualStyleBackColor = true;
            this.btnEnterArr.Click += new System.EventHandler(this.btnEnterArr_Click);
            // 
            // lblArr
            // 
            this.lblArr.AutoSize = true;
            this.lblArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArr.ForeColor = System.Drawing.Color.Red;
            this.lblArr.Location = new System.Drawing.Point(53, 76);
            this.lblArr.Name = "lblArr";
            this.lblArr.Size = new System.Drawing.Size(0, 18);
            this.lblArr.TabIndex = 3;
            this.lblArr.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSearchMin
            // 
            this.btnSearchMin.Location = new System.Drawing.Point(29, 133);
            this.btnSearchMin.Name = "btnSearchMin";
            this.btnSearchMin.Size = new System.Drawing.Size(187, 43);
            this.btnSearchMin.TabIndex = 4;
            this.btnSearchMin.Text = "Tìm số dương nhỏ nhất";
            this.btnSearchMin.UseVisualStyleBackColor = true;
            this.btnSearchMin.Click += new System.EventHandler(this.btnSearchMin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập một số";
            // 
            // txtNumSearch
            // 
            this.txtNumSearch.Location = new System.Drawing.Point(153, 243);
            this.txtNumSearch.Multiline = true;
            this.txtNumSearch.Name = "txtNumSearch";
            this.txtNumSearch.Size = new System.Drawing.Size(203, 46);
            this.txtNumSearch.TabIndex = 6;
            this.txtNumSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(396, 243);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 39);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Location = new System.Drawing.Point(221, 315);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(135, 39);
            this.btnRefesh.TabIndex = 2;
            this.btnRefesh.Text = "Làm lại";
            this.btnRefesh.UseVisualStyleBackColor = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(375, 315);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 39);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(26, 193);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(0, 17);
            this.lblMin.TabIndex = 7;
            // 
            // frmEx13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 373);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtNumSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchMin);
            this.Controls.Add(this.lblArr);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEnterArr);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Name = "frmEx13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEx13";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnEnterArr;
        private System.Windows.Forms.Label lblArr;
        private System.Windows.Forms.Button btnSearchMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMin;
    }
}