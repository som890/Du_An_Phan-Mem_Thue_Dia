
namespace GUI
{
    partial class frmCDManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCDManage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtMaDia = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtDanhMuc = new System.Windows.Forms.TextBox();
            this.txtTenDia = new System.Windows.Forms.TextBox();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.chkDanhMuc = new System.Windows.Forms.CheckBox();
            this.chkTenDia = new System.Windows.Forms.CheckBox();
            this.chkTheLoai = new System.Windows.Forms.CheckBox();
            this.chkMaDia = new System.Windows.Forms.CheckBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvCDManage = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDManage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupControl3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 360);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(802, 292);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMaDia);
            this.groupControl1.Controls.Add(this.txtDonGia);
            this.groupControl1.Controls.Add(this.txtDanhMuc);
            this.groupControl1.Controls.Add(this.txtTenDia);
            this.groupControl1.Controls.Add(this.cbbTheLoai);
            this.groupControl1.Controls.Add(this.numSoLuong);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(9, 12);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(787, 266);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Thông tin đĩa";
            // 
            // txtMaDia
            // 
            this.txtMaDia.Location = new System.Drawing.Point(121, 36);
            this.txtMaDia.Name = "txtMaDia";
            this.txtMaDia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMaDia.Properties.Items.AddRange(new object[] {
            "CD01",
            "CD02",
            "CD03",
            "CD04",
            "CD05",
            "CD06",
            "CD07",
            "CD08]",
            "CD09",
            "CD10",
            "CD11",
            "CD12",
            "CD13",
            "CD14",
            "CD15",
            "CD16",
            "CD17",
            "CD18",
            "CD19",
            "CD20",
            "CD21",
            "CD22",
            "CD23",
            "CD24",
            "CD25",
            "CD26",
            "CD27",
            "CD28",
            "CD29"});
            this.txtMaDia.Size = new System.Drawing.Size(243, 22);
            this.txtMaDia.TabIndex = 10;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Location = new System.Drawing.Point(509, 102);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(243, 41);
            this.txtDonGia.TabIndex = 9;
            // 
            // txtDanhMuc
            // 
            this.txtDanhMuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDanhMuc.Location = new System.Drawing.Point(121, 198);
            this.txtDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDanhMuc.Multiline = true;
            this.txtDanhMuc.Name = "txtDanhMuc";
            this.txtDanhMuc.Size = new System.Drawing.Size(243, 41);
            this.txtDanhMuc.TabIndex = 8;
            // 
            // txtTenDia
            // 
            this.txtTenDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDia.Location = new System.Drawing.Point(121, 85);
            this.txtTenDia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenDia.Multiline = true;
            this.txtTenDia.Name = "txtTenDia";
            this.txtTenDia.Size = new System.Drawing.Size(243, 41);
            this.txtTenDia.TabIndex = 7;
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Items.AddRange(new object[] {
            "Nhạc trẻ",
            "Phim hành động",
            "Phim cổ trang",
            "Phim tình cảm",
            "Phim Hàn Quốc",
            "Phim Việt Nam",
            "Phim Nhật Bản"});
            this.cbbTheLoai.Location = new System.Drawing.Point(121, 144);
            this.cbbTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(243, 24);
            this.cbbTheLoai.TabIndex = 3;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(509, 39);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(243, 23);
            this.numSoLuong.TabIndex = 2;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn giá: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số  lượng: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Danh mục: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thể loại: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đĩa: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã đĩa: ";
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(486, 292);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 44);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "SỬA";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFind.Location = new System.Drawing.Point(923, 12);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(243, 41);
            this.txtFind.TabIndex = 8;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(177, 292);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 44);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(802, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tìm kiếm: ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.chkDanhMuc);
            this.groupControl3.Controls.Add(this.chkTenDia);
            this.groupControl3.Controls.Add(this.chkTheLoai);
            this.groupControl3.Controls.Add(this.chkMaDia);
            this.groupControl3.Location = new System.Drawing.Point(830, 70);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(336, 170);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Tìm kiếm theo";
            // 
            // chkDanhMuc
            // 
            this.chkDanhMuc.AutoSize = true;
            this.chkDanhMuc.Location = new System.Drawing.Point(189, 110);
            this.chkDanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDanhMuc.Name = "chkDanhMuc";
            this.chkDanhMuc.Size = new System.Drawing.Size(94, 21);
            this.chkDanhMuc.TabIndex = 3;
            this.chkDanhMuc.Text = "Danh mục";
            this.chkDanhMuc.UseVisualStyleBackColor = true;
            // 
            // chkTenDia
            // 
            this.chkTenDia.AutoSize = true;
            this.chkTenDia.Location = new System.Drawing.Point(37, 118);
            this.chkTenDia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTenDia.Name = "chkTenDia";
            this.chkTenDia.Size = new System.Drawing.Size(109, 21);
            this.chkTenDia.TabIndex = 2;
            this.chkTenDia.Text = "Tên băng đĩa";
            this.chkTenDia.UseVisualStyleBackColor = true;
            // 
            // chkTheLoai
            // 
            this.chkTheLoai.AutoSize = true;
            this.chkTheLoai.Location = new System.Drawing.Point(189, 57);
            this.chkTheLoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTheLoai.Name = "chkTheLoai";
            this.chkTheLoai.Size = new System.Drawing.Size(76, 21);
            this.chkTheLoai.TabIndex = 1;
            this.chkTheLoai.Text = "Thể loại";
            this.chkTheLoai.UseVisualStyleBackColor = true;
            // 
            // chkMaDia
            // 
            this.chkMaDia.AutoSize = true;
            this.chkMaDia.Location = new System.Drawing.Point(37, 57);
            this.chkMaDia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMaDia.Name = "chkMaDia";
            this.chkMaDia.Size = new System.Drawing.Size(103, 21);
            this.chkMaDia.TabIndex = 0;
            this.chkMaDia.Text = "Mã băng đĩa";
            this.chkMaDia.UseVisualStyleBackColor = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvCDManage);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 360);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1182, 326);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông tin chi tiết băng đĩa";
            // 
            // dgvCDManage
            // 
            this.dgvCDManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCDManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCDManage.Location = new System.Drawing.Point(2, 28);
            this.dgvCDManage.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.dgvCDManage.Name = "dgvCDManage";
            this.dgvCDManage.RowHeadersWidth = 51;
            this.dgvCDManage.RowTemplate.Height = 24;
            this.dgvCDManage.Size = new System.Drawing.Size(1178, 296);
            this.dgvCDManage.TabIndex = 0;
            this.dgvCDManage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCDManage_CellClick);
            // 
            // frmCDManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 686);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCDManage";
            this.Text = "frmCDManage";
            this.Load += new System.EventHandler(this.frmCDManage_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCDManage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDanhMuc;
        private System.Windows.Forms.TextBox txtTenDia;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.TextBox txtFind;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.CheckBox chkDanhMuc;
        private System.Windows.Forms.CheckBox chkTenDia;
        private System.Windows.Forms.CheckBox chkTheLoai;
        private System.Windows.Forms.CheckBox chkMaDia;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgvCDManage;
        private DevExpress.XtraEditors.ComboBoxEdit txtMaDia;
    }
}