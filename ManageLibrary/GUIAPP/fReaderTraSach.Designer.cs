namespace GUIAPP
{
    partial class fReaderTraSach
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
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbTimKiemTheoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiemTheoMaSach = new System.Windows.Forms.TextBox();
            this.btnTimKiemTheoTenSach = new System.Windows.Forms.Button();
            this.btnTimKiemTheoMaSach = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbLocTheoNamXuatBan = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbLocTheoTenTacGia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbLocTheoTheLoai = new System.Windows.Forms.ComboBox();
            this.btnTimKiemTheoNamXuatBan = new System.Windows.Forms.Button();
            this.btnTimKiemTheoTacGia = new System.Windows.Forms.Button();
            this.btnTimKiemTheoTheLoai = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txbMaSachDaChon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.NamXuatBan,
            this.GiaSach,
            this.SoLuong,
            this.TenNhaXuatBan,
            this.TenTacGia,
            this.TenTheLoai});
            this.dgvSach.Location = new System.Drawing.Point(12, 182);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(917, 377);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cell_Click);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.DataPropertyName = "NamXuatBan";
            this.NamXuatBan.HeaderText = "Năm Xuất Bản";
            this.NamXuatBan.MinimumWidth = 6;
            this.NamXuatBan.Name = "NamXuatBan";
            // 
            // GiaSach
            // 
            this.GiaSach.DataPropertyName = "GiaSach";
            this.GiaSach.HeaderText = "Giá Sách";
            this.GiaSach.MinimumWidth = 6;
            this.GiaSach.Name = "GiaSach";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // TenNhaXuatBan
            // 
            this.TenNhaXuatBan.DataPropertyName = "TenNhaXuatBan";
            this.TenNhaXuatBan.HeaderText = "Tên Nhà Xuất Bản";
            this.TenNhaXuatBan.MinimumWidth = 6;
            this.TenNhaXuatBan.Name = "TenNhaXuatBan";
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.HeaderText = "Tên Tác Giả";
            this.TenTacGia.MinimumWidth = 6;
            this.TenTacGia.Name = "TenTacGia";
            // 
            // TenTheLoai
            // 
            this.TenTheLoai.DataPropertyName = "TenTheLoai";
            this.TenTheLoai.HeaderText = "Tên Thể Loại";
            this.TenTheLoai.MinimumWidth = 6;
            this.TenTheLoai.Name = "TenTheLoai";
            // 
            // txbTimKiemTheoTen
            // 
            this.txbTimKiemTheoTen.Location = new System.Drawing.Point(130, 61);
            this.txbTimKiemTheoTen.Name = "txbTimKiemTheoTen";
            this.txbTimKiemTheoTen.Size = new System.Drawing.Size(176, 22);
            this.txbTimKiemTheoTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tra Cứu & Mượn Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm theo tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tìm kiếm theo mã sách";
            // 
            // txtTimKiemTheoMaSach
            // 
            this.txtTimKiemTheoMaSach.Location = new System.Drawing.Point(163, 128);
            this.txtTimKiemTheoMaSach.Name = "txtTimKiemTheoMaSach";
            this.txtTimKiemTheoMaSach.Size = new System.Drawing.Size(143, 22);
            this.txtTimKiemTheoMaSach.TabIndex = 5;
            // 
            // btnTimKiemTheoTenSach
            // 
            this.btnTimKiemTheoTenSach.Image = global::GUIAPP.Properties.Resources.ChatGPT_Image_Apr_23__2025__11_40_11_AM;
            this.btnTimKiemTheoTenSach.Location = new System.Drawing.Point(313, 59);
            this.btnTimKiemTheoTenSach.Name = "btnTimKiemTheoTenSach";
            this.btnTimKiemTheoTenSach.Size = new System.Drawing.Size(29, 24);
            this.btnTimKiemTheoTenSach.TabIndex = 6;
            this.btnTimKiemTheoTenSach.UseVisualStyleBackColor = true;
            this.btnTimKiemTheoTenSach.Click += new System.EventHandler(this.btnTimKiemTheoTenSach_Click);
            // 
            // btnTimKiemTheoMaSach
            // 
            this.btnTimKiemTheoMaSach.Location = new System.Drawing.Point(313, 128);
            this.btnTimKiemTheoMaSach.Name = "btnTimKiemTheoMaSach";
            this.btnTimKiemTheoMaSach.Size = new System.Drawing.Size(29, 23);
            this.btnTimKiemTheoMaSach.TabIndex = 7;
            this.btnTimKiemTheoMaSach.Text = "button2";
            this.btnTimKiemTheoMaSach.UseVisualStyleBackColor = true;
            this.btnTimKiemTheoMaSach.Click += new System.EventHandler(this.btnTimKiemTheoMaSach_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lọc theo năm xuất bản";
            // 
            // cbbLocTheoNamXuatBan
            // 
            this.cbbLocTheoNamXuatBan.FormattingEnabled = true;
            this.cbbLocTheoNamXuatBan.Location = new System.Drawing.Point(523, 59);
            this.cbbLocTheoNamXuatBan.Name = "cbbLocTheoNamXuatBan";
            this.cbbLocTheoNamXuatBan.Size = new System.Drawing.Size(82, 24);
            this.cbbLocTheoNamXuatBan.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lọc theo tên tác giả";
            // 
            // cbbLocTheoTenTacGia
            // 
            this.cbbLocTheoTenTacGia.FormattingEnabled = true;
            this.cbbLocTheoTenTacGia.Location = new System.Drawing.Point(502, 127);
            this.cbbLocTheoTenTacGia.Name = "cbbLocTheoTenTacGia";
            this.cbbLocTheoTenTacGia.Size = new System.Drawing.Size(102, 24);
            this.cbbLocTheoTenTacGia.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(652, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lọc theo thể loại";
            // 
            // cbbLocTheoTheLoai
            // 
            this.cbbLocTheoTheLoai.FormattingEnabled = true;
            this.cbbLocTheoTheLoai.Location = new System.Drawing.Point(762, 56);
            this.cbbLocTheoTheLoai.Name = "cbbLocTheoTheLoai";
            this.cbbLocTheoTheLoai.Size = new System.Drawing.Size(139, 24);
            this.cbbLocTheoTheLoai.TabIndex = 13;
            // 
            // btnTimKiemTheoNamXuatBan
            // 
            this.btnTimKiemTheoNamXuatBan.Location = new System.Drawing.Point(611, 60);
            this.btnTimKiemTheoNamXuatBan.Name = "btnTimKiemTheoNamXuatBan";
            this.btnTimKiemTheoNamXuatBan.Size = new System.Drawing.Size(29, 23);
            this.btnTimKiemTheoNamXuatBan.TabIndex = 14;
            this.btnTimKiemTheoNamXuatBan.Text = "button3";
            this.btnTimKiemTheoNamXuatBan.UseVisualStyleBackColor = true;
            this.btnTimKiemTheoNamXuatBan.Click += new System.EventHandler(this.btnTimKiemTheoNamXuatBan_Click);
            // 
            // btnTimKiemTheoTacGia
            // 
            this.btnTimKiemTheoTacGia.Location = new System.Drawing.Point(611, 127);
            this.btnTimKiemTheoTacGia.Name = "btnTimKiemTheoTacGia";
            this.btnTimKiemTheoTacGia.Size = new System.Drawing.Size(29, 23);
            this.btnTimKiemTheoTacGia.TabIndex = 15;
            this.btnTimKiemTheoTacGia.Text = "button4";
            this.btnTimKiemTheoTacGia.UseVisualStyleBackColor = true;
            this.btnTimKiemTheoTacGia.Click += new System.EventHandler(this.btnTimKiemTheoTacGia_Click);
            // 
            // btnTimKiemTheoTheLoai
            // 
            this.btnTimKiemTheoTheLoai.Location = new System.Drawing.Point(907, 57);
            this.btnTimKiemTheoTheLoai.Name = "btnTimKiemTheoTheLoai";
            this.btnTimKiemTheoTheLoai.Size = new System.Drawing.Size(29, 23);
            this.btnTimKiemTheoTheLoai.TabIndex = 16;
            this.btnTimKiemTheoTheLoai.Text = "button5";
            this.btnTimKiemTheoTheLoai.UseVisualStyleBackColor = true;
            this.btnTimKiemTheoTheLoai.Click += new System.EventHandler(this.btnTimKiemTheoTheLoai_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(655, 117);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(274, 43);
            this.button6.TabIndex = 17;
            this.button6.Text = "Mượn Sách";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(650, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mã sách bạn đã chọn :";
            // 
            // txbMaSachDaChon
            // 
            this.txbMaSachDaChon.BackColor = System.Drawing.Color.Lime;
            this.txbMaSachDaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbMaSachDaChon.ForeColor = System.Drawing.Color.Snow;
            this.txbMaSachDaChon.Location = new System.Drawing.Point(897, 15);
            this.txbMaSachDaChon.Name = "txbMaSachDaChon";
            this.txbMaSachDaChon.Size = new System.Drawing.Size(32, 30);
            this.txbMaSachDaChon.TabIndex = 19;
            // 
            // fReaderTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 571);
            this.Controls.Add(this.txbMaSachDaChon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnTimKiemTheoTheLoai);
            this.Controls.Add(this.btnTimKiemTheoTacGia);
            this.Controls.Add(this.btnTimKiemTheoNamXuatBan);
            this.Controls.Add(this.cbbLocTheoTheLoai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbLocTheoTenTacGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbLocTheoNamXuatBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimKiemTheoMaSach);
            this.Controls.Add(this.btnTimKiemTheoTenSach);
            this.Controls.Add(this.txtTimKiemTheoMaSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTimKiemTheoTen);
            this.Controls.Add(this.dgvSach);
            this.Name = "fReaderTraSach";
            this.Text = "fReader";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTheLoai;
        private System.Windows.Forms.TextBox txbTimKiemTheoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiemTheoMaSach;
        private System.Windows.Forms.Button btnTimKiemTheoTenSach;
        private System.Windows.Forms.Button btnTimKiemTheoMaSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbLocTheoNamXuatBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbLocTheoTenTacGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbLocTheoTheLoai;
        private System.Windows.Forms.Button btnTimKiemTheoNamXuatBan;
        private System.Windows.Forms.Button btnTimKiemTheoTacGia;
        private System.Windows.Forms.Button btnTimKiemTheoTheLoai;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbMaSachDaChon;
    }
}