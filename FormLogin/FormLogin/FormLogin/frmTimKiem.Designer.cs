namespace FormLogin
{
    partial class frmTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiem));
            this.dgvTimHD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.cbxngay = new System.Windows.Forms.ComboBox();
            this.cbxthang = new System.Windows.Forms.ComboBox();
            this.btntimlai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimHD
            // 
            this.dgvTimHD.AllowUserToAddRows = false;
            this.dgvTimHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimHD.Location = new System.Drawing.Point(13, 253);
            this.dgvTimHD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTimHD.Name = "dgvTimHD";
            this.dgvTimHD.ReadOnly = true;
            this.dgvTimHD.RowHeadersWidth = 51;
            this.dgvTimHD.RowTemplate.Height = 24;
            this.dgvTimHD.Size = new System.Drawing.Size(776, 365);
            this.dgvTimHD.TabIndex = 0;
            this.dgvTimHD.DoubleClick += new System.EventHandler(this.dgvTimHD_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(32, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMahd
            // 
            this.txtMahd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMahd.ForeColor = System.Drawing.Color.Black;
            this.txtMahd.Location = new System.Drawing.Point(160, 87);
            this.txtMahd.Margin = new System.Windows.Forms.Padding(4);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(267, 30);
            this.txtMahd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(32, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(272, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "TÌM KIẾM HÓA ĐƠN";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtien.ForeColor = System.Drawing.Color.Black;
            this.txtTongtien.Location = new System.Drawing.Point(556, 87);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(233, 30);
            this.txtTongtien.TabIndex = 8;
            this.txtTongtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTongtien_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(458, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(275, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tháng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(32, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Năm";
            // 
            // txtNam
            // 
            this.txtNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.ForeColor = System.Drawing.Color.Black;
            this.txtNam.Location = new System.Drawing.Point(160, 203);
            this.txtNam.Margin = new System.Windows.Forms.Padding(4);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(132, 30);
            this.txtNam.TabIndex = 14;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam_KeyPress);
            // 
            // cbxngay
            // 
            this.cbxngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxngay.ForeColor = System.Drawing.Color.Black;
            this.cbxngay.FormattingEnabled = true;
            this.cbxngay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxngay.Location = new System.Drawing.Point(160, 143);
            this.cbxngay.Margin = new System.Windows.Forms.Padding(4);
            this.cbxngay.Name = "cbxngay";
            this.cbxngay.Size = new System.Drawing.Size(79, 31);
            this.cbxngay.TabIndex = 15;
            this.cbxngay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxngay_KeyPress);
            // 
            // cbxthang
            // 
            this.cbxthang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxthang.ForeColor = System.Drawing.Color.Black;
            this.cbxthang.FormattingEnabled = true;
            this.cbxthang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxthang.Location = new System.Drawing.Point(361, 143);
            this.cbxthang.Margin = new System.Windows.Forms.Padding(4);
            this.cbxthang.Name = "cbxthang";
            this.cbxthang.Size = new System.Drawing.Size(66, 31);
            this.cbxthang.TabIndex = 16;
            this.cbxthang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxthang_KeyPress);
            // 
            // btntimlai
            // 
            this.btntimlai.BackgroundImage = global::FormLogin.Properties.Resources.refesh;
            this.btntimlai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntimlai.Location = new System.Drawing.Point(375, 691);
            this.btntimlai.Margin = new System.Windows.Forms.Padding(4);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(99, 75);
            this.btntimlai.TabIndex = 18;
            this.btntimlai.UseVisualStyleBackColor = true;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = global::FormLogin.Properties.Resources.close;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Location = new System.Drawing.Point(195, 691);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(152, 75);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackgroundImage = global::FormLogin.Properties.Resources.Timkiem;
            this.btnTimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimkiem.Location = new System.Drawing.Point(19, 691);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(142, 75);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(15, 636);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(391, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nhấp đúp một dòng để xem thông tin chi tiết";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(510, 691);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(123, 65);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Trở lại";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // frmTimKiem
            // 
            this.AcceptButton = this.btnTimkiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 768);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cbxthang);
            this.Controls.Add(this.cbxngay);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtMahd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTimHD);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTimKiem";
            this.Text = " Tìm kiếm hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.ComboBox cbxngay;
        private System.Windows.Forms.ComboBox cbxthang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnback;
    }
}