
namespace Lab.GUI
{
    partial class FrmDiemDanh
    {
        private System.ComponentModel.IContainer components = null;
        
        // Layout Controls
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelFill;
        
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TabControl tabControl; // NEW: Replaced grpDanhSach
        private System.Windows.Forms.TabPage tabDanhSach;
        private System.Windows.Forms.TabPage tabKiosk;
        
        // Input Controls (Left)
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ComboBox cmbPhong;
        private System.Windows.Forms.Button btnXem;
        
        // Tab 1: List Controls
        private System.Windows.Forms.DataGridView dgvDiemDanh;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;

        // Tab 2: QR Controls
        private System.Windows.Forms.Label lblQRCode; // Text version of Code
        private System.Windows.Forms.Button btnTaoMa;
        private System.Windows.Forms.TextBox txtInputMSSV;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.ListBox lstLog; 
        private System.Windows.Forms.Label lblLogTitle;
        
        // Timer
        private System.Windows.Forms.Timer timerSession;
        private System.Windows.Forms.Label lblTimer;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.panelFill = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDanhSach = new System.Windows.Forms.TabPage();
            this.tabKiosk = new System.Windows.Forms.TabPage();
            
            this.dgvDiemDanh = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cmbPhong = new System.Windows.Forms.ComboBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            // QR Controls init
            this.btnTaoMa = new System.Windows.Forms.Button();
            this.lblQRCode = new System.Windows.Forms.Label();
            this.txtInputMSSV = new System.Windows.Forms.TextBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.lblLogTitle = new System.Windows.Forms.Label();
            
