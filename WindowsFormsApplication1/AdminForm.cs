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
            productsDGV.DataSource = db.products.Local.ToBindingList();

            db.genres.Load();
            genresDGV.DataSource = db.genres.Local.ToBindingList();

            db.producttypes.Load();
            productTypeDGV.DataSource = db.producttypes.Local.ToBindingList();

            db.users.Load();
            usersDGV.DataSource = db.users.Local.ToBindingList();

        }

        private void saveChangesProductButton_Click(object sender, EventArgs e)
        {
            productsDGV.EndEdit();
            db.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            product prod = productsDGV.CurrentRow.DataBoundItem as product;
            ProductAdminForm paf = new ProductAdminForm();
            paf.Tag = prod;
            paf.Show();
        }

        private void saveChangesGenresButton_Click(object sender, EventArgs e)
        {
            genresDGV.EndEdit();
            db.SaveChanges();
        }

        private void saveChangesTypeButton_Click(object sender, EventArgs e)
        {
            productTypeDGV.EndEdit();
            db.SaveChanges();
        }

        private void saveChangesUsersButton_Click(object sender, EventArgs e)
        {
            usersDGV.EndEdit();
            db.SaveChanges();
        }

        private void editUserCardsButton_Click(object sender, EventArgs e)
        {
            user user = usersDGV.CurrentRow.DataBoundItem as user;

            using (var db = new musicShopEntities())
            {

                db.creditcards.Where(c => c.userID == user.userID).Load();
                creditcardsDGV.DataSource = db.creditcards.Local.ToBindingList();
            }
        }

        private void saveChangesCardsButton_Click(object sender, EventArgs e)
        {
            creditcardsDGV.EndEdit();
            db.SaveChanges();
        }
    }
}
