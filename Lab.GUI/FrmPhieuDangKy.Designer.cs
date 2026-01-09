
namespace Lab.GUI
{
    partial class FrmPhieuDangKy
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.Panel panelButtons;

        // Info Controls
        private System.Windows.Forms.Label lblMaPDK;
        private System.Windows.Forms.TextBox txtMaPDK;
        
        private System.Windows.Forms.Label lblSinhVien;
        private System.Windows.Forms.ComboBox cmbSinhVien;
        
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ComboBox cmbPhong;
        
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cmbNhanVien;

        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.NumericUpDown numHocKy;
        
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.TextBox txtNamHoc;
        
        private System.Windows.Forms.Label lblNgayDK;
        private System.Windows.Forms.DateTimePicker dtpNgayDK;
        
        private System.Windows.Forms.Label lblThoiHan;
        private System.Windows.Forms.NumericUpDown numThoiHan;

        // Buttons
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTimKiem;

        // Grid
        private System.Windows.Forms.DataGridView dgvPhieuDK;

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
            this.dgvPhieuDK = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();

            this.lblMaPDK = new System.Windows.Forms.Label();
            this.txtMaPDK = new System.Windows.Forms.TextBox();
            this.lblSinhVien = new System.Windows.Forms.Label();
            this.cmbSinhVien = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.numHocKy = new System.Windows.Forms.NumericUpDown();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.lblNgayDK = new System.Windows.Forms.Label();
            this.dtpNgayDK = new System.Windows.Forms.DateTimePicker();
            this.lblThoiHan = new System.Windows.Forms.Label();
            this.numThoiHan = new System.Windows.Forms.NumericUpDown();

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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiHan)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237))))); // Violet
            this.panelHeader.Controls.Add(this.lblSubTitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 100);
            this.panelHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "ĐĂNG KÝ LƯU TRÚ";
            
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(254))))); // Light Violet
            this.lblSubTitle.Location = new System.Drawing.Point(40, 65);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Text = "Quản lý phiếu đăng ký phòng cho sinh viên";

            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.grpDanhSach);
            this.panelBody.Controls.Add(this.grpThongTin);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 100);
            this.panelBody.Padding = new System.Windows.Forms.Padding(15);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1100, 600);
            this.panelBody.TabIndex = 1;

            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.numThoiHan);
            this.grpThongTin.Controls.Add(this.lblThoiHan);
            this.grpThongTin.Controls.Add(this.dtpNgayDK);
            this.grpThongTin.Controls.Add(this.lblNgayDK);
            this.grpThongTin.Controls.Add(this.txtNamHoc);
            this.grpThongTin.Controls.Add(this.lblNamHoc);
            this.grpThongTin.Controls.Add(this.numHocKy);
            this.grpThongTin.Controls.Add(this.lblHocKy);
            this.grpThongTin.Controls.Add(this.cmbNhanVien);
            this.grpThongTin.Controls.Add(this.lblNhanVien);
            this.grpThongTin.Controls.Add(this.cmbPhong);
            this.grpThongTin.Controls.Add(this.lblPhong);
            this.grpThongTin.Controls.Add(this.cmbSinhVien);
            this.grpThongTin.Controls.Add(this.lblSinhVien);
            this.grpThongTin.Controls.Add(this.txtMaPDK);
            this.grpThongTin.Controls.Add(this.lblMaPDK);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpThongTin.Width = 380;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.grpThongTin.Location = new System.Drawing.Point(15, 15);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(380, 570);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.Text = " Thông tin phiếu ";

            // MaPDK
            this.lblMaPDK.Location = new System.Drawing.Point(20, 35); this.lblMaPDK.Text = "Mã Phiếu:"; this.lblMaPDK.AutoSize = true; this.lblMaPDK.ForeColor = System.Drawing.Color.Black; this.lblMaPDK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaPDK.Location = new System.Drawing.Point(130, 32); this.txtMaPDK.Size = new System.Drawing.Size(220, 25); this.txtMaPDK.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtMaPDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // SV
            this.lblSinhVien.Location = new System.Drawing.Point(20, 85); this.lblSinhVien.Text = "Sinh Viên:"; this.lblSinhVien.AutoSize = true; this.lblSinhVien.ForeColor = System.Drawing.Color.Black; this.lblSinhVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSinhVien.Location = new System.Drawing.Point(130, 82); this.cmbSinhVien.Size = new System.Drawing.Size(220, 25); this.cmbSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Phong
            this.lblPhong.Location = new System.Drawing.Point(20, 135); this.lblPhong.Text = "Phòng:"; this.lblPhong.AutoSize = true; this.lblPhong.ForeColor = System.Drawing.Color.Black; this.lblPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPhong.Location = new System.Drawing.Point(130, 132); this.cmbPhong.Size = new System.Drawing.Size(220, 25); this.cmbPhong.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // NhanVien
            this.lblNhanVien.Location = new System.Drawing.Point(20, 185); this.lblNhanVien.Text = "Nhân Viên:"; this.lblNhanVien.AutoSize = true; this.lblNhanVien.ForeColor = System.Drawing.Color.Black; this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbNhanVien.Location = new System.Drawing.Point(130, 182); this.cmbNhanVien.Size = new System.Drawing.Size(220, 25); this.cmbNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // HocKy & NamHoc
            this.lblHocKy.Location = new System.Drawing.Point(20, 235); this.lblHocKy.Text = "Học Kỳ:"; this.lblHocKy.AutoSize = true; this.lblHocKy.ForeColor = System.Drawing.Color.Black; this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numHocKy.Location = new System.Drawing.Point(130, 232); this.numHocKy.Size = new System.Drawing.Size(60, 25); this.numHocKy.Font = new System.Drawing.Font("Segoe UI", 10F); this.numHocKy.Minimum = 1; this.numHocKy.Maximum = 3; this.numHocKy.Value = 1;
            
            this.lblNamHoc.Location = new System.Drawing.Point(200, 235); this.lblNamHoc.Text = "Năm:"; this.lblNamHoc.AutoSize = true; this.lblNamHoc.ForeColor = System.Drawing.Color.Black; this.lblNamHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNamHoc.Location = new System.Drawing.Point(240, 232); this.txtNamHoc.Size = new System.Drawing.Size(110, 25); this.txtNamHoc.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtNamHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.txtNamHoc.Text = System.DateTime.Now.Year.ToString();

            // NgayDK
            this.lblNgayDK.Location = new System.Drawing.Point(20, 285); this.lblNgayDK.Text = "Ngày ĐK:"; this.lblNgayDK.AutoSize = true; this.lblNgayDK.ForeColor = System.Drawing.Color.Black; this.lblNgayDK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayDK.Location = new System.Drawing.Point(130, 282); this.dtpNgayDK.Size = new System.Drawing.Size(220, 25); this.dtpNgayDK.Font = new System.Drawing.Font("Segoe UI", 10F); this.dtpNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // ThoiHan
            this.lblThoiHan.Location = new System.Drawing.Point(20, 335); this.lblThoiHan.Text = "Thời hạn (Tháng):"; this.lblThoiHan.AutoSize = true; this.lblThoiHan.ForeColor = System.Drawing.Color.Black; this.lblThoiHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numThoiHan.Location = new System.Drawing.Point(130, 332); this.numThoiHan.Size = new System.Drawing.Size(220, 25); this.numThoiHan.Font = new System.Drawing.Font("Segoe UI", 10F); this.numThoiHan.Minimum = 1; this.numThoiHan.Maximum = 12; this.numThoiHan.Value = 5;

            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvPhieuDK);
            this.grpDanhSach.Controls.Add(this.panelButtons);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Location = new System.Drawing.Point(395, 15);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Padding = new System.Windows.Forms.Padding(10);
            this.grpDanhSach.Size = new System.Drawing.Size(690, 570);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = " Danh sách phiếu đăng ký ";
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));

            // 
            // panelButtons
            // 
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Height = 70;
            this.panelButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelButtons.Controls.Add(this.btnThem);
            this.panelButtons.Controls.Add(this.btnSua);
            this.panelButtons.Controls.Add(this.btnXoa);
            this.panelButtons.Controls.Add(this.btnLuu);
            this.panelButtons.Controls.Add(this.btnHuy);
            this.panelButtons.Controls.Add(this.txtTimKiem);
            this.panelButtons.Controls.Add(this.btnThoat);

            // Button Styles (Flat, Modern)
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(10, 15);
            this.btnThem.Size = new System.Drawing.Size(85, 40);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(105, 15);
            this.btnSua.Size = new System.Drawing.Size(85, 40);
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(200, 15);
            this.btnXoa.Size = new System.Drawing.Size(85, 40);
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38))))); // Red
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLuu.Text = "Lưu";
            this.btnLuu.Location = new System.Drawing.Point(295, 15);
            this.btnLuu.Size = new System.Drawing.Size(85, 40);
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235))))); // Blue
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            this.btnHuy.Text = "Hủy";
            this.btnHuy.Location = new System.Drawing.Point(390, 15);
            this.btnHuy.Size = new System.Drawing.Size(85, 40);
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.Enabled = false;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.txtTimKiem.Location = new System.Drawing.Point(490, 20);
            this.txtTimKiem.Size = new System.Drawing.Size(110, 30);
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.Location = new System.Drawing.Point(600, 15);
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // 
            // dgvPhieuDK
            // 
            this.dgvPhieuDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuDK.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuDK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhieuDK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhieuDK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPhieuDK.EnableHeadersVisualStyles = false;
            
            // Header Style
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhieuDK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhieuDK.ColumnHeadersHeight = 45;

            // Row Style
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPhieuDK.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhieuDK.RowTemplate.Height = 40;
            this.dgvPhieuDK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuDK.RowHeadersVisible = false;
            this.dgvPhieuDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuDK.Location = new System.Drawing.Point(10, 80); 
            this.dgvPhieuDK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuDK_CellClick);

            // 
            // FrmPhieuDangKy
            // 
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPhieuDangKy";
            this.Text = "ĐĂNG KÝ PHÒNG";
            this.Load += new System.EventHandler(this.FrmPhieuDangKy_Load);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThoiHan)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
