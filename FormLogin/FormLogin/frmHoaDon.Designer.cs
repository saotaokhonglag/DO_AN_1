namespace FormLogin
{
    partial class frmHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttendia = new System.Windows.Forms.TextBox();
            this.cbxMadia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDia = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtngayban = new System.Windows.Forms.DateTimePicker();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTke = new System.Windows.Forms.Button();
            this.btnadd_HD = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDia)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Location = new System.Drawing.Point(422, 64);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.ReadOnly = true;
            this.txtThanhtien.Size = new System.Drawing.Size(159, 28);
            this.txtThanhtien.TabIndex = 9;
            this.txtThanhtien.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 24);
            this.label9.TabIndex = 8;
            this.label9.Text = "Thành tiền:";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(118, 63);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(159, 28);
            this.txtsoluong.TabIndex = 7;
            this.txtsoluong.Text = "0";
            this.txtsoluong.TextChanged += new System.EventHandler(this.txtsoluong_TextChanged);
            this.txtsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoluong_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Số lượng:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(695, 16);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(159, 28);
            this.txtGia.TabIndex = 5;
            this.txtGia.Text = "0";
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(650, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Giá:";
            // 
            // txttendia
            // 
            this.txttendia.Location = new System.Drawing.Point(422, 14);
            this.txttendia.Name = "txttendia";
            this.txttendia.ReadOnly = true;
            this.txttendia.Size = new System.Drawing.Size(159, 28);
            this.txttendia.TabIndex = 3;
            // 
            // cbxMadia
            // 
            this.cbxMadia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMadia.FormattingEnabled = true;
            this.cbxMadia.Location = new System.Drawing.Point(118, 15);
            this.cbxMadia.Name = "cbxMadia";
            this.cbxMadia.Size = new System.Drawing.Size(159, 30);
            this.cbxMadia.TabIndex = 2;
            this.cbxMadia.SelectedIndexChanged += new System.EventHandler(this.cbxMadia_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã đĩa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên đĩa:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDia);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 398);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // dgvDia
            // 
            this.dgvDia.AllowUserToAddRows = false;
            this.dgvDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDia.Location = new System.Drawing.Point(3, 129);
            this.dgvDia.Name = "dgvDia";
            this.dgvDia.ReadOnly = true;
            this.dgvDia.RowHeadersWidth = 51;
            this.dgvDia.RowTemplate.Height = 24;
            this.dgvDia.Size = new System.Drawing.Size(862, 203);
            this.dgvDia.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtThanhtien);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtsoluong);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtGia);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txttendia);
            this.panel3.Controls.Add(this.cbxMadia);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(3, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(862, 105);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(339, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // dtngayban
            // 
            this.dtngayban.CustomFormat = "dd-MM-yyyy";
            this.dtngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngayban.Location = new System.Drawing.Point(149, 83);
            this.dtngayban.Name = "dtngayban";
            this.dtngayban.Size = new System.Drawing.Size(209, 30);
            this.dtngayban.TabIndex = 3;
            this.dtngayban.Value = new System.DateTime(2020, 11, 26, 0, 0, 0, 0);
            // 
            // txtMahd
            // 
            this.txtMahd.Enabled = false;
            this.txtMahd.Location = new System.Drawing.Point(149, 41);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(209, 30);
            this.txtMahd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày tạo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvHD);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(872, 827);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtngayban);
            this.groupBox1.Controls.Add(this.txtMahd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // dgvHD
            // 
            this.dgvHD.AllowUserToAddRows = false;
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHD.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHD.Location = new System.Drawing.Point(6, 341);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.ReadOnly = true;
            this.dgvHD.RowHeadersWidth = 51;
            this.dgvHD.RowTemplate.Height = 24;
            this.dgvHD.Size = new System.Drawing.Size(863, 226);
            this.dgvHD.TabIndex = 9;
            this.dgvHD.DoubleClick += new System.EventHandler(this.dgvHD_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txttongtien);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(3, 574);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(910, 51);
            this.panel4.TabIndex = 7;
            // 
            // txttongtien
            // 
            this.txttongtien.Enabled = false;
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtien.Location = new System.Drawing.Point(663, 9);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(203, 30);
            this.txttongtien.TabIndex = 2;
            this.txttongtien.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(528, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tổng tiền:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(19, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ấn đúp một dòng để xóa";
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::FormLogin.Properties.Resources.ADDSP;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Location = new System.Drawing.Point(1049, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(131, 66);
            this.btnThem.TabIndex = 0;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTke
            // 
            this.btnTke.BackgroundImage = global::FormLogin.Properties.Resources.Tke;
            this.btnTke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTke.Location = new System.Drawing.Point(878, 154);
            this.btnTke.Name = "btnTke";
            this.btnTke.Size = new System.Drawing.Size(136, 66);
            this.btnTke.TabIndex = 10;
            this.btnTke.UseVisualStyleBackColor = true;
            this.btnTke.Click += new System.EventHandler(this.btnTke_Click);
            // 
            // btnadd_HD
            // 
            this.btnadd_HD.BackgroundImage = global::FormLogin.Properties.Resources.add_hoadon2;
            this.btnadd_HD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadd_HD.ForeColor = System.Drawing.Color.Blue;
            this.btnadd_HD.Location = new System.Drawing.Point(877, 7);
            this.btnadd_HD.Name = "btnadd_HD";
            this.btnadd_HD.Size = new System.Drawing.Size(137, 66);
            this.btnadd_HD.TabIndex = 9;
            this.btnadd_HD.UseVisualStyleBackColor = true;
            this.btnadd_HD.Click += new System.EventHandler(this.btnadd_HD_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackgroundImage = global::FormLogin.Properties.Resources.close;
            this.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDong.ForeColor = System.Drawing.Color.Blue;
            this.btnDong.Location = new System.Drawing.Point(1211, 80);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(131, 66);
            this.btnDong.TabIndex = 4;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackgroundImage = global::FormLogin.Properties.Resources.Timkiem;
            this.btntimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntimkiem.ForeColor = System.Drawing.Color.Blue;
            this.btntimkiem.Location = new System.Drawing.Point(1049, 154);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(131, 66);
            this.btntimkiem.TabIndex = 0;
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackgroundImage = global::FormLogin.Properties.Resources.InHD;
            this.btnIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIn.ForeColor = System.Drawing.Color.Blue;
            this.btnIn.Location = new System.Drawing.Point(1049, 85);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(131, 62);
            this.btnIn.TabIndex = 3;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackgroundImage = global::FormLogin.Properties.Resources.huy1;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuy.ForeColor = System.Drawing.Color.Blue;
            this.btnHuy.Location = new System.Drawing.Point(878, 83);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(136, 66);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = global::FormLogin.Properties.Resources.LuuHD;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Location = new System.Drawing.Point(1211, 7);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(131, 66);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmHoaDon
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 815);
            this.Controls.Add(this.btnTke);
            this.Controls.Add(this.btnadd_HD);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDia)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttendia;
        private System.Windows.Forms.ComboBox cbxMadia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btntimkiem;
        public System.Windows.Forms.TextBox txtMahd;
        public System.Windows.Forms.DateTimePicker dtngayban;
        public System.Windows.Forms.DataGridView dgvHD;
        public System.Windows.Forms.TextBox txttongtien;
        public System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTke;
        public System.Windows.Forms.Button btnLuu;
        public System.Windows.Forms.Button btnHuy;
        public System.Windows.Forms.Button btnadd_HD;
        public System.Windows.Forms.DataGridView dgvDia;
    }
}