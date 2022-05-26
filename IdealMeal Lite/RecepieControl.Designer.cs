namespace IdealMeal_Lite
{
    partial class RecepieControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pbRecepie = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecepie)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.pbRecepie);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(171, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 149);
            this.panel1.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(34, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(115, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "RECEPIE NAME";
            // 
            // pbRecepie
            // 
            this.pbRecepie.Location = new System.Drawing.Point(14, 20);
            this.pbRecepie.Name = "pbRecepie";
            this.pbRecepie.Size = new System.Drawing.Size(150, 150);
            this.pbRecepie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRecepie.TabIndex = 0;
            this.pbRecepie.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCarbs);
            this.panel2.Controls.Add(this.lblProtein);
            this.panel2.Controls.Add(this.lblFat);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblCalories);
            this.panel2.Location = new System.Drawing.Point(33, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 113);
            this.panel2.TabIndex = 3;
            // 
            // lblCarbs
            // 
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Location = new System.Drawing.Point(10, 90);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(97, 14);
            this.lblCarbs.TabIndex = 5;
            this.lblCarbs.Text = "Ugljikohidrati: 0g";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Location = new System.Drawing.Point(10, 74);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(91, 14);
            this.lblProtein.TabIndex = 4;
            this.lblProtein.Text = "Bjelančevine: 0g";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(10, 59);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(73, 14);
            this.lblFat.TabIndex = 3;
            this.lblFat.Text = "Masnoće: 0g";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "kcal";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalories.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCalories.Location = new System.Drawing.Point(42, 20);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(28, 16);
            this.lblCalories.TabIndex = 2;
            this.lblCalories.Text = "000";
            // 
            // RecepieControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RecepieControl";
            this.Size = new System.Drawing.Size(360, 190);
            this.Load += new System.EventHandler(this.RecepieControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecepie)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbRecepie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCalories;
    }
}
