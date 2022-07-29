using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FormLogin.Core;

namespace FormLogin
{
    public partial class frmTimKiem : Form
    {
        DBManager db = null;
        SqlConnection conn = null;
        SqlCommand cmd;
        SqlDataReader reader;
        DataTable dt = new DataTable();
        string sql;
        DataTable da;
        frmHoaDon hd = new frmHoaDon();
        public frmTimKiem()
        {
            InitializeComponent();
            db = new DBManager();
            conn = db.ketnoi();
            this.dgvTimHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void MaHD(TextBox Mahd)
        {
            this.txtMahd.Text = Mahd.Text;
        }
        private void loaddgvTK()
        {
            dgvTimHD.Columns[0].HeaderText = "Mã HĐB";
            dgvTimHD.Columns[1].HeaderText = "Ngày tạo";
            dgvTimHD.Columns[2].HeaderText = "Tổng tiền";
            dgvTimHD.Columns[0].Width = 150;
            dgvTimHD.Columns[1].Width = 150;

        }
        private void loaddgvHD()
        {
            hd.dgvHD.Columns[0].HeaderText = "Mã đĩa";
            hd.dgvHD.Columns[1].HeaderText = "Tên đĩa";
            hd.dgvHD.Columns[2].HeaderText = "Giá bán";
            hd.dgvHD.Columns[3].HeaderText = "Số lượng";
            hd.dgvHD.Columns[4].HeaderText = "Thành tiền";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if ((txtMahd.Text.Equals(""))
                && (txtTongtien.Text.Equals(""))
                && (cbxngay.Text.Equals(""))
                && (cbxthang.Text.Equals(""))
                && (txtNam.Text.Equals("")))
            {
             MessageBox.Show("Vui lòng nhập một điều kiện để tìm kiếm!", "Yêu cầu...", 
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            sql = "select * from HoaDon where 1=1";
            if(txtMahd.Text !="")
            {
                sql = sql + "and MaHD Like N'%" + txtMahd.Text + "%'";
            }
            if (cbxngay.Text !="") 
            {
                sql += "and DAY(NgayTao)='" + cbxngay.Text+"'";
            }
            if (cbxthang.Text != "")
            {
                sql += "and MONTH(NgayTao)='" + cbxthang.Text + "'";
            }
            if (txtNam.Text != "")
            {
                sql += "and YEAR(NgayTao)=" + txtNam.Text;
            }
            if (txtTongtien.Text != "")
            {
                sql += "and TongTien <=" + txtTongtien.Text;
            }
            Console.WriteLine("sql :"+sql);
            da = db.GetDataToTable(sql);
            if (da.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Có " + da.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTimHD.DataSource = da;
                loaddgvTK();
            }
        }

        private void txtTongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgvTimHD_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            string tt;
            if(MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                
                mahd = dgvTimHD.CurrentRow.Cells["MaHD"].Value.ToString();
                tt = dgvTimHD.CurrentRow.Cells["TongTien"].Value.ToString();
                sql = "select dg.MaDia,dg.TenDia,dg.GiaBan, SoLuong, ThanhTien from CTHoaDon ct join DiaGame dg on ct.MaDia = dg.MaDia  where MaHD ='" +mahd+ "'";
                hd.dtngayban.Value = (DateTime)dgvTimHD.CurrentRow.Cells["NgayTao"].Value;
                hd.txtMahd.Text = mahd;
                hd.txttongtien.Text = tt;
                da = db.GetDataToTable(sql);
                hd.dgvHD.DataSource = da;
                loaddgvHD();
                hd.StartPosition = FormStartPosition.CenterParent;
                hd.ShowDialog();  
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng trang này không?", "Thông báo!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbxngay_KeyPress(object sender, KeyPressEventArgs e)
        {
            // giới hạn ko cho nhập chữ và lớn hơn 9
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void cbxthang_KeyPress(object sender, KeyPressEventArgs e)
        {
            // giới hạn ko cho nhập chữ và lớn hơn 9
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            // giới hạn ko cho nhập chữ và lớn hơn 9
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox || Ctl is ComboBox)
                    Ctl.Text = "";
            txtMahd.Focus();
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvTimHD.DataSource = null;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            this.Hide();
            hd.ShowDialog();
        }
    }
}
