using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop
{
    public class MusicShopBL
    {
        public static List<invoicedetail> GetUserProducts(user user)
        {
            List<invoicedetail> ids = new List<invoicedetail>();
            try
            {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.users.Attach(user);
                    ids = db.invoicedetails.Include("product.producttype").Where(id => id.invoice.userID == user.userID).ToList();
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
            return ids;
        }

        public static List<invoicedetail> GetInvoiceDetails(invoice invoice)
        {
            List<invoicedetail> ids = new List<invoicedetail>();
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.invoices.Attach(invoice);
                    ids = db.invoicedetails.Include("product").Where(id => id.invoiceID == invoice.invoiceID).ToList();
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
            return ids;
        }

        public static List<invoice> GetInvoices(user user)
        {
            List<invoice> invoices = new List<invoice>();
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.users.Attach(user);
                    invoices = db.invoices.Where(i => i.user.userID == user.userID).ToList();
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
            return invoices;
        }

        public static bool ExecuteCreditCardTransaction(creditcard creditCard, float amount, user user)
        {
 
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.creditcards.Attach(creditCard);
                    db.users.Attach(user);
                    if (creditCard.creditBalance > amount)
                    {
                        creditCard.creditBalance -= amount;
                        db.Entry(creditCard).State = System.Data.Entity.EntityState.Modified;

                        user.discountPoints += amount / 10;
                        db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    }
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
            return false;
        }
        public static bool UpdateCreditCard(creditcard creditCard)
        {
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.creditcards.Attach(creditCard);
                    db.Entry(creditCard).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
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
            return false;
        }

        public static bool DeleteCreditCard(creditcard creditCard)
        {
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.creditcards.Attach(creditCard);
                    db.Entry(creditCard).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    return true;
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
            return false;
        }

        public static bool InsertNewCreditCard(creditcard creditCard, user user)
        {
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.users.Attach(user);
                    creditCard.user = user;
                    db.creditcards.Add(creditCard);
                    db.SaveChanges();
                    return true;
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
            return false;
        }

        public static bool IncludeProductDetails(product product)
        {
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.products.Attach(product);
                    db.Entry(product).Reference(p => p.genre).Load();

                    db.Entry(product).Collection(p => p.ratings).Load();
                    foreach (rating r in product.ratings)
                    {
                        db.Entry(r).Reference(x => x.user).Load();
                    }

                    db.Entry(product).Collection(p => p.productcreators).Load();
                    foreach (productcreator pc in product.productcreators)
                    {
                        db.Entry(pc).Reference(x => x.creator).Load();
                    }

                    return true;
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
            return false;
        }

        public static bool EmptyCart(user user)
        {
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.users.Attach(user);
                    db.cartdetails.RemoveRange(db.cartdetails.Where(x => x.user.userID == user.userID));
                    db.SaveChanges();
                    return true;
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
            return false;
        }

        public static List<invoicedetail> FillInvoiceDetails(user user, invoice invoice, float discountPointsToDeduct)
        {
            List<invoicedetail> ids = new List<invoicedetail>();
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.users.Attach(user);
                    user.discountPoints -= discountPointsToDeduct;
                    db.Entry(user).State = System.Data.Entity.EntityState.Modified;

                    db.invoices.Attach(invoice);
                    List<cartdetail> cds = db.cartdetails.Where(x => x.user.userID == user.userID).ToList();
                    
                    foreach (cartdetail cd in cds)
                    {
                        invoicedetail id = new invoicedetail { product = cd.product, productPrice = cd.productPrice, invoice = invoice };
                        db.invoicedetails.Add(id);
                        ids.Add(id);
                    }
                    db.SaveChanges();

                    return ids;
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
            return ids;
        }

        
        public static List<string> GetProductTYpes()
        {
            List<string> productTypes = new List<string>();
            try
            {
                

                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    

                    db.Database.Log = s => DBLogger.Log(s);
                    productTypes = db.producttypes.Select(b => b.productTypeName.ToUpper()).ToList();
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

            return productTypes;
        }

        public static List<string> GetGenres()
        {
            List<string> genres = new List<string>();
            try
            {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    genres = db.genres.Select(g => g.genreName.ToUpper()).ToList();
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

            return genres;
        }

        public static List<product> GetProducts(string prodType, List<string> genres, double priceFrom, double priceTo, int page, ref int pageCount, ref int numOfRes)
        {
            List<product> products = new List<product>();
            int pageSize = 6;
            try
            {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    IQueryable<product> query = null;
                    if (prodType.Equals("ALL"))
                    {
                        query = db.products.Include("producttype").Include("genre").Where(p => p.productPrice > priceFrom && p.productPrice < priceTo).OrderBy(p => p.productID);
                    }
                    else
                    {
                        query = db.products.Include("producttype").Include("genre").Where(p => p.producttype.productTypeName.Equals(prodType) && (genres.Contains(p.genre.genreName) || p.genre == null) && (p.productPrice > priceFrom && p.productPrice < priceTo)).OrderBy(p => p.productID);
                    }

                    pageCount = (int)Math.Ceiling((double)query.Count() / pageSize);
                    numOfRes = query.Count();
                    products = query.Skip(pageSize * (page - 1)).Take(pageSize).ToList();
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
            return products;
        }

        public static List<user> GetUsers()
        {
            List<user> users = new List<user>();
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    users = db.users.ToList();
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
            return users;
        }

        public static List<creditcard> GetUserCreditCards(user user)
        {
            List<creditcard> ccs = new List<creditcard>();
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.users.Attach(user);
                    ccs = db.creditcards.Where(c => c.userID == user.userID).ToList();
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
            return ccs;
        }

        public static List<cartdetail> GetCartDetails(user user)
        {
            List<cartdetail> cds = new List<cartdetail>();
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.users.Attach(user);
                    cds = db.cartdetails.Include("product").Where(x => x.user.userID == user.userID).ToList();
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
            return cds;
        }

        public static bool RegisterNewUser(string username, string pass, DateTime dob, string email, ref user newUser)
        {
            //Hash
            var hashedPassword = SecurePasswordHasher.Hash(pass);
    
            newUser = new user { userName = username, password = hashedPassword, dateOfBirth = dob, userEmail = email, accessLevel = "general", discountPoints = 20};

            try
            {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.users.Add(newUser);
                    db.SaveChanges();
                    return true;
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
            return false;
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

        public static bool InsertProductIntoCart(product product, user user)
        {
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.users.Attach(user);
                    product prod = db.products.Where(p => p.productID == product.productID).FirstOrDefault();

                    int count = db.cartdetails.Where(c => c.user.userID == user.userID && c.product.productID == prod.productID).Count();
                    if (count > 0)
                        return true;

                    
                    float? prodPrice = prod.productPrice;
                    if (prod.isDiscounted == true)
                    {
                        float? disRate = prod.discountRate;
                        prodPrice = prodPrice - (prodPrice * disRate / 100);
                    }
                    //db.Entry(prod).State = System.Data.Entity.EntityState.Unchanged;
                    db.cartdetails.Add(new cartdetail { product = prod, user = user, productPrice = prodPrice });
                    db.SaveChanges();

                    return false;
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
            return false;
        }

        public static bool InsertNewRating(rating rating, user user, product prod)
        {
            try
            {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.users.Attach(user);
                    db.products.Attach(prod);
                    rating.user = user;
                    rating.product = prod;
                    db.ratings.Add(rating);
                    db.SaveChanges();
                    return true;
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
            return false;
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

        public static void CreateInvoice(invoice invoice, user user)
        {
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.users.Attach(user);
                    invoice.user = user;
                    db.invoices.Add(invoice);
                    db.SaveChanges();
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

        public static float GetCartTotal(user user)
        {
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    db.Database.Log = s => DBLogger.Log(s);
                    db.users.Attach(user);
                    var query = db.cartdetails.Where(x => x.user.userID == user.userID).Select(x => x.productPrice).Sum();
                    if (query == null)
                        return 0;
                    else
                        return (float)query;
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
            return 0;
        }
    }

    
}
