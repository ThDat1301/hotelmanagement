﻿namespace GUI_Hotel
{
    partial class frmFloor
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
            this.checkButton1 = new DevExpress.XtraEditors.CheckButton();
            this.SuspendLayout();
            // 
            // checkButton1
            // 
            this.checkButton1.Location = new System.Drawing.Point(144, 62);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(75, 23);
            this.checkButton1.TabIndex = 0;
            this.checkButton1.Text = "checkButton1";
            // 
            // frmFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 430);
            this.Controls.Add(this.checkButton1);
            this.Name = "frmFloor";
            this.Text = "frmTang";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckButton checkButton1;
    }
}