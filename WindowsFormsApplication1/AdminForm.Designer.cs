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
            this.saveChangesProductButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.genresDGV = new System.Windows.Forms.DataGridView();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveChangesGenresButton = new System.Windows.Forms.Button();
            this.productTypeDGV = new System.Windows.Forms.DataGridView();
            this.producttypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveChangesTypeButton = new System.Windows.Forms.Button();
            this.usersDGV = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveChangesUsersButton = new System.Windows.Forms.Button();
            this.creditcardsDGV = new System.Windows.Forms.DataGridView();
            this.creditcardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditCardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditCardCVVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardProviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditCardHolderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveChangesCardsButton = new System.Windows.Forms.Button();
            this.editUserCardsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditcardsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditcardBindingSource)).BeginInit();
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
            // saveChangesProductButton
            // 
            this.saveChangesProductButton.Location = new System.Drawing.Point(93, 216);
            this.saveChangesProductButton.Name = "saveChangesProductButton";
            this.saveChangesProductButton.Size = new System.Drawing.Size(75, 23);
            this.saveChangesProductButton.TabIndex = 1;
            this.saveChangesProductButton.Text = "button1";
            this.saveChangesProductButton.UseVisualStyleBackColor = true;
            this.saveChangesProductButton.Click += new System.EventHandler(this.saveChangesProductButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // genresDGV
            // 
            this.genresDGV.AutoGenerateColumns = false;
            this.genresDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genresDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreIDDataGridViewTextBoxColumn1,
            this.genreNameDataGridViewTextBoxColumn});
            this.genresDGV.DataSource = this.genreBindingSource;
            this.genresDGV.Location = new System.Drawing.Point(798, 42);
            this.genresDGV.Name = "genresDGV";
            this.genresDGV.Size = new System.Drawing.Size(249, 150);
            this.genresDGV.TabIndex = 3;
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataSource = typeof(MusicShop.genre);
            // 
            // saveChangesGenresButton
            // 
            this.saveChangesGenresButton.Location = new System.Drawing.Point(884, 207);
            this.saveChangesGenresButton.Name = "saveChangesGenresButton";
            this.saveChangesGenresButton.Size = new System.Drawing.Size(75, 23);
            this.saveChangesGenresButton.TabIndex = 4;
            this.saveChangesGenresButton.Text = "button1";
            this.saveChangesGenresButton.UseVisualStyleBackColor = true;
            this.saveChangesGenresButton.Click += new System.EventHandler(this.saveChangesGenresButton_Click);
            // 
            // productTypeDGV
            // 
            this.productTypeDGV.AutoGenerateColumns = false;
            this.productTypeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTypeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productTypeIDDataGridViewTextBoxColumn1,
            this.productTypeNameDataGridViewTextBoxColumn});
            this.productTypeDGV.DataSource = this.producttypeBindingSource;
            this.productTypeDGV.Location = new System.Drawing.Point(1078, 42);
            this.productTypeDGV.Name = "productTypeDGV";
            this.productTypeDGV.Size = new System.Drawing.Size(268, 150);
            this.productTypeDGV.TabIndex = 5;
            // 
            // producttypeBindingSource
            // 
            this.producttypeBindingSource.DataSource = typeof(MusicShop.producttype);
            // 
            // productTypeIDDataGridViewTextBoxColumn1
            // 
            this.productTypeIDDataGridViewTextBoxColumn1.DataPropertyName = "productTypeID";
            this.productTypeIDDataGridViewTextBoxColumn1.HeaderText = "productTypeID";
            this.productTypeIDDataGridViewTextBoxColumn1.Name = "productTypeIDDataGridViewTextBoxColumn1";
            // 
            // productTypeNameDataGridViewTextBoxColumn
            // 
            this.productTypeNameDataGridViewTextBoxColumn.DataPropertyName = "productTypeName";
            this.productTypeNameDataGridViewTextBoxColumn.HeaderText = "productTypeName";
            this.productTypeNameDataGridViewTextBoxColumn.Name = "productTypeNameDataGridViewTextBoxColumn";
            // 
            // genreIDDataGridViewTextBoxColumn1
            // 
            this.genreIDDataGridViewTextBoxColumn1.DataPropertyName = "genreID";
            this.genreIDDataGridViewTextBoxColumn1.HeaderText = "genreID";
            this.genreIDDataGridViewTextBoxColumn1.Name = "genreIDDataGridViewTextBoxColumn1";
            // 
            // genreNameDataGridViewTextBoxColumn
            // 
            this.genreNameDataGridViewTextBoxColumn.DataPropertyName = "genreName";
            this.genreNameDataGridViewTextBoxColumn.HeaderText = "genreName";
            this.genreNameDataGridViewTextBoxColumn.Name = "genreNameDataGridViewTextBoxColumn";
            // 
            // saveChangesTypeButton
            // 
            this.saveChangesTypeButton.Location = new System.Drawing.Point(1134, 206);
            this.saveChangesTypeButton.Name = "saveChangesTypeButton";
            this.saveChangesTypeButton.Size = new System.Drawing.Size(75, 23);
            this.saveChangesTypeButton.TabIndex = 6;
            this.saveChangesTypeButton.Text = "button1";
            this.saveChangesTypeButton.UseVisualStyleBackColor = true;
            this.saveChangesTypeButton.Click += new System.EventHandler(this.saveChangesTypeButton_Click);
            // 
            // usersDGV
            // 
            this.usersDGV.AutoGenerateColumns = false;
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameDataGridViewTextBoxColumn,
            this.userEmailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.accessLevelDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.subscriptionActiveDataGridViewTextBoxColumn,
            this.discountPointsDataGridViewTextBoxColumn});
            this.usersDGV.DataSource = this.userBindingSource;
            this.usersDGV.Location = new System.Drawing.Point(13, 297);
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.Size = new System.Drawing.Size(760, 150);
            this.usersDGV.TabIndex = 7;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(MusicShop.user);
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "userName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // userEmailDataGridViewTextBoxColumn
            // 
            this.userEmailDataGridViewTextBoxColumn.DataPropertyName = "userEmail";
            this.userEmailDataGridViewTextBoxColumn.HeaderText = "userEmail";
            this.userEmailDataGridViewTextBoxColumn.Name = "userEmailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // accessLevelDataGridViewTextBoxColumn
            // 
            this.accessLevelDataGridViewTextBoxColumn.DataPropertyName = "accessLevel";
            this.accessLevelDataGridViewTextBoxColumn.HeaderText = "accessLevel";
            this.accessLevelDataGridViewTextBoxColumn.Name = "accessLevelDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // subscriptionActiveDataGridViewTextBoxColumn
            // 
            this.subscriptionActiveDataGridViewTextBoxColumn.DataPropertyName = "subscriptionActive";
            this.subscriptionActiveDataGridViewTextBoxColumn.HeaderText = "subscriptionActive";
            this.subscriptionActiveDataGridViewTextBoxColumn.Name = "subscriptionActiveDataGridViewTextBoxColumn";
            // 
            // discountPointsDataGridViewTextBoxColumn
            // 
            this.discountPointsDataGridViewTextBoxColumn.DataPropertyName = "discountPoints";
            this.discountPointsDataGridViewTextBoxColumn.HeaderText = "discountPoints";
            this.discountPointsDataGridViewTextBoxColumn.Name = "discountPointsDataGridViewTextBoxColumn";
            // 
            // saveChangesUsersButton
            // 
            this.saveChangesUsersButton.Location = new System.Drawing.Point(80, 468);
            this.saveChangesUsersButton.Name = "saveChangesUsersButton";
            this.saveChangesUsersButton.Size = new System.Drawing.Size(75, 23);
            this.saveChangesUsersButton.TabIndex = 8;
            this.saveChangesUsersButton.Text = "button1";
            this.saveChangesUsersButton.UseVisualStyleBackColor = true;
            this.saveChangesUsersButton.Click += new System.EventHandler(this.saveChangesUsersButton_Click);
            // 
            // creditcardsDGV
            // 
            this.creditcardsDGV.AutoGenerateColumns = false;
            this.creditcardsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creditcardsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.creditCardNumberDataGridViewTextBoxColumn,
            this.creditCardCVVDataGridViewTextBoxColumn,
            this.creditBalanceDataGridViewTextBoxColumn,
            this.cardProviderDataGridViewTextBoxColumn,
            this.creditCardHolderNameDataGridViewTextBoxColumn,
            this.expirationDateDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.creditcardsDGV.DataSource = this.creditcardBindingSource;
            this.creditcardsDGV.Location = new System.Drawing.Point(12, 514);
            this.creditcardsDGV.Name = "creditcardsDGV";
            this.creditcardsDGV.Size = new System.Drawing.Size(769, 150);
            this.creditcardsDGV.TabIndex = 9;
            // 
            // creditcardBindingSource
            // 
            this.creditcardBindingSource.DataSource = typeof(MusicShop.creditcard);
            // 
            // creditCardNumberDataGridViewTextBoxColumn
            // 
            this.creditCardNumberDataGridViewTextBoxColumn.DataPropertyName = "creditCardNumber";
            this.creditCardNumberDataGridViewTextBoxColumn.HeaderText = "creditCardNumber";
            this.creditCardNumberDataGridViewTextBoxColumn.Name = "creditCardNumberDataGridViewTextBoxColumn";
            // 
            // creditCardCVVDataGridViewTextBoxColumn
            // 
            this.creditCardCVVDataGridViewTextBoxColumn.DataPropertyName = "creditCardCVV";
            this.creditCardCVVDataGridViewTextBoxColumn.HeaderText = "creditCardCVV";
            this.creditCardCVVDataGridViewTextBoxColumn.Name = "creditCardCVVDataGridViewTextBoxColumn";
            // 
            // creditBalanceDataGridViewTextBoxColumn
            // 
            this.creditBalanceDataGridViewTextBoxColumn.DataPropertyName = "creditBalance";
            this.creditBalanceDataGridViewTextBoxColumn.HeaderText = "creditBalance";
            this.creditBalanceDataGridViewTextBoxColumn.Name = "creditBalanceDataGridViewTextBoxColumn";
            // 
            // cardProviderDataGridViewTextBoxColumn
            // 
            this.cardProviderDataGridViewTextBoxColumn.DataPropertyName = "cardProvider";
            this.cardProviderDataGridViewTextBoxColumn.HeaderText = "cardProvider";
            this.cardProviderDataGridViewTextBoxColumn.Name = "cardProviderDataGridViewTextBoxColumn";
            // 
            // creditCardHolderNameDataGridViewTextBoxColumn
            // 
            this.creditCardHolderNameDataGridViewTextBoxColumn.DataPropertyName = "creditCardHolderName";
            this.creditCardHolderNameDataGridViewTextBoxColumn.HeaderText = "creditCardHolderName";
            this.creditCardHolderNameDataGridViewTextBoxColumn.Name = "creditCardHolderNameDataGridViewTextBoxColumn";
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            this.expirationDateDataGridViewTextBoxColumn.DataPropertyName = "expirationDate";
            this.expirationDateDataGridViewTextBoxColumn.HeaderText = "expirationDate";
            this.expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // saveChangesCardsButton
            // 
            this.saveChangesCardsButton.Location = new System.Drawing.Point(60, 671);
            this.saveChangesCardsButton.Name = "saveChangesCardsButton";
            this.saveChangesCardsButton.Size = new System.Drawing.Size(75, 23);
            this.saveChangesCardsButton.TabIndex = 10;
            this.saveChangesCardsButton.Text = "button1";
            this.saveChangesCardsButton.UseVisualStyleBackColor = true;
            this.saveChangesCardsButton.Click += new System.EventHandler(this.saveChangesCardsButton_Click);
            // 
            // editUserCardsButton
            // 
            this.editUserCardsButton.Location = new System.Drawing.Point(270, 468);
            this.editUserCardsButton.Name = "editUserCardsButton";
            this.editUserCardsButton.Size = new System.Drawing.Size(84, 23);
            this.editUserCardsButton.TabIndex = 11;
            this.editUserCardsButton.Text = "Edit Cards";
            this.editUserCardsButton.UseVisualStyleBackColor = true;
            this.editUserCardsButton.Click += new System.EventHandler(this.editUserCardsButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 723);
            this.Controls.Add(this.editUserCardsButton);
            this.Controls.Add(this.saveChangesCardsButton);
            this.Controls.Add(this.creditcardsDGV);
            this.Controls.Add(this.saveChangesUsersButton);
            this.Controls.Add(this.usersDGV);
            this.Controls.Add(this.saveChangesTypeButton);
            this.Controls.Add(this.productTypeDGV);
            this.Controls.Add(this.saveChangesGenresButton);
            this.Controls.Add(this.genresDGV);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.saveChangesProductButton);
            this.Controls.Add(this.productsDGV);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditcardsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditcardBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productsDGV;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button saveChangesProductButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCoverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isDiscountedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView genresDGV;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.Button saveChangesGenresButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView productTypeDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource producttypeBindingSource;
        private System.Windows.Forms.Button saveChangesTypeButton;
        private System.Windows.Forms.DataGridView usersDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button saveChangesUsersButton;
        private System.Windows.Forms.DataGridView creditcardsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardCVVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardProviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardHolderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource creditcardBindingSource;
        private System.Windows.Forms.Button saveChangesCardsButton;
        private System.Windows.Forms.Button editUserCardsButton;
    }
}