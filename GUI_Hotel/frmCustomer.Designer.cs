namespace GUI_Hotel
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.ToolStripButton();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Customer_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Customer_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Customer_gender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Customer_phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Customer_address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Customer_personalID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerPersonalID = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(856, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::GUI_Hotel.Properties.Resources.add;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(50, 44);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::GUI_Hotel.Properties.Resources.update;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(38, 44);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI_Hotel.Properties.Resources.delete;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 44);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::GUI_Hotel.Properties.Resources.exit;
            this.btnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(51, 44);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 47);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(856, 312);
            this.gcDanhSach.TabIndex = 1;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Customer_id,
            this.Customer_name,
            this.Customer_gender,
            this.Customer_phone,
            this.Customer_address,
            this.Customer_personalID});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsBehavior.Editable = false;
            this.gvDanhSach.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDanhSach_FocusedRowChanged);
            // 
            // Customer_id
            // 
            this.Customer_id.Caption = "Mã Khách Hàng";
            this.Customer_id.FieldName = "Customer_id";
            this.Customer_id.MinWidth = 25;
            this.Customer_id.Name = "Customer_id";
            this.Customer_id.Visible = true;
            this.Customer_id.VisibleIndex = 0;
            this.Customer_id.Width = 94;
            // 
            // Customer_name
            // 
            this.Customer_name.Caption = "Tên Khách Hàng";
            this.Customer_name.FieldName = "Customer_name";
            this.Customer_name.MinWidth = 25;
            this.Customer_name.Name = "Customer_name";
            this.Customer_name.Visible = true;
            this.Customer_name.VisibleIndex = 1;
            this.Customer_name.Width = 94;
            // 
            // Customer_gender
            // 
            this.Customer_gender.Caption = "Giới tính";
            this.Customer_gender.FieldName = "Customer_gender";
            this.Customer_gender.MinWidth = 25;
            this.Customer_gender.Name = "Customer_gender";
            this.Customer_gender.Visible = true;
            this.Customer_gender.VisibleIndex = 2;
            this.Customer_gender.Width = 94;
            // 
            // Customer_phone
            // 
            this.Customer_phone.Caption = "Điện thoại";
            this.Customer_phone.FieldName = "Customer_phone";
            this.Customer_phone.MinWidth = 25;
            this.Customer_phone.Name = "Customer_phone";
            this.Customer_phone.Visible = true;
            this.Customer_phone.VisibleIndex = 3;
            this.Customer_phone.Width = 94;
            // 
            // Customer_address
            // 
            this.Customer_address.Caption = "Địa chỉ";
            this.Customer_address.FieldName = "Customer_address";
            this.Customer_address.MinWidth = 25;
            this.Customer_address.Name = "Customer_address";
            this.Customer_address.Visible = true;
            this.Customer_address.VisibleIndex = 4;
            this.Customer_address.Width = 94;
            // 
            // Customer_personalID
            // 
            this.Customer_personalID.Caption = "Căn cước công dân";
            this.Customer_personalID.FieldName = "Customer_personalID";
            this.Customer_personalID.MinWidth = 25;
            this.Customer_personalID.Name = "Customer_personalID";
            this.Customer_personalID.Visible = true;
            this.Customer_personalID.VisibleIndex = 5;
            this.Customer_personalID.Width = 94;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Controls.Add(this.txtCustomerAddress);
            this.groupControl1.Controls.Add(this.txtCustomerPersonalID);
            this.groupControl1.Controls.Add(this.txtCustomerPhone);
            this.groupControl1.Controls.Add(this.txtCustomerName);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(0, 365);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(856, 179);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdNu);
            this.panel1.Controls.Add(this.rdNam);
            this.panel1.Location = new System.Drawing.Point(116, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 32);
            this.panel1.TabIndex = 10;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.Location = new System.Drawing.Point(63, 5);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(52, 25);
            this.rdNu.TabIndex = 4;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.Location = new System.Drawing.Point(3, 6);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(65, 25);
            this.rdNam.TabIndex = 3;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(116, 117);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(406, 23);
            this.txtCustomerAddress.TabIndex = 9;
            // 
            // txtCustomerPersonalID
            // 
            this.txtCustomerPersonalID.Location = new System.Drawing.Point(195, 146);
            this.txtCustomerPersonalID.Name = "txtCustomerPersonalID";
            this.txtCustomerPersonalID.Size = new System.Drawing.Size(327, 23);
            this.txtCustomerPersonalID.TabIndex = 8;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(406, 81);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(327, 23);
            this.txtCustomerPhone.TabIndex = 6;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(172, 50);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(327, 23);
            this.txtCustomerName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Căn cước công dân:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng:";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 543);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnThoat;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerPersonalID;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private DevExpress.XtraGrid.Columns.GridColumn Customer_id;
        private DevExpress.XtraGrid.Columns.GridColumn Customer_name;
        private DevExpress.XtraGrid.Columns.GridColumn Customer_gender;
        private DevExpress.XtraGrid.Columns.GridColumn Customer_phone;
        private DevExpress.XtraGrid.Columns.GridColumn Customer_address;
        private DevExpress.XtraGrid.Columns.GridColumn Customer_personalID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
    }
}