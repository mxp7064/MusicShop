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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        musicShopEntities db;

        private void AdminForm_Load(object sender, EventArgs e)
        {
            db = new musicShopEntities();
            db.products.Load();
            this.productsDGV.DataSource = db.products.Local.ToBindingList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.productsDGV.EndEdit();
            db.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            product prod = productsDGV.CurrentRow.DataBoundItem as product;
            ProductAdminForm paf = new ProductAdminForm();
            paf.Tag = prod;
            paf.Show();
        }
    }
}
