using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1;

namespace MusicShop
{
    class ExceptionLog
    {
        public static void Log(string exceptionLog)
        {
            using (System.IO.StreamWriter file =
            File.AppendText(System.IO.Path.GetFullPath(@"..\..\") + "log.txt"))
            {
                string user = "none";
                if (MusicShopPage.User != null)
                    user = MusicShopPage.User.userID.ToString();
                file.WriteLine("Time Stamp: " + DateTime.Now + " | User that was logged in(id): " + user + " | Exception message: " + exceptionLog);
            }
        }
    }
}
