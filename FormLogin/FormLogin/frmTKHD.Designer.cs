namespace FormLogin
{
    partial class frmTKHD
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.dtToi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.btnTK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTDT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txthd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tới ngày";
            // 
            // dtTu
            // 
            this.dtTu.CustomFormat = "dd/MM/yyyy";
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTu.Location = new System.Drawing.Point(38, 67);
            this.dtTu.Margin = new System.Windows.Forms.Padding(4);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(160, 27);
            this.dtTu.TabIndex = 2;
            // 
            // dtToi
            // 
            this.dtToi.CustomFormat = "dd/MM/yyyy";
            this.dtToi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToi.Location = new System.Drawing.Point(298, 67);
            this.dtToi.Margin = new System.Windows.Forms.Padding(4);
            this.dtToi.Name = "dtToi";
            this.dtToi.Size = new System.Drawing.Size(152, 27);
            this.dtToi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(151, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "BẢNG THỐNG KÊ";
            // 
            // dgvTK
            // 
            this.dgvTK.AllowUserToAddRows = false;
            this.dgvTK.AllowUserToDeleteRows = false;
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTK.Location = new System.Drawing.Point(7, 27);
            this.dgvTK.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.ReadOnly = true;
            this.dgvTK.RowHeadersWidth = 51;
            this.dgvTK.RowTemplate.Height = 24;
            this.dgvTK.Size = new System.Drawing.Size(542, 258);
            this.dgvTK.TabIndex = 5;
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(13, 577);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(90, 51);
            this.btnTK.TabIndex = 6;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng doanh thu:";
            // 
            // txtTDT
            // 
            this.txtTDT.Enabled = false;
            this.txtTDT.Location = new System.Drawing.Point(191, 136);
            this.txtTDT.Name = "txtTDT";
            this.txtTDT.Size = new System.Drawing.Size(165, 27);
            this.txtTDT.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTK);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 292);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Top 5 sản phẩm bán chạy";
            // 
            // txthd
            // 
            this.txthd.Enabled = false;
            this.txthd.Location = new System.Drawing.Point(191, 191);
            this.txthd.Name = "txthd";
            this.txthd.Size = new System.Drawing.Size(165, 27);
            this.txthd.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số hóa đơn đã bán:";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(110, 577);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(90, 51);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "Trở lại";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(207, 577);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(90, 51);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "Đóng";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frmTKHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 668);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txthd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtToi);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTKHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTKHD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.DateTimePicker dtToi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTK;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txthd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnexit;
    }
}