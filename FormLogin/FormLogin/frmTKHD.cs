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
    public partial class frmTKHD : Form
    {
        string sql;
        SqlCommand cmd;
        DBManager db = null;
        SqlConnection conn= null;
        SqlDataReader re;
        DataTable da;
        public frmTKHD()
        {
            InitializeComponent();
            db = new DBManager();
            conn = db.ketnoi();
            this.dgvTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void loadInfoTKe()
        {
            dgvTK.Columns[0].HeaderText = "Mã đĩa";
            dgvTK.Columns[1].HeaderText = "Tên đĩa";
            dgvTK.Columns[2].HeaderText = "Giá bán";
            dgvTK.Columns[3].HeaderText = "Đã bán(Cái)";
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            // Top5 sp ban chay
            sql = "select Top 5 dg.MaDia,dg.TenDia,dg.GiaBan , SUM(ct.SoLuong) as N'SL bán'" +
                    " from CTHoaDon ct join DiaGame dg on ct.MaDia = dg.MaDia" +
                    " join HoaDon hd on ct.MaHD = hd.MaHD" +
                    " group by dg.MaDia,dg.TenDia, dg.GiaBan, hd.NgayTao" +
                    " having hd.NgayTao between '"+dtTu.Value.Date+"' and '"+dtToi.Value.Date+"'" +
                    " order by sum(ct.SoLuong) desc";
            da = db.GetDataToTable(sql);
            dgvTK.DataSource = da;
            loadInfoTKe();

            sql = "select COUNT(HoaDon.MaHD) as 'HD đã bán', SUM(CTHoaDon.ThanhTien) as 'Tổng doanh thu'" +
                    " from HoaDon join CTHoaDon on HoaDon.MaHD = CTHoaDon.MaHD" +
                    " where NgayTao between'" + dtTu.Value.Date + "' and '" + dtToi.Value.Date + "'";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dt = cmd.ExecuteReader();

                while (dt.Read())
            {
                txtTDT.Text = dt.GetValue(1).ToString();
                txthd.Text = dt.GetValue(0).ToString();
               
            }
            if (txtTDT.Text != "")
            {
                System.Globalization.CultureInfo ct = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(txtTDT.Text, System.Globalization.NumberStyles.AllowThousands);
                txtTDT.Text = String.Format(ct, "{0:N0}", value);
                txtTDT.Select(txtTDT.Text.Length, 0);
            }
                else
            {
                txtTDT.Text = "0";
            }
            dt.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            hd.ShowDialog();
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng trang này?", "Thông báo!",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
