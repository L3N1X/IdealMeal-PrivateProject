namespace IdealMeal_WinForms
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudProtein = new System.Windows.Forms.NumericUpDown();
            this.nudCarbs = new System.Windows.Forms.NumericUpDown();
            this.nudFat = new System.Windows.Forms.NumericUpDown();
            this.nudKcal = new System.Windows.Forms.NumericUpDown();
            this.txtDesription = new System.Windows.Forms.RichTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreateGrocery = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKcal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateGrocery)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCreateGrocery);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudProtein);
            this.groupBox1.Controls.Add(this.nudCarbs);
            this.groupBox1.Controls.Add(this.nudFat);
            this.groupBox1.Controls.Add(this.nudKcal);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Protein (g)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Uglijkohidrati (g)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mast (g)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kalorije (kcal)";
            // 
            // nudProtein
            // 
            this.nudProtein.DecimalPlaces = 2;
            this.nudProtein.Location = new System.Drawing.Point(97, 420);
            this.nudProtein.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudProtein.Name = "nudProtein";
            this.nudProtein.Size = new System.Drawing.Size(56, 20);
            this.nudProtein.TabIndex = 6;
            // 
            // nudCarbs
            // 
            this.nudCarbs.DecimalPlaces = 2;
            this.nudCarbs.Location = new System.Drawing.Point(97, 394);
            this.nudCarbs.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudCarbs.Name = "nudCarbs";
            this.nudCarbs.Size = new System.Drawing.Size(56, 20);
            this.nudCarbs.TabIndex = 5;
            // 
            // nudFat
            // 
            this.nudFat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudFat.DecimalPlaces = 2;
            this.nudFat.Location = new System.Drawing.Point(97, 368);
            this.nudFat.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudFat.Name = "nudFat";
            this.nudFat.Size = new System.Drawing.Size(56, 20);
            this.nudFat.TabIndex = 4;
            // 
            // nudKcal
            // 
            this.nudKcal.DecimalPlaces = 2;
            this.nudKcal.Location = new System.Drawing.Point(97, 342);
            this.nudKcal.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudKcal.Name = "nudKcal";
            this.nudKcal.Size = new System.Drawing.Size(56, 20);
            this.nudKcal.TabIndex = 3;
            // 
            // txtDesription
            // 
            this.txtDesription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesription.Location = new System.Drawing.Point(6, 19);
            this.txtDesription.Name = "txtDesription";
            this.txtDesription.Size = new System.Drawing.Size(307, 56);
            this.txtDesription.TabIndex = 2;
            this.txtDesription.Text = "";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(10, 222);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(319, 24);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IdealMeal_WinForms.Images.groceries;
            this.pictureBox1.Location = new System.Drawing.Point(82, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCreateGrocery
            // 
            this.btnCreateGrocery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateGrocery.Image = global::IdealMeal_WinForms.Images.add;
            this.btnCreateGrocery.Location = new System.Drawing.Point(147, 449);
            this.btnCreateGrocery.Name = "btnCreateGrocery";
            this.btnCreateGrocery.Size = new System.Drawing.Size(45, 48);
            this.btnCreateGrocery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCreateGrocery.TabIndex = 24;
            this.btnCreateGrocery.TabStop = false;
            this.btnCreateGrocery.Click += new System.EventHandler(this.btnCreateGrocery_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDesription);
            this.groupBox2.Location = new System.Drawing.Point(10, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 87);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kratak opis";
            // 
            // CreateGroceryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 527);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateGroceryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kreiraj novu namirnicu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKcal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateGrocery)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudProtein;
        private System.Windows.Forms.NumericUpDown nudCarbs;
        private System.Windows.Forms.NumericUpDown nudFat;
        private System.Windows.Forms.NumericUpDown nudKcal;
        private System.Windows.Forms.RichTextBox txtDesription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnCreateGrocery;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}