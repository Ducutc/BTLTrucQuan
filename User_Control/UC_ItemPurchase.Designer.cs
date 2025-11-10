namespace CoffeeHouseABC.User_Control
{
    partial class UC_ItemPurchase
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMaHD = new Label();
            lblTongTien = new Label();
            lblNgay = new Label();
            lblTrangThai = new Label();
            SuspendLayout();
            // 
            // lblMaHD
            // 
            lblMaHD.Location = new Point(-1, 0);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(223, 55);
            lblMaHD.TabIndex = 0;
            lblMaHD.Text = "label1";
            lblMaHD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTongTien
            // 
            lblTongTien.Location = new Point(457, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(223, 55);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "label1";
            lblTongTien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNgay
            // 
            lblNgay.Location = new Point(228, 0);
            lblNgay.Name = "lblNgay";
            lblNgay.Size = new Size(223, 55);
            lblNgay.TabIndex = 2;
            lblNgay.Text = "label1";
            lblNgay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Location = new Point(686, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(223, 55);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "label3";
            lblTrangThai.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_ItemPurchase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTrangThai);
            Controls.Add(lblNgay);
            Controls.Add(lblTongTien);
            Controls.Add(lblMaHD);
            Name = "UC_ItemPurchase";
            Size = new Size(1104, 564);
            ResumeLayout(false);
        }

        #endregion

        private Label lblMaHD;
        private Label lblTongTien;
        private Label lblNgay;
        private Label lblTrangThai;
    }
}
