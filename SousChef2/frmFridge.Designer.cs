namespace SousChef2
{
    partial class frmFridge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFridge));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lboxFridge = new System.Windows.Forms.ListBox();
            this.btnMain = new System.Windows.Forms.Button();
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
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(194, 341);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(152, 95);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove Food";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(31, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 95);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Food";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lboxFridge
            // 
            this.lboxFridge.FormattingEnabled = true;
            this.lboxFridge.Location = new System.Drawing.Point(352, 107);
            this.lboxFridge.Name = "lboxFridge";
            this.lboxFridge.Size = new System.Drawing.Size(171, 329);
            this.lboxFridge.TabIndex = 1;
            this.lboxFridge.SelectedIndexChanged += new System.EventHandler(this.lboxFridge_SelectedIndexChanged);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Transparent;
            this.btnMain.BackgroundImage = global::SousChef2.Properties.Resources.home_iconGoldBorder1;
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Location = new System.Drawing.Point(31, 42);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(55, 52);
            this.btnMain.TabIndex = 4;
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
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
            this.pictureBox2.Image = global::SousChef2.Properties.Resources.txtFridge;
            this.pictureBox2.Location = new System.Drawing.Point(352, 42);
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
            // frmFridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(737, 483);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lboxFridge);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFridge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Your Fridge";
            this.Load += new System.EventHandler(this.frmFridge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_ListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lboxFridge;
        private System.Windows.Forms.Button btnMain;
        private foodListDataSet foodListDataSet;
        private System.Windows.Forms.BindingSource food_ListBindingSource;
        private foodListDataSetTableAdapters.Food_ListTableAdapter food_ListTableAdapter;
        private foodListDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}