using CoffeeHouseABC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_Order : UserControl
    {
        private List<ChiTietDonHang> _ds = new();
        private List<string> _tenSP = new();

        // ✅ Constructor rỗng (dùng khi mở Đơn hàng mà chưa chọn gì)
        public UC_Order()
        {
            InitializeComponent();
            HienThiTrangThaiTrong();
        }

        // ✅ Constructor có dữ liệu
        public UC_Order(List<ChiTietDonHang> ds, List<string> tenSP)
        {
            InitializeComponent();
            _ds = ds;
            _tenSP = tenSP;

            LoadOrder();
        }

        // ✅ Khi chưa có đơn hàng
        private void HienThiTrangThaiTrong()
        {
            panelList.Controls.Clear();

            Label lbl = new Label
            {
                Text = "Bạn chưa chọn sản phẩm nào...",
                AutoSize = true,
                Font = new Font("Segoe UI", 12, FontStyle.Italic),
                ForeColor = Color.Gray,
                Location = new Point(20, 20)
            };

            panelList.Controls.Add(lbl);

            lblTongTien.Text = "Tổng: 0 VNĐ";
        }

        // ✅ Load danh sách đơn hàng
        private void LoadOrder()
        {
            panelList.Controls.Clear();

            if (_ds == null || _ds.Count == 0)
            {
                HienThiTrangThaiTrong();
                return;
            }

            for (int i = 0; i < _ds.Count; i++)
            {
                var item = new UC_ItemOrder();
                item.SetData(_ds[i], _tenSP[i]);
                panelList.Controls.Add(item);
            }

            decimal tong = _ds.Sum(x => x.DonGiaBan * x.SoLuong);
            lblTongTien.Text = $"Tổng: {tong:N0} VNĐ";
        }

        private void BtnThanhToan_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Đang xử lý thanh toán...");
        }
    }
}
