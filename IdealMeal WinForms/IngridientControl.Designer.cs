namespace IdealMeal_WinForms
{
    partial class IngridientControl
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
            this.pbGrocery = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGrocery = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrocery)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pbGrocery
            // 
            this.pbGrocery.Image = global::IdealMeal_WinForms.Images.groceries;
            this.pbGrocery.Location = new System.Drawing.Point(20, 18);
            this.pbGrocery.Name = "pbGrocery";
            this.pbGrocery.Size = new System.Drawing.Size(120, 129);
            this.pbGrocery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGrocery.TabIndex = 0;
            this.pbGrocery.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblGrocery);
            this.groupBox2.Controls.Add(this.pbGrocery);
            this.groupBox2.Location = new System.Drawing.Point(6, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblGrocery
            // 
            this.lblGrocery.AutoSize = true;
            this.lblGrocery.Location = new System.Drawing.Point(37, 155);
            this.lblGrocery.Name = "lblGrocery";
            this.lblGrocery.Size = new System.Drawing.Size(87, 14);
            this.lblGrocery.TabIndex = 1;
            this.lblGrocery.Text = "GROCERYNAME";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCarbs);
            this.panel1.Controls.Add(this.lblProtein);
            this.panel1.Controls.Add(this.lblFat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCalories);
            this.panel1.Controls.Add(this.lblAmount);
            this.panel1.Location = new System.Drawing.Point(178, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 162);
            this.panel1.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(30, 38);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(53, 19);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "0.00 g";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalories.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCalories.Location = new System.Drawing.Point(42, 68);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(28, 16);
            this.lblCalories.TabIndex = 2;
            this.lblCalories.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "kcal";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(10, 107);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(73, 14);
            this.lblFat.TabIndex = 3;
            this.lblFat.Text = "Masnoće: 0g";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Location = new System.Drawing.Point(10, 122);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(91, 14);
            this.lblProtein.TabIndex = 4;
            this.lblProtein.Text = "Bjelančevine: 0g";
            // 
            // lblCarbs
            // 
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Location = new System.Drawing.Point(10, 138);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(97, 14);
            this.lblCarbs.TabIndex = 5;
            this.lblCarbs.Text = "Ugljikohidrati: 0g";
            // 
            // IngridientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "IngridientControl";
            this.Size = new System.Drawing.Size(300, 200);
            this.Load += new System.EventHandler(this.IngridientControl_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGrocery)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbGrocery;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblGrocery;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label label1;
    }
}
