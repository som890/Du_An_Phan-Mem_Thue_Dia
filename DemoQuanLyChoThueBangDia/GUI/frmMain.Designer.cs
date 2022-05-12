
namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMenuLeft = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnPayCD = new System.Windows.Forms.Button();
            this.btnCDBorrow = new System.Windows.Forms.Button();
            this.btnCD = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlMenuLeft.SuspendLayout();
            this.pnlImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlMain.Location = new System.Drawing.Point(322, 88);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1624, 1018);
            this.pnlMain.TabIndex = 7;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnMaximize);
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(322, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1624, 88);
            this.pnlTop.TabIndex = 6;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMaximize.Location = new System.Drawing.Point(1395, 6);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(68, 51);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.Text = "!";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.Location = new System.Drawing.Point(1471, 5);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(72, 52);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(1548, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 52);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(744, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // pnlMenuLeft
            // 
            this.pnlMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenuLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuLeft.Controls.Add(this.btnLogout);
            this.pnlMenuLeft.Controls.Add(this.btnSetting);
            this.pnlMenuLeft.Controls.Add(this.btnPayCD);
            this.pnlMenuLeft.Controls.Add(this.btnCDBorrow);
            this.pnlMenuLeft.Controls.Add(this.btnCD);
            this.pnlMenuLeft.Controls.Add(this.btnCustomer);
            this.pnlMenuLeft.Controls.Add(this.btnMain);
            this.pnlMenuLeft.Controls.Add(this.pnlImage);
            this.pnlMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenuLeft.Name = "pnlMenuLeft";
            this.pnlMenuLeft.Size = new System.Drawing.Size(322, 1106);
            this.pnlMenuLeft.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Image = global::GUI.Properties.Resources.unlock_icon;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 470);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(320, 79);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "     Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSetting.Image = global::GUI.Properties.Resources.icon_setting;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 411);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(320, 59);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Text = "     Cài đặt";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnPayCD
            // 
            this.btnPayCD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayCD.FlatAppearance.BorderSize = 0;
            this.btnPayCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayCD.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPayCD.Image = global::GUI.Properties.Resources.icon_Tra;
            this.btnPayCD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayCD.Location = new System.Drawing.Point(0, 347);
            this.btnPayCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayCD.Name = "btnPayCD";
            this.btnPayCD.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnPayCD.Size = new System.Drawing.Size(320, 64);
            this.btnPayCD.TabIndex = 5;
            this.btnPayCD.Text = "     Quản lý trả đĩa";
            this.btnPayCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayCD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayCD.UseVisualStyleBackColor = true;
            this.btnPayCD.Click += new System.EventHandler(this.btnPayCD_Click);
            // 
            // btnCDBorrow
            // 
            this.btnCDBorrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCDBorrow.FlatAppearance.BorderSize = 0;
            this.btnCDBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCDBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDBorrow.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCDBorrow.Image = global::GUI.Properties.Resources.icon_thue;
            this.btnCDBorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCDBorrow.Location = new System.Drawing.Point(0, 288);
            this.btnCDBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCDBorrow.Name = "btnCDBorrow";
            this.btnCDBorrow.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCDBorrow.Size = new System.Drawing.Size(320, 59);
            this.btnCDBorrow.TabIndex = 4;
            this.btnCDBorrow.Text = "     Quản lý thuê đĩa";
            this.btnCDBorrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCDBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCDBorrow.UseVisualStyleBackColor = true;
            this.btnCDBorrow.Click += new System.EventHandler(this.btnCDBorrow_Click);
            // 
            // btnCD
            // 
            this.btnCD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCD.FlatAppearance.BorderSize = 0;
            this.btnCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCD.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCD.Image = global::GUI.Properties.Resources.Device_DVD_plus_R_icon;
            this.btnCD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCD.Location = new System.Drawing.Point(0, 229);
            this.btnCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCD.Name = "btnCD";
            this.btnCD.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCD.Size = new System.Drawing.Size(320, 59);
            this.btnCD.TabIndex = 3;
            this.btnCD.Text = "     Quản lý băng đĩa";
            this.btnCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCD.UseVisualStyleBackColor = true;
            this.btnCD.Click += new System.EventHandler(this.btnCD_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCustomer.Image = global::GUI.Properties.Resources.icon_user;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 170);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(320, 59);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "     Quản lý khách hàng";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnMain
            // 
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMain.Image = global::GUI.Properties.Resources.Home_icon;
            this.btnMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.Location = new System.Drawing.Point(0, 111);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMain.Size = new System.Drawing.Size(320, 59);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "     Main";
            this.btnMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // pnlImage
            // 
            this.pnlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImage.Controls.Add(this.button1);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(320, 111);
            this.pnlImage.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::GUI.Properties.Resources.icon_menu;
            this.button1.Location = new System.Drawing.Point(4, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 52);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlMenuLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMenuLeft.ResumeLayout(false);
            this.pnlImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMenuLeft;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnPayCD;
        private System.Windows.Forms.Button btnCDBorrow;
        private System.Windows.Forms.Button btnCD;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogout;
    }
}