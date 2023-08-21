namespace BookingCarParkingManagement
{
    partial class frmCarRegistration
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
            btnRegister = new Button();
            btnClose = new Button();
            lbCarID = new Label();
            lbUserID = new Label();
            lbBSX = new Label();
            lbStatus = new Label();
            label5 = new Label();
            txtCarID = new TextBox();
            txtUserID = new TextBox();
            txtBSX = new TextBox();
            cboStatus = new ComboBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(101, 415);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(300, 415);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(37, 118);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 2;
            lbCarID.Text = "Car ID";
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Location = new Point(37, 197);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new Size(57, 20);
            lbUserID.TabIndex = 3;
            lbUserID.Text = "User ID";
            // 
            // lbBSX
            // 
            lbBSX.AutoSize = true;
            lbBSX.Location = new Point(37, 267);
            lbBSX.Name = "lbBSX";
            lbBSX.Size = new Size(35, 20);
            lbBSX.TabIndex = 4;
            lbBSX.Text = "BSX";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(37, 338);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 5;
            lbStatus.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(115, 24);
            label5.Name = "label5";
            label5.Size = new Size(238, 41);
            label5.TabIndex = 6;
            label5.Text = "CarRegistration";
            // 
            // txtCarID
            // 
            txtCarID.BackColor = SystemColors.InactiveCaption;
            txtCarID.Enabled = false;
            txtCarID.Location = new Point(192, 111);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(222, 27);
            txtCarID.TabIndex = 7;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(192, 190);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(222, 27);
            txtUserID.TabIndex = 8;
            // 
            // txtBSX
            // 
            txtBSX.Location = new Point(192, 260);
            txtBSX.Name = "txtBSX";
            txtBSX.Size = new Size(222, 27);
            txtBSX.TabIndex = 9;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "1", "2" });
            cboStatus.Location = new Point(192, 330);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(222, 28);
            cboStatus.TabIndex = 10;
            // 
            // frmCarRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 485);
            Controls.Add(cboStatus);
            Controls.Add(txtBSX);
            Controls.Add(txtUserID);
            Controls.Add(txtCarID);
            Controls.Add(label5);
            Controls.Add(lbStatus);
            Controls.Add(lbBSX);
            Controls.Add(lbUserID);
            Controls.Add(lbCarID);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Name = "frmCarRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Button btnClose;
        private Label lbCarID;
        private Label lbUserID;
        private Label lbBSX;
        private Label lbStatus;
        private Label label5;
        private TextBox txtCarID;
        private TextBox txtUserID;
        private TextBox txtBSX;
        private ComboBox cboStatus;
    }
}