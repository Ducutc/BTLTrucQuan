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
    public partial class UC_Estimate : UserControl
    {
        public UC_Estimate()
        {
            InitializeComponent();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cảm ơn bạn đã gửi đánh giá!", 
                "Thành công", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            
            ResetForm();
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
