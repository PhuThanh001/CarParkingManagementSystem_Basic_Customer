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
            dgvUserManagement = new DataGridView();
            label1 = new Label();
            txtUserID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            txtRole = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtStatus = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUserManagement).BeginInit();
            SuspendLayout();
            // 
            // dgvUserManagement
            // 
            dgvUserManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserManagement.Location = new Point(12, 12);
            dgvUserManagement.Name = "dgvUserManagement";
            dgvUserManagement.RowHeadersWidth = 51;
            dgvUserManagement.RowTemplate.Height = 29;
            dgvUserManagement.Size = new Size(644, 240);
            dgvUserManagement.TabIndex = 0;
            dgvUserManagement.CellContentClick += dgvUserManagement_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 289);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "User ID";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(95, 286);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(218, 27);
            txtUserID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 330);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 370);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 409);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // txtName
            // 
            txtName.Location = new Point(95, 327);
            txtName.Name = "txtName";
            txtName.Size = new Size(218, 27);
            txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(95, 367);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(95, 406);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(218, 27);
            txtPassword.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(362, 289);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 9;
            label5.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(438, 286);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(218, 27);
            txtPhone.TabIndex = 10;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(438, 327);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(218, 27);
            txtRole.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(362, 330);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 12;
            label6.Text = "Role";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(362, 370);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 13;
            label7.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(438, 367);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(218, 27);
            txtStatus.TabIndex = 14;
            // 
            // frmAdminHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(668, 487);
            Controls.Add(txtStatus);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtRole);
            Controls.Add(txtPhone);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUserID);
            Controls.Add(label1);
            Controls.Add(dgvUserManagement);
            Name = "frmAdminHome";
            Text = " ";
            Load += frmAdminHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUserManagement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUserManagement;
        private Label label1;
        private TextBox txtUserID;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label5;
        private TextBox txtPhone;
        private TextBox txtRole;
        private Label label6;
        private Label label7;
        private TextBox txtStatus;
    }
}