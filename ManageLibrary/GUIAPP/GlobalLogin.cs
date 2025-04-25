using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer;

namespace GUIAPP
{
    public partial class GlobalLogin : Form
    {
        public GlobalLogin()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text;
            string password = txbPassword.Text;
            string error = "";
            // Call the login method from DBTaiKhoan
            DBTaiKhoan dbTaiKhoan = new DBTaiKhoan();
            bool isLoginSuccessful = dbTaiKhoan.Login(email, password, ref error);
            if (isLoginSuccessful)
            {
                MessageBox.Show("Đăng nhập thành công!");
                // Open the main form or perform any other action
                this.Hide();
                fReaderTraSach fReaderTraSach = new fReaderTraSach();
                fReaderTraSach.Show();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại: " + error);
            }
        }
    }
}
