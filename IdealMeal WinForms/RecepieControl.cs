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
    public partial class RecepieControl : UserControl
    {
        public Recepie Recepie { get; set; }
        public RecepieControl(Recepie recepie)
        {
            this.Recepie = recepie;
            InitializeComponent();
        }

        private void RecepieControl_Load(object sender, EventArgs e)
        {
            this.lblName.Text = this.Recepie.Name;
            this.lblCalories.Text = this.Recepie.Nutrition.Calories.ToString();

            Tools.CenterControlInParentHorizontally(this.lblName);
            Tools.CenterControlInParentHorizontally(this.lblCalories);

            this.lblFat.Text = "Masnoće: " + this.Recepie.Nutrition.Fat.ToString() + "g";
            this.lblProtein.Text = "Bjelančevine: " + this.Recepie.Nutrition.Protein.ToString() + "g";
            this.lblCarbs.Text = "Ugljikohidrati: " + this.Recepie.Nutrition.Carbs.ToString() + "g";
        }
    }
}
