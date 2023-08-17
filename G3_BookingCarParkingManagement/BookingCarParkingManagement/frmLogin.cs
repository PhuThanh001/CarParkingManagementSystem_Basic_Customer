using Repository;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookingCarParkingManagement
{
    public partial class frmLogin : Form
    {
        public UserRpository _user { get; set; }
        public frmLogin()
        {
            _user = new UserRpository();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var password = txtPassword.Text;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            var passwordRegex = new Regex(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");

            var emailIsValid = emailRegex.IsMatch(email);
            var passwordIsValid = passwordRegex.IsMatch(password);

            if (!emailIsValid)
            {
                MessageBox.Show("Please enter a valid email", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!passwordIsValid)
            {
                MessageBox.Show("Password must be at least 8 characters long and include a digit, an uppercase letter, and a special character", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var user = _user.GetAll().Where(p => p.Email.Equals(email)
                            && p.Password.Equals(password))
                    .FirstOrDefault();

            if(user != null)
            {
                switch (user.Role)
                {
                    case 1: // customer
                        frmCustomerScreen customerScreen = new frmCustomerScreen();
                        this.Hide();
                        customerScreen.ShowDialog();
                        break;
                    case 2: // staff
                        frmStaffScreen staffScreen = new frmStaffScreen();
                        this.Hide();
                        staffScreen.ShowDialog();
                        break;
                    case 3: // admin
                        frmAdminScreen adminScreen = new frmAdminScreen();
                        this.Hide();
                        adminScreen.ShowDialog();
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
                txtEmail.Focus();
                return;
            }
        }
    }
}