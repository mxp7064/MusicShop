using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace MusicShop
{
    public partial class CartForm : Form
    {
        private user User;
        private creditcard selectedCreditCard;
        float cartTotal;
        float discountRate;
        float totalWithDiscount;

        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            User = MusicShopPage.User;
            LoadCart();
        }

        private void emptyCartButton_Click(object sender, EventArgs e)
        {
            if (MusicShopBL.EmptyCart(User) == false) {
                MessageBox.Show("Cart can't be emptied!");
                return;
            }
            LoadCart();
        }

        public void LoadCart()
        {
            List<cartdetail> cds = MusicShopBL.GetCartDetails(User);
            List<CustomCartDetail> ccd = new List<CustomCartDetail>();
            cds.ForEach(cd => ccd.Add(new CustomCartDetail { ProductPrice = cd.productPrice, ProductName = cd.product.productName, OriginalPrice = cd.product.productPrice, DiscountRate = (cd.product.isDiscounted ?? false) ? "-" + cd.product.discountRate + "%" : "" }));
            cartGridView.DataSource = ccd;
            setCartLabels();

            List<creditcard> userCreditCards = MusicShopBL.GetUserCreditCards(User);
            if (userCreditCards.Count == 0)
            {
                paymentMethodPanel.Visible = false;
                noPaymentMethLabel.Visible = true;
            }
            else
            {
                paymentMethodPanel.Visible = true;
                noPaymentMethLabel.Visible = false;
                creditCardsComboBox.DisplayMember = "Text";
                creditCardsComboBox.ValueMember = "Value";
                creditCardsComboBox.Items.Clear();
                userCreditCards.ForEach(c => creditCardsComboBox.Items.Add(new { Text = c.creditCardHolderName + " - " + c.cardProvider, Value = c }));
            }

            float discountPoints = (float)User.discountPoints;
            if (discountPoints > 30)
                discountPoints = 30;

            discountRate = discountPoints;

            totalWithDiscount = cartTotal - (cartTotal * discountRate / 100);

            if (discountPoints <= 0 || cartTotal == 0)
            {
                originalTotalLabel.Visible = false;
                discountRateLabel.Visible = false;
            }
            else
            {
                originalTotalLabel.Visible = true;
                discountRateLabel.Visible = true;
                discountRateLabel.Text = "-" + discountRate.ToString("#.##") + "%";
                originalTotalLabel.Text = "$" + cartTotal.ToString("#.##");
            }
        }

        private void setCartLabels()
        {
            cartTotal = (float) MusicShopBL.GetCartTotal(User);
            cartTotalLabel.Text = "Total: $" + cartTotal.ToString("#.##");
            if (cartTotal == 0)
            {
                cartEmptyLabel.Visible = true;
                cartGridView.Visible = false;
                emptyCartButton.Visible = false;
                buyButton.Visible = false;
                cartTotalLabel.Visible = false;
                originalTotalLabel.Visible = false;
                discountRateLabel.Visible = false;
            }
            else
            {
                cartEmptyLabel.Visible = false;
                cartGridView.Visible = true;
                cartTotalLabel.Visible = true;
                buyButton.Visible = true;
                cartTotalLabel.Visible = true;
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (selectedCreditCard == null)
            {
                MessageBox.Show("You must select payment method!");
                return;
            }



            Console.WriteLine(totalWithDiscount);
            bool executed = MusicShopBL.ExecuteCreditCardTransaction(selectedCreditCard, totalWithDiscount, MusicShopPage.User);
            if (executed == false)
            {
                MessageBox.Show("Transaction failed, check if you have enough money on your credit card!");
                return;
            }

            DateTime dt = DateTime.Now;
            //1 bod = 1% discount s tim da mozes max 30% na jednoj kupnji dobit
            

            invoice invoice = new invoice { datePurchased = dt, total = cartTotal, discount = discountRate, totalWithDiscount = totalWithDiscount };

            MusicShopBL.CreateInvoice(invoice, MusicShopPage.User);
            List<invoicedetail> ids = MusicShopBL.FillInvoiceDetails(User, invoice, discountRate);
            
            SendEmail(invoice, ids);

            if (MusicShopBL.EmptyCart(User) == false)
            {
                MessageBox.Show("Cart can't be emptied!");
                return;
            }

            LoadCart();
            Close();

            MessageBox.Show("Thank you for your purchase! We sent you an email invoice!");
        }

        private void SendEmail(invoice invoice, List<invoicedetail> ids)
        {
            using (SmtpClient smtp = new SmtpClient())
            {
                smtp.Host = "smtp.gmail.com";
                smtp.UseDefaultCredentials = false;
                NetworkCredential netCred = new NetworkCredential("panca1234@gmail.com", "boolean = false;");
                smtp.Credentials = netCred;
                smtp.EnableSsl = true;

                using (MailMessage msg = new MailMessage("panca1234@gmail.com", User.userEmail))
                {
                    msg.Subject = "Invoice for you purchase at Music Shop";
                    StringBuilder sb = new StringBuilder();

                    string start = "<div style='font-family: Verdana, sans-serif; background-color: #33ccff; padding: 20px; width: 500px; margin-left: auto; margin-right: auto;'><p style='color: white; padding-bottom:10px; text-align: center;'>Dear " + User.userName + ",<br>This is your invoice for your purchase!</p><p><span style='width: 300px;color: white;'>Product Name</span><span style='color: white;float: right;'>Product Price</span></p>";
                    sb.AppendLine(start);
                    
                    foreach (invoicedetail id in ids)
                    {
                        sb.AppendLine("<p><span style='width: 300px;'>" + id.product.productName + "</span><span style='float: right;'>$" + id.productPrice + "</span></p>");
                    }

                    float? total = invoice.totalWithDiscount;

                    string end = "<p style='color: white; padding-left: 369px; border-top: 2px solid white; padding-top: 10px;'>TOTAL: $" + total + "</p></div>";
                    sb.AppendLine(end);

                    msg.Body = sb.ToString();
                    msg.IsBodyHtml = true;

                    try
                    {
                        smtp.Send(msg);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Email to your address could not be sent!");
                        //MessageBox.Show(ex.ToString());
                    }

                }
            }
        }

        private void manageCardsButton_Click(object sender, EventArgs e)
        {
            CardManagement cm = new CardManagement();
            cm.Tag = this;
            cm.Show();
        }

        private void creditCardsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            creditcard creditCard = ((sender as ComboBox).SelectedItem as dynamic).Value as creditcard;
            Console.WriteLine(creditCard.cardProvider);
            selectedCreditCard = creditCard;
        }
    }
}
