
namespace Lab.GUI
{
    partial class FrmHoaDon
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
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblNgayHD;
        private System.Windows.Forms.DateTimePicker dtpNgayHD;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ComboBox cmbPhong;

        // Buttons
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTimKiem;

        // Grid
        private System.Windows.Forms.DataGridView dgvHoaDon;

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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();

            this.lblMaHD = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblNgayHD = new System.Windows.Forms.Label();
            this.dtpNgayHD = new System.Windows.Forms.DateTimePicker();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cmbPhong = new System.Windows.Forms.ComboBox();

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
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199))))); // Sky Blue
            this.panelHeader.Controls.Add(this.lblSubTitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 100);
            this.panelHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "QUẢN LÝ HÓA ĐƠN";

            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254))))); // Light Sky Blue
            this.lblSubTitle.Location = new System.Drawing.Point(40, 65);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Text = "Quản lý hóa đơn, ngày lập và nhân viên";

            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.grpDanhSach);
            this.panelBody.Controls.Add(this.grpThongTin);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 100);
            this.panelBody.Padding = new System.Windows.Forms.Padding(15);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1000, 500);
            this.panelBody.TabIndex = 1;

            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.cmbPhong);
            this.grpThongTin.Controls.Add(this.lblPhong);
            this.grpThongTin.Controls.Add(this.cmbNhanVien);
            this.grpThongTin.Controls.Add(this.lblNhanVien);
            this.grpThongTin.Controls.Add(this.dtpNgayHD);
            this.grpThongTin.Controls.Add(this.lblNgayHD);
            this.grpThongTin.Controls.Add(this.txtMaHD);
            this.grpThongTin.Controls.Add(this.lblMaHD);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpThongTin.Width = 380;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.grpThongTin.Location = new System.Drawing.Point(15, 15);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(380, 470);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.Text = " Thông tin hóa đơn ";

            // MaHD
            this.lblMaHD.Location = new System.Drawing.Point(20, 40); this.lblMaHD.Text = "Mã HĐ:"; this.lblMaHD.AutoSize = true; this.lblMaHD.ForeColor = System.Drawing.Color.Black; this.lblMaHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaHD.Location = new System.Drawing.Point(130, 37); this.txtMaHD.Size = new System.Drawing.Size(220, 25); this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtMaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // NgayHD
            this.lblNgayHD.Location = new System.Drawing.Point(20, 90); this.lblNgayHD.Text = "Ngày lập:"; this.lblNgayHD.AutoSize = true; this.lblNgayHD.ForeColor = System.Drawing.Color.Black; this.lblNgayHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayHD.Location = new System.Drawing.Point(130, 87); this.dtpNgayHD.Size = new System.Drawing.Size(220, 25); this.dtpNgayHD.Font = new System.Drawing.Font("Segoe UI", 10F); this.dtpNgayHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom; this.dtpNgayHD.CustomFormat = "dd/MM/yyyy";

            // NhanVien
            this.lblNhanVien.Location = new System.Drawing.Point(20, 140); this.lblNhanVien.Text = "Nhân viên:"; this.lblNhanVien.AutoSize = true; this.lblNhanVien.ForeColor = System.Drawing.Color.Black; this.lblNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbNhanVien.Location = new System.Drawing.Point(130, 137); this.cmbNhanVien.Size = new System.Drawing.Size(220, 25); this.cmbNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // Phong
            this.lblPhong.Location = new System.Drawing.Point(20, 190); this.lblPhong.Text = "Phòng:"; this.lblPhong.AutoSize = true; this.lblPhong.ForeColor = System.Drawing.Color.Black; this.lblPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPhong.Location = new System.Drawing.Point(130, 187); this.cmbPhong.Size = new System.Drawing.Size(220, 25); this.cmbPhong.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvHoaDon);
            this.grpDanhSach.Controls.Add(this.panelButtons);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Location = new System.Drawing.Point(395, 15);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Padding = new System.Windows.Forms.Padding(10);
            this.grpDanhSach.Size = new System.Drawing.Size(590, 470);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = " Danh sách hóa đơn ";
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));

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
            this.btnThem.Size = new System.Drawing.Size(80, 40);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);


            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(95, 15);
            this.btnSua.Size = new System.Drawing.Size(80, 40);
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);


            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(180, 15);
            this.btnXoa.Size = new System.Drawing.Size(80, 40);
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38))))); // Red
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);


            this.btnLuu.Text = "Lưu";
            this.btnLuu.Location = new System.Drawing.Point(265, 15);
            this.btnLuu.Size = new System.Drawing.Size(80, 40);
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74))))); // Green
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);


            this.btnHuy.Text = "Hủy";
            this.btnHuy.Location = new System.Drawing.Point(350, 15);
            this.btnHuy.Size = new System.Drawing.Size(80, 40);
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.Enabled = false;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Enabled = false;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);


            this.txtTimKiem.Location = new System.Drawing.Point(440, 20);
            this.txtTimKiem.Size = new System.Drawing.Size(120, 30);
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);


            this.btnThoat.Text = "Thoát";
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.Location = new System.Drawing.Point(500, 15);
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);


            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            
            // Header Style
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeight = 45;

            // Row Style
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.RowTemplate.Height = 40;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(10, 80); 
            // Event


            // 
            // FrmHoaDon
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHoaDon";
            this.Text = "QUẢN LÝ HÓA ĐƠN";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
