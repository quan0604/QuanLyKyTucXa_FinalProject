
namespace Lab.GUI
{
    partial class FrmSinhVien
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelLeft; // For Info
        private System.Windows.Forms.Panel panelFill; // For Grid
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.Panel panelButtons;

        // Custom Layout Controls
        // Using Panels for grouping
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.PictureBox picAvatar; // Logic code didn't use this but Designer did? No, logic uses txtAnhChanDung string path maybe? 
        // Logic check: txtAnhChanDung exists in old Designer. Reference code line 26.
        // I will keep txtAnhChanDung but maybe hide it or put it near avatar.
        
        // Controls from analysis
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.DateTimePicker dtpNgSinh;
        private System.Windows.Forms.ComboBox cmbPhai; // Was ComboBox in old designer
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtDienSV;
        private System.Windows.Forms.TextBox txtBHYT;
        private System.Windows.Forms.TextBox txtAnhChanDung;
        
        // Labels
        private System.Windows.Forms.Label label1; // MSSV
        private System.Windows.Forms.Label label2; // HoTen
        private System.Windows.Forms.Label label3; // Lop
        private System.Windows.Forms.Label label4; // Phai
        private System.Windows.Forms.Label label5; // NgSinh
        private System.Windows.Forms.Label label6; // CMND
        private System.Windows.Forms.Label label7; // SDT
        private System.Windows.Forms.Label label8; // Email
        private System.Windows.Forms.Label label9; // QueQuan
        private System.Windows.Forms.Label label10; // DienSV
        private System.Windows.Forms.Label label11; // BHYT
        private System.Windows.Forms.Label label12; // Anh

        // Buttons
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;

