using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace MusicShop
{
    public partial class CardManagement : Form
    {
        private creditcard creditCard;

        public CardManagement()
        {
            InitializeComponent();
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            expirationDatePicker.Format = DateTimePickerFormat.Custom;
            expirationDatePicker.CustomFormat = "MM-yyyy";
            expirationDatePicker.ShowUpDown = true;

            LoadCards();
        }

        private void LoadCards()
        {
            List<creditcard> creditCards = MusicShopBL.GetUserCreditCards(MusicShopPage.User);
            cardsPanel.Controls.Clear();
            if (this.Tag != null)
                (this.Tag as CartForm).LoadCart();
            foreach (creditcard c in creditCards)
            {
                TableLayoutPanel ccPanel = new TableLayoutPanel();
                ccPanel.Size = new System.Drawing.Size(500, 40);
                ccPanel.RowCount = 1;
                ccPanel.ColumnCount = 5;
                ccPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                ccPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
                ccPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
                ccPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
                ccPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));

                Label cardProviderLabel = new Label();
                cardProviderLabel.Text = c.cardProvider;
                cardProviderLabel.TextAlign = ContentAlignment.MiddleCenter;
                ccPanel.Controls.Add(cardProviderLabel, 0, 0);

                Label cardHolderLabel = new Label();
                cardHolderLabel.Text = c.creditCardHolderName;
                cardHolderLabel.TextAlign = ContentAlignment.MiddleCenter;
                ccPanel.Controls.Add(cardHolderLabel, 1, 0);

                Label expireDateLabel = new Label();
                expireDateLabel.Text = c.expirationDate.ToString("MM-yyyy");
                expireDateLabel.TextAlign = ContentAlignment.MiddleCenter;
                ccPanel.Controls.Add(expireDateLabel, 2, 0);

                Button updateButton = new Button { Margin = new Padding(0) };
                updateButton.Tag = c;
                updateButton.Click += new System.EventHandler(updateClick);
                updateButton.Text = "UPDATE";
                ccPanel.Controls.Add(updateButton, 3, 0);

                Button deleteButton = new Button { Margin = new Padding(0) };
                deleteButton.Text = "DELETE";
                deleteButton.Tag = c;
                deleteButton.Click += new System.EventHandler(deleteClick);
                ccPanel.Controls.Add(deleteButton, 4, 0);

                cardsPanel.Controls.Add(ccPanel);
            }
        }
        private void updateClick(object sender, EventArgs e)
        {
            addCardButton.Visible = false;
            updateAddCreditCardGroupBox.Visible = true;
            updateAddCreditCardGroupBox.Text = "UPDATE CREDIT CARD";
            updateCreditCardButton.Visible = true;
            addCreditCardButton.Visible = false;
            Button updateButton = sender as Button;
            creditCard = updateButton.Tag as creditcard;
        }

        private void deleteClick(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this card?", "Card will be deleted!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Button deleteButton = sender as Button;
                creditcard creditCardToDelete = deleteButton.Tag as creditcard;
                MusicShopBL.DeleteCreditCard(creditCardToDelete);
                MessageBox.Show("Credit card deleted");
                cancelButton_Click(null, EventArgs.Empty);
                LoadCards();
            }
            
            
        }

        private void updateCreditCardButton_Click(object sender, EventArgs e)
        {
            creditCard.creditCardNumber = Int32.Parse(creditCardNumTextBox.Text);
            creditCard.creditCardCVV = Int32.Parse(creditCardCvvTextBox.Text);
            creditCard.cardProvider = cardProviderTextBox.Text;
            creditCard.creditCardHolderName = creditCardHolderTextBox.Text;
            creditCard.expirationDate = System.Convert.ToDateTime(expirationDatePicker.Value.ToString("yyyy-MM-dd"));

            MusicShopBL.UpdateCreditCard(creditCard);
            MessageBox.Show("Credit card sucessfully updated!");
            cancelButton_Click(null, EventArgs.Empty);
            LoadCards();
        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            addCardButton.Visible = false;
            updateAddCreditCardGroupBox.Visible = true;
            updateAddCreditCardGroupBox.Text = "ADD CREDIT CARD";
            updateCreditCardButton.Visible = false;
            addCreditCardButton.Visible = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            updateAddCreditCardGroupBox.Visible = false;
            addCardButton.Visible = true;
            creditCardNumTextBox.Text = "";
            creditCardCvvTextBox.Text = "";
            creditCardHolderTextBox.Text = "";
            creditCardNumTextBox.Text = "";
            cardProviderTextBox.Text = "";
        }

        private void addCreditCardButton_Click(object sender, EventArgs e)
        {
            creditcard cc = new creditcard();
            cc.creditCardNumber = Int32.Parse(creditCardNumTextBox.Text);
            cc.creditCardCVV = Int32.Parse(creditCardCvvTextBox.Text);
            cc.cardProvider = cardProviderTextBox.Text;
            cc.creditCardHolderName = creditCardHolderTextBox.Text;
            cc.expirationDate = System.Convert.ToDateTime(expirationDatePicker.Value.ToString("yyyy-MM-dd"));
            cc.creditBalance = 300;

            MusicShopBL.InsertNewCreditCard(cc, MusicShopPage.User);
            MessageBox.Show("Credit card sucessfully added!");
            cancelButton_Click(null, EventArgs.Empty);
            LoadCards();
        }
    }
}
