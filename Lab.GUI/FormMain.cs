
using System;
using System.Drawing;
using System.Windows.Forms;
using Lab.DAL.Entities;

namespace Lab.GUI
{
    public partial class FormMain : Form
    {
        private Form activeForm = null;
        private Button currentButton = null;

        public FormMain()
        {
            InitializeComponent();
            ShowDashboard(); // Show dashboard on startup
        }

        public FormMain(NHANVIEN nv) : this()
        {
            if (nv != null)
                lblUser.Text = $"Xin chào: {nv.HoTen ?? "Người dùng"}";
        }

        // ================= HELPER METHODS =================
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(45, 55, 72); // Active color (lighter)
                    currentButton.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelSidebar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(30, 41, 59); // Default color
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
            lblTitle.Text = childForm.Text.ToUpper();
        }

        // ================= EVENTS =================
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            ActivateButton(sender);
            ShowDashboard();
        }

        private void ShowDashboard()
        {
            panelBody.Controls.Clear();
            
            // Simple Dashboard Placeholder
            Label lbl = new Label();
            lbl.Text = "Chào mừng đến với Hệ thống Quản lý Ký túc xá";
            lbl.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lbl.ForeColor = Color.Gray;
            lbl.AutoSize = false;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            
            panelBody.Controls.Add(lbl);
            lblTitle.Text = "DASHBOARD";
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSinhVien(), sender);
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDiemDanh(), sender);
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPhong(), sender);
        }

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLoaiPhong(), sender);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDichVu(), sender);
        }

        private void btnSuDungDichVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSuDungDichVu(), sender);
        }


        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHoaDon(), sender);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThongKe(), sender);
        }


        private void btnLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLop(), sender);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNhanVien(), sender);
        }

        private void btnNguoiThan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNguoiThan(), sender);
        }

        private void btnPhieuDangKy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPhieuDangKy(), sender);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTaiKhoan(), sender);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK; // Signal Logout
                this.Close();
            }
        }
    }
}
