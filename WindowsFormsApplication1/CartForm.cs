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
    public partial class CartForm : Form
    {
        private user User;

        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            User = MusicShopPage.User;
            MyLoad();
        }

        private void emptyCartButton_Click(object sender, EventArgs e)
        {
            MusicShopBL.EmptyCart(User);
            MyLoad();
        }

        private void MyLoad()
        {
            List<cartdetail> cds = MusicShopBL.GetCartDetails(User);
            List<CustomCartDetail> ccd = new List<CustomCartDetail>();
            cds.ForEach(cd => ccd.Add(new CustomCartDetail { ProductPrice = cd.productPrice, ProductName = cd.product.productName, OriginalPrice = cd.product.productPrice, DiscountRate = (cd.product.isDiscounted ?? false) ? "-" + cd.product.discountRate + "%" : "" }));
            cartGridView.DataSource = ccd;
            setCartLabels();
        }

        private void setCartLabels()
        {
            float? cartTotal = MusicShopBL.GetCartTotal(User);
            cartTotalLabel.Text = "Total: $" + cartTotal;
            if (cartTotal == 0)
            {
                cartEmptyLabel.Visible = true;
                cartGridView.Visible = false;
                emptyCartButton.Visible = false;
                buyButton.Visible = false;
                cartTotalLabel.Visible = false;
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
            MyLoad();
            Close();

            DateTime dt = DateTime.Now;
            //1 bod = 1% discount s tim da mozes max 30% na jednoj kupnji dobit
            float? discountPoints = User.discountPoints;
            if (discountPoints > 30)
                discountPoints = 30;
            float? total = MusicShopBL.GetCartTotal(MusicShopPage.User);
            invoice invoice = new invoice { user = MusicShopPage.User , datePurchased = dt, total = total, discount = discountPoints, totalWithDiscount = total - (total * discountPoints / 100)};

            MusicShopBL.CreateInvoice(invoice);
            List<invoicedetail> ids = MusicShopBL.FillInvoiceDetails(User, invoice);

            User.discountPoints -= discountPoints;

            SendEmail();
            MusicShopBL.EmptyCart(User); 
            MessageBox.Show("Thank you for your purchase! We sent you an email invoice!");
        }

        private void SendEmail()
        {
        }
    }
}
