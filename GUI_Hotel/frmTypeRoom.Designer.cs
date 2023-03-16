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
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.SuspendLayout();
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Location = new System.Drawing.Point(106, 94);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(135, 23);
            this.dropDownButton1.TabIndex = 0;
            this.dropDownButton1.Text = "dropDownButton1";
            // 
            // frmTypeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 438);
            this.Controls.Add(this.dropDownButton1);
            this.Name = "frmTypeRoom";
            this.Text = "frmLoaiPhong";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
    }
}