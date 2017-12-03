using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace MusicShop
{
    public partial class DatabaseConnection : Form
    {
        public static string ConnectionString;

        public DatabaseConnection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = serverTB.Text;
            string user = userTB.Text;
            string password = passwordTB.Text;
            string database = databaseTB.Text;

            var entityBuilder = new EntityConnectionStringBuilder();

            entityBuilder.ProviderConnectionString = "server=" + server + ";user id=" + user + ";password=" + password + ";persistsecurityinfo=True;database=" + database;
            entityBuilder.Provider = "MySql.Data.MySqlClient";
            entityBuilder.Metadata = @"res://*/MusicShopModel.csdl|res://*/MusicShopModel.ssdl|res://*/MusicShopModel.msl";
            ConnectionString = entityBuilder.ConnectionString;

            MusicShopPage msp = new MusicShopPage();
            msp.Show();
            Hide();
            msp.FormClosing += delegate { Application.Exit(); };
        }

        private void DatabaseConnection_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
