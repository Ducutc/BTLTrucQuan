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
            panelList = new FlowLayoutPanel();
            lblTongTien = new Label();
            btnThanhToan = new Button();

            this.SuspendLayout();

            // panelList
            panelList.Dock = DockStyle.Top;
            panelList.Height = 450;
            panelList.AutoScroll = true;

            // lblTongTien
            lblTongTien.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTongTien.Location = new Point(20, 460);
            lblTongTien.Size = new Size(300, 30);
            lblTongTien.Text = "Tổng: 0 VNĐ";

            // btnThanhToan
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.BackColor = Color.DodgerBlue;
            btnThanhToan.ForeColor = Color.White;
            btnThanhToan.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnThanhToan.Size = new Size(200, 45);
            btnThanhToan.Location = new Point(20, 500);

            btnThanhToan.Click += BtnThanhToan_Click;

            // UC_Order
            this.Controls.Add(panelList);
            this.Controls.Add(lblTongTien);
            this.Controls.Add(btnThanhToan);
            this.Size = new Size(500, 600);

            this.ResumeLayout(false);
        }
    }
}
