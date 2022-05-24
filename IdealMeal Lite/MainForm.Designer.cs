namespace IdealMeal_Lite
{
    partial class MainForm
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblLoggedUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flpRecepies = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateRecepie = new System.Windows.Forms.Button();
            this.btnSearchRecepie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpHomeGroceries = new System.Windows.Forms.FlowLayoutPanel();
            this.flpGroceries = new System.Windows.Forms.FlowLayoutPanel();
            this.pbCreateGrocery = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreateGrocery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLoggedUser});
            this.statusStrip.Location = new System.Drawing.Point(0, 862);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1392, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(60, 17);
            this.lblLoggedUser.Text = "Korisnik: ?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flpRecepies);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Location = new System.Drawing.Point(319, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1060, 249);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recepti";
            // 
            // flpRecepies
            // 
            this.flpRecepies.AutoScroll = true;
            this.flpRecepies.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpRecepies.Location = new System.Drawing.Point(6, 26);
            this.flpRecepies.Name = "flpRecepies";
            this.flpRecepies.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpRecepies.Size = new System.Drawing.Size(1048, 214);
            this.flpRecepies.TabIndex = 2;
            this.flpRecepies.WrapContents = false;
            // 
            // btnCreateRecepie
            // 
            this.btnCreateRecepie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(235)))), ((int)(((byte)(118)))));
            this.btnCreateRecepie.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRecepie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateRecepie.Location = new System.Drawing.Point(1201, 398);
            this.btnCreateRecepie.Name = "btnCreateRecepie";
            this.btnCreateRecepie.Size = new System.Drawing.Size(178, 123);
            this.btnCreateRecepie.TabIndex = 13;
            this.btnCreateRecepie.Text = "Kreiraj novi recept";
            this.btnCreateRecepie.UseVisualStyleBackColor = false;
            // 
            // btnSearchRecepie
            // 
            this.btnSearchRecepie.BackColor = System.Drawing.Color.LightCoral;
            this.btnSearchRecepie.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRecepie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchRecepie.Location = new System.Drawing.Point(1201, 272);
            this.btnSearchRecepie.Name = "btnSearchRecepie";
            this.btnSearchRecepie.Size = new System.Drawing.Size(178, 120);
            this.btnSearchRecepie.TabIndex = 12;
            this.btnSearchRecepie.Text = "Traži recept";
            this.btnSearchRecepie.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpHomeGroceries);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(19, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1176, 262);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moje namrinice";
            // 
            // flpHomeGroceries
            // 
            this.flpHomeGroceries.AutoScroll = true;
            this.flpHomeGroceries.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpHomeGroceries.Location = new System.Drawing.Point(6, 27);
            this.flpHomeGroceries.Name = "flpHomeGroceries";
            this.flpHomeGroceries.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpHomeGroceries.Size = new System.Drawing.Size(1154, 227);
            this.flpHomeGroceries.TabIndex = 1;
            this.flpHomeGroceries.WrapContents = false;
            // 
            // flpGroceries
            // 
            this.flpGroceries.AutoScroll = true;
            this.flpGroceries.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpGroceries.Location = new System.Drawing.Point(17, 526);
            this.flpGroceries.Name = "flpGroceries";
            this.flpGroceries.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flpGroceries.Size = new System.Drawing.Size(1360, 268);
            this.flpGroceries.TabIndex = 7;
            this.flpGroceries.WrapContents = false;
            // 
            // pbCreateGrocery
            // 
            this.pbCreateGrocery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCreateGrocery.Location = new System.Drawing.Point(1312, 799);
            this.pbCreateGrocery.Name = "pbCreateGrocery";
            this.pbCreateGrocery.Size = new System.Drawing.Size(45, 52);
            this.pbCreateGrocery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCreateGrocery.TabIndex = 8;
            this.pbCreateGrocery.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IdealMeal_Lite.Images.ideaMeal_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 884);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pbCreateGrocery);
            this.Controls.Add(this.btnCreateRecepie);
            this.Controls.Add(this.btnSearchRecepie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flpGroceries);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "IdealMeal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCreateGrocery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblLoggedUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flpRecepies;
        private System.Windows.Forms.PictureBox pbCreateGrocery;
        private System.Windows.Forms.Button btnCreateRecepie;
        private System.Windows.Forms.Button btnSearchRecepie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpHomeGroceries;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flpGroceries;
    }
}

