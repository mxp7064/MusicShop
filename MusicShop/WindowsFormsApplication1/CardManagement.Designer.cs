namespace MusicShop
{
    partial class CardManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.cardsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.creditCardNumTextBox = new System.Windows.Forms.TextBox();
            this.creditCardCvvTextBox = new System.Windows.Forms.TextBox();
            this.cardProviderTextBox = new System.Windows.Forms.TextBox();
            this.creditCardHolderTextBox = new System.Windows.Forms.TextBox();
            this.expirationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.updateCreditCardButton = new System.Windows.Forms.Button();
            this.addCreditCardButton = new System.Windows.Forms.Button();
            this.updateAddCreditCardGroupBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addCardButton = new System.Windows.Forms.Button();
            this.updateAddCreditCardGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your credit cards";
            // 
            // cardsPanel
            // 
            this.cardsPanel.AutoScroll = true;
            this.cardsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardsPanel.Location = new System.Drawing.Point(28, 61);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Size = new System.Drawing.Size(550, 142);
            this.cardsPanel.TabIndex = 1;
            // 
            // creditCardNumTextBox
            // 
            this.creditCardNumTextBox.Location = new System.Drawing.Point(15, 61);
            this.creditCardNumTextBox.Name = "creditCardNumTextBox";
            this.creditCardNumTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditCardNumTextBox.TabIndex = 3;
            // 
            // creditCardCvvTextBox
            // 
            this.creditCardCvvTextBox.Location = new System.Drawing.Point(121, 61);
            this.creditCardCvvTextBox.Name = "creditCardCvvTextBox";
            this.creditCardCvvTextBox.Size = new System.Drawing.Size(32, 20);
            this.creditCardCvvTextBox.TabIndex = 4;
            // 
            // cardProviderTextBox
            // 
            this.cardProviderTextBox.Location = new System.Drawing.Point(170, 61);
            this.cardProviderTextBox.Name = "cardProviderTextBox";
            this.cardProviderTextBox.Size = new System.Drawing.Size(100, 20);
            this.cardProviderTextBox.TabIndex = 5;
            // 
            // creditCardHolderTextBox
            // 
            this.creditCardHolderTextBox.Location = new System.Drawing.Point(288, 61);
            this.creditCardHolderTextBox.Name = "creditCardHolderTextBox";
            this.creditCardHolderTextBox.Size = new System.Drawing.Size(129, 20);
            this.creditCardHolderTextBox.TabIndex = 6;
            // 
            // expirationDatePicker
            // 
            this.expirationDatePicker.CustomFormat = "";
            this.expirationDatePicker.Location = new System.Drawing.Point(433, 61);
            this.expirationDatePicker.Name = "expirationDatePicker";
            this.expirationDatePicker.ShowUpDown = true;
            this.expirationDatePicker.Size = new System.Drawing.Size(106, 20);
            this.expirationDatePicker.TabIndex = 7;
            this.expirationDatePicker.Value = new System.DateTime(2017, 11, 1, 23, 59, 0, 0);
            // 
            // updateCreditCardButton
            // 
            this.updateCreditCardButton.Location = new System.Drawing.Point(15, 93);
            this.updateCreditCardButton.Name = "updateCreditCardButton";
            this.updateCreditCardButton.Size = new System.Drawing.Size(75, 23);
            this.updateCreditCardButton.TabIndex = 8;
            this.updateCreditCardButton.Text = "Save";
            this.updateCreditCardButton.UseVisualStyleBackColor = true;
            this.updateCreditCardButton.Click += new System.EventHandler(this.updateCreditCardButton_Click);
            // 
            // addCreditCardButton
            // 
            this.addCreditCardButton.Location = new System.Drawing.Point(15, 93);
            this.addCreditCardButton.Name = "addCreditCardButton";
            this.addCreditCardButton.Size = new System.Drawing.Size(75, 23);
            this.addCreditCardButton.TabIndex = 9;
            this.addCreditCardButton.Text = "Add card";
            this.addCreditCardButton.UseVisualStyleBackColor = true;
            this.addCreditCardButton.Click += new System.EventHandler(this.addCreditCardButton_Click);
            // 
            // updateAddCreditCardGroupBox
            // 
            this.updateAddCreditCardGroupBox.Controls.Add(this.label6);
            this.updateAddCreditCardGroupBox.Controls.Add(this.label5);
            this.updateAddCreditCardGroupBox.Controls.Add(this.label4);
            this.updateAddCreditCardGroupBox.Controls.Add(this.label3);
            this.updateAddCreditCardGroupBox.Controls.Add(this.label2);
            this.updateAddCreditCardGroupBox.Controls.Add(this.cancelButton);
            this.updateAddCreditCardGroupBox.Controls.Add(this.creditCardNumTextBox);
            this.updateAddCreditCardGroupBox.Controls.Add(this.addCreditCardButton);
            this.updateAddCreditCardGroupBox.Controls.Add(this.creditCardCvvTextBox);
            this.updateAddCreditCardGroupBox.Controls.Add(this.updateCreditCardButton);
            this.updateAddCreditCardGroupBox.Controls.Add(this.cardProviderTextBox);
            this.updateAddCreditCardGroupBox.Controls.Add(this.expirationDatePicker);
            this.updateAddCreditCardGroupBox.Controls.Add(this.creditCardHolderTextBox);
            this.updateAddCreditCardGroupBox.Location = new System.Drawing.Point(28, 229);
            this.updateAddCreditCardGroupBox.Name = "updateAddCreditCardGroupBox";
            this.updateAddCreditCardGroupBox.Size = new System.Drawing.Size(550, 127);
            this.updateAddCreditCardGroupBox.TabIndex = 10;
            this.updateAddCreditCardGroupBox.TabStop = false;
            this.updateAddCreditCardGroupBox.Text = "groupBox1";
            this.updateAddCreditCardGroupBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Expiration date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Card Holder Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Card Provider";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "CVV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Card Number";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelButton.Location = new System.Drawing.Point(522, 14);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(20, 20);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addCardButton
            // 
            this.addCardButton.Location = new System.Drawing.Point(43, 229);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(114, 23);
            this.addCardButton.TabIndex = 11;
            this.addCardButton.Text = "Add new card";
            this.addCardButton.UseVisualStyleBackColor = true;
            this.addCardButton.Click += new System.EventHandler(this.addCardButton_Click);
            // 
            // CardManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 462);
            this.Controls.Add(this.addCardButton);
            this.Controls.Add(this.updateAddCreditCardGroupBox);
            this.Controls.Add(this.cardsPanel);
            this.Controls.Add(this.label1);
            this.Name = "CardManagement";
            this.Text = "Card Management";
            this.Load += new System.EventHandler(this.AccountManagement_Load);
            this.updateAddCreditCardGroupBox.ResumeLayout(false);
            this.updateAddCreditCardGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel cardsPanel;
        private System.Windows.Forms.TextBox creditCardNumTextBox;
        private System.Windows.Forms.TextBox creditCardCvvTextBox;
        private System.Windows.Forms.TextBox cardProviderTextBox;
        private System.Windows.Forms.TextBox creditCardHolderTextBox;
        private System.Windows.Forms.DateTimePicker expirationDatePicker;
        private System.Windows.Forms.Button updateCreditCardButton;
        private System.Windows.Forms.Button addCreditCardButton;
        private System.Windows.Forms.GroupBox updateAddCreditCardGroupBox;
        private System.Windows.Forms.Button addCardButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}