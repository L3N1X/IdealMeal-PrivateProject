namespace IdealMeal_Lite
{
    partial class CreateRecepieForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDesription = new System.Windows.Forms.RichTextBox();
            this.btnCreateRecepie = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbIngridients = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCarbs = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblFat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateRecepie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCreateRecepie);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 762);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDesription);
            this.groupBox2.Location = new System.Drawing.Point(10, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 135);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upute";
            // 
            // txtDesription
            // 
            this.txtDesription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesription.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesription.Location = new System.Drawing.Point(6, 20);
            this.txtDesription.Name = "txtDesription";
            this.txtDesription.Size = new System.Drawing.Size(359, 108);
            this.txtDesription.TabIndex = 2;
            this.txtDesription.Text = "";
            // 
            // btnCreateRecepie
            // 
            this.btnCreateRecepie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateRecepie.Location = new System.Drawing.Point(171, 704);
            this.btnCreateRecepie.Name = "btnCreateRecepie";
            this.btnCreateRecepie.Size = new System.Drawing.Size(45, 52);
            this.btnCreateRecepie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCreateRecepie.TabIndex = 24;
            this.btnCreateRecepie.TabStop = false;
            this.btnCreateRecepie.Click += new System.EventHandler(this.btnCreateRecepie_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(10, 239);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(371, 24);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(106, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbIngridients
            // 
            this.lbIngridients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbIngridients.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngridients.FormattingEnabled = true;
            this.lbIngridients.ItemHeight = 19;
            this.lbIngridients.Location = new System.Drawing.Point(6, 16);
            this.lbIngridients.Name = "lbIngridients";
            this.lbIngridients.Size = new System.Drawing.Size(359, 133);
            this.lbIngridients.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCarbs);
            this.panel1.Controls.Add(this.lblProtein);
            this.panel1.Controls.Add(this.lblFat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCalories);
            this.panel1.Location = new System.Drawing.Point(138, 589);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 107);
            this.panel1.TabIndex = 27;
            // 
            // lblCarbs
            // 
            this.lblCarbs.AutoSize = true;
            this.lblCarbs.Location = new System.Drawing.Point(10, 80);
            this.lblCarbs.Name = "lblCarbs";
            this.lblCarbs.Size = new System.Drawing.Size(97, 14);
            this.lblCarbs.TabIndex = 5;
            this.lblCarbs.Text = "Ugljikohidrati: 0g";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.Location = new System.Drawing.Point(10, 62);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(91, 14);
            this.lblProtein.TabIndex = 4;
            this.lblProtein.Text = "Bjelančevine: 0g";
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(10, 46);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(73, 14);
            this.lblFat.TabIndex = 3;
            this.lblFat.Text = "Masnoće: 0g";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 22);
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
            this.lblCalories.Location = new System.Drawing.Point(42, 4);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(28, 16);
            this.lblCalories.TabIndex = 2;
            this.lblCalories.Text = "000";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbIngridients);
            this.groupBox3.Location = new System.Drawing.Point(10, 408);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 174);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sastojci";
            // 
            // CreateRecepieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 788);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CreateRecepieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kreiraj novi recept";
            this.Load += new System.EventHandler(this.CreateRecepieForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateRecepie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbIngridients;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtDesription;
        private System.Windows.Forms.PictureBox btnCreateRecepie;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCarbs;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCalories;
    }
}