
namespace Lab.GUI
{
    partial class FrmNhanVien
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.Panel panelButtons;

        // Inputs
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.ComboBox cmbNguoiQuanLy;
        
        // Labels
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblNguoiQuanLy;

        // Buttons
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.DataGridView dgvNhanVien;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();

            // Inputs / Labels
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.cmbNguoiQuanLy = new System.Windows.Forms.ComboBox();

            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblNguoiQuanLy = new System.Windows.Forms.Label();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();

            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelHeader - ROSE THEME (#BE123C)
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(18)))), ((int)(((byte)(60)))));
            this.panelHeader.Controls.Add(this.lblSubTitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 80);
            this.panelHeader.TabIndex = 0;
            
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "HỒ SƠ NHÂN SỰ";
            
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(230)))));
            this.lblSubTitle.Location = new System.Drawing.Point(30, 55);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Text = "Quản lý thông tin nhân viên và cơ cấu tổ chức";

            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.grpDanhSach);
            this.panelBody.Controls.Add(this.grpThongTin);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 80);
            this.panelBody.Padding = new System.Windows.Forms.Padding(10);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1100, 620);
            this.panelBody.TabIndex = 1;

            // 
            // grpThongTin (Top section)
            // 
            this.grpThongTin.Controls.Add(this.txtLuong);
            this.grpThongTin.Controls.Add(this.lblLuong);
            this.grpThongTin.Controls.Add(this.cmbNguoiQuanLy);
            this.grpThongTin.Controls.Add(this.lblNguoiQuanLy);
            this.grpThongTin.Controls.Add(this.txtDiaChi);
            this.grpThongTin.Controls.Add(this.lblDiaChi);
            this.grpThongTin.Controls.Add(this.txtEmail);
            this.grpThongTin.Controls.Add(this.lblEmail);
            this.grpThongTin.Controls.Add(this.txtSDT);
            this.grpThongTin.Controls.Add(this.lblSDT);
            this.grpThongTin.Controls.Add(this.txtCMND);
            this.grpThongTin.Controls.Add(this.lblCMND);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.lblHoTen);
            this.grpThongTin.Controls.Add(this.txtMaNV);
            this.grpThongTin.Controls.Add(this.lblMaNV);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(18)))), ((int)(((byte)(60))))); // Rose color text
            this.grpThongTin.Location = new System.Drawing.Point(10, 10);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(1080, 180);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.Text = "Thông Tin Chi Tiết";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(5);

            // Inputs Layout 4x2
            // Inputs Layout 4x2 - Replaced with static values
            int txtW = 160; // Keep local width var if needed or inline it. Better inline for 100% safety? 
            // In InitializeComponent, local vars are okay if they are const-like, but `int txtW=160` is technically dynamic code.
            // Designer might tolerate `int const` but simpler to just hardcode width too.
            // Actually, `Size` property takes a `Size` object which is fine.
            // I will hardcode the width to be safe.

            // Row 1
            this.lblMaNV.Location = new System.Drawing.Point(30, 40); this.lblMaNV.Text = "Mã NV:"; this.lblMaNV.AutoSize = true; this.lblMaNV.ForeColor = System.Drawing.Color.Black; this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNV.Location = new System.Drawing.Point(100, 37); this.txtMaNV.Size = new System.Drawing.Size(160, 25); this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblHoTen.Location = new System.Drawing.Point(280, 40); this.lblHoTen.Text = "Họ tên:"; this.lblHoTen.AutoSize = true; this.lblHoTen.ForeColor = System.Drawing.Color.Black; this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoTen.Location = new System.Drawing.Point(350, 37); this.txtHoTen.Size = new System.Drawing.Size(160, 25); this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblCMND.Location = new System.Drawing.Point(540, 40); this.lblCMND.Text = "CMND:"; this.lblCMND.AutoSize = true; this.lblCMND.ForeColor = System.Drawing.Color.Black; this.lblCMND.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCMND.Location = new System.Drawing.Point(610, 37); this.txtCMND.Size = new System.Drawing.Size(160, 25); this.txtCMND.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtCMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblSDT.Location = new System.Drawing.Point(800, 40); this.lblSDT.Text = "SĐT:"; this.lblSDT.AutoSize = true; this.lblSDT.ForeColor = System.Drawing.Color.Black; this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.Location = new System.Drawing.Point(870, 37); this.txtSDT.Size = new System.Drawing.Size(160, 25); this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Row 2
            this.lblEmail.Location = new System.Drawing.Point(30, 100); this.lblEmail.Text = "Email:"; this.lblEmail.AutoSize = true; this.lblEmail.ForeColor = System.Drawing.Color.Black; this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(100, 97); this.txtEmail.Size = new System.Drawing.Size(160, 25); this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblDiaChi.Location = new System.Drawing.Point(280, 100); this.lblDiaChi.Text = "Địa chỉ:"; this.lblDiaChi.AutoSize = true; this.lblDiaChi.ForeColor = System.Drawing.Color.Black; this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi.Location = new System.Drawing.Point(350, 97); this.txtDiaChi.Size = new System.Drawing.Size(160, 25); this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblLuong.Location = new System.Drawing.Point(540, 100); this.lblLuong.Text = "Lương:"; this.lblLuong.AutoSize = true; this.lblLuong.ForeColor = System.Drawing.Color.Black; this.lblLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLuong.Location = new System.Drawing.Point(610, 97); this.txtLuong.Size = new System.Drawing.Size(160, 25); this.txtLuong.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblNguoiQuanLy.Location = new System.Drawing.Point(800, 100); this.lblNguoiQuanLy.Text = "Quản lý:"; this.lblNguoiQuanLy.AutoSize = true; this.lblNguoiQuanLy.ForeColor = System.Drawing.Color.Black; this.lblNguoiQuanLy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbNguoiQuanLy.Location = new System.Drawing.Point(870, 97); this.cmbNguoiQuanLy.Size = new System.Drawing.Size(160, 25); this.cmbNguoiQuanLy.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbNguoiQuanLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbNguoiQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.cmbNguoiQuanLy.BackColor = System.Drawing.Color.WhiteSmoke;

            // 
            // grpDanhSach (Bottom fill)
            // 
            this.grpDanhSach.Controls.Add(this.dgvNhanVien);
            this.grpDanhSach.Controls.Add(this.panelButtons);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Location = new System.Drawing.Point(10, 190);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1080, 420);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.Text = "Danh Sách Nhân Viên";
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // 
            // panelButtons
            // 
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Height = 60;
            this.panelButtons.BackColor = System.Drawing.Color.White;
            
            this.panelButtons.Controls.Add(this.btnThem);
            this.panelButtons.Controls.Add(this.btnSua);
            this.panelButtons.Controls.Add(this.btnXoa);
            this.panelButtons.Controls.Add(this.btnLuu);
            this.panelButtons.Controls.Add(this.btnHuy);
            this.panelButtons.Controls.Add(this.txtTimKiem);
            this.panelButtons.Controls.Add(this.btnThoat);

            // Helper for buttons
            int btnY = 12; int btnH = 36;
            
            this.btnThem.Location = new System.Drawing.Point(10, btnY); this.btnThem.Size = new System.Drawing.Size(90, btnH); this.btnThem.Text = "Thêm"; 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(18)))), ((int)(((byte)(60))))); this.btnThem.ForeColor = System.Drawing.Color.White; this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Location = new System.Drawing.Point(110, btnY); this.btnSua.Size = new System.Drawing.Size(90, btnH); this.btnSua.Text = "Sửa"; 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(18)))), ((int)(((byte)(60))))); this.btnSua.ForeColor = System.Drawing.Color.White; this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Location = new System.Drawing.Point(210, btnY); this.btnXoa.Size = new System.Drawing.Size(90, btnH); this.btnXoa.Text = "Xóa"; 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(113)))), ((int)(((byte)(133))))); this.btnXoa.ForeColor = System.Drawing.Color.White; this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLuu.Location = new System.Drawing.Point(310, btnY); this.btnLuu.Size = new System.Drawing.Size(90, btnH); this.btnLuu.Text = "Lưu"; 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105))))); this.btnLuu.ForeColor = System.Drawing.Color.White; this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLuu.FlatAppearance.BorderSize = 0; this.btnLuu.Enabled = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            this.btnHuy.Location = new System.Drawing.Point(410, btnY); this.btnHuy.Size = new System.Drawing.Size(90, btnH); this.btnHuy.Text = "Hủy"; 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128))))); this.btnHuy.ForeColor = System.Drawing.Color.White; this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnHuy.FlatAppearance.BorderSize = 0; this.btnHuy.Enabled = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.txtTimKiem.Location = new System.Drawing.Point(520, btnY + 6); this.txtTimKiem.Size = new System.Drawing.Size(200, 23); this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right; this.btnThoat.Location = new System.Drawing.Point(980, btnY); this.btnThoat.Size = new System.Drawing.Size(90, btnH); this.btnThoat.Text = "Thoát"; 
            this.btnThoat.BackColor = System.Drawing.Color.White; this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(18)))), ((int)(((byte)(60))))); this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(18)))), ((int)(((byte)(60)))));
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(18)))), ((int)(((byte)(60))))); // Rose Header
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.ColumnHeadersHeight = 40;
            
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(230))))); // Light Rose Selection
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.RowTemplate.Height = 35;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            
            // 
            // FrmNhanVien
            // 
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Name = "FrmNhanVien";
            this.Text = "HỒ SƠ NHÂN SỰ";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
