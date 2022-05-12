using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;
using DTO;
using BUS;
namespace GUI
{
    public partial class frmPhieuThue : Form
    {
        PhieuThue_BUS ptBus = new PhieuThue_BUS();
        public frmPhieuThue()
        {
            InitializeComponent();
        }

      
     

        private void dgvPhieuthue_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dgvPhieuthue.SelectedRows[0];


            int index = dgvPhieuthue.CurrentRow.Index;
              
            txtPhieuThue.Text = row.Cells[0].Value.ToString();
            txtMaKhach.Text = row.Cells[1].Value.ToString();
            dNgayTra.Text = row.Cells[10].Value.ToString();
            dNgayThue.Text = row.Cells[3].Value.ToString();
            txtMaDia.Text = row.Cells[6].Value.ToString();
            txtMaQuanLy.Text = row.Cells[4].Value.ToString();
            numSoLuong.Text = row.Cells[9].Value.ToString();
            txtThanhTien.Text = row.Cells[11].Value.ToString();

         //   txtPhieuThue.Text = dgvPhieuthue.Rows[index].Cells[0].Value.ToString();
          //  numSoLuong.Text = dgvPhieuthue.Rows[index].Cells[1].Value.ToString();


        }
        private void SetTittleForTable()
        {
            dgvPhieuthue.Columns[0].HeaderText = "Mã phiếu thuê";
            dgvPhieuthue.Columns[1].HeaderText = "Mã khách";
            dgvPhieuthue.Columns[2].HeaderText = "Tên khách";
            dgvPhieuthue.Columns[3].HeaderText = "Ngày thuê";
            dgvPhieuthue.Columns[4].HeaderText = "Mã quản lý ";
            dgvPhieuthue.Columns[5].HeaderText = "Người lập ";
            dgvPhieuthue.Columns[6].HeaderText = "Mã  đĩa";
            dgvPhieuthue.Columns[7].HeaderText = "Tên  đĩa";
            dgvPhieuthue.Columns[8].HeaderText = "Đơn giá";
            dgvPhieuthue.Columns[9].HeaderText = "Số lượng";
            dgvPhieuthue.Columns[10].HeaderText = "Hạn trả";
            dgvPhieuthue.Columns[11].HeaderText = "Thanh tiền";

            dgvPhieuthue.Columns[0].Width = 150;
            dgvPhieuthue.Columns[1].Width = 180;
            dgvPhieuthue.Columns[2].Width = 100;
            dgvPhieuthue.Columns[3].Width = 100;
            dgvPhieuthue.Columns[4].Width = 200;
            dgvPhieuthue.Columns[5].Width = 100;
            dgvPhieuthue.Columns[6].Width = 100;
            dgvPhieuthue.Columns[7].Width = 100;
            dgvPhieuthue.Columns[8].Width = 100;
            dgvPhieuthue.Columns[9].Width = 100;
            dgvPhieuthue.Columns[10].Width = 100;
            dgvPhieuthue.Columns[10].Width = 100;
            dgvPhieuthue.AllowUserToAddRows = false;
            dgvPhieuthue.EditMode = DataGridViewEditMode.EditProgrammatically;
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            // txtPhieuThue.ReadOnly = ;
            txtPhieuThue.Text = "";
            txtMaQuanLy.Text = "";
            dNgayTra.Text = "";
            txtMaKhach.Text = "";
            txtMaQuanLy.Text = "";
            dNgayThue.Text = "";
            dNgayTra.Text = "";
            txtMaDia.Text = "";
        }

