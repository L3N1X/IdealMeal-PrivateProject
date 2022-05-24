namespace IdealMeal_WinForms
{
    partial class GroceryControl
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbGrocery = new System.Windows.Forms.PictureBox();
            this.cmsGrocery = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toggleGroceryOption = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrocery)).BeginInit();
            this.cmsGrocery.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCalories);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.pbGrocery);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "kcal/100g";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalories.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCalories.Location = new System.Drawing.Point(26, 168);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(40, 16);
            this.lblCalories.TabIndex = 2;
            this.lblCalories.Text = "label1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(37, 150);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(115, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "GROCERYNAME";
            // 
            // pbGrocery
            // 
            this.pbGrocery.Image = global::IdealMeal_WinForms.Images.groceries;
            this.pbGrocery.Location = new System.Drawing.Point(35, 14);
            this.pbGrocery.Name = "pbGrocery";
            this.pbGrocery.Size = new System.Drawing.Size(120, 120);
            this.pbGrocery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGrocery.TabIndex = 0;
            this.pbGrocery.TabStop = false;
            // 
            // cmsGrocery
            // 
            this.cmsGrocery.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleGroceryOption});
            this.cmsGrocery.Name = "cmsGrocery";
            this.cmsGrocery.Size = new System.Drawing.Size(163, 26);
            // 
            // toggleGroceryOption
            // 
            this.toggleGroceryOption.Name = "toggleGroceryOption";
            this.toggleGroceryOption.Size = new System.Drawing.Size(162, 22);
            this.toggleGroceryOption.Text = "Dodaj namrinicu";
            this.toggleGroceryOption.Click += new System.EventHandler(this.toggleGroceryOption_Click);
            // 
            // GroceryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.cmsGrocery;
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "GroceryControl";
            this.Size = new System.Drawing.Size(200, 200);
            this.Load += new System.EventHandler(this.GroceryControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrocery)).EndInit();
            this.cmsGrocery.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbGrocery;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsGrocery;
        private System.Windows.Forms.ToolStripMenuItem toggleGroceryOption;
    }
}
