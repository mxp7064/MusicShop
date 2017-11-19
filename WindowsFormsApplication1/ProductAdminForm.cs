using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicShop
{
    public partial class ProductAdminForm : Form
    {
        public ProductAdminForm()
        {
            InitializeComponent();
        }

        musicShopEntities db;

        private void ProductAdminForm_Load(object sender, EventArgs e)
        {
            db = new musicShopEntities();
            product prod = this.Tag as product;
            db.ratings.Where(r => r.product.productID == prod.productID).Load();
            this.productRatingsDGV.DataSource = db.ratings.Local.ToBindingList();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.productRatingsDGV.EndEdit();
            db.SaveChanges();
        }
    }
}
