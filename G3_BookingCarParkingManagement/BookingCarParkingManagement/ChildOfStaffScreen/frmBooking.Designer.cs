namespace BookingCarParkingManagement.ChildOfStaffScreen
{
    partial class frmBooking
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
            dgvBooking = new DataGridView();
            panel1 = new Panel();
            dtpEnd = new DateTimePicker();
            dtpStart = new DateTimePicker();
            dtpBook = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtCar = new TextBox();
            label3 = new Label();
            txtSlot = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            cbxSearchBy = new ComboBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            pnButton = new Panel();
            btnReject = new Button();
            btnApprove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnButton.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBooking
            // 
            dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooking.Location = new Point(4, 174);
            dgvBooking.Name = "dgvBooking";
            dgvBooking.RowTemplate.Height = 25;
            dgvBooking.Size = new Size(793, 274);
            dgvBooking.TabIndex = 0;
            dgvBooking.CellMouseClick += dgvBooking_CellMouseClick;
            dgvBooking.MouseClick += dgvBooking_MouseClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtpEnd);
            panel1.Controls.Add(dtpStart);
            panel1.Controls.Add(dtpBook);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSlot);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 157);
            panel1.TabIndex = 1;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(299, 112);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(273, 23);
            dtpEnd.TabIndex = 13;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(299, 58);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(273, 23);
            dtpStart.TabIndex = 12;
            // 
            // dtpBook
            // 
            dtpBook.Location = new Point(299, 12);
            dtpBook.Name = "dtpBook";
            dtpBook.Size = new Size(273, 23);
            dtpBook.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(201, 113);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 10;
            label6.Text = "End Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(201, 61);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 8;
            label5.Text = "Start Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(201, 13);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 6;
            label4.Text = "Booking Time";
            // 
            // txtCar
            // 
            txtCar.Location = new Point(84, 110);
            txtCar.Name = "txtCar";
            txtCar.Size = new Size(100, 23);
            txtCar.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(2, 113);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 4;
            label3.Text = "Car";
            // 
            // txtSlot
            // 
            txtSlot.Location = new Point(84, 58);
            txtSlot.Name = "txtSlot";
            txtSlot.Size = new Size(100, 23);
            txtSlot.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(2, 61);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 2;
            label2.Text = "Slot";
            // 
            // txtID
            // 
            txtID.Location = new Point(84, 10);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(2, 13);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Booking ID";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(cbxSearchBy);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(585, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(343, 159);
            panel2.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(269, 45);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(119, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(153, 23);
            txtSearch.TabIndex = 4;
            // 
            // cbxSearchBy
            // 
            cbxSearchBy.FormattingEnabled = true;
            cbxSearchBy.Items.AddRange(new object[] { "Booking ID", "Slot ID", "Car Number" });
            cbxSearchBy.Location = new Point(13, 45);
            cbxSearchBy.Name = "cbxSearchBy";
            cbxSearchBy.Size = new Size(103, 23);
            cbxSearchBy.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(13, 12);
            label8.Name = "label8";
            label8.Size = new Size(103, 25);
            label8.TabIndex = 2;
            label8.Text = "Search By:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(92, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(13, 110);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 0;
            label7.Text = "Filter:";
            // 
            // pnButton
            // 
            pnButton.Controls.Add(btnReject);
            pnButton.Controls.Add(btnApprove);
            pnButton.Location = new Point(807, 174);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(121, 264);
            pnButton.TabIndex = 3;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.FromArgb(192, 0, 0);
            btnReject.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReject.ForeColor = SystemColors.Control;
            btnReject.Location = new Point(16, 160);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(90, 54);
            btnReject.TabIndex = 1;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.FromArgb(0, 192, 0);
            btnApprove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnApprove.ForeColor = SystemColors.Control;
            btnApprove.Location = new Point(16, 74);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(90, 54);
            btnApprove.TabIndex = 0;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // frmBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 450);
            Controls.Add(pnButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvBooking);
            Name = "frmBooking";
            Text = "frmBooking";
            Load += frmBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooking).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBooking;
        private Panel panel1;
        private DateTimePicker dtpEnd;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpBook;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtCar;
        private Label label3;
        private TextBox txtSlot;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Panel panel2;
        private Panel pnButton;
        private Button btnReject;
        private Button btnApprove;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox cbxSearchBy;
        private Label label8;
        private ComboBox comboBox1;
        private Label label7;
    }
}