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
    public partial class AccountManagement : Form
    {
        public AccountManagement()
        {
            InitializeComponent();
        }

        private void AccountManagement_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            invoiceDataGridView.DataSource = MusicShopBL.GetInvoices(MusicShopPage.User);
        }

        private void showInvoiceDetails_Click(object sender, EventArgs e)
        {
            invoice invoice = invoiceDataGridView.CurrentRow.DataBoundItem as invoice;

            List<CustomInvoiceDetail> cid = new List<CustomInvoiceDetail>();
            List<invoicedetail> id = MusicShopBL.GetInvoiceDetails(invoice);
            id.ForEach(x => cid.Add(new CustomInvoiceDetail(x.productPrice, x.product)));
            invoiceDetailsGridView.DataSource = cid;
        }

        private void manageCardsButton_Click(object sender, EventArgs e)
        {
            CardManagement cm = new CardManagement();
            cm.Show();
        }

        private void playUserProductsButton_Click(object sender, EventArgs e)
        {
            PlayUserProductsForm pupf = new PlayUserProductsForm();
            pupf.Show();
        }
    }
}
