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
            Form dialog = new LoginForm(dataManager);
            var result = dialog.ShowDialog();
            if (!DialogResult.OK.Equals(result))
                Close();
            InitializeComponent();
        }

        private void DefaultForm_Load(object sender, EventArgs e)
        {
            this.lblLoggedUser.Text = $"Korisnik: {dataManager.User}";
            this.FillAndResetGroceriesPanel();
        }

        private void FillRecepiesPanel(IList<Ingridient> ingridients)
        {
            this.flpRecepies.Controls.Clear();
            this.dataManager.GetValidRecepies(ingridients).ToList().ForEach(recepie => this.flpRecepies.Controls.Add(new RecepieControl(recepie)));
        }

        private void pbCreateGrocery_MouseHover(object sender, EventArgs e)
        {
            this.ttCreateGrocery.Show("Dodaj novu namrinicu", sender as Control);
        }

        private void FillAndResetGroceriesPanel()
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
            //GroceryControl groceryControl = new GroceryControl(grocery, isHomeGrocery: true);
            //groceryControl.GroceryRemovedFromHome += GroceryControl_GroceryRemovedFromHome;
            //this.flpHomeGroceries.Controls.Add(groceryControl);

            AddIngridientForm dialog = new AddIngridientForm(grocery);
            dialog.ShowDialog();
            if (dialog.Ingridient == null)
                return;
            IngridientControl ingridientControl = new IngridientControl(dialog.Ingridient);
            ingridientControl.IngridentRemoved += IngridientControl_IngridentRemoved;
            this.flpHomeGroceries.Controls.Add(ingridientControl);
        }

        private void IngridientControl_IngridentRemoved(object sender, EventArgs args)
        {
            throw new NotImplementedException();
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
                GroceryControl groceryControl = new GroceryControl(dialog.Grocery);
                groceryControl.GroceryAddedToHome += GroceryControl_GroceryAddedToHome;
                this.flpGroceries.Controls.Add(new GroceryControl(dialog.Grocery));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainTab_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateRecepie_Click(object sender, EventArgs e)
        {
            if (this.flpHomeGroceries.Controls.Count == 0)
            {
                MessageBox.Show("Molimo vas da odaberete namirnice za recept");
                return;
            }
                
            IList<Ingridient> ingridients = new List<Ingridient>();
            foreach (var control in this.flpHomeGroceries.Controls)
                ingridients.Add(((IngridientControl)control).Ingridient);

            CreateRecepieForm dialog = new CreateRecepieForm(ingridients);
            dialog.ShowDialog();
            if (dialog.Recepie == null)
                return;
            try
            {
                dataManager.CreateRecepie(dialog.Recepie);
                this.flpHomeGroceries.Controls.Clear();
                MessageBox.Show($"Recept: {dialog.Recepie.Name} je uspješno dodan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchRecepie_Click(object sender, EventArgs e)
        {
            IList<Ingridient> ingridients = new List<Ingridient>();
            foreach (var control in this.flpHomeGroceries.Controls)
            {
                ingridients.Add(((IngridientControl)control).Ingridient);
            }
            this.FillRecepiesPanel(ingridients);
            if (this.flpRecepies.Controls.Count == 0)
                MessageBox.Show("Nismo pronašli niti jedan recept:(");
        }
    }
}
