using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer;

namespace GUIAPP
{
    public partial class fReaderTraSach : Form
    {

        DBSach dbsach = new DBSach();
        public fReaderTraSach()
        {
            InitializeComponent();
            LoadNamSanXuat(); // Gọi hàm LoadNamSanXuat để nạp dữ liệu vào ComboBox
            LoadSach();
            LoadTenTacGia(); // Gọi hàm LoadTenTacGia để nạp dữ liệu vào ComboBox
            LoadTheLoai(); // Gọi hàm LoadTheLoai để nạp dữ liệu vào ComboBox
        }

        public void LoadSach()
        {
            string error = "";

            // Lấy dữ liệu từ DBSach
            DataSet ds = dbsach.GetAllSach(ref error);

            if (string.IsNullOrEmpty(error))
            {
                // Kiểm tra nếu DataSet có ít nhất một bảng
                if (ds != null && ds.Tables.Count > 0)
                {
                    dgvSach.DataSource = ds.Tables[0];  // Gán DataTable đầu tiên trong DataSet vào DataGridView
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu.");
                }
            }
            else
            {
                MessageBox.Show(error); // Hiển thị lỗi nếu có
            }

            // Tùy chỉnh tiêu đề cột
            dgvSach.Columns["MaSach"].HeaderText = "Mã Sách";
            dgvSach.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvSach.Columns["NamXuatBan"].HeaderText = "Năm Xuất Bản";
            dgvSach.Columns["GiaSach"].HeaderText = "Giá Sách";
            dgvSach.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgvSach.Columns["TenNhaXuatBan"].HeaderText = "Tên Nhà Xuất Bản";
            dgvSach.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
            dgvSach.Columns["TenTheLoai"].HeaderText = "Tên Thể Loại";
        }

        private void btnTimKiemTheoTenSach_Click(object sender, EventArgs e)
        {
            string tensach = txbTimKiemTheoTen.Text;
            string error = "";
            DataSet ds = dbsach.TimKiemTHeoTenSach(tensach, ref error);
            if (string.IsNullOrEmpty(error))
            {
                dgvSach.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show(error);
            }

        }
        private void btnTimKiemTheoMaSach_Click(object sender, EventArgs e)
        {
            int masach = int.Parse(txtTimKiemTheoMaSach.Text);

            string error = "";
            DataSet ds = dbsach.TimKiemTheoMaSach(masach, ref error);
            if (string.IsNullOrEmpty(error))
            {
                dgvSach.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show(error);
            }

        }

        public void LoadNamSanXuat()
        {
            string error = "";
            DataSet ds = dbsach.GetAllNamXuatBan(ref error);
            if (string.IsNullOrEmpty(error))
            {
                if (String.IsNullOrEmpty(error))
                {

                    cbbLocTheoNamXuatBan.DataSource = ds.Tables[0];
                    cbbLocTheoNamXuatBan.DisplayMember = "NamXuatBan";
                    cbbLocTheoNamXuatBan.ValueMember = "NamXuatBan";

                }
                else
                {
                    MessageBox.Show(error);
                }
            }
        }

        public void LoadTenTacGia()
        {
            string error = "";
            DataSet ds = dbsach.GetAllTacGia(ref error);
            if (string.IsNullOrEmpty(error))
            {
                if (String.IsNullOrEmpty(error))
                {
                    cbbLocTheoTenTacGia.DataSource = ds.Tables[0];
                    cbbLocTheoTenTacGia.DisplayMember = "TenTacGia";
                    cbbLocTheoTenTacGia.ValueMember = "TenTacGia";
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
        }
        public void LoadTheLoai()
        {
            string error = "";
            DataSet ds = dbsach.GetAllTheLoai(ref error);
            if (string.IsNullOrEmpty(error))
            {
                if (String.IsNullOrEmpty(error))
                {
                    cbbLocTheoTheLoai.DataSource = ds.Tables[0];
                    cbbLocTheoTheLoai.DisplayMember = "TenTheLoai";
                    cbbLocTheoTheLoai.ValueMember = "TenTheLoai";
                }
                else
                {
                    MessageBox.Show(error);
                }
            }
        }
        public void btnTimKiemTheoTacGia_Click(object sender, EventArgs e)
        {
            string tentacgia = cbbLocTheoTenTacGia.Text;
            string error = "";
            DataSet ds = dbsach.TimKiemTheoTacGia(tentacgia, ref error);
            if (string.IsNullOrEmpty(error))
            {
                dgvSach.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show(error);
            }
        }
        public void btnTimKiemTheoNamXuatBan_Click(object sender, EventArgs e)
        {
            int namxuatban = int.Parse(cbbLocTheoNamXuatBan.Text);
            string error = "";
            DataSet ds = dbsach.TimKiemTheoNamXuatBan(namxuatban, ref error);
            if (string.IsNullOrEmpty(error))
            {
                dgvSach.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        public void btnTimKiemTheoTheLoai_Click(object sender, EventArgs e)
        {
            string tentheloai = cbbLocTheoTheLoai.Text;
            string error = "";
            DataSet ds = dbsach.TimKiemTheoTheLoai(tentheloai, ref error);
            if (string.IsNullOrEmpty(error))
            {
                dgvSach.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        public void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSach.Rows[e.RowIndex];
                txbMaSachDaChon.Text = row.Cells["MaSach"].Value.ToString();

            }
        }
    }
}
