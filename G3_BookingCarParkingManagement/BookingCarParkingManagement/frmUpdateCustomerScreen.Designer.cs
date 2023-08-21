namespace BookingCarParkingManagement
{
    partial class frmUpdateCustomerScreen
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
            tabUserInfo = new TabControl();
            tabInfo = new TabPage();
            txtCusID = new TextBox();
            CustomerID = new Label();
            txtStatus = new TextBox();
            label1 = new Label();
            label223 = new Label();
            btnUpdateMember = new Button();
            btnClose = new Button();
            label7 = new Label();
            label8 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNum = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtCusName = new TextBox();
            tabUserInfo.SuspendLayout();
            tabInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tabUserInfo
            // 
            tabUserInfo.Controls.Add(tabInfo);
            tabUserInfo.Location = new Point(-28, -61);
            tabUserInfo.Name = "tabUserInfo";
            tabUserInfo.SelectedIndex = 0;
            tabUserInfo.Size = new Size(475, 520);
            tabUserInfo.TabIndex = 1;
            // 
            // tabInfo
            // 
            tabInfo.Controls.Add(txtCusID);
            tabInfo.Controls.Add(CustomerID);
            tabInfo.Controls.Add(txtStatus);
            tabInfo.Controls.Add(label1);
            tabInfo.Controls.Add(label223);
            tabInfo.Controls.Add(btnUpdateMember);
            tabInfo.Controls.Add(btnClose);
            tabInfo.Controls.Add(label7);
            tabInfo.Controls.Add(label8);
            tabInfo.Controls.Add(txtPassword);
            tabInfo.Controls.Add(txtEmail);
            tabInfo.Controls.Add(txtPhoneNum);
            tabInfo.Controls.Add(label9);
            tabInfo.Controls.Add(label10);
            tabInfo.Controls.Add(txtCusName);
            tabInfo.Location = new Point(4, 29);
            tabInfo.Name = "tabInfo";
            tabInfo.Padding = new Padding(3);
            tabInfo.Size = new Size(467, 487);
            tabInfo.TabIndex = 1;
            tabInfo.Text = "UserInfo";
            tabInfo.UseVisualStyleBackColor = true;
            tabInfo.Click += tabInfo_Click;
            // 
            // txtCusID
            // 
            txtCusID.Location = new Point(205, 102);
            txtCusID.Name = "txtCusID";
            txtCusID.ReadOnly = true;
            txtCusID.Size = new Size(226, 27);
            txtCusID.TabIndex = 40;
            // 
            // CustomerID
            // 
            CustomerID.AutoSize = true;
            CustomerID.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CustomerID.Location = new Point(53, 105);
            CustomerID.Name = "CustomerID";
            CustomerID.Size = new Size(111, 25);
            CustomerID.TabIndex = 39;
            CustomerID.Text = "CustomerID";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(201, 316);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(226, 27);
            txtStatus.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 319);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 37;
            label1.Text = "Status";
            // 
            // label223
            // 
            label223.AutoSize = true;
            label223.Font = new Font("Calisto MT", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            label223.ForeColor = SystemColors.HotTrack;
            label223.Location = new Point(79, 41);
            label223.Name = "label223";
            label223.Size = new Size(338, 39);
            label223.TabIndex = 36;
            label223.Text = "Member Mamagement";
            // 
            // btnUpdateMember
            // 
            btnUpdateMember.Location = new Point(260, 379);
            btnUpdateMember.Margin = new Padding(3, 4, 3, 4);
            btnUpdateMember.Name = "btnUpdateMember";
            btnUpdateMember.Size = new Size(86, 31);
            btnUpdateMember.TabIndex = 33;
            btnUpdateMember.Text = "Update";
            btnUpdateMember.UseVisualStyleBackColor = true;
            btnUpdateMember.Click += btnUpdateMember_Click_1;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ButtonShadow;
            btnClose.Location = new Point(53, 379);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 31);
            btnClose.TabIndex = 32;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(53, 224);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 31;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(53, 182);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 30;
            label8.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(201, 225);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(230, 27);
            txtPassword.TabIndex = 29;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(205, 182);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 27);
            txtEmail.TabIndex = 28;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(201, 273);
            txtPhoneNum.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(230, 27);
            txtPhoneNum.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(51, 272);
            label9.Name = "label9";
            label9.Size = new Size(107, 25);
            label9.TabIndex = 26;
            label9.Text = "PhoneNum";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(51, 143);
            label10.Name = "label10";
            label10.Size = new Size(148, 25);
            label10.TabIndex = 25;
            label10.Text = "Customer Name";
            // 
            // txtCusName
            // 
            txtCusName.Location = new Point(205, 144);
            txtCusName.Margin = new Padding(3, 4, 3, 4);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(230, 27);
            txtCusName.TabIndex = 23;
            // 
            // frmUpdateCustomerScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 398);
            Controls.Add(tabUserInfo);
            Name = "frmUpdateCustomerScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateScreen";
            Load += frmUpdateCustomerScreen_Load_1;
            tabUserInfo.ResumeLayout(false);
            tabInfo.ResumeLayout(false);
            tabInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabUserInfo;
        private TabPage tabInfo;
        private Label label223;
        private Button btnUpdateMember;
        private Button btnClose;
        private Label label7;
        private Label label8;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtPhoneNum;
        private Label label9;
        private Label label10;
        private TextBox txtCusName;
        private TextBox txtStatus;
        private Label label1;
        private TextBox txtCusID;
        private Label CustomerID;
    }
}