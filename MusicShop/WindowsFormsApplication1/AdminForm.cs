using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
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

        private void AdminForm_Load(object sender, EventArgs ea)
        {
            CenterToScreen();
            db = new musicShopEntities(DatabaseConnection.ConnectionString);
            db.Database.Log = s => DBLogger.Log(s);
            try {
                db.products.Load();
                productsDGV.DataSource = db.products.Local.ToBindingList();

                db.genres.Load();
                genresDGV.DataSource = db.genres.Local.ToBindingList();

                db.producttypes.Load();
                productTypeDGV.DataSource = db.producttypes.Local.ToBindingList();

                db.users.Load();
                usersDGV.DataSource = db.users.Local.ToBindingList();

                db.logs.Load();
                logDGV.DataSource = db.logs.Local.ToBindingList();
            }
            catch (DbEntityValidationException e)
            {
                ExceptionLog.Log(ValidationExceptionCustomFormat(e));
            }
            catch (EntityException e)
            {
                ExceptionLog.Log(e.InnerException.Message);
            }
            catch (DbUpdateException e)
            {
                ExceptionLog.Log(DBUpdateExceptionConstructMessage(e));
            }
            catch (Exception e)
            {
                ExceptionLog.Log(e.Message);
            }
        }

        private void saveChangesProductButton_Click(object sender, EventArgs ea)
        {
            try {
                productsDGV.EndEdit();
                db.SaveChanges();
                MessageBox.Show("Changes successfully saved!");
                return;
            }
            catch (DbEntityValidationException e)
            {
                ExceptionLog.Log(ValidationExceptionCustomFormat(e));
                MessageBox.Show("Inputed the wrong format!");  
            }
            catch (EntityException e)
            {
                ExceptionLog.Log(e.InnerException.Message);
            }
            catch (DbUpdateException e)
            {
                ExceptionLog.Log(DBUpdateExceptionConstructMessage(e));
            }
            catch (Exception e)
            {
                ExceptionLog.Log(e.Message);
            }
            MessageBox.Show("Something went wrong!");
        }

        private void saveChangesGenresButton_Click(object sender, EventArgs ea)
        {
            try {
                genresDGV.EndEdit();
                db.SaveChanges();
                MessageBox.Show("Changes successfully saved!");
                return;
            }
            catch (DbEntityValidationException e)
            {
                ExceptionLog.Log(ValidationExceptionCustomFormat(e));
                MessageBox.Show("Inputed the wrong format!");
            }
            catch (EntityException e)
            {
                ExceptionLog.Log(e.InnerException.Message);
            }
            catch (DbUpdateException e)
            {
                ExceptionLog.Log(DBUpdateExceptionConstructMessage(e));
            }
            catch (Exception e)
            {
                ExceptionLog.Log(e.Message);
            }
            MessageBox.Show("Something went wrong!");
        }

        private void saveChangesTypeButton_Click(object sender, EventArgs ea)
        {
            try {
                productTypeDGV.EndEdit();
                db.SaveChanges();
                MessageBox.Show("Changes successfully saved!");
                return;
            }
            catch (DbEntityValidationException e)
            {
                ExceptionLog.Log(ValidationExceptionCustomFormat(e));
                MessageBox.Show("Inputed the wrong format!");
            }
            catch (EntityException e)
            {
                ExceptionLog.Log(e.InnerException.Message);
            }
            catch (DbUpdateException e)
            {
                ExceptionLog.Log(DBUpdateExceptionConstructMessage(e));
            }
            catch (Exception e)
            {
                ExceptionLog.Log(e.Message);
            }
            MessageBox.Show("Something went wrong!");
        }

        private void saveChangesUsersButton_Click(object sender, EventArgs ea)
        {
            try {
                usersDGV.EndEdit();
                db.SaveChanges();
                MessageBox.Show("Changes successfully saved!");
                return;
            }
            catch (DbEntityValidationException e)
            {
                ExceptionLog.Log(ValidationExceptionCustomFormat(e));
                MessageBox.Show("Inputed the wrong format!");
            }
            catch (EntityException e)
            {
                ExceptionLog.Log(e.InnerException.Message);
            }
            catch (DbUpdateException e)
            {
                ExceptionLog.Log(DBUpdateExceptionConstructMessage(e));
            }
            catch (Exception e)
            {
                ExceptionLog.Log(e.Message);
            }
            MessageBox.Show("Something went wrong!");
        }

        private void editUserCardsButton_Click(object sender, EventArgs ea)
        {
            try {
                user user = usersDGV.CurrentRow.DataBoundItem as user;

                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {

                    db.creditcards.Where(c => c.userID == user.userID).Load();
                    creditcardsDGV.DataSource = db.creditcards.Local.ToBindingList();
                }
            }
            catch (DbEntityValidationException e)
            {
                ExceptionLog.Log(ValidationExceptionCustomFormat(e));
            }
            catch (EntityException e)
            {
                ExceptionLog.Log(e.InnerException.Message);
            }
            catch (DbUpdateException e)
            {
                ExceptionLog.Log(DBUpdateExceptionConstructMessage(e));
            }
            catch (Exception e)
            {
                ExceptionLog.Log(e.Message);
            }
            
        }

        private void saveChangesCardsButton_Click(object sender, EventArgs ea)
        {
            try {
                creditcardsDGV.EndEdit();
                db.SaveChanges();
                MessageBox.Show("Changes successfully saved!");
                return;
            }
            catch (DbEntityValidationException e)
            {
                ExceptionLog.Log(ValidationExceptionCustomFormat(e));
                MessageBox.Show("Inputed the wrong format!");
            }
            catch (EntityException e)
            {
                ExceptionLog.Log(e.InnerException.Message);
            }
            catch (DbUpdateException e)
            {
                ExceptionLog.Log(DBUpdateExceptionConstructMessage(e));
            }
            catch (Exception e)
            {
                ExceptionLog.Log(e.Message);
            }
            MessageBox.Show("Something went wrong!");
        }

        private void saveChangesInvoicesButton_Click(object sender, EventArgs ea)
        {
            try {
                invoiceDGV.EndEdit();
                db.SaveChanges();
                MessageBox.Show("Changes successfully saved!");
                return;
            }
            catch (DbEntityValidationException e)
            {
                ExceptionLog.Log(ValidationExceptionCustomFormat(e));
                MessageBox.Show("Inputed the wrong format!");
            }
            catch (EntityException e)
            {
                ExceptionLog.Log(e.InnerException.Message);
            }
            catch (DbUpdateException e)
            {
                ExceptionLog.Log(DBUpdateExceptionConstructMessage(e));
            }
            catch (Exception e)
            {
                ExceptionLog.Log(e.Message);
            }
            MessageBox.Show("Something went wrong!");
        }

        private void editUserInvoicesButton_Click(object sender, EventArgs ea)
        {
            try {
                user user = usersDGV.CurrentRow.DataBoundItem as user;

                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {

                    db.invoices.Where(i => i.userID == user.userID).Load();
                    invoiceDGV.DataSource = db.invoices.Local.ToBindingList();
                }
            }
            catch (DbEntityValidationException e)
            {
                ExceptionLog.Log(ValidationExceptionCustomFormat(e));
            }
            catch (EntityException e)
            {
                ExceptionLog.Log(e.InnerException.Message);
            }
            catch (DbUpdateException e)
            {
                ExceptionLog.Log(DBUpdateExceptionConstructMessage(e));
            }
            catch (Exception e)
            {
                ExceptionLog.Log(e.Message);
            }
            
        }

        private void saveChangesLogButton_Click(object sender, EventArgs ea)
        {
            try {
                logDGV.EndEdit();
                db.SaveChanges();
                MessageBox.Show("Changes successfully saved!");
                return;
            }
            catch (DbEntityValidationException e)
            {
                ExceptionLog.Log(ValidationExceptionCustomFormat(e));
                MessageBox.Show("Inputed the wrong format!");
            }
            catch (EntityException e)
            {
                ExceptionLog.Log(e.InnerException.Message);
            }
            catch (DbUpdateException e)
            {
                ExceptionLog.Log(DBUpdateExceptionConstructMessage(e));
            }
            catch (Exception e)
            {
                ExceptionLog.Log(e.Message);
            }
            MessageBox.Show("Something went wrong!");
        }

        private void refreshLogButton_Click(object sender, EventArgs ea)
        {
            try {
                db.logs.Load();
                logDGV.DataSource = db.logs.Local.ToBindingList();
            }
            catch (DbEntityValidationException e)
            {
                ExceptionLog.Log(ValidationExceptionCustomFormat(e));
                MessageBox.Show("Inputed the wrong format!");
            }
            catch (EntityException e)
            {
                ExceptionLog.Log(e.InnerException.Message);
            }
            catch (DbUpdateException e)
            {
                ExceptionLog.Log(DBUpdateExceptionConstructMessage(e));
            }
            catch (Exception e)
            {
                ExceptionLog.Log(e.Message);
            }
            
        }

        private static string ValidationExceptionCustomFormat(DbEntityValidationException e)
        {
            var errorMessages = e.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

            var fullErrorMessage = string.Join("; ", errorMessages);

            var exceptionMessage = string.Concat(e.Message, " The validation errors are: ", fullErrorMessage);
            return exceptionMessage;
        }

        private static string DBUpdateExceptionConstructMessage(DbUpdateException e)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"DbUpdateException error details - {e?.InnerException?.InnerException?.Message}");

            foreach (var eve in e.Entries)
            {
                sb.AppendLine($"Entity of type {eve.Entity.GetType().Name} in state {eve.State} could not be updated");
            }

            return sb.ToString();
        }

        
    }
}
