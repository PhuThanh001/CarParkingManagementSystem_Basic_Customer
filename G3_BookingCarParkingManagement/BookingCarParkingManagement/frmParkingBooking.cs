using DataObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BookingCarParkingManagement
{
    public partial class frmParkingBooking : Form
    {
        public BookRepository _book { get; set; }
        public frmParkingBooking()
        {
            _book = new BookRepository();
            InitializeComponent();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                //int bookId = int.Parse(txtBookID.Text);
                int slotXeId = int.Parse(txtSlotXeID.Text);
                int carId = int.Parse(txtCarID.Text);
                DateTime bookingTime = dtpBookingTime.Value;
                DateTime startTime = dtpStartTime.Value;
                DateTime endTime = dtpEndTime.Value;
                int status = Convert.ToInt32(cboStatus.SelectedValue);
                int userId = int.Parse(txtUserID.Text);

                Book newBooking = new Book
                {
                    //BookId = bookId,
                    SlotxeId = slotXeId,
                    CarId = carId,
                    BookingTime = bookingTime,
                    StartTime = startTime,
                    EndTime = endTime,
                    Status = status,
                    UserId = userId
                };

                _book.Create(newBooking);

                MessageBox.Show("Đặt chỗ đậu xe thành công!");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Vui lòng điền đúng thông tin.");
            }
        }
        private bool ValidateInput()
        {
            if (//string.IsNullOrWhiteSpace(txtBookID.Text) ||
                string.IsNullOrWhiteSpace(txtSlotXeID.Text) ||
                string.IsNullOrWhiteSpace(txtCarID.Text) ||
                string.IsNullOrWhiteSpace(txtUserID.Text) ||
                cboStatus.SelectedItem == null)
            {
                return false;
            }

            if (//!int.TryParse(txtBookID.Text, out _) ||
                !int.TryParse(txtSlotXeID.Text, out _) ||
                !int.TryParse(txtCarID.Text, out _) ||
                !int.TryParse(txtUserID.Text, out _))
            {
                return false;
            }
            if (dtpBookingTime.Value >= dtpStartTime.Value ||
                dtpStartTime.Value >= dtpEndTime.Value)
            {
                return false;
            }

            return true;
        }
        private void ClearInputFields()
        {
            //txtBookID.Clear();
            txtSlotXeID.Clear();
            txtCarID.Clear();
            dtpBookingTime.Value = DateTime.Now;
            dtpStartTime.Value = DateTime.Now;
            dtpEndTime.Value = DateTime.Now;
            cboStatus.SelectedItem = null;
            txtUserID.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
