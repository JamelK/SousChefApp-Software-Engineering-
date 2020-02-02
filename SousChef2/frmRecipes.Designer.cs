namespace SousChef2
{
    partial class frmRecipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipes));
            this.lboxRecipes = new System.Windows.Forms.ListBox();
            this.lboxFridgePantry = new System.Windows.Forms.ListBox();
            this.txtRecipeSearch = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.recipesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recipeDataSet = new SousChef2.RecipeDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recipesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.viewRecipeBtn = new System.Windows.Forms.Button();
            this.lblrecpieSelection = new System.Windows.Forms.Label();
            this.removeRcpBtn = new System.Windows.Forms.Button();
            this.foodListDataSet = new SousChef2.foodListDataSet();
            this.food_ListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.food_ListTableAdapter = new SousChef2.foodListDataSetTableAdapters.Food_ListTableAdapter();
            this.tableAdapterManager = new SousChef2.foodListDataSetTableAdapters.TableAdapterManager();
            this.recipesTableAdapter = new SousChef2.RecipeDataSetTableAdapters.RecipesTableAdapter();
            this.tableAdapterManager1 = new SousChef2.RecipeDataSetTableAdapters.TableAdapterManager();
            this.addRecipebtn = new System.Windows.Forms.Button();
            this.txtboxaddrcp = new System.Windows.Forms.TextBox();
            this.NIbtn = new System.Windows.Forms.Button();
            this.lblNutrInfo = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingNavigator)).BeginInit();
            this.recipesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_ListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxRecipes
            // 
            this.lboxRecipes.FormattingEnabled = true;
            this.lboxRecipes.Location = new System.Drawing.Point(240, 103);
            this.lboxRecipes.Name = "lboxRecipes";
            this.lboxRecipes.Size = new System.Drawing.Size(327, 342);
            this.lboxRecipes.TabIndex = 1;
            this.lboxRecipes.SelectedIndexChanged += new System.EventHandler(this.lboxRecipes_SelectedIndexChanged);
            // 
            // lboxFridgePantry
            // 
            this.lboxFridgePantry.FormattingEnabled = true;
            this.lboxFridgePantry.Location = new System.Drawing.Point(31, 285);
            this.lboxFridgePantry.Name = "lboxFridgePantry";
            this.lboxFridgePantry.Size = new System.Drawing.Size(203, 160);
            this.lboxFridgePantry.TabIndex = 2;
            this.lboxFridgePantry.SelectedIndexChanged += new System.EventHandler(this.lboxFridgePantry_SelectedIndexChanged);
            // 
            // txtRecipeSearch
            // 
            this.txtRecipeSearch.Location = new System.Drawing.Point(575, 363);
            this.txtRecipeSearch.Name = "txtRecipeSearch";
            this.txtRecipeSearch.Size = new System.Drawing.Size(150, 20);
            this.txtRecipeSearch.TabIndex = 5;
            this.txtRecipeSearch.TextChanged += new System.EventHandler(this.txtRecipeSearch_TextChanged);
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFood.Location = new System.Drawing.Point(575, 389);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(150, 50);
            this.btnSearchFood.TabIndex = 6;
            this.btnSearchFood.Text = "Search";
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Location = new System.Drawing.Point(240, 81);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(46, 13);
            this.lblRecipes.TabIndex = 7;
            this.lblRecipes.Text = "Recipes";
            // 
            // recipesBindingNavigator
            // 
            this.recipesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.recipesBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recipesBindingNavigator.BindingSource = this.recipesBindingSource;
            this.recipesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.recipesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.recipesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.recipesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.recipesBindingNavigatorSaveItem});
            this.recipesBindingNavigator.Location = new System.Drawing.Point(29, 9);
            this.recipesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.recipesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.recipesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.recipesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.recipesBindingNavigator.Name = "recipesBindingNavigator";
            this.recipesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.recipesBindingNavigator.Size = new System.Drawing.Size(278, 25);
            this.recipesBindingNavigator.TabIndex = 8;
            this.recipesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "Recipes";
            this.recipesBindingSource.DataSource = this.recipeDataSet;
            // 
            // recipeDataSet
            // 
            this.recipeDataSet.DataSetName = "RecipeDataSet";
            this.recipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // recipesBindingNavigatorSaveItem
            // 
            this.recipesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recipesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("recipesBindingNavigatorSaveItem.Image")));
            this.recipesBindingNavigatorSaveItem.Name = "recipesBindingNavigatorSaveItem";
            this.recipesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.recipesBindingNavigatorSaveItem.Text = "Save Data";
            this.recipesBindingNavigatorSaveItem.Click += new System.EventHandler(this.recipesBindingNavigatorSaveItem_Click);
            // 
            // viewRecipeBtn
            // 
            this.viewRecipeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewRecipeBtn.Location = new System.Drawing.Point(575, 297);
            this.viewRecipeBtn.Name = "viewRecipeBtn";
            this.viewRecipeBtn.Size = new System.Drawing.Size(150, 50);
            this.viewRecipeBtn.TabIndex = 10;
            this.viewRecipeBtn.Text = "View Recipe";
            this.viewRecipeBtn.UseVisualStyleBackColor = true;
            this.viewRecipeBtn.Click += new System.EventHandler(this.viewRecipeBtn_Click);
            // 
            // lblrecpieSelection
            // 
            this.lblrecpieSelection.AutoSize = true;
            this.lblrecpieSelection.Location = new System.Drawing.Point(595, 361);
            this.lblrecpieSelection.Name = "lblrecpieSelection";
            this.lblrecpieSelection.Size = new System.Drawing.Size(0, 13);
            this.lblrecpieSelection.TabIndex = 11;
            this.lblrecpieSelection.Click += new System.EventHandler(this.lblrecpieSelection_Click);
            // 
            // removeRcpBtn
            // 
            this.removeRcpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeRcpBtn.Location = new System.Drawing.Point(575, 185);
            this.removeRcpBtn.Name = "removeRcpBtn";
            this.removeRcpBtn.Size = new System.Drawing.Size(150, 50);
            this.removeRcpBtn.TabIndex = 12;
            this.removeRcpBtn.Text = "Remove Recipe";
            this.removeRcpBtn.UseVisualStyleBackColor = true;
            this.removeRcpBtn.Click += new System.EventHandler(this.removeRcpBtn_Click);
            // 
            // foodListDataSet
            // 
            this.foodListDataSet.DataSetName = "foodListDataSet";
            this.foodListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // food_ListBindingSource
            // 
            this.food_ListBindingSource.DataMember = "Food List";
            this.food_ListBindingSource.DataSource = this.foodListDataSet;
            // 
            // food_ListTableAdapter
            // 
            this.food_ListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Food_ListTableAdapter = this.food_ListTableAdapter;
            this.tableAdapterManager.UpdateOrder = SousChef2.foodListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.RecipesTableAdapter = this.recipesTableAdapter;
            this.tableAdapterManager1.UpdateOrder = SousChef2.RecipeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // addRecipebtn
            // 
            this.addRecipebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRecipebtn.Location = new System.Drawing.Point(575, 129);
            this.addRecipebtn.Name = "addRecipebtn";
            this.addRecipebtn.Size = new System.Drawing.Size(150, 50);
            this.addRecipebtn.TabIndex = 13;
            this.addRecipebtn.Text = "Add Recipe";
            this.addRecipebtn.UseVisualStyleBackColor = true;
            this.addRecipebtn.Click += new System.EventHandler(this.addRecipebtn_Click);
            // 
            // txtboxaddrcp
            // 
            this.txtboxaddrcp.Location = new System.Drawing.Point(575, 103);
            this.txtboxaddrcp.Name = "txtboxaddrcp";
            this.txtboxaddrcp.Size = new System.Drawing.Size(150, 20);
            this.txtboxaddrcp.TabIndex = 14;
            // 
            // NIbtn
            // 
            this.NIbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NIbtn.Location = new System.Drawing.Point(575, 241);
            this.NIbtn.Name = "NIbtn";
            this.NIbtn.Size = new System.Drawing.Size(150, 50);
            this.NIbtn.TabIndex = 15;
            this.NIbtn.Text = "Nutrition Information";
            this.NIbtn.UseVisualStyleBackColor = true;
            this.NIbtn.Click += new System.EventHandler(this.NIbtn_Click);
            // 
            // lblNutrInfo
            // 
            this.lblNutrInfo.AutoSize = true;
            this.lblNutrInfo.Location = new System.Drawing.Point(632, 389);
            this.lblNutrInfo.Name = "lblNutrInfo";
            this.lblNutrInfo.Size = new System.Drawing.Size(0, 13);
            this.lblNutrInfo.TabIndex = 16;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SousChef2.Properties.Resources.txtyour;
            this.pictureBox4.Location = new System.Drawing.Point(31, 201);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SousChef2.Properties.Resources.txtRecipes;
            this.pictureBox2.Location = new System.Drawing.Point(240, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(297, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btnMain
            // 
            this.btnMain.AutoSize = true;
            this.btnMain.BackColor = System.Drawing.Color.Transparent;
            this.btnMain.BackgroundImage = global::SousChef2.Properties.Resources.home_iconGoldBorder1;
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Location = new System.Drawing.Point(31, 42);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(55, 52);
            this.btnMain.TabIndex = 0;
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SousChef2.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(31, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SousChef2.Properties.Resources.txtIngredients;
            this.pictureBox3.Location = new System.Drawing.Point(31, 221);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(297, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // frmRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 483);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblNutrInfo);
            this.Controls.Add(this.NIbtn);
            this.Controls.Add(this.txtboxaddrcp);
            this.Controls.Add(this.addRecipebtn);
            this.Controls.Add(this.removeRcpBtn);
            this.Controls.Add(this.lblrecpieSelection);
            this.Controls.Add(this.viewRecipeBtn);
            this.Controls.Add(this.lblRecipes);
            this.Controls.Add(this.btnSearchFood);
            this.Controls.Add(this.txtRecipeSearch);
            this.Controls.Add(this.lboxFridgePantry);
            this.Controls.Add(this.lboxRecipes);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.recipesBindingNavigator);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecipes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recipes";
            this.Load += new System.EventHandler(this.frmRecipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingNavigator)).EndInit();
            this.recipesBindingNavigator.ResumeLayout(false);
            this.recipesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_ListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.ListBox lboxRecipes;
        private System.Windows.Forms.ListBox lboxFridgePantry;
        private System.Windows.Forms.TextBox txtRecipeSearch;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Label lblRecipes;
        private RecipeDataSet recipeDataSet;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        private RecipeDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
        private RecipeDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator recipesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton recipesBindingNavigatorSaveItem;
        private foodListDataSet foodListDataSet;
        private System.Windows.Forms.BindingSource food_ListBindingSource;
        private foodListDataSetTableAdapters.Food_ListTableAdapter food_ListTableAdapter;
        private foodListDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button viewRecipeBtn;
        private System.Windows.Forms.Label lblrecpieSelection;
        private System.Windows.Forms.Button removeRcpBtn;
        private System.Windows.Forms.Button addRecipebtn;
        private System.Windows.Forms.TextBox txtboxaddrcp;
        private System.Windows.Forms.Button NIbtn;
        private System.Windows.Forms.Label lblNutrInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}