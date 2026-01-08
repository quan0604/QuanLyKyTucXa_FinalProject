
using System;
using System.Drawing;
using System.Windows.Forms;
using Lab.BUS;

namespace Lab.GUI
{
    public partial class FormDangNhap : Form
    {
        private DangNhapService _service = new DangNhapService();

        public FormDangNhap()
        {
            InitializeComponent();
            LoadLogo();
        }

        private void LoadLogo()
        {
            try
            {
                // Load the Branding Image (Hero) instead of the small logo
                string logoPath = System.IO.Path.Combine(Application.StartupPath, "Images", "unidorms_hero.png");
                if (System.IO.File.Exists(logoPath))
                {
                    pictureBoxLogo.Image = Image.FromFile(logoPath);
                    // Adjust PictureBox to fill the left panel
                    pictureBoxLogo.Dock = DockStyle.Fill;
                    pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    
                    // Hide the text label since the image has the text 'UNI DORMS'
                    lblWelcome.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not load logo: " + ex.Message);
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var nv = _service.KiemTraDangNhap(userName, password);
                if (nv != null)
                {
                    // Đăng nhập thành công
                    LoggedInEmployee = nv;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình xử lý: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DAL.Entities.NHANVIEN LoggedInEmployee { get; private set; }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