        // Grid
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.GroupBox grpTimKiem; // Logic uses this container? Maybe not strictly required but good to keep structure or map controls directly.

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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.panelFill = new System.Windows.Forms.Panel();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            
            // Init Controls
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.dtpNgSinh = new System.Windows.Forms.DateTimePicker();
            this.cmbPhai = new System.Windows.Forms.ComboBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtDienSV = new System.Windows.Forms.TextBox();
            this.txtBHYT = new System.Windows.Forms.TextBox();
            this.txtAnhChanDung = new System.Windows.Forms.TextBox();
            
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button(); // Not used in new layout usually, but keep for compat
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();

            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelHeader
            // 
            // Theme: INDIGO (#4f46e5)
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.panelHeader.Controls.Add(this.lblSubTitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 80); // Wider form
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            //this.lblTitle.Size = new System.Drawing.Size(315, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỒ SƠ SINH VIÊN";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255))))); // Light Indigo
            this.lblSubTitle.Location = new System.Drawing.Point(30, 55);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Quản lý thông tin chi tiết sinh viên, lớp học và nội trú";

            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelFill);
            this.panelBody.Controls.Add(this.panelLeft);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 80);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1100, 620);
            this.panelBody.TabIndex = 1;

            // 
            // panelLeft (Info Section - Fixed width left)
            // 
            this.panelLeft.Controls.Add(this.grpThongTin);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10);
            this.panelLeft.Width = 350;
            this.panelLeft.BackColor = System.Drawing.Color.White;
            
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.txtAnhChanDung);
            this.grpThongTin.Controls.Add(this.label12);
            this.grpThongTin.Controls.Add(this.txtBHYT);
            this.grpThongTin.Controls.Add(this.label11);
            this.grpThongTin.Controls.Add(this.txtDienSV);
            this.grpThongTin.Controls.Add(this.label10);
            this.grpThongTin.Controls.Add(this.txtQueQuan);
            this.grpThongTin.Controls.Add(this.label9);
            this.grpThongTin.Controls.Add(this.txtEmail);
            this.grpThongTin.Controls.Add(this.label8);
            this.grpThongTin.Controls.Add(this.txtSDT);
            this.grpThongTin.Controls.Add(this.label7);
            this.grpThongTin.Controls.Add(this.txtCMND);
            this.grpThongTin.Controls.Add(this.label6);
            this.grpThongTin.Controls.Add(this.dtpNgSinh);
            this.grpThongTin.Controls.Add(this.label5);
            this.grpThongTin.Controls.Add(this.cmbPhai);
            this.grpThongTin.Controls.Add(this.label4);
            this.grpThongTin.Controls.Add(this.cmbLop);
            this.grpThongTin.Controls.Add(this.label3);
            this.grpThongTin.Controls.Add(this.txtHoTen);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.txtMSSV);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.grpThongTin.Location = new System.Drawing.Point(10, 10);
            this.grpThongTin.Text = "Thông tin cá nhân";
            
            // Helper for Textbox Styles
            // MSSV
            this.label1.AutoSize = true; this.label1.Location = new System.Drawing.Point(15, 30); this.label1.Text = "MSSV:";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F); this.label1.ForeColor = System.Drawing.Color.Black;
            this.txtMSSV.Location = new System.Drawing.Point(100, 27); this.txtMSSV.Size = new System.Drawing.Size(220, 25);
            this.txtMSSV.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtMSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            
            // Hoten
            this.label2.AutoSize = true; this.label2.Location = new System.Drawing.Point(15, 70); this.label2.Text = "Họ tên:";
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F); this.label2.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.Location = new System.Drawing.Point(100, 67); this.txtHoTen.Size = new System.Drawing.Size(220, 25);
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            
            // Lop
            this.label3.AutoSize = true; this.label3.Location = new System.Drawing.Point(15, 110); this.label3.Text = "Lớp:";
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F); this.label3.ForeColor = System.Drawing.Color.Black;
            this.cmbLop.Location = new System.Drawing.Point(100, 107); this.cmbLop.Size = new System.Drawing.Size(220, 25);
            this.cmbLop.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.cmbLop.BackColor = System.Drawing.Color.WhiteSmoke;
            
            // Phai
            this.label4.AutoSize = true; this.label4.Location = new System.Drawing.Point(15, 150); this.label4.Text = "Phái:";
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F); this.label4.ForeColor = System.Drawing.Color.Black;
            this.cmbPhai.Location = new System.Drawing.Point(100, 147); this.cmbPhai.Size = new System.Drawing.Size(220, 25);
            this.cmbPhai.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbPhai.Items.AddRange(new object[] { "Nam", "Nữ" }); this.cmbPhai.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.cmbPhai.BackColor = System.Drawing.Color.WhiteSmoke;
            
            // NgSinh
            this.label5.AutoSize = true; this.label5.Location = new System.Drawing.Point(15, 190); this.label5.Text = "Ngày sinh:";
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F); this.label5.ForeColor = System.Drawing.Color.Black;
            this.dtpNgSinh.Location = new System.Drawing.Point(100, 187); this.dtpNgSinh.Size = new System.Drawing.Size(220, 25);
            this.dtpNgSinh.Font = new System.Drawing.Font("Segoe UI", 10F); this.dtpNgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // CMND
            this.label6.AutoSize = true; this.label6.Location = new System.Drawing.Point(15, 230); this.label6.Text = "CMND:";
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F); this.label6.ForeColor = System.Drawing.Color.Black;
            this.txtCMND.Location = new System.Drawing.Point(100, 227); this.txtCMND.Size = new System.Drawing.Size(220, 25);
            this.txtCMND.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtCMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // SDT
            this.label7.AutoSize = true; this.label7.Location = new System.Drawing.Point(15, 270); this.label7.Text = "SĐT:";
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F); this.label7.ForeColor = System.Drawing.Color.Black;
            this.txtSDT.Location = new System.Drawing.Point(100, 267); this.txtSDT.Size = new System.Drawing.Size(220, 25);
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Email
            this.label8.AutoSize = true; this.label8.Location = new System.Drawing.Point(15, 310); this.label8.Text = "Email:";
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F); this.label8.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(100, 307); this.txtEmail.Size = new System.Drawing.Size(220, 25);
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // QueQuan
            this.label9.AutoSize = true; this.label9.Location = new System.Drawing.Point(15, 350); this.label9.Text = "Quê quán:";
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F); this.label9.ForeColor = System.Drawing.Color.Black;
            this.txtQueQuan.Location = new System.Drawing.Point(100, 347); this.txtQueQuan.Size = new System.Drawing.Size(220, 25);
            this.txtQueQuan.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtQueQuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // DienSV
            this.label10.AutoSize = true; this.label10.Location = new System.Drawing.Point(15, 390); this.label10.Text = "Diện SV:";
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F); this.label10.ForeColor = System.Drawing.Color.Black;
            this.txtDienSV.Location = new System.Drawing.Point(100, 387); this.txtDienSV.Size = new System.Drawing.Size(220, 25);
            this.txtDienSV.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtDienSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // BHYT
            this.label11.AutoSize = true; this.label11.Location = new System.Drawing.Point(15, 430); this.label11.Text = "BHYT:";
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F); this.label11.ForeColor = System.Drawing.Color.Black;
            this.txtBHYT.Location = new System.Drawing.Point(100, 427); this.txtBHYT.Size = new System.Drawing.Size(220, 25);
            this.txtBHYT.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtBHYT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // AnhChanDung (Text path)
            this.label12.AutoSize = true; this.label12.Location = new System.Drawing.Point(15, 470); this.label12.Text = "Ảnh:";
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F); this.label12.ForeColor = System.Drawing.Color.Black;
            this.txtAnhChanDung.Location = new System.Drawing.Point(100, 467); this.txtAnhChanDung.Size = new System.Drawing.Size(220, 25);
            this.txtAnhChanDung.Font = new System.Drawing.Font("Segoe UI", 10F); this.txtAnhChanDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // panelFill (List & Action Section - Right side)
            // 
            this.panelFill.Controls.Add(this.grpDanhSach);
            this.panelFill.Controls.Add(this.panelButtons);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Padding = new System.Windows.Forms.Padding(10);
            this.panelFill.BackColor = System.Drawing.Color.WhiteSmoke;

            // 
            // panelButtons
            // 
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Height = 60;
            this.panelButtons.BackColor = System.Drawing.Color.White;
            this.panelButtons.Controls.Add(this.txtTimKiem); // Search in toolbar now
            //this.panelButtons.Controls.Add(this.lblTimKiem);
            this.panelButtons.Controls.Add(this.btnThoat);
            this.panelButtons.Controls.Add(this.btnHuy);
            this.panelButtons.Controls.Add(this.btnLuu);
            this.panelButtons.Controls.Add(this.btnXoa);
            this.panelButtons.Controls.Add(this.btnSua);
            this.panelButtons.Controls.Add(this.btnThem);
            // btnThem
            this.btnThem.Location = new System.Drawing.Point(10, 10);
            this.btnThem.Size = new System.Drawing.Size(80, 35);
            this.btnThem.Text = "Thêm";
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // btnSua
            this.btnSua.Location = new System.Drawing.Point(100, 10);
            this.btnSua.Size = new System.Drawing.Size(80, 35);
            this.btnSua.Text = "Sửa";
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(190, 10);
            this.btnXoa.Size = new System.Drawing.Size(80, 35);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // btnLuu
            this.btnLuu.Location = new System.Drawing.Point(280, 10);
            this.btnLuu.Size = new System.Drawing.Size(80, 35);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Enabled = false;

            // btnHuy
            this.btnHuy.Location = new System.Drawing.Point(370, 10);
            this.btnHuy.Size = new System.Drawing.Size(80, 35);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Enabled = false;

            // Search (Right aligned nearby)
            this.txtTimKiem.Location = new System.Drawing.Point(470, 15);
            this.txtTimKiem.Size = new System.Drawing.Size(200, 25);
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // Placeholder can be done via events later if needed
            
            // btnThoat
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.Location = new System.Drawing.Point(650, 10); // Adjust based on parent size, let's use Anchor
            this.btnThoat.Size = new System.Drawing.Size(80, 35);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Left = this.panelButtons.Width - 100; // Will adjust on resize due to Anchor
            
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvSinhVien);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Location = new System.Drawing.Point(10, 70);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(730, 540);
            this.grpDanhSach.TabIndex = 2;
            this.grpDanhSach.Text = "Danh sách sinh viên";
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSinhVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSinhVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSinhVien.EnableHeadersVisualStyles = false;
            
            // Style Grid
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229))))); // Match Header
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSinhVien.ColumnHeadersHeight = 40;
            
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255))))); // Light Indigo selection
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSinhVien.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSinhVien.RowTemplate.Height = 35;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.RowHeadersVisible = false;

            // Form
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Name = "FrmSinhVien";
            this.Text = "HỒ SƠ SINH VIÊN";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.panelFill.ResumeLayout(false);
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
