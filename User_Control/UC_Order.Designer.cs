namespace CoffeeHouseABC.User_Control
{
    partial class UC_Order
    {
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel panelList;
        private Label lblTongTien;
        private Button btnThanhToan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelList = new FlowLayoutPanel();
            lblTongTien = new Label();
            btnThanhToan = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            SuspendLayout();
            // 
            // panelList
            // 
            panelList.AutoScroll = true;
            panelList.Dock = DockStyle.Top;
            panelList.Location = new Point(0, 0);
            panelList.Name = "panelList";
            panelList.Size = new Size(500, 450);
            panelList.TabIndex = 0;
            // 
            // lblTongTien
            // 
            lblTongTien.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTongTien.Location = new Point(20, 460);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(300, 30);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Tổng: 0 VNĐ";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.FromArgb(70, 183, 91);
            btnThanhToan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Location = new Point(192, 527);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(200, 45);
            btnThanhToan.TabIndex = 2;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += BtnThanhToan_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = btnThanhToan;
            // 
            // UC_Order
            // 
            Controls.Add(panelList);
            Controls.Add(lblTongTien);
            Controls.Add(btnThanhToan);
            Name = "UC_Order";
            Size = new Size(500, 600);
            ResumeLayout(false);
        }
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
