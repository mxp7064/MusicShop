using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace MusicShop
{
    class DBLogger
    {
        
        public static void Log(string logMessage)
        {
            try {
                using (var db = new musicShopEntities(DatabaseConnection.ConnectionString))
                {
                    int? user = null;
                    if (MusicShopPage.User != null)
                        user = MusicShopPage.User.userID;
                    db.logs.Add(new log { userID = user, timeStamp = DateTime.Now, logMessage = logMessage });
                    db.SaveChanges();
                }
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
                Console.WriteLine(logMessage.Length + " *******************");
                ExceptionLog.Log(e.Message);
            }
            
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
