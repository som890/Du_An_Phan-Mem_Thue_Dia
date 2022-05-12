
namespace GUI
{
    partial class frmPhieuTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuTra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.chkNgayTra = new System.Windows.Forms.CheckBox();
            this.chkMaDia = new System.Windows.Forms.CheckBox();
            this.chkMaKhach = new System.Windows.Forms.CheckBox();
            this.btnXuatPhieuGia = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPhathuHong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numSoDiaHong = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhatQuaHan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numQuaHan = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dHanTra = new DevExpress.XtraEditors.DateEdit();
            this.dNgayTra = new DevExpress.XtraEditors.DateEdit();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaDia = new System.Windows.Forms.TextBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.txtMaPhieuGia = new System.Windows.Forms.TextBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvPhieuTra = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoDiaHong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuaHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dHanTra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dHanTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayTra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTra)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupControl3);
            this.panel1.Controls.Add(this.btnXuatPhieuGia);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.txtFind);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1458, 526);
            this.panel1.TabIndex = 3;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.chkNgayTra);
            this.groupControl3.Controls.Add(this.chkMaDia);
            this.groupControl3.Controls.Add(this.chkMaKhach);
            this.groupControl3.Location = new System.Drawing.Point(1096, 165);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(333, 234);
            this.groupControl3.TabIndex = 14;
            this.groupControl3.Text = "Thông tin tìm kiếm";
            // 
            // chkNgayTra
            // 
            this.chkNgayTra.AutoSize = true;
            this.chkNgayTra.Location = new System.Drawing.Point(86, 181);
            this.chkNgayTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkNgayTra.Name = "chkNgayTra";
            this.chkNgayTra.Size = new System.Drawing.Size(95, 23);
            this.chkNgayTra.TabIndex = 2;
            this.chkNgayTra.Text = "Ngày trả";
            this.chkNgayTra.UseVisualStyleBackColor = true;
            // 
            // chkMaDia
            // 
            this.chkMaDia.AutoSize = true;
            this.chkMaDia.Location = new System.Drawing.Point(86, 115);
            this.chkMaDia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkMaDia.Name = "chkMaDia";
            this.chkMaDia.Size = new System.Drawing.Size(83, 23);
            this.chkMaDia.TabIndex = 1;
            this.chkMaDia.Text = "Mã Đĩa";
            this.chkMaDia.UseVisualStyleBackColor = true;
            // 
            // chkMaKhach
            // 
            this.chkMaKhach.AutoSize = true;
            this.chkMaKhach.Location = new System.Drawing.Point(86, 61);
            this.chkMaKhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkMaKhach.Name = "chkMaKhach";
            this.chkMaKhach.Size = new System.Drawing.Size(102, 23);
            this.chkMaKhach.TabIndex = 0;
            this.chkMaKhach.Text = "Mã Khách";
            this.chkMaKhach.UseVisualStyleBackColor = true;
            // 
            // btnXuatPhieuGia
            // 
            this.btnXuatPhieuGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatPhieuGia.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatPhieuGia.Appearance.Options.UseFont = true;
            this.btnXuatPhieuGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatPhieuGia.ImageOptions.Image")));
            this.btnXuatPhieuGia.Location = new System.Drawing.Point(1109, 462);
            this.btnXuatPhieuGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXuatPhieuGia.Name = "btnXuatPhieuGia";
            this.btnXuatPhieuGia.Size = new System.Drawing.Size(136, 55);
            this.btnXuatPhieuGia.TabIndex = 13;
            this.btnXuatPhieuGia.Text = "In báo cáo";
            this.btnXuatPhieuGia.Click += new System.EventHandler(this.btnXuatPhieuGia_Click_1);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupControl1.Controls.Add(this.txtThanhTien);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.txtPhathuHong);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.numSoDiaHong);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.txtPhatQuaHan);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.numQuaHan);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.dHanTra);
            this.groupControl1.Controls.Add(this.dNgayTra);
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.txtMaDia);
            this.groupControl1.Controls.Add(this.txtMaKhach);
            this.groupControl1.Controls.Add(this.txtMaPhieuGia);
            this.groupControl1.Controls.Add(this.numSoLuong);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(-2, 14);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1077, 431);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Thông tin đĩa";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhTien.Location = new System.Drawing.Point(701, 374);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(273, 51);
            this.txtThanhTien.TabIndex = 26;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(558, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "Thành tiền: ";
            // 
            // txtPhathuHong
            // 
            this.txtPhathuHong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhathuHong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhathuHong.Location = new System.Drawing.Point(701, 309);
            this.txtPhathuHong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhathuHong.Multiline = true;
            this.txtPhathuHong.Name = "txtPhathuHong";
            this.txtPhathuHong.Size = new System.Drawing.Size(273, 51);
            this.txtPhathuHong.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(558, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Phạt hư hỏng: ";
            // 
            // numSoDiaHong
            // 
            this.numSoDiaHong.Location = new System.Drawing.Point(701, 264);
            this.numSoDiaHong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSoDiaHong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSoDiaHong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoDiaHong.Name = "numSoDiaHong";
            this.numSoDiaHong.Size = new System.Drawing.Size(197, 27);
            this.numSoDiaHong.TabIndex = 22;
            this.numSoDiaHong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoDiaHong.ValueChanged += new System.EventHandler(this.numSoDiaHong_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(558, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Số đĩa hỏng: ";
            // 
            // txtPhatQuaHan
            // 
            this.txtPhatQuaHan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhatQuaHan.Location = new System.Drawing.Point(701, 182);
            this.txtPhatQuaHan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhatQuaHan.Multiline = true;
            this.txtPhatQuaHan.Name = "txtPhatQuaHan";
            this.txtPhatQuaHan.Size = new System.Drawing.Size(273, 51);
            this.txtPhatQuaHan.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(558, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Phạt quá hạn: ";
            // 
            // numQuaHan
            // 
            this.numQuaHan.Location = new System.Drawing.Point(701, 106);
            this.numQuaHan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numQuaHan.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuaHan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuaHan.Name = "numQuaHan";
            this.numQuaHan.Size = new System.Drawing.Size(197, 27);
            this.numQuaHan.TabIndex = 18;
            this.numQuaHan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuaHan.ValueChanged += new System.EventHandler(this.numQuaHan_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quá hạn: ";
            // 
            // dHanTra
            // 
            this.dHanTra.EditValue = null;
            this.dHanTra.Location = new System.Drawing.Point(701, 54);
            this.dHanTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dHanTra.Name = "dHanTra";
            this.dHanTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dHanTra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dHanTra.Size = new System.Drawing.Size(262, 26);
            this.dHanTra.TabIndex = 16;
            // 
            // dNgayTra
            // 
            this.dNgayTra.EditValue = null;
            this.dNgayTra.Location = new System.Drawing.Point(111, 360);
            this.dNgayTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dNgayTra.Name = "dNgayTra";
            this.dNgayTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgayTra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dNgayTra.Size = new System.Drawing.Size(197, 26);
            this.dNgayTra.TabIndex = 15;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hạn trả: ";
            // 
            // txtMaDia
            // 
            this.txtMaDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDia.Location = new System.Drawing.Point(111, 279);
            this.txtMaDia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaDia.Multiline = true;
            this.txtMaDia.Name = "txtMaDia";
            this.txtMaDia.Size = new System.Drawing.Size(273, 51);
            this.txtMaDia.TabIndex = 8;
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKhach.Location = new System.Drawing.Point(111, 198);
            this.txtMaKhach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaKhach.Multiline = true;
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(273, 51);
            this.txtMaKhach.TabIndex = 7;
            // 
            // txtMaPhieuGia
            // 
            this.txtMaPhieuGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhieuGia.Location = new System.Drawing.Point(122, 59);
            this.txtMaPhieuGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhieuGia.Multiline = true;
            this.txtMaPhieuGia.Name = "txtMaPhieuGia";
            this.txtMaPhieuGia.Size = new System.Drawing.Size(273, 51);
            this.txtMaPhieuGia.TabIndex = 6;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(122, 139);
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
            this.numSoLuong.Size = new System.Drawing.Size(197, 27);
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
            this.label6.Location = new System.Drawing.Point(26, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số lượng: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã đĩa: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày trả: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu giả : ";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(750, 462);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 55);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "XÓA";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(395, 462);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(136, 55);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "SỬA";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFind.Location = new System.Drawing.Point(1174, 102);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(273, 51);
            this.txtFind.TabIndex = 8;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(90, 452);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 55);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1081, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tìm kiếm: ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupControl2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 526);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1458, 344);
            this.panel2.TabIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvPhieuTra);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1458, 344);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông tin phiếu giả:";
            // 
            // dgvPhieuTra
            // 
            this.dgvPhieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuTra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuTra.Location = new System.Drawing.Point(2, 34);
            this.dgvPhieuTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPhieuTra.Name = "dgvPhieuTra";
            this.dgvPhieuTra.RowHeadersWidth = 51;
            this.dgvPhieuTra.RowTemplate.Height = 24;
            this.dgvPhieuTra.Size = new System.Drawing.Size(1454, 308);
            this.dgvPhieuTra.TabIndex = 0;
            this.dgvPhieuTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuTra_CellClick);
            // 
            // frmPhieuTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 870);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPhieuTra";
            this.Text = "frmPhieuTra";
            this.Load += new System.EventHandler(this.frmPhieuTra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoDiaHong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuaHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dHanTra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dHanTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayTra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dNgayTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnXuatPhieuGia;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dHanTra;
        private DevExpress.XtraEditors.DateEdit dNgayTra;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaDia;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.TextBox txtMaPhieuGia;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private System.Windows.Forms.TextBox txtFind;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhatQuaHan;
        private System.Windows.Forms.NumericUpDown numQuaHan;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPhathuHong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numSoDiaHong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dgvPhieuTra;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.CheckBox chkNgayTra;
        private System.Windows.Forms.CheckBox chkMaDia;
        private System.Windows.Forms.CheckBox chkMaKhach;
    }
}