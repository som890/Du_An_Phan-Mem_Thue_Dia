using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel_12 = Microsoft.Office.Interop.Excel;
using DTO;
using BUS;
namespace GUI
{
    public partial class frmPhieuTra : Form
    {
        PhieuTra_BUS ptBus = new PhieuTra_BUS();
        public frmPhieuTra()
        {
            InitializeComponent();
        }

        private void SetTittleForTable()
        {
            dgvPhieuTra.Columns[0].HeaderText = "Mã phiếu trả";
            dgvPhieuTra.Columns[1].HeaderText = "Số lượng";
            dgvPhieuTra.Columns[2].HeaderText = "Ngày trả";
            dgvPhieuTra.Columns[3].HeaderText = "Mã khách ";
            dgvPhieuTra.Columns[4].HeaderText = "Tên khách";
            dgvPhieuTra.Columns[5].HeaderText = "Mã đĩa";
            dgvPhieuTra.Columns[6].HeaderText = "Tên đĩa";

            dgvPhieuTra.Columns[7].HeaderText = "Hạn trả";
            dgvPhieuTra.Columns[8].HeaderText = "Quá hạn";
            dgvPhieuTra.Columns[9].HeaderText = "Phạt quá hạn";
            dgvPhieuTra.Columns[10].HeaderText = "Số đĩa hỏng";
            dgvPhieuTra.Columns[11].HeaderText = "Phạt hư hỏng";
            dgvPhieuTra.Columns[12].HeaderText = "Thành tiền";

            dgvPhieuTra.Columns[0].Width = 120;
            dgvPhieuTra.Columns[1].Width = 100;
            dgvPhieuTra.Columns[2].Width = 80;
            dgvPhieuTra.Columns[3].Width = 80;
            dgvPhieuTra.Columns[4].Width = 80;
            dgvPhieuTra.Columns[5].Width = 100;
            dgvPhieuTra.Columns[6].Width = 100;
            dgvPhieuTra.Columns[7].Width = 120;
            dgvPhieuTra.Columns[8].Width = 120;
            dgvPhieuTra.Columns[9].Width = 120;
            dgvPhieuTra.Columns[10].Width = 120;
            dgvPhieuTra.Columns[11].Width = 120;
            dgvPhieuTra.Columns[12].Width = 120;


        }


        private void frmPhieuTra_Load(object sender, EventArgs e)
        {
            dgvPhieuTra.DataSource = ptBus.GetList();
            SetTittleForTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ptBus.CheckExist("tblKhachHangg", txtMaKhach.Text) == true && ptBus.CheckExist("tblBangDia", txtMaDia.Text) == true)
            {
                PhieuTra pt = new PhieuTra();

                pt.MaPhieuGia = txtMaPhieuGia.Text;
                pt.MaKhach = txtMaKhach.Text;
                pt.MaDia = txtMaDia.Text;
                pt.SoLuong = float.Parse(numSoLuong.Text);
                pt.QuaHan = float.Parse(numQuaHan.Text);
                pt.PhatQuaHan = float.Parse(txtPhatQuaHan.Text);
                pt.SoDiaHong = float.Parse(numSoDiaHong.Text);
                pt.PhatHuHong = float.Parse(txtPhathuHong.Text);
                pt.ThanhTien = float.Parse(txtThanhTien.Text);


                if (dNgayTra.Text == "")
                    pt.NgayTra = DateTime.Now;
                else
                    pt.NgayTra = dNgayTra.DateTime;

                if (dHanTra.Text == "")
                    pt.HanTra = DateTime.Now;
                else
                    pt.HanTra = dHanTra.DateTime;

                int check = ptBus.Them(pt);
                if (check == -1)
                    MessageBox.Show("Dữ liệu ko trùng nhau!");
                else
                    frmPhieuTra_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Mã băng đĩa hoặc mã khách hàng không khớp");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuGia.Text != "")
            {
                if (ptBus.CheckExist("tblBangDia", txtMaDia.Text) == true && ptBus.CheckExist("tblKhachHangg", txtMaKhach.Text) == true)
                {
                    PhieuTra pt = new PhieuTra();

                    pt.MaPhieuGia = txtMaPhieuGia.Text;
                    pt.MaKhach = txtMaKhach.Text;
                    pt.MaDia = txtMaDia.Text;
                    pt.SoLuong = float.Parse(numSoLuong.Text);
                    pt.QuaHan = float.Parse(numQuaHan.Text);
                    pt.PhatQuaHan = float.Parse(txtPhatQuaHan.Text);
                    pt.SoDiaHong = float.Parse(numSoDiaHong.Text);
                    pt.PhatHuHong = float.Parse(txtPhathuHong.Text);
                    pt.ThanhTien = float.Parse(txtThanhTien.Text);


                    if (dNgayTra.Text == "")
                        pt.NgayTra = DateTime.Now;
                    else
                        pt.NgayTra = dNgayTra.DateTime;

                    if (dHanTra.Text == "")
                        pt.HanTra = DateTime.Now;
                    else
                        pt.HanTra = dHanTra.DateTime;

                    ptBus.Sua(pt);
                    frmPhieuTra_Load(sender, e);
                }
            }
        }