        public void Reset()
        {
           
            txtPhieuThue.Text = "";
            txtMaQuanLy.Text = "";
            dNgayTra.Text = "";
            txtMaKhach.Text = "";
            txtMaQuanLy.Text = "";
            dNgayThue.Text = "";
            dNgayTra.Text = "";
            txtMaDia.Text = "";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPhieuThue.Text != "")
            {
                DialogResult dlr = MessageBox.Show("Ban có thực sự muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    ptBus.Xoa(txtPhieuThue.Text);
                    btnClear_Click(sender, e);
                    frmThueDia_Load(sender, e);
                }
            }
        }

        private void btnXuatPhieuThue_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
           
            int hang = 0, cot = 0;

            DataTable  tblThongtinDia;

            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];

            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop cho thuê băng đĩa";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Tân Thịnh - Thái Nguyên";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (03)339794819";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN THUÊ BĂNG ĐĨA";

            tblThongtinDia = ptBus.GetList();

            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinDia.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinDia.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinDia.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinDia.Rows[hang][cot].ToString() + "%";
                }
            }


           
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;

        }

        private void frmThueDia_Load(object sender, EventArgs e)
        {
            dgvPhieuthue.DataSource = ptBus.GetList();
              SetTittleForTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string str;
           // if(Convert.ToDouble(ptBus.CheckExist("tblBangDia", numSoLuong)))
            if (ptBus.CheckExist("tblKhachHangg", txtMaKhach.Text) == true && ptBus.CheckExist("tblBangDia", txtMaDia.Text) == true && ptBus.CheckExist("tblAdmin", txtMaQuanLy.Text) == true)
            {

                PhieuThue pt = new PhieuThue();

                pt.MaPhieuThue = txtPhieuThue.Text;
                pt.MaKhach = txtMaKhach.Text;
                pt.MaDia = txtMaDia.Text;
                pt.MaQuanLy = txtMaQuanLy.Text;
                pt.SoLuong = float.Parse(numSoLuong.Text);
                pt.ThanhTien = float.Parse(txtThanhTien.Text);

                if (dNgayThue.Text == "")
                    pt.NgayThue = DateTime.Now;
                else
                    pt.NgayThue = dNgayThue.DateTime;

                if (dNgayTra.Text == "")
                    pt.HanTra = DateTime.Now;
                else
                    pt.HanTra = dNgayTra.DateTime;

                int check = ptBus.Them(pt);
                if (check == -1)
                    MessageBox.Show("Lỗi trùng mã");
                else
                    frmThueDia_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Không tồn tại mã đĩa hoặc mã khách, mã quản lý");
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
               dgvPhieuthue.DataSource = ptBus.GetList();

            }
            else
            {
                if (chkMaKhach.Checked == true)
                    dgvPhieuthue.DataSource = ptBus.TimKiem(txtFind.Text, "MaKhach");
                else if (chkMaDia.Checked == true)
                    dgvPhieuthue.DataSource = ptBus.TimKiem(txtFind.Text, "MaDia");
                else if (chkNgayThue.Checked == true)
                    dgvPhieuthue.DataSource = ptBus.TimKiem(txtFind.Text, "NgayThue");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtPhieuThue.Text != "")
            {

                if (ptBus.CheckExist("tblKhachHangg", txtMaKhach.Text) == true && ptBus.CheckExist("tblBangDia", txtMaDia.Text) == true && ptBus.CheckExist("tblAdmin", txtMaQuanLy.Text) == true)
                {
                    PhieuThue pt = new PhieuThue();

                    pt.MaPhieuThue = txtPhieuThue.Text;
                    pt.MaKhach = txtMaKhach.Text;
                    pt.MaDia = txtMaDia.Text;
                    pt.MaQuanLy = txtMaQuanLy.Text;
                    pt.SoLuong = float.Parse(numSoLuong.Text);
                    pt.ThanhTien = float.Parse(txtThanhTien.Text);

                    if (dNgayThue.Text == "")
                        pt.NgayThue = DateTime.Now;
                    else
                        pt.NgayThue = dNgayThue.DateTime;

                    if (dNgayTra.Text == "")
                        pt.HanTra = DateTime.Now;
                    else
                        pt.HanTra = dNgayTra.DateTime;

                    ptBus.Sua(pt);
                    frmThueDia_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("không tồn tại mã đĩa hoặc mã khách hoặc mã quản lý");
                }
            }
        }

        private void dNgayThue_EditValueChanged(object sender, EventArgs e)
        {
       
        }

        private void dgvPhieuthue_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void txtMaKhach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            float soLuong = 0, kq = 0;

            soLuong = float.Parse(numSoLuong.Text);
            kq = soLuong * 15000;

            txtThanhTien.ReadOnly = true;

            txtThanhTien.Text = kq + "";

        }
    }
    }

