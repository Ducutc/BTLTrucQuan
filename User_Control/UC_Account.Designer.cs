namespace CoffeeHouseABC.User_Control
{
    partial class UC_Account
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.txtVaiTro = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(420, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông tin tài khoản";
            
            this.lblTenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(250, 140);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(125, 25);
            this.lblTenTaiKhoan.TabIndex = 1;
            this.lblTenTaiKhoan.Text = "Tên tài khoản:";
            
            this.txtTenTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenTaiKhoan.BorderRadius = 8;
            this.txtTenTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTaiKhoan.DefaultText = "";
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(450, 130);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.PasswordChar = '\0';
            this.txtTenTaiKhoan.PlaceholderText = "Tên tài khoản";
            this.txtTenTaiKhoan.SelectedText = "";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(500, 45);
            this.txtTenTaiKhoan.TabIndex = 2;
            
            this.lblVaiTro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblVaiTro.Location = new System.Drawing.Point(250, 210);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(68, 25);
            this.lblVaiTro.TabIndex = 3;
            this.lblVaiTro.Text = "Vai trò:";
            
            this.txtVaiTro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVaiTro.BorderRadius = 8;
            this.txtVaiTro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVaiTro.DefaultText = "";
            this.txtVaiTro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVaiTro.Location = new System.Drawing.Point(450, 200);
            this.txtVaiTro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVaiTro.Name = "txtVaiTro";
            this.txtVaiTro.PasswordChar = '\0';
            this.txtVaiTro.PlaceholderText = "Khách hàng/admin";
            this.txtVaiTro.ReadOnly = true;
            this.txtVaiTro.SelectedText = "";
            this.txtVaiTro.Size = new System.Drawing.Size(500, 45);
            this.txtVaiTro.TabIndex = 4;
            
            this.lblMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMatKhau.Location = new System.Drawing.Point(250, 280);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(90, 25);
            this.lblMatKhau.TabIndex = 5;
            this.lblMatKhau.Text = "Mật khẩu:";
            
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMatKhau.BorderRadius = 8;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhau.Location = new System.Drawing.Point(450, 270);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.PlaceholderText = "••••••• (mặc định 8 dấu • để ẩn mật khẩu)";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(500, 45);
            this.txtMatKhau.TabIndex = 6;
            
            this.lblMatKhauMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMatKhauMoi.Location = new System.Drawing.Point(250, 350);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(125, 25);
            this.lblMatKhauMoi.TabIndex = 7;
            this.lblMatKhauMoi.Text = "Mật khẩu mới:";
            
            this.txtMatKhauMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMatKhauMoi.BorderRadius = 8;
            this.txtMatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhauMoi.DefaultText = "";
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhauMoi.Location = new System.Drawing.Point(450, 340);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '●';
            this.txtMatKhauMoi.PlaceholderText = "Nhập đúng mật khẩu cũ để đổi sang mật khẩu mới";
            this.txtMatKhauMoi.SelectedText = "";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(500, 45);
            this.txtMatKhauMoi.TabIndex = 8;
            
            this.btnXacNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXacNhan.BorderRadius = 8;
            this.btnXacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacNhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(85)))), ((int)(((byte)(40)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(600, 430);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(150, 45);
            this.btnXacNhan.TabIndex = 9;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtVaiTro);
            this.Controls.Add(this.lblVaiTro);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.lblTenTaiKhoan);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_Account";
            this.Size = new System.Drawing.Size(1200, 700);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label lblVaiTro;
        private Guna.UI2.WinForms.Guna2TextBox txtVaiTro;
        private System.Windows.Forms.Label lblMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhauMoi;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
    }
}
