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
using DTO_Hotel;
using DAL_Hotel;
using BUS_Hotel;

namespace GUI_Hotel
{
    
    public partial class frmOrder : DevExpress.XtraEditors.XtraForm
    {
        CustomerBUS bus_customer = new CustomerBUS();
        ProductBUS bus_product = new ProductBUS();
        public frmOrder()
        {
            InitializeComponent();
            string sql = "SELECT r.id, r.num, f.id, f.name, tr.price FROM Room r, TypeRoom tr, Floor f WHERE r.floorId = f.id AND r.typeRoomId = tr.id";
            DataTable tb = Functions.getData(sql);
            gcPhong.DataSource = tb;
            gcPhongDat.DataSource = tb.Clone();
            gvPhong.OptionsBehavior.Editable = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tabDanhSach.SelectedTabPage = pageOrderDetails;
            reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tabDanhSach.SelectedTabPage = pageOrderDetails;
            reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void bthThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tabDanhSach.SelectedTabPage = pageOrders;

        }

        void reset()
        {
            dpCheckin.Value = DateTime.Now;
            dpCheckout.Value = DateTime.Now.AddDays(1);
            txtNumCus.Text = "1";
            chkIsGroup.Checked = true;
            cbStatus.SelectedValue = false;
            txtNote.Text = "";
            txtTotalAmount.Text = "0";
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            reset();
            dpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dpTo.Value = DateTime.Now;
            loadCbCus();
            loadGcProduct();
            cbStatus.DataSource = OrderStatus.getList();
            cbStatus.DisplayMember = "name";
            cbStatus.ValueMember = "value";
        }

        void loadCbCus()
        {
            cbCustomer.DataSource = bus_customer.getCustmer();
            cbCustomer.DisplayMember = "Customer_name";
            cbCustomer.ValueMember = "Customer_id";
        }

        void loadGcProduct()
        {
            gcSanPham.DataSource = bus_product.getProducts();
            gvSanPham.OptionsBehavior.Editable = false;
        }
    }
}