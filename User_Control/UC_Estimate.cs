using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeHouseABC.Services;
using CoffeeHouseABC.Utils;

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_Estimate : UserControl
    {
        public UC_Estimate()
        {
            InitializeComponent();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (!SessionManager.IsLoggedIn() || SessionManager.CurrentUser == null)
            {
                MessageBox.Show("Vui lòng đăng nhập để gửi đánh giá!", 
                    "Thông báo", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            int diemPhucVu = GetDiemThaiDo();
            int diemChatLuong = GetDiemChatLuong();
            int diemKhongGian = GetDiemKhongGian();
            int diemDaDang = GetDiemDoDaDang();

            if (diemPhucVu == 0 || diemChatLuong == 0 || diemKhongGian == 0 || diemDaDang == 0)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ các mục đánh giá!", 
                    "Thông báo", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            bool success = DanhGiaService.ThemDanhGia(
                SessionManager.CurrentUser.MaKH,
                diemPhucVu,
                diemChatLuong,
                diemKhongGian,
                diemDaDang,
                txtGopY.Text
            );

            if (success)
            {
                MessageBox.Show("Cảm ơn bạn đã gửi đánh giá!", 
                    "Thành công", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                
                ResetForm();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi gửi đánh giá!", 
                    "Lỗi", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private int GetDiemThaiDo()
        {
            if (rbThaiDo1.Checked) return 1;
            if (rbThaiDo2.Checked) return 2;
            if (rbThaiDo3.Checked) return 3;
            if (rbThaiDo4.Checked) return 4;
            if (rbThaiDo5.Checked) return 5;
            return 0;
        }

        private int GetDiemChatLuong()
        {
            if (rbChatLuong1.Checked) return 1;
            if (rbChatLuong2.Checked) return 2;
            if (rbChatLuong3.Checked) return 3;
            if (rbChatLuong4.Checked) return 4;
            if (rbChatLuong5.Checked) return 5;
            return 0;
        }

        private int GetDiemKhongGian()
        {
            if (rbKhongGian1.Checked) return 1;
            if (rbKhongGian2.Checked) return 2;
            if (rbKhongGian3.Checked) return 3;
            if (rbKhongGian4.Checked) return 4;
            if (rbKhongGian5.Checked) return 5;
            return 0;
        }

        private int GetDiemDoDaDang()
        {
            if (rbDoDaDang1.Checked) return 1;
            if (rbDoDaDang2.Checked) return 2;
            if (rbDoDaDang3.Checked) return 3;
            if (rbDoDaDang4.Checked) return 4;
            if (rbDoDaDang5.Checked) return 5;
            return 0;
        }

        private void ResetForm()
        {
            rbThaiDo1.Checked = false;
            rbThaiDo2.Checked = false;
            rbThaiDo3.Checked = false;
            rbThaiDo4.Checked = false;
            rbThaiDo5.Checked = false;
            
            rbChatLuong1.Checked = false;
            rbChatLuong2.Checked = false;
            rbChatLuong3.Checked = false;
            rbChatLuong4.Checked = false;
            rbChatLuong5.Checked = false;
            
            rbKhongGian1.Checked = false;
            rbKhongGian2.Checked = false;
            rbKhongGian3.Checked = false;
            rbKhongGian4.Checked = false;
            rbKhongGian5.Checked = false;
            
            rbDoDaDang1.Checked = false;
            rbDoDaDang2.Checked = false;
            rbDoDaDang3.Checked = false;
            rbDoDaDang4.Checked = false;
            rbDoDaDang5.Checked = false;
            
            txtGopY.Text = "";
        }
    }
}
