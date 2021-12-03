namespace Верфь
{
    partial class Manufacture
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boatIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfRowersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mastDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.woodTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.woodTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boatIdDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.boatTypeIdDataGridViewTextBoxColumn,
            this.numberOfRowersDataGridViewTextBoxColumn,
            this.mastDataGridViewCheckBoxColumn,
            this.colourDataGridViewTextBoxColumn,
            this.woodTypeIdDataGridViewTextBoxColumn,
            this.basePriceDataGridViewTextBoxColumn,
            this.wATDataGridViewTextBoxColumn,
            this.boatTypeDataGridViewTextBoxColumn,
            this.woodTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.boatsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // boatIdDataGridViewTextBoxColumn
            // 
            this.boatIdDataGridViewTextBoxColumn.DataPropertyName = "BoatId";
            this.boatIdDataGridViewTextBoxColumn.HeaderText = "BoatId";
            this.boatIdDataGridViewTextBoxColumn.Name = "boatIdDataGridViewTextBoxColumn";
            this.boatIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boatTypeIdDataGridViewTextBoxColumn
            // 
            this.boatTypeIdDataGridViewTextBoxColumn.DataPropertyName = "BoatTypeId";
            this.boatTypeIdDataGridViewTextBoxColumn.HeaderText = "BoatTypeId";
            this.boatTypeIdDataGridViewTextBoxColumn.Name = "boatTypeIdDataGridViewTextBoxColumn";
            this.boatTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfRowersDataGridViewTextBoxColumn
            // 
            this.numberOfRowersDataGridViewTextBoxColumn.DataPropertyName = "NumberOfRowers";
            this.numberOfRowersDataGridViewTextBoxColumn.HeaderText = "NumberOfRowers";
            this.numberOfRowersDataGridViewTextBoxColumn.Name = "numberOfRowersDataGridViewTextBoxColumn";
            this.numberOfRowersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mastDataGridViewCheckBoxColumn
            // 
            this.mastDataGridViewCheckBoxColumn.DataPropertyName = "Mast";
            this.mastDataGridViewCheckBoxColumn.HeaderText = "Mast";
            this.mastDataGridViewCheckBoxColumn.Name = "mastDataGridViewCheckBoxColumn";
            this.mastDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "Colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "Colour";
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            this.colourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // woodTypeIdDataGridViewTextBoxColumn
            // 
            this.woodTypeIdDataGridViewTextBoxColumn.DataPropertyName = "WoodTypeId";
            this.woodTypeIdDataGridViewTextBoxColumn.HeaderText = "WoodTypeId";
            this.woodTypeIdDataGridViewTextBoxColumn.Name = "woodTypeIdDataGridViewTextBoxColumn";
            this.woodTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // basePriceDataGridViewTextBoxColumn
            // 
            this.basePriceDataGridViewTextBoxColumn.DataPropertyName = "BasePrice";
            this.basePriceDataGridViewTextBoxColumn.HeaderText = "BasePrice";
            this.basePriceDataGridViewTextBoxColumn.Name = "basePriceDataGridViewTextBoxColumn";
            this.basePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wATDataGridViewTextBoxColumn
            // 
            this.wATDataGridViewTextBoxColumn.DataPropertyName = "WAT";
            this.wATDataGridViewTextBoxColumn.HeaderText = "WAT";
            this.wATDataGridViewTextBoxColumn.Name = "wATDataGridViewTextBoxColumn";
            this.wATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boatTypeDataGridViewTextBoxColumn
            // 
            this.boatTypeDataGridViewTextBoxColumn.DataPropertyName = "BoatType";
            this.boatTypeDataGridViewTextBoxColumn.HeaderText = "BoatType";
            this.boatTypeDataGridViewTextBoxColumn.Name = "boatTypeDataGridViewTextBoxColumn";
            this.boatTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // woodTypeDataGridViewTextBoxColumn
            // 
            this.woodTypeDataGridViewTextBoxColumn.DataPropertyName = "WoodType";
            this.woodTypeDataGridViewTextBoxColumn.HeaderText = "WoodType";
            this.woodTypeDataGridViewTextBoxColumn.Name = "woodTypeDataGridViewTextBoxColumn";
            this.woodTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boatsBindingSource
            // 
            this.boatsBindingSource.DataSource = typeof(Верфь.Boats);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(1081, 418);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Manufacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Manufacture";
            this.Text = "Производство";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manufacture_FormClosing);
            this.Load += new System.EventHandler(this.Manufacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boatsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfRowersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn mastDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn woodTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boatTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn woodTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource boatsBindingSource;
        private System.Windows.Forms.Button backButton;
    }
}