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
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnaddHD_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            hd.btnIn.Enabled = false;
            hd.ShowDialog();
        }

        private void btnTKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem tk = new frmTimKiem();
            tk.ShowDialog();
        }

        private void btnTKe_Click(object sender, EventArgs e)
        {
            frmTKHD tke = new frmTKHD();
            tke.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đóng ứng dụng không?","Thông báo!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }    
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            hd.btnIn.Enabled = false;
            hd.ShowDialog();
        }
    }
}
