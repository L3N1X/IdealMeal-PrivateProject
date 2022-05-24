using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdealMeal_WinForms
{
    public partial class IngridientControl : UserControl
    {
        public delegate void IngridientRemovedDelegate(object sender, EventArgs args);
        public event IngridientRemovedDelegate IngridentRemoved;
        public Ingridient Ingridient { get; set; }
        public IngridientControl(Ingridient ingridient)
        {
            this.Ingridient = ingridient;
            InitializeComponent();
        }
        private void IngridientControl_Load(object sender, EventArgs e)
        {
            this.lblGrocery.Text = Ingridient.Grocery.Name;
            this.lblAmount.Text = Ingridient.Amount.ToString() + "g";
            this.lblCalories.Text = Ingridient.Nutrition.Calories.ToString();

            Tools.CenterControlInParentHorizontally(this.lblGrocery);
            Tools.CenterControlInParentHorizontally(this.lblAmount);
            Tools.CenterControlInParentHorizontally(this.lblCalories);

            this.lblFat.Text = this.Ingridient.Nutrition.Fat.ToString() + "g";
            this.lblProtein.Text = this.Ingridient.Nutrition.Protein.ToString() + "g";
            this.lblCarbs.Text = this.Ingridient.Nutrition.Carbs.ToString() + "g";
        }
    }
}
