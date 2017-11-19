namespace MusicShop
{
    partial class ProductForm
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
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.creatorListBox = new System.Windows.Forms.ListBox();
            this.creatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creatorDescriptionLabel = new System.Windows.Forms.Label();
            this.creatorRoleLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.myCommentPanel = new System.Windows.Forms.Panel();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginToPostLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.postCommentButton = new System.Windows.Forms.Button();
            this.commenctTextBox = new System.Windows.Forms.RichTextBox();
            this.gradeComboBox = new System.Windows.Forms.ComboBox();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.leaveCommentLabel = new System.Windows.Forms.Label();
            this.commentsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.producttypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.discountRateLabel = new System.Windows.Forms.Label();
            this.oldPriceLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creatorBindingSource)).BeginInit();
            this.myCommentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "productName", true));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(MusicShop.product);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(412, 405);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(70, 25);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.genreBindingSource, "genreName", true));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataSource = typeof(MusicShop.genre);
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.Location = new System.Drawing.Point(12, 12);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(1051, 369);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.coverPictureBox.TabIndex = 3;
            this.coverPictureBox.TabStop = false;
            // 
            // creatorListBox
            // 
            this.creatorListBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.creatorListBox.DataSource = this.creatorBindingSource;
            this.creatorListBox.DisplayMember = "creatorName";
            this.creatorListBox.FormattingEnabled = true;
            this.creatorListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.creatorListBox.IntegralHeight = false;
            this.creatorListBox.Location = new System.Drawing.Point(531, 451);
            this.creatorListBox.Name = "creatorListBox";
            this.creatorListBox.Size = new System.Drawing.Size(103, 56);
            this.creatorListBox.TabIndex = 4;
            this.creatorListBox.ValueMember = "creatorID";
            this.creatorListBox.SelectedIndexChanged += new System.EventHandler(this.creatorListBox_SelectedIndexChanged);
            // 
            // creatorBindingSource
            // 
            this.creatorBindingSource.DataSource = typeof(MusicShop.creator);
            // 
            // creatorDescriptionLabel
            // 
            this.creatorDescriptionLabel.AutoSize = true;
            this.creatorDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatorDescriptionLabel.Location = new System.Drawing.Point(729, 473);
            this.creatorDescriptionLabel.MaximumSize = new System.Drawing.Size(130, 0);
            this.creatorDescriptionLabel.Name = "creatorDescriptionLabel";
            this.creatorDescriptionLabel.Size = new System.Drawing.Size(41, 15);
            this.creatorDescriptionLabel.TabIndex = 5;
            this.creatorDescriptionLabel.Text = "label4";
            // 
            // creatorRoleLabel
            // 
            this.creatorRoleLabel.AutoSize = true;
            this.creatorRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatorRoleLabel.Location = new System.Drawing.Point(729, 451);
            this.creatorRoleLabel.Name = "creatorRoleLabel";
            this.creatorRoleLabel.Size = new System.Drawing.Size(41, 15);
            this.creatorRoleLabel.TabIndex = 6;
            this.creatorRoleLabel.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(650, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Role:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(650, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(609, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "CREATORS";
            // 
            // myCommentPanel
            // 
            this.myCommentPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.myCommentPanel.AutoSize = true;
            this.myCommentPanel.Controls.Add(this.registerButton);
            this.myCommentPanel.Controls.Add(this.loginToPostLabel);
            this.myCommentPanel.Controls.Add(this.loginButton);
            this.myCommentPanel.Controls.Add(this.postCommentButton);
            this.myCommentPanel.Controls.Add(this.commenctTextBox);
            this.myCommentPanel.Controls.Add(this.gradeComboBox);
            this.myCommentPanel.Controls.Add(this.gradeLabel);
            this.myCommentPanel.Controls.Add(this.leaveCommentLabel);
            this.myCommentPanel.Location = new System.Drawing.Point(266, 513);
            this.myCommentPanel.Name = "myCommentPanel";
            this.myCommentPanel.Size = new System.Drawing.Size(573, 194);
            this.myCommentPanel.TabIndex = 19;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Red;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(286, 67);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 30);
            this.registerButton.TabIndex = 18;
            this.registerButton.TabStop = false;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Visible = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginToPostLabel
            // 
            this.loginToPostLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loginToPostLabel.AutoSize = true;
            this.loginToPostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToPostLabel.Location = new System.Drawing.Point(152, 24);
            this.loginToPostLabel.Name = "loginToPostLabel";
            this.loginToPostLabel.Size = new System.Drawing.Size(253, 25);
            this.loginToPostLabel.TabIndex = 5;
            this.loginToPostLabel.Text = "Login to post a comment!";
            this.loginToPostLabel.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Red;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(205, 67);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 30);
            this.loginButton.TabIndex = 17;
            this.loginButton.TabStop = false;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Visible = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // postCommentButton
            // 
            this.postCommentButton.BackColor = System.Drawing.Color.Red;
            this.postCommentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postCommentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.postCommentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postCommentButton.ForeColor = System.Drawing.Color.White;
            this.postCommentButton.Location = new System.Drawing.Point(215, 154);
            this.postCommentButton.Name = "postCommentButton";
            this.postCommentButton.Size = new System.Drawing.Size(140, 30);
            this.postCommentButton.TabIndex = 4;
            this.postCommentButton.TabStop = false;
            this.postCommentButton.Text = "Post comment";
            this.postCommentButton.UseVisualStyleBackColor = false;
            this.postCommentButton.Click += new System.EventHandler(this.postCommentButton_Click);
            // 
            // commenctTextBox
            // 
            this.commenctTextBox.Location = new System.Drawing.Point(22, 52);
            this.commenctTextBox.Name = "commenctTextBox";
            this.commenctTextBox.Size = new System.Drawing.Size(529, 96);
            this.commenctTextBox.TabIndex = 3;
            this.commenctTextBox.Text = "";
            // 
            // gradeComboBox
            // 
            this.gradeComboBox.FormattingEnabled = true;
            this.gradeComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.gradeComboBox.Location = new System.Drawing.Point(230, 15);
            this.gradeComboBox.Name = "gradeComboBox";
            this.gradeComboBox.Size = new System.Drawing.Size(121, 21);
            this.gradeComboBox.TabIndex = 2;
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.Location = new System.Drawing.Point(167, 15);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(54, 20);
            this.gradeLabel.TabIndex = 1;
            this.gradeLabel.Text = "Grade";
            // 
            // leaveCommentLabel
            // 
            this.leaveCommentLabel.AutoSize = true;
            this.leaveCommentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveCommentLabel.Location = new System.Drawing.Point(18, 15);
            this.leaveCommentLabel.Name = "leaveCommentLabel";
            this.leaveCommentLabel.Size = new System.Drawing.Size(139, 20);
            this.leaveCommentLabel.TabIndex = 0;
            this.leaveCommentLabel.Text = "Leave a comment ";
            // 
            // commentsPanel
            // 
            this.commentsPanel.AutoSize = true;
            this.commentsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.commentsPanel.Location = new System.Drawing.Point(266, 593);
            this.commentsPanel.Name = "commentsPanel";
            this.commentsPanel.Size = new System.Drawing.Size(573, 55);
            this.commentsPanel.TabIndex = 18;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.Location = new System.Drawing.Point(483, 554);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(114, 25);
            this.commentsLabel.TabIndex = 17;
            this.commentsLabel.Text = "Comments";
            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addToCartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCartButton.ForeColor = System.Drawing.Color.White;
            this.addToCartButton.Location = new System.Drawing.Point(881, 405);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(182, 43);
            this.addToCartButton.TabIndex = 20;
            this.addToCartButton.TabStop = false;
            this.addToCartButton.Text = "ADD TO CART";
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(177, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Genre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(21, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producttypeBindingSource, "productTypeName", true));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Type";
            // 
            // producttypeBindingSource
            // 
            this.producttypeBindingSource.DataSource = typeof(MusicShop.producttype);
            // 
            // discountRateLabel
            // 
            this.discountRateLabel.AutoSize = true;
            this.discountRateLabel.BackColor = System.Drawing.Color.Red;
            this.discountRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountRateLabel.ForeColor = System.Drawing.Color.White;
            this.discountRateLabel.Location = new System.Drawing.Point(335, 405);
            this.discountRateLabel.Name = "discountRateLabel";
            this.discountRateLabel.Size = new System.Drawing.Size(63, 25);
            this.discountRateLabel.TabIndex = 24;
            this.discountRateLabel.Text = "-10%";
            this.discountRateLabel.Visible = false;
            // 
            // oldPriceLabel
            // 
            this.oldPriceLabel.AutoSize = true;
            this.oldPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPriceLabel.Location = new System.Drawing.Point(252, 405);
            this.oldPriceLabel.Name = "oldPriceLabel";
            this.oldPriceLabel.Size = new System.Drawing.Size(75, 25);
            this.oldPriceLabel.TabIndex = 25;
            this.oldPriceLabel.Text = "label10";
            this.oldPriceLabel.Visible = false;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "avgRating", true));
            this.ratingLabel.Location = new System.Drawing.Point(41, 554);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(35, 13);
            this.ratingLabel.TabIndex = 26;
            this.ratingLabel.Text = "label2";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1089, 719);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.oldPriceLabel);
            this.Controls.Add(this.discountRateLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.myCommentPanel);
            this.Controls.Add(this.commentsPanel);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.creatorRoleLabel);
            this.Controls.Add(this.creatorDescriptionLabel);
            this.Controls.Add(this.creatorListBox);
            this.Controls.Add(this.coverPictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creatorBindingSource)).EndInit();
            this.myCommentPanel.ResumeLayout(false);
            this.myCommentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producttypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.ListBox creatorListBox;
        private System.Windows.Forms.Label creatorDescriptionLabel;
        private System.Windows.Forms.Label creatorRoleLabel;
        private System.Windows.Forms.BindingSource creatorBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel myCommentPanel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label loginToPostLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button postCommentButton;
        private System.Windows.Forms.RichTextBox commenctTextBox;
        private System.Windows.Forms.ComboBox gradeComboBox;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label leaveCommentLabel;
        private System.Windows.Forms.FlowLayoutPanel commentsPanel;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource producttypeBindingSource;
        private System.Windows.Forms.Label discountRateLabel;
        private System.Windows.Forms.Label oldPriceLabel;
        private System.Windows.Forms.Label ratingLabel;
    }
}