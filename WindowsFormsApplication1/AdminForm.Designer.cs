namespace MusicShop
{
    partial class AdminForm
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
            this.productsDGV = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCoverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDiscountedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productsDGV
            // 
            this.productsDGV.AutoGenerateColumns = false;
            this.productsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productCoverDataGridViewTextBoxColumn,
            this.productTypeIDDataGridViewTextBoxColumn,
            this.genreIDDataGridViewTextBoxColumn,
            this.isDiscountedDataGridViewTextBoxColumn,
            this.discountRateDataGridViewTextBoxColumn});
            this.productsDGV.DataSource = this.productBindingSource;
            this.productsDGV.Location = new System.Drawing.Point(12, 42);
            this.productsDGV.Name = "productsDGV";
            this.productsDGV.Size = new System.Drawing.Size(745, 150);
            this.productsDGV.TabIndex = 0;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "productPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "productPrice";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            // 
            // productCoverDataGridViewTextBoxColumn
            // 
            this.productCoverDataGridViewTextBoxColumn.DataPropertyName = "productCover";
            this.productCoverDataGridViewTextBoxColumn.HeaderText = "productCover";
            this.productCoverDataGridViewTextBoxColumn.Name = "productCoverDataGridViewTextBoxColumn";
            // 
            // productTypeIDDataGridViewTextBoxColumn
            // 
            this.productTypeIDDataGridViewTextBoxColumn.DataPropertyName = "productTypeID";
            this.productTypeIDDataGridViewTextBoxColumn.HeaderText = "productTypeID";
            this.productTypeIDDataGridViewTextBoxColumn.Name = "productTypeIDDataGridViewTextBoxColumn";
            // 
            // genreIDDataGridViewTextBoxColumn
            // 
            this.genreIDDataGridViewTextBoxColumn.DataPropertyName = "genreID";
            this.genreIDDataGridViewTextBoxColumn.HeaderText = "genreID";
            this.genreIDDataGridViewTextBoxColumn.Name = "genreIDDataGridViewTextBoxColumn";
            // 
            // isDiscountedDataGridViewTextBoxColumn
            // 
            this.isDiscountedDataGridViewTextBoxColumn.DataPropertyName = "isDiscounted";
            this.isDiscountedDataGridViewTextBoxColumn.HeaderText = "isDiscounted";
            this.isDiscountedDataGridViewTextBoxColumn.Name = "isDiscountedDataGridViewTextBoxColumn";
            // 
            // discountRateDataGridViewTextBoxColumn
            // 
            this.discountRateDataGridViewTextBoxColumn.DataPropertyName = "discountRate";
            this.discountRateDataGridViewTextBoxColumn.HeaderText = "discountRate";
            this.discountRateDataGridViewTextBoxColumn.Name = "discountRateDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(MusicShop.product);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 406);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productsDGV);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDGV;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCoverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDiscountedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}