
namespace GUI
{
    partial class frmPhieuThue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuThue));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvPhieuthue = new System.Windows.Forms.DataGridView();
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.chkNgayThue = new System.Windows.Forms.CheckBox();
            this.chkMaDia = new System.Windows.Forms.CheckBox();
            this.chkMaKhach = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.dNgayTra = new DevExpress.XtraEditors.DateEdit();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnXuatPhieuThue = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.txtMaQuanLy = new System.Windows.Forms.TextBox();
            this.txtMaDia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhieuThue = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dNgayThue = new DevExpress.XtraEditors.DateEdit();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuthue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayTra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayThue.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayThue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 574);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1456, 276);
            this.panel2.TabIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.groupControl2.Controls.Add(this.dgvPhieuthue);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1456, 276);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông tin về phiếu thuê:";
            // 
            // dgvPhieuthue
            // 
            this.dgvPhieuthue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuthue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuthue.Location = new System.Drawing.Point(2, 34);
            this.dgvPhieuthue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPhieuthue.Name = "dgvPhieuthue";
            this.dgvPhieuthue.RowHeadersWidth = 51;
            this.dgvPhieuthue.RowTemplate.Height = 24;
            this.dgvPhieuthue.Size = new System.Drawing.Size(1452, 240);
            this.dgvPhieuthue.TabIndex = 0;
            this.dgvPhieuthue.Click += new System.EventHandler(this.dgvPhieuthue_Click);
            this.dgvPhieuthue.DoubleClick += new System.EventHandler(this.dgvPhieuthue_DoubleClick);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.chkNgayThue);
            this.groupControl3.Controls.Add(this.chkMaDia);
            this.groupControl3.Controls.Add(this.chkMaKhach);
            this.groupControl3.Location = new System.Drawing.Point(1053, 156);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(351, 220);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Thông tin tìm kiếm";
            // 
            // chkNgayThue
            // 
            this.chkNgayThue.AutoSize = true;
            this.chkNgayThue.Location = new System.Drawing.Point(226, 48);
            this.chkNgayThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkNgayThue.Name = "chkNgayThue";
            this.chkNgayThue.Size = new System.Drawing.Size(107, 23);
            this.chkNgayThue.TabIndex = 5;
            this.chkNgayThue.Text = "Ngày thuê";
            this.chkNgayThue.UseVisualStyleBackColor = true;
            // 
            // chkMaDia
            // 
            this.chkMaDia.AutoSize = true;
            this.chkMaDia.Location = new System.Drawing.Point(93, 104);
            this.chkMaDia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkMaDia.Name = "chkMaDia";
            this.chkMaDia.Size = new System.Drawing.Size(81, 23);
            this.chkMaDia.TabIndex = 4;
            this.chkMaDia.Text = "Mã đĩa";
            this.chkMaDia.UseVisualStyleBackColor = true;
            // 
            // chkMaKhach
            // 
            this.chkMaKhach.AutoSize = true;
            this.chkMaKhach.Location = new System.Drawing.Point(82, 48);
            this.chkMaKhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkMaKhach.Name = "chkMaKhach";
            this.chkMaKhach.Size = new System.Drawing.Size(101, 23);
            this.chkMaKhach.TabIndex = 3;
            this.chkMaKhach.Text = "Mã khách";
            this.chkMaKhach.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1006, 79);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tìm kiếm: ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(81, 484);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 55);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFind.Location = new System.Drawing.Point(1131, 75);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(273, 51);
            this.txtFind.TabIndex = 8;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(436, 484);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(147, 55);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "SỬA";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = global::GUI.Properties.Resources.recycle_bin_icon;
            this.btnDelete.Location = new System.Drawing.Point(790, 484);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 55);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dNgayTra
            // 
            this.dNgayTra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dNgayTra.EditValue = null;
            this.dNgayTra.Location = new System.Drawing.Point(670, 260);
            this.dNgayTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dNgayTra.Name = "dNgayTra";
            this.dNgayTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgayTra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgayTra.Size = new System.Drawing.Size(273, 26);
            this.dNgayTra.TabIndex = 16;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSoLuong.Location = new System.Drawing.Point(670, 175);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.numSoLuong.Size = new System.Drawing.Size(273, 27);
            this.numSoLuong.TabIndex = 2;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.ValueChanged += new System.EventHandler(this.numSoLuong_ValueChanged);
            // 
            // btnXuatPhieuThue
            // 
            this.btnXuatPhieuThue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatPhieuThue.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatPhieuThue.Appearance.Options.UseFont = true;
            this.btnXuatPhieuThue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatPhieuThue.ImageOptions.Image")));
            this.btnXuatPhieuThue.Location = new System.Drawing.Point(1146, 484);
            this.btnXuatPhieuThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXuatPhieuThue.Name = "btnXuatPhieuThue";
            this.btnXuatPhieuThue.Size = new System.Drawing.Size(147, 55);
            this.btnXuatPhieuThue.TabIndex = 13;
            this.btnXuatPhieuThue.Text = "In đơn";
            this.btnXuatPhieuThue.Click += new System.EventHandler(this.btnXuatPhieuThue_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnXuatPhieuThue);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupControl3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 574);
            this.panel1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtThanhTien);
            this.groupControl1.Controls.Add(this.txtMaKhach);
            this.groupControl1.Controls.Add(this.txtMaQuanLy);
            this.groupControl1.Controls.Add(this.txtMaDia);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtPhieuThue);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.dNgayThue);
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.numSoLuong);
            this.groupControl1.Controls.Add(this.dNgayTra);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(24, 29);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(983, 380);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Thông tin đĩa";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "Thành tiền: ";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhTien.Location = new System.Drawing.Point(670, 329);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(273, 51);
            this.txtThanhTien.TabIndex = 38;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaKhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKhach.Location = new System.Drawing.Point(670, 58);
            this.txtMaKhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKhach.Multiline = true;
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(273, 51);
            this.txtMaKhach.TabIndex = 37;
            // 
            // txtMaQuanLy
            // 
            this.txtMaQuanLy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaQuanLy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaQuanLy.Location = new System.Drawing.Point(148, 128);
            this.txtMaQuanLy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaQuanLy.Multiline = true;
            this.txtMaQuanLy.Name = "txtMaQuanLy";
            this.txtMaQuanLy.Size = new System.Drawing.Size(273, 51);
            this.txtMaQuanLy.TabIndex = 35;
            // 
            // txtMaDia
            // 
            this.txtMaDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDia.Location = new System.Drawing.Point(148, 261);
            this.txtMaDia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDia.Multiline = true;
            this.txtMaDia.Name = "txtMaDia";
            this.txtMaDia.Size = new System.Drawing.Size(273, 51);
            this.txtMaDia.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "Số lượng: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Hạn trả: ";
            // 
            // txtPhieuThue
            // 
            this.txtPhieuThue.FormattingEnabled = true;
            this.txtPhieuThue.Items.AddRange(new object[] {
            "PT01",
            "PT02",
            "PT03",
            "PT04",
            "PT05",
            "PT06",
            "PT07",
            "PT08",
            "PT09",
            "PT10",
            "PT11",
            "PT12",
            "PT13",
            "PT14",
            "PT15",
            "PT16",
            "PT17",
            "PT18",
            "PT19",
            "PT20"});
            this.txtPhieuThue.Location = new System.Drawing.Point(148, 60);
            this.txtPhieuThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhieuThue.Name = "txtPhieuThue";
            this.txtPhieuThue.Size = new System.Drawing.Size(273, 27);
            this.txtPhieuThue.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "Mã đĩa: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Mã quản lý: ";
            // 
            // dNgayThue
            // 
            this.dNgayThue.EditValue = null;
            this.dNgayThue.Location = new System.Drawing.Point(148, 199);
            this.dNgayThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dNgayThue.Name = "dNgayThue";
            this.dNgayThue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dNgayThue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgayThue.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgayThue.Size = new System.Drawing.Size(273, 26);
            this.dNgayThue.TabIndex = 17;
            this.dNgayThue.EditValueChanged += new System.EventHandler(this.dNgayThue_EditValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(464, 492);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(202, 45);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "HỦY BỎ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(182, 492);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(208, 45);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "CẬP NHẬT";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã khách hàng: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày thuê: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu thuê: ";
            // 
            // frmPhieuThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 850);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPhieuThue";
            this.Text = "frmBorrowCD";
            this.Load += new System.EventHandler(this.frmThueDia_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuthue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayTra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayThue.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayThue.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgvPhieuthue;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.CheckBox chkNgayThue;
        private System.Windows.Forms.CheckBox chkMaDia;
        private System.Windows.Forms.CheckBox chkMaKhach;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.TextBox txtFind;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.DateEdit dNgayTra;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private DevExpress.XtraEditors.SimpleButton btnXuatPhieuThue;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtPhieuThue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.DateEdit dNgayThue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.TextBox txtMaQuanLy;
        private System.Windows.Forms.TextBox txtMaDia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThanhTien;
    }
}