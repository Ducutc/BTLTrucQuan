using CoffeeHouseABC.User_Control;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.BringToFront();

            LoadUserControl(new UC_Menu());
        }

        // ✅ Load UserControl vào panel
        private void LoadUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(uc);
        }

        // ✅ Các nút chuyển trang
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
            LoadUserControl(new UC_Order());
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


        // ✅ THU / MỞ MENU
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


        // ✅ THU MENU → icon vào giữa
        private void CollapseAllButtons()
        {
            foreach (var ctrl in guna2Panel3.Controls)
            {
                if (ctrl is Guna2Button btn)
                {
                    btn.Text = "";

                    // Icon vào giữa
                    btn.CustomImages.ImageOffset = new Point(0, 0);
                    btn.CustomImages.ImageSize = new Size(30, 30);

                    // Căn text/icon vào giữa
                    btn.TextAlign = HorizontalAlignment.Center;
                    btn.TextOffset = new Point(0, 0);
                }
            }
        }


        // ✅ MỞ MENU → hiện chữ + icon trái
        private void ExpandAllButtons()
        {
            // ✅ Gán text lại
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
                    // Icon về trái
                    btn.CustomImages.ImageOffset = new Point(10, 0);
                    btn.CustomImages.ImageSize = new Size(30, 30);

                    // Text lệch phải
                    btn.TextAlign = HorizontalAlignment.Left;
                    btn.TextOffset = new Point(45, 0);
                }
            }
        }

        
    }
}
