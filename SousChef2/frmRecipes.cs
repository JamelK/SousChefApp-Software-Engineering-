using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SousChef2
{
    public partial class frmRecipes : Form
    {
        public frmRecipes()
        {
            InitializeComponent();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            var counter = 0;

            for (int i = 0; i < this.lboxRecipes.Items.Count; i++)
            {
                var item = this.lboxRecipes.Items[i];
                if (lboxRecipes.Items[i].ToString().ToLower().Contains(txtRecipeSearch.Text.ToLower()))
                {
                    this.lboxRecipes.SelectedItems.Add(item);
                    counter++;
                }
            }

            if (counter == 0)
            {
                MessageBox.Show($"No matches for \"{this.txtRecipeSearch.Text}\" found!", "Search Results",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"{counter} items found for \"{this.txtRecipeSearch.Text}\"!", "Search Results",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lboxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display selected recipe to search
            lblrecpieSelection.Text = lboxRecipes.SelectedItem.ToString();
            //display selected recipe to search
            lblNutrInfo.Text = lboxRecipes.SelectedItem.ToString();

        }

        private void recipesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            if (txtboxaddrcp.Text != "")
            {
                this.Validate();
                this.recipesBindingSource.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.recipeDataSet);

                MessageBox.Show("Saved!");
            }
            else
            {
                MessageBox.Show("Error: All fields must be filled in.");
            }
            bindingNavigatorAddNewItem.PerformClick();
        }

        private void frmRecipes_Load(object sender, EventArgs e)
        {

            lboxRecipes.Items.Clear();
            lboxFridgePantry.Items.Clear();

            // TODO: This line of code loads data into the 'foodListDataSet.Food_List' table. You can move, or remove it, as needed.
            this.food_ListTableAdapter.Fill(this.foodListDataSet.Food_List);
            // TODO: This line of code loads data into the 'recipeDataSet.Recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.recipeDataSet.Recipes);

            this.recipesBindingNavigator.Visible = false;
            this.lblrecpieSelection.Visible = false;

            bindingNavigatorAddNewItem.PerformClick();
            // bindingNavigatorAddNewItem.PerformClick();
            this.lblNutrInfo.Visible = false;
            fillListBox();
            fillListBox2();

        }

        private void fillListBox()
        {
            try
            {
                this.recipesTableAdapter.FillBy(this.recipeDataSet.Recipes);
            }
            catch { }

            int rowCount = int.Parse(this.recipeDataSet.Tables["Recipes"].Rows.Count.ToString());

            for (int i = 0; i < rowCount; i++)
            {
                lboxRecipes.Items.Add(this.recipeDataSet.Tables["Recipes"].Rows[i]["Recipes"].ToString());
            }
        }

        private void fillListBox2()
        {
            try
            {
                this.food_ListTableAdapter.Fill(this.foodListDataSet.Food_List);
            }
            catch { }

            int rowCount = int.Parse(this.foodListDataSet.Tables["Food List"].Rows.Count.ToString());

            for (int i = 0; i < rowCount; i++)
            {
                lboxFridgePantry.Items.Add(this.foodListDataSet.Tables["Food List"].Rows[i]["Item Name"].ToString());
            }
        }

        private void lblFridgePantry_Click(object sender, EventArgs e)
        {

        }

        private void viewRecipeBtn_Click(object sender, EventArgs e)
        {
            if (lblrecpieSelection.Text.Length > 0)
            {
                System.Diagnostics.Process.Start("https://www.food.com/search/" + lblrecpieSelection.Text);

            }
        }

        private void removeRcpBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.recipesTableAdapter.DeleteQuery(lboxRecipes.SelectedItem.ToString());

                lboxRecipes.Items.Clear();

                fillListBox();
            }
            catch { }
        }

        private void addRecipebtn_Click(object sender, EventArgs e)
        {
            recipesBindingNavigatorSaveItem.PerformClick();
          


            try
            {
                this.recipesTableAdapter.InsertQuery(txtboxaddrcp.Text.ToString());

                lboxRecipes.Items.Clear();

                fillListBox();
            }
            catch { }
            txtboxaddrcp.Clear();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
       
        }

        private void addRecipetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lboxFridgePantry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display selected ingredient to search
            lblNutrInfo.Text = lboxFridgePantry.SelectedItem.ToString();
            //display selected ingredient to search
            lblrecpieSelection.Text = lboxFridgePantry.SelectedItem.ToString();
        }

        private void NIbtn_Click(object sender, EventArgs e)
        {
            if (lblNutrInfo.Text.Length > 0)
            {
                System.Diagnostics.Process.Start("https://fdc.nal.usda.gov/fdc-app.html#/?query=" + lblNutrInfo.Text);
            }
        }

        private void lblrecpieSelection_Click(object sender, EventArgs e)
        {

        }

        private void txtRecipeSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}