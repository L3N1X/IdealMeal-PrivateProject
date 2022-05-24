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
    public partial class CreateGroceryForm : Form
    {
        public Grocery Grocery { get; set; }
        public CreateGroceryForm()
        {
            InitializeComponent();
        }

        private void btnCreateGrocery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("Navedite naziv namirnice");
                return;
            }
            Grocery = new Grocery(
                name: this.txtName.Text.Trim(),
                description: this.txtDesription.Text.Trim(), 
                nutrition: new Nutrition
                {
                    Calories = (double)this.nudKcal.Value,
                    Fat = (double)this.nudFat.Value,
                    Carbs = (double)this.nudCarbs.Value,
                    Protein = (double)this.nudProtein.Value
                }
            );
            this.Close();
        }
    }
}