            this.timerSession = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();

            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabDanhSach.SuspendLayout();
            this.tabKiosk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDanh)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199))))); // Sky Blue
            this.panelHeader.Controls.Add(this.lblSubTitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 100;
            this.panelHeader.TabIndex = 0;
            
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Text = "ĐIỂM DANH";
            
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.lblSubTitle.Location = new System.Drawing.Point(40, 65);
            this.lblSubTitle.Text = "Quản lý điểm danh sinh viên nội trú theo ngày";

            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.panelFill);
            this.panelBody.Controls.Add(this.panelLeft);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 100);
            this.panelBody.Padding = new System.Windows.Forms.Padding(15);
            this.panelBody.TabIndex = 1;

            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.grpThongTin);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Width = 320;
            this.panelLeft.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0); // Right padding
            
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.btnXem);
            this.grpThongTin.Controls.Add(this.cmbPhong);
            this.grpThongTin.Controls.Add(this.lblPhong);
            this.grpThongTin.Controls.Add(this.dtpNgay);
            this.grpThongTin.Controls.Add(this.lblNgay);
            this.grpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.grpThongTin.Text = " Thông tin chọn ";
            
            // Controls (Left Panel)
            this.lblNgay.Location = new System.Drawing.Point(20, 40); this.lblNgay.Text = "Ngày:"; this.lblNgay.AutoSize = true; this.lblNgay.ForeColor = System.Drawing.Color.Black; this.lblNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgay.Location = new System.Drawing.Point(100, 37); this.dtpNgay.Size = new System.Drawing.Size(200, 25); this.dtpNgay.Font = new System.Drawing.Font("Segoe UI", 10F); this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // startY += step;
            this.lblPhong.Location = new System.Drawing.Point(20, 90); this.lblPhong.Text = "Phòng:"; this.lblPhong.AutoSize = true; this.lblPhong.ForeColor = System.Drawing.Color.Black; this.lblPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPhong.Location = new System.Drawing.Point(100, 87); this.cmbPhong.Size = new System.Drawing.Size(200, 25); this.cmbPhong.Font = new System.Drawing.Font("Segoe UI", 10F); this.cmbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; this.cmbPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // startY += step + 10;
            this.btnXem.Text = "Xem Danh Sách";
            this.btnXem.Location = new System.Drawing.Point(100, 150);
            this.btnXem.Size = new System.Drawing.Size(200, 40);
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.tabControl);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDanhSach);
            this.tabControl.Controls.Add(this.tabKiosk);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            
            // 
            // tabDanhSach
            // 
            this.tabDanhSach.Controls.Add(this.dgvDiemDanh);
            this.tabDanhSach.Controls.Add(this.panelButtons);
            this.tabDanhSach.Text = "Danh sách điểm danh";
            this.tabDanhSach.Padding = new System.Windows.Forms.Padding(3);
            
            // panelButtons (Inside Tab 1)
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Height = 60;
            this.panelButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelButtons.Controls.Add(this.btnLuu);
            this.panelButtons.Controls.Add(this.btnThoat);
            
            this.btnLuu.Text = "Lưu Lại";
            this.btnLuu.Location = new System.Drawing.Point(10, 10);
            this.btnLuu.Size = new System.Drawing.Size(120, 40);
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74))))); // Green
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.Location = new System.Drawing.Point(500, 10); // Adjust dynamically
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat; this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // dgvDiemDanh
            this.dgvDiemDanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiemDanh.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiemDanh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiemDanh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDiemDanh.EnableHeadersVisualStyles = false;
            
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiemDanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiemDanh.ColumnHeadersHeight = 40;
            
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDiemDanh.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiemDanh.RowTemplate.Height = 35;
            this.dgvDiemDanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // tabKiosk (QR Mode)
            // 
            this.tabKiosk.Text = "Quét Thẻ / Nhập Mã";
            this.tabKiosk.Padding = new System.Windows.Forms.Padding(10);
            this.tabKiosk.Controls.Add(this.lstLog);
            this.tabKiosk.Controls.Add(this.lblLogTitle);
            this.tabKiosk.Controls.Add(this.txtInputMSSV);
            this.tabKiosk.Controls.Add(this.lblInstruction);
            this.tabKiosk.Controls.Add(this.lblQRCode);
            this.tabKiosk.Controls.Add(this.lblTimer); // Add Label
            this.tabKiosk.Controls.Add(this.btnTaoMa);

            // btnTaoMa
            this.btnTaoMa.Text = "TẠO PHIÊN ĐIỂM DANH";
            this.btnTaoMa.Location = new System.Drawing.Point(30, 30);
            this.btnTaoMa.Size = new System.Drawing.Size(250, 50);
            this.btnTaoMa.BackColor = System.Drawing.Color.OrangeRed;
            this.btnTaoMa.ForeColor = System.Drawing.Color.White;
            this.btnTaoMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoMa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);

            // lblQRCode (Big Text)
            this.lblQRCode.Text = "MÃ SỐ: ----";
            this.lblQRCode.Location = new System.Drawing.Point(30, 100);
            this.lblQRCode.Size = new System.Drawing.Size(400, 100);
            this.lblQRCode.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblQRCode.ForeColor = System.Drawing.Color.Navy;
            this.lblQRCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblTimer
            this.lblTimer.Text = "Thời gian còn lại: --";
            this.lblTimer.Location = new System.Drawing.Point(30, 85); // Right below/near button
            this.lblTimer.Size = new System.Drawing.Size(250, 25);
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.Red;

            // lblInstruction
            this.lblInstruction.Text = "Quét thẻ hoặc nhập MSSV vào ô bên dưới:";
            this.lblInstruction.Location = new System.Drawing.Point(30, 220);
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);

            // txtInputMSSV
            this.txtInputMSSV.Location = new System.Drawing.Point(30, 250);
            this.txtInputMSSV.Size = new System.Drawing.Size(400, 50);
            this.txtInputMSSV.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.txtInputMSSV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInputMSSV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;

            // Log Section
            this.lblLogTitle.Text = "Lịch sử quét trong phiên này:";
            this.lblLogTitle.Location = new System.Drawing.Point(450, 30);
            this.lblLogTitle.AutoSize = true;

            this.lstLog.Location = new System.Drawing.Point(450, 60);
            this.lstLog.Size = new System.Drawing.Size(200, 350);
            this.lstLog.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstLog.Dock = System.Windows.Forms.DockStyle.Right; // Fill right side

            // 
            // FrmDiemDanh
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Text = "ĐIỂM DANH SINH VIÊN";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.panelFill.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabDanhSach.ResumeLayout(false);
            this.tabKiosk.ResumeLayout(false);
            this.tabKiosk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDanh)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
