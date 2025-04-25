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
    public partial class fGlobalLogincs : Form
    {
        public fGlobalLogincs()
        {
            InitializeComponent();
        }


        GlobalVariable gl = new GlobalVariable();
        DBTaiKhoan db = new DBTaiKhoan();
        public void btnLogin_Click(object sender, EventArgs e)
        {
            string err = "";

            string email = txbEmail.Text.Trim();

            var result = db.Login(txbEmail.Text, txbPassword.Text, ref err);
            if (result != null)
            {
                MessageBox.Show("Login successful!");

                int maTaiKhoan = db.GetMaTaiKhoanByEmail(email, ref err);

                if (!string.IsNullOrEmpty(err))
                {
                    MessageBox.Show("Error: " + err);
                }

                if (maTaiKhoan > 0)
                {
                    gl.MaTaiKhoan = maTaiKhoan;
                    

                    Hide();
                    fReaderTraSach fReader = new fReaderTraSach();
                    fReader.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No account found for this email.");
                }
            }
            else
            {
                MessageBox.Show("Login failed: " + err);
            }
        }

    }
}
