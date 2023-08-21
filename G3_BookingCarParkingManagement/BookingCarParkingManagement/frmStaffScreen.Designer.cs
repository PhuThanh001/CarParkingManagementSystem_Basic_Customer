namespace BookingCarParkingManagement
{
    partial class frmStaffScreen
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
            menuStrip1 = new MenuStrip();
            parkingToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { parkingToolStripMenuItem, bookingToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(142, 527);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // parkingToolStripMenuItem
            // 
            parkingToolStripMenuItem.Name = "parkingToolStripMenuItem";
            parkingToolStripMenuItem.Size = new Size(135, 29);
            parkingToolStripMenuItem.Text = "Parking slots";
            parkingToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            parkingToolStripMenuItem.Click += parkingToolStripMenuItem_Click;
            // 
            // bookingToolStripMenuItem
            // 
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new Size(135, 29);
            bookingToolStripMenuItem.Text = "Booking list";
            bookingToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            bookingToolStripMenuItem.Click += bookingToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(135, 29);
            exitToolStripMenuItem.Text = "Sign out";
            exitToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // frmStaffScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 527);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmStaffScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStaffScreen";
            Load += frmStaffScreen_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem parkingToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}