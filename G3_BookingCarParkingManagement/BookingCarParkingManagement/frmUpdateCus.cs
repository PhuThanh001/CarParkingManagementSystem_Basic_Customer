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
    public partial class frmUpdateCus : Form
    {
        public IUserRepository UserRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Users user { get; set; }
        public frmUpdateCus()
        {
            InitializeComponent();
        }

        private void frmUpdateCus_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are u sure to exit?", "Login Notification!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtCustomerName.Clear();
            txtPassword.Clear();
            txtPhoneNum.Clear();
            txtCustomerStatus.Clear();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUpdateCus_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                txtEmail.Text = user.Email.ToString();
                txtCustomerName.Text = user.Name.ToString();
                txtPassword.Text = user.Password.ToString();
                txtPhoneNum.Text = user.Phone.ToString();
                txtCustomerStatus.Text = user.Status.ToString();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Boolean checkId = true;
            int memID;
            try
            {
                do
                {

                    memID = rnd.Next(10, 10000);
                    if (!UserRepository.CheckMemberIdDuplicated(memID))
                    {
                        checkId = false;
                    }


                } while (checkId);


                if (txtEmail.Text == "" || txtCustomerName.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("All fields are required!", "Product Management",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (InsertOrUpdate == true)
                    {
                        var m = new Users
                        {
                            Email = txtEmail.Text,
                            Name = txtCustomerName.Text,
                            Password = txtPassword.Text,
                            Phone = txtPhoneNum.Text,
                            Status = int.Parse(txtCustomerStatus.Text),
                            UserId = user.UserId


                        };
                        UserRepository.UpdateMember(m);
                        MessageBox.Show("Update member successfully!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new Member!" : "Update a Member!");

            }
        }

        
    }
}
