namespace BookingCarParkingManagement
{
    partial class frmAdminHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvBaiXe = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBaiXe).BeginInit();
            SuspendLayout();
            // 
            // dgvBaiXe
            // 
            dgvBaiXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaiXe.Location = new Point(12, 12);
            dgvBaiXe.Name = "dgvBaiXe";
            dgvBaiXe.RowHeadersWidth = 51;
            dgvBaiXe.RowTemplate.Height = 29;
            dgvBaiXe.Size = new Size(644, 244);
            dgvBaiXe.TabIndex = 0;
            dgvBaiXe.CellContentClick += dgvBaiXe_CellContentClick;
            // 
            // frmAdminHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(668, 458);
            Controls.Add(dgvBaiXe);
            Name = "frmAdminHome";
            Text = "Admin Home";
            Load += frmAdminHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBaiXe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBaiXe;
    }
}