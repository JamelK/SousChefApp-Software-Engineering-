namespace SousChef2
{
    partial class PantryFr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantryFr));
            this.lblPantry = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.foodListDataSet = new SousChef2.foodListDataSet();
            this.food_ListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.food_ListTableAdapter = new SousChef2.foodListDataSetTableAdapters.Food_ListTableAdapter();
            this.tableAdapterManager = new SousChef2.foodListDataSetTableAdapters.TableAdapterManager();
            this.lboxPantry = new System.Windows.Forms.ListBox();
            this.MainPantryBTN = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_ListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPantry
            // 
            this.lblPantry.AutoSize = true;
            this.lblPantry.Location = new System.Drawing.Point(228, 40);
            this.lblPantry.Name = "lblPantry";
            this.lblPantry.Size = new System.Drawing.Size(62, 13);
            this.lblPantry.TabIndex = 0;
            this.lblPantry.Text = "Your Pantry";
            this.lblPantry.Click += new System.EventHandler(this.lblPantry_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(31, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 95);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Foods";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(194, 341);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(152, 95);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove Foods";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            // lboxPantry
            // 
            this.lboxPantry.FormattingEnabled = true;
            this.lboxPantry.Location = new System.Drawing.Point(352, 107);
            this.lboxPantry.Name = "lboxPantry";
            this.lboxPantry.Size = new System.Drawing.Size(171, 329);
            this.lboxPantry.TabIndex = 2;
            // 
            // MainPantryBTN
            // 
            this.MainPantryBTN.BackColor = System.Drawing.Color.Transparent;
            this.MainPantryBTN.BackgroundImage = global::SousChef2.Properties.Resources.home_iconGoldBorder1;
            this.MainPantryBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainPantryBTN.FlatAppearance.BorderSize = 0;
            this.MainPantryBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MainPantryBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MainPantryBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainPantryBTN.Location = new System.Drawing.Point(31, 42);
            this.MainPantryBTN.Name = "MainPantryBTN";
            this.MainPantryBTN.Size = new System.Drawing.Size(55, 52);
            this.MainPantryBTN.TabIndex = 1;
            this.MainPantryBTN.UseVisualStyleBackColor = false;
            this.MainPantryBTN.Click += new System.EventHandler(this.MainPantryBTN_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SousChef2.Properties.Resources.txtPantry;
            this.pictureBox2.Location = new System.Drawing.Point(352, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(297, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SousChef2.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(31, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // PantryFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(737, 483);
            this.Controls.Add(this.MainPantryBTN);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lboxPantry);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPantry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantryFr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Your Pantry";
            this.Load += new System.EventHandler(this.PantryFr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_ListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPantry;
        private System.Windows.Forms.Button MainPantryBTN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private foodListDataSet foodListDataSet;
        private System.Windows.Forms.BindingSource food_ListBindingSource;
        private foodListDataSetTableAdapters.Food_ListTableAdapter food_ListTableAdapter;
        private foodListDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lboxPantry;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}