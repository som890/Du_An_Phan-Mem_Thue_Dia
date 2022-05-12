using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmLogin : Form
    {
        TaiKhoan_BUS tkBus = new TaiKhoan_BUS();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (tkBus.DangNhap(txtUserName.Text, txtPassword.Text) == true)
            {
                MessageBox.Show("Chào mừng admin đăng nhập", "Thông báo");
                frmMain f = new frmMain();
                f.ShowDialog(); this.Hide();
               

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }

        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPass.Checked)
            {
                txtPassword.PasswordChar = (char)0;
            }else
            {
                txtPassword.PasswordChar = '*';
            } 

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có  thực sự muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có  thực sự muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }
    }
}
