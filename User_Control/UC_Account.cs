using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_Account : UserControl
    {
        public UC_Account()
        {
            InitializeComponent();
            LoadAccountInfo();
        }

        private void LoadAccountInfo()
        {
            txtTenTaiKhoan.Text = "nguyenvana";
            txtVaiTro.Text = "Khách hàng";
            txtMatKhau.Text = "********";
            txtMatKhau.UseSystemPasswordChar = false;
            txtMatKhauMoi.Text = "";
            txtMatKhauMoi.UseSystemPasswordChar = true;
            
            txtVaiTro.Enabled = false;
            txtTenTaiKhoan.ReadOnly = true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật thông tin tài khoản thành công!", 
                "Thành công", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            
            txtMatKhau.Text = "********";
            txtMatKhauMoi.Text = "";
        }
    }
}
