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

namespace BookingCarParkingManagement
{
    public partial class frmCarRegistration : Form
    {
        public CarRepository _car { get; set; }
        public frmCarRegistration()
        {
            _car = new CarRepository();
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                //int carId = int.Parse(txtCarID.Text);
                int userId = int.Parse(txtUserID.Text);
                string bsx = txtBSX.Text;
                int status = Convert.ToInt32(cboStatus.SelectedValue);

                Car newCar = new Car
                {
                    //CarId = carId,
                    UserId = userId,
                    Bsx = bsx,
                    Status = status
                };
                _car.Create(newCar);
                MessageBox.Show("Đăng ký xe thành công!");
                ClearInputFields();
            }
            else
            {
                {
                    MessageBox.Show("Vui lòng điền đúng thông tin.");
                }
            }
        }

        private bool ValidateInput()
        {
            if (//string.IsNullOrWhiteSpace(txtCarID.Text) ||
                string.IsNullOrWhiteSpace(txtUserID.Text) ||
                string.IsNullOrWhiteSpace(txtBSX.Text) ||
                cboStatus.SelectedItem == null)
            {
                return false;
            }

            if (//!int.TryParse(txtCarID.Text, out _) ||
                !int.TryParse(txtUserID.Text, out _))
            {
                return false;
            }

            return true;
        }
        private void ClearInputFields()
        {
            //txtCarID.Clear();
            txtUserID.Clear();
            txtBSX.Clear();
            cboStatus.SelectedItem = null;
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
