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
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            user newUser = null;
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            List<user> users = MusicShopBL.GetUsers();

            bool isMatch = false;
            foreach (user user in users)
            {
                if (user.userName == username && SecurePasswordHasher.Verify(password, user.password))
                {
                    newUser = user;
                    isMatch = true;
                }
            }

            if (isMatch)
            {
                MusicShopPage.IsLoggedIn = true;
                MusicShopPage.User = newUser;
                MusicShopPage.msp.SetButtons();
                if (this.Tag != null)
                    (this.Tag as ProductForm).MyLoad();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password wrong!");
            }
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