        private void btnXuatPhieuGia_Click(object sender, EventArgs e)
        {
            /*Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= dgvPhieuTra.RowCount - 1; i++)
            {
                for (j = 0; j <= dgvPhieuTra.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgvPhieuTra[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            xlWorkBook.SaveAs("quanlyphieutradia.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Đã tạo file Excel, Fil được lưu tại ổ đĩa C: \\quanlyphieutradia.xls");
            */

            
     
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuGia.Text != "")
            {
                DialogResult dlr = MessageBox.Show("Ban có thực sự muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    ptBus.Xoa(txtMaPhieuGia.Text);
                    frmPhieuTra_Load(sender, e);
                }

            }
        }

        private void dgvPhieuTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy row hiện tại
         //   DataGridViewRow row = dgvPhieuTra.SelectedRows[0];

            // Chuyển giá trị lên form

            txtMaPhieuGia.ReadOnly = true;

            int index = dgvPhieuTra.CurrentRow.Index;

            txtMaPhieuGia.Text = dgvPhieuTra.Rows[index].Cells[0].Value.ToString();
            numSoLuong.Text = dgvPhieuTra.Rows[index].Cells[1].Value.ToString();
            dNgayTra.Text = dgvPhieuTra.Rows[index].Cells[2].Value.ToString();
            txtMaKhach.Text = dgvPhieuTra.Rows[index].Cells[3].Value.ToString();
            txtMaDia.Text = dgvPhieuTra.Rows[index].Cells[5].Value.ToString();
            dHanTra.Text = dgvPhieuTra.Rows[index].Cells[7].Value.ToString();
            numQuaHan.Text = dgvPhieuTra.Rows[index].Cells[8].Value.ToString();
            txtPhatQuaHan.Text = dgvPhieuTra.Rows[index].Cells[9].Value.ToString();
            numSoDiaHong.Text = dgvPhieuTra.Rows[index].Cells[10].Value.ToString();
            txtPhathuHong.Text = dgvPhieuTra.Rows[index].Cells[11].Value.ToString();
            txtThanhTien.Text = dgvPhieuTra.Rows[index].Cells[12].Value.ToString();



         
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                dgvPhieuTra.DataSource = ptBus.GetList();

            }
            else
            {
                if (chkMaDia.Checked == true)
                    dgvPhieuTra.DataSource = ptBus.TimKiem(txtFind.Text, "MaDia");
                else if (chkMaKhach.Checked == true)
                    dgvPhieuTra.DataSource = ptBus.TimKiem(txtFind.Text, "MaKhachHang");
                else if (chkNgayTra.Checked == true)
                    dgvPhieuTra.DataSource = ptBus.TimKiem(txtFind.Text, "NgayTra");
            }
        }


        private void numQuaHan_ValueChanged(object sender, EventArgs e)
        {
            float soHan = 0, kqQuaHan = 0;
            soHan= float.Parse(numQuaHan.Text);
            kqQuaHan = soHan * 5000;

            txtPhatQuaHan.Text = kqQuaHan + "";
            txtPhatQuaHan.ReadOnly = true;
        }

        private void numSoDiaHong_ValueChanged(object sender, EventArgs e)
        {
            float soDiaHong = 0, kqDiaHong = 0, soA =0, soB = 0, kq;

            soDiaHong = float.Parse(numSoDiaHong.Text);
            kqDiaHong = soDiaHong * 5000;

            txtPhathuHong.Text = kqDiaHong + "";
            txtPhathuHong.ReadOnly = true;

            soA= float.Parse(txtPhatQuaHan.Text);
            soB= float.Parse(txtPhathuHong.Text);

            kq = soA + soB;

            txtThanhTien.Text = kq + "";

        }

        private void btnXuatPhieuGia_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;


            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Name = "Doanh thu cửa hàng băng đĩa";

            for (int i = 0; i < dgvPhieuTra.ColumnCount; i++)
            {
                xlWorkSheet.Cells[1, i + 1] = dgvPhieuTra.Columns[i].HeaderText;

            }
            for (int i = 0; i <= dgvPhieuTra.RowCount - 1; i++)
            {
                for (int j = 0; j <= dgvPhieuTra.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgvPhieuTra[j, i];
                    xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                }
            }

            Microsoft.Office.Interop.Excel.Range rowHead = xlWorkSheet.get_Range("A1", "M1");
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            rowHead.Interior.ColorIndex = 3;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //Thiết lập độ rộng
            Microsoft.Office.Interop.Excel.Range cl1 = xlWorkSheet.get_Range("A1", "A1");
            cl1.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl2 = xlWorkSheet.get_Range("B1", "B1");
            cl2.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl3 = xlWorkSheet.get_Range("C1", "C1");
            cl3.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl4 = xlWorkSheet.get_Range("D1", "D1");
            cl4.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl5 = xlWorkSheet.get_Range("E1", "E1");
            cl5.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl6 = xlWorkSheet.get_Range("F1", "F1");
            cl6.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl7 = xlWorkSheet.get_Range("G1", "G1");
            cl7.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl8 = xlWorkSheet.get_Range("H1", "H1");
            cl8.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl9 = xlWorkSheet.get_Range("I1", "J1");
            cl9.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl10 = xlWorkSheet.get_Range("J1", "J1");
            cl10.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl11 = xlWorkSheet.get_Range("K1", "K1");
            cl11.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl12 = xlWorkSheet.get_Range("L1", "L1");
            cl12.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range cl13 = xlWorkSheet.get_Range("M1", "M1");
            cl13.ColumnWidth = 13.5;


            xlWorkBook.SaveAs("doanhthuthang9.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();


            //   releaseObject(xlWorkSheet);
            //       releaseObject(xlWorkBook);
            //    releaseObject(xlApp);

            MessageBox.Show("Xuất file thống kê thành công!");
        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

