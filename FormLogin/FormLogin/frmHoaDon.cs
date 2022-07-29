using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using FormLogin.Core;
using OfficeOpenXml;
using System.IO;
using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Drawing;

namespace FormLogin
{
    public partial class frmHoaDon : Form    
    {
        DBManager db = null;
        SqlConnection conn = null;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        string sql;
        // list dùng để thêm mã đĩa mỗi lần thêm vào dgv
        List<string> MaDia = new List<string>();
        public frmHoaDon()
        {
            InitializeComponent();
            db = new DBManager();
            conn = db.ketnoi();
            dt.Columns.Add("Mã đĩa");
            dt.Columns.Add("Tên đĩa");
            dt.Columns.Add("Giá bán");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Thành tiền");

            this.dgvDia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHD.DataSource = dt;
        }


        public void tongtien()
        {
            int tt = dgvHD.Rows.Count;
            float tongtien = 0;
            for(int i = 0; i < tt; i++)
            {
                tongtien += float.Parse(dgvHD.Rows[i].Cells["Thành tiền"].Value.ToString());
            }
            txttongtien.Text = tongtien.ToString();

        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            taicb();
            taidulieu();
        }
        public void taicb()
        {
            cbxMadia.DataSource = db.ds_Dia();
            cbxMadia.DisplayMember = "MaDia";
            cbxMadia.ValueMember = "MaDia"; 
        }
        public void taidulieu()
        {
            BindingSource bd = new BindingSource();
            bd.DataSource = db.ds_Dia();
            dgvDia.DataSource = bd;

            cbxMadia.DataBindings.Clear();
            cbxMadia.DataBindings.Add(new Binding("Text", bd, "Madia"));

            txttendia.DataBindings.Clear();
            txttendia.DataBindings.Add(new Binding("Text", bd, "TenDia"));

            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add(new Binding("Text", bd, "GiaBan"));
    
        }

        
        public Boolean KTSL(string MaDia, int SLmua)
        {
            Boolean laco = false;
            //Lấy sl tồn kho
            string sql = "select * from DiaGame where MaDia = '" + MaDia + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            using (var sl = cmd1.ExecuteReader())
            {
                int sltk = 0;
                if (sl.HasRows)
                {
                    while (sl.Read())
                    {
                        sltk = Convert.ToInt32(sl.GetValue(3));
                    }
                }
                // So sánh sl tồn và sl mua
                if (sltk < SLmua)
                {
                    laco = false;
                }
                else
                    laco = true;
                return laco;
            }
        }
        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            int tt, sl, dg;
            if (txtsoluong.Text == "")
            {
                sl = 0;
            }
            else
            {
                sl = Convert.ToInt32(txtsoluong.Text);
            }
            if (txtGia.Text == "")
            {
                dg = 0;
            }
            else
            {
                dg = Convert.ToInt32(txtGia.Text);
            }
            tt = sl * dg;
            txtThanhtien.Text = tt.ToString();
        }
        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            int tt, sl, dg;
            if (txtsoluong.Text == "")
            {
                sl = 0;
            }
            else
            {
                sl = Convert.ToInt32(txtsoluong.Text);
            }
            if (txtGia.Text == "")
            {
                dg = 0;
            }
            else
            {
                dg = Convert.ToInt32(txtGia.Text);
            }
            tt = sl * dg;
            txtThanhtien.Text = tt.ToString();
        }
        private void btnadd_HD_Click(object sender, EventArgs e)
        {
            txtMahd.Text = db.CreateKey("HD");
            dgvHD.DataSource = null;
            dgvHD.DataSource = dt;
            txttongtien.Text = "0";
            dtngayban.Text = DateTime.Now.ToShortDateString();
          
            btnadd_HD.Enabled = false;
            btnHuy.Enabled = false;
            btnIn.Enabled = false;
            dgvHD.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow row;
            row = dt.NewRow();
            if (this.txtMahd.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                txtMahd.Focus();
                return;
            }
            if (this.cbxMadia.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập mã đĩa", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                cbxMadia.Focus();
                return;
            }
            if (this.txttendia.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập tên đĩa", "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                txttendia.Focus();
                return;
            }
            if (this.txtGia.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải nhập giá bán", "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                txtGia.Focus();
                return;
            }
            if ((this.txtsoluong.Text.Equals("")) || (this.txtsoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                txtsoluong.Focus();
                return;
            }
            if (KTSL(cbxMadia.Text, Convert.ToInt32(txtsoluong.Text)) == false)
            {
                MessageBox.Show("Số lượng đĩa không đủ! Vui lòng kiểm tra lại");
            }
            else
            {
                // Check trùng mã đĩa để cộng dồn
                if (MaDia.Contains(cbxMadia.Text))
                {
                    if (MessageBox.Show("Mã đĩa này đã tồn tại bạn có muốn cộng dồn số lượng không?", "Xác nhận!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int SLM;
                        int TMM;
                        SLM = Convert.ToInt32(txtsoluong.Text) + Convert.ToInt32(dgvHD.CurrentRow.Cells["Số lượng"].Value.ToString());
                        TMM = Convert.ToInt32(txtThanhtien.Text) + Convert.ToInt32(dgvHD.CurrentRow.Cells["Thành tiền"].Value.ToString());
                        dgvHD.CurrentRow.Cells["Số lượng"].Value = SLM.ToString();
                        dgvHD.CurrentRow.Cells["Thành tiền"].Value = TMM.ToString();
                        txtsoluong.Text = "0";
                        txtThanhtien.Text = "0";
                    }
                }
                else
                {
                   
                    row["Mã đĩa"] = cbxMadia.Text;
                    row["Tên đĩa"] = txttendia.Text;
                    row["Giá bán"] = txtGia.Text;
                    row["Số lượng"] = txtsoluong.Text;
                    row["Thành tiền"] = txtThanhtien.Text;
                    dt.Rows.Add(row);
                    // Thêm mã đĩa vào list để check trùng
                    MaDia.Add(cbxMadia.Text);

                    txtsoluong.Text = "0";
                    txtThanhtien.Text = "0";
                }
                foreach (String item in MaDia)
                {
                    Console.WriteLine(item);
                }
            }
            int tt = dgvHD.Rows.Count;
            float tongtien = 0;
            for (int i = 0; i < tt; i++)
            {
                tongtien += float.Parse(dgvHD.Rows[i].Cells["Thành tiền"].Value.ToString());
            }
            txttongtien.Text = tongtien.ToString();
            btnHuy.Enabled = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            sql = "insert into HoaDon(MaHD, NgayTao, TongTien) values('" + txtMahd.Text.Trim() + "','" 
                + dtngayban.Text + "','" + txttongtien.Text + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            for (int i = 0; i < dgvHD.RowCount; i++)
            {
                sql = "insert into CTHoaDon (MaHD, MaDia, SoLuong, ThanhTien) values('" + txtMahd.Text + "','" + dgvHD.Rows[i].Cells["Mã đĩa"].Value + "','"
                    + dgvHD.Rows[i].Cells["Số lượng"].Value + "','" + dgvHD.Rows[i].Cells["Thành tiền"].Value + "')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();


                int SLcon;

                string sl = "select SoLuongCon from DiaGame where MaDia= '" + dgvHD.Rows[i].Cells["Mã đĩa"].Value + "'";
                cmd = new SqlCommand(sl, conn);
                string sltk = "";
                SqlDataReader slc = cmd.ExecuteReader();
                while (slc.Read())
                    sltk = slc.GetValue(0).ToString();
                SLcon = Convert.ToInt32(sltk) - Convert.ToInt32(dgvHD.Rows[i].Cells["Số lượng"].Value);

                slc.Close();

                sql = "Update DiaGame set SoLuongCon=" + SLcon
                    + "where MaDia='" + dgvHD.Rows[i].Cells["Mã đĩa"].Value+ "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lưu hóa đơn thành công!");
              
            }

            taidulieu();
            btnadd_HD.Enabled = true;
            btnLuu.Enabled = false;
            btnIn.Enabled = true;
            btnThem.Enabled = false;
            btnHuy.Enabled = false;
            dgvHD.Enabled = false;
        }
        
        
        private void dgvHD_DoubleClick(object sender, EventArgs e)
        {
            float tt = 0;
            

            if (this.dgvHD.SelectedRows.Count>0)
            {
                tt = float.Parse(txttongtien.Text) - float.Parse(dgvHD.SelectedRows[0].Cells["Thành tiền"].Value.ToString());
                
                txttongtien.Text = tt.ToString();
            }
            while (dgvHD.Rows.Count > 0)
            {
                dgvHD.Rows.Remove(dgvHD.Rows[0]);
            }

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMahd.Text = "";
            txttongtien.Text = "0";
            while (dgvHD.Rows.Count > 0)
            {
                dgvHD.Rows.Remove(dgvHD.Rows[0]);
            }
            btnLuu.Enabled = false;
            btnIn.Enabled = false;
            btnadd_HD.Enabled = true;
        }

        private void cbxMadia_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "select TenDia from DiaGame where MaDia ='" + cbxMadia.SelectedValue + "'";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader t= cmd.ExecuteReader();
            while(t.Read())
            {
                txttendia.Text = t.GetValue(0).ToString();
            }

            t.Close();
            sql = "select GiaBan from DiaGame where MaDia ='" + cbxMadia.SelectedValue + "'";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader g = cmd.ExecuteReader();
            while (g.Read())
            {
                txtGia.Text = g.GetValue(0).ToString();
            }
            g.Close();
            
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // giới hạn ko cho nhập chữ và lớn hơn 9
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn trang này không?", "Thông báo!",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
                 frmTimKiem tk = new frmTimKiem();
            tk.StartPosition = FormStartPosition.CenterParent;
            tk.ShowDialog();
        
        }
        private void btnIn_Click(object sender, EventArgs e)
        {

            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange; // Làm việc với ô của ex
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Cửa hàng đĩa Game TN";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Mỹ Xuyên - Sóc Trăng";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0855633053";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Lấy thông tin chung
            sql = "Select MaHD, NgayTao, TongTien from HoaDon where MaHD = '" + txtMahd.Text + "'";
            tblThongtinHD = db.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Font.Bold = true;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();

            //Lấy thông tin mặt hàng
            sql = "select DiaGame.TenDia, CTHoaDon.SoLuong, DiaGame.GiaBan, CTHoaDon.ThanhTien from CTHoaDon join DiaGame on CTHoaDon.MaDia = DiaGame.MaDia where MaHD = '"
                + txtMahd.Text + "'";
            tblThongtinHang = db.GetDataToTable(sql);
            exRange.Range["A8:E8"].Font.Bold = true;
            exRange.Range["A8:E8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:E11"].ColumnWidth = 12;
            exRange.Range["A8:A8"].Value = "STT";
            exRange.Range["B8:B8"].Value = "Tên hàng";
            exRange.Range["C8:C8"].Value = "Số lượng";
            exRange.Range["D8:D8"].Value = "Giá bán";
            exRange.Range["E8:E8"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 9] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 9] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 9] = tblThongtinHang.Rows[hang][cot].ToString();
                }
            }
            exRange = exSheet.Cells[cot][hang + 11];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 11];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 12]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Sóc Trăng, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exApp.Visible = true;

        }

        private void btnTke_Click(object sender, EventArgs e)
        {
            frmTKHD tke = new frmTKHD();
            tke.StartPosition = FormStartPosition.CenterParent;
            tke.ShowDialog();
        }
    }
}
