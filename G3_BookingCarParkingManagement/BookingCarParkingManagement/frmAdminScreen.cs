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
        public BaixeRepository _baixe { get; set; }
        public SlotxeRepository _slotxe { get; set; }
        public frmAdminHome()
        {
            _baixe = new BaixeRepository();
            _slotxe = new SlotxeRepository();
            InitializeComponent();
        }

        private void dgvBaiXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void frmAdminHome_Load(object sender, EventArgs e)
        {
            GetList();
        }*/
        public void GetCarCountByBaixeId(int id)
        {

        }

       /* public void GetList()
        {
            //var listBaixe = _baixe.GetAll();
            var slotxeIds = _slotxe.GetAll().Select(s => s.SlotxeId).ToList();
            dgvBaiXe.DataSource = listBaixe.Select(p => new
            {
                p.BaixeId,
                p.TotalSlot,
                p.AvailableSlot
            }).ToList();
        }*/
    }
}
