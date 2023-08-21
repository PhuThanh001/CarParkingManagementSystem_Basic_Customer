namespace BookingCarParkingManagement
{
    partial class frmParkingBooking
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
            label1 = new Label();
            lbBookID = new Label();
            lbUserID = new Label();
            lbCarID = new Label();
            lbSlotXeID = new Label();
            lbBookingTime = new Label();
            lbStartTime = new Label();
            lbEndTime = new Label();
            lbStatus = new Label();
            txtBookID = new TextBox();
            txtUserID = new TextBox();
            txtCarID = new TextBox();
            txtSlotXeID = new TextBox();
            cboStatus = new ComboBox();
            dtpBookingTime = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            dtpEndTime = new DateTimePicker();
            btnBooking = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(306, 9);
            label1.Name = "label1";
            label1.Size = new Size(252, 41);
            label1.TabIndex = 0;
            label1.Text = "Parking Booking";
            // 
            // lbBookID
            // 
            lbBookID.AutoSize = true;
            lbBookID.Location = new Point(26, 96);
            lbBookID.Name = "lbBookID";
            lbBookID.Size = new Size(62, 20);
            lbBookID.TabIndex = 1;
            lbBookID.Text = "Book ID";
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Location = new Point(26, 162);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new Size(57, 20);
            lbUserID.TabIndex = 2;
            lbUserID.Text = "User ID";
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(26, 232);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 3;
            lbCarID.Text = "Car ID";
            // 
            // lbSlotXeID
            // 
            lbSlotXeID.AutoSize = true;
            lbSlotXeID.Location = new Point(26, 308);
            lbSlotXeID.Name = "lbSlotXeID";
            lbSlotXeID.Size = new Size(71, 20);
            lbSlotXeID.TabIndex = 4;
            lbSlotXeID.Text = "SlotXe ID";
            // 
            // lbBookingTime
            // 
            lbBookingTime.AutoSize = true;
            lbBookingTime.Location = new Point(26, 372);
            lbBookingTime.Name = "lbBookingTime";
            lbBookingTime.Size = new Size(97, 20);
            lbBookingTime.TabIndex = 5;
            lbBookingTime.Text = "BookingTime";
            // 
            // lbStartTime
            // 
            lbStartTime.AutoSize = true;
            lbStartTime.Location = new Point(447, 96);
            lbStartTime.Name = "lbStartTime";
            lbStartTime.Size = new Size(73, 20);
            lbStartTime.TabIndex = 6;
            lbStartTime.Text = "StartTime";
            // 
            // lbEndTime
            // 
            lbEndTime.AutoSize = true;
            lbEndTime.Location = new Point(447, 162);
            lbEndTime.Name = "lbEndTime";
            lbEndTime.Size = new Size(67, 20);
            lbEndTime.TabIndex = 7;
            lbEndTime.Text = "EndTime";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(447, 232);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 8;
            lbStatus.Text = "Status";
            // 
            // txtBookID
            // 
            txtBookID.BackColor = SystemColors.InactiveCaption;
            txtBookID.Enabled = false;
            txtBookID.Location = new Point(135, 89);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(250, 27);
            txtBookID.TabIndex = 9;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(135, 155);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(250, 27);
            txtUserID.TabIndex = 10;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(135, 225);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(250, 27);
            txtCarID.TabIndex = 11;
            // 
            // txtSlotXeID
            // 
            txtSlotXeID.Location = new Point(135, 305);
            txtSlotXeID.Name = "txtSlotXeID";
            txtSlotXeID.Size = new Size(250, 27);
            txtSlotXeID.TabIndex = 12;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "1", "2" });
            cboStatus.Location = new Point(576, 224);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(250, 28);
            cboStatus.TabIndex = 13;
            // 
            // dtpBookingTime
            // 
            dtpBookingTime.Location = new Point(135, 365);
            dtpBookingTime.Name = "dtpBookingTime";
            dtpBookingTime.Size = new Size(250, 27);
            dtpBookingTime.TabIndex = 14;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Location = new Point(576, 91);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(250, 27);
            dtpStartTime.TabIndex = 15;
            // 
            // dtpEndTime
            // 
            dtpEndTime.Location = new Point(576, 157);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.Size = new Size(250, 27);
            dtpEndTime.TabIndex = 16;
            // 
            // btnBooking
            // 
            btnBooking.Location = new Point(227, 451);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(94, 29);
            btnBooking.TabIndex = 17;
            btnBooking.Text = "Booking";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(540, 451);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmParkingBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 506);
            Controls.Add(btnClose);
            Controls.Add(btnBooking);
            Controls.Add(dtpEndTime);
            Controls.Add(dtpStartTime);
            Controls.Add(dtpBookingTime);
            Controls.Add(cboStatus);
            Controls.Add(txtSlotXeID);
            Controls.Add(txtCarID);
            Controls.Add(txtUserID);
            Controls.Add(txtBookID);
            Controls.Add(lbStatus);
            Controls.Add(lbEndTime);
            Controls.Add(lbStartTime);
            Controls.Add(lbBookingTime);
            Controls.Add(lbSlotXeID);
            Controls.Add(lbCarID);
            Controls.Add(lbUserID);
            Controls.Add(lbBookID);
            Controls.Add(label1);
            Name = "frmParkingBooking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmParkingBooking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbBookID;
        private Label lbUserID;
        private Label lbCarID;
        private Label lbSlotXeID;
        private Label lbBookingTime;
        private Label lbStartTime;
        private Label lbEndTime;
        private Label lbStatus;
        private TextBox txtBookID;
        private TextBox txtUserID;
        private TextBox txtCarID;
        private TextBox txtSlotXeID;
        private ComboBox cboStatus;
        private DateTimePicker dtpBookingTime;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpEndTime;
        private Button btnBooking;
        private Button btnClose;
    }
}