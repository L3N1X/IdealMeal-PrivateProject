using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdealMeal_WinForms
{
    public partial class GroceryControl : UserControl
    {
        public Grocery Grocery { get; set; }
        public GroceryControl(Grocery grocery)
        {
            this.Grocery = grocery;
            InitializeComponent();
        }

        private void GroceryControl_Load(object sender, EventArgs e)
        {
            this.lblName.Text = Grocery.Name;
            this.lblCalories.Text = Grocery.Nutrition.Calories.ToString() + " kalorija";

            Tools.CenterControlInParentHorizontally(this.lblName);
            Tools.CenterControlInParentHorizontally(this.lblCalories);

            if (File.Exists(this.Grocery.ImagePath))
                this.pbGrocery.Image = Image.FromFile(this.Grocery.ImagePath);
        }
    }
}
