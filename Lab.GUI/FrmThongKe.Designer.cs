namespace Lab.GUI
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabThongKe;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.TabPage tabTinhTrang;
        private System.Windows.Forms.Panel panelDoanhThuControls;
        private System.Windows.Forms.DateTimePicker dtpThangNam;
        private System.Windows.Forms.Label lblChonThang;
        private System.Windows.Forms.Button btnXemDoanhThu;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Panel panelDoanhThuFooter;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView dgvTinhTrang;
        private System.Windows.Forms.Panel panelTinhTrangControls;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Label lblTongPhong;
        private System.Windows.Forms.Button btnThoat;

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
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabThongKe = new System.Windows.Forms.TabControl();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.panelDoanhThuFooter = new System.Windows.Forms.Panel();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.panelDoanhThuControls = new System.Windows.Forms.Panel();
            this.btnXemDoanhThu = new System.Windows.Forms.Button();
            this.dtpThangNam = new System.Windows.Forms.DateTimePicker();
            this.lblChonThang = new System.Windows.Forms.Label();
            this.tabTinhTrang = new System.Windows.Forms.TabPage();
            this.dgvTinhTrang = new System.Windows.Forms.DataGridView();
            this.panelTinhTrangControls = new System.Windows.Forms.Panel();
            this.lblTongPhong = new System.Windows.Forms.Label();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.panelDoanhThuFooter.SuspendLayout();
            this.panelDoanhThuControls.SuspendLayout();
            this.tabTinhTrang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrang)).BeginInit();
            this.panelTinhTrangControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.panelHeader.Controls.Add(this.btnThoat);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnThoat.Location = new System.Drawing.Point(908, 24);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 30);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO THỐNG KÊ";
            // 
            // tabThongKe
            // 
            this.tabThongKe.Controls.Add(this.tabDoanhThu);
            this.tabThongKe.Controls.Add(this.tabTinhTrang);
            this.tabThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabThongKe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabThongKe.Location = new System.Drawing.Point(0, 80);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.SelectedIndex = 0;
            this.tabThongKe.Size = new System.Drawing.Size(1000, 520);
            this.tabThongKe.TabIndex = 1;
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.dgvDoanhThu);
            this.tabDoanhThu.Controls.Add(this.panelDoanhThuFooter);
            this.tabDoanhThu.Controls.Add(this.panelDoanhThuControls);
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 26);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhThu.Size = new System.Drawing.Size(992, 490);
            this.tabDoanhThu.TabIndex = 0;
            this.tabDoanhThu.Text = "Doanh Thu";
            this.tabDoanhThu.UseVisualStyleBackColor = true;
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.Location = new System.Drawing.Point(3, 53);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.Size = new System.Drawing.Size(986, 394);
            this.dgvDoanhThu.TabIndex = 2;
            // 
            // panelDoanhThuFooter
            // 
            this.panelDoanhThuFooter.Controls.Add(this.lblTongTien);
            this.panelDoanhThuFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDoanhThuFooter.Location = new System.Drawing.Point(3, 447);
            this.panelDoanhThuFooter.Name = "panelDoanhThuFooter";
            this.panelDoanhThuFooter.Size = new System.Drawing.Size(986, 40);
            this.panelDoanhThuFooter.TabIndex = 1;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(20, 10);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(164, 21);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng cộng: 0.00 VNĐ";
            // 
            // panelDoanhThuControls
            // 
            this.panelDoanhThuControls.Controls.Add(this.btnXemDoanhThu);
            this.panelDoanhThuControls.Controls.Add(this.dtpThangNam);
            this.panelDoanhThuControls.Controls.Add(this.lblChonThang);
            this.panelDoanhThuControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDoanhThuControls.Location = new System.Drawing.Point(3, 3);
            this.panelDoanhThuControls.Name = "panelDoanhThuControls";
            this.panelDoanhThuControls.Size = new System.Drawing.Size(986, 50);
            this.panelDoanhThuControls.TabIndex = 0;
            // 
            // btnXemDoanhThu
            // 
            this.btnXemDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnXemDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnXemDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnXemDoanhThu.Location = new System.Drawing.Point(350, 10);
            this.btnXemDoanhThu.Name = "btnXemDoanhThu";
            this.btnXemDoanhThu.Size = new System.Drawing.Size(100, 30);
            this.btnXemDoanhThu.TabIndex = 2;
            this.btnXemDoanhThu.Text = "Thống Kê";
            this.btnXemDoanhThu.UseVisualStyleBackColor = false;
            this.btnXemDoanhThu.Click += new System.EventHandler(this.btnXemDoanhThu_Click);
            // 
            // dtpThangNam
            // 
            this.dtpThangNam.CustomFormat = "MM/yyyy";
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangNam.Location = new System.Drawing.Point(130, 12);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.ShowUpDown = true;
            this.dtpThangNam.Size = new System.Drawing.Size(200, 25);
            this.dtpThangNam.TabIndex = 1;
            // 
            // lblChonThang
            // 
            this.lblChonThang.AutoSize = true;
            this.lblChonThang.Location = new System.Drawing.Point(20, 15);
            this.lblChonThang.Name = "lblChonThang";
            this.lblChonThang.Size = new System.Drawing.Size(86, 19);
            this.lblChonThang.TabIndex = 0;
            this.lblChonThang.Text = "Chọn tháng:";
            // 
            // tabTinhTrang
            // 
            this.tabTinhTrang.Controls.Add(this.dgvTinhTrang);
            this.tabTinhTrang.Controls.Add(this.panelTinhTrangControls);
            this.tabTinhTrang.Location = new System.Drawing.Point(4, 26);
            this.tabTinhTrang.Name = "tabTinhTrang";
            this.tabTinhTrang.Padding = new System.Windows.Forms.Padding(3);
            this.tabTinhTrang.Size = new System.Drawing.Size(992, 490);
            this.tabTinhTrang.TabIndex = 1;
            this.tabTinhTrang.Text = "Tình Trạng Phòng";
            this.tabTinhTrang.UseVisualStyleBackColor = true;
            // 
            // dgvTinhTrang
            // 
            this.dgvTinhTrang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTinhTrang.BackgroundColor = System.Drawing.Color.White;
            this.dgvTinhTrang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinhTrang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTinhTrang.Location = new System.Drawing.Point(3, 53);
            this.dgvTinhTrang.Name = "dgvTinhTrang";
            this.dgvTinhTrang.Size = new System.Drawing.Size(986, 434);
            this.dgvTinhTrang.TabIndex = 1;
            // 
            // panelTinhTrangControls
            // 
            this.panelTinhTrangControls.Controls.Add(this.lblTongPhong);
            this.panelTinhTrangControls.Controls.Add(this.btnTaiLai);
            this.panelTinhTrangControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTinhTrangControls.Location = new System.Drawing.Point(3, 3);
            this.panelTinhTrangControls.Name = "panelTinhTrangControls";
            this.panelTinhTrangControls.Size = new System.Drawing.Size(986, 50);
            this.panelTinhTrangControls.TabIndex = 0;
            // 
            // lblTongPhong
            // 
            this.lblTongPhong.AutoSize = true;
            this.lblTongPhong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTongPhong.Location = new System.Drawing.Point(150, 15);
            this.lblTongPhong.Name = "lblTongPhong";
            this.lblTongPhong.Size = new System.Drawing.Size(0, 19);
            this.lblTongPhong.TabIndex = 1;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnTaiLai.FlatAppearance.BorderSize = 0;
            this.btnTaiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLai.ForeColor = System.Drawing.Color.White;
            this.btnTaiLai.Location = new System.Drawing.Point(20, 10);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(100, 30);
            this.btnTaiLai.TabIndex = 0;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = false;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabThongKe);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabThongKe.ResumeLayout(false);
            this.tabDoanhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.panelDoanhThuFooter.ResumeLayout(false);
            this.panelDoanhThuFooter.PerformLayout();
            this.panelDoanhThuControls.ResumeLayout(false);
            this.panelDoanhThuControls.PerformLayout();
            this.tabTinhTrang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinhTrang)).EndInit();
            this.panelTinhTrangControls.ResumeLayout(false);
            this.panelTinhTrangControls.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
