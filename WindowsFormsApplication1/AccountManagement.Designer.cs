namespace MusicShop
{
    partial class AccountManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.datePurchasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWithDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showInvoiceDetails = new System.Windows.Forms.Button();
            this.invoiceDetailsGridView = new System.Windows.Forms.DataGridView();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customInvoiceDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.manageCardsButton = new System.Windows.Forms.Button();
            this.playUserProductsButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase History";
            // 
            // invoiceDataGridView
            // 
            this.invoiceDataGridView.AutoGenerateColumns = false;
            this.invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datePurchasedDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.totalWithDiscountDataGridViewTextBoxColumn});
            this.invoiceDataGridView.DataSource = this.invoiceBindingSource;
            this.invoiceDataGridView.Location = new System.Drawing.Point(32, 81);
            this.invoiceDataGridView.Name = "invoiceDataGridView";
            this.invoiceDataGridView.Size = new System.Drawing.Size(470, 150);
            this.invoiceDataGridView.TabIndex = 1;
            // 
            // datePurchasedDataGridViewTextBoxColumn
            // 
            this.datePurchasedDataGridViewTextBoxColumn.DataPropertyName = "datePurchased";
            this.datePurchasedDataGridViewTextBoxColumn.HeaderText = "datePurchased";
            this.datePurchasedDataGridViewTextBoxColumn.Name = "datePurchasedDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // totalWithDiscountDataGridViewTextBoxColumn
            // 
            this.totalWithDiscountDataGridViewTextBoxColumn.DataPropertyName = "totalWithDiscount";
            this.totalWithDiscountDataGridViewTextBoxColumn.HeaderText = "totalWithDiscount";
            this.totalWithDiscountDataGridViewTextBoxColumn.Name = "totalWithDiscountDataGridViewTextBoxColumn";
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(MusicShop.invoice);
            // 
            // showInvoiceDetails
            // 
            this.showInvoiceDetails.Location = new System.Drawing.Point(53, 253);
            this.showInvoiceDetails.Name = "showInvoiceDetails";
            this.showInvoiceDetails.Size = new System.Drawing.Size(97, 23);
            this.showInvoiceDetails.TabIndex = 2;
            this.showInvoiceDetails.Text = "Show Details";
            this.showInvoiceDetails.UseVisualStyleBackColor = true;
            this.showInvoiceDetails.Click += new System.EventHandler(this.showInvoiceDetails_Click);
            // 
            // invoiceDetailsGridView
            // 
            this.invoiceDetailsGridView.AutoGenerateColumns = false;
            this.invoiceDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDetailsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productPriceDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn});
            this.invoiceDetailsGridView.DataSource = this.customInvoiceDetailBindingSource;
            this.invoiceDetailsGridView.Location = new System.Drawing.Point(32, 296);
            this.invoiceDetailsGridView.Name = "invoiceDetailsGridView";
            this.invoiceDetailsGridView.Size = new System.Drawing.Size(268, 110);
            this.invoiceDetailsGridView.TabIndex = 3;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // customInvoiceDetailBindingSource
            // 
            this.customInvoiceDetailBindingSource.DataSource = typeof(MusicShop.CustomInvoiceDetail);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Credit Cards";
            // 
            // manageCardsButton
            // 
            this.manageCardsButton.Location = new System.Drawing.Point(32, 484);
            this.manageCardsButton.Name = "manageCardsButton";
            this.manageCardsButton.Size = new System.Drawing.Size(109, 35);
            this.manageCardsButton.TabIndex = 16;
            this.manageCardsButton.Text = "Manage Cards";
            this.manageCardsButton.UseVisualStyleBackColor = true;
            this.manageCardsButton.Click += new System.EventHandler(this.manageCardsButton_Click);
            // 
            // playUserProductsButton
            // 
            this.playUserProductsButton.Location = new System.Drawing.Point(248, 484);
            this.playUserProductsButton.Name = "playUserProductsButton";
            this.playUserProductsButton.Size = new System.Drawing.Size(122, 35);
            this.playUserProductsButton.TabIndex = 17;
            this.playUserProductsButton.Text = "Play";
            this.playUserProductsButton.UseVisualStyleBackColor = true;
            this.playUserProductsButton.Click += new System.EventHandler(this.playUserProductsButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Play and Download your products";
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playUserProductsButton);
            this.Controls.Add(this.manageCardsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invoiceDetailsGridView);
            this.Controls.Add(this.showInvoiceDetails);
            this.Controls.Add(this.invoiceDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "AccountManagement";
            this.Text = "AccountManagement";
            this.Load += new System.EventHandler(this.AccountManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDetailsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customInvoiceDetailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView invoiceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePurchasedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWithDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private System.Windows.Forms.Button showInvoiceDetails;
        private System.Windows.Forms.DataGridView invoiceDetailsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customInvoiceDetailBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button manageCardsButton;
        private System.Windows.Forms.Button playUserProductsButton;
        private System.Windows.Forms.Label label3;
    }
}