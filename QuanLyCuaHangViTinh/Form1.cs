using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace QuanLyCuaHangViTinh
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if(username == "admin" && password == "admin")
            {
                frmMain fm = new frmMain();
                this.Hide();
                fm.ShowDialog();
                this.Close();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
