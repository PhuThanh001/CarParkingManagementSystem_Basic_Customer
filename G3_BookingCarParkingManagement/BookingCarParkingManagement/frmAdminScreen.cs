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
    public partial class frmAdminHome : Form
    {
        public UserRepository _user { get; set; }
        public frmAdminHome()
        {
            _user = new UserRepository();
            InitializeComponent();
        }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
            GetList();
        }

        public void GetList()
        {
            var listUser = _user.GetAll();
            dgvUserManagement.DataSource = listUser.Select(p => new
            {
                p.UserId,
                p.Name,
                p.Email,
                p.Password,
                p.Phone,
                p.Role,
                p.Status
            }).ToList();
        }

        private void dgvUserManagement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var UserId = dgvUserManagement.Rows[e.RowIndex].Cells[0].Value;
            if (UserId != null)
            {
                var obj = _user.GetAll().ToList().Where(p => p.UserId.Equals(UserId)).FirstOrDefault();
                if (obj != null)
                {
                    txtUserID.Text = obj.UserId.ToString();
                    txtName.Text = obj.Name;
                    txtEmail.Text = obj.Email;
                    txtPassword.Text = obj.Password;
                    txtPhone.Text = obj.Phone;
                    txtRole.Text = obj.Role.ToString();
                    txtStatus.Text = obj.Status.ToString();
                }
            }
        }
    }
}
