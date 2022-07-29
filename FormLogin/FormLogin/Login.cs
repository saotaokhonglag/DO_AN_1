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
    public partial class Login : Form
    {
        DBManager db = null;
        string sql;
        SqlConnection conn = null;
        public Login()
        {
            InitializeComponent();
            db = new DBManager();
            conn = db.ketnoi();
            if (db.ketnoi() == null)
            {
                MessageBox.Show(this, "Kiem tra lai ket noi CSDL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtmk.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                txtmk.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;

            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Bạn có muốn thoát?","Thông báo!", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }    
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM TaiKhoan WHERE TaiKhoan ='"
               + txttk.Text + "' AND MatKhau = '" + txtmk.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    frmMenu menu = new frmMenu();
                    this.Hide();
                    menu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(this, "Sai tài khoản hoặc mật khẩu! Xin vui lòng kiểm tra lại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();
        }
    }
}
