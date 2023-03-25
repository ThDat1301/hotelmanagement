namespace GUI_Hotel
{
    partial class frmTypeRoom
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
            this.bthThoat = new System.Windows.Forms.ToolStripButton();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TypeRoom_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TypeRoom_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TypeRoom_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TypeRoom_maxCus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TypeRoom_surCharge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TypeRoom_qtyBed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTypeRoomQtyBed = new System.Windows.Forms.TextBox();
            this.txtTypeRoomSurCharge = new System.Windows.Forms.TextBox();
            this.txtTypeRoomMaxCus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTypeRoomePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTypeRoomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.bthThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(966, 42);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::GUI_Hotel.Properties.Resources.add;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(41, 39);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::GUI_Hotel.Properties.Resources.update;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(30, 39);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI_Hotel.Properties.Resources.delete;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(31, 39);
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // bthThoat
            // 
            this.bthThoat.Image = global::GUI_Hotel.Properties.Resources.exit;
            this.bthThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bthThoat.Name = "bthThoat";
            this.bthThoat.Size = new System.Drawing.Size(41, 39);
            this.bthThoat.Text = "Thoát";
            this.bthThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bthThoat.Click += new System.EventHandler(this.bthThoat_Click);
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 42);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(966, 200);
            this.gcDanhSach.TabIndex = 1;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            this.gcDanhSach.Click += new System.EventHandler(this.gcDanhSach_Click);
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TypeRoom_id,
            this.TypeRoom_name,
            this.TypeRoom_price,
            this.TypeRoom_maxCus,
            this.TypeRoom_surCharge,
            this.TypeRoom_qtyBed});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvDanhSach_RowCellClick);
            this.gvDanhSach.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDanhSach_FocusedRowChanged);
            // 
            // TypeRoom_id
            // 
            this.TypeRoom_id.Caption = "Mã loại phòng";
            this.TypeRoom_id.FieldName = "TypeRoom_id";
            this.TypeRoom_id.MinWidth = 21;
            this.TypeRoom_id.Name = "TypeRoom_id";
            this.TypeRoom_id.Visible = true;
            this.TypeRoom_id.VisibleIndex = 0;
            // 
            // TypeRoom_name
            // 
            this.TypeRoom_name.Caption = "Tên loại phòng";
            this.TypeRoom_name.FieldName = "TypeRoom_name";
            this.TypeRoom_name.MinWidth = 21;
            this.TypeRoom_name.Name = "TypeRoom_name";
            this.TypeRoom_name.Visible = true;
            this.TypeRoom_name.VisibleIndex = 1;
            // 
            // TypeRoom_price
            // 
            this.TypeRoom_price.Caption = "Giá";
            this.TypeRoom_price.FieldName = "TypeRoom_price";
            this.TypeRoom_price.Name = "TypeRoom_price";
            this.TypeRoom_price.Visible = true;
            this.TypeRoom_price.VisibleIndex = 2;
            this.TypeRoom_price.Width = 64;
            // 
            // TypeRoom_maxCus
            // 
            this.TypeRoom_maxCus.Caption = "Số khách hàng tối đa";
            this.TypeRoom_maxCus.FieldName = "TypeRoom_maxCus";
            this.TypeRoom_maxCus.Name = "TypeRoom_maxCus";
            this.TypeRoom_maxCus.Visible = true;
            this.TypeRoom_maxCus.VisibleIndex = 3;
            this.TypeRoom_maxCus.Width = 64;
            // 
            // TypeRoom_surCharge
            // 
            this.TypeRoom_surCharge.Caption = "Chi phí phụ thu";
            this.TypeRoom_surCharge.FieldName = "TypeRoom_surCharge";
            this.TypeRoom_surCharge.Name = "TypeRoom_surCharge";
            this.TypeRoom_surCharge.Visible = true;
            this.TypeRoom_surCharge.VisibleIndex = 4;
            this.TypeRoom_surCharge.Width = 64;
            // 
            // TypeRoom_qtyBed
            // 
            this.TypeRoom_qtyBed.Caption = "Số lượng giường";
            this.TypeRoom_qtyBed.FieldName = "TypeRoom_qtyBed";
            this.TypeRoom_qtyBed.Name = "TypeRoom_qtyBed";
            this.TypeRoom_qtyBed.Visible = true;
            this.TypeRoom_qtyBed.VisibleIndex = 5;
            this.TypeRoom_qtyBed.Width = 64;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTypeRoomQtyBed);
            this.groupControl1.Controls.Add(this.txtTypeRoomSurCharge);
            this.groupControl1.Controls.Add(this.txtTypeRoomMaxCus);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtTypeRoomePrice);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtTypeRoomName);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 242);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(966, 128);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // txtTypeRoomQtyBed
            // 
            this.txtTypeRoomQtyBed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeRoomQtyBed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeRoomQtyBed.Location = new System.Drawing.Point(794, 35);
            this.txtTypeRoomQtyBed.Name = "txtTypeRoomQtyBed";
            this.txtTypeRoomQtyBed.Size = new System.Drawing.Size(150, 26);
            this.txtTypeRoomQtyBed.TabIndex = 9;
            // 
            // txtTypeRoomSurCharge
            // 
            this.txtTypeRoomSurCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeRoomSurCharge.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeRoomSurCharge.Location = new System.Drawing.Point(452, 76);
            this.txtTypeRoomSurCharge.Name = "txtTypeRoomSurCharge";
            this.txtTypeRoomSurCharge.Size = new System.Drawing.Size(150, 26);
            this.txtTypeRoomSurCharge.TabIndex = 8;
            // 
            // txtTypeRoomMaxCus
            // 
            this.txtTypeRoomMaxCus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeRoomMaxCus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeRoomMaxCus.Location = new System.Drawing.Point(452, 35);
            this.txtTypeRoomMaxCus.Name = "txtTypeRoomMaxCus";
            this.txtTypeRoomMaxCus.Size = new System.Drawing.Size(150, 26);
            this.txtTypeRoomMaxCus.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(659, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng giường:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chi phí phụ thu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số khách hàng tối đa:";
            // 
            // txtTypeRoomePrice
            // 
            this.txtTypeRoomePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeRoomePrice.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeRoomePrice.Location = new System.Drawing.Point(101, 76);
            this.txtTypeRoomePrice.Name = "txtTypeRoomePrice";
            this.txtTypeRoomePrice.Size = new System.Drawing.Size(150, 26);
            this.txtTypeRoomePrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá:";
            // 
            // txtTypeRoomName
            // 
            this.txtTypeRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTypeRoomName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeRoomName.Location = new System.Drawing.Point(101, 36);
            this.txtTypeRoomName.Name = "txtTypeRoomName";
            this.txtTypeRoomName.Size = new System.Drawing.Size(150, 26);
            this.txtTypeRoomName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại phòng:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmTypeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 370);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmTypeRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoaiPhong";
            this.Load += new System.EventHandler(this.frmTypeRoom_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtTypeRoomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton bthThoat;
        private DevExpress.XtraGrid.Columns.GridColumn TypeRoom_id;
        private DevExpress.XtraGrid.Columns.GridColumn TypeRoom_name;
        private DevExpress.XtraGrid.Columns.GridColumn TypeRoom_price;
        private DevExpress.XtraGrid.Columns.GridColumn TypeRoom_maxCus;
        private DevExpress.XtraGrid.Columns.GridColumn TypeRoom_surCharge;
        private DevExpress.XtraGrid.Columns.GridColumn TypeRoom_qtyBed;
        private System.Windows.Forms.TextBox txtTypeRoomQtyBed;
        private System.Windows.Forms.TextBox txtTypeRoomSurCharge;
        private System.Windows.Forms.TextBox txtTypeRoomMaxCus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTypeRoomePrice;
        private System.Windows.Forms.Label label2;
    }
}