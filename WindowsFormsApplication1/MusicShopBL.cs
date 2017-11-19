using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop
{
    public class MusicShopBL
    {
        
        public static void IncludeProductDetails(product product)
        {
            using (var db = new musicShopEntities())
            {
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
            }
        }

        public static void EmptyCart(user user)
        {
            using (var db = new musicShopEntities())
            {
                db.cartdetails.RemoveRange(db.cartdetails.Where(x => x.user.userID == user.userID));
                db.SaveChanges();
            }
        }

        public static List<invoicedetail> FillInvoiceDetails(user user, invoice invoice)
        {
            using (var db = new musicShopEntities())
            {
                List<cartdetail> cds = db.cartdetails.Where(x => x.user.userID == user.userID).ToList();
                List<invoicedetail> ids = new List<invoicedetail>();
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

        public static List<string> GetProductTYpes()
        {
            using (var db = new musicShopEntities())
            {
                return db.producttypes.Select(b => b.productTypeName.ToUpper()).ToList();
            }
        }

        public static List<string> GetGenres()
        {
            using (var db = new musicShopEntities())
            {
                return db.genres.Select(g => g.genreName.ToUpper()).ToList();
            }
        }

        public static List<product> GetProducts(string prodType, List<string> genres, double priceFrom, double priceTo, int page, out int pageCount, out int numOfRes)
        {
            int pageSize = 6;
 
            using (var db = new musicShopEntities())
            {
                IQueryable<product> query = null;
                if (prodType.Equals("ALL"))
                {
                    query = db.products.Include("producttype").Include("genre").Where(p => p.productPrice > priceFrom && p.productPrice < priceTo).OrderBy(p => p.productID);    
                }
                else
                {
                    query = db.products.Include("producttype").Include("genre").Where(p => p.producttype.productTypeName.Equals(prodType) && (genres.Contains(p.genre.genreName) || p.genre == null)&& (p.productPrice > priceFrom && p.productPrice < priceTo)).OrderBy(p => p.productID);
                }

                pageCount = (int) Math.Ceiling((double)query.Count()/pageSize);
                numOfRes = query.Count();
                return query.Skip(pageSize * (page - 1)).Take(pageSize).ToList();
            }
        }

        public static List<user> GetUsers()
        {
            using (var db = new musicShopEntities())
            {
                return db.users.ToList();
            }
        }
        /*
        public static List<product> GetAllProducts()
        {
            using (var db = new musicShopEntities())
            {
                return db.products.ToList();
            }
        }*/

        public static List<cartdetail> GetCartDetails(user user)
        {
            using (var db = new musicShopEntities())
            {
                return db.cartdetails.Include("product").Where(x => x.user.userID == user.userID).ToList();
            }
        }

        public static user RegisterNewUser(string username, string pass, DateTime dob, string email)
        {
            //Hash
            var hashedPassword = SecurePasswordHasher.Hash(pass);
    
            var newUser = new user { userName = username, password = hashedPassword, dateOfBirth = dob, userEmail = email, accessLevel = "general", discountPoints = 0, subscriptionActive = false};

            using (var db = new musicShopEntities())
            {
                db.users.Add(newUser);
                db.SaveChanges();
                return newUser;
            }
        }

        public static void InsertProductIntoCart(product prod, user user)
        {
            using (var db = new musicShopEntities())
            {
                float? prodPrice = prod.productPrice;
                if (prod.isDiscounted == true)
                {
                    float? disRate = prod.discountRate;
                    prodPrice = prodPrice - (prodPrice * disRate/100);
                }

                db.users.Attach(user);
                //db.Entry(user).Collection(u => u.carts).Load();
                //Console.WriteLine(user.carts.Count + "******************");

                db.cartdetails.Add(new cartdetail { product = prod, user = user, productPrice = prodPrice });
                db.SaveChanges();
            }
        }

        public static void InsertNewRating(rating rating)
        {
            using (var db = new musicShopEntities())
            {
                db.ratings.Add(rating);
                db.SaveChanges();
            }
        }

        public static void CreateInvoice(invoice invoice)
        {
            using (var db = new musicShopEntities())
            {
                db.invoices.Add(invoice);
                db.SaveChanges();
            }
        }

        public static float? GetCartTotal(user user)
        {
            using (var db = new musicShopEntities())
            {
                return db.cartdetails.Where(x => x.user.userID == user.userID).Select(x => x.productPrice).Sum();
            }
        }
    }

    
}
