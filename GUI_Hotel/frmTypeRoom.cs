using BUS_Hotel;
using DAL_Hotel;
using DevExpress.XtraEditors;
using DTO_Hotel;
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
        TypeRoomBUS busTypeRoom = new TypeRoomBUS();
        public frmTypeRoom()
        {
            InitializeComponent();
        }


        private void frmTypeRoom_Load(object sender, EventArgs e)
        {
            loadData();
            showHideControl(true);
        }

        private void bthThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadData()
        {
            gcDanhSach.DataSource = busTypeRoom.getTypeRoom();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            showHideControl(true);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            showHideControl(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            showHideControl(false);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            showHideControl(false);
            if (txtTypeRoomName.Text.Trim() != "")
            {
                DTO_TypeRoom tr = new DTO_TypeRoom(txtTypeRoomName.Text);
                if (busTypeRoom.addTypeRoom(tr))
                {
                    MessageBox.Show("Thêm thành công");
                    loadData();
                }
                else MessageBox.Show("Thêm không thành công");

            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            

        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {

        }

        void showHideControl(bool b)
        {
            btnThem.Visible= b;
            btnXoa.Visible = b;
            btnSua.Visible = b;
            bthThoat.Visible = b;
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            showHideControl(true);
        }
    }
}