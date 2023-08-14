using Repository;
using System.Windows.Forms.Design;

namespace CarParkingSystem_Group3
{
    public partial class frmLogin : Form
    {
        public UserManagementRepository _userManagement { get; set; }
        public frmLogin()
        {
            InitializeComponent();
            _userManagement = new UserManagementRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Error", MessageBoxButtons.OK);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password cannot be empty.", "Error", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }
            //goi vao db de check username && pass
            var user = _userManagement.GetAll()
                        .Where(u => txtUsername.Text.Equals(u.Username) && txtPassword.Text.Equals(u.Password))
                        .FirstOrDefault();

            if (user != null)
            {
                switch (user.Role)
                {
                    case 1: // guest
                        frmCarParkingGuestManagement guestManagement = new frmCarParkingGuestManagement();
                        this.Hide();
                        guestManagement.ShowDialog();
                        break;
                    case 2: // member
                        frmCarParkingMemberManagement memberManagement = new frmCarParkingMemberManagement();
                        this.Hide();
                        memberManagement.ShowDialog();
                        break;
                    case 3: // staff
                        frmCarParkingStaffManagement staffManagement = new frmCarParkingStaffManagement();
                        this.Hide();
                        staffManagement.ShowDialog();
                        break;
                    case 4: // admin
                        frmCarParkingAdminManagement adminManagement = new frmCarParkingAdminManagement();
                        this.Hide();
                        adminManagement.ShowDialog();
                        break;
                    default:
                        MessageBox.Show("You are not allowed to access this function!", "Error", MessageBoxButtons.OK);
                        break;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK);
                txtUsername.Focus();
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}