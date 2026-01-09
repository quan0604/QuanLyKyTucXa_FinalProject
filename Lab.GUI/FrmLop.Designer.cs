
namespace Lab.GUI
{
    partial class FrmLop
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
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        
        private System.Windows.Forms.Label lblKhoaHoc;
        private System.Windows.Forms.TextBox txtKhoaHoc;
        
        private System.Windows.Forms.Label lblKhoaQL;
        private System.Windows.Forms.TextBox txtKhoaQL;
        
        private System.Windows.Forms.Label lblNganh;
        private System.Windows.Forms.TextBox txtNganh;
        
        private System.Windows.Forms.Label lblSiSo;
        private System.Windows.Forms.NumericUpDown numSiSo;

        // Buttons
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTimKiem;

        // Grid
        private System.Windows.Forms.DataGridView dgvLop;

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
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();

            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblKhoaHoc = new System.Windows.Forms.Label();
            this.txtKhoaHoc = new System.Windows.Forms.TextBox();
            this.lblKhoaQL = new System.Windows.Forms.Label();
            this.txtKhoaQL = new System.Windows.Forms.TextBox();
            this.lblNganh = new System.Windows.Forms.Label();
            this.txtNganh = new System.Windows.Forms.TextBox();
            this.lblSiSo = new System.Windows.Forms.Label();
            this.numSiSo = new System.Windows.Forms.NumericUpDown();

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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSiSo)).BeginInit();
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
            this.lblTitle.Text = "QUẢN LÝ LỚP HỌC";

            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254))))); // Light Sky Blue
            this.lblSubTitle.Location = new System.Drawing.Point(40, 65);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Text = "Quản lý thông tin lớp, khoa và ngành học";

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
            this.grpThongTin.Controls.Add(this.numSiSo);
            this.grpThongTin.Controls.Add(this.lblSiSo);
            this.grpThongTin.Controls.Add(this.txtNganh);
            this.grpThongTin.Controls.Add(this.lblNganh);
            this.grpThongTin.Controls.Add(this.txtKhoaQL);
            this.grpThongTin.Controls.Add(this.lblKhoaQL);
            this.grpThongTin.Controls.Add(this.txtKhoaHoc);
            this.grpThongTin.Controls.Add(this.lblKhoaHoc);
            this.grpThongTin.Controls.Add(this.txtMaLop);
            this.grpThongTin.Controls.Add(this.lblMaLop);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpThongTin.Width = 380;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.grpThongTin.Location = new System.Drawing.Point(15, 15);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(380, 570);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.Text = " Thông tin lớp ";

            // int lblX = 20, ctrlX = 130, startY = 35, step = 50; // REMOVED

            // MaLop
            this.lblMaLop.Location = new System.Drawing.Point(20, 35); this.lblMaLop.Text = "Mã Lớp:"; this.lblMaLop.AutoSize = true; this.lblMaLop.ForeColor = System.Drawing.Color.Black; this.lblMaLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaLop.Location = new System.Drawing.Point(130, 32); this.txtMaLop.Size = new System.Drawing.Size(220, 25); this.txtMaLop.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtMaLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // KhoaHoc
            this.lblKhoaHoc.Location = new System.Drawing.Point(20, 85); this.lblKhoaHoc.Text = "Khóa Học:"; this.lblKhoaHoc.AutoSize = true; this.lblKhoaHoc.ForeColor = System.Drawing.Color.Black; this.lblKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKhoaHoc.Location = new System.Drawing.Point(130, 82); this.txtKhoaHoc.Size = new System.Drawing.Size(220, 25); this.txtKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtKhoaHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // KhoaQL
            this.lblKhoaQL.Location = new System.Drawing.Point(20, 135); this.lblKhoaQL.Text = "Khoa QL:"; this.lblKhoaQL.AutoSize = true; this.lblKhoaQL.ForeColor = System.Drawing.Color.Black; this.lblKhoaQL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKhoaQL.Location = new System.Drawing.Point(130, 132); this.txtKhoaQL.Size = new System.Drawing.Size(220, 25); this.txtKhoaQL.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtKhoaQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Nganh
            this.lblNganh.Location = new System.Drawing.Point(20, 185); this.lblNganh.Text = "Ngành:"; this.lblNganh.AutoSize = true; this.lblNganh.ForeColor = System.Drawing.Color.Black; this.lblNganh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNganh.Location = new System.Drawing.Point(130, 182); this.txtNganh.Size = new System.Drawing.Size(220, 25); this.txtNganh.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtNganh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // SiSo
            this.lblSiSo.Location = new System.Drawing.Point(20, 235); this.lblSiSo.Text = "Sĩ Số:"; this.lblSiSo.AutoSize = true; this.lblSiSo.ForeColor = System.Drawing.Color.Black; this.lblSiSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSiSo.Location = new System.Drawing.Point(130, 232); this.numSiSo.Size = new System.Drawing.Size(100, 25); this.numSiSo.Font = new System.Drawing.Font("Segoe UI", 10F); this.numSiSo.Maximum = 1000;

            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvLop);
            this.grpDanhSach.Controls.Add(this.panelButtons);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Location = new System.Drawing.Point(395, 15);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Padding = new System.Windows.Forms.Padding(10);
            this.grpDanhSach.Size = new System.Drawing.Size(690, 570);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = " Danh sách lớp ";
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
            this.btnThem.Size = new System.Drawing.Size(85, 40);
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new System.Drawing.Point(105, 15);
            this.btnSua.Size = new System.Drawing.Size(85, 40);
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
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
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74))))); // Green
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
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // 
            // dgvLop
            // 
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLop.BackgroundColor = System.Drawing.Color.White;
            this.dgvLop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLop.EnableHeadersVisualStyles = false;
            
            // Header Style
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLop.ColumnHeadersHeight = 45;

            // Row Style
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLop.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLop.RowTemplate.Height = 40;
            this.dgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.RowHeadersVisible = false;
            this.dgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.Location = new System.Drawing.Point(10, 80); 
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);

            // 
            // FrmLop
            // 
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLop";
            this.Text = "QUẢN LÝ LỚP HỌC";
            this.Load += new System.EventHandler(this.FrmLop_Load);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSiSo)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
