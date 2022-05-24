using DataLayer;
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
    public partial class DefaultForm : Form
    {
        private DataManager dataManager;
        public DefaultForm()
        {
            try
            {
                this.dataManager = new DataManager();    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
            //Form dialog = new LoginForm(dataManager);
            //var result = dialog.ShowDialog();
            //if (!DialogResult.OK.Equals(result))
            //    Close();
            InitializeComponent();
        }

        private void DefaultForm_Load(object sender, EventArgs e)
        {
            this.lblLoggedUser.Text = $"Korisnik: {dataManager.User}";
            this.ResetGroceriesPanel();
        }

        private void pbCreateGrocery_MouseHover(object sender, EventArgs e)
        {
            this.ttCreateGrocery.Show("Dodaj novu namrinicu", sender as Control);
        }

        private void ResetGroceriesPanel()
        {
            this.flpGroceries.Controls.Clear();
            dataManager.GetGroceries().ToList().ForEach(grocery => 
            {
                GroceryControl groceryControl = new GroceryControl(grocery);
                groceryControl.GroceryAddedToHome += GroceryControl_GroceryAddedToHome;
                groceryControl.GroceryRemovedFromHome += GroceryControl_GroceryRemovedFromHome;
                this.flpGroceries.Controls.Add(groceryControl);

            });
        }

        private void GroceryControl_GroceryRemovedFromHome(object sender, EventArgs args)
        {
            this.flpHomeGroceries.Controls.Remove(((Control)sender));
        }

        private void GroceryControl_GroceryAddedToHome(object sender, EventArgs args)
        {
            Grocery grocery = ((GroceryControl)sender).Grocery;
            GroceryControl groceryControl = new GroceryControl(grocery, isHomeGrocery: true);
            groceryControl.GroceryRemovedFromHome += GroceryControl_GroceryRemovedFromHome;
            this.flpHomeGroceries.Controls.Add(groceryControl);
        }

        private void pbCreateGrocery_Click(object sender, EventArgs e)
        {
            CreateGroceryForm dialog = new CreateGroceryForm();
            dialog.ShowDialog();
            if(dialog.Grocery == null)
                return;
            try
            {
                dataManager.CreateGrocery(dialog.Grocery);
                this.ResetGroceriesPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
