﻿namespace GUI_Hotel
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSystem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navMain = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navItemTypeRoom = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemFloor = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemRoom = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemEmployee = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemOrder = new DevExpress.XtraNavBar.NavBarItem();
            this.navItemProduct = new DevExpress.XtraNavBar.NavBarItem();
            this.gControl = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnMakeOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdateOrder = new DevExpress.XtraBars.BarButtonItem();
            this.btnPay = new DevExpress.XtraBars.BarButtonItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl)).BeginInit();
            this.gControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSystem,
            this.toolStripSeparator1,
            this.btnReport,
            this.toolStripSeparator2,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1278, 60);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSystem
            // 
            this.btnSystem.Image = global::GUI_Hotel.Properties.Resources.system;
            this.btnSystem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(78, 57);
            this.btnSystem.Text = "Hệ thống";
            this.btnSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSystem.Click += new System.EventHandler(this.btnSystem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 60);
            // 
            // btnReport
            // 
            this.btnReport.Image = global::GUI_Hotel.Properties.Resources.chart;
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(68, 57);
            this.btnReport.Text = "Báo cáo";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 60);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::GUI_Hotel.Properties.Resources.exit;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 57);
            this.btnExit.Text = "Thoát";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 60);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.navMain);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1278, 628);
            this.splitContainerControl1.SplitterPosition = 216;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // navMain
            // 
            this.navMain.ActiveGroup = this.navBarGroup1;
            this.navMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navMain.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navMain.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navItemTypeRoom,
            this.navItemFloor,
            this.navItemRoom,
            this.navItemEmployee,
            this.navItemCustomer,
            this.navItemOrder,
            this.navItemProduct});
            this.navMain.Location = new System.Drawing.Point(0, 0);
            this.navMain.Name = "navMain";
            this.navMain.OptionsNavPane.ExpandedWidth = 216;
            this.navMain.Size = new System.Drawing.Size(216, 628);
            this.navMain.TabIndex = 0;
            this.navMain.Text = "Chức năng";
            this.navMain.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navMain_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Chức năng";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarGroup1.ImageOptions.SvgImage")));
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemTypeRoom),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemFloor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemRoom),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemEmployee),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemOrder),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navItemProduct)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navItemTypeRoom
            // 
            this.navItemTypeRoom.Caption = "Quản lý Loại phòng";
            this.navItemTypeRoom.Name = "navItemTypeRoom";
            // 
            // navItemFloor
            // 
            this.navItemFloor.Caption = "Quản lý Tầng";
            this.navItemFloor.Name = "navItemFloor";
            // 
            // navItemRoom
            // 
            this.navItemRoom.Caption = "Quản lý Phòng";
            this.navItemRoom.Name = "navItemRoom";
            // 
            // navItemEmployee
            // 
            this.navItemEmployee.Caption = "Quản lý Nhân viên";
            this.navItemEmployee.Name = "navItemEmployee";
            // 
            // navItemCustomer
            // 
            this.navItemCustomer.Caption = "Quản lý Khách hàng";
            this.navItemCustomer.Name = "navItemCustomer";
            // 
            // navItemOrder
            // 
            this.navItemOrder.Caption = "Quản lý Đặt phòng";
            this.navItemOrder.Name = "navItemOrder";
            // 
            // navItemProduct
            // 
            this.navItemProduct.Caption = "Quản lý Dịch vụ";
            this.navItemProduct.Name = "navItemProduct";
            // 
            // gControl
            // 
            this.gControl.Controls.Add(this.galleryControlClient1);
            this.gControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gControl.Location = new System.Drawing.Point(0, 0);
            this.gControl.Name = "gControl";
            this.barManager1.SetPopupContextMenu(this.gControl, this.popupMenu1);
            this.gControl.Size = new System.Drawing.Size(1052, 628);
            this.gControl.TabIndex = 0;
            this.gControl.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.gControl;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(1031, 624);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "room1.png");
            this.imageList1.Images.SetKeyName(1, "room0.png");
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMakeOrder),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdateOrder),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPay)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            this.popupMenu1.Popup += new System.EventHandler(this.popupMenu1_Popup);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnMakeOrder,
            this.btnUpdateOrder,
            this.btnPay});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1278, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 688);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1278, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 688);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1278, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 688);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Caption = "Đặt phòng";
            this.btnMakeOrder.Id = 0;
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMakeOrder_ItemClick);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Caption = "Cập nhật";
            this.btnUpdateOrder.Id = 1;
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            // 
            // btnPay
            // 
            this.btnPay.Caption = "Thanh toán";
            this.btnPay.Id = 2;
            this.btnPay.Name = "btnPay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 688);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gControl)).EndInit();
            this.gControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSystem;
        private System.Windows.Forms.ToolStripButton btnReport;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navMain;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navItemTypeRoom;
        private DevExpress.XtraNavBar.NavBarItem navItemFloor;
        private DevExpress.XtraNavBar.NavBarItem navItemRoom;
        private DevExpress.XtraNavBar.NavBarItem navItemEmployee;
        private DevExpress.XtraNavBar.NavBarItem navItemCustomer;
        private DevExpress.XtraNavBar.NavBarItem navItemOrder;
        private DevExpress.XtraNavBar.NavBarItem navItemProduct;
        private DevExpress.XtraBars.Ribbon.GalleryControl gControl;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnMakeOrder;
        private DevExpress.XtraBars.BarButtonItem btnUpdateOrder;
        private DevExpress.XtraBars.BarButtonItem btnPay;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
    }
}

