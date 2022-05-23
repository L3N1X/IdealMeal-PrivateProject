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
            this.RecepiesTab = new System.Windows.Forms.TabPage();
            this.pbCreateGrocery = new System.Windows.Forms.PictureBox();
            this.ttCreateGrocery = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl.SuspendLayout();
            this.MainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCreateGrocery)).BeginInit();
            this.SuspendLayout();
            // 
            // flpGroceries
            // 
            this.flpGroceries.Location = new System.Drawing.Point(8, 649);
            this.flpGroceries.Name = "flpGroceries";
            this.flpGroceries.Size = new System.Drawing.Size(1360, 203);
            this.flpGroceries.TabIndex = 0;
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
            this.MainTab.Controls.Add(this.pbCreateGrocery);
            this.MainTab.Controls.Add(this.flpGroceries);
            this.MainTab.Location = new System.Drawing.Point(4, 22);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(1376, 860);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "tabPage1";
            this.MainTab.UseVisualStyleBackColor = true;
            // 
            // RecepiesTab
            // 
            this.RecepiesTab.Location = new System.Drawing.Point(4, 22);
            this.RecepiesTab.Name = "RecepiesTab";
            this.RecepiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.RecepiesTab.Size = new System.Drawing.Size(1376, 860);
            this.RecepiesTab.TabIndex = 1;
            this.RecepiesTab.Text = "tabPage2";
            this.RecepiesTab.UseVisualStyleBackColor = true;
            // 
            // pbCreateGrocery
            // 
            this.pbCreateGrocery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCreateGrocery.Image = global::IdealMeal_WinForms.Images.add;
            this.pbCreateGrocery.Location = new System.Drawing.Point(5, 602);
            this.pbCreateGrocery.Name = "pbCreateGrocery";
            this.pbCreateGrocery.Size = new System.Drawing.Size(45, 45);
            this.pbCreateGrocery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCreateGrocery.TabIndex = 1;
            this.pbCreateGrocery.TabStop = false;
            this.pbCreateGrocery.MouseHover += new System.EventHandler(this.pbCreateGrocery_MouseHover);
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 911);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip);
            this.MaximumSize = new System.Drawing.Size(1400, 950);
            this.MinimumSize = new System.Drawing.Size(1400, 950);
            this.Name = "DefaultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IdealMeal";
            this.Load += new System.EventHandler(this.DefaultForm_Load);
            this.tabControl.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCreateGrocery)).EndInit();
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
    }
}

