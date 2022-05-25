namespace IdealMeal_Lite
{
    partial class CreateGroceryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateGrocery = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudKcal = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateGrocery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKcal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateGrocery);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudKcal);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnCreateGrocery
            // 
            this.btnCreateGrocery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateGrocery.Location = new System.Drawing.Point(119, 351);
            this.btnCreateGrocery.Name = "btnCreateGrocery";
            this.btnCreateGrocery.Size = new System.Drawing.Size(45, 48);
            this.btnCreateGrocery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCreateGrocery.TabIndex = 24;
            this.btnCreateGrocery.TabStop = false;
            this.btnCreateGrocery.Click += new System.EventHandler(this.btnCreateGrocery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kalorije (kcal)";
            // 
            // nudKcal
            // 
            this.nudKcal.DecimalPlaces = 2;
            this.nudKcal.Location = new System.Drawing.Point(75, 300);
            this.nudKcal.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudKcal.Name = "nudKcal";
            this.nudKcal.Size = new System.Drawing.Size(56, 20);
            this.nudKcal.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(6, 228);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 24);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CreateGroceryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 459);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateGroceryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kreiraj novu namirnicu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateGrocery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKcal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudKcal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCreateGrocery;
    }
}