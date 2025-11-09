namespace CoffeeHouseABC.User_Control
{
    partial class UC_Menu
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Button btnDatHang;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // flowPanel
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(900, 520);

            // btnDatHang
            this.btnDatHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDatHang.Height = 60;
            this.btnDatHang.Text = "Đặt hàng";
            this.btnDatHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDatHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDatHang.ForeColor = System.Drawing.Color.White;
            this.btnDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatHang.Click += new System.EventHandler(this.btnDatHang_Click);

            // UC_Menu
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.btnDatHang);
            this.Name = "UC_Menu";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
        }
    }
}
