namespace IdealMeal_WinForms
{
    partial class DefaultForm
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
            this.flpGroceries = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this.pbCreateGrocery = new System.Windows.Forms.PictureBox();
            this.RecepiesTab = new System.Windows.Forms.TabPage();
            this.ttCreateGrocery = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblLoggedUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.flpHomeGroceries = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl.SuspendLayout();
            this.MainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreateGrocery)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpGroceries
            // 
            this.flpGroceries.AutoScroll = true;
            this.flpGroceries.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpGroceries.Location = new System.Drawing.Point(8, 681);
            this.flpGroceries.Name = "flpGroceries";
            this.flpGroceries.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpGroceries.Size = new System.Drawing.Size(1360, 228);
            this.flpGroceries.TabIndex = 0;
            this.flpGroceries.WrapContents = false;
            // 
            // toolStrip
            // 
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1384, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.MainTab);
            this.tabControl.Controls.Add(this.RecepiesTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1384, 956);
            this.tabControl.TabIndex = 2;
            // 
            // MainTab
            // 
            this.MainTab.BackColor = System.Drawing.SystemColors.Control;
            this.MainTab.Controls.Add(this.flpHomeGroceries);
            this.MainTab.Controls.Add(this.statusStrip);
            this.MainTab.Controls.Add(this.pbCreateGrocery);
            this.MainTab.Controls.Add(this.flpGroceries);
            this.MainTab.Location = new System.Drawing.Point(4, 23);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(1376, 929);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Glavna stranica";
            // 
            // pbCreateGrocery
            // 
            this.pbCreateGrocery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCreateGrocery.Image = global::IdealMeal_WinForms.Images.add;
            this.pbCreateGrocery.Location = new System.Drawing.Point(9, 658);
            this.pbCreateGrocery.Name = "pbCreateGrocery";
            this.pbCreateGrocery.Size = new System.Drawing.Size(45, 48);
            this.pbCreateGrocery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCreateGrocery.TabIndex = 1;
            this.pbCreateGrocery.TabStop = false;
            this.pbCreateGrocery.Click += new System.EventHandler(this.pbCreateGrocery_Click);
            this.pbCreateGrocery.MouseHover += new System.EventHandler(this.pbCreateGrocery_MouseHover);
            // 
            // RecepiesTab
            // 
            this.RecepiesTab.BackColor = System.Drawing.SystemColors.Control;
            this.RecepiesTab.Location = new System.Drawing.Point(4, 23);
            this.RecepiesTab.Name = "RecepiesTab";
            this.RecepiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.RecepiesTab.Size = new System.Drawing.Size(1376, 929);
            this.RecepiesTab.TabIndex = 1;
            this.RecepiesTab.Text = "Recepti";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLoggedUser});
            this.statusStrip.Location = new System.Drawing.Point(3, 904);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1370, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(60, 17);
            this.lblLoggedUser.Text = "Korisnik: ?";
            // 
            // flpHomeGroceries
            // 
            this.flpHomeGroceries.AutoScroll = true;
            this.flpHomeGroceries.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpHomeGroceries.Location = new System.Drawing.Point(8, 424);
            this.flpHomeGroceries.Name = "flpHomeGroceries";
            this.flpHomeGroceries.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpHomeGroceries.Size = new System.Drawing.Size(1360, 228);
            this.flpHomeGroceries.TabIndex = 1;
            this.flpHomeGroceries.WrapContents = false;
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 981);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1400, 1020);
            this.MinimumSize = new System.Drawing.Size(1400, 1020);
            this.Name = "DefaultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IdealMeal";
            this.Load += new System.EventHandler(this.DefaultForm_Load);
            this.tabControl.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreateGrocery)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpGroceries;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.TabPage RecepiesTab;
        private System.Windows.Forms.PictureBox pbCreateGrocery;
        private System.Windows.Forms.ToolTip ttCreateGrocery;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblLoggedUser;
        private System.Windows.Forms.FlowLayoutPanel flpHomeGroceries;
    }
}

