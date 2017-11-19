namespace WindowsFormsApplication1
{
    partial class MusicShopPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicShopPage));
            this.bigPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.productTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.genreCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.priceRangeToTB = new System.Windows.Forms.TextBox();
            this.priceRangeFromTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.noResultsLabel = new System.Windows.Forms.Label();
            this.cartButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.loggedInLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.priceRangeButton = new System.Windows.Forms.Button();
            this.pageTextBox = new System.Windows.Forms.TextBox();
            this.leftArrowPic = new System.Windows.Forms.PictureBox();
            this.rightArrowPic = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lastPageLabel = new System.Windows.Forms.Label();
            this.numOfResLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrowPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrowPic)).BeginInit();
            this.SuspendLayout();
            // 
            // bigPanel
            // 
            this.bigPanel.AutoSize = true;
            this.bigPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.bigPanel.Location = new System.Drawing.Point(14, 140);
            this.bigPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bigPanel.Name = "bigPanel";
            this.bigPanel.Size = new System.Drawing.Size(1260, 32);
            this.bigPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(547, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Music Shop";
            // 
            // productTypeComboBox
            // 
            this.productTypeComboBox.FormattingEnabled = true;
            this.productTypeComboBox.Location = new System.Drawing.Point(14, 33);
            this.productTypeComboBox.Name = "productTypeComboBox";
            this.productTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.productTypeComboBox.TabIndex = 5;
            this.productTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.productTypeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Genre";
            // 
            // genreCheckedListBox
            // 
            this.genreCheckedListBox.BackColor = System.Drawing.SystemColors.Control;
            this.genreCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genreCheckedListBox.CheckOnClick = true;
            this.genreCheckedListBox.ColumnWidth = 85;
            this.genreCheckedListBox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreCheckedListBox.FormattingEnabled = true;
            this.genreCheckedListBox.Location = new System.Drawing.Point(168, 33);
            this.genreCheckedListBox.MultiColumn = true;
            this.genreCheckedListBox.Name = "genreCheckedListBox";
            this.genreCheckedListBox.Size = new System.Drawing.Size(339, 36);
            this.genreCheckedListBox.TabIndex = 9;
            this.genreCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.genreCheckedListBox_ItemCheck);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "TO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "FROM";
            // 
            // priceRangeToTB
            // 
            this.priceRangeToTB.Location = new System.Drawing.Point(597, 34);
            this.priceRangeToTB.Name = "priceRangeToTB";
            this.priceRangeToTB.Size = new System.Drawing.Size(69, 20);
            this.priceRangeToTB.TabIndex = 17;
            this.priceRangeToTB.Text = "270";
            // 
            // priceRangeFromTB
            // 
            this.priceRangeFromTB.Location = new System.Drawing.Point(513, 34);
            this.priceRangeFromTB.Name = "priceRangeFromTB";
            this.priceRangeFromTB.Size = new System.Drawing.Size(68, 20);
            this.priceRangeFromTB.TabIndex = 16;
            this.priceRangeFromTB.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Price Range";
            // 
            // noResultsLabel
            // 
            this.noResultsLabel.AutoSize = true;
            this.noResultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noResultsLabel.Location = new System.Drawing.Point(480, 189);
            this.noResultsLabel.Name = "noResultsLabel";
            this.noResultsLabel.Size = new System.Drawing.Size(381, 25);
            this.noResultsLabel.TabIndex = 0;
            this.noResultsLabel.Text = "No products matching your criteria!";
            // 
            // cartButton
            // 
            this.cartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartButton.ForeColor = System.Drawing.Color.White;
            this.cartButton.Location = new System.Drawing.Point(1115, 28);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(75, 30);
            this.cartButton.TabIndex = 21;
            this.cartButton.TabStop = false;
            this.cartButton.Text = "Cart";
            this.cartButton.UseVisualStyleBackColor = false;
            this.cartButton.Visible = false;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.adminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.ForeColor = System.Drawing.Color.White;
            this.adminButton.Location = new System.Drawing.Point(1206, 28);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(75, 30);
            this.adminButton.TabIndex = 22;
            this.adminButton.TabStop = false;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Visible = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // loggedInLabel
            // 
            this.loggedInLabel.AutoSize = true;
            this.loggedInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedInLabel.Location = new System.Drawing.Point(1031, 69);
            this.loggedInLabel.Name = "loggedInLabel";
            this.loggedInLabel.Size = new System.Drawing.Size(45, 16);
            this.loggedInLabel.TabIndex = 23;
            this.loggedInLabel.Text = "label2";
            this.loggedInLabel.Visible = false;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(1115, 28);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 30);
            this.registerButton.TabIndex = 24;
            this.registerButton.TabStop = false;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(1022, 28);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 30);
            this.loginButton.TabIndex = 25;
            this.loginButton.TabStop = false;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Product Type";
            // 
            // priceRangeButton
            // 
            this.priceRangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.priceRangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceRangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.priceRangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceRangeButton.ForeColor = System.Drawing.Color.White;
            this.priceRangeButton.Location = new System.Drawing.Point(685, 28);
            this.priceRangeButton.Name = "priceRangeButton";
            this.priceRangeButton.Size = new System.Drawing.Size(75, 30);
            this.priceRangeButton.TabIndex = 27;
            this.priceRangeButton.TabStop = false;
            this.priceRangeButton.Text = "Apply";
            this.priceRangeButton.UseVisualStyleBackColor = false;
            this.priceRangeButton.Click += new System.EventHandler(this.priceRangeButton_Click);
            // 
            // pageTextBox
            // 
            this.pageTextBox.Enabled = false;
            this.pageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pageTextBox.Location = new System.Drawing.Point(91, 99);
            this.pageTextBox.Name = "pageTextBox";
            this.pageTextBox.Size = new System.Drawing.Size(25, 20);
            this.pageTextBox.TabIndex = 28;
            this.pageTextBox.Text = "1";
            this.pageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // leftArrowPic
            // 
            this.leftArrowPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftArrowPic.Image = ((System.Drawing.Image)(resources.GetObject("leftArrowPic.Image")));
            this.leftArrowPic.Location = new System.Drawing.Point(32, 93);
            this.leftArrowPic.Name = "leftArrowPic";
            this.leftArrowPic.Size = new System.Drawing.Size(30, 30);
            this.leftArrowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftArrowPic.TabIndex = 29;
            this.leftArrowPic.TabStop = false;
            this.leftArrowPic.Click += new System.EventHandler(this.leftArrowPic_Click);
            // 
            // rightArrowPic
            // 
            this.rightArrowPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightArrowPic.Image = ((System.Drawing.Image)(resources.GetObject("rightArrowPic.Image")));
            this.rightArrowPic.Location = new System.Drawing.Point(145, 93);
            this.rightArrowPic.Name = "rightArrowPic";
            this.rightArrowPic.Size = new System.Drawing.Size(30, 30);
            this.rightArrowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightArrowPic.TabIndex = 30;
            this.rightArrowPic.TabStop = false;
            this.rightArrowPic.Click += new System.EventHandler(this.rightArrowPic_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Page";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "1...";
            // 
            // lastPageLabel
            // 
            this.lastPageLabel.AutoSize = true;
            this.lastPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastPageLabel.Location = new System.Drawing.Point(116, 102);
            this.lastPageLabel.Name = "lastPageLabel";
            this.lastPageLabel.Size = new System.Drawing.Size(27, 15);
            this.lastPageLabel.TabIndex = 33;
            this.lastPageLabel.Text = "...5";
            // 
            // numOfResLabel
            // 
            this.numOfResLabel.AutoSize = true;
            this.numOfResLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfResLabel.Location = new System.Drawing.Point(196, 104);
            this.numOfResLabel.Name = "numOfResLabel";
            this.numOfResLabel.Size = new System.Drawing.Size(132, 16);
            this.numOfResLabel.TabIndex = 34;
            this.numOfResLabel.Text = "Number of results: 15";
            // 
            // MusicShopPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1301, 556);
            this.Controls.Add(this.numOfResLabel);
            this.Controls.Add(this.lastPageLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rightArrowPic);
            this.Controls.Add(this.leftArrowPic);
            this.Controls.Add(this.pageTextBox);
            this.Controls.Add(this.priceRangeButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loggedInLabel);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.noResultsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceRangeToTB);
            this.Controls.Add(this.priceRangeFromTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.genreCheckedListBox);
            this.Controls.Add(this.productTypeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigPanel);
            this.Name = "MusicShopPage";
            this.Text = "Music Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leftArrowPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrowPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel bigPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox genreCheckedListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox priceRangeToTB;
        private System.Windows.Forms.TextBox priceRangeFromTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label noResultsLabel;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Label loggedInLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button priceRangeButton;
        private System.Windows.Forms.TextBox pageTextBox;
        private System.Windows.Forms.PictureBox leftArrowPic;
        private System.Windows.Forms.PictureBox rightArrowPic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lastPageLabel;
        private System.Windows.Forms.Label numOfResLabel;
    }
}

