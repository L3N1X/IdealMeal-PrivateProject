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
            this.btnCreateRecepie = new System.Windows.Forms.Button();
            this.btnSearchRecepie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpHomeGroceries = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbCreateGrocery = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblLoggedUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.RecepiesTab = new System.Windows.Forms.TabPage();
            this.ttCreateGrocery = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreateGrocery)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpGroceries
            // 
            this.flpGroceries.AutoScroll = true;
            this.flpGroceries.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpGroceries.Location = new System.Drawing.Point(8, 558);
            this.flpGroceries.Name = "flpGroceries";
            this.flpGroceries.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpGroceries.Size = new System.Drawing.Size(1360, 249);
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
            this.tabControl.Size = new System.Drawing.Size(1384, 886);
            this.tabControl.TabIndex = 2;
            // 
            // MainTab
            // 
            this.MainTab.BackColor = System.Drawing.SystemColors.Control;
            this.MainTab.Controls.Add(this.groupBox2);
            this.MainTab.Controls.Add(this.pbCreateGrocery);
            this.MainTab.Controls.Add(this.btnCreateRecepie);
            this.MainTab.Controls.Add(this.btnSearchRecepie);
            this.MainTab.Controls.Add(this.groupBox1);
            this.MainTab.Controls.Add(this.pictureBox1);
            this.MainTab.Controls.Add(this.statusStrip);
            this.MainTab.Controls.Add(this.flpGroceries);
            this.MainTab.Location = new System.Drawing.Point(4, 23);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(1376, 859);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "Glavna stranica";
            this.MainTab.Click += new System.EventHandler(this.MainTab_Click);
            // 
            // btnCreateRecepie
            // 
            this.btnCreateRecepie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(235)))), ((int)(((byte)(118)))));
            this.btnCreateRecepie.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRecepie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateRecepie.Location = new System.Drawing.Point(1192, 436);
            this.btnCreateRecepie.Name = "btnCreateRecepie";
            this.btnCreateRecepie.Size = new System.Drawing.Size(178, 114);
            this.btnCreateRecepie.TabIndex = 6;
            this.btnCreateRecepie.Text = "Kreiraj novi recept";
            this.btnCreateRecepie.UseVisualStyleBackColor = false;
            // 
            // btnSearchRecepie
            // 
            this.btnSearchRecepie.BackColor = System.Drawing.Color.LightCoral;
            this.btnSearchRecepie.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRecepie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchRecepie.Location = new System.Drawing.Point(1192, 301);
            this.btnSearchRecepie.Name = "btnSearchRecepie";
            this.btnSearchRecepie.Size = new System.Drawing.Size(178, 111);
            this.btnSearchRecepie.TabIndex = 5;
            this.btnSearchRecepie.Text = "Traži recept";
            this.btnSearchRecepie.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpHomeGroceries);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(10, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1176, 258);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moje namrinice";
            // 
            // flpHomeGroceries
            // 
            this.flpHomeGroceries.AutoScroll = true;
            this.flpHomeGroceries.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpHomeGroceries.Location = new System.Drawing.Point(6, 37);
            this.flpHomeGroceries.Name = "flpHomeGroceries";
            this.flpHomeGroceries.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpHomeGroceries.Size = new System.Drawing.Size(1154, 209);
            this.flpHomeGroceries.TabIndex = 1;
            this.flpHomeGroceries.WrapContents = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IdealMeal_WinForms.Images.ideaMeal_logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pbCreateGrocery
            // 
            this.pbCreateGrocery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCreateGrocery.Image = global::IdealMeal_WinForms.Images.add;
            this.pbCreateGrocery.Location = new System.Drawing.Point(1303, 808);
            this.pbCreateGrocery.Name = "pbCreateGrocery";
            this.pbCreateGrocery.Size = new System.Drawing.Size(45, 48);
            this.pbCreateGrocery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCreateGrocery.TabIndex = 1;
            this.pbCreateGrocery.TabStop = false;
            this.pbCreateGrocery.Click += new System.EventHandler(this.pbCreateGrocery_Click);
            this.pbCreateGrocery.MouseHover += new System.EventHandler(this.pbCreateGrocery_MouseHover);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLoggedUser});
            this.statusStrip.Location = new System.Drawing.Point(3, 834);
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
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Location = new System.Drawing.Point(308, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1060, 277);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recepti";
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 911);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1400, 950);
            this.MinimumSize = new System.Drawing.Size(1400, 950);
            this.Name = "DefaultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IdealMeal";
            this.Load += new System.EventHandler(this.DefaultForm_Load);
            this.tabControl.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateRecepie;
        private System.Windows.Forms.Button btnSearchRecepie;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

