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
    public partial class frmCDManage : Form
    {
        BangDia_BUS bangDiaBus = new BangDia_BUS();
        public frmCDManage()
        {
            InitializeComponent();
        }

      
        private void ResetGridview()
        {
            txtMaDia.ResetText();
            txtTenDia.ResetText();
            cbbTheLoai.ResetText();
            txtDanhMuc.ResetText();
            numSoLuong.ResetText();
            txtDonGia.ResetText();

        }
        private void SetTitleForTableCD()
        {
            dgvCDManage.Columns[0].HeaderText = "Mã băng đĩa";
            dgvCDManage.Columns[1].HeaderText = "Tên băng đĩa";
            dgvCDManage.Columns[2].HeaderText = "Trạng thái";
            dgvCDManage.Columns[3].HeaderText = "Danh mục";
            dgvCDManage.Columns[4].HeaderText = "Số lượng";
            dgvCDManage.Columns[5].HeaderText = "Đơn giá";
            dgvCDManage.Columns[0].Width = 100;
            dgvCDManage.Columns[1].Width = 150;
            dgvCDManage.Columns[2].Width = 100;
            dgvCDManage.Columns[3].Width = 150;
            dgvCDManage.Columns[4].Width = 100;
            dgvCDManage.Columns[5].Width = 130;
            dgvCDManage.AllowUserToAddRows = false;
            dgvCDManage.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

    

       

        private void frmCDManage_Load_1(object sender, EventArgs e)
        {
            dgvCDManage.DataSource = bangDiaBus.GetList();
            SetTitleForTableCD();
        }

    
        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            if (dgvCDManage.SelectedRows.Count > 0)
            {
                if (txtMaDia.Text != "" && txtTenDia.Text != "" && cbbTheLoai.Text != "" && txtDanhMuc.Text != "" && numSoLuong.Text != "" && txtDonGia.Text != "")
                {
                    
                    DataGridViewRow row = dgvCDManage.SelectedRows[0];
                    float soLuong = float.Parse(row.Cells[4].Value.ToString());
                    float donGia = float.Parse(row.Cells[5].Value.ToString());

                 
                    BangDia bd = new BangDia(txtMaDia.Text, txtTenDia.Text, cbbTheLoai.Text, txtDanhMuc.Text, soLuong, donGia);
                    DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn sửa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dlr == DialogResult.Yes)
                    {
                        if (bangDiaBus.Sua(bd))
                        {

                            dgvCDManage.DataSource = bangDiaBus.GetList();
                            MessageBox.Show("Sửa thành công");
                            // refresh datagridview
                        }
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
        }

        private void dgvCDManage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDia.ReadOnly = true;
            int index = dgvCDManage.CurrentRow.Index;
            txtMaDia.Text = dgvCDManage.Rows[index].Cells[0].Value.ToString();
            txtTenDia.Text = dgvCDManage.Rows[index].Cells[1].Value.ToString();
            cbbTheLoai.Text = dgvCDManage.Rows[index].Cells[2].Value.ToString();
            txtDanhMuc.Text = dgvCDManage.Rows[index].Cells[3].Value.ToString();
            numSoLuong.Text = dgvCDManage.Rows[index].Cells[4].Value.ToString();
            txtDonGia.Text = dgvCDManage.Rows[index].Cells[5].Value.ToString();
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

  
                if (dgvCDManage.SelectedRows.Count > 0)
                {
                DialogResult dlr = MessageBox.Show("Ban có thực sự muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {

                    DataGridViewRow row = dgvCDManage.SelectedRows[0];
                    string maDia = row.Cells[0].Value.ToString();

                   
                    if (bangDiaBus.Xoa(maDia))
                    {
                        MessageBox.Show("Xóa thành công");
                        dgvCDManage.DataSource = bangDiaBus.GetList(); // refresh datagridview
                    }
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

                }
                else
                {
                    MessageBox.Show("Hãy chọn thành viên muốn xóa");
                }
            }

      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaDia.Text != "" && txtTenDia.Text != "" && cbbTheLoai.Text != "" && txtDanhMuc.Text != "" && numSoLuong.Text != "" && txtDonGia.Text != "")
            {


                float SoLuong = float.Parse(numSoLuong.Text);
                float DonGia = float.Parse(txtDonGia.Text);

                BangDia bd = new BangDia(txtMaDia.Text, txtTenDia.Text, cbbTheLoai.Text, txtDanhMuc.Text, SoLuong, DonGia);


                if (bangDiaBus.Them(bd))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvCDManage.DataSource = bangDiaBus.GetList(); // refresh datagridview
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
            ResetGridview();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtMaDia.Text == "")
            {
                dgvCDManage.DataSource = bangDiaBus.GetList();
            }
            else
                dgvCDManage.DataSource = bangDiaBus.TimKiem(txtMaDia.Text, "MaSach");
        }
    }
    }


        
        
    

