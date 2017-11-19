namespace MusicShop
{
    partial class CartForm
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
            this.cartEmptyLabel = new System.Windows.Forms.Label();
            this.cartTotalLabel = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.emptyCartButton = new System.Windows.Forms.Button();
            this.cartGridView = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customCartDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customCartDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cartEmptyLabel
            // 
            this.cartEmptyLabel.AutoSize = true;
            this.cartEmptyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartEmptyLabel.ForeColor = System.Drawing.Color.LightSalmon;
            this.cartEmptyLabel.Location = new System.Drawing.Point(136, 187);
            this.cartEmptyLabel.Name = "cartEmptyLabel";
            this.cartEmptyLabel.Size = new System.Drawing.Size(241, 25);
            this.cartEmptyLabel.TabIndex = 11;
            this.cartEmptyLabel.Text = "YOUR CART IS EMPTY";
            this.cartEmptyLabel.Visible = false;
            // 
            // cartTotalLabel
            // 
            this.cartTotalLabel.AutoSize = true;
            this.cartTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartTotalLabel.Location = new System.Drawing.Point(297, 273);
            this.cartTotalLabel.Name = "cartTotalLabel";
            this.cartTotalLabel.Size = new System.Drawing.Size(96, 25);
            this.cartTotalLabel.TabIndex = 10;
            this.cartTotalLabel.Text = "Total: $0";
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.ForeColor = System.Drawing.Color.White;
            this.buyButton.Location = new System.Drawing.Point(257, 330);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(120, 40);
            this.buyButton.TabIndex = 9;
            this.buyButton.TabStop = false;
            this.buyButton.Text = "Buy All";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // emptyCartButton
            // 
            this.emptyCartButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.emptyCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emptyCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emptyCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyCartButton.ForeColor = System.Drawing.Color.White;
            this.emptyCartButton.Location = new System.Drawing.Point(131, 330);
            this.emptyCartButton.Name = "emptyCartButton";
            this.emptyCartButton.Size = new System.Drawing.Size(120, 40);
            this.emptyCartButton.TabIndex = 8;
            this.emptyCartButton.TabStop = false;
            this.emptyCartButton.Text = "Emtpy Cart";
            this.emptyCartButton.UseVisualStyleBackColor = false;
            this.emptyCartButton.Click += new System.EventHandler(this.emptyCartButton_Click);
            // 
            // cartGridView
            // 
            this.cartGridView.AutoGenerateColumns = false;
            this.cartGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.cartGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.originalPriceDataGridViewTextBoxColumn,
            this.discountRateDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn});
            this.cartGridView.DataSource = this.customCartDetailBindingSource;
            this.cartGridView.Location = new System.Drawing.Point(30, 107);
            this.cartGridView.Name = "cartGridView";
            this.cartGridView.Size = new System.Drawing.Size(465, 150);
            this.cartGridView.TabIndex = 7;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // originalPriceDataGridViewTextBoxColumn
            // 
            this.originalPriceDataGridViewTextBoxColumn.DataPropertyName = "OriginalPrice";
            this.originalPriceDataGridViewTextBoxColumn.HeaderText = "Original Price";
            this.originalPriceDataGridViewTextBoxColumn.Name = "originalPriceDataGridViewTextBoxColumn";
            // 
            // discountRateDataGridViewTextBoxColumn
            // 
            this.discountRateDataGridViewTextBoxColumn.DataPropertyName = "DiscountRate";
            this.discountRateDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountRateDataGridViewTextBoxColumn.Name = "discountRateDataGridViewTextBoxColumn";
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            // 
            // customCartDetailBindingSource
            // 
            this.customCartDetailBindingSource.DataSource = typeof(MusicShop.CustomCartDetail);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSalmon;
            this.label1.Location = new System.Drawing.Point(198, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your Cart";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 415);
            this.Controls.Add(this.cartEmptyLabel);
            this.Controls.Add(this.cartTotalLabel);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.emptyCartButton);
            this.Controls.Add(this.cartGridView);
            this.Controls.Add(this.label1);
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customCartDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cartEmptyLabel;
        private System.Windows.Forms.Label cartTotalLabel;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button emptyCartButton;
        private System.Windows.Forms.DataGridView cartGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customCartDetailBindingSource;
    }
}