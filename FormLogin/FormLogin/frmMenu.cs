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
    public partial class frmMenu : Form
    {
        DBManager db = null;
        SqlConnection conn = null;
        public frmMenu()
        {
            InitializeComponent();
            db = new DBManager();
            conn = db.ketnoi();
        }

        private void btnaddHD_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            hd.txtMahd.Text = db.CreateKey("CH");
            hd.txttongtien.Text = "0";
            hd.dtngayban.Text = DateTime.Now.ToShortDateString();
            hd.btnadd_HD.Enabled = false;
            hd.btnHuy.Enabled = false;
            hd.dgvHD.Enabled = true;
            hd.btnIn.Enabled = false;
            hd.ShowDialog();
        }

        private void btnTKe_Click(object sender, EventArgs e)
        {
            frmTKHD tke = new frmTKHD();
            tke.ShowDialog();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            frmTimKiem tk = new frmTimKiem();
            tk.ShowDialog();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo!",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
