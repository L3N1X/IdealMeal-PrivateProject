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
    public partial class AddIngridientForm : Form
    {
        public delegate void IngridientRemovedDelegate(object sender, EventArgs args);
        public event IngridientRemovedDelegate IngridientRemoved;
        public Grocery Grocery { get; set; }
        public Ingridient Ingridient { get; set; }
        public AddIngridientForm(Grocery grocery)
        {
            this.Grocery = grocery;
            InitializeComponent();
        }

        private void AddIngridientForm_Load(object sender, EventArgs e)
        {
            GroceryControl groceryControl = new GroceryControl(Grocery);
            this.Controls.Add(groceryControl);
            groceryControl.Location = new Point(0, 25);
            groceryControl.ContextMenuStrip = null;
            Tools.CenterControlInParentHorizontally(groceryControl);
        }

        private void btnAddIngridient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtAmount.Text))
            {
                MessageBox.Show("Navedite količinu");
                return;
            }
            this.Ingridient = new Ingridient(grocery: this.Grocery, amount: double.Parse(this.txtAmount.Text));
            this.Close();
        }
    }
}
