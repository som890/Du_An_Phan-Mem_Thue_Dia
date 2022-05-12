using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class frmCustomer : Form
    {
        KhachHang_BUS khBus = new KhachHang_BUS();
        public frmCustomer()
        {
            InitializeComponent();
        }

    
        private void SetTitleForTable()
        {
            dgvCustomer.Columns[0].HeaderText = "Mã khách hàng";
            dgvCustomer.Columns[1].HeaderText = "Tên khách hàng";
            dgvCustomer.Columns[2].HeaderText = "Địa chỉ";
            dgvCustomer.Columns[3].HeaderText = "Điện thoại";
            dgvCustomer.Columns[4].HeaderText = "Giới tính";
            dgvCustomer.Columns[5].HeaderText = "Năm sinh";
            dgvCustomer.Columns[0].Width = 150;
            dgvCustomer.Columns[1].Width = 200;
            dgvCustomer.Columns[2].Width = 150;
            dgvCustomer.Columns[3].Width = 150;
            dgvCustomer.Columns[4].Width = 140;
            dgvCustomer.Columns[5].Width = 140;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaKhach.Text != "" && txtTenKhach.Text != "" && txtDiaChi.Text != "" && txtDienThoai.Text != "" && cbbGioiTinh.Text != "" && cbbNamSinh.Text != "")
            {
             
                // Tạo DTo
                KhachHang kh = new KhachHang(txtMaKhach.Text, txtTenKhach.Text, txtDiaChi.Text, txtDienThoai.Text,cbbGioiTinh.Text,cbbNamSinh.Text); 
                // Them
                if (khBus.Them(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvCustomer.DataSource = khBus.GetList(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        public void Reset()
        {
            txtMaKhach.ReadOnly = false;
            txtMaKhach.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            cbbGioiTinh.Text = "";
            cbbNamSinh.Text = "";
            txtTenKhach.Text = "";
        }
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = khBus.GetList();
            SetTitleForTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                if (txtMaKhach.Text != "" && txtTenKhach.Text != "" && txtDiaChi.Text != "" && txtDienThoai.Text != "" && cbbGioiTinh.Text != "" && cbbNamSinh.Text != "")
                {
                
                    DataGridViewRow row = dgvCustomer.SelectedRows[0];
                  
                    KhachHang kh = new KhachHang(txtMaKhach.Text, txtTenKhach.Text, txtDiaChi.Text, txtDienThoai.Text, cbbGioiTinh.Text, cbbNamSinh.Text);

                    if (khBus.Sua(kh))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvCustomer.DataSource = khBus.GetList(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn băng đĩa muốn sửa");
            }
            Reset();

        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhach.ReadOnly = true;
            int index = dgvCustomer.CurrentRow.Index;
            txtMaKhach.Text = dgvCustomer.Rows[index].Cells[0].Value.ToString();
            txtTenKhach.Text = dgvCustomer.Rows[index].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvCustomer.Rows[index].Cells[2].Value.ToString();
            txtDienThoai.Text = dgvCustomer.Rows[index].Cells[3].Value.ToString();
            cbbGioiTinh.Text = dgvCustomer.Rows[index].Cells[4].Value.ToString();
            cbbNamSinh.Text = dgvCustomer.Rows[index].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
         
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                DialogResult dlr = MessageBox.Show("Ban có thực sự muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    
                    DataGridViewRow row = dgvCustomer.SelectedRows[0];
                    string maKhach = row.Cells[0].Value.ToString();

                    // Xóa
                    if (khBus.Xoa(maKhach))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvCustomer.DataSource = khBus.GetList(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Xóa ko thành công");
                    }
                }
                

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
            Reset();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.Text == " ")
            {
                dgvCustomer.DataSource = khBus.GetList();
            }
            else
                dgvCustomer.DataSource = khBus.TimKiem(txtFind.Text);
        }

        private void txtTenKhach_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


