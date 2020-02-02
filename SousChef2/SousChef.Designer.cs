namespace SousChef2
{
    partial class frmSousChefMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSousChefMain));
            this.btnPantry = new System.Windows.Forms.Button();
            this.btnFridge = new System.Windows.Forms.Button();
            this.btnRecipes = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lboxExpiring = new System.Windows.Forms.ListBox();
            this.foodListDataSet = new SousChef2.foodListDataSet();
            this.food_ListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.food_ListTableAdapter = new SousChef2.foodListDataSetTableAdapters.Food_ListTableAdapter();
            this.tableAdapterManager = new SousChef2.foodListDataSetTableAdapters.TableAdapterManager();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_ListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPantry
            // 
            this.btnPantry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPantry.Location = new System.Drawing.Point(357, 208);
            this.btnPantry.Name = "btnPantry";
            this.btnPantry.Size = new System.Drawing.Size(152, 75);
            this.btnPantry.TabIndex = 0;
            this.btnPantry.Text = "Pantry";
            this.btnPantry.UseVisualStyleBackColor = true;
            this.btnPantry.Click += new System.EventHandler(this.PantryMainBTN_Click);
            // 
            // btnFridge
            // 
            this.btnFridge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFridge.Location = new System.Drawing.Point(357, 127);
            this.btnFridge.Name = "btnFridge";
            this.btnFridge.Size = new System.Drawing.Size(152, 75);
            this.btnFridge.TabIndex = 2;
            this.btnFridge.Text = "Fridge";
            this.btnFridge.UseVisualStyleBackColor = true;
            this.btnFridge.Click += new System.EventHandler(this.btnFridge_Click);
            // 
            // btnRecipes
            // 
            this.btnRecipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecipes.Location = new System.Drawing.Point(357, 370);
            this.btnRecipes.Name = "btnRecipes";
            this.btnRecipes.Size = new System.Drawing.Size(152, 75);
            this.btnRecipes.TabIndex = 3;
            this.btnRecipes.Text = "Recipes";
            this.btnRecipes.UseVisualStyleBackColor = true;
            this.btnRecipes.Click += new System.EventHandler(this.btnRecipes_Click);
            // 
            // btnAll
            // 
            this.btnAll.AutoSize = true;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Location = new System.Drawing.Point(357, 289);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(152, 75);
            this.btnAll.TabIndex = 4;
            this.btnAll.Text = "Pantry and Fridge";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(357, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 75);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Food";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lboxExpiring
            // 
            this.lboxExpiring.FormattingEnabled = true;
            this.lboxExpiring.Location = new System.Drawing.Point(515, 103);
            this.lboxExpiring.Name = "lboxExpiring";
            this.lboxExpiring.Size = new System.Drawing.Size(210, 342);
            this.lboxExpiring.TabIndex = 8;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SousChef2.Properties.Resources.txtEF;
            this.pictureBox2.Location = new System.Drawing.Point(515, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(297, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SousChef2.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(31, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmSousChefMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 483);
            this.Controls.Add(this.btnRecipes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lboxExpiring);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnFridge);
            this.Controls.Add(this.btnPantry);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSousChefMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sous Chef";
            this.Load += new System.EventHandler(this.MainFr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_ListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPantry;
        private System.Windows.Forms.Button btnFridge;
        private System.Windows.Forms.Button btnRecipes;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lboxExpiring;
        private foodListDataSet foodListDataSet;
        private System.Windows.Forms.BindingSource food_ListBindingSource;
        private foodListDataSetTableAdapters.Food_ListTableAdapter food_ListTableAdapter;
        private foodListDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

