namespace IdealMeal_Lite
{
    partial class AddIngridientForm
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddIngridient = new System.Windows.Forms.Button();
            this.lblGroceryName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(84, 291);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(141, 32);
            this.txtAmount.TabIndex = 0;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Količina (g)";
            // 
            // btnAddIngridient
            // 
            this.btnAddIngridient.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddIngridient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddIngridient.Location = new System.Drawing.Point(84, 361);
            this.btnAddIngridient.Name = "btnAddIngridient";
            this.btnAddIngridient.Size = new System.Drawing.Size(141, 33);
            this.btnAddIngridient.TabIndex = 24;
            this.btnAddIngridient.Text = "Dodaj sastojak";
            this.btnAddIngridient.UseVisualStyleBackColor = false;
            this.btnAddIngridient.Click += new System.EventHandler(this.btnAddIngridient_Click);
            // 
            // lblGroceryName
            // 
            this.lblGroceryName.AutoSize = true;
            this.lblGroceryName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroceryName.Location = new System.Drawing.Point(105, 242);
            this.lblGroceryName.Name = "lblGroceryName";
            this.lblGroceryName.Size = new System.Drawing.Size(99, 16);
            this.lblGroceryName.TabIndex = 25;
            this.lblGroceryName.Text = "Naziv namirnice";
            // 
            // AddIngridientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(309, 415);
            this.Controls.Add(this.lblGroceryName);
            this.Controls.Add(this.btnAddIngridient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddIngridientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj sastojak";
            this.Load += new System.EventHandler(this.AddIngridientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddIngridient;
        private System.Windows.Forms.Label lblGroceryName;
    }
}