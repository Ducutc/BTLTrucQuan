using CoffeeHouseABC.Models;
using CoffeeHouseABC.User_Control;
using CoffeeHouseABC.Utils;
using Guna.UI2.WinForms;

namespace CoffeeHouseABC
{
    public partial class HomePage : Form
    {
        private bool isCollapsed = false;

        public HomePage()
        {
            InitializeComponent();
        }

        private List<ChiTietDonHang> _gioHang = new();
        private List<string> _tenSP = new();
        public void CapNhatGioHang(List<ChiTietDonHang> ds, List<string> tenSP)
        {
            _gioHang = ds;
            _tenSP = tenSP;

            LoadUserControl(new UC_Order(_gioHang, _tenSP));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.BringToFront();

            LoadUserControl(new UC_ItemSanPham());
        }

        private void LoadUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Menu());
        }

        private void btnLichSuMuaHang_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_PurchaseHitstory());
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            if (_gioHang.Count == 0)
            {
                LoadUserControl(new UC_Order());
            }
            else
            {
                LoadUserControl(new UC_Order(_gioHang, _tenSP));
            }
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            ToggleMenu();
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Estimate());
        }

        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_Account());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SessionManager.Logout();

                Login.Login loginForm = new Login.Login();
                loginForm.Show();
                this.Close();
            }
        }

        private void ToggleMenu()
        {
            if (!isCollapsed)
            {
                guna2Panel3.Width = 60;
                CollapseAllButtons();
                isCollapsed = true;
            }
            else
            {
                guna2Panel3.Width = 250;
                ExpandAllButtons();
                isCollapsed = false;
            }

            panelContainer.Dock = DockStyle.Fill;
            panelContainer.BringToFront();
        }

        private void CollapseAllButtons()
        {
            foreach (var ctrl in guna2Panel3.Controls)
            {
                if (ctrl is Guna2Button btn)
                {
                    btn.Text = "";
                    btn.CustomImages.ImageOffset = new Point(0, 0);
                    btn.CustomImages.ImageSize = new Size(30, 30);
                    btn.TextAlign = HorizontalAlignment.Center;
                    btn.TextOffset = new Point(0, 0);
                }
            }
        }

        private void ExpandAllButtons()
        {
            btnDanhMuc.Text = "Danh mục";
            btnThucDon.Text = "Thực đơn";
            btnDonHang.Text = "Đơn hàng";
            btnLichSuMuaHang.Text = "Lịch sử mua hàng";
            btnDanhGia.Text = "Đánh giá";
            btnThongTinTaiKhoan.Text = "Thông tin tài khoản";
            btnDangXuat.Text = "Đăng xuất";

            foreach (var ctrl in guna2Panel3.Controls)
            {
                if (ctrl is Guna2Button btn)
                {
                    btn.CustomImages.ImageOffset = new Point(10, 0);
                    btn.CustomImages.ImageSize = new Size(30, 30);
                    btn.TextAlign = HorizontalAlignment.Left;
                    btn.TextOffset = new Point(45, 0);
                }
            }
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
        "Bạn có chắc muốn đăng xuất không?",
        "Xác nhận",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                SessionManager.Logout();

                Login.Login loginForm = new Login.Login();
                loginForm.Show();

                this.Close();
            }
        }
    }
}
