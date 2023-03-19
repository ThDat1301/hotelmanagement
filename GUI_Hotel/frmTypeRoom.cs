using BUS_Hotel;
using DAL_Hotel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Hotel
{
    public partial class frmTypeRoom : DevExpress.XtraEditors.XtraForm
    {
        public frmTypeRoom()
        {
            InitializeComponent();
        }



        private void frmTypeRoom_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void bthThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadData()
        {
            gcDanhSach.DataSource = TypeRoomBUS.listTypeRoom();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {

        }
    }
}