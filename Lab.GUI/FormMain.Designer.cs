
namespace Lab.GUI
{
    partial class FormMain
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnPhieuDangKy = new System.Windows.Forms.Button();
            this.btnNguoiThan = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnSuDungDichVu = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnLoaiPhong = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnDiemDanh = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelAppName = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelSidebar.Controls.Add(this.btnDangXuat);
            this.panelSidebar.Controls.Add(this.btnTaiKhoan);
            this.panelSidebar.Controls.Add(this.btnPhieuDangKy);
            this.panelSidebar.Controls.Add(this.btnNguoiThan);
            this.panelSidebar.Controls.Add(this.btnNhanVien);
            this.panelSidebar.Controls.Add(this.btnLop);
            this.panelSidebar.Controls.Add(this.btnThongKe);
            this.panelSidebar.Controls.Add(this.btnHoaDon);
            this.panelSidebar.Controls.Add(this.btnSuDungDichVu);
            this.panelSidebar.Controls.Add(this.btnDichVu);
            this.panelSidebar.Controls.Add(this.btnLoaiPhong);
            this.panelSidebar.Controls.Add(this.btnPhong);
            this.panelSidebar.Controls.Add(this.btnDiemDanh);
            this.panelSidebar.Controls.Add(this.btnSinhVien);
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(6);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(480, 1463);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 1376);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(6);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(480, 87);
            this.btnDangXuat.TabIndex = 13;
            this.btnDangXuat.Text = "🚪 Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 1285);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(6);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(480, 87);
            this.btnTaiKhoan.TabIndex = 12;
            this.btnTaiKhoan.Text = "🔑 Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnPhieuDangKy
            // 
            this.btnPhieuDangKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhieuDangKy.FlatAppearance.BorderSize = 0;
            this.btnPhieuDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuDangKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPhieuDangKy.ForeColor = System.Drawing.Color.White;
            this.btnPhieuDangKy.Location = new System.Drawing.Point(0, 1198);
            this.btnPhieuDangKy.Margin = new System.Windows.Forms.Padding(6);
            this.btnPhieuDangKy.Name = "btnPhieuDangKy";
            this.btnPhieuDangKy.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPhieuDangKy.Size = new System.Drawing.Size(480, 87);
            this.btnPhieuDangKy.TabIndex = 11;
            this.btnPhieuDangKy.Text = "📝 Phiếu đăng ký";
            this.btnPhieuDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuDangKy.UseVisualStyleBackColor = true;
            this.btnPhieuDangKy.Click += new System.EventHandler(this.btnPhieuDangKy_Click);
            // 
            // btnNguoiThan
            // 
            this.btnNguoiThan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNguoiThan.FlatAppearance.BorderSize = 0;
            this.btnNguoiThan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNguoiThan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNguoiThan.ForeColor = System.Drawing.Color.White;
            this.btnNguoiThan.Location = new System.Drawing.Point(0, 1111);
            this.btnNguoiThan.Margin = new System.Windows.Forms.Padding(6);
            this.btnNguoiThan.Name = "btnNguoiThan";
            this.btnNguoiThan.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnNguoiThan.Size = new System.Drawing.Size(480, 87);
            this.btnNguoiThan.TabIndex = 10;
            this.btnNguoiThan.Text = "👪 Người thân";
            this.btnNguoiThan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNguoiThan.UseVisualStyleBackColor = true;
            this.btnNguoiThan.Click += new System.EventHandler(this.btnNguoiThan_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 1024);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(6);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(480, 87);
            this.btnNhanVien.TabIndex = 9;
            this.btnNhanVien.Text = "👔 Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnLop
            // 
            this.btnLop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLop.FlatAppearance.BorderSize = 0;
            this.btnLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLop.ForeColor = System.Drawing.Color.White;
            this.btnLop.Location = new System.Drawing.Point(0, 937);
            this.btnLop.Margin = new System.Windows.Forms.Padding(6);
            this.btnLop.Name = "btnLop";
            this.btnLop.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnLop.Size = new System.Drawing.Size(480, 87);
            this.btnLop.TabIndex = 8;
            this.btnLop.Text = "🏫 Lớp";
            this.btnLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(0, 850);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(480, 87);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "📊 Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 763);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(6);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(480, 87);
            this.btnHoaDon.TabIndex = 7;
            this.btnHoaDon.Text = "💰 Hóa đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnSuDungDichVu
            // 
            this.btnSuDungDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSuDungDichVu.FlatAppearance.BorderSize = 0;
            this.btnSuDungDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuDungDichVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSuDungDichVu.ForeColor = System.Drawing.Color.White;
            this.btnSuDungDichVu.Location = new System.Drawing.Point(0, 676);
            this.btnSuDungDichVu.Margin = new System.Windows.Forms.Padding(6);
            this.btnSuDungDichVu.Name = "btnSuDungDichVu";
            this.btnSuDungDichVu.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSuDungDichVu.Size = new System.Drawing.Size(480, 87);
            this.btnSuDungDichVu.TabIndex = 6;
            this.btnSuDungDichVu.Text = "🔌 Sử dụng dịch vụ";
            this.btnSuDungDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuDungDichVu.UseVisualStyleBackColor = true;
            this.btnSuDungDichVu.Click += new System.EventHandler(this.btnSuDungDichVu_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDichVu.FlatAppearance.BorderSize = 0;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDichVu.ForeColor = System.Drawing.Color.White;
            this.btnDichVu.Location = new System.Drawing.Point(0, 589);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(6);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDichVu.Size = new System.Drawing.Size(480, 87);
            this.btnDichVu.TabIndex = 5;
            this.btnDichVu.Text = "🛠 Dịch vụ";
            this.btnDichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnLoaiPhong
            // 
            this.btnLoaiPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoaiPhong.FlatAppearance.BorderSize = 0;
            this.btnLoaiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.btnLoaiPhong.Location = new System.Drawing.Point(0, 502);
            this.btnLoaiPhong.Margin = new System.Windows.Forms.Padding(6);
            this.btnLoaiPhong.Name = "btnLoaiPhong";
            this.btnLoaiPhong.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnLoaiPhong.Size = new System.Drawing.Size(480, 87);
            this.btnLoaiPhong.TabIndex = 4;
            this.btnLoaiPhong.Text = "🏷 Loại phòng";
            this.btnLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoaiPhong.UseVisualStyleBackColor = true;
            this.btnLoaiPhong.Click += new System.EventHandler(this.btnLoaiPhong_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhong.FlatAppearance.BorderSize = 0;
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPhong.ForeColor = System.Drawing.Color.White;
            this.btnPhong.Location = new System.Drawing.Point(0, 415);
            this.btnPhong.Margin = new System.Windows.Forms.Padding(6);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPhong.Size = new System.Drawing.Size(480, 87);
            this.btnPhong.TabIndex = 3;
            this.btnPhong.Text = "🏢 Phòng";
            this.btnPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnDiemDanh
            // 
            this.btnDiemDanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiemDanh.FlatAppearance.BorderSize = 0;
            this.btnDiemDanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiemDanh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDiemDanh.ForeColor = System.Drawing.Color.White;
            this.btnDiemDanh.Location = new System.Drawing.Point(0, 328);
            this.btnDiemDanh.Margin = new System.Windows.Forms.Padding(6);
            this.btnDiemDanh.Name = "btnDiemDanh";
            this.btnDiemDanh.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDiemDanh.Size = new System.Drawing.Size(480, 87);
            this.btnDiemDanh.TabIndex = 20;
            this.btnDiemDanh.Text = "📅 Điểm danh";
            this.btnDiemDanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiemDanh.UseVisualStyleBackColor = true;
            this.btnDiemDanh.Click += new System.EventHandler(this.btnDiemDanh_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSinhVien.FlatAppearance.BorderSize = 0;
            this.btnSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSinhVien.ForeColor = System.Drawing.Color.White;
            this.btnSinhVien.Location = new System.Drawing.Point(0, 241);
            this.btnSinhVien.Margin = new System.Windows.Forms.Padding(6);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSinhVien.Size = new System.Drawing.Size(480, 87);
            this.btnSinhVien.TabIndex = 2;
            this.btnSinhVien.Text = "👨‍🎓 Sinh viên";
            this.btnSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 154);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(6);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(480, 87);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "🏠 Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelAppName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(6);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(480, 154);
            this.panelLogo.TabIndex = 0;
            // 
            // labelAppName
            // 
            this.labelAppName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAppName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelAppName.ForeColor = System.Drawing.Color.White;
            this.labelAppName.Location = new System.Drawing.Point(0, 0);
            this.labelAppName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(480, 154);
            this.labelAppName.TabIndex = 0;
            this.labelAppName.Text = "QL KTX";
            this.labelAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblUser);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(480, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(6);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1888, 115);
            this.panelHeader.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUser.Location = new System.Drawing.Point(1638, 0);
            this.lblUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Padding = new System.Windows.Forms.Padding(0, 38, 40, 0);
            this.lblUser.Size = new System.Drawing.Size(250, 75);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Xin chào: Admin";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(40, 35);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DASHBOARD";
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(480, 115);
            this.panelBody.Margin = new System.Windows.Forms.Padding(6);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1888, 1348);
            this.panelBody.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2368, 1463);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ KÝ TÚC XÁ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelSidebar.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Button btnDiemDanh;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnLoaiPhong;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnSuDungDichVu;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnNguoiThan;
        private System.Windows.Forms.Button btnPhieuDangKy;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
    }
}
