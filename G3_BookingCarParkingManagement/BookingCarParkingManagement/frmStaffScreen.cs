using BookingCarParkingManagement.ChildOfStaffScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingCarParkingManagement
{
    public partial class frmStaffScreen : Form
    {
        public frmStaffScreen()
        {
            InitializeComponent();
        }

        private void frmStaffScreen_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void parkingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmParkingSlot frmParkingSlot = new frmParkingSlot();
            frmParkingSlot.MdiParent = this;
            frmParkingSlot.StartPosition = FormStartPosition.Manual;
            frmParkingSlot.Show();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            frmBooking frmBooking = new frmBooking();
            frmBooking.MdiParent = this;
            frmBooking.StartPosition = FormStartPosition.Manual;
            frmBooking.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cfm = MessageBox.Show("Are you sure to Sign Out?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (cfm == DialogResult.OK)
            {
                this.Hide();
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
            }
        }
    }
}
