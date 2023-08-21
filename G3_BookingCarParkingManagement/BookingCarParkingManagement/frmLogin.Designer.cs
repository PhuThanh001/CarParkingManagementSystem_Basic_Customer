namespace BookingCarParkingManagement
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            btnCancel = new Button();
            txtRegister = new LinkLabel();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(58, 101);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
=======
            label1.Location = new Point(51, 76);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
>>>>>>> c67ee7ca86e5cef3134aac52e8037090e3b65fd3
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(58, 148);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
=======
            label2.Location = new Point(51, 111);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
>>>>>>> c67ee7ca86e5cef3134aac52e8037090e3b65fd3
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(137, 74);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(137, 109);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(220, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(103, 28);
            label3.Name = "label3";
            label3.Size = new Size(183, 32);
            label3.TabIndex = 4;
            label3.Text = "Welcome back";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(82, 160);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(87, 22);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(228, 160);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 22);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtRegister
            // 
            txtRegister.ActiveLinkColor = Color.LightYellow;
            txtRegister.AutoSize = true;
            txtRegister.BackColor = Color.FromArgb(0, 0, 0, 0);
            txtRegister.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtRegister.ForeColor = SystemColors.ActiveCaptionText;
            txtRegister.LinkColor = Color.Red;
<<<<<<< HEAD
            txtRegister.Location = new Point(261, 245);
=======
            txtRegister.Location = new Point(238, 184);
>>>>>>> c67ee7ca86e5cef3134aac52e8037090e3b65fd3
            txtRegister.Name = "txtRegister";
            txtRegister.Size = new Size(57, 15);
            txtRegister.TabIndex = 7;
            txtRegister.TabStop = true;
            txtRegister.Text = "Register";
            txtRegister.LinkClicked += txtRegister_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
<<<<<<< HEAD
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Location = new Point(102, 245);
=======
            label4.BackColor = SystemColors.ActiveBorder;
            label4.Location = new Point(89, 184);
>>>>>>> c67ee7ca86e5cef3134aac52e8037090e3b65fd3
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 8;
            label4.Text = "Do not have account?";
            label4.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(411, 216);
            Controls.Add(label4);
            Controls.Add(txtRegister);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
        private Button btnCancel;
        private LinkLabel txtRegister;
        private Label label4;
    }
}