using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        private Button currentButton;
     //   private int tempIndex;
        private Form activeForm;

        public frmMain()
        {
            InitializeComponent();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.DarkBlue;
                    currentButton.ForeColor = Color.White;

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenuLeft.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
           
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(btnSender);

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(childForm);
            this.pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = currentButton.Text;

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTitle(), sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCustomer(), sender);
        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCDManage(), sender);
        }

        private void btnCDBorrow_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhieuThue(), sender);
        }

        private void btnPayCD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhieuTra(), sender);
        }



    
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       
    }
}
