namespace SousChef2
{
    partial class frmAddFood
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
            System.Windows.Forms.Label item_NameLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label expiration_DateLabel;
            System.Windows.Forms.Label fridge_PantryLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddFood));
            this.foodListDataSet = new SousChef2.foodListDataSet();
            this.food_ListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.food_ListTableAdapter = new SousChef2.foodListDataSetTableAdapters.Food_ListTableAdapter();
            this.tableAdapterManager = new SousChef2.foodListDataSetTableAdapters.TableAdapterManager();
            this.btnMain = new System.Windows.Forms.Button();
            this.item_NameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.expiration_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fridge_PantryComboBox = new System.Windows.Forms.ComboBox();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.food_ListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.food_ListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            item_NameLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            expiration_DateLabel = new System.Windows.Forms.Label();
            fridge_PantryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_ListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_ListBindingNavigator)).BeginInit();
            this.food_ListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // item_NameLabel
            // 
            item_NameLabel.AutoSize = true;
            item_NameLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_NameLabel.Location = new System.Drawing.Point(35, 79);
            item_NameLabel.Name = "item_NameLabel";
            item_NameLabel.Size = new System.Drawing.Size(67, 16);
            item_NameLabel.TabIndex = 18;
            item_NameLabel.Text = "Item Name:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoryLabel.Location = new System.Drawing.Point(35, 105);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(60, 16);
            categoryLabel.TabIndex = 22;
            categoryLabel.Text = "Category:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel.Location = new System.Drawing.Point(35, 132);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(57, 16);
            quantityLabel.TabIndex = 24;
            quantityLabel.Text = "Quantity:";
            // 
            // expiration_DateLabel
            // 
            expiration_DateLabel.AutoSize = true;
            expiration_DateLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expiration_DateLabel.Location = new System.Drawing.Point(35, 159);
            expiration_DateLabel.Name = "expiration_DateLabel";
            expiration_DateLabel.Size = new System.Drawing.Size(93, 16);
            expiration_DateLabel.TabIndex = 26;
            expiration_DateLabel.Text = "Expiration Date:";
            // 
            // fridge_PantryLabel
            // 
            fridge_PantryLabel.AutoSize = true;
            fridge_PantryLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fridge_PantryLabel.Location = new System.Drawing.Point(35, 184);
            fridge_PantryLabel.Name = "fridge_PantryLabel";
            fridge_PantryLabel.Size = new System.Drawing.Size(83, 16);
            fridge_PantryLabel.TabIndex = 28;
            fridge_PantryLabel.Text = "Fridge/Pantry:";
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
            // btnMain
            // 
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(38, 265);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(322, 48);
            this.btnMain.TabIndex = 18;
            this.btnMain.Text = "Close";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // item_NameTextBox
            // 
            this.item_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_ListBindingSource, "Item Name", true));
            this.item_NameTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_NameTextBox.Location = new System.Drawing.Point(128, 76);
            this.item_NameTextBox.Name = "item_NameTextBox";
            this.item_NameTextBox.Size = new System.Drawing.Size(232, 22);
            this.item_NameTextBox.TabIndex = 19;
            this.item_NameTextBox.TextChanged += new System.EventHandler(this.item_NameTextBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_ListBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(165, 390);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(232, 22);
            this.descriptionTextBox.TabIndex = 21;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_ListBindingSource, "Category", true));
            this.categoryComboBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Dairy",
            "Frozen",
            "General (Non - perishables)",
            "Meat",
            "Produce"});
            this.categoryComboBox.Location = new System.Drawing.Point(128, 102);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(232, 24);
            this.categoryComboBox.TabIndex = 23;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_ListBindingSource, "Quantity", true));
            this.quantityTextBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTextBox.Location = new System.Drawing.Point(128, 129);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(232, 22);
            this.quantityTextBox.TabIndex = 25;
            // 
            // expiration_DateDateTimePicker
            // 
            this.expiration_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.food_ListBindingSource, "Expiration Date", true));
            this.expiration_DateDateTimePicker.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiration_DateDateTimePicker.Location = new System.Drawing.Point(128, 155);
            this.expiration_DateDateTimePicker.Name = "expiration_DateDateTimePicker";
            this.expiration_DateDateTimePicker.Size = new System.Drawing.Size(232, 22);
            this.expiration_DateDateTimePicker.TabIndex = 27;
            // 
            // fridge_PantryComboBox
            // 
            this.fridge_PantryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.food_ListBindingSource, "Fridge/Pantry", true));
            this.fridge_PantryComboBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fridge_PantryComboBox.FormattingEnabled = true;
            this.fridge_PantryComboBox.Items.AddRange(new object[] {
            "Fridge",
            "Pantry"});
            this.fridge_PantryComboBox.Location = new System.Drawing.Point(128, 181);
            this.fridge_PantryComboBox.Name = "fridge_PantryComboBox";
            this.fridge_PantryComboBox.Size = new System.Drawing.Size(232, 24);
            this.fridge_PantryComboBox.TabIndex = 29;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // food_ListBindingNavigator
            // 
            this.food_ListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.food_ListBindingNavigator.BindingSource = this.food_ListBindingSource;
            this.food_ListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.food_ListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.food_ListBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.food_ListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.food_ListBindingNavigatorSaveItem});
            this.food_ListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.food_ListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.food_ListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.food_ListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.food_ListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.food_ListBindingNavigator.Name = "food_ListBindingNavigator";
            this.food_ListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.food_ListBindingNavigator.Size = new System.Drawing.Size(408, 39);
            this.food_ListBindingNavigator.TabIndex = 3;
            this.food_ListBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // food_ListBindingNavigatorSaveItem
            // 
            this.food_ListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.food_ListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("food_ListBindingNavigatorSaveItem.Image")));
            this.food_ListBindingNavigatorSaveItem.Name = "food_ListBindingNavigatorSaveItem";
            this.food_ListBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
            this.food_ListBindingNavigatorSaveItem.Text = "Save Data";
            this.food_ListBindingNavigatorSaveItem.Click += new System.EventHandler(this.food_ListBindingNavigatorSaveItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(38, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(322, 48);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SousChef2.Properties.Resources.txtAddFood;
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // frmAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 333);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(item_NameLabel);
            this.Controls.Add(this.food_ListBindingNavigator);
            this.Controls.Add(this.item_NameTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.fridge_PantryComboBox);
            this.Controls.Add(fridge_PantryLabel);
            this.Controls.Add(expiration_DateLabel);
            this.Controls.Add(this.expiration_DateDateTimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Food";
            this.Load += new System.EventHandler(this.frmAddFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_ListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_ListBindingNavigator)).EndInit();
            this.food_ListBindingNavigator.ResumeLayout(false);
            this.food_ListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private foodListDataSet foodListDataSet;
        private System.Windows.Forms.BindingSource food_ListBindingSource;
        private foodListDataSetTableAdapters.Food_ListTableAdapter food_ListTableAdapter;
        private foodListDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.TextBox item_NameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.DateTimePicker expiration_DateDateTimePicker;
        private System.Windows.Forms.ComboBox fridge_PantryComboBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton food_ListBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator food_ListBindingNavigator;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}