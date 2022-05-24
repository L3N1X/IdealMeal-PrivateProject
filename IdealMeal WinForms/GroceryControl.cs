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
        public delegate void GroceryAddedToHomeDelegate(object sender, EventArgs args);
        public event GroceryAddedToHomeDelegate GroceryAddedToHome;

        public delegate void GroceryRemovedFromHomeDelegate (object sender, EventArgs args);
        public event GroceryRemovedFromHomeDelegate GroceryRemovedFromHome;
        public bool IsHomeGrocery { get; set; } = false;
        public Grocery Grocery { get; set; }
        public GroceryControl(Grocery grocery)
        {
            this.Grocery = grocery;
            InitializeComponent();
        }

        public GroceryControl(Grocery grocery, bool isHomeGrocery)
        {
            this.Grocery = grocery;
            this.IsHomeGrocery = isHomeGrocery;
            InitializeComponent();
        }

        private void GroceryControl_Load(object sender, EventArgs e)
        {
            this.lblName.Text = Grocery.Name;

            this.lblCalories.Text = this.Grocery.Nutrition.Calories.ToString();

            Tools.CenterControlInParentHorizontally(this.lblName);
            Tools.CenterControlInParentHorizontally(this.lblCalories);

            if (File.Exists(this.Grocery.ImagePath))
                this.pbGrocery.Image = Image.FromFile(this.Grocery.ImagePath);

            if (!this.IsHomeGrocery)
                this.toggleGroceryOption.Text = $"Dodaj: {$"{this.Grocery.Name}"}";
            else
                this.toggleGroceryOption.Text = $"Ukloni: {$"{this.Grocery.Name}"}";
        }

        private void toggleGroceryOption_Click(object sender, EventArgs e)
        {
            if (this.IsHomeGrocery)
                GroceryRemovedFromHome?.Invoke(this, new EventArgs());
            else
                GroceryAddedToHome?.Invoke(this, new EventArgs());
        }
    }
}
