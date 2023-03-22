﻿using BUS_Hotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace GUI_Hotel
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {

        GalleryItem item = null;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void navMain_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string item = e.Link.ItemName;
            switch (item)
            {
                case "navItemTypeRoom":
                    frmTypeRoom frm1 = new frmTypeRoom();
                    frm1.ShowDialog();
                    break;
                case "navItemFloor":
                    frmFloor frm2 = new frmFloor();
                    frm2.ShowDialog();
                    break;
                case "navItemProduct":
                    frmProduct frm7 = new frmProduct();
                    frm7.ShowDialog();
                    break;


            }
            
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void showRoom()
        {
            var listFloor = FloorBUS.listFloor();
            gControl.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            gControl.Gallery.ImageSize = new Size(64, 64);
            gControl.Gallery.ShowItemText = true;
            gControl.Gallery.ShowGroupCaption = true;
            
            foreach(var f in listFloor)
            { 
                var galleryItem = new GalleryItemGroup();
                galleryItem.Caption = f.Floor_name;
                galleryItem.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;

                var listRoom = RoomBUS.listRoomByFloor(f.Floor_id);
                foreach(var r in listRoom)
                {
                    var gcItem = new GalleryItem();
                    gcItem.Caption = r.Room_num;
                    gcItem.Value = r.Room_id;
                    if (r.Room_status)                   
                        gcItem.ImageOptions.Image = imageList1.Images[0];
                    else gcItem.ImageOptions.Image = imageList1.Images[1];



                    galleryItem.Items.Add(gcItem);
                }

                gControl.Gallery.Groups.Add(galleryItem);

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showRoom();
        }

        private void popupMenu1_Popup(object sender, EventArgs e)
        {
            Point point = gControl.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = gControl.CalcHitInfo(point);
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
                item = hitInfo.GalleryItem; 
        }

        private void btnMakeOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var gc_item = new GalleryItem();
            string id = item.Value.ToString();
            MessageBox.Show(id);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainerControl1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
